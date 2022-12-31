namespace Rename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Folder_Open(object sender, EventArgs e)
        {
            TextBox tb;
            string selected_path = String.Empty;

            if (sender == this.bt1)
            {
                selected_path = Folder_Open_Dialog("�R�s�[�����w�肵�Ă�������",false);
                tb = this.tb1;
            }
            else if (sender == this.bt2)
            {
                selected_path = Folder_Open_Dialog("�R�s�[���I�����Ă�������", true);
                tb = this.tb2;
            }
            else
            {
                return;
            }
            tb.Text = selected_path;
        }

        private string Folder_Open_Dialog(string message,bool showNewFolderButton)
        {
            string path = "";
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.Description = message;
            folderBrowserDialog.SelectedPath = @"C:";
            folderBrowserDialog.ShowNewFolderButton = showNewFolderButton;

            
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath;
            }
            else 
            {
                path = String.Empty;
            }
            return path;
        }

        private void Run_Rename(object sender, EventArgs e)
        {
            if (this.cb1.Checked == false && this.cb2.Checked == false) 
            {
                MessageBox.Show("�������s���t�@�C���`�����w�肳��Ă��܂���");
                this.cb1.Checked = true;
                return;
            }
            DialogResult dr =  MessageBox.Show("���������s���܂����H\n�Ȃ������t�@�C���͏㏑������܂�","�m�F",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr != DialogResult.OK) { return; }
            
            if (this.cb1.Checked == true)
            {
                Renamer.Rename(this.tb1.Text, this.tb2.Text,Renamer.Type.mp3);
            }

            if (this.cb2.Checked == true)
            {
                Renamer.Rename(this.tb1.Text, this.tb2.Text, Renamer.Type.mp4);
            }

            MessageBox.Show("�����ɐ������܂���");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tb1.Text = String.Empty;
            this.tb2.Text = String.Empty;
        }
    }
}