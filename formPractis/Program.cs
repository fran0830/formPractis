using System;
using System.Windows.Forms;

//�t�H�[���̊�{�̌^
class Program
{
    [STAThread]     //STAThread�������}�[�N�i�܂��Ȃ��j
    static void Main()
    {
        Application.Run(new Form1());       //�t�H�[���P�����C���E�B���h�E�Ƃ��ĕ\��
    }
}   

class Form1 : Form
{
    //�R���X�g���N�^
    public Form1()
    {
        this.Text = "Hello";        //title��ݒ�
    }
}
