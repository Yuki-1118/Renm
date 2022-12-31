using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rename
{
    internal class Renamer
    {
        public  enum Type {mp3,mp4};
        public static void Rename(string @target_path, string @save_path,Type type)
        {
            string[] FileList;

            switch (type)
            {
                case Type.mp3:
                    FileList = Directory.GetFiles(target_path, "*.mp3");
                    break;
                case Type.mp4:
                    FileList = Directory.GetFiles(target_path, "*.mp4");
                    break;
                default:
                    throw new Exception("Args type not match");
            }

            foreach (string item in FileList)
            {
                /*
                 * 配列からファイル名を１つ取得
                 * 取得したファイル名の先頭に対象の文字列があるかを確認
                 * 文字列が存在した場合文字列を削除
                 * 文字列を加工後完了したらコピー後のファイルパスを生成
                 * ファイルをコピー
                 * 次のファイルへ
                 */

                string tmp = String.Empty;
                string FileName = String.Empty;

                tmp = Path.GetFileName(item);

                if (tmp.Contains("y2mate.com - "))
                {
                    FileName = tmp.Remove(0,13);
                }
                else
                {
                    FileName = tmp;
                }

                string path =  Path.Combine(save_path, FileName);
                File.Copy(item, path,true);
                
            }

        }
    }
}
