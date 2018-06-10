using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using CoreTweet;

namespace UselessProgressTweet
{
  public partial class Form1 : Form
  {
    private string consumer_key = "";
    private string consumer_secret = "";
    private OAuth.OAuthSession session;
    private Tokens tokens;

    public Form1()
    {
      InitializeComponent();
      //確認ボタンの非表示
      OutButton.Visible = false;
      GoodButton.Visible = false;
			//保存値の読み出し
			Properties.Settings.Default.Reload();
			//デフォルト値の設定(現状できてない)
      //if(String.IsNullOrEmpty(Properties.Settings.Default.AccessToken) 
      //  && String.IsNullOrEmpty(Properties.Settings.Default.AccessTokenSecret) )
			//{
          tokens = Tokens.Create(
            consumer_key, consumer_secret,
            Properties.Settings.Default.AccessToken,
            Properties.Settings.Default.AccessTokenSecret);
            tokens.Statuses.Update(new { status = "おっぱい" });
      //}
      //else
      {
        //各ボタンなどの表示
        PINCode.Visible = true;
        PINOkButton.Visible = true;
        AuthenticationButton.Visible = true;
      }
    }

    //認証
    private void AuthenticationButton_Click(object sender, EventArgs e)
    {
      session = OAuth.Authorize(this.consumer_key,this.consumer_secret);
      Process.Start(session.AuthorizeUri.ToString());
    }

    //PINコード確認
    private void PINOkButton_Click(object sender, EventArgs e)
    {
      if (PINCode != null)
      {
        tokens = OAuth.GetTokens(session, PINCode.Text);
        PINCode.Visible = false;
        PINOkButton.Visible = false;
        AuthenticationButton.Visible = false;
        tokens.Statuses.Update(new { status = System.DateTime.Now });
      }
      else
      {
      }
    }

    //通知アイコンクリック時
    private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
    {
      this.WindowState = FormWindowState.Normal;
    }

    #region 定期実行分
    private void timer1_Tick(object sender, EventArgs e)
    {
      this.NotificationStart();
    }

    private void NotificationStart() {
      this.notifyIcon1.ShowBalloonTip(120000);
    }

    private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
    {
      if (tokens != null)
      {
        OutButton.Visible = true;
        GoodButton.Visible = true;
        this.WindowState = FormWindowState.Normal;
      }
    }



    private void OutButton_Click(object sender, EventArgs e)
    {
      tokens.Statuses.Update(new { status = "進捗ダメです．(" + System.DateTime.Now +")"});
      OutButton.Visible = false;
      GoodButton.Visible = false;
    }

    private void GoodButton_Click(object sender, EventArgs e)
    {
      tokens.Statuses.Update(new { status = "OKです．(" + System.DateTime.Now + ")" });

      OutButton.Visible = false;
      GoodButton.Visible = false;
    }

    #endregion

    //実行間隔の再設定
    private void TimeButton_Click(object sender, EventArgs e)
    {
      timer1.Interval = int.Parse(TimeText.Text) * 60 * 1000;
    }

    //タスクトレイから終了
    private void EndToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }


    //終了時のデータ保存
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (tokens != null)
      {
        Properties.Settings.Default.AccessToken = tokens.AccessToken;
        Properties.Settings.Default.AccessTokenSecret = tokens.AccessTokenSecret;
        Properties.Settings.Default.Save();
      }
    }

    
    private void TweetToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Normal;
      if (tokens != null)
      {
        OutButton.Visible = true;
        GoodButton.Visible = true;
        this.WindowState = FormWindowState.Normal;
      }
    }
  }
}
