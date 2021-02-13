using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ChatScan
{
    public partial class Form1 : Form
    {
        List<String> lstDonations = new List<string>();
        List<String> lstChatPeople = new List<string>();
        List<String> lstChatText = new List<string>();
        String sCurrentChatter = String.Empty;
        int iTotalMsgs = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculateCash()
        {
            Double dTotalUSD = 0;
            Double dTotalGBP = 0;
            Double dTotalEURO = 0;
            Double dTotalRUP = 0;
            int iDash = -1;
            int iCash = -1;
            int iGBP = -1;
            int iEURO = -1;
            int iRUP = -1;

            foreach (String sx in ListBoxDonations.Items)
            {
                iDash = sx.IndexOf(" - ");

                // Dollah dollah dollah
                iCash = sx.IndexOf("$");
                if (iDash > 0 && iCash > 0)
                    try
                    {
                        String sq = sx.Substring(iCash, iDash - iCash).Replace("$", "").Replace(" ", "").Replace("-", "");
                        Double iSq = Convert.ToDouble(sq);
                        dTotalUSD += iSq;
                    }
                    catch { }

                iEURO = sx.IndexOf("€");
                if (iDash > 0 && iEURO > 0)
                    try
                    {
                        String sq = sx.Substring(iEURO, iDash - iEURO).Replace("€", "").Replace(" ", "").Replace("-", "");
                        Double iSq = Convert.ToDouble(sq);
                        dTotalEURO += iSq;
                    }
                    catch { }

                iRUP = sx.IndexOf("₹");
                if (iDash > 0 && iRUP > 0)
                    try
                    {
                        String sq = sx.Substring(iRUP, iDash - iRUP).Replace("₹", "").Replace(" ", "").Replace("-", "");
                        Double iSq = Convert.ToDouble(sq);
                        dTotalRUP += iSq;
                    }
                    catch { }

                iGBP = sx.IndexOf("£");
                if (iDash > 0 && iGBP > 0)
                    try
                    {
                        String sq = sx.Substring(iGBP, iDash - iGBP).Replace("£", "").Replace(" ", "").Replace("-", "");
                        Double iSq = Convert.ToDouble(sq);
                        dTotalGBP += iSq;
                    }
                    catch { }
            }

            lblStatus1.Text = ListBoxDonations.Items.Count + " donations totalling $" + String.Format("{0:#.00}", dTotalUSD);
            if (dTotalEURO > 0)
                lblStatus1.Text += ", €" + String.Format("{0:#.00}", dTotalEURO);
            if (dTotalGBP > 0)
                lblStatus1.Text += ", £" + String.Format("{0:#.00}", dTotalGBP);
            if (dTotalRUP> 0)
                lblStatus1.Text += ", ₹" + String.Format("{0:#.00}", dTotalRUP);
        }

        private void LogEntry(String st)
        {
            try
            {
                using (StreamWriter w = File.AppendText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\" + "log.txt"))
                    w.WriteLine("{0}: {1}", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString(), st);
            }
            catch { }
        }

        private void ParseDonations(String s)
        {
            int iCurrentPos = 0;
            int iPurchase = 0;
            int iMess = -1;
            int iEnd = -1;
            int iAuthor = -1;
            int iAuthorEnd = -1;
            int iNoMessage = -1;
            String sAuthorArea = String.Empty;
            String sAuthor = String.Empty;
            String sPurchase = String.Empty;
            String sFinalText = String.Empty;

            // "authorName":{"simpleText":"bewee"},"authorPhoto"
            // "purchaseAmountText":{"simpleText":"$50.00"},"message":{"runs":[{"text":"Does anyone use Stash?"}]},"headerBackgroundColor":4290910299,"headerTextColor"

            try
            {
                while (iPurchase > -1)
                {
                    iPurchase = s.IndexOf("purchaseAmountText", iCurrentPos);
                    if (iPurchase > -1)
                    {
                        iMess = s.IndexOf("\"message\":{\"runs\"", iPurchase);
                        if (iMess > -1)
                        {
                            sAuthor = "";
                            sAuthorArea = s.Substring(iPurchase - 700, 700);
                            iAuthor = sAuthorArea.IndexOf("\"authorName\":");
                            if (iAuthor > -1)
                            {
                                iAuthorEnd = sAuthorArea.IndexOf("\"},\"authorPhoto", iAuthor);
                                if (iAuthorEnd > -1)
                                    sAuthor = sAuthorArea.Substring(iAuthor, iAuthorEnd - iAuthor).Replace("\":{\"simpleText\":\"", "").Replace("\"authorName", "");
                            }
                            iEnd = s.IndexOf("\"}]},\"", iMess);
                            sPurchase = s.Substring(iPurchase, iEnd - iPurchase).Replace("â‚¹", "₹").Replace("€", "€");
                            // Anthony Liang25 $100.00"},"headerBackgroundColor":4291821568,"headerTextColor":4294967295,"bodyBackgroundColor":4293271831
                            if (sPurchase.Contains("stickerDisplayWidth"))
                            {
                                iNoMessage = sPurchase.IndexOf("stickerDisplayWidth");
                                sPurchase = sPurchase.Substring(0, iNoMessage).Replace("\"},\"", "").Replace("},", "");
                            }
                            if (sPurchase.Contains("headerBackgroundColor"))
                            {
                                iNoMessage = sPurchase.IndexOf("headerBackgroundColor");
                                sPurchase = sPurchase.Substring(0, iNoMessage).Replace("\"},\"", "");
                            }
                            // purchaseAmountText":{"simpleText":"€5.00"},"message":{"runs":[{"text":"Thoughts on UAMY
                            sFinalText = sAuthor + " " + sPurchase.Replace("purchaseAmountText\":{\"simpleText\":\"", "").Replace("\"},\"message\":{\"runs\":[{\"text\":\"", " - ").Replace("\"", "").Replace("},{", "").Replace("text", "").Replace(":", " ");
                            sFinalText = sFinalText.Replace(@"\u0026", "&");
                            if (!lstDonations.Contains(sFinalText))
                            {
                                lstDonations.Add(sFinalText);
                                ListBoxDonations.Items.Add(sFinalText);
                                if (chkLog.Checked)
                                    LogEntry(sFinalText);
                            }
                        }
                        iCurrentPos = iEnd;
                    }
                }
                CalculateCash();
            }
            catch (Exception ec)
            {
                lblStatus1.Text = "Failed parsing chat. " + ec.Message;
            }
        }

        private void ParseChatMessages(String s)
        {
            int iCurrentPos = 0;
            int iChatMsg = 0;
            int iEnd = -1;
            int iAuthor = -0;
            int iAuthorEnd = -1;
            String sAuthorArea = String.Empty;
            String sAuthor = String.Empty;
            String sChatMsg = String.Empty;
            String sFinalText = String.Empty;

            try
            {
                while (iChatMsg > -1)
                {
                    iChatMsg = s.IndexOf("\"message\":{\"runs\":[{\"text\"", iCurrentPos);
                    if (iChatMsg > -1)
                    {
                        iEnd = s.IndexOf("\"}]}", iChatMsg);
                        if (iEnd == -1)
                            iEnd = s.IndexOf("\"},{\"", iChatMsg);
                        if (iEnd > -1)
                        {
                            sAuthor = "";
                            sAuthorArea = s.Substring(iEnd, 110);
                            iAuthor = sAuthorArea.IndexOf("\"authorName\":");
                            if (iAuthor > -1)
                            {
                                iAuthorEnd = sAuthorArea.IndexOf("\"},\"authorPhoto", iAuthor);
                                if (iAuthorEnd > -1)
                                    sAuthor = sAuthorArea.Substring(iAuthor, iAuthorEnd - iAuthor).Replace("\":{\"simpleText\":\"", "").Replace("\"authorName", "").Replace(@"\u0026", "&");
                            }
                            sChatMsg = s.Substring(iChatMsg, iEnd - iChatMsg).Replace("\"message\":{\"runs\":[{\"text\"", "").Replace(":\"","- ");
                            sFinalText = sAuthor + " " + sChatMsg;
                            sFinalText = sFinalText.Replace("text", " ").Replace("}", "").Replace("{", "").Replace(":", "").Replace("\"", "").Replace(@"\u0026", "&");
                            if (!lstChatText.Contains(sFinalText))
                            {
                                lstChatText.Add(sFinalText);
                                iTotalMsgs++;
                            }
                            if (!lstChatPeople.Contains(sAuthor))
                            {
                                lstChatPeople.Add(sAuthor);
                                lstChatPeople.Sort();
                                lstChatters.Items.Clear();
                                lstChatters.BeginUpdate();
                                foreach (String u in lstChatPeople)
                                    lstChatters.Items.Add(u);
                                lstChatters.EndUpdate();
                            }
                            tabPage2.Text = "Chat - " + lstChatters.Items.Count + " people";
                        }
                        iCurrentPos = iEnd;
                    }
                }
            }
            catch (Exception exa)
            {
                lblStatus1.Text = "Failed parsing chat. " + exa.Message;
            }
        }

        private void LoadYouTubeChat(String sURL)
        {
            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("https://www.youtube.com/live_chat?is_popout=1&v=" + sURL);
                myRequest.Method = "GET";
                myRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.150 Safari/537.36";
                WebResponse myResponse = myRequest.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                string result = sr.ReadToEnd();
                sr.Close();
                myResponse.Close();
                if (chkDebug.Checked)
                    File.WriteAllText(@"c:\temp\dump.txt", result);
                if (chkTrackDonos.Checked)
                    ParseDonations(result);
                if (chkTrackChat.Checked)
                    ParseChatMessages(result);
            }
            catch (Exception ec)
            {
                lblStatus1.Text = "Could not connect to URL/chat. " + ec.Message;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                int iSlash = txtStreamURL.Text.LastIndexOf("/");
                if (iSlash > -1)
                    LoadYouTubeChat(txtStreamURL.Text.Substring(iSlash + 1, txtStreamURL.Text.Length - iSlash - 1).Trim());
                else
                    LoadYouTubeChat(txtStreamURL.Text.Trim());
            }
            catch (Exception ex)
            {
                lblStatus1.Text = "URL not found, please only include the last letters/digits";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "STOP")
            {
                timer1.Enabled = false;
                button1.Text = "Start scanning";
            }
            else
            {
                lstChatText.Clear();
                ListBoxChatText.Items.Clear();
                lstChatters.Items.Clear();
                tabPage2.Text = "Chat";
                timer1.Enabled = true;
                button1.Text = "STOP";
            }
            timer1_Tick(null, null);
        }

        private void txtStreamURL_TextChanged(object sender, EventArgs e)
        {
            lstChatText.Clear();
            ListBoxChatText.Items.Clear();
            lstChatters.Items.Clear();
            tabPage2.Text = "Chat";
            timer1.Enabled = false;
            button1.Text = "Start scanning";
            button1.Enabled = true;
        }

        private void lstChatters_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ay = String.Empty;
            int iy = -1;

            sCurrentChatter = lstChatters.GetItemText(lstChatters.SelectedItem);
            ListBoxChatText.Items.Clear();
            foreach (String u in lstChatText)
                if (u.Contains(lstChatters.GetItemText(lstChatters.SelectedItem) + " - "))
                {
                    iy = u.IndexOf(" - ");
                    if (iy > 0)
                        ListBoxChatText.Items.Add(u.Substring(iy, u.Length - iy).Replace(" - ", ""));
/*
                    try
                    {
                        lstChatters.SelectedItem = sCurrentChatter;
                        lstChatters.SetSelected(lstChatters.FindString(sCurrentChatter), true);
                    }
                    catch(Exception eu) 
                    {
                        int i = 1;
                    }
*/
                }
        }

        private void txtManualQuestion_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(txtOutputFile.Text, txtManualQuestion.Text);
        }

        private void ListBoxChatText_SelectedIndexChanged(object sender, EventArgs e)
        {
            File.WriteAllText(txtOutputFile.Text, sCurrentChatter + " - " + ListBoxChatText.GetItemText(ListBoxChatText.SelectedItem));
        }

        private void ListBoxDonations_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtManualQuestion.Text = "";
            if (chkDonoNumber.Checked)
                File.WriteAllText(txtOutputFile.Text, "(" + (ListBoxDonations.SelectedIndex + 1).ToString() + ") " + ListBoxDonations.GetItemText(ListBoxDonations.SelectedItem));
            else
                File.WriteAllText(txtOutputFile.Text, ListBoxDonations.GetItemText(ListBoxDonations.SelectedItem));
        }
    }
}
