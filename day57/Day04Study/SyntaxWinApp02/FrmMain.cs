using System.Diagnostics;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private bool isInitializing = false;


        private void BtnCheck_Click(object sender, EventArgs e)
        {

            isInitializing = true; // �̺�Ʈ ��� �ߴ�


            //������ DB���� �����ͷε� �� �Ʒ��� �۾����� ����
            //�迭 ����
            string[] fruits = { "���", "�ٳ���", "����", "����", "��纣��" };
            CboArray.Items.AddRange(fruits);
            CboArray.SelectedIndex = 0;
            //����Ʈ ����
            //List<string> lFruits = new List<string>();
            //lFruits.Add("���");
            //lFruits.Add("����ƾ");
            //lFruits.Add("���ø���");
            //lFruits.Add("�ڸ�");

            List<string> lFruits = ["���", "����ƾ", "���ø���", "�ڸ�"];
            CboList.DataSource = null;
            CboList.DataSource = lFruits;
    
            //��ųʸ� ����
            Dictionary<string, string> dCountry = new Dictionary<string, string>()
            {
                { "KR" , "���ѹα�"},
                { "US" , "�̱�"},
                { "JP" , "�Ϻ�"},
                { "CN" , "�߱�"},
                { "IN" , "�ε�"},
                { "PH" , "�ʸ���"}
            };

            //BindingSource�� ������ �ҽ� ������ �ϸ�, �÷��� �����͸� ���ε��� �� �ְ� ���ݴϴ�.
            CboDictionary.DataSource = null;
            CboDictionary.DataSource = new BindingSource(dCountry, null);
            CboDictionary.DisplayMember = "Value";  //����ڿ��� ���̴� �̸�
            CboDictionary.ValueMember = "Key";      //���������� ���õǴ� ��

            //foreach�� �ݺ� ó��
            string result = "";
            foreach (var item in dCountry)
            {
                Debug.WriteLine(item.ToString());
            }

            isInitializing = false; // �ʱ�ȭ ��
        }

        private void CboArray_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return; // �ʱ�ȭ �߿� ����

            //selectedItem�� object
            string selected = CboArray.SelectedItem.ToString();
            MessageBox.Show($"������ ������ {selected}�Դϴ�.", "�����ϴ� ����", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return; // �ʱ�ȭ �߿� ����

            string selected = CboList.SelectedItem.ToString();
            MessageBox.Show($"������ ������ {selected}�Դϴ�.", "���õ� ����", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CboDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return; // �ʱ�ȭ �߿� ����

            var kvp = (KeyValuePair<string, string>)CboDictionary.SelectedItem;
            string key = kvp.Key;
            string value = kvp.Value;
            MessageBox.Show($"���õ� Ű�� {key}, ���� {value}", "���õ� ����", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
