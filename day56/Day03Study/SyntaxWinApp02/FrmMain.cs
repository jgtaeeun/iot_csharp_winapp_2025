namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //�⺻������ + setter�Լ�
            Person hugo = new Person();
            hugo.Name = TxtName.Text.Trim();
            hugo.Age = int.Parse(TxtAge.Text.Trim());
            hugo.Gender = char.Parse(TxtGender.Text.Trim());
            hugo.Phone = TxtPhone.Text.Trim();


            //�Ű����� 4���� ������
            //Person hugo2 = new Person("������",19,'M',"010-1997-0000");

            TxtResult.Text = hugo.ToString();
            hugo.GetUp();
            hugo.GoToSchool();

            MessageBox.Show(Person.GetNumber().ToString());
        }
    }
}
