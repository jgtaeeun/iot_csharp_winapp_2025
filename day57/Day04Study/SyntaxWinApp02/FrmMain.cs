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

            isInitializing = true; // 이벤트 잠시 중단


            //실제로 DB에서 데이터로드 후 아래의 작업들을 수행
            //배열 생성
            string[] fruits = { "사과", "바나나", "딸기", "망고", "블루베리" };
            CboArray.Items.AddRange(fruits);
            CboArray.SelectedIndex = 0;
            //리스트 생성
            //List<string> lFruits = new List<string>();
            //lFruits.Add("용과");
            //lFruits.Add("망고스틴");
            //lFruits.Add("애플망고");
            //lFruits.Add("자몽");

            List<string> lFruits = ["용과", "망고스틴", "애플망고", "자몽"];
            CboList.DataSource = null;
            CboList.DataSource = lFruits;
    
            //딕셔너리 생성
            Dictionary<string, string> dCountry = new Dictionary<string, string>()
            {
                { "KR" , "대한민국"},
                { "US" , "미국"},
                { "JP" , "일본"},
                { "CN" , "중국"},
                { "IN" , "인도"},
                { "PH" , "필리핀"}
            };

            //BindingSource는 데이터 소스 역할을 하며, 컬렉션 데이터를 바인딩할 수 있게 해줍니다.
            CboDictionary.DataSource = null;
            CboDictionary.DataSource = new BindingSource(dCountry, null);
            CboDictionary.DisplayMember = "Value";  //사용자에게 보이는 이름
            CboDictionary.ValueMember = "Key";      //내부적으로 선택되는 값

            //foreach로 반복 처리
            string result = "";
            foreach (var item in dCountry)
            {
                Debug.WriteLine(item.ToString());
            }

            isInitializing = false; // 초기화 끝
        }

        private void CboArray_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return; // 초기화 중엔 무시

            //selectedItem은 object
            string selected = CboArray.SelectedItem.ToString();
            MessageBox.Show($"선택한 과일은 {selected}입니다.", "좋아하는 과일", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return; // 초기화 중엔 무시

            string selected = CboList.SelectedItem.ToString();
            MessageBox.Show($"선택한 과일은 {selected}입니다.", "선택된 과일", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CboDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return; // 초기화 중엔 무시

            var kvp = (KeyValuePair<string, string>)CboDictionary.SelectedItem;
            string key = kvp.Key;
            string value = kvp.Value;
            MessageBox.Show($"선택된 키는 {key}, 값은 {value}", "선택된 국가", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
