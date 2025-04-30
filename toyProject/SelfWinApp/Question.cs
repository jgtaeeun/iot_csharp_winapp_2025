using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWinApp
{
    internal class Question
    {
        public List<string> Choices { get; set; }  // 보기 4개
        public int CorrectAnswer { get; set; }     // 정답 인덱스 (0~3)

        public String Answer { get; set; }  //해설
    }
}
