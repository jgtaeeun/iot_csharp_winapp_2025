namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private string filePath = "sample.rtf";   //Rich Text Format (MS Word와 유사)

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //파일저장경로
            //C:\Source\iot_csharp_winapp_2025\day57\Day04Study\SyntaxWinApp03\bin\Debug\net8.0-windows
            //string filePath = "sample.txt";
            try
            {
                //File : 파일 관련 메서드가 들어있는 클래스
                //1. TXT파일 저장
                //File.WriteAllText(filePath, RtbResult.Text);

                //2.Rich Text Format  파일 저장
                RtbResult.SaveFile(filePath, RichTextBoxStreamType.RichText);
                MessageBox.Show("파일이 저장되었습니다.", "파일저장", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"저장실패 : {ex.Message}", "파일저장", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //3. OpenFileDialog 사용
            // doc, docx는 실제 로드 불가
            DlgOpen.Filter = "RTF파일 (*.rtf)|*.rtf|워드파일 (*.docx)|*.docx";
            DlgOpen.Title = "RTF파일 읽기";

            //다이얼로그창 열기(DialogResult.OK),취소(DialogResult.Cancel)
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    RtbResult.LoadFile(DlgOpen.FileName, RichTextBoxStreamType.RichText);

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"읽기실패 : {ex.Message}", "파일읽기", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            
            //string filePath = "sample.txt"; //읽어올 파일명
            //try
            //{
            //    if (File.Exists(filePath))
            //    {
            //        //1.TXT파일 로드
            //        //string content = File.ReadAllText(filePath);
            //        // RtbResult.Text = content;

            //        //2. Rich Text Format  파일 로드
            //        RtbResult.LoadFile(filePath, RichTextBoxStreamType.RichText);
            //    }
            //    else
            //    {
            //        //sample.txt 파일이 해당 경로에 존재하지 않을 때
            //        //해당 위치에 파일이 없거나 이름이 틀렸을 때
            //        MessageBox.Show($"파일이 존재하지 않습니다.", "파일읽기", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }
            //}
            //catch (Exception ex)
            //{
            //    //파일이 존재하긴 하지만 파일 읽기 중 예외가 발생했을 때
            //    MessageBox.Show($"읽기실패 : {ex.Message}", "파일읽기", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            RtbResult.SelectionColor = Color.Red;
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            Font currFont = RtbResult.SelectionFont;
            FontStyle newStyle;

            if (currFont.Bold)
            {
                newStyle = currFont.Style & ~FontStyle.Bold;  // Bold 제거
            }
            else 
            {
                newStyle = currFont.Style | FontStyle.Bold;   //Bold 추가
            }
            RtbResult.SelectionFont = new Font(currFont, newStyle);
        }
    }
}
