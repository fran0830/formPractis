using System;
using System.Windows.Forms;

//フォームの基本の型
class Program
{
    [STAThread]     //STAThread属性をマーク（まじない）
    static void Main()
    {
        Application.Run(new Form1());       //フォーム１をメインウィンドウとして表示
    }
}   

class Form1 : Form
{
    //コンストラクタ
    public Form1()
    {
        this.Text = "Hello";        //titleを設定
    }
}
