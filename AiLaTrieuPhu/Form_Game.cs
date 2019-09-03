using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

using System.Windows.Media;

namespace AiLaTrieuPhu
{
    public partial class Form_Game : Form
    {

        static private Random random_obj = new Random();// helping for making a random order

        private const int FLICKFERING_TIME = 12;//  * half a second
        private const int MAX_WEIGHTS_EASY = 30;
        private const int MAX_WEIGHTS_MEDIUM = 60;
        private const int MAX_WEIGHTS_HARD = 80;
        

        SoundPlayer intro_media = HelperFunctions.getSoundPlayerObj("background", "intro");
        SoundPlayer intro_media2 = HelperFunctions.getSoundPlayerObj("background", "intro2");
        MediaPlayer audio_question;

        string wrong_answer = String.Empty;
        bool is_lifeline_5050_just_used = false;

        /*lock lifelines*/
        bool lifeline_changeQues_is_used = false;
        bool lifeline_5050_is_used = false;
        bool lifeline_phoneCall_is_used = false;
        bool lifeline_audience_is_used = false;
        /**/

        /*control the btn_StartGame*/
        enum Status //status for btn_StartGame;
        {
            LETS_START,
            START_GAME,
            STOP_GAME,
            REPLAY_GAME
        };
        enum ReasonStopGame //why the game is stoped
        {
            STOP_BY_PLAYER,
            TIME_OUT,
            WRONG_ANSWER,
            WIN
        };


        private const double PERCENTAGE_OF_NEXTQUESTION_SOUND = 0.15;
        private const double NUM_QUES = 15;
        private const int THINKING_TIME = 30; //30 seconds for players make up their mind
        private Status status_btnStartGame = Status.LETS_START;
        /**/


        /*CONTROL level of the game*/
        public enum Level //level of the current question
        {

            EASY,// FROM QUESTION 1 - 5
            MEDIUM,// 6-10
            HARD,//11-15
        };
        private int cur_num_ques = 1;
        private int cur_num_ques_level_index = 0;

        /*control the size when resezing*/
        private List<Rec_Control> resize_list;
        private Size originalForm;
        /**/


        /*Timer's count*/
        int countTime_highlightIntro = 0;
        int countTime_30s = 1;
        int countTime_flickfering = 0;
        int countTime_changingQues = 0;
        /**/


        /*current question*/
        Question cur_question;


        /*Question_lists*/
        List<Question> question_list;

        bool is_first_ques = true;

        /**/
        MediaPlayer wrong_ans = new System.Windows.Media.MediaPlayer();
        MediaPlayer true_ans_congratuate = new System.Windows.Media.MediaPlayer();
        MediaPlayer next_question = new System.Windows.Media.MediaPlayer();
        MediaPlayer sound_5050 = new MediaPlayer();
        MediaPlayer sound_5050_2wrongOpitions = new MediaPlayer();
        MediaPlayer sound_changeQues = new MediaPlayer();
        MediaPlayer sound_audience = new MediaPlayer();
        MediaPlayer sound_phone_call = new MediaPlayer();

        Uri uri_true_answer = new System.Uri(HelperFunctions.getTheFolderLink(@"sounds\announcement\true_answer.wav"));
        Uri uri_next_question = new System.Uri(HelperFunctions.getTheFolderLink(@"sounds\questions_and_time30\next_question.mp3"));
        Uri uri_5050 = new System.Uri(HelperFunctions.getTheFolderLink(@"sounds\Lifelines\") + "5050.wav");
        Uri uri_change_question = new System.Uri(HelperFunctions.getTheFolderLink(@"sounds\Lifelines\") + "change_the_question_lifeline.wav");
        Uri uri_ask_audience = new System.Uri(HelperFunctions.getTheFolderLink(@"sounds\Lifelines\ask_audience.mp3"));
        Uri uri_phone_call = new System.Uri(HelperFunctions.getTheFolderLink(@"sounds\Lifelines\give_30s_PhoneLifeline.mp3"));

        SoundPlayer first_ques_sound = HelperFunctions.getSoundPlayerObj("questions_and_time30", "first_question");
        SoundPlayer ticktac30_sound = HelperFunctions.getSoundPlayerObj("questions_and_time30", "time30");


        Form_Chart form_chart;

        List<string> background_images;
        int NUM_BACKGROUNDS =9;
        Random rd_background;
        object obj_image_background;



        public Form_Game()
        {
            resize_list = new List<Rec_Control>();
            InitializeComponent();
        }


        public IEnumerable<Control> getAllControls(Control control, Type type = null)
        {

            var controls = control.Controls.Cast<Control>();
            if (type == null)
            {
                return controls.SelectMany(ctrl => getAllControls(ctrl, type))
                                      .Concat(controls);
            }
            else
                return controls.SelectMany(ctrl => getAllControls(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public void outro_Ended(object sender, EventArgs e)
        {
            HelperFunctions.playSound("background", "outro", false, true);
            btn_StartGame.Text = "CHƠI LẠI";
            btn_StartGame.Enabled = true;
        }

        private void setMinimumFormSize()
        {
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
        }
        private void setMaximumFormSize()
        {

            // Rectangle screen = Screen.PrimaryScreen.Bounds; //size (real size in total)
            Rectangle screen = Screen.PrimaryScreen.WorkingArea; //size (doesnt count Taskbar, it's smaller)

            double ideal_ratio = this.Width / Convert.ToDouble(this.Height);
            double client_ratio = Convert.ToDouble(screen.Width) / screen.Height;
            int height, width;
            if (client_ratio < ideal_ratio)
            {
                double he = screen.Width / ideal_ratio;
                height = Convert.ToInt32(he);
                width = screen.Width;
            }
            else
            {
                double wi = screen.Height * ideal_ratio;
                width = Convert.ToInt32(wi);
                height = screen.Height;
            }
            this.MaximumSize = new System.Drawing.Size(width, height);

            Console.WriteLine(MaximumSize);

            Point maximizedLocation = new Point(
              (screen.Width - width) / 2,
              (screen.Height - height) / 2);

            this.MaximizedBounds = new Rectangle(maximizedLocation, this.MaximumSize);
        }

        private void Form_Game_Load(object sender, EventArgs e)
        {

            background_images = new List<string>();
            for (int i = 1; i <= NUM_BACKGROUNDS; i++)
                background_images.Add("penguin__" + i + "_");

            rd_background = new Random();
            int index_background = rd_background.Next(NUM_BACKGROUNDS);

            obj_image_background = Properties.Resources.ResourceManager.GetObject(background_images[index_background]);
            BackgroundImage = (Image)(obj_image_background);

            intro_media.PlayLooping();
            setMaximumFormSize();
            setMinimumFormSize();
            //get all children of the form:
            var c = getAllControls(this);

            
            foreach (Control control in c)
            {
                resize_list.Add(new Rec_Control(new Rectangle(control.Location.X, control.Location.Y, control.Width, control.Height), control));
            }

            originalForm = this.Size;

            wrong_ans.MediaEnded += new EventHandler(outro_Ended);

            btn_StartGame.Visible = true;//visible the play button:		btn_name	null	string



        }

        private void showAudioAndImage()
        {
            is_lifeline_5050_just_used = false;
     
            if (lifeline_phoneCall_is_used)
                btn_PhoneCall.BackgroundImage = Properties.Resources.btn_phoneCall_used;

            lockEnabledPanelButtons(panel_Lifelines);
            lockEnabledPanelButtons(panel_QuesAns);


            var c = getAllControls(panel_15Milestones);

            string btn_name = "btn_Milestone" + cur_num_ques;
            foreach (Control btn_milestone in c)
            {
                if (btn_milestone.Name.Equals(btn_name))
                {
                    btn_milestone.BackgroundImage = Properties.Resources.btn_question;
                    break;
                }

            }
          

            if (cur_question.audio_name != "")
            {
                if (cur_question.image_name != "")
                {
                    panel_Screen.BackgroundImage = Image.FromFile(HelperFunctions.getTheFolderLink("image_data") + @"\" + cur_question.image_name);
                }
                else
                    panel_Screen.BackgroundImage = Properties.Resources.listen_heart_music_;

                btn_skip.Visible = true;
                picBox1_Timer.Visible = false;

                audio_question = getMediaPlayerObj("", cur_question.audio_name, "audio_data");
                audio_question.MediaEnded += new EventHandler(showQuestionUp);
                audio_question.Play();

                //picBox1_Timer.BackgroundImage = Properties.re
                btn_AnswerA.Text = btn_AnswerB.Text = btn_AnswerC.Text = btn_AnswerD.Text = String.Empty;
                btn_Question.Text = "Câu " + cur_num_ques + ": " + "[Đang phát...]";


                //picBox1_Timer.Visible = false;
            }
            else
            {
                if (cur_question.image_name != "")
                {
                    panel_Screen.BackgroundImage = Image.FromFile(HelperFunctions.getTheFolderLink("image_data") + @"\" + cur_question.image_name);
                }
                else
                {
                    panel_Screen.BackgroundImage = Properties.Resources.LaiVanSam_2;
                }

                showQuestionUp();

            }

        }

        public void showQuestionUp()
        {
            List<string> ans_list = new List<string>();
            ans_list.Add(cur_question.ansA);
            ans_list.Add(cur_question.ansB);
            ans_list.Add(cur_question.ansC);
            ans_list.Add(cur_question.ansD);

            List<string> index_ansList = new List<string>();
            index_ansList.Add("A");
            index_ansList.Add("B");
            index_ansList.Add("C");
            index_ansList.Add("D");

            string true_ans_content = ans_list.ElementAt(index_ansList.IndexOf(cur_question.trueAns));
            Shuffle(ans_list);

            btn_Question.Text = "Câu " + cur_num_ques + ": " + cur_question.quesStm;
            btn_AnswerA.Text = "A. " + ans_list[0];
            btn_AnswerB.Text = "B. " + ans_list[1];
            btn_AnswerC.Text = "C. " + ans_list[2];
            btn_AnswerD.Text = "D. " + ans_list[3];

            for (int i = 0; i < ans_list.Count; i++)
            {
                if (true_ans_content == ans_list[i])
                {
                    cur_question.trueAns = index_ansList[i];
                    break;
                }
            }

            var c = getAllControls(panel_15Milestones);

            string btn_name = "btn_Milestone" + cur_num_ques;
            foreach (Control btn_milestone in c)
            {
                if (btn_milestone.Name.Equals(btn_name))
                {
                    btn_milestone.BackgroundImage = Properties.Resources.btn_question;
                    break;
                }

            }
            unlockEnabledPanelButtons(panel_Lifelines);
            unlockEnabledPanelButtons(panel_QuesAns);


            if (!is_first_ques)

                startTimer30s_and_PlayTicktac();
            else
                is_first_ques = false;
        }



        public void showQuestionUp(object sender, EventArgs e)
        {
            btn_skip.Visible = false;
            picBox1_Timer.Visible = true;

            List<string> ans_list = new List<string>();
            ans_list.Add(cur_question.ansA);
            ans_list.Add(cur_question.ansB);
            ans_list.Add(cur_question.ansC);
            ans_list.Add(cur_question.ansD);

            List<string> index_ansList = new List<string>();
            index_ansList.Add("A");
            index_ansList.Add("B");
            index_ansList.Add("C");
            index_ansList.Add("D");

            string true_ans_content = ans_list.ElementAt(index_ansList.IndexOf(cur_question.trueAns));
            Shuffle(ans_list);

            btn_Question.Text = "Câu " + cur_num_ques + ": " + cur_question.quesStm;
            btn_AnswerA.Text = "A. " + ans_list[0];
            btn_AnswerB.Text = "B. " + ans_list[1];
            btn_AnswerC.Text = "C. " + ans_list[2];
            btn_AnswerD.Text = "D. " + ans_list[3];

            for (int i = 0; i < ans_list.Count; i++)
            {
                if (true_ans_content == ans_list[i])
                {
                    cur_question.trueAns = index_ansList[i];
                    break;
                }
            }


            unlockEnabledPanelButtons(panel_Lifelines);
            unlockEnabledPanelButtons(panel_QuesAns);

            if (lifeline_changeQues_is_used)
                btn_ChangeQues.Enabled = false;
            if (lifeline_5050_is_used)
                btn_50_50.Enabled = false;
            if (lifeline_phoneCall_is_used)
                btn_PhoneCall.Enabled = false;
            if (lifeline_audience_is_used)
                btn_Audience.Enabled = false;

            if (!is_first_ques)

                startTimer30s_and_PlayTicktac();
            else
                is_first_ques = false;


        }


        public void lockEnabledPanelButtons(Control panel_name)
        {
            var c = getAllControls(panel_name);
            foreach (Control control in c)
            {
                control.Enabled = false;
            }
        }

        public void unlockEnabledPanelButtons(Control panel_name)
        {
            var c = getAllControls(panel_name);
            foreach (Control control in c)
            {
                control.Enabled = true;
            }

            if (lifeline_changeQues_is_used)
                btn_ChangeQues.Enabled = false;
            if (lifeline_5050_is_used)
                btn_50_50.Enabled = false;
            if (lifeline_phoneCall_is_used)
                btn_PhoneCall.Enabled = false;
            if (lifeline_audience_is_used)
                btn_Audience.Enabled = false;

        }




        //resize control: ---------------------------------------------
        private void resizeChildren()
        {
           // if (resize_list != null)
                foreach (Rec_Control resize_element in resize_list)
                    resizeChildren_Control(resize_element.rec, resize_element.ctrl);

        }
        private void resizeChildren_Control(Rectangle rec, Control control)
        {
            float Xratio = this.Width / (float)(originalForm.Width);
            float Yratio = this.Height / (float)(originalForm.Height);

            int new_width = (int)(rec.Width * Xratio);
            int new_height = (int)(rec.Height * Yratio);
            int newX = (int)(rec.X * Xratio);
            int newY = (int)(rec.Y * Yratio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(new_width, new_height);

        }

        private void Form_Game_SizeChanged(object sender, EventArgs e)
        {
            resizeChildren();
        }  //end  resize control -----------------------------------------------------

        private void timer_highlightIntro_Tick(object sender, EventArgs e)
        {
            switch (countTime_highlightIntro)
            {
                case 12:
                    btn_Milestone5.FlatStyle = FlatStyle.Popup;
                    break;
                case 13:
                    btn_Milestone5.FlatStyle = FlatStyle.Flat;
                    btn_Milestone10.FlatStyle = FlatStyle.Popup;
                    break;
                case 14:
                    btn_Milestone10.FlatStyle = FlatStyle.Flat;
                    btn_Milestone15.FlatStyle = FlatStyle.Popup;
                    break;
                case 15:
                    btn_Milestone15.FlatStyle = FlatStyle.Flat;
                    break;
                case 20:
                    btn_50_50.FlatStyle = FlatStyle.Popup;
                    break;
                case 23:
                    btn_50_50.FlatStyle = FlatStyle.Standard;
                    btn_PhoneCall.FlatStyle = FlatStyle.Popup;
                    break;
                case 26:
                    btn_PhoneCall.FlatStyle = FlatStyle.Standard;
                    btn_Audience.FlatStyle = FlatStyle.Popup;
                    break;
                case 29:
                    btn_Audience.FlatStyle = FlatStyle.Standard;
                    timer_highlightIntro.Stop();
                    break;
                default:
                    break;
            }

            countTime_highlightIntro++;

        }

        private void resetStandardLifelineAndMileStoneBtns()
        {
            btn_50_50.FlatStyle = FlatStyle.Standard;
            btn_Audience.FlatStyle = FlatStyle.Standard;
            btn_PhoneCall.FlatStyle = FlatStyle.Standard;
            btn_Milestone5.FlatStyle = FlatStyle.Flat;
            btn_Milestone10.FlatStyle = FlatStyle.Flat;
            btn_Milestone15.FlatStyle = FlatStyle.Flat;

        }

        private Level getLevelGame()
        {
            Level level_game;
            if (cur_num_ques <= 5)
                level_game = Level.EASY;
            else
            {
                if (cur_num_ques <= 10)
                    level_game = Level.MEDIUM;
                else
                    level_game = Level.HARD;
            }

            return level_game;
        }

        //Shuffle a question_list (to get random questions)
        private void ShuffleQuestions(IList<Question> question_list)
        {
            int n = question_list.Count;
            while (n > 1)
            {
                n--;
                int k = random_obj.Next(n + 1);
                Question value = question_list[k];
                question_list[k] = question_list[n];
                question_list[n] = value;
            }
        }//end Shuffle function


        //get question_list from json file and shuffle it:
        private List<Question> getQuestions()
        {
            cur_num_ques_level_index = 0;

            List<Question> question_list = new List<Question>();
            string data_file_name = String.Empty;

            Level level_game = getLevelGame();

            question_list = HelperFunctions.readJsonFromResource(level_game);
            ShuffleQuestions(question_list);

            int i = question_list.Count - 1;
            //get the first question is not have the audio
            while (question_list[0].audio_name != "")
            {
                question_list[0] = question_list[i];
                i--;
                if (i == 0)
                    break;
                //Console.WriteLine("changing...");
            }
            //Do we need just return all ques (or just 6 first Ques) ?

            return question_list;
        }

        static private MediaPlayer getMediaPlayerObj(string parents_2, string file_name, string parents_1 = "sounds")
        {
            MediaPlayer media = new MediaPlayer();
            string path = HelperFunctions.getTheFolderLink(parents_1) + @"\" + parents_2 + @"\" + file_name;
            Console.WriteLine(path);
            media.Open(new Uri(path));

            return media;
        }
        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            switch (status_btnStartGame)
            {
                case Status.LETS_START:
                    {
                        menuStrip1.Hide();

                        question_list = getQuestions();

                        this.BackgroundImage = null;
                        btn_StartGame.Text = "SẴN SÀNG";

                        intro_media2.Play();//play intro

                        timer_highlightIntro.Start();


                        //visible all panels:
                        panel_Screen.Visible = true;
                        panel_15Milestones.Visible = true;
                        panel_Lifelines.Visible = true;
                        panel_QuesAns.Visible = true;

                        lockEnabledPanelButtons(panel_Lifelines);
                        lockEnabledPanelButtons(panel_QuesAns);

                        status_btnStartGame = Status.START_GAME;
                        break;
                    }

                case Status.START_GAME:
                    {
                        timer_highlightIntro.Stop();

                        is_first_ques = true;
                        HelperFunctions.playSound("questions_and_time30", "first_question");
                        timer_30s.Start();


                        resetStandardLifelineAndMileStoneBtns();

                        panel_Screen.BackgroundImage = Properties.Resources.studio;
                        picBox1_Timer.BackgroundImage = Properties.Resources.t30;
                        btn_StartGame.Text = "DỪNG CHƠI";

                        cur_num_ques = 1;//1st question


                        cur_question = question_list[cur_num_ques_level_index];

                        showAudioAndImage();
                        btn_StartGame.Enabled = true;
                        status_btnStartGame = Status.STOP_GAME;
                        break;
                    }
                case Status.STOP_GAME:
                    {
                        DialogResult is_quit = MessageBox.Show("Bạn muốn dừng chơi ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (is_quit == DialogResult.Yes)
                        {
                            gameOver(ReasonStopGame.STOP_BY_PLAYER);
                        }
                        break;

                    }
                case Status.REPLAY_GAME:
                    {
                        if (wrong_ans != null)
                            wrong_ans.Stop();

                        btn_StartGame.Text = "BẮT ĐẦU";
                        menuStrip1.Visible = true;

                        resetGame();

                        break;
                    }

            }//end switch

        }

        private void timer_30s_Tick(object sender, EventArgs e)
        {
            if (countTime_30s <= THINKING_TIME)
            {
                picBox1_Timer.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("t" + (THINKING_TIME - countTime_30s));
            }

            if (countTime_30s == (THINKING_TIME - 1))
                HelperFunctions.playSound("questions_and_time30", "time_out_1s");

            if (countTime_30s > THINKING_TIME)
            {

                gameOver();
            }

            countTime_30s++;
        }


        private void gameOver(ReasonStopGame reason = ReasonStopGame.TIME_OUT)
        {
            //stop other sounds:
            if (audio_question != null)
                audio_question.Stop();


            resetTimer30s();

            switch (reason)
            {
                case ReasonStopGame.TIME_OUT:
                    {
                        HelperFunctions.playSound("background", "stopedTheGame");
                        picBox1_Timer.BackgroundImage = Properties.Resources.time_over_1;
                        panel_Screen.BackgroundImage = Properties.Resources.game_over_1;
                        btn_StartGame.Text = "CHƠI LẠI";
                        break;
                    }
                case ReasonStopGame.WIN:
                    {
                        picBox1_Timer.Visible = true;
                        btn_skip.Visible = false;
                        HelperFunctions.playSound("background", "outro");//need a new audio file for winning
                        picBox1_Timer.BackgroundImage = Properties.Resources.Penguin_btn_3;
                        panel_Screen.BackgroundImage = Properties.Resources.winner_jpg;
                        btn_StartGame.Text = "CHƠI LẠI";
                        btn_StartGame.Enabled = true;

                        break;
                    }
                case ReasonStopGame.WRONG_ANSWER:
                    {
                        string true_ans = cur_question.trueAns;
                        string path = HelperFunctions.getTheFolderLink(@"sounds\announcement\") + true_ans.ToLower() + "-f.wav";

                        wrong_ans.Open(new System.Uri(path));
                        wrong_ans.Play();

                        picBox1_Timer.BackgroundImage = Properties.Resources.Penguin_btn_3;
                        panel_Screen.BackgroundImage = Properties.Resources.game_over_1;

                        break;
                    }
                case ReasonStopGame.STOP_BY_PLAYER:
                    {
                        HelperFunctions.playSound("background", "stopedTheGame");

                        picBox1_Timer.Visible = true;
                        btn_skip.Visible = false;
                        picBox1_Timer.BackgroundImage = Properties.Resources.Penguin_btn_3;
                        panel_Screen.BackgroundImage = Properties.Resources.stoped_game;
                        btn_StartGame.Text = "CHƠI LẠI";

                        break;
                    }
            }//end switch


            lockEnabledPanelButtons(panel_QuesAns);
            lockEnabledPanelButtons(panel_Lifelines);
            status_btnStartGame = Status.REPLAY_GAME;
            // 
        }


        private void resetTimer30s()
        {
            pauseTimer30s_and_PlayTicktac();
            countTime_30s = 1;
        }

        private void startTimer30s_and_PlayTicktac()
        {
            timer_30s.Start();
            ticktac30_sound.Play();
        }


        private void pauseTimer30s_and_PlayTicktac()
        {
            timer_30s.Stop();
            if (first_ques_sound != null)
                first_ques_sound.Stop();
            if (ticktac30_sound != null)
                ticktac30_sound.Stop();
        }

        private void goToNextLevel(object sender, EventArgs e)
        {
            cur_num_ques++;
            if (cur_num_ques == 6 || cur_num_ques == 11) //next level
            {
                question_list = getQuestions();
            }

            cur_num_ques_level_index++;

            //get next question:
            cur_question = question_list[cur_num_ques_level_index];
            showAudioAndImage();
            btn_skip.Enabled = true;
            btn_StartGame.Enabled = true;

            picBox1_Timer.BackgroundImage = Properties.Resources.t30;

        }
        private void whenTrueAnsCongratulation_ended(object sender, EventArgs e)
        {
            if (cur_num_ques == NUM_QUES)
            {
                gameOver(ReasonStopGame.WIN);
                btn_Question.Text = "Chúc mừng, bạn đã chiến thắng 15 câu hỏi !!!";
                btn_AnswerA.Text = "";
                btn_AnswerB.Text = "";
                btn_AnswerC.Text = "";
                btn_AnswerD.Text = "";
                return;
            }

            //random:
            double random = random_obj.NextDouble();

            if (random > PERCENTAGE_OF_NEXTQUESTION_SOUND)
                next_question.Open(new System.Uri(HelperFunctions.getTheFolderLink(@"sounds\questions_and_time30\q" + (cur_num_ques + 1) + "(audio-cutter).mp3")));
            else
                next_question.Open(uri_next_question);


            next_question.MediaEnded += new EventHandler(goToNextLevel);
            next_question.Play();
        }

        private void choseTheTrueAns()
        {
            resetTimer30s();

            true_ans_congratuate.MediaEnded += new EventHandler(whenTrueAnsCongratulation_ended);
            true_ans_congratuate.Open(uri_true_answer);
            true_ans_congratuate.Play();

           
        }


        private void btn_AnswerA_Click(object sender, EventArgs e)
        {
            whenClickAnswerButton("A");
        }

        private void btn_AnswerB_Click(object sender, EventArgs e)
        {
            whenClickAnswerButton("B");
        }

        private void btn_AnswerC_Click(object sender, EventArgs e)
        {
            whenClickAnswerButton("C");
        }

        private void btn_AnswerD_Click(object sender, EventArgs e)
        {
            whenClickAnswerButton("D");
        }

        private void whenClickAnswerButton(string btn_name)
        {
            //stopother sounds
            if (sound_5050_2wrongOpitions != null)
                sound_5050_2wrongOpitions.Stop();


            lockEnabledPanelButtons(panel_Lifelines);
            lockEnabledPanelButtons(panel_QuesAns);
            btn_StartGame.Enabled = false;

            //resetTimer30s();


            timer_Flickering.Start();

            if (btn_name.Equals(cur_question.trueAns))
            {
                choseTheTrueAns();
            }
            else
            {
                gameOver(ReasonStopGame.WRONG_ANSWER);
            }
        }

        public Control getTrueAnsButton(Question cur_ques)
        {
            Control true_ans_button = btn_AnswerA;
            string true_ans = cur_ques.trueAns;

            switch (true_ans)
            {
                case "A":
                    true_ans_button = btn_AnswerA;
                    break;
                case "B":
                    true_ans_button = btn_AnswerB;
                    break;
                case "C":
                    true_ans_button = btn_AnswerC;
                    break;
                case "D":
                    true_ans_button = btn_AnswerD;
                    break;
            }
            return true_ans_button;
        }
        private void timer_Flickering_Tick(object sender, EventArgs e)
        {
            Control true_ans_button = getTrueAnsButton(cur_question);

            if ((countTime_flickfering % 2) == 1)
                true_ans_button.BackgroundImage = Properties.Resources.btn_green;
            else
                true_ans_button.BackgroundImage = Properties.Resources.btn_blue_answer;

            if (countTime_flickfering > FLICKFERING_TIME)
            {
                timer_Flickering.Stop();
                true_ans_button.BackgroundImage = Properties.Resources.btn_blue_answer;
                countTime_flickfering = 0; //reset

            }

            countTime_flickfering++;
        }

        private void btn_Question_Click(object sender, EventArgs e)
        {
        }



        private void Shuffle(List<string> answers)
        {
            int n = answers.Count;
            while (n > 1)
            {
                n--;
                int k = random_obj.Next(n + 1);
                string value = answers[k];
                answers[k] = answers[n];
                answers[n] = value;
            }
        }//end Shuffle function


        private void btn_50_50_Click(object sender, EventArgs e)
        {
            is_lifeline_5050_just_used = true;

            lockEnabledPanelButtons(panel_QuesAns);
            lockEnabledPanelButtons(panel_Lifelines);
            btn_StartGame.Enabled = false;

            lifeline_5050_is_used = true;
            btn_50_50.Enabled = false;
            btn_50_50.BackgroundImage = Properties.Resources.btn_50_50_used;
            HelperFunctions.playSound("Lifelines", "5050");
            timer_30s.Stop();//stop counting to play sound_5050

            sound_5050.MediaEnded += new EventHandler(whenSound5050_ended);
            sound_5050.Open(uri_5050);
            sound_5050.Play();

        }

        private void whenSound5050_ended(object sender, EventArgs e)
        {
            string true_answer = cur_question.trueAns;

            List<string> answers = new List<string>() { "A", "B", "C", "D" };

            answers.Remove(true_answer);
            Shuffle(answers);

            //HelperFunctions.playSound("Lifelines", (answers[0] + answers[1] + "f"));
            string path = String.Empty;
            if (String.Compare(answers[0], answers[1]) < 0)
                path = HelperFunctions.getTheFolderLink(@"sounds\Lifelines\") + answers[0] + answers[1] + "f.wav";
            else
                path = HelperFunctions.getTheFolderLink(@"sounds\Lifelines\") + answers[1] + answers[0] + "f.wav";

            wrong_answer = answers[2];//get the remain wrong_answer

            sound_5050_2wrongOpitions.Open(new System.Uri(path));
            sound_5050_2wrongOpitions.MediaEnded += new EventHandler(when5050_ended);

            sound_5050_2wrongOpitions.Play();

            var c = getAllControls(panel_QuesAns);

            string btn_name1 = "btn_Answer" + answers[0];
            string btn_name2 = "btn_Answer" + answers[1];
            foreach (Control btn_answer in c)
            {
                if (btn_answer.Name.Equals(btn_name1) || btn_answer.Name.Equals(btn_name2))
                {
                    btn_answer.Text = String.Empty;
                    btn_answer.Enabled = false;
                }
                else
                {
                    btn_answer.Enabled = true;
                }

            }


            timer_30s.Start();//countinue counting
            unlockEnabledPanelButtons(panel_Lifelines);


        }
        public void when5050_ended(object sender, EventArgs e)
        {
            ticktac30_sound.Play();
        }
        private void btn_ChangeQues_Click(object sender, EventArgs e)
        {
            // turn off others sound
            if (sound_5050_2wrongOpitions != null)
                sound_5050_2wrongOpitions.Stop();


            lifeline_changeQues_is_used = true;
            btn_ChangeQues.BackgroundImage = Properties.Resources.btn_changeQuestion_used;
            btn_ChangeQues.Enabled = false;
            lockEnabledPanelButtons(panel_Lifelines);
            lockEnabledPanelButtons(panel_QuesAns);
            btn_StartGame.Enabled = false;


            btn_AnswerA.Text = btn_AnswerB.Text = btn_AnswerC.Text = btn_AnswerD.Text = String.Empty;

            pauseTimer30s_and_PlayTicktac();

            sound_changeQues.MediaEnded += new EventHandler(whenSoundChangeQues_ended);
            sound_changeQues.Open(uri_change_question);
            sound_changeQues.Play();
            timer_changingQues.Start();
        }

        private void whenSoundChangeQues_ended(object sender, EventArgs e)
        {
            //todo Question button effect
            timer_changingQues.Stop();
            cur_num_ques_level_index++;
            cur_question = question_list[cur_num_ques_level_index];

            showAudioAndImage();
            btn_skip.Enabled = true;
            btn_StartGame.Enabled = true;
        }

        private void timer_changingQues_Tick(object sender, EventArgs e)
        {
            int index = countTime_changingQues % question_list.Count;

            btn_Question.Text = question_list[index].quesStm;
            countTime_changingQues++;
        }


        private void btn_skip_Click(object sender, EventArgs e)
        {
            if (audio_question != null)
                audio_question.Stop();
            showQuestionUp();
            btn_skip.Visible = false;
            picBox1_Timer.Visible = true;
        }

        private void resetGame()
        {
            is_lifeline_5050_just_used = false;

            panel_Screen.Visible = false;
            panel_15Milestones.Visible = false;
            panel_Lifelines.Visible = false;
            panel_QuesAns.Visible = false;

            intro_media.PlayLooping();
           
            btn_Question.Text = btn_AnswerA.Text = btn_AnswerB.Text = btn_AnswerC.Text = btn_AnswerD.Text = String.Empty;
            panel_Screen.BackgroundImage = Properties.Resources.LaiVanSam_2;


            btn_ChangeQues.BackgroundImage = Properties.Resources.btn_changeQuestion;
            btn_50_50.BackgroundImage = Properties.Resources.btn_50_50;
            btn_PhoneCall.BackgroundImage = Properties.Resources.btn_phoneCall;
            btn_Audience.BackgroundImage = Properties.Resources.btn_audience;

            var c = getAllControls(panel_15Milestones);
            foreach (Control btn_milestone in c)
            {
                if (btn_milestone.Name.Equals("btn_Milestone5") ||
                    btn_milestone.Name.Equals("btn_Milestone10") ||
                    btn_milestone.Name.Equals("btn_Milestone15")
                )
                {
                    btn_milestone.BackgroundImage = Properties.Resources.btn_darkblue;
                }
                else
                    btn_milestone.BackgroundImage = Properties.Resources.btn_green_chubby;
            }

            status_btnStartGame = Status.LETS_START;
            /*lock lifelines*/
            lifeline_changeQues_is_used = false;
            lifeline_5050_is_used = false;
            lifeline_phoneCall_is_used = false;
            lifeline_audience_is_used = false;

            cur_num_ques = 1;
            cur_num_ques_level_index = 0;

            countTime_highlightIntro = 0;
            countTime_30s = 1;
            countTime_flickfering = 0;
            countTime_changingQues = 0;

            is_first_ques = true;


            first_ques_sound = HelperFunctions.getSoundPlayerObj("questions_and_time30", "first_question");
            ticktac30_sound = HelperFunctions.getSoundPlayerObj("questions_and_time30", "time30");
            picBox1_Timer.BackgroundImage = Properties.Resources.Penguin_btn_3;

            //change background image (the first screen)
            rd_background = new Random();
            int index_background = rd_background.Next(NUM_BACKGROUNDS);

            obj_image_background = Properties.Resources.ResourceManager.GetObject(background_images[index_background]);
            BackgroundImage = (Image)(obj_image_background);
        }

        private string generatePhoneCallAnswer()
        {
            Level level = getLevelGame();
            string string_answer = String.Empty; 

            List<string> answer_names = new List<string>() { "A", "B", "C", "D", "dont_know" };

            string true_answer = cur_question.trueAns;

            int index_true_answer = answer_names.IndexOf(true_answer);
            int index_wrong_answer = answer_names.IndexOf(wrong_answer);

            int max_for_wrong_answer = 0;
            int max_for_dont_know = 0;
            switch (level)
            {
                case Level.EASY:
                    {
                        max_for_wrong_answer = MAX_WEIGHTS_EASY/2;
                        max_for_dont_know = MAX_WEIGHTS_EASY / 5;
                        break;
                    }
                    

                case Level.MEDIUM:
                    {
                        max_for_wrong_answer = MAX_WEIGHTS_MEDIUM/2;
                        max_for_dont_know = MAX_WEIGHTS_MEDIUM / 3;
                        break;
                    }

                case Level.HARD:
                    {
                        max_for_wrong_answer = MAX_WEIGHTS_HARD;
                        max_for_dont_know = MAX_WEIGHTS_HARD;
                        break;
                    }
            }

            int[] value_for_answers = new int[5];

            if (is_lifeline_5050_just_used)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i == index_true_answer)
                        value_for_answers[i] = random_obj.Next(100);
                    else
                    {
                        if (i == index_wrong_answer)
                            value_for_answers[i] = random_obj.Next(max_for_wrong_answer);
                        else
                        {
                            if (i == 4)
                                value_for_answers[i] = random_obj.Next(max_for_dont_know);
                            else
                                value_for_answers[i] = 0;
                        }
                    }

                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i == index_true_answer)
                        value_for_answers[i] = random_obj.Next(100);
                    else
                    {

                        if (i == 4)
                            value_for_answers[i] = random_obj.Next(max_for_dont_know);
                        else
                            value_for_answers[i] = random_obj.Next(max_for_wrong_answer);

                    }
                }
            }

            int max_value = value_for_answers[0];
            int index_max_value = 0;
            for (int i = 1; i < 4; i++)
            {
                if (max_value < value_for_answers[i])
                {
                    max_value = value_for_answers[i];
                    index_max_value = i;
                }
            }

            string_answer = answer_names[index_max_value].ToLower();


            //random for DONT_KNOW:


            return string_answer;
        }

        private void whenSoundPhoneCall_ended(object sender, EventArgs e)
        {
            string answer_phone_call = generatePhoneCallAnswer();
          
            if (answer_phone_call == "dont_know")
            {
                btn_PhoneCall.BackgroundImage = Properties.Resources.do_i_know_u;
            }
            else
            {
                btn_PhoneCall.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("green_" + answer_phone_call + "_md");
            }
            startTimer30s_and_PlayTicktac();

            unlockEnabledPanelButtons(panel_QuesAns);
            unlockEnabledPanelButtons(panel_Lifelines);
            btn_StartGame.Enabled = true;
        }


        private void btn_PhoneCall_Click(object sender, EventArgs e)
        {
            pauseTimer30s_and_PlayTicktac();

            // turn off others sound
            if (sound_5050_2wrongOpitions != null)
                sound_5050_2wrongOpitions.Stop();

            lifeline_phoneCall_is_used = true;

            btn_PhoneCall.BackgroundImage = Properties.Resources.btn_phoneCall_used;
            btn_PhoneCall.Enabled = false;
            lockEnabledPanelButtons(panel_Lifelines);
            lockEnabledPanelButtons(panel_QuesAns);
            btn_StartGame.Enabled = false;

            //timer_changingQues.Start();
            sound_phone_call.MediaEnded += new EventHandler(whenSoundPhoneCall_ended);
            sound_phone_call.Open(uri_phone_call);
            sound_phone_call.Play();
        }

        private void formChartClosed()
        {
            if (audio_question != null)
                audio_question.Stop();
            startTimer30s_and_PlayTicktac();

            unlockEnabledPanelButtons(panel_QuesAns);
            unlockEnabledPanelButtons(panel_Lifelines);
            btn_StartGame.Enabled = true;

        }

        private void whenFormChart_Closed(object sender, EventArgs e)
        {
            timer_hide_chart.Stop();
            formChartClosed();
        }


     
        private double[] generateWeightChart(int max_for_wrong_answer)
        {
          
            List<string> answer_names = new List<string>() { "A", "B", "C", "D" };

            string true_answer = cur_question.trueAns;

            int index_true_answer = answer_names.IndexOf(true_answer);
            int index_wrong_answer = answer_names.IndexOf(wrong_answer);


            double[] percent_of_answers = new double[4];

            if (is_lifeline_5050_just_used)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == index_true_answer)
                        percent_of_answers[i] = random_obj.Next(100);
                    else
                    {
                        if (i == index_wrong_answer)
                            percent_of_answers[i] = random_obj.Next(max_for_wrong_answer);
                        else
                            percent_of_answers[i] = 0;
                    }
                       
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == index_true_answer)
                        percent_of_answers[i] = random_obj.Next(100);
                    else
                        percent_of_answers[i] = random_obj.Next(max_for_wrong_answer);
                }
            }
          
           


            //scale to [0-100%]
            double sum = percent_of_answers.Sum();
            for (int i = 0; i < 4; i++)
            {
                percent_of_answers[i] = Math.Round(percent_of_answers[i]/sum, 2);
            }
                
            //ensure the sum of 4 options equals 100%
            percent_of_answers[3] = Math.Round(1 - percent_of_answers[0] - percent_of_answers[1] - percent_of_answers[2], 2);

            return percent_of_answers;
        }

        private void whenSoundAudience_ended(object sender, EventArgs e)
        {
            Level cur_level = getLevelGame();


            //generate random with weights:
            double[] percent_of_answers = { };
            switch (cur_level)
            {
                case Level.EASY:
                    {
                        percent_of_answers = generateWeightChart(MAX_WEIGHTS_EASY);
                        break;
                    }
                case Level.MEDIUM: 
                    {
                        percent_of_answers = generateWeightChart(MAX_WEIGHTS_MEDIUM);
                        break;
                    }
                case Level.HARD:
                    {
                        percent_of_answers = generateWeightChart(MAX_WEIGHTS_HARD);
                        break;
                    }
            }

            form_chart = new Form_Chart(percent_of_answers);
            form_chart.Visible = true;
            form_chart.FormClosed += new FormClosedEventHandler(whenFormChart_Closed);
            timer_hide_chart.Start();

        }
        private void btn_Audience_Click(object sender, EventArgs e)
        {
            pauseTimer30s_and_PlayTicktac();

            // turn off others sound
            if (sound_5050_2wrongOpitions != null)
                sound_5050_2wrongOpitions.Stop();

            lifeline_audience_is_used = true;

            btn_Audience.BackgroundImage = Properties.Resources.btn_audience_used;
            btn_Audience.Enabled = false;
            lockEnabledPanelButtons(panel_Lifelines);
            lockEnabledPanelButtons(panel_QuesAns);
            btn_StartGame.Enabled = false;

            //timer_changingQues.Start();
            sound_audience.MediaEnded += new EventHandler(whenSoundAudience_ended);
            sound_audience.Open(uri_ask_audience);
            sound_audience.Play();
        }

        private void timer_hide_chart_Tick(object sender, EventArgs e)
        {
            timer_hide_chart.Stop();
            form_chart.Close();

        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Author form_author = new Form_Author();

            form_author.BackgroundImage = (Image)obj_image_background;
            form_author.ShowDialog();
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game: Ai Là Triệu Phú \nVersion 1.8 \nPhiên bản Chim Cánh Cụt", "Ai Là Triệu Phú ", MessageBoxButtons.OK);
        }

        private void menu_top10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa cập nhật !", "Top 10", MessageBoxButtons.OK);
        }
    }//end class
}//end file
