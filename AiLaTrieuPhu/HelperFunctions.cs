using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;


namespace AiLaTrieuPhu
{
    static class HelperFunctions
    {
      
        public static string getTheFolderLink(string folder_name)
        {
            /*string path = String.Empty; //initial the link
            path = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
            path = Path.Combine(path, @"Resources\", folder_name);*/

            string path = Environment.CurrentDirectory;

            path = Path.Combine(path, folder_name);
            return path;
        }

        public static SoundPlayer getSoundPlayerObj(string folder_name, string sound_name)
        {
            //get the link to sound_name:
            /*string path = String.Empty; //initial the link
            path = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
            path = Path.Combine(path, @"Resources\sounds", folder_name + @"\" + sound_name + ".wav");*/
            string path = Environment.CurrentDirectory;
            path = Path.Combine(path, "sounds", folder_name + @"\" + sound_name + ".wav");
            SoundPlayer sound_player = new SoundPlayer(path);
            return sound_player;
        }

        public static void playSound(string folder_name, string sound_name, bool is_playSync = false, bool is_loop = false)
        {
            try
            {
                if (is_loop)
                    getSoundPlayerObj(folder_name, sound_name).PlayLooping();
                else
                {
                    if (is_playSync)
                        getSoundPlayerObj(folder_name, sound_name).PlaySync();
                    else
                        getSoundPlayerObj(folder_name, sound_name).Play();
                }
                    
            }
            catch (Exception e)
            {
                Console.WriteLine("_____Error_____: '{0}'", e);
            }
        }

        public static List<Question> readJsonIntoQuestionList(string file_name)
        {
            string path = String.Empty; //initial the link
            path = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() +
                    @"\Resources\" + file_name;

            string data_raw = File.ReadAllText(path);
            List<Question> ques_list = JsonConvert.DeserializeObject<List<Question>>(data_raw);

            return ques_list;          
        }

      

        public static List<Question> readJsonFromResource(AiLaTrieuPhu.Form_Game.Level level_game)
        {

            Byte[] byteArray = null;
            
            switch (level_game)
            {
                case AiLaTrieuPhu.Form_Game.Level.EASY:
                    byteArray = Properties.Resources.data_easy;
                    break;
                case AiLaTrieuPhu.Form_Game.Level.MEDIUM:
                    byteArray = Properties.Resources.data_medium;
                    break;
                case AiLaTrieuPhu.Form_Game.Level.HARD:
                    byteArray = Properties.Resources.data_hard;
                    break;
            }
            
            string data_raw = System.Text.Encoding.UTF8.GetString(byteArray);
            List<Question> ques_list = JsonConvert.DeserializeObject<List<Question>>(data_raw);

            return ques_list;
        }

        public static void WriteJsonObjtoFle()
        {
            //
        }

       
        

    }//end class
}
