using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        DialogResult result = MessageBox.Show(
            "�u�͂��v���u�������v��I�����ĉ������B", "�N�b�N",       //�����������e ���������^�C�g��
            MessageBoxButtons.YesNo,     //�{�^���̐ݒu
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            MessageBox.Show("�u�͂��v���I������܂����B", "����");
        }
        else if (result == DialogResult.No)
        {
            MessageBox.Show("�u�������v���I������܂����B", "����");
        }
    }

    
}   
