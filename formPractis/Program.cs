using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        DialogResult result = MessageBox.Show(
            "「はい」か「いいえ」を選択して下さい。", "クック",       //第一引数が内容 第二引数がタイトル
            MessageBoxButtons.YesNo,     //ボタンの設置
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            MessageBox.Show("「はい」が選択されました。", "結果");
        }
        else if (result == DialogResult.No)
        {
            MessageBox.Show("「いいえ」が選択されました。", "結果");
        }
    }

    
}   
