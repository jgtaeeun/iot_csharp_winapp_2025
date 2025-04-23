using SyntaxWinApp01.Properties;
using System;
using System.Diagnostics.Eventing.Reader;

namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            try
            {
                
                person.Name = TxtName.Text.Trim();

                //int (4bytes ����) , decimal(16bytes �Ǽ�)
                //ū�������� ���������� ���� ������ ������������ �Ҵ�(������ ����ȯ)
                //NudAge.Value = person.Age;
                person.Age = Convert.ToInt32(NudAge.Value);

                person.Gender = char.Parse(TxtGender.Text.Trim());

                person.Phone = TxtPhone.Text;


               
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("������ �� �Ǵ� ���� �Է��ϼ���", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Error);

                TxtGender.Focus();
                return;
            }

            //try
            //{
            //    float val = 0f;
            //    int x = 10 , y = 0;
            //    val = x / y;
            //}
            //catch (ArithmeticException ex) 
            //{
            //    MessageBox.Show("0���� ���� �� �����ϴ�.", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("�� �� ���� �����Դϴ�.", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}



            //PicResult�� �̹��� �ֱ�(����, ���� ���)
            person.BirthYear = DateTime.Now.Year - person.Age;
            TxtResult.Text = person.ToString();

            if (person.Gender == '��')
            {
                MessageBox.Show($"Gender: {person.Gender}, Age: {person.Age}");

                if (person.Age < 20)
                {
                    PicResult.Image = Resources.girl;
                }
                else if (person.Age < 60)
                {
                    PicResult.Image = Resources.woman;
                }
                else
                {
                    PicResult.Image = Resources.oldwoman;
                }
            }
            else if (person.Gender == '��')
            {
                if (person.Age < 20)
                { PicResult.Image = Resources.boy; }
                else if (person.Age < 60)
                { PicResult.Image = Resources.man; }
                else
                {   PicResult.Image = Resources.oldman; }
            }

        }
    }
}
