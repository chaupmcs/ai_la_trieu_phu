namespace AiLaTrieuPhu
{
    partial class Form_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Game));
            this.panel_QuesAns = new System.Windows.Forms.Panel();
            this.btn_skip = new System.Windows.Forms.Button();
            this.picBox1_Timer = new System.Windows.Forms.PictureBox();
            this.btn_AnswerC = new System.Windows.Forms.Button();
            this.btn_Question = new System.Windows.Forms.Button();
            this.btn_AnswerA = new System.Windows.Forms.Button();
            this.btn_AnswerB = new System.Windows.Forms.Button();
            this.btn_AnswerD = new System.Windows.Forms.Button();
            this.panel_Lifelines = new System.Windows.Forms.Panel();
            this.btn_Audience = new System.Windows.Forms.Button();
            this.btn_PhoneCall = new System.Windows.Forms.Button();
            this.btn_50_50 = new System.Windows.Forms.Button();
            this.btn_ChangeQues = new System.Windows.Forms.Button();
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.panel_15Milestones = new System.Windows.Forms.Panel();
            this.btn_Milestone12 = new System.Windows.Forms.Button();
            this.btn_Milestone13 = new System.Windows.Forms.Button();
            this.btn_Milestone14 = new System.Windows.Forms.Button();
            this.btn_Milestone15 = new System.Windows.Forms.Button();
            this.btn_Milestone11 = new System.Windows.Forms.Button();
            this.btn_Milestone8 = new System.Windows.Forms.Button();
            this.btn_Milestone9 = new System.Windows.Forms.Button();
            this.btn_Milestone10 = new System.Windows.Forms.Button();
            this.btn_Milestone1 = new System.Windows.Forms.Button();
            this.btn_Milestone7 = new System.Windows.Forms.Button();
            this.btn_Milestone3 = new System.Windows.Forms.Button();
            this.btn_Milestone4 = new System.Windows.Forms.Button();
            this.btn_Milestone5 = new System.Windows.Forms.Button();
            this.btn_Milestone6 = new System.Windows.Forms.Button();
            this.btn_Milestone2 = new System.Windows.Forms.Button();
            this.panel_Screen = new AiLaTrieuPhu.NoFlickeringPanel();
            this.timer_highlightIntro = new System.Windows.Forms.Timer(this.components);
            this.timer_30s = new System.Windows.Forms.Timer(this.components);
            this.timer_Flickering = new System.Windows.Forms.Timer(this.components);
            this.timer_changingQues = new System.Windows.Forms.Timer(this.components);
            this.timer_hide_chart = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_highScore = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_top10 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_theGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_author = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel_QuesAns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1_Timer)).BeginInit();
            this.panel_Lifelines.SuspendLayout();
            this.panel_15Milestones.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_QuesAns
            // 
            this.panel_QuesAns.BackColor = System.Drawing.Color.Transparent;
            this.panel_QuesAns.Controls.Add(this.btn_skip);
            this.panel_QuesAns.Controls.Add(this.picBox1_Timer);
            this.panel_QuesAns.Controls.Add(this.btn_AnswerC);
            this.panel_QuesAns.Controls.Add(this.btn_Question);
            this.panel_QuesAns.Controls.Add(this.btn_AnswerA);
            this.panel_QuesAns.Controls.Add(this.btn_AnswerB);
            this.panel_QuesAns.Controls.Add(this.btn_AnswerD);
            this.panel_QuesAns.Location = new System.Drawing.Point(14, 583);
            this.panel_QuesAns.Margin = new System.Windows.Forms.Padding(6);
            this.panel_QuesAns.Name = "panel_QuesAns";
            this.panel_QuesAns.Size = new System.Drawing.Size(1038, 387);
            this.panel_QuesAns.TabIndex = 0;
            this.panel_QuesAns.Visible = false;
            // 
            // btn_skip
            // 
            this.btn_skip.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_skip;
            this.btn_skip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_skip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_skip.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_skip.Location = new System.Drawing.Point(848, 19);
            this.btn_skip.Margin = new System.Windows.Forms.Padding(6);
            this.btn_skip.Name = "btn_skip";
            this.btn_skip.Size = new System.Drawing.Size(124, 117);
            this.btn_skip.TabIndex = 8;
            this.btn_skip.UseVisualStyleBackColor = false;
            this.btn_skip.Visible = false;
            this.btn_skip.Click += new System.EventHandler(this.btn_skip_Click);
            // 
            // picBox1_Timer
            // 
            this.picBox1_Timer.BackColor = System.Drawing.Color.Transparent;
            this.picBox1_Timer.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.Penguin_btn_3;
            this.picBox1_Timer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox1_Timer.Location = new System.Drawing.Point(848, 19);
            this.picBox1_Timer.Margin = new System.Windows.Forms.Padding(6);
            this.picBox1_Timer.Name = "picBox1_Timer";
            this.picBox1_Timer.Size = new System.Drawing.Size(124, 125);
            this.picBox1_Timer.TabIndex = 7;
            this.picBox1_Timer.TabStop = false;
            // 
            // btn_AnswerC
            // 
            this.btn_AnswerC.BackColor = System.Drawing.Color.Transparent;
            this.btn_AnswerC.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_blue_answer;
            this.btn_AnswerC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AnswerC.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_AnswerC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btn_AnswerC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_AnswerC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_AnswerC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnswerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnswerC.Location = new System.Drawing.Point(14, 267);
            this.btn_AnswerC.Margin = new System.Windows.Forms.Padding(6);
            this.btn_AnswerC.Name = "btn_AnswerC";
            this.btn_AnswerC.Size = new System.Drawing.Size(500, 102);
            this.btn_AnswerC.TabIndex = 6;
            this.btn_AnswerC.UseVisualStyleBackColor = false;
            this.btn_AnswerC.Click += new System.EventHandler(this.btn_AnswerC_Click);
            // 
            // btn_Question
            // 
            this.btn_Question.BackColor = System.Drawing.Color.Transparent;
            this.btn_Question.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_question;
            this.btn_Question.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Question.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_Question.FlatAppearance.BorderSize = 0;
            this.btn_Question.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Question.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Question.Location = new System.Drawing.Point(24, 8);
            this.btn_Question.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Question.Name = "btn_Question";
            this.btn_Question.Size = new System.Drawing.Size(812, 138);
            this.btn_Question.TabIndex = 2;
            this.btn_Question.UseVisualStyleBackColor = false;
            // 
            // btn_AnswerA
            // 
            this.btn_AnswerA.BackColor = System.Drawing.Color.Transparent;
            this.btn_AnswerA.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_blue_answer;
            this.btn_AnswerA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AnswerA.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_AnswerA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btn_AnswerA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_AnswerA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_AnswerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnswerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnswerA.Location = new System.Drawing.Point(14, 156);
            this.btn_AnswerA.Margin = new System.Windows.Forms.Padding(6);
            this.btn_AnswerA.Name = "btn_AnswerA";
            this.btn_AnswerA.Size = new System.Drawing.Size(500, 102);
            this.btn_AnswerA.TabIndex = 5;
            this.btn_AnswerA.UseVisualStyleBackColor = false;
            this.btn_AnswerA.Click += new System.EventHandler(this.btn_AnswerA_Click);
            // 
            // btn_AnswerB
            // 
            this.btn_AnswerB.BackColor = System.Drawing.Color.Transparent;
            this.btn_AnswerB.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_blue_answer;
            this.btn_AnswerB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AnswerB.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_AnswerB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_AnswerB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_AnswerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnswerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnswerB.Location = new System.Drawing.Point(510, 156);
            this.btn_AnswerB.Margin = new System.Windows.Forms.Padding(6);
            this.btn_AnswerB.Name = "btn_AnswerB";
            this.btn_AnswerB.Size = new System.Drawing.Size(500, 102);
            this.btn_AnswerB.TabIndex = 3;
            this.btn_AnswerB.UseVisualStyleBackColor = false;
            this.btn_AnswerB.Click += new System.EventHandler(this.btn_AnswerB_Click);
            // 
            // btn_AnswerD
            // 
            this.btn_AnswerD.BackColor = System.Drawing.Color.Transparent;
            this.btn_AnswerD.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_blue_answer;
            this.btn_AnswerD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AnswerD.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_AnswerD.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btn_AnswerD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_AnswerD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_AnswerD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnswerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnswerD.Location = new System.Drawing.Point(510, 267);
            this.btn_AnswerD.Margin = new System.Windows.Forms.Padding(6);
            this.btn_AnswerD.Name = "btn_AnswerD";
            this.btn_AnswerD.Size = new System.Drawing.Size(500, 102);
            this.btn_AnswerD.TabIndex = 4;
            this.btn_AnswerD.UseVisualStyleBackColor = false;
            this.btn_AnswerD.Click += new System.EventHandler(this.btn_AnswerD_Click);
            // 
            // panel_Lifelines
            // 
            this.panel_Lifelines.BackColor = System.Drawing.Color.Transparent;
            this.panel_Lifelines.Controls.Add(this.btn_Audience);
            this.panel_Lifelines.Controls.Add(this.btn_PhoneCall);
            this.panel_Lifelines.Controls.Add(this.btn_50_50);
            this.panel_Lifelines.Controls.Add(this.btn_ChangeQues);
            this.panel_Lifelines.Location = new System.Drawing.Point(820, 8);
            this.panel_Lifelines.Margin = new System.Windows.Forms.Padding(6);
            this.panel_Lifelines.Name = "panel_Lifelines";
            this.panel_Lifelines.Size = new System.Drawing.Size(192, 571);
            this.panel_Lifelines.TabIndex = 2;
            this.panel_Lifelines.Visible = false;
            // 
            // btn_Audience
            // 
            this.btn_Audience.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_audience;
            this.btn_Audience.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Audience.Location = new System.Drawing.Point(18, 427);
            this.btn_Audience.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Audience.Name = "btn_Audience";
            this.btn_Audience.Size = new System.Drawing.Size(148, 125);
            this.btn_Audience.TabIndex = 2;
            this.btn_Audience.UseVisualStyleBackColor = true;
            this.btn_Audience.Click += new System.EventHandler(this.btn_Audience_Click);
            // 
            // btn_PhoneCall
            // 
            this.btn_PhoneCall.BackColor = System.Drawing.SystemColors.Control;
            this.btn_PhoneCall.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_phoneCall;
            this.btn_PhoneCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PhoneCall.Location = new System.Drawing.Point(18, 288);
            this.btn_PhoneCall.Margin = new System.Windows.Forms.Padding(6);
            this.btn_PhoneCall.Name = "btn_PhoneCall";
            this.btn_PhoneCall.Size = new System.Drawing.Size(148, 125);
            this.btn_PhoneCall.TabIndex = 1;
            this.btn_PhoneCall.UseVisualStyleBackColor = false;
            this.btn_PhoneCall.Click += new System.EventHandler(this.btn_PhoneCall_Click);
            // 
            // btn_50_50
            // 
            this.btn_50_50.BackColor = System.Drawing.SystemColors.Control;
            this.btn_50_50.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_50_50;
            this.btn_50_50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_50_50.Location = new System.Drawing.Point(18, 150);
            this.btn_50_50.Margin = new System.Windows.Forms.Padding(6);
            this.btn_50_50.Name = "btn_50_50";
            this.btn_50_50.Size = new System.Drawing.Size(148, 125);
            this.btn_50_50.TabIndex = 1;
            this.btn_50_50.UseVisualStyleBackColor = false;
            this.btn_50_50.Click += new System.EventHandler(this.btn_50_50_Click);
            // 
            // btn_ChangeQues
            // 
            this.btn_ChangeQues.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_changeQuestion;
            this.btn_ChangeQues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ChangeQues.Location = new System.Drawing.Point(18, 13);
            this.btn_ChangeQues.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ChangeQues.Name = "btn_ChangeQues";
            this.btn_ChangeQues.Size = new System.Drawing.Size(148, 125);
            this.btn_ChangeQues.TabIndex = 0;
            this.btn_ChangeQues.UseVisualStyleBackColor = true;
            this.btn_ChangeQues.Click += new System.EventHandler(this.btn_ChangeQues_Click);
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartGame.Location = new System.Drawing.Point(1144, 881);
            this.btn_StartGame.Margin = new System.Windows.Forms.Padding(6);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(184, 88);
            this.btn_StartGame.TabIndex = 4;
            this.btn_StartGame.Text = "BẮT ĐẦU";
            this.btn_StartGame.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_StartGame.UseVisualStyleBackColor = false;
            this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click);
            // 
            // panel_15Milestones
            // 
            this.panel_15Milestones.BackColor = System.Drawing.Color.Transparent;
            this.panel_15Milestones.Controls.Add(this.btn_Milestone12);
            this.panel_15Milestones.Controls.Add(this.btn_Milestone13);
            this.panel_15Milestones.Controls.Add(this.btn_Milestone14);
            this.panel_15Milestones.Controls.Add(this.btn_Milestone15);
            this.panel_15Milestones.Controls.Add(this.btn_Milestone11);
            this.panel_15Milestones.Controls.Add(this.btn_Milestone8);
            this.panel_15Milestones.Controls.Add(this.btn_Milestone9);
            this.panel_15Milestones.Controls.Add(this.btn_Milestone10);
            this.panel_15Milestones.Controls.Add(this.btn_Milestone1);
            this.panel_15Milestones.Controls.Add(this.btn_Milestone7);
            this.panel_15Milestones.Controls.Add(this.btn_Milestone3);
            this.panel_15Milestones.Controls.Add(this.btn_Milestone4);
            this.panel_15Milestones.Controls.Add(this.btn_Milestone5);
            this.panel_15Milestones.Controls.Add(this.btn_Milestone6);
            this.panel_15Milestones.Controls.Add(this.btn_Milestone2);
            this.panel_15Milestones.Location = new System.Drawing.Point(1034, 8);
            this.panel_15Milestones.Margin = new System.Windows.Forms.Padding(6);
            this.panel_15Milestones.Name = "panel_15Milestones";
            this.panel_15Milestones.Size = new System.Drawing.Size(294, 856);
            this.panel_15Milestones.TabIndex = 1;
            this.panel_15Milestones.Visible = false;
            // 
            // btn_Milestone12
            // 
            this.btn_Milestone12.BackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone12.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_green_chubby;
            this.btn_Milestone12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Milestone12.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Milestone12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Milestone12.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Milestone12.Location = new System.Drawing.Point(12, 181);
            this.btn_Milestone12.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Milestone12.Name = "btn_Milestone12";
            this.btn_Milestone12.Size = new System.Drawing.Size(268, 44);
            this.btn_Milestone12.TabIndex = 14;
            this.btn_Milestone12.Text = "12 - 75,000,000";
            this.btn_Milestone12.UseVisualStyleBackColor = false;
            // 
            // btn_Milestone13
            // 
            this.btn_Milestone13.BackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone13.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_green_chubby;
            this.btn_Milestone13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Milestone13.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Milestone13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Milestone13.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Milestone13.Location = new System.Drawing.Point(12, 125);
            this.btn_Milestone13.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Milestone13.Name = "btn_Milestone13";
            this.btn_Milestone13.Size = new System.Drawing.Size(268, 44);
            this.btn_Milestone13.TabIndex = 13;
            this.btn_Milestone13.Text = "13 - 100,000,000";
            this.btn_Milestone13.UseVisualStyleBackColor = false;
            // 
            // btn_Milestone14
            // 
            this.btn_Milestone14.BackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone14.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_green_chubby;
            this.btn_Milestone14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Milestone14.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Milestone14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Milestone14.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Milestone14.Location = new System.Drawing.Point(12, 69);
            this.btn_Milestone14.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Milestone14.Name = "btn_Milestone14";
            this.btn_Milestone14.Size = new System.Drawing.Size(268, 44);
            this.btn_Milestone14.TabIndex = 12;
            this.btn_Milestone14.Text = "14 - 150,000,000";
            this.btn_Milestone14.UseVisualStyleBackColor = false;
            // 
            // btn_Milestone15
            // 
            this.btn_Milestone15.BackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone15.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_darkblue;
            this.btn_Milestone15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Milestone15.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Milestone15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Milestone15.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Milestone15.Location = new System.Drawing.Point(12, 13);
            this.btn_Milestone15.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Milestone15.Name = "btn_Milestone15";
            this.btn_Milestone15.Size = new System.Drawing.Size(268, 44);
            this.btn_Milestone15.TabIndex = 11;
            this.btn_Milestone15.Text = "15 - 500,000,000";
            this.btn_Milestone15.UseVisualStyleBackColor = false;
            // 
            // btn_Milestone11
            // 
            this.btn_Milestone11.BackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone11.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_green_chubby;
            this.btn_Milestone11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Milestone11.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Milestone11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Milestone11.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Milestone11.Location = new System.Drawing.Point(12, 237);
            this.btn_Milestone11.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Milestone11.Name = "btn_Milestone11";
            this.btn_Milestone11.Size = new System.Drawing.Size(268, 44);
            this.btn_Milestone11.TabIndex = 10;
            this.btn_Milestone11.Text = "11 - 55,000,000";
            this.btn_Milestone11.UseVisualStyleBackColor = false;
            // 
            // btn_Milestone8
            // 
            this.btn_Milestone8.BackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone8.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_green_chubby;
            this.btn_Milestone8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Milestone8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Milestone8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Milestone8.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Milestone8.Location = new System.Drawing.Point(12, 408);
            this.btn_Milestone8.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Milestone8.Name = "btn_Milestone8";
            this.btn_Milestone8.Size = new System.Drawing.Size(268, 44);
            this.btn_Milestone8.TabIndex = 9;
            this.btn_Milestone8.Text = "8 - 20,000,000";
            this.btn_Milestone8.UseVisualStyleBackColor = false;
            // 
            // btn_Milestone9
            // 
            this.btn_Milestone9.BackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone9.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_green_chubby;
            this.btn_Milestone9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Milestone9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Milestone9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Milestone9.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Milestone9.Location = new System.Drawing.Point(12, 348);
            this.btn_Milestone9.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Milestone9.Name = "btn_Milestone9";
            this.btn_Milestone9.Size = new System.Drawing.Size(268, 44);
            this.btn_Milestone9.TabIndex = 8;
            this.btn_Milestone9.Text = "9 - 30,000,000";
            this.btn_Milestone9.UseVisualStyleBackColor = false;
            // 
            // btn_Milestone10
            // 
            this.btn_Milestone10.BackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone10.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_darkblue;
            this.btn_Milestone10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Milestone10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Milestone10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Milestone10.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Milestone10.Location = new System.Drawing.Point(12, 292);
            this.btn_Milestone10.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Milestone10.Name = "btn_Milestone10";
            this.btn_Milestone10.Size = new System.Drawing.Size(268, 44);
            this.btn_Milestone10.TabIndex = 7;
            this.btn_Milestone10.Text = "10 - 42,000,000";
            this.btn_Milestone10.UseVisualStyleBackColor = false;
            // 
            // btn_Milestone1
            // 
            this.btn_Milestone1.BackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone1.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_green_chubby;
            this.btn_Milestone1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Milestone1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Milestone1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Milestone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Milestone1.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Milestone1.Location = new System.Drawing.Point(12, 806);
            this.btn_Milestone1.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Milestone1.Name = "btn_Milestone1";
            this.btn_Milestone1.Size = new System.Drawing.Size(268, 44);
            this.btn_Milestone1.TabIndex = 6;
            this.btn_Milestone1.Text = "1 - 200,000";
            this.btn_Milestone1.UseVisualStyleBackColor = false;
            // 
            // btn_Milestone7
            // 
            this.btn_Milestone7.BackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone7.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_green_chubby;
            this.btn_Milestone7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Milestone7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Milestone7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Milestone7.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Milestone7.Location = new System.Drawing.Point(12, 467);
            this.btn_Milestone7.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Milestone7.Name = "btn_Milestone7";
            this.btn_Milestone7.Size = new System.Drawing.Size(268, 44);
            this.btn_Milestone7.TabIndex = 5;
            this.btn_Milestone7.Text = "7 - 14,000,000";
            this.btn_Milestone7.UseVisualStyleBackColor = false;
            // 
            // btn_Milestone3
            // 
            this.btn_Milestone3.BackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone3.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_green_chubby;
            this.btn_Milestone3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Milestone3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Milestone3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Milestone3.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Milestone3.Location = new System.Drawing.Point(12, 696);
            this.btn_Milestone3.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Milestone3.Name = "btn_Milestone3";
            this.btn_Milestone3.Size = new System.Drawing.Size(268, 44);
            this.btn_Milestone3.TabIndex = 4;
            this.btn_Milestone3.Text = "3 - 1,000,000";
            this.btn_Milestone3.UseVisualStyleBackColor = false;
            // 
            // btn_Milestone4
            // 
            this.btn_Milestone4.BackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone4.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_green_chubby;
            this.btn_Milestone4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Milestone4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Milestone4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Milestone4.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Milestone4.Location = new System.Drawing.Point(12, 640);
            this.btn_Milestone4.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Milestone4.Name = "btn_Milestone4";
            this.btn_Milestone4.Size = new System.Drawing.Size(268, 44);
            this.btn_Milestone4.TabIndex = 3;
            this.btn_Milestone4.Text = "4 - 3,000,000";
            this.btn_Milestone4.UseVisualStyleBackColor = false;
            // 
            // btn_Milestone5
            // 
            this.btn_Milestone5.BackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone5.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_darkblue;
            this.btn_Milestone5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Milestone5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Milestone5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Milestone5.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Milestone5.Location = new System.Drawing.Point(12, 585);
            this.btn_Milestone5.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Milestone5.Name = "btn_Milestone5";
            this.btn_Milestone5.Size = new System.Drawing.Size(268, 44);
            this.btn_Milestone5.TabIndex = 2;
            this.btn_Milestone5.Text = "5 - 6,000,000";
            this.btn_Milestone5.UseVisualStyleBackColor = false;
            // 
            // btn_Milestone6
            // 
            this.btn_Milestone6.BackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone6.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_green_chubby;
            this.btn_Milestone6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Milestone6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Milestone6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Milestone6.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Milestone6.Location = new System.Drawing.Point(12, 529);
            this.btn_Milestone6.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Milestone6.Name = "btn_Milestone6";
            this.btn_Milestone6.Size = new System.Drawing.Size(268, 44);
            this.btn_Milestone6.TabIndex = 1;
            this.btn_Milestone6.Text = "6 - 10,000,000";
            this.btn_Milestone6.UseVisualStyleBackColor = false;
            // 
            // btn_Milestone2
            // 
            this.btn_Milestone2.BackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone2.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.btn_green_chubby;
            this.btn_Milestone2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Milestone2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Milestone2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Milestone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Milestone2.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Milestone2.Location = new System.Drawing.Point(12, 752);
            this.btn_Milestone2.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Milestone2.Name = "btn_Milestone2";
            this.btn_Milestone2.Size = new System.Drawing.Size(268, 44);
            this.btn_Milestone2.TabIndex = 0;
            this.btn_Milestone2.Text = "2 - 400,000";
            this.btn_Milestone2.UseVisualStyleBackColor = false;
            // 
            // panel_Screen
            // 
            this.panel_Screen.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.LaiVanSam_2;
            this.panel_Screen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Screen.Location = new System.Drawing.Point(24, 21);
            this.panel_Screen.Margin = new System.Windows.Forms.Padding(6);
            this.panel_Screen.Name = "panel_Screen";
            this.panel_Screen.Size = new System.Drawing.Size(764, 538);
            this.panel_Screen.TabIndex = 3;
            this.panel_Screen.Visible = false;
            // 
            // timer_highlightIntro
            // 
            this.timer_highlightIntro.Interval = 500;
            this.timer_highlightIntro.Tick += new System.EventHandler(this.timer_highlightIntro_Tick);
            // 
            // timer_30s
            // 
            this.timer_30s.Interval = 1000;
            this.timer_30s.Tick += new System.EventHandler(this.timer_30s_Tick);
            // 
            // timer_Flickering
            // 
            this.timer_Flickering.Interval = 250;
            this.timer_Flickering.Tick += new System.EventHandler(this.timer_Flickering_Tick);
            // 
            // timer_changingQues
            // 
            this.timer_changingQues.Interval = 50;
            this.timer_changingQues.Tick += new System.EventHandler(this.timer_changingQues_Tick);
            // 
            // timer_hide_chart
            // 
            this.timer_hide_chart.Interval = 3000;
            this.timer_hide_chart.Tick += new System.EventHandler(this.timer_hide_chart_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_highScore,
            this.menu_about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1334, 44);
            this.menuStrip1.TabIndex = 5;
            // 
            // menu_highScore
            // 
            this.menu_highScore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_top10});
            this.menu_highScore.Name = "menu_highScore";
            this.menu_highScore.Size = new System.Drawing.Size(128, 36);
            this.menu_highScore.Text = "Điểm cao";
            // 
            // menu_top10
            // 
            this.menu_top10.Name = "menu_top10";
            this.menu_top10.Size = new System.Drawing.Size(186, 38);
            this.menu_top10.Text = "Top 10";
            this.menu_top10.Click += new System.EventHandler(this.menu_top10_Click);
            // 
            // menu_about
            // 
            this.menu_about.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_theGame,
            this.menu_author});
            this.menu_about.Name = "menu_about";
            this.menu_about.Size = new System.Drawing.Size(92, 36);
            this.menu_about.Text = "About";
            // 
            // menu_theGame
            // 
            this.menu_theGame.Name = "menu_theGame";
            this.menu_theGame.Size = new System.Drawing.Size(272, 38);
            this.menu_theGame.Text = "Ai Là Triệu Phú";
            this.menu_theGame.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // menu_author
            // 
            this.menu_author.Name = "menu_author";
            this.menu_author.Size = new System.Drawing.Size(272, 38);
            this.menu_author.Text = "Tác giả";
            this.menu_author.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1334, 973);
            this.Controls.Add(this.btn_StartGame);
            this.Controls.Add(this.panel_Screen);
            this.Controls.Add(this.panel_Lifelines);
            this.Controls.Add(this.panel_15Milestones);
            this.Controls.Add(this.panel_QuesAns);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ai Là Triệu Phú -  Version 1.8";
            this.Load += new System.EventHandler(this.Form_Game_Load);
            this.SizeChanged += new System.EventHandler(this.Form_Game_SizeChanged);
            this.panel_QuesAns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1_Timer)).EndInit();
            this.panel_Lifelines.ResumeLayout(false);
            this.panel_15Milestones.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_QuesAns;
        private System.Windows.Forms.Panel panel_15Milestones;
        private System.Windows.Forms.Button btn_AnswerC;
        private System.Windows.Forms.Button btn_Question;
        private System.Windows.Forms.Button btn_AnswerA;
        private System.Windows.Forms.Button btn_AnswerB;
        private System.Windows.Forms.Button btn_AnswerD;
        private System.Windows.Forms.Panel panel_Lifelines;
        private System.Windows.Forms.Button btn_Audience;
        private System.Windows.Forms.Button btn_50_50;
        private System.Windows.Forms.Button btn_ChangeQues;
        private System.Windows.Forms.Button btn_Milestone12;
        private System.Windows.Forms.Button btn_Milestone13;
        private System.Windows.Forms.Button btn_Milestone14;
        private System.Windows.Forms.Button btn_Milestone15;
        private System.Windows.Forms.Button btn_Milestone11;
        private System.Windows.Forms.Button btn_Milestone8;
        private System.Windows.Forms.Button btn_Milestone9;
        private System.Windows.Forms.Button btn_Milestone10;
        private System.Windows.Forms.Button btn_Milestone1;
        private System.Windows.Forms.Button btn_Milestone7;
        private System.Windows.Forms.Button btn_Milestone3;
        private System.Windows.Forms.Button btn_Milestone4;
        private System.Windows.Forms.Button btn_Milestone5;
        private System.Windows.Forms.Button btn_Milestone6;
        private System.Windows.Forms.Button btn_Milestone2;
        private System.Windows.Forms.Button btn_StartGame;
        private System.Windows.Forms.Timer timer_highlightIntro;
        private System.Windows.Forms.Button btn_PhoneCall;
        private System.Windows.Forms.Timer timer_30s;
        private System.Windows.Forms.PictureBox picBox1_Timer;
        private System.Windows.Forms.Timer timer_Flickering;
        private System.Windows.Forms.Timer timer_changingQues;
        private System.Windows.Forms.Button btn_skip;
        private System.Windows.Forms.Timer timer_hide_chart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_about;
        private System.Windows.Forms.ToolStripMenuItem menu_theGame;
        private System.Windows.Forms.ToolStripMenuItem menu_author;
        private System.Windows.Forms.ToolStripMenuItem menu_highScore;
        private System.Windows.Forms.ToolStripMenuItem menu_top10;
        private NoFlickeringPanel panel_Screen;
    }
}