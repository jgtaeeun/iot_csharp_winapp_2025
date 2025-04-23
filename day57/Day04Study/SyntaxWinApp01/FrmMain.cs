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

                //int (4bytes 정수) , decimal(16bytes 실수)
                //큰사이즈의 데이터형에 작은 사이즈 데이터형값을 할당(묵시적 형변환)
                //NudAge.Value = person.Age;
                person.Age = Convert.ToInt32(NudAge.Value);

                person.Gender = char.Parse(TxtGender.Text.Trim());

                person.Phone = TxtPhone.Text;


               
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "예외", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("성별은 남 또는 여만 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            //    MessageBox.Show("0으로 나눌 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("알 수 없는 예외입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}



            //PicResult에 이미지 넣기(나이, 성별 고려)
            person.BirthYear = DateTime.Now.Year - person.Age;
            TxtResult.Text = person.ToString();

            if (person.Gender == '여')
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
            else if (person.Gender == '남')
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
