namespace Rename
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "対象フォルダ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "コピー先";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(84, 20);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(213, 23);
            this.tb1.TabIndex = 2;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(84, 49);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(213, 23);
            this.tb2.TabIndex = 3;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(303, 20);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(26, 23);
            this.bt1.TabIndex = 4;
            this.bt1.Text = "…";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.Folder_Open);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(303, 49);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(26, 23);
            this.bt2.TabIndex = 5;
            this.bt2.Text = "…";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.Folder_Open);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(249, 92);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 23);
            this.bt3.TabIndex = 6;
            this.bt3.Text = "実行";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.Run_Rename);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Checked = true;
            this.cb1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb1.Location = new System.Drawing.Point(12, 95);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(52, 19);
            this.cb1.TabIndex = 7;
            this.cb1.Text = ".mp3";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(101, 95);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(52, 19);
            this.cb2.TabIndex = 8;
            this.cb2.Text = ".mp4";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 133);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb1;
        private TextBox tb2;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private CheckBox cb1;
        private CheckBox cb2;
    }
}