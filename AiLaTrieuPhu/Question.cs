using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLaTrieuPhu
{
    public class Question
    {
        public int quesID { get; set; }

        public string quesStm { get; set; }

        public string ansA { get; set; }
        public string ansB { get; set; }
        public string ansC { get; set; }
        public string ansD { get; set; }

        public string trueAns { get; set; }

        public string image_name {get; set; } //default name is ID + '_' + level. ex: 1_easy.

        public string audio_name { get; set; }
       /* public override string ToString()
        {
            return string.Format("ID: {5} \nQuesion: {0} \nAns_A: {1}  \nAns_B: {2}  \nAns_C: {3}  \nAns_D: {4} \ntrueAns: {6}\n=====================",
                                quesStm, ansA, ansB, ansC, ansD, quesID, trueAns);
        }
        */
    }//end class
}
