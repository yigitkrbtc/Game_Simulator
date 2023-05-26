namespace GameSimulator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gamecreating = new System.Windows.Forms.GroupBox();
            this.creategamebutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.player2NameTextBox = new System.Windows.Forms.TextBox();
            this.player1NameTextBox = new System.Windows.Forms.TextBox();
            this.gameloading = new System.Windows.Forms.GroupBox();
            this.loadgamebutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loadplayer2 = new System.Windows.Forms.TextBox();
            this.loadplayer1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gamescorelabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.score2TextBox = new System.Windows.Forms.TextBox();
            this.score1TextBox = new System.Windows.Forms.TextBox();
            this.simulategamebutton = new System.Windows.Forms.Button();
            this.gamecreating.SuspendLayout();
            this.gameloading.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamecreating
            // 
            this.gamecreating.Controls.Add(this.creategamebutton);
            this.gamecreating.Controls.Add(this.label2);
            this.gamecreating.Controls.Add(this.label1);
            this.gamecreating.Controls.Add(this.player2NameTextBox);
            this.gamecreating.Controls.Add(this.player1NameTextBox);
            this.gamecreating.Location = new System.Drawing.Point(25, 12);
            this.gamecreating.Name = "gamecreating";
            this.gamecreating.Size = new System.Drawing.Size(289, 140);
            this.gamecreating.TabIndex = 0;
            this.gamecreating.TabStop = false;
            this.gamecreating.Text = "Creating Game";
            // 
            // creategamebutton
            // 
            this.creategamebutton.Location = new System.Drawing.Point(176, 103);
            this.creategamebutton.Name = "creategamebutton";
            this.creategamebutton.Size = new System.Drawing.Size(94, 25);
            this.creategamebutton.TabIndex = 4;
            this.creategamebutton.Text = "Create Game";
            this.creategamebutton.UseVisualStyleBackColor = true;
            this.creategamebutton.Click += new System.EventHandler(this.creategamebutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player 1";
            // 
            // player2NameTextBox
            // 
            this.player2NameTextBox.Location = new System.Drawing.Point(96, 77);
            this.player2NameTextBox.Name = "player2NameTextBox";
            this.player2NameTextBox.Size = new System.Drawing.Size(174, 20);
            this.player2NameTextBox.TabIndex = 1;
            // 
            // player1NameTextBox
            // 
            this.player1NameTextBox.Location = new System.Drawing.Point(96, 35);
            this.player1NameTextBox.Name = "player1NameTextBox";
            this.player1NameTextBox.Size = new System.Drawing.Size(174, 20);
            this.player1NameTextBox.TabIndex = 0;
            // 
            // gameloading
            // 
            this.gameloading.Controls.Add(this.loadgamebutton);
            this.gameloading.Controls.Add(this.label4);
            this.gameloading.Controls.Add(this.label3);
            this.gameloading.Controls.Add(this.loadplayer2);
            this.gameloading.Controls.Add(this.loadplayer1);
            this.gameloading.Location = new System.Drawing.Point(25, 168);
            this.gameloading.Name = "gameloading";
            this.gameloading.Size = new System.Drawing.Size(289, 140);
            this.gameloading.TabIndex = 1;
            this.gameloading.TabStop = false;
            this.gameloading.Text = "Loading Game";
            // 
            // loadgamebutton
            // 
            this.loadgamebutton.Location = new System.Drawing.Point(176, 104);
            this.loadgamebutton.Name = "loadgamebutton";
            this.loadgamebutton.Size = new System.Drawing.Size(94, 25);
            this.loadgamebutton.TabIndex = 5;
            this.loadgamebutton.Text = "Load Game";
            this.loadgamebutton.UseVisualStyleBackColor = true;
            this.loadgamebutton.Click += new System.EventHandler(this.loadgamebutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Player 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player 1";
            // 
            // loadplayer2
            // 
            this.loadplayer2.Location = new System.Drawing.Point(96, 78);
            this.loadplayer2.Name = "loadplayer2";
            this.loadplayer2.Size = new System.Drawing.Size(174, 20);
            this.loadplayer2.TabIndex = 3;
            // 
            // loadplayer1
            // 
            this.loadplayer1.Location = new System.Drawing.Point(96, 36);
            this.loadplayer1.Name = "loadplayer1";
            this.loadplayer1.Size = new System.Drawing.Size(174, 20);
            this.loadplayer1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gamescorelabel);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.score2TextBox);
            this.groupBox3.Controls.Add(this.score1TextBox);
            this.groupBox3.Controls.Add(this.simulategamebutton);
            this.groupBox3.Location = new System.Drawing.Point(25, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 140);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Simulator";
            // 
            // gamescorelabel
            // 
            this.gamescorelabel.Font = new System.Drawing.Font("Big John", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamescorelabel.Location = new System.Drawing.Point(30, 36);
            this.gamescorelabel.Name = "gamescorelabel";
            this.gamescorelabel.Size = new System.Drawing.Size(77, 78);
            this.gamescorelabel.TabIndex = 5;
            this.gamescorelabel.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Player 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Player 1";
            // 
            // score2TextBox
            // 
            this.score2TextBox.Location = new System.Drawing.Point(176, 99);
            this.score2TextBox.Name = "score2TextBox";
            this.score2TextBox.Size = new System.Drawing.Size(83, 20);
            this.score2TextBox.TabIndex = 2;
            // 
            // score1TextBox
            // 
            this.score1TextBox.Location = new System.Drawing.Point(176, 61);
            this.score1TextBox.Name = "score1TextBox";
            this.score1TextBox.Size = new System.Drawing.Size(83, 20);
            this.score1TextBox.TabIndex = 1;
            // 
            // simulategamebutton
            // 
            this.simulategamebutton.Location = new System.Drawing.Point(176, 19);
            this.simulategamebutton.Name = "simulategamebutton";
            this.simulategamebutton.Size = new System.Drawing.Size(90, 24);
            this.simulategamebutton.TabIndex = 0;
            this.simulategamebutton.Text = "Start simulating";
            this.simulategamebutton.UseVisualStyleBackColor = true;
            this.simulategamebutton.Click += new System.EventHandler(this.simulategamebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 500);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gameloading);
            this.Controls.Add(this.gamecreating);
            this.Name = "Form1";
            this.Text = "YK GAME SIMULATOR";
            this.gamecreating.ResumeLayout(false);
            this.gamecreating.PerformLayout();
            this.gameloading.ResumeLayout(false);
            this.gameloading.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gamecreating;
        private System.Windows.Forms.GroupBox gameloading;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button creategamebutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox player2NameTextBox;
        private System.Windows.Forms.TextBox player1NameTextBox;
        private System.Windows.Forms.Button loadgamebutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loadplayer2;
        private System.Windows.Forms.TextBox loadplayer1;
        private System.Windows.Forms.Label gamescorelabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox score2TextBox;
        private System.Windows.Forms.TextBox score1TextBox;
        private System.Windows.Forms.Button simulategamebutton;
    }
}

