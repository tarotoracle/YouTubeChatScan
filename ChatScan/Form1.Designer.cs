
namespace ChatScan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtStreamURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtManualQuestion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkTrackDonos = new System.Windows.Forms.CheckBox();
            this.chkTrackChat = new System.Windows.Forms.CheckBox();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.chkDonoNumber = new System.Windows.Forms.CheckBox();
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ListBoxDonations = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ListBoxChatText = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstChatters = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ListBoxSaved = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus1,
            this.lblStatus2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(835, 22);
            this.statusStrip1.TabIndex = 14;
            // 
            // lblStatus1
            // 
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(219, 17);
            this.lblStatus1.Text = "Fill in the YouTube URL to start scanning";
            this.lblStatus1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus2
            // 
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(0, 17);
            // 
            // txtStreamURL
            // 
            this.txtStreamURL.Location = new System.Drawing.Point(157, 12);
            this.txtStreamURL.Name = "txtStreamURL";
            this.txtStreamURL.Size = new System.Drawing.Size(199, 23);
            this.txtStreamURL.TabIndex = 11;
            this.txtStreamURL.TextChanged += new System.EventHandler(this.txtStreamURL_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "YouTube Livestream URL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Text file to store into:";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(711, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start Scanning";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(134, 44);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(222, 23);
            this.txtOutputFile.TabIndex = 14;
            this.txtOutputFile.Text = "c:\\temp\\donation.txt";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtManualQuestion);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.chkTrackDonos);
            this.panel2.Controls.Add(this.chkTrackChat);
            this.panel2.Controls.Add(this.chkDebug);
            this.panel2.Controls.Add(this.chkDonoNumber);
            this.panel2.Controls.Add(this.chkLog);
            this.panel2.Controls.Add(this.txtOutputFile);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtStreamURL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 119);
            this.panel2.TabIndex = 12;
            // 
            // txtManualQuestion
            // 
            this.txtManualQuestion.Location = new System.Drawing.Point(155, 84);
            this.txtManualQuestion.Name = "txtManualQuestion";
            this.txtManualQuestion.Size = new System.Drawing.Size(389, 23);
            this.txtManualQuestion.TabIndex = 21;
            this.txtManualQuestion.TextChanged += new System.EventHandler(this.txtManualQuestion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Manually enter question: ";
            // 
            // chkTrackDonos
            // 
            this.chkTrackDonos.AutoSize = true;
            this.chkTrackDonos.Checked = true;
            this.chkTrackDonos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrackDonos.Location = new System.Drawing.Point(392, 10);
            this.chkTrackDonos.Name = "chkTrackDonos";
            this.chkTrackDonos.Size = new System.Drawing.Size(110, 19);
            this.chkTrackDonos.TabIndex = 19;
            this.chkTrackDonos.Text = "Track Donations";
            this.chkTrackDonos.UseVisualStyleBackColor = true;
            // 
            // chkTrackChat
            // 
            this.chkTrackChat.AutoSize = true;
            this.chkTrackChat.Checked = true;
            this.chkTrackChat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrackChat.Location = new System.Drawing.Point(392, 33);
            this.chkTrackChat.Name = "chkTrackChat";
            this.chkTrackChat.Size = new System.Drawing.Size(81, 19);
            this.chkTrackChat.TabIndex = 18;
            this.chkTrackChat.Text = "Track Chat";
            this.chkTrackChat.UseVisualStyleBackColor = true;
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(559, 85);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(95, 19);
            this.chkDebug.TabIndex = 17;
            this.chkDebug.Text = "Debug mode";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // chkDonoNumber
            // 
            this.chkDonoNumber.AutoSize = true;
            this.chkDonoNumber.Location = new System.Drawing.Point(392, 55);
            this.chkDonoNumber.Name = "chkDonoNumber";
            this.chkDonoNumber.Size = new System.Drawing.Size(213, 19);
            this.chkDonoNumber.TabIndex = 16;
            this.chkDonoNumber.Text = "Include donation number in output";
            this.chkDonoNumber.UseVisualStyleBackColor = true;
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.Checked = true;
            this.chkLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLog.Location = new System.Drawing.Point(678, 85);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(117, 19);
            this.chkLog.TabIndex = 15;
            this.chkLog.Text = "Log all donations";
            this.chkLog.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 559);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.ListBoxDonations);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(827, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Donations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ListBoxDonations
            // 
            this.ListBoxDonations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxDonations.FormattingEnabled = true;
            this.ListBoxDonations.ItemHeight = 15;
            this.ListBoxDonations.Location = new System.Drawing.Point(3, 3);
            this.ListBoxDonations.Name = "ListBoxDonations";
            this.ListBoxDonations.Size = new System.Drawing.Size(817, 521);
            this.ListBoxDonations.TabIndex = 14;
            this.ListBoxDonations.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxDonations_MouseClick);
            this.ListBoxDonations.SelectedIndexChanged += new System.EventHandler(this.ListBoxDonations_SelectedIndexChanged_1);
            this.ListBoxDonations.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListBoxDonations_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ListBoxChatText);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(827, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ListBoxChatText
            // 
            this.ListBoxChatText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxChatText.FormattingEnabled = true;
            this.ListBoxChatText.ItemHeight = 15;
            this.ListBoxChatText.Location = new System.Drawing.Point(147, 3);
            this.ListBoxChatText.Name = "ListBoxChatText";
            this.ListBoxChatText.Size = new System.Drawing.Size(677, 525);
            this.ListBoxChatText.TabIndex = 1;
            this.ListBoxChatText.SelectedIndexChanged += new System.EventHandler(this.ListBoxChatText_SelectedIndexChanged);
            this.ListBoxChatText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListBoxChatText_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstChatters);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 525);
            this.panel1.TabIndex = 0;
            // 
            // lstChatters
            // 
            this.lstChatters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstChatters.FormattingEnabled = true;
            this.lstChatters.ItemHeight = 15;
            this.lstChatters.Location = new System.Drawing.Point(0, 0);
            this.lstChatters.Name = "lstChatters";
            this.lstChatters.Size = new System.Drawing.Size(144, 525);
            this.lstChatters.TabIndex = 0;
            this.lstChatters.SelectedIndexChanged += new System.EventHandler(this.lstChatters_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ListBoxSaved);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(827, 531);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Saved";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ListBoxSaved
            // 
            this.ListBoxSaved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxSaved.FormattingEnabled = true;
            this.ListBoxSaved.ItemHeight = 15;
            this.ListBoxSaved.Location = new System.Drawing.Point(3, 3);
            this.ListBoxSaved.Name = "ListBoxSaved";
            this.ListBoxSaved.Size = new System.Drawing.Size(821, 525);
            this.ListBoxSaved.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 700);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube SuperChatter v1.25 - by TarotOracle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus2;
        private System.Windows.Forms.TextBox txtStreamURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.CheckBox chkDonoNumber;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox ListBoxDonations;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstChatters;
        private System.Windows.Forms.CheckBox chkTrackChat;
        private System.Windows.Forms.TextBox txtManualQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTrackDonos;
        private System.Windows.Forms.ListBox ListBoxChatText;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox ListBoxSaved;
    }
}

