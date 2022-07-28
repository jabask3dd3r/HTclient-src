using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Discord;
using Discord.Gateway;
using DiscordRPC;
using htclientv2;
using Button = System.Windows.Forms.Button;

namespace gayruda_selfbot;

public class Form1 : Form
{
    private static DiscordSocketClient client = new DiscordSocketClient(new DiscordSocketConfig
    {
        Intents = DiscordGatewayIntent.Guilds
    });

    private static bool loggedin = false;

    private static int cache_bully = 0;

    private static string prefix = "!";

    private static ulong clown = 0uL;

    private static ulong bully = 0uL;

    public List<string> bullshit = new List<string>();

    private static ulong clownfish = 0uL;

    private static string negris = "";

    private static string nickerText = "";

    private static ulong botChannel = 0uL;

    private static int botLimit = 0;

    private static int nickerLimit = 0;

    private static ulong nickerChannel = 0uL;

    private static List<string> mention_lsit = new List<string>();

    private DiscordRpcClient clientr = new DiscordRpcClient("905525338317160518");

    private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

    private IContainer components = null;

    private TabPage tabPage5;

    private Button button6;

    private Label label8;

    private Label label2;

    private TabPage tabPage4;

    public TextBox logs;

    private Button button3;

    private CheckBox debugmentions;

    private CheckBox debugchat;

    private TabPage tabPage3;

    private TextBox bot_messages;

    private TextBox bot_channel;

    private TextBox bot_limit;

    private Label label12;

    private CheckBox checkBox1;

    private Label label11;

    private Button button7;

    private Label label9;

    private Label label10;

    private TabPage tabPage1;

    private Button button8;

    private PictureBox accp;

    private Label accd;

    private TabControl tabControl1;

    private TabPage tabPage2;

    private CheckBox hohol;

    private Label label1;

    private Button button5;

    private Button button2;

    private TextBox cfish;

    private TextBox tobully;

    private CheckBox clownc;

    private TextBox clown_id;

    private Label dwaksakfo;

    private Label label3;

    private Button button1;

    private Label label4;

    private TextBox lims;

    private CheckBox checkBox2;

    private TextBox nicker_text;

    private TextBox nicker_guild;

    private TextBox nicker_limit;

    private Label label14;

    private CheckBox checkBox4;

    private Button button9;

    private Label label15;

    private Label label16;

    private Label label13;

    private ComboBox comboBox1;

    private TextBox activity_text;

    private Button button10;

    private Label label17;

    private Button button12;

    private Label label18;

    private ComboBox comboBox2;

    private TabPage tabPage6;

    private Label label20;

    private Label label19;

    private Button button13;

    private ComboBox comboBox3;

    private ProgressBar progressBar1;

    private Button button14;

    private Label wver;

    private Label label27;

    private Label uver;

    private Label label25;

    private CheckBox promotion;

    private CheckBox checkBox5;

    private CheckBox isbuillerchannel;

    private Button button15;

    private Label label26;

    private TextBox xdmeme;

    private Label label29;

    private Button button16;

    private TextBox textBox1;

    private CheckBox checkBox3;

    private CheckBox isHruk;

    private TextBox textBox2;

    private Label label35;

    private Label label38;

    private Label label36;

    private Label label37;

    private ComboBox the_id_to_dump;

    private ComboBox the_sid_to_dump;

    private Button button17;

    private Button button18;

    private Label label42;

    private TabControl tabControl2;

    private TabPage tabPage11;

    private Button button11;

    private Label label43;

    private TextBox secondrpc;

    private Label label44;

    private TextBox firstrpc;

    private Button button4;

    private Label label45;

    private TextBox textBox19;

    private Label label65;

    private Label label66;

    private Label label67;

    private Label label68;

    private Label label69;

    private ProgressBar progressBar2;

    private Button button34;

    private TabPage tabPage12;

    private Label label72;

    private Label label73;

    private Label label74;

    private Label label75;

    private Label label76;

    private Label label77;

    private Label label78;

    private Label label79;

    private Label label80;

    private Label label81;

    private Label label83;

    private TabPage tabPage7;

    private Label newjoinedusa;

    private Label label41;

    private Label label50;

    private Label label49;

    private Label label48;

    private Label label47;

    private Label label46;

    private CheckBox ispingg;

    private Button button19;

    private Button button20;

    private Label label5;

    private Button button26;

    private Button button25;

    private Label label7;

    private Label label6;

    private Label label51;

    private Label label52;

    private Label label53;

    private Label label54;

    private CheckBox checkBox6;

    private Button button21;

    private Button button22;

    private PictureBox pictureBox1;

    private ComboBox comboBox4;

    private Button button23;

    private Label label56;

    private PictureBox bully_target_pfp;

    private Label bully_target_title;

    private Label bully_target_msg;

    private Label bully_target_user;

    private Label bully_target_title_message;

    private Label bully_target_title_name;

    private Label label30;

    private Label label28;

    private Label label21;

    private Label label32;

    private Label label31;

    private Button button24;

    private Label label33;

    private Label label39;

    private Label label34;

    public static int ghp { get; set; }

    public Form1()
    {
        //IL_0011: Unknown result type (might be due to invalid IL or missing references)
        //IL_001b: Expected O, but got Unknown
        InitializeComponent();
    }

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
    internal static extern bool IsDebuggerPresent();

    private void Form1_Load(object sender, EventArgs e)
    {
        string path = "\\cache";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Directory.CreateDirectory("\\cache\\girls");
            Form2 form = new Form2();
            Hide();
            form.ShowDialog();
           
        }
        else
        {
            try
            {
                string value = File.ReadAllText("\\cache\\girls\\girl.txt");
                int selectedIndex = Convert.ToInt32(value);
                comboBox4.SelectedIndex = selectedIndex;
                button23_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }
        BackgroundWorker backgroundWorker = new BackgroundWorker();
        backgroundWorker.DoWork += bw_DoWork;
        backgroundWorker.RunWorkerAsync();
        bully_target_msg.Hide();
        bully_target_pfp.Hide();
        bully_target_title.Hide();
        bully_target_title_message.Hide();
        bully_target_title_name.Hide();
        bully_target_user.Hide();
        button26.Hide();
        if (!File.Exists("token.txt"))
        {
            File.WriteAllText("token.txt", string.Empty);
        }
        if (!File.Exists("whitelist.txt"))
        {
            File.WriteAllText("whitelist.txt", string.Empty);
        }
        timer.Interval = 1;
        timer.Tick += timer_Tick;
         
            try
            {
            // client.Login(File.ReadAllText("token.txt"));
            client.Login("Nzk2NTYxNTA4MjkzMjc5NzQ1.GtEDji.KCUNdDZd4CBVQIYa6E3k0XDSpHfZ7bo5UQtuRE")
         ;
        }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "error");
            }
           // DiscordGuild guild = client.GetGuild(916380688498974761uL);
           
            
          
        
       
    }

    public void timer_Tick(object sender, EventArgs e)
    {
        if (ghp == 240)
        {
            ghp = 0;
            return;
        }
        ghp++;
        foreach (CheckBox item in tabPage1.Controls.OfType<CheckBox>())
        {
            item.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
        foreach (CheckBox item2 in tabPage2.Controls.OfType<CheckBox>())
        {
            item2.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
        foreach (CheckBox item3 in tabPage3.Controls.OfType<CheckBox>())
        {
            item3.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
        foreach (CheckBox item4 in tabPage4.Controls.OfType<CheckBox>())
        {
            item4.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
        foreach (CheckBox item5 in tabPage5.Controls.OfType<CheckBox>())
        {
            item5.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
        foreach (CheckBox item6 in tabPage6.Controls.OfType<CheckBox>())
        {
            item6.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
        foreach (Label item7 in tabPage1.Controls.OfType<Label>())
        {
            item7.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
        foreach (Label item8 in tabPage2.Controls.OfType<Label>())
        {
            item8.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
        foreach (Label item9 in tabPage3.Controls.OfType<Label>())
        {
            item9.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
        foreach (Label item10 in tabPage4.Controls.OfType<Label>())
        {
            item10.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
        foreach (Label item11 in tabPage5.Controls.OfType<Label>())
        {
            item11.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
        foreach (Label item12 in tabPage6.Controls.OfType<Label>())
        {
            item12.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
        foreach (Button item13 in tabPage1.Controls.OfType<Button>())
        {
            item13.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
        foreach (Button item14 in tabPage2.Controls.OfType<Button>())
        {
            item14.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
        foreach (Button item15 in tabPage3.Controls.OfType<Button>())
        {
            item15.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
        foreach (Button item16 in tabPage4.Controls.OfType<Button>())
        {
            item16.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
        foreach (Button item17 in tabPage5.Controls.OfType<Button>())
        {
            item17.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
        foreach (Button item18 in tabPage6.Controls.OfType<Button>())
        {
            item18.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
        }
    }

    [DllImport("shlwapi.dll")]
    public static extern int ColorHLSToRGB(int H, int L, int S);

    public bool cmd(string input, string content)
    {
        if (input.StartsWith(prefix + content))
        {
            return true;
        }
        return false;
    }

    public void changeTheme(int theme)
    {
        if (theme == 1)
        {
            label8.Text = "black-white";
            foreach (ComboBox item in tabPage1.Controls.OfType<ComboBox>())
            {
                item.ForeColor = Color.White;
                item.BackColor = Color.Black;
            }
            foreach (Label item2 in tabPage1.Controls.OfType<Label>())
            {
                item2.ForeColor = Color.White;
                item2.BackColor = Color.Black;
            }
            foreach (CheckBox item3 in tabPage1.Controls.OfType<CheckBox>())
            {
                item3.ForeColor = Color.White;
                item3.BackColor = Color.Black;
            }
            foreach (TextBox item4 in tabPage1.Controls.OfType<TextBox>())
            {
                item4.ForeColor = Color.White;
                item4.BackColor = Color.Black;
            }
            foreach (Button item5 in tabPage1.Controls.OfType<Button>())
            {
                item5.ForeColor = Color.White;
                item5.BackColor = Color.Black;
            }
            foreach (Label item6 in tabPage1.Controls.OfType<Label>())
            {
                item6.ForeColor = Color.White;
                item6.BackColor = Color.Black;
            }
            foreach (CheckBox item7 in tabPage1.Controls.OfType<CheckBox>())
            {
                item7.ForeColor = Color.White;
                item7.BackColor = Color.Black;
            }
            foreach (TextBox item8 in tabPage1.Controls.OfType<TextBox>())
            {
                item8.ForeColor = Color.White;
                item8.BackColor = Color.Black;
            }
            foreach (Button item9 in tabPage1.Controls.OfType<Button>())
            {
                item9.ForeColor = Color.White;
                item9.BackColor = Color.Black;
            }
            foreach (ComboBox item10 in tabPage2.Controls.OfType<ComboBox>())
            {
                item10.ForeColor = Color.White;
                item10.BackColor = Color.Black;
            }
            foreach (Label item11 in tabPage2.Controls.OfType<Label>())
            {
                item11.ForeColor = Color.White;
                item11.BackColor = Color.Black;
            }
            foreach (CheckBox item12 in tabPage2.Controls.OfType<CheckBox>())
            {
                item12.ForeColor = Color.White;
                item12.BackColor = Color.Black;
            }
            foreach (TextBox item13 in tabPage2.Controls.OfType<TextBox>())
            {
                item13.ForeColor = Color.White;
                item13.BackColor = Color.Black;
            }
            foreach (Button item14 in tabPage2.Controls.OfType<Button>())
            {
                item14.ForeColor = Color.White;
                item14.BackColor = Color.Black;
            }
            foreach (ComboBox item15 in tabPage3.Controls.OfType<ComboBox>())
            {
                item15.ForeColor = Color.White;
                item15.BackColor = Color.Black;
            }
            foreach (Label item16 in tabPage3.Controls.OfType<Label>())
            {
                item16.ForeColor = Color.White;
                item16.BackColor = Color.Black;
            }
            foreach (CheckBox item17 in tabPage3.Controls.OfType<CheckBox>())
            {
                item17.ForeColor = Color.White;
                item17.BackColor = Color.Black;
            }
            foreach (TextBox item18 in tabPage3.Controls.OfType<TextBox>())
            {
                item18.ForeColor = Color.White;
                item18.BackColor = Color.Black;
            }
            foreach (Button item19 in tabPage3.Controls.OfType<Button>())
            {
                item19.ForeColor = Color.White;
                item19.BackColor = Color.Black;
            }
            foreach (ComboBox item20 in tabPage4.Controls.OfType<ComboBox>())
            {
                item20.ForeColor = Color.White;
                item20.BackColor = Color.Black;
            }
            foreach (Label item21 in tabPage4.Controls.OfType<Label>())
            {
                item21.ForeColor = Color.White;
                item21.BackColor = Color.Black;
            }
            foreach (CheckBox item22 in tabPage4.Controls.OfType<CheckBox>())
            {
                item22.ForeColor = Color.White;
                item22.BackColor = Color.Black;
            }
            foreach (TextBox item23 in tabPage4.Controls.OfType<TextBox>())
            {
                item23.ForeColor = Color.White;
                item23.BackColor = Color.Black;
            }
            foreach (Button item24 in tabPage4.Controls.OfType<Button>())
            {
                item24.ForeColor = Color.White;
                item24.BackColor = Color.Black;
            }
            foreach (ComboBox item25 in tabPage5.Controls.OfType<ComboBox>())
            {
                item25.ForeColor = Color.White;
                item25.BackColor = Color.Black;
            }
            foreach (Label item26 in tabPage5.Controls.OfType<Label>())
            {
                item26.ForeColor = Color.White;
                item26.BackColor = Color.Black;
            }
            foreach (CheckBox item27 in tabPage5.Controls.OfType<CheckBox>())
            {
                item27.ForeColor = Color.White;
                item27.BackColor = Color.Black;
            }
            foreach (TextBox item28 in tabPage5.Controls.OfType<TextBox>())
            {
                item28.ForeColor = Color.White;
                item28.BackColor = Color.Black;
            }
            foreach (Button item29 in tabPage5.Controls.OfType<Button>())
            {
                item29.ForeColor = Color.White;
                item29.BackColor = Color.Black;
            }
            foreach (ComboBox item30 in tabPage6.Controls.OfType<ComboBox>())
            {
                item30.ForeColor = Color.White;
                item30.BackColor = Color.Black;
            }
            foreach (Label item31 in tabPage6.Controls.OfType<Label>())
            {
                item31.ForeColor = Color.White;
                item31.BackColor = Color.Black;
            }
            foreach (CheckBox item32 in tabPage6.Controls.OfType<CheckBox>())
            {
                item32.ForeColor = Color.White;
                item32.BackColor = Color.Black;
            }
            foreach (TextBox item33 in tabPage6.Controls.OfType<TextBox>())
            {
                item33.ForeColor = Color.White;
                item33.BackColor = Color.Black;
            }
            foreach (Button item34 in tabPage6.Controls.OfType<Button>())
            {
                item34.ForeColor = Color.White;
                item34.BackColor = Color.Black;
            }
        }
        if (theme == 2)
        {
            label8.Text = "black-green";
            foreach (ComboBox item35 in tabPage1.Controls.OfType<ComboBox>())
            {
                item35.ForeColor = Color.Green;
                item35.BackColor = Color.Black;
            }
            foreach (Label item36 in tabPage1.Controls.OfType<Label>())
            {
                item36.ForeColor = Color.Green;
                item36.BackColor = Color.Black;
            }
            foreach (CheckBox item37 in tabPage1.Controls.OfType<CheckBox>())
            {
                item37.ForeColor = Color.Green;
                item37.BackColor = Color.Black;
            }
            foreach (TextBox item38 in tabPage1.Controls.OfType<TextBox>())
            {
                item38.ForeColor = Color.Green;
                item38.BackColor = Color.Black;
            }
            foreach (Button item39 in tabPage1.Controls.OfType<Button>())
            {
                item39.ForeColor = Color.Green;
                item39.BackColor = Color.Black;
            }
            foreach (Label item40 in tabPage1.Controls.OfType<Label>())
            {
                item40.ForeColor = Color.Green;
                item40.BackColor = Color.Black;
            }
            foreach (CheckBox item41 in tabPage1.Controls.OfType<CheckBox>())
            {
                item41.ForeColor = Color.Green;
                item41.BackColor = Color.Black;
            }
            foreach (TextBox item42 in tabPage1.Controls.OfType<TextBox>())
            {
                item42.ForeColor = Color.Green;
                item42.BackColor = Color.Black;
            }
            foreach (Button item43 in tabPage1.Controls.OfType<Button>())
            {
                item43.ForeColor = Color.Green;
                item43.BackColor = Color.Black;
            }
            foreach (ComboBox item44 in tabPage2.Controls.OfType<ComboBox>())
            {
                item44.ForeColor = Color.Green;
                item44.BackColor = Color.Black;
            }
            foreach (Label item45 in tabPage2.Controls.OfType<Label>())
            {
                item45.ForeColor = Color.Green;
                item45.BackColor = Color.Black;
            }
            foreach (CheckBox item46 in tabPage2.Controls.OfType<CheckBox>())
            {
                item46.ForeColor = Color.Green;
                item46.BackColor = Color.Black;
            }
            foreach (TextBox item47 in tabPage2.Controls.OfType<TextBox>())
            {
                item47.ForeColor = Color.Green;
                item47.BackColor = Color.Black;
            }
            foreach (Button item48 in tabPage2.Controls.OfType<Button>())
            {
                item48.ForeColor = Color.Green;
                item48.BackColor = Color.Black;
            }
            foreach (ComboBox item49 in tabPage3.Controls.OfType<ComboBox>())
            {
                item49.ForeColor = Color.Green;
                item49.BackColor = Color.Black;
            }
            foreach (Label item50 in tabPage3.Controls.OfType<Label>())
            {
                item50.ForeColor = Color.Green;
                item50.BackColor = Color.Black;
            }
            foreach (CheckBox item51 in tabPage3.Controls.OfType<CheckBox>())
            {
                item51.ForeColor = Color.Green;
                item51.BackColor = Color.Black;
            }
            foreach (TextBox item52 in tabPage3.Controls.OfType<TextBox>())
            {
                item52.ForeColor = Color.Green;
                item52.BackColor = Color.Black;
            }
            foreach (Button item53 in tabPage3.Controls.OfType<Button>())
            {
                item53.ForeColor = Color.Green;
                item53.BackColor = Color.Black;
            }
            foreach (ComboBox item54 in tabPage4.Controls.OfType<ComboBox>())
            {
                item54.ForeColor = Color.Green;
                item54.BackColor = Color.Black;
            }
            foreach (Label item55 in tabPage4.Controls.OfType<Label>())
            {
                item55.ForeColor = Color.Green;
                item55.BackColor = Color.Black;
            }
            foreach (CheckBox item56 in tabPage4.Controls.OfType<CheckBox>())
            {
                item56.ForeColor = Color.Green;
                item56.BackColor = Color.Black;
            }
            foreach (TextBox item57 in tabPage4.Controls.OfType<TextBox>())
            {
                item57.ForeColor = Color.Green;
                item57.BackColor = Color.Black;
            }
            foreach (Button item58 in tabPage4.Controls.OfType<Button>())
            {
                item58.ForeColor = Color.Green;
                item58.BackColor = Color.Black;
            }
            foreach (ComboBox item59 in tabPage5.Controls.OfType<ComboBox>())
            {
                item59.ForeColor = Color.Green;
                item59.BackColor = Color.Black;
            }
            foreach (Label item60 in tabPage5.Controls.OfType<Label>())
            {
                item60.ForeColor = Color.Green;
                item60.BackColor = Color.Black;
            }
            foreach (CheckBox item61 in tabPage5.Controls.OfType<CheckBox>())
            {
                item61.ForeColor = Color.Green;
                item61.BackColor = Color.Black;
            }
            foreach (TextBox item62 in tabPage5.Controls.OfType<TextBox>())
            {
                item62.ForeColor = Color.Green;
                item62.BackColor = Color.Black;
            }
            foreach (Button item63 in tabPage5.Controls.OfType<Button>())
            {
                item63.ForeColor = Color.Green;
                item63.BackColor = Color.Black;
            }
            foreach (ComboBox item64 in tabPage6.Controls.OfType<ComboBox>())
            {
                item64.ForeColor = Color.Green;
                item64.BackColor = Color.Black;
            }
            foreach (Label item65 in tabPage6.Controls.OfType<Label>())
            {
                item65.ForeColor = Color.Green;
                item65.BackColor = Color.Black;
            }
            foreach (CheckBox item66 in tabPage6.Controls.OfType<CheckBox>())
            {
                item66.ForeColor = Color.Green;
                item66.BackColor = Color.Black;
            }
            foreach (TextBox item67 in tabPage6.Controls.OfType<TextBox>())
            {
                item67.ForeColor = Color.Green;
                item67.BackColor = Color.Black;
            }
            foreach (Button item68 in tabPage6.Controls.OfType<Button>())
            {
                item68.ForeColor = Color.Green;
                item68.BackColor = Color.Black;
            }
        }
        if (theme == 3)
        {
            label8.Text = "black-yellow";
            foreach (ComboBox item69 in tabPage1.Controls.OfType<ComboBox>())
            {
                item69.ForeColor = Color.Yellow;
                item69.BackColor = Color.Black;
            }
            foreach (Label item70 in tabPage1.Controls.OfType<Label>())
            {
                item70.ForeColor = Color.Yellow;
                item70.BackColor = Color.Black;
            }
            foreach (CheckBox item71 in tabPage1.Controls.OfType<CheckBox>())
            {
                item71.ForeColor = Color.Yellow;
                item71.BackColor = Color.Black;
            }
            foreach (TextBox item72 in tabPage1.Controls.OfType<TextBox>())
            {
                item72.ForeColor = Color.Yellow;
                item72.BackColor = Color.Black;
            }
            foreach (Button item73 in tabPage1.Controls.OfType<Button>())
            {
                item73.ForeColor = Color.Yellow;
                item73.BackColor = Color.Black;
            }
            foreach (Label item74 in tabPage1.Controls.OfType<Label>())
            {
                item74.ForeColor = Color.Yellow;
                item74.BackColor = Color.Black;
            }
            foreach (CheckBox item75 in tabPage1.Controls.OfType<CheckBox>())
            {
                item75.ForeColor = Color.Yellow;
                item75.BackColor = Color.Black;
            }
            foreach (TextBox item76 in tabPage1.Controls.OfType<TextBox>())
            {
                item76.ForeColor = Color.Yellow;
                item76.BackColor = Color.Black;
            }
            foreach (Button item77 in tabPage1.Controls.OfType<Button>())
            {
                item77.ForeColor = Color.Yellow;
                item77.BackColor = Color.Black;
            }
            foreach (ComboBox item78 in tabPage2.Controls.OfType<ComboBox>())
            {
                item78.ForeColor = Color.Yellow;
                item78.BackColor = Color.Black;
            }
            foreach (Label item79 in tabPage2.Controls.OfType<Label>())
            {
                item79.ForeColor = Color.Yellow;
                item79.BackColor = Color.Black;
            }
            foreach (CheckBox item80 in tabPage2.Controls.OfType<CheckBox>())
            {
                item80.ForeColor = Color.Yellow;
                item80.BackColor = Color.Black;
            }
            foreach (TextBox item81 in tabPage2.Controls.OfType<TextBox>())
            {
                item81.ForeColor = Color.Yellow;
                item81.BackColor = Color.Black;
            }
            foreach (Button item82 in tabPage2.Controls.OfType<Button>())
            {
                item82.ForeColor = Color.Yellow;
                item82.BackColor = Color.Black;
            }
            foreach (ComboBox item83 in tabPage3.Controls.OfType<ComboBox>())
            {
                item83.ForeColor = Color.Yellow;
                item83.BackColor = Color.Black;
            }
            foreach (Label item84 in tabPage3.Controls.OfType<Label>())
            {
                item84.ForeColor = Color.Yellow;
                item84.BackColor = Color.Black;
            }
            foreach (CheckBox item85 in tabPage3.Controls.OfType<CheckBox>())
            {
                item85.ForeColor = Color.Yellow;
                item85.BackColor = Color.Black;
            }
            foreach (TextBox item86 in tabPage3.Controls.OfType<TextBox>())
            {
                item86.ForeColor = Color.Yellow;
                item86.BackColor = Color.Black;
            }
            foreach (Button item87 in tabPage3.Controls.OfType<Button>())
            {
                item87.ForeColor = Color.Yellow;
                item87.BackColor = Color.Black;
            }
            foreach (ComboBox item88 in tabPage4.Controls.OfType<ComboBox>())
            {
                item88.ForeColor = Color.Yellow;
                item88.BackColor = Color.Black;
            }
            foreach (Label item89 in tabPage4.Controls.OfType<Label>())
            {
                item89.ForeColor = Color.Yellow;
                item89.BackColor = Color.Black;
            }
            foreach (CheckBox item90 in tabPage4.Controls.OfType<CheckBox>())
            {
                item90.ForeColor = Color.Yellow;
                item90.BackColor = Color.Black;
            }
            foreach (TextBox item91 in tabPage4.Controls.OfType<TextBox>())
            {
                item91.ForeColor = Color.Yellow;
                item91.BackColor = Color.Black;
            }
            foreach (Button item92 in tabPage4.Controls.OfType<Button>())
            {
                item92.ForeColor = Color.Yellow;
                item92.BackColor = Color.Black;
            }
            foreach (ComboBox item93 in tabPage5.Controls.OfType<ComboBox>())
            {
                item93.ForeColor = Color.Yellow;
                item93.BackColor = Color.Black;
            }
            foreach (Label item94 in tabPage5.Controls.OfType<Label>())
            {
                item94.ForeColor = Color.Yellow;
                item94.BackColor = Color.Black;
            }
            foreach (CheckBox item95 in tabPage5.Controls.OfType<CheckBox>())
            {
                item95.ForeColor = Color.Yellow;
                item95.BackColor = Color.Black;
            }
            foreach (TextBox item96 in tabPage5.Controls.OfType<TextBox>())
            {
                item96.ForeColor = Color.Yellow;
                item96.BackColor = Color.Black;
            }
            foreach (Button item97 in tabPage5.Controls.OfType<Button>())
            {
                item97.ForeColor = Color.Yellow;
                item97.BackColor = Color.Black;
            }
            foreach (ComboBox item98 in tabPage6.Controls.OfType<ComboBox>())
            {
                item98.ForeColor = Color.Yellow;
                item98.BackColor = Color.Black;
            }
            foreach (Label item99 in tabPage6.Controls.OfType<Label>())
            {
                item99.ForeColor = Color.Yellow;
                item99.BackColor = Color.Black;
            }
            foreach (CheckBox item100 in tabPage6.Controls.OfType<CheckBox>())
            {
                item100.ForeColor = Color.Yellow;
                item100.BackColor = Color.Black;
            }
            foreach (TextBox item101 in tabPage6.Controls.OfType<TextBox>())
            {
                item101.ForeColor = Color.Yellow;
                item101.BackColor = Color.Black;
            }
            foreach (Button item102 in tabPage6.Controls.OfType<Button>())
            {
                item102.ForeColor = Color.Yellow;
                item102.BackColor = Color.Black;
            }
        }
        if (theme != 4)
        {
            return;
        }
        label8.Text = "black-blue";
        foreach (ComboBox item103 in tabPage1.Controls.OfType<ComboBox>())
        {
            item103.ForeColor = Color.Blue;
            item103.BackColor = Color.Black;
        }
        foreach (Label item104 in tabPage1.Controls.OfType<Label>())
        {
            item104.ForeColor = Color.Blue;
            item104.BackColor = Color.Black;
        }
        foreach (CheckBox item105 in tabPage1.Controls.OfType<CheckBox>())
        {
            item105.ForeColor = Color.Blue;
            item105.BackColor = Color.Black;
        }
        foreach (TextBox item106 in tabPage1.Controls.OfType<TextBox>())
        {
            item106.ForeColor = Color.Blue;
            item106.BackColor = Color.Black;
        }
        foreach (Button item107 in tabPage1.Controls.OfType<Button>())
        {
            item107.ForeColor = Color.Blue;
            item107.BackColor = Color.Black;
        }
        foreach (Label item108 in tabPage1.Controls.OfType<Label>())
        {
            item108.ForeColor = Color.Blue;
            item108.BackColor = Color.Black;
        }
        foreach (CheckBox item109 in tabPage1.Controls.OfType<CheckBox>())
        {
            item109.ForeColor = Color.Blue;
            item109.BackColor = Color.Black;
        }
        foreach (TextBox item110 in tabPage1.Controls.OfType<TextBox>())
        {
            item110.ForeColor = Color.Blue;
            item110.BackColor = Color.Black;
        }
        foreach (Button item111 in tabPage1.Controls.OfType<Button>())
        {
            item111.ForeColor = Color.Blue;
            item111.BackColor = Color.Black;
        }
        foreach (ComboBox item112 in tabPage2.Controls.OfType<ComboBox>())
        {
            item112.ForeColor = Color.Blue;
            item112.BackColor = Color.Black;
        }
        foreach (Label item113 in tabPage2.Controls.OfType<Label>())
        {
            item113.ForeColor = Color.Blue;
            item113.BackColor = Color.Black;
        }
        foreach (CheckBox item114 in tabPage2.Controls.OfType<CheckBox>())
        {
            item114.ForeColor = Color.Blue;
            item114.BackColor = Color.Black;
        }
        foreach (TextBox item115 in tabPage2.Controls.OfType<TextBox>())
        {
            item115.ForeColor = Color.Blue;
            item115.BackColor = Color.Black;
        }
        foreach (Button item116 in tabPage2.Controls.OfType<Button>())
        {
            item116.ForeColor = Color.Blue;
            item116.BackColor = Color.Black;
        }
        foreach (ComboBox item117 in tabPage3.Controls.OfType<ComboBox>())
        {
            item117.ForeColor = Color.Blue;
            item117.BackColor = Color.Black;
        }
        foreach (Label item118 in tabPage3.Controls.OfType<Label>())
        {
            item118.ForeColor = Color.Blue;
            item118.BackColor = Color.Black;
        }
        foreach (CheckBox item119 in tabPage3.Controls.OfType<CheckBox>())
        {
            item119.ForeColor = Color.Blue;
            item119.BackColor = Color.Black;
        }
        foreach (TextBox item120 in tabPage3.Controls.OfType<TextBox>())
        {
            item120.ForeColor = Color.Blue;
            item120.BackColor = Color.Black;
        }
        foreach (Button item121 in tabPage3.Controls.OfType<Button>())
        {
            item121.ForeColor = Color.Blue;
            item121.BackColor = Color.Black;
        }
        foreach (ComboBox item122 in tabPage4.Controls.OfType<ComboBox>())
        {
            item122.ForeColor = Color.Blue;
            item122.BackColor = Color.Black;
        }
        foreach (Label item123 in tabPage4.Controls.OfType<Label>())
        {
            item123.ForeColor = Color.Blue;
            item123.BackColor = Color.Black;
        }
        foreach (CheckBox item124 in tabPage4.Controls.OfType<CheckBox>())
        {
            item124.ForeColor = Color.Blue;
            item124.BackColor = Color.Black;
        }
        foreach (TextBox item125 in tabPage4.Controls.OfType<TextBox>())
        {
            item125.ForeColor = Color.Blue;
            item125.BackColor = Color.Black;
        }
        foreach (Button item126 in tabPage4.Controls.OfType<Button>())
        {
            item126.ForeColor = Color.Blue;
            item126.BackColor = Color.Black;
        }
        foreach (ComboBox item127 in tabPage5.Controls.OfType<ComboBox>())
        {
            item127.ForeColor = Color.Blue;
            item127.BackColor = Color.Black;
        }
        foreach (Label item128 in tabPage5.Controls.OfType<Label>())
        {
            item128.ForeColor = Color.Blue;
            item128.BackColor = Color.Black;
        }
        foreach (CheckBox item129 in tabPage5.Controls.OfType<CheckBox>())
        {
            item129.ForeColor = Color.Blue;
            item129.BackColor = Color.Black;
        }
        foreach (TextBox item130 in tabPage5.Controls.OfType<TextBox>())
        {
            item130.ForeColor = Color.Blue;
            item130.BackColor = Color.Black;
        }
        foreach (Button item131 in tabPage5.Controls.OfType<Button>())
        {
            item131.ForeColor = Color.Blue;
            item131.BackColor = Color.Black;
        }
        foreach (ComboBox item132 in tabPage6.Controls.OfType<ComboBox>())
        {
            item132.ForeColor = Color.Blue;
            item132.BackColor = Color.Black;
        }
        foreach (Label item133 in tabPage6.Controls.OfType<Label>())
        {
            item133.ForeColor = Color.Blue;
            item133.BackColor = Color.Black;
        }
        foreach (CheckBox item134 in tabPage6.Controls.OfType<CheckBox>())
        {
            item134.ForeColor = Color.Blue;
            item134.BackColor = Color.Black;
        }
        foreach (TextBox item135 in tabPage6.Controls.OfType<TextBox>())
        {
            item135.ForeColor = Color.Blue;
            item135.BackColor = Color.Black;
        }
        foreach (Button item136 in tabPage6.Controls.OfType<Button>())
        {
            item136.ForeColor = Color.Blue;
            item136.BackColor = Color.Black;
        }
    }

    public static void xp_bot_Proccess()
    {
        List<string> list = new List<string>
        {
            "pog", "message", "sample", "test", "discord", "minecraft", "bot", "mee6", "poggr", "poggers",
            "troll", "nootnoot", "this is a message", "give me free nitro", "ignore me please", "why are you reading this", "made you look", "hi", "hello", "this is another random message",
            "this is a message with no context", "this message serves no purpose", "hi audit logs its me", "its me", "isnt this entertaining?", "this message will self-destruct", "this message will also self-destruct", "this message will go poof", "poof", "my password is....",
            "#auditlog spam", "dont mind me", "this is a string", "this is a bunch of garbage", "this message is for mee6 levels", "this message is for experience", "#freeexperience", "xp", "dont mind me... im collecting xp", "just chilling",
            "this is message number 999999999999999999999", "m e s s a g e", "hello, this is a message which wont last long", "insert message here", "insert creative quote here", "insert useless message here", "dont ask", "no need to question", "insert creative message here", "typo",
            "spam", "this is not spam", "give me nitro", "look at me xp farming", "this randomizer is cool", "hello there", "i see you", "peek a boo", "boo!"
        };
        Thread.Sleep(botLimit * 1000);
        Random random = new Random();
        int index = random.Next(0, 58);
        client.SendMessage(botChannel, list[index]);
    }

    private void nicker_Proccess(object sender, DoWorkEventArgs e)
    {
        Console.WriteLine("zxczxczxc");
        DiscordGuild guild = client.GetGuild(nickerChannel);
        while (checkBox4.Checked)
        {
            Console.WriteLine("zxczxczxc2");
            string text = "";
            string text2 = nickerText;
            string[] array = text2.Split(' ');
            string[] array2 = array;
            foreach (string text3 in array2)
            {
                Thread.Sleep(nickerLimit);
                guild.SetNickname(text + text3);
                text += text3;
            }
            text = string.Empty;
            Thread.Sleep(nickerLimit);
            guild.SetNickname("htclient.tk");
        }
    }

    public void welcum(DiscordSocketClient client, LoginEventArgs args)
    {
        loggedin = true;
        
        Console.WriteLine($"Logged in\nUser: {args.Client.User}#{args.Client.User.Discriminator}");
        sendLog($"Logged in{Environment.NewLine}User: {args.Client.User}");
        label52.Text = $"{args.Client.User}".Split('#')[0];
        string d1 = $"User: {client.User.Username}#{client.User.Discriminator}";
        string d2 = $"UID: {client.User.Id}";
        string d3 = "Email: " + client.User.Email;
        string d4 = $"Nitro: {client.User.Nitro}";

        Console.WriteLine("result : 3");

        foreach (PartialGuild item in client.GetGuilds(100u, 0uL))
        {
            Console.WriteLine($"[DEBUG]: Loaded: {item.Id}");
            the_id_to_dump.Invoke((Action)delegate
            {
                the_id_to_dump.Items.Add(item);
            });
        }
        int num = 0;
        WebRequest webRequest = WebRequest.Create(client.User.Avatar.Url);
        using (WebResponse webResponse = webRequest.GetResponse())
        {
            using Stream stream = webResponse.GetResponseStream();
            accp.Image = Image.FromStream(stream);
        }
        accd.Invoke((Action)delegate
        {
            accd.Text = d1 + "\n" + d2 + "\n" + d3 + "\n" + d4;
        });
        try
        {
            accd.Invoke((Action)delegate
            {
                Form.ActiveForm.Text = $"| HTClient V2 | UID: {client.User.Id} | Build: ReMake |";
            });
        }
        catch
        {
        }
        get_update();
    }

    private void get_update()
    {
    }

    private void update_rpc(string t1, string t2)
    {
        //IL_0008: Unknown result type (might be due to invalid IL or missing references)
        //IL_000d: Unknown result type (might be due to invalid IL or missing references)
        //IL_001e: Unknown result type (might be due to invalid IL or missing references)
        //IL_002f: Unknown result type (might be due to invalid IL or missing references)
        //IL_003b: Unknown result type (might be due to invalid IL or missing references)
        //IL_003c: Unknown result type (might be due to invalid IL or missing references)
        //IL_0041: Unknown result type (might be due to invalid IL or missing references)
        //IL_004d: Unknown result type (might be due to invalid IL or missing references)
        //IL_0059: Unknown result type (might be due to invalid IL or missing references)
        //IL_0065: Unknown result type (might be due to invalid IL or missing references)
        //IL_0076: Expected O, but got Unknown
        //IL_007c: Expected O, but got Unknown
        DiscordRpcClient obj = clientr;

    }

    private void sendLog(string text)
    {
        logs.Invoke((Action)delegate
        {
            logs.AppendText(text ?? "");
        });
        logs.Invoke((Action)delegate
        {
            logs.AppendText(Environment.NewLine);
        });
    }

    private void negri(DiscordSocketClient client, MessageEventArgs args)
    {
        loggedin = true;

        if (!args.Message.Author.User.Type.HasFlag(DiscordUserType.Bot))
        {
            Console.WriteLine($"{args.Message.Author}: {args.Message.Content}");
            if (debugchat.Checked)
            {
                DiscordChannel zxc = client.GetChannel(args.Message.Channel.Id);
                try
                {
                    DiscordGuild zxcc = client.GetGuild(args.Message.Guild.Id);
                    logs.Invoke((Action)delegate
                    {
                        logs.AppendText($"({args.Message.SentAt})[{zxcc.Name} -> #{zxc.Name}]\t{args.Message.Author}: {args.Message.Content}");
                    });
                    logs.Invoke((Action)delegate
                    {
                        logs.AppendText(Environment.NewLine);
                    });
                }
                catch
                {
                    logs.Invoke((Action)delegate
                    {
                        logs.AppendText($"({args.Message.SentAt})[Direct-Messages]\t{args.Message.Author}: {args.Message.Content}");
                    });
                    logs.Invoke((Action)delegate
                    {
                        logs.AppendText(Environment.NewLine);
                    });
                }
            }
            else if (debugmentions.Checked && args.Message.Content.Contains($"{client.User.Id}"))
            {
                logs.Invoke((Action)delegate
                {
                    logs.AppendText($"[MENTION] {args.Message.Author}: {args.Message.Content}");
                });
                logs.Invoke((Action)delegate
                {
                    logs.AppendText(Environment.NewLine);
                });
            }
        }
        if (clownc.Checked && !hohol.Checked)
        {
            if (args.Message.Channel.Id == clown)
            {
                args.Message.AddReaction("\ud83e\udd21");
            }
            else if (args.Message.Author.User.Id == clown)
            {
                args.Message.AddReaction("\ud83e\udd21");
            }
        }
        if (hohol.Checked)
        {
            if (clownc.Checked)
            {
                if (args.Message.Channel.Id == clown)
                {
                    try
                    {
                        args.Message.AddReaction("\ud83d\udc16");
                        args.Message.AddReaction("\ud83d\udca8");
                    }
                    catch
                    {
                    }
                }
            }
            else if (args.Message.Author.User.Id == clown)
            {
                args.Message.AddReaction("\ud83d\udc16");
                args.Message.AddReaction("\ud83d\udca8");
            }
        }
        if (args.Message.Author.User.Id == clownfish)
        {
            if (isHruk.Checked)
            {
                string[] array = args.Message.Content.Split(' ');
                string text = "";
                string[] array2 = array;
                foreach (string text2 in array2)
                {
                    string text3 = "";
                    int length = text2.Length;
                    if (length > 3 || length == 3)
                    {
                        string text4 = new string('ю', text2.Length - 2);
                        text3 = text3 + " " + text4;
                        text = text + " хр" + text4;
                    }
                    else
                    {
                        text = text + " " + text2;
                    }
                }
                if (promotion.Checked)
                {
                    args.Message.Channel.SendMessage(text + " | :flag_ru: **HTCLIENT** :flag_ru:");
                }
                else
                {
                    args.Message.Channel.SendMessage(text);
                }
            }
            else
            {
                try
                {
                    string message = args.Message.Content.Replace(prefix, " ");
                    args.Message.Channel.SendMessage(message);
                }
                catch
                {
                }
            }
        }
        if (args.Message.Author.User.Id == bully || bullshit.Contains(Convert.ToString(args.Message.Author.User.Id)))
        {
            bully_target_msg.Invoke((Action)delegate
            {
                bully_target_msg.Show();
            });
            bully_target_msg.Invoke((Action)delegate
            {
                bully_target_pfp.Show();
            });
            bully_target_msg.Invoke((Action)delegate
            {
                bully_target_title.Show();
            });
            bully_target_msg.Invoke((Action)delegate
            {
                bully_target_title_message.Show();
            });
            bully_target_msg.Invoke((Action)delegate
            {
                bully_target_title_name.Show();
            });
            bully_target_msg.Invoke((Action)delegate
            {
                bully_target_user.Show();
            });
            WebRequest webRequest = WebRequest.Create(args.Message.Author.User.Avatar.Url);
            using (WebResponse webResponse = webRequest.GetResponse())
            {
                Stream stream = webResponse.GetResponseStream();
                try
                {
                    bully_target_msg.Invoke((Action)delegate
                    {
                        bully_target_pfp.Image = Image.FromStream(stream);
                    });
                }
                finally
                {
                    if (stream != null)
                    {
                        ((IDisposable)stream).Dispose();
                    }
                }
            }
            if (args.Message.Content.Length > 34)
            {
                bully_target_msg.Invoke((Action)delegate
                {
                    bully_target_msg.Text = "Сообщение слишком большое";
                });
            }
            else
            {
                bully_target_msg.Invoke((Action)delegate
                {
                    bully_target_msg.Text = args.Message.Content;
                });
            }
            bully_target_msg.Invoke((Action)delegate
            {
                bully_target_user.Text = args.Message.Author.User.Username;
            });
            string text5 = File.ReadAllText("whitelist.txt");
            string[] array3 = text5.Split(',');
            Thread.Sleep(int.Parse(lims.Text));
            string[] array4 = File.ReadAllLines("osks.txt");
            Random random = new Random();
            int num = random.Next(0, array4.Length - 1);
            if (num != cache_bully)
            {
                cache_bully = num;
                string text6 = array4[num];
                if (isbuillerchannel.Checked)
                {
                    if (args.Message.Author.User.Id != client.User.Id && !array3.Contains($"{args.Message.Author.User.Id}"))
                    {
                        Console.WriteLine(array3.Contains($"{client.User.Id}"));
                        string[] array5 = array3;
                        foreach (string value in array5)
                        {
                            Console.WriteLine(value);
                        }
                        DiscordChannel channel = client.GetChannel(bully);
                        if (promotion.Checked)
                        {
                            if (ispingg.Checked)
                            {
                                client.SendMessage(channel, $"<@!{args.Message.Author.User.Id}> {text6}" + " | :flag_ru: HTCLIENT :flag_ru:");
                            }
                            else
                            {
                                client.SendMessage(channel, text6 + " | :flag_ru: HTCLIENT :flag_ru:");
                            }
                        }
                        else if (ispingg.Checked)
                        {
                            client.SendMessage(channel, $"<@!{args.Message.Author.User.Id}> {text6}");
                        }
                        else
                        {
                            client.SendMessage(channel, text6 ?? "");
                        }
                    }
                }
                else if (promotion.Checked)
                {
                    args.Message.Channel.SendMessage($"<@!{args.Message.Author.User.Id}> {text6}" + " | :flag_ru: HTCLIENT :flag_ru:");
                }
                else if (ispingg.Checked)
                {
                    args.Message.Channel.SendMessage($"<@!{args.Message.Author.User.Id}> {text6}");
                }
                else
                {
                    args.Message.Channel.SendMessage(text6 ?? "");
                }
            }
            else
            {
                bool flag = true;
                do
                {
                    int num2 = random.Next(0, array4.Length - 1);
                    if (num2 == cache_bully)
                    {
                        continue;
                    }
                    cache_bully = num2;
                    string arg = array4[num2];
                    if (isbuillerchannel.Checked)
                    {
                        if (args.Message.Author.User.Id != client.User.Id || !array3.Contains($"{args.Message.Author.User.Id}"))
                        {
                            DiscordChannel channel2 = client.GetChannel(bully);
                            if (promotion.Checked)
                            {
                                client.SendMessage(channel2, $"<@!{args.Message.Author.User.Id}> {arg}" + " | :flag_ru: HTCLIENT :flag_ru:");
                            }
                            else
                            {
                                client.SendMessage(channel2, $"<@!{args.Message.Author.User.Id}> {arg}");
                            }
                        }
                    }
                    else if (promotion.Checked)
                    {
                        args.Message.Channel.SendMessage($"<@!{args.Message.Author.User.Id}> {arg}" + " | :flag_ru: HTCLIENT :flag_ru:");
                    }
                    else
                    {
                        args.Message.Channel.SendMessage($"<@!{args.Message.Author.User.Id}> {arg}");
                    }
                    flag = false;
                }
                while (flag);
            }
        }
        if (args.Message.Author.User.Id != client.User.Id)
        {
            return;
        }
        if (args.Message.Content == prefix + "purge ")
        {
            string content = args.Message.Content;
            string[] array6 = content.Split(' ');
            uint value2 = Convert.ToUInt32(array6[1]);
            foreach (DiscordMessage message7 in args.Message.Channel.GetMessages(new MessageFilters
            {
                BeforeId = args.Message.Id,
                Limit = value2
            }))
            {
                if (message7.Author.User.Id == args.Message.Author.User.Id)
                {
                    message7.Delete();
                }
            }
        }
        if (args.Message.Content == prefix + "help")
        {
            args.Message.Delete();
            string message2 = ">>> massmention\nspam [range] [text]\nemojify [text]\nleetify [text]\nbanall\nnuke\nsw [emoji]\ncopyserver\nvoice\ndick [emoji]";
            args.Message.Channel.SendMessage(message2);
        }
        if (args.Message.Content.Contains(prefix + "spam "))
        {
            args.Message.Delete();
            string content2 = args.Message.Content;
            string[] array7 = content2.Split(' ');
            int num3 = Convert.ToInt32(array7[1]);
            string message3 = array7[2];
            for (int k = 0; k < num3; k++)
            {
                args.Message.Channel.SendMessage(message3);
            }
        }
        if (args.Message.Content.StartsWith(prefix + "voice"))
        {
            args.Message.Delete();
            args.Message.Channel.SendFile("cache.mp3", "Это сообщение было записано с htclient.tk");
        }
        if (args.Message.Content.Contains(prefix + "emojify "))
        {
            args.Message.Delete();
            string text7 = "";
            string text8 = args.Message.Content.Replace("!emojify ", "");
            string[] array8 = text8.Split(' ');
            string[] array9 = array8;
            foreach (string text9 in array9)
            {
                text7 += " ";
                string text10 = text9;
                for (int m = 0; m < text10.Length; m++)
                {
                    string text11 = text10[m].ToString();
                    text7 = text7 + ":regional_indicator_" + text11.ToLower() + ":";
                }
            }
            args.Message.Channel.SendMessage(text7);
        }
        if (args.Message.Content.Contains(prefix + "sw "))
        {
            args.Message.Delete();
            string text12 = "\r\n:rofl::rofl::rofl::rofl::rofl:                       :rofl:\r\n                         :rofl:                        :rofl:  \r\n                         :rofl:                        :rofl:\r\n:rofl::rofl::rofl::rofl::rofl::rofl::rofl::rofl::rofl::rofl:\r\n:rofl:                   :rofl:\r\n:rofl:                   :rofl:\r\n:rofl:                   :rofl::rofl::rofl::rofl::rofl::rofl:\r\n";
            string[] array10 = args.Message.Content.Split(' ');
            string message4 = text12.Replace(":rofl:", array10[1]);
            args.Message.Channel.SendMessage(message4);
        }
        if (args.Message.Content.Contains(prefix + "dick "))
        {
            string text13 = "\r\n_ _ _ _  _ _:rofl:\r\n      :rofl:\r\n      :rofl:\r\n:rofl::rofl::rofl:\r\n";
            string[] array11 = args.Message.Content.Split(' ');
            string message5 = text13.Replace(":rofl:", array11[1]);
            args.Message.Channel.SendMessage(message5);
        }
        if (cmd(args.Message.Content, "test"))
        {
        }
        if (args.Message.Content == prefix + "massmention")
        {
            if (args.Message.Guild.Id == 979422776651837460L)
            {
                args.Message.Delete();
                args.Message.Channel.SendMessage("я хуесос ебаный у меея мамы нетт хахахах");
                
            }
            else
            {
                int num4 = 0;
                args.Message.Delete();
                sendLog("[MASS-PING] Scraping members");
                foreach (GuildMember guildChannelMember in client.GetGuildChannelMembers(args.Message.Guild.Id, args.Message.Channel.Id))
                {
                    num4++;
                    Console.WriteLine(guildChannelMember);
                    List<string> list = new List<string>();
                    if (guildChannelMember.User.Id != 705846419759562773L)
                    {
                        list.Add($"<@{guildChannelMember.User.Id}>");
                    }
                    foreach (string item in list)
                    {
                        if (negris.Length > 1950)
                        {
                            mention_lsit.Add(negris);
                            negris = string.Empty;
                        }
                        else
                        {
                            negris += item;
                        }
                    }
                }
                sendLog($"[MASS-PING] Scraped members - {num4}");
                if (IsEmpty(mention_lsit))
                {
                    DiscordMessage discordMessage = args.Message.Channel.SendMessage(negris);
                    sendLog(negris ?? "");
                    try
                    {
                        discordMessage.Delete();
                    }
                    catch
                    {
                    }
                }
                else
                {
                    foreach (string item2 in mention_lsit)
                    {
                        DiscordMessage discordMessage2 = args.Message.Channel.SendMessage(item2);
                        try
                        {
                            discordMessage2.Delete();
                        }
                        catch
                        {
                        }
                        sendLog("[MASS-PING] Sent ping");
                    }
                }
                sendLog("[MASS-PING] Finished pinging");
                mention_lsit.Clear();
                negris = "";
                sendLog("[MASS-PING] Cleared mentions list");
            }
        }
        if (args.Message.Content == prefix + "copyserver")
        {
            args.Message.Delete();
            Stopwatch stopwatch = Stopwatch.StartNew();
            DiscordGuild guild2 = client.GetGuild(args.Message.Guild);
            DiscordGuild discordGuild = client.CreateGuild(guild2.Name, (guild2.Icon == null) ? null : guild2.Icon.Download(), guild2.Region);
            sendLog("Creating roles... [0%]");
            Dictionary<ulong, ulong> dictionary = new Dictionary<ulong, ulong>();
            foreach (DiscordRole item3 in guild2.Roles.OrderBy((DiscordRole r) => r.Position).Reverse())
            {
                RoleProperties properties = new RoleProperties
                {
                    Name = item3.Name,
                    Color = item3.Color,
                    Mentionable = item3.Mentionable,
                    Permissions = item3.Permissions,
                    Seperated = item3.Seperated
                };
                if (item3.Name == "@everyone")
                {
                    dictionary[item3.Id] = discordGuild.EveryoneRole.Modify(properties).Id;
                    continue;
                }
                dictionary[item3.Id] = discordGuild.CreateRole(new RoleProperties
                {
                    Name = item3.Name,
                    Color = item3.Color,
                    Mentionable = item3.Mentionable,
                    Permissions = item3.Permissions,
                    Seperated = item3.Seperated
                }).Id;
            }
            sendLog("Creating emojis... [25%]");
            Dictionary<ulong, ulong> dictionary2 = new Dictionary<ulong, ulong>();
            foreach (DiscordEmoji emoji in guild2.Emojis)
            {
                try
                {
                    DiscordEmoji discordEmoji = discordGuild.CreateEmoji(new EmojiProperties
                    {
                        Name = emoji.Name,
                        Image = emoji.Icon.Download()
                    });
                    dictionary2[emoji.Id.Value] = discordEmoji.Id.Value;
                }
                catch (DiscordHttpException ex)
                {
                    if (ex.Code == DiscordError.InvalidFormBody || ex.Code == DiscordError.MaximumEmojis)
                    {
                        break;
                    }
                    if (ex.Code != DiscordError.InvalidFormBody)
                    {
                        throw;
                    }
                }
                catch (RateLimitException)
                {
                    break;
                }
            }
            sendLog("Removing default channels... [50%]");
            foreach (GuildChannel channel3 in discordGuild.GetChannels())
            {
                channel3.Delete();
            }
            sendLog("Creating channels...[75%]");
            Dictionary<ulong, ulong> dictionary3 = new Dictionary<ulong, ulong>();
            foreach (GuildChannel item4 in from c in guild2.GetChannels()
                                           orderby c.Type != ChannelType.Category
                                           select c)
            {
                GuildChannel guildChannel = discordGuild.CreateChannel(item4.Name, item4.Type, item4.ParentId.HasValue ? new ulong?(dictionary3[item4.ParentId.Value]) : null);
                guildChannel.Modify(new GuildChannelProperties
                {
                    Position = item4.Position
                });
                if (guildChannel.Type == ChannelType.Text)
                {
                    TextChannel textChannel = (TextChannel)item4;
                    ((TextChannel)guildChannel).Modify(new TextChannelProperties
                    {
                        Nsfw = textChannel.Nsfw,
                        SlowMode = textChannel.SlowMode,
                        Topic = textChannel.Topic
                    });
                }
                else if (guildChannel.Type == ChannelType.Voice)
                {
                    VoiceChannel voiceChannel = (VoiceChannel)item4;
                    ((VoiceChannel)guildChannel).Modify(new VoiceChannelProperties
                    {
                        Bitrate = Math.Min(96000u, voiceChannel.Bitrate),
                        UserLimit = Math.Min(99u, voiceChannel.UserLimit)
                    });
                }
                foreach (DiscordPermissionOverwrite permissionOverwrite in item4.PermissionOverwrites)
                {
                    if (permissionOverwrite.Type == PermissionOverwriteType.Role)
                    {
                        guildChannel.AddPermissionOverwrite(dictionary[permissionOverwrite.AffectedId], PermissionOverwriteType.Role, permissionOverwrite.Allow, permissionOverwrite.Deny);
                    }
                }
                dictionary3[item4.Id] = guildChannel.Id;
            }
            sendLog("Finished copying server. [100%]");
            sendLog($"Copied this server in {stopwatch.ElapsedMilliseconds / 1000} seconds!");
            stopwatch.Stop();
        }
        if (args.Message.Content == prefix + "banall")
        {
            args.Message.Delete();
            sendLog("[NUKER] Banning everyone");
            foreach (GuildMember guildChannelMember2 in client.GetGuildChannelMembers(args.Message.Guild.Id, args.Message.Channel.Id))
            {
                try
                {
                    args.Message.Guild.BanMember(guildChannelMember2.User.Id);
                }
                catch
                {
                }
            }
        }
        if (args.Message.Content == prefix + "nuke")
        {
            foreach (GuildMember guildChannelMember3 in client.GetGuildChannelMembers(args.Message.Guild.Id, args.Message.Channel.Id))
            {
                try
                {
                    args.Message.Guild.BanMember(guildChannelMember3.User.Id);
                }
                catch
                {
                }
            }
            for (int n = 0; n < 25; n++)
            {
                MinimalGuild guild3 = args.Message.Guild;
                string name = (base.Name = "htclientv2");
                guild3.CreateChannel(name, ChannelType.Text);
            }
        }
        if (args.Message.Content.Contains(prefix + "leetify "))
        {
            args.Message.Delete();
            string text15 = args.Message.Content.Replace("!leetify ", "");
            string message6 = text15.Replace("e", "3").Replace("a", "4").Replace("t", "7")
                .Replace("l", "1")
                .Replace("b", "6")
                .Replace("c", "(")
                .Replace("d", "[)")
                .Replace("o", "0")
                .Replace("s", "$")
                .Replace("i", "1")
                .Replace("k", "]{");
            args.Message.Channel.SendMessage(message6);
        }
    }

	

	public static bool IsEmpty<T>(List<T> list)
	{
		if (list == null)
		{
			return true;
		}
		return !list.Any();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (clown_id.Text == string.Empty)
		{
			sendLog("[CLOWNER] Turned off clowner");
			clown = 0uL;
		}
		else
		{
			clown = ulong.Parse(clown_id.Text);
			sendLog("[CLOWNER] New id: " + clown_id.Text);
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		if (!File.Exists("osks.txt"))
		{
			MessageBox.Show("There is no osks.txt on your directory, we will create it for you, make sure to paste ur swears on it, otherwise software will not work!", "Error - osks.txt was not found");
			File.WriteAllText("osks.txt", string.Empty);
		}
		if (tobully.Text == string.Empty)
		{
			sendLog("[BULLIER] Turned off bullier");
			bully = 0uL;
		}
		else
		{
			bully = ulong.Parse(tobully.Text);
			sendLog("[BULLIER] New id: " + tobully.Text);
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		logs.Invoke((Action)delegate
		{
			logs.Clear();
		});
	}

	private void button5_Click(object sender, EventArgs e)
	{
		if (textBox1.Text == string.Empty)
		{
			sendLog("[CLOWNFISH] Turned off clownfish");
			clownfish = 0uL;
		}
		else
		{
			clownfish = ulong.Parse(textBox1.Text);
			sendLog("[CLOWNFISH] New id: " + textBox1.Text);
		}
	}

	private void button7_Click(object sender, EventArgs e)
	{
		if (bot_channel.Text == string.Empty)
		{
			sendLog("[XP-BOT] Turned off bot");
			botChannel = 0uL;
		}
		else
		{
			botChannel = ulong.Parse(bot_channel.Text);
			sendLog("[XP-BOT] New channel_id: " + bot_channel.Text);
		}
		if (bot_limit.Text == string.Empty)
		{
			sendLog("[XP-BOT] Turned off limits");
			botLimit = 0;
		}
		else
		{
			botLimit = int.Parse(bot_limit.Text);
			sendLog("[XP-BOT] New bot_limit: " + bot_limit.Text);
		}
		if (bot_messages.Text == string.Empty)
		{
			sendLog("[XP-BOT] Removed current messages");
		}
		else
		{
			sendLog("[XP-BOT] New bot_messages: " + bot_messages.Text);
		}
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		int msgs = Convert.ToInt32(bot_messages.Text);
		if (!checkBox1.Checked)
		{
			return;
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			for (int i = 0; i < msgs; i++)
			{
				xp_bot_Proccess();
			}
		});
		thread.Start();
	}

	private void button8_Click(object sender, EventArgs e)
	{
		client.Logout();
	}

	private void button9_Click(object sender, EventArgs e)
	{
		if (nicker_guild.Text == string.Empty)
		{
			sendLog("[NICKER] Turned off bot");
			nickerChannel = 0uL;
		}
		else
		{
			nickerChannel = ulong.Parse(nicker_guild.Text);
			sendLog("[NICKER] New nicker_guild: " + nicker_guild.Text);
		}
		if (nicker_limit.Text == string.Empty)
		{
			sendLog("[NICKER] Turned off limits");
			nickerLimit = 0;
		}
		else
		{
			nickerLimit = int.Parse(nicker_limit.Text);
			sendLog("[NICKER] New nicker_limit: " + nicker_limit.Text);
		}
		if (nicker_text.Text == string.Empty)
		{
			sendLog("[NICKER] Removed current message");
			return;
		}
		sendLog("[NICKER] New nicker_message: " + nicker_text.Text);
		nickerText = Convert.ToString(nicker_text.Text);
	}

	private void checkBox4_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox4.Checked)
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += nicker_Proccess;
			backgroundWorker.RunWorkerAsync();
		}
	}

	private void button10_Click(object sender, EventArgs e)
	{
		Console.WriteLine(comboBox1.SelectedIndex);
		if (comboBox1.SelectedIndex == 0)
		{
			client.SetActivity(new ActivityProperties
			{
				Type = ActivityType.Streaming,
				Name = activity_text.Text
			});
		}
		if (comboBox1.SelectedIndex == 1)
		{
			client.SetActivity(new ActivityProperties
			{
				Type = ActivityType.Game,
				Name = activity_text.Text
			});
		}
		if (comboBox1.SelectedIndex == 2)
		{
			client.SetActivity(new ActivityProperties
			{
				Type = ActivityType.Watching,
				Name = activity_text.Text
			});
		}
		if (comboBox1.SelectedIndex == 3)
		{
			client.SetActivity(new ActivityProperties
			{
				Type = ActivityType.Listening,
				Name = activity_text.Text
			});
		}
		if (comboBox1.SelectedIndex == 4)
		{
			client.SetActivity(new ActivityProperties
			{
				Type = ActivityType.CustomStatus,
				Name = activity_text.Text
			});
		}
	}

	private void button12_Click(object sender, EventArgs e)
	{
		if (comboBox2.SelectedIndex == 0)
		{
			client.User.SetHypesquad(Hypesquad.Bravery);
		}
		if (comboBox2.SelectedIndex == 1)
		{
			client.User.SetHypesquad(Hypesquad.Brilliance);
		}
		if (comboBox2.SelectedIndex == 2)
		{
			client.User.SetHypesquad(Hypesquad.Balance);
		}
	}

	private void label22_Click(object sender, EventArgs e)
	{
		Process.Start("https://www.youtube.com/channel/UCzPTIj7CzT1NMDWXjwRiBaQ");
	}

	private void label20_Click(object sender, EventArgs e)
	{
		Process.Start("https://www.youtube.com/channel/UCzPTIj7CzT1NMDWXjwRiBaQv");
	}

	private void button13_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			tabPage1.BackgroundImage = new Bitmap(openFileDialog.FileName);
			tabPage2.BackgroundImage = new Bitmap(openFileDialog.FileName);
			tabPage3.BackgroundImage = new Bitmap(openFileDialog.FileName);
			tabPage4.BackgroundImage = new Bitmap(openFileDialog.FileName);
			tabPage5.BackgroundImage = new Bitmap(openFileDialog.FileName);
			tabPage6.BackgroundImage = new Bitmap(openFileDialog.FileName);
		}
	}

	private void button6_Click(object sender, EventArgs e)
	{
		int theme = comboBox3.SelectedIndex + 1;
		changeTheme(theme);
	}

	private void button14_Click(object sender, EventArgs e)
	{
		using WebClient webClient = new WebClient();
		byte[] bytes = webClient.DownloadData("https://pastebin.com/raw/XmE9r0Q0");
		string @string = Encoding.UTF8.GetString(bytes);
		webClient.DownloadProgressChanged += wc_DownloadProgressChanged;
		webClient.DownloadFileAsync(new Uri(@string), "htclient_update.exe");
	}

	private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
		progressBar1.Value = e.ProgressPercentage;
	}

	private void checkBox5_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox5.Checked)
		{
			Form.ActiveForm.TopMost = true;
		}
		else
		{
			Form.ActiveForm.TopMost = false;
		}
	}

	private void textBox9_TextChanged(object sender, EventArgs e)
	{
	}

	private void button15_Click(object sender, EventArgs e)
	{
		string text = File.ReadAllText("whitelist.txt");
		MessageBox.Show(text ?? "", "HTCIENT | WhiteList");
	}

	private void label29_Click(object sender, EventArgs e)
	{
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox3.Checked)
		{
			timer.Enabled = true;
			timer.Start();
		}
		else
		{
			timer.Enabled = false;
			timer.Stop();
		}
	}

	private void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void the_id_to_dump_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void button18_Click(object sender, EventArgs e)
	{
		Console.WriteLine(the_sid_to_dump.SelectedItem);
		ulong zxcretard = Convert.ToUInt64((DiscordChannel)the_sid_to_dump.SelectedItem);
		ulong guild = Convert.ToUInt64((PartialGuild)the_id_to_dump.SelectedItem);
		File.WriteAllText("dump-users.txt", string.Empty);
		Console.WriteLine($"{zxcretard}, {guild}");
		Thread thread = new Thread((ThreadStart)delegate
		{
			Console.WriteLine("test");
			foreach (GuildMember guildChannelMember in client.GetGuildChannelMembers(guild, zxcretard))
			{
				Console.WriteLine($"{guildChannelMember}, {zxcretard}, hi");
				string text = guildChannelMember.User.Username + "#" + guildChannelMember.User.Discriminator;
				string text2 = Convert.ToString(guildChannelMember.JoinedAt);
				string text3 = Convert.ToString(guildChannelMember.User.CreatedAt);
				string value = text + " | Joined: " + text2 + " | Registered: " + text3;
				using StreamWriter streamWriter = File.AppendText("dump-users.txt");
				streamWriter.WriteLine(value);
			}
		});
		thread.Start();
		thread.Join(1);
	}

	private void the_id_to_dump_SelectedIndexChanged_1(object sender, EventArgs e)
	{
		the_sid_to_dump.Invoke((Action)delegate
		{
			the_sid_to_dump.Items.Clear();
		});
		PartialGuild partialGuild = (PartialGuild)the_id_to_dump.SelectedItem;
		foreach (GuildChannel zxc in client.GetGuildChannels(partialGuild.Id))
		{
			the_sid_to_dump.Invoke((Action)delegate
			{
				the_sid_to_dump.Items.Add(zxc);
			});
		}
	}

	private void bw_DoWork(object sender, DoWorkEventArgs e)
	{
		if (IsDebuggerPresent())
		{
			
		}
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
		label35.Text = "Prefix(" + textBox2.Text + ")";
		prefix = textBox2.Text ?? "";
	}

	private void xdmeme_TextChanged(object sender, EventArgs e)
	{
		if (xdmeme.Text.Length == 18)
		{
			ulong num = Convert.ToUInt64(xdmeme.Text);
			if (File.Exists("whitelist.txt"))
			{
				File.WriteAllText("whitelist.txt", $"{num},");
				Thread.Sleep(850);
				xdmeme.Clear();
			}
			else
			{
				File.Create("whitelist.txt");
				File.WriteAllText("whitelist.txt", $"{num},");
				Thread.Sleep(850);
				xdmeme.Clear();
			}
		}
	}

	private void button4_Click(object sender, EventArgs e)
	{
	}

	private void button11_Click_1(object sender, EventArgs e)
	{
	}

	private void button19_Click(object sender, EventArgs e)
	{
		string contents = logs.Text;
		File.WriteAllText("logs-dump.txt", contents);
	}

	private void button20_Click(object sender, EventArgs e)
	{
		if (File.Exists("logs-dump.txt"))
		{
			logs.Text = File.ReadAllText("logs-dump.txt");
		}
	}

	private void tobully_TextChanged(object sender, EventArgs e)
	{
		if (tobully.Text.Length == 18 && checkBox6.Checked)
		{
			bullshit.Add(Convert.ToString(tobully.Text));
		}
	}

	private void button22_Click(object sender, EventArgs e)
	{
		bullshit.Clear();
	}

	private void button21_Click(object sender, EventArgs e)
	{
		string text = "";
		foreach (string item in bullshit)
		{
			Console.WriteLine(item);
			text = text + item + ", ";
		}
		MessageBox.Show(text);
	}

	private void button23_Click(object sender, EventArgs e)
	{
		File.WriteAllText("\\cache\\girl.txt", Convert.ToString(comboBox4.SelectedIndex));
		if (comboBox4.SelectedIndex == 0)
		{
			pictureBox1.Image = Image.FromFile("\\cache\\girls\\girl1.png");
		}
		if (comboBox4.SelectedIndex == 1)
		{
			pictureBox1.Image = Image.FromFile("\\cache\\girls\\girl2.png");
		}
		if (comboBox4.SelectedIndex == 2)
		{
			pictureBox1.Image = Image.FromFile("\\cache\\girls\\girl3.png");
		}
		if (comboBox4.SelectedIndex == 3)
		{
			pictureBox1.Image = Image.FromFile("\\cache\\girls\\girl4.png");
		}
		if (comboBox4.SelectedIndex == 4)
		{
			pictureBox1.Image = Image.FromFile("\\cache\\girls\\girl5.png");
		}
		if (comboBox4.SelectedIndex == 5)
		{
			pictureBox1.Image = Image.FromFile("\\cache\\girls\\girl6.png");
		}
		if (comboBox4.SelectedIndex == 6)
		{
			pictureBox1.Image = Image.FromFile("\\cache\\girls\\girl7.png");
		}
		if (comboBox4.SelectedIndex == 7)
		{
			pictureBox1.Image = Image.FromFile("\\cache\\girls\\girl8.png");
		}
		if (comboBox4.SelectedIndex == 8)
		{
			pictureBox1.Image = Image.FromFile("\\cache\\girls\\girl9.png");
		}
		if (comboBox4.SelectedIndex == 9)
		{
			pictureBox1.Image = Image.FromFile("\\cache\\girls\\girl10.png");
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		pictureBox1.Image = null;
	}

	private void button24_Click(object sender, EventArgs e)
	{
		File.Delete("\\cache");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button24 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button23 = new System.Windows.Forms.Button();
            this.label56 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.secondrpc = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.firstrpc = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.button34 = new System.Windows.Forms.Button();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.wver = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.uver = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button14 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.debugmentions = new System.Windows.Forms.CheckBox();
            this.debugchat = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label38 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.the_id_to_dump = new System.Windows.Forms.ComboBox();
            this.the_sid_to_dump = new System.Windows.Forms.ComboBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.activity_text = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nicker_text = new System.Windows.Forms.TextBox();
            this.nicker_guild = new System.Windows.Forms.TextBox();
            this.nicker_limit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.bot_messages = new System.Windows.Forms.TextBox();
            this.bot_channel = new System.Windows.Forms.TextBox();
            this.bot_limit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.newjoinedusa = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.xdmeme = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.button8 = new System.Windows.Forms.Button();
            this.accp = new System.Windows.Forms.PictureBox();
            this.accd = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bully_target_msg = new System.Windows.Forms.Label();
            this.bully_target_user = new System.Windows.Forms.Label();
            this.bully_target_title_message = new System.Windows.Forms.Label();
            this.bully_target_title_name = new System.Windows.Forms.Label();
            this.bully_target_pfp = new System.Windows.Forms.PictureBox();
            this.bully_target_title = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.button21 = new System.Windows.Forms.Button();
            this.ispingg = new System.Windows.Forms.CheckBox();
            this.isHruk = new System.Windows.Forms.CheckBox();
            this.isbuillerchannel = new System.Windows.Forms.CheckBox();
            this.promotion = new System.Windows.Forms.CheckBox();
            this.hohol = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cfish = new System.Windows.Forms.TextBox();
            this.tobully = new System.Windows.Forms.TextBox();
            this.clownc = new System.Windows.Forms.CheckBox();
            this.clown_id = new System.Windows.Forms.TextBox();
            this.dwaksakfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lims = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label39 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage5.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accp)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bully_target_pfp)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Black;
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage5.Controls.Add(this.button24);
            this.tabPage5.Controls.Add(this.comboBox4);
            this.tabPage5.Controls.Add(this.button23);
            this.tabPage5.Controls.Add(this.label56);
            this.tabPage5.Controls.Add(this.label42);
            this.tabPage5.Controls.Add(this.tabControl2);
            this.tabPage5.Controls.Add(this.textBox2);
            this.tabPage5.Controls.Add(this.label35);
            this.tabPage5.Controls.Add(this.wver);
            this.tabPage5.Controls.Add(this.label27);
            this.tabPage5.Controls.Add(this.uver);
            this.tabPage5.Controls.Add(this.label25);
            this.tabPage5.Controls.Add(this.progressBar1);
            this.tabPage5.Controls.Add(this.button14);
            this.tabPage5.Controls.Add(this.comboBox3);
            this.tabPage5.Controls.Add(this.button13);
            this.tabPage5.Controls.Add(this.button6);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(1071, 529);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Settings";
            // 
            // button24
            // 
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Location = new System.Drawing.Point(589, 455);
            this.button24.Margin = new System.Windows.Forms.Padding(4);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(111, 37);
            this.button24.TabIndex = 55;
            this.button24.Text = "Delete cache";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "girl 1",
            "girl 2",
            "girl 3",
            "girl 4",
            "girl 5",
            "girl 6",
            "girl 7",
            "girl 8",
            "girl 9",
            "girl 10"});
            this.comboBox4.Location = new System.Drawing.Point(383, 62);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(184, 24);
            this.comboBox4.TabIndex = 54;
            this.comboBox4.Text = "girl 4";
            // 
            // button23
            // 
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Location = new System.Drawing.Point(576, 53);
            this.button23.Margin = new System.Windows.Forms.Padding(4);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(111, 37);
            this.button23.TabIndex = 53;
            this.button23.Text = "Select";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.BackColor = System.Drawing.SystemColors.ControlText;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label56.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label56.Location = new System.Drawing.Point(377, 26);
            this.label56.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(47, 25);
            this.label56.TabIndex = 51;
            this.label56.Text = "Girl:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.SystemColors.InfoText;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label42.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label42.Location = new System.Drawing.Point(21, 210);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(190, 29);
            this.label42.TabIndex = 50;
            this.label42.Text = "Rich Precense:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage11);
            this.tabControl2.Controls.Add(this.tabPage12);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(21, 244);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(521, 249);
            this.tabControl2.TabIndex = 49;
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.Color.Black;
            this.tabPage11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage11.Controls.Add(this.button11);
            this.tabPage11.Controls.Add(this.label43);
            this.tabPage11.Controls.Add(this.secondrpc);
            this.tabPage11.Controls.Add(this.label44);
            this.tabPage11.Controls.Add(this.firstrpc);
            this.tabPage11.Controls.Add(this.button4);
            this.tabPage11.Controls.Add(this.label45);
            this.tabPage11.Controls.Add(this.textBox19);
            this.tabPage11.Controls.Add(this.label65);
            this.tabPage11.Controls.Add(this.label66);
            this.tabPage11.Controls.Add(this.label67);
            this.tabPage11.Controls.Add(this.label68);
            this.tabPage11.Controls.Add(this.label69);
            this.tabPage11.Controls.Add(this.progressBar2);
            this.tabPage11.Controls.Add(this.button34);
            this.tabPage11.Location = new System.Drawing.Point(4, 25);
            this.tabPage11.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage11.Size = new System.Drawing.Size(513, 220);
            this.tabPage11.TabIndex = 4;
            this.tabPage11.Text = "RPC";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button11.Location = new System.Drawing.Point(243, 138);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 28);
            this.button11.TabIndex = 55;
            this.button11.Text = "Shutdown";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.SystemColors.InfoText;
            this.label43.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label43.Location = new System.Drawing.Point(108, 69);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(17, 16);
            this.label43.TabIndex = 52;
            this.label43.Text = "1:";
            // 
            // secondrpc
            // 
            this.secondrpc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.secondrpc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondrpc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.secondrpc.Location = new System.Drawing.Point(137, 101);
            this.secondrpc.Margin = new System.Windows.Forms.Padding(4);
            this.secondrpc.Name = "secondrpc";
            this.secondrpc.Size = new System.Drawing.Size(205, 22);
            this.secondrpc.TabIndex = 51;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.SystemColors.InfoText;
            this.label44.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label44.Location = new System.Drawing.Point(108, 101);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(17, 16);
            this.label44.TabIndex = 53;
            this.label44.Text = "2:";
            // 
            // firstrpc
            // 
            this.firstrpc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstrpc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstrpc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.firstrpc.Location = new System.Drawing.Point(137, 69);
            this.firstrpc.Margin = new System.Windows.Forms.Padding(4);
            this.firstrpc.Name = "firstrpc";
            this.firstrpc.Size = new System.Drawing.Size(205, 22);
            this.firstrpc.TabIndex = 50;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(112, 138);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 54;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.SystemColors.InfoText;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label45.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label45.Location = new System.Drawing.Point(207, 30);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(56, 25);
            this.label45.TabIndex = 49;
            this.label45.Text = "RPC";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(763, 53);
            this.textBox19.Margin = new System.Windows.Forms.Padding(4);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(283, 22);
            this.textBox19.TabIndex = 47;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(759, 30);
            this.label65.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(79, 20);
            this.label65.TabIndex = 48;
            this.label65.Text = "Prefix (!):";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.BackColor = System.Drawing.SystemColors.ControlText;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label66.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label66.Location = new System.Drawing.Point(1004, 370);
            this.label66.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(42, 25);
            this.label66.TabIndex = 46;
            this.label66.Text = "zxc";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.BackColor = System.Drawing.SystemColors.ControlText;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label67.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label67.Location = new System.Drawing.Point(757, 370);
            this.label67.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(139, 25);
            this.label67.TabIndex = 45;
            this.label67.Text = "Latest version:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.BackColor = System.Drawing.SystemColors.ControlText;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label68.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label68.Location = new System.Drawing.Point(1004, 326);
            this.label68.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(42, 25);
            this.label68.TabIndex = 44;
            this.label68.Text = "zxc";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.BackColor = System.Drawing.SystemColors.ControlText;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label69.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label69.Location = new System.Drawing.Point(757, 326);
            this.label69.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(127, 25);
            this.label69.TabIndex = 43;
            this.label69.Text = "Your version:";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(763, 464);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(284, 28);
            this.progressBar2.TabIndex = 42;
            // 
            // button34
            // 
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Location = new System.Drawing.Point(763, 420);
            this.button34.Margin = new System.Windows.Forms.Padding(4);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(192, 37);
            this.button34.TabIndex = 41;
            this.button34.Text = "Update HTClient";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.BackColor = System.Drawing.Color.Black;
            this.tabPage12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage12.Controls.Add(this.label72);
            this.tabPage12.Controls.Add(this.label73);
            this.tabPage12.Controls.Add(this.label74);
            this.tabPage12.Controls.Add(this.label75);
            this.tabPage12.Controls.Add(this.label76);
            this.tabPage12.Controls.Add(this.label77);
            this.tabPage12.Controls.Add(this.label78);
            this.tabPage12.Controls.Add(this.label79);
            this.tabPage12.Controls.Add(this.label80);
            this.tabPage12.Controls.Add(this.label81);
            this.tabPage12.Controls.Add(this.label83);
            this.tabPage12.Location = new System.Drawing.Point(4, 25);
            this.tabPage12.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage12.Size = new System.Drawing.Size(513, 220);
            this.tabPage12.TabIndex = 5;
            this.tabPage12.Text = "DeadCode";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.BackColor = System.Drawing.SystemColors.InfoText;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label72.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label72.Location = new System.Drawing.Point(673, 46);
            this.label72.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(329, 29);
            this.label72.TabIndex = 32;
            this.label72.Text = "ChangeLog [ReMake | 1.1]:";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.BackColor = System.Drawing.SystemColors.InfoText;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label73.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label73.Location = new System.Drawing.Point(673, 270);
            this.label73.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(178, 25);
            this.label73.TabIndex = 31;
            this.label73.Text = "[ / ] Fixed clownfish";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.BackColor = System.Drawing.SystemColors.InfoText;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label74.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label74.Location = new System.Drawing.Point(673, 439);
            this.label74.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(235, 25);
            this.label74.TabIndex = 30;
            this.label74.Text = "[+] Added Rainbow labels";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.BackColor = System.Drawing.SystemColors.InfoText;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label75.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label75.Location = new System.Drawing.Point(673, 415);
            this.label75.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(310, 25);
            this.label75.TabIndex = 29;
            this.label75.Text = "[ / ] Removed Notifs to nerf file size";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.BackColor = System.Drawing.SystemColors.InfoText;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label76.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label76.Location = new System.Drawing.Point(673, 390);
            this.label76.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(198, 25);
            this.label76.TabIndex = 28;
            this.label76.Text = "[+] Updated Bully-Bot";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.BackColor = System.Drawing.SystemColors.InfoText;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label77.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label77.Location = new System.Drawing.Point(673, 366);
            this.label77.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(226, 25);
            this.label77.TabIndex = 27;
            this.label77.Text = "[+] Added Always on top";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.BackColor = System.Drawing.SystemColors.InfoText;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label78.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label78.Location = new System.Drawing.Point(673, 341);
            this.label78.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(247, 25);
            this.label78.TabIndex = 26;
            this.label78.Text = "[+] Added Promotion Mode";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.BackColor = System.Drawing.SystemColors.InfoText;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label79.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label79.Location = new System.Drawing.Point(673, 316);
            this.label79.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(192, 25);
            this.label79.TabIndex = 25;
            this.label79.Text = "[+] Added White-List";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.BackColor = System.Drawing.SystemColors.InfoText;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label80.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label80.Location = new System.Drawing.Point(673, 292);
            this.label80.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(198, 25);
            this.label80.TabIndex = 24;
            this.label80.Text = "[+] Updated Bully-Bot";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.BackColor = System.Drawing.SystemColors.InfoText;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label81.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label81.Location = new System.Drawing.Point(673, 240);
            this.label81.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(329, 29);
            this.label81.TabIndex = 23;
            this.label81.Text = "ChangeLog [ReMake | 1.0]:";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.BackColor = System.Drawing.SystemColors.InfoText;
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label83.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label83.Location = new System.Drawing.Point(193, 213);
            this.label83.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(145, 29);
            this.label83.TabIndex = 21;
            this.label83.Text = "and You <3";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.Black;
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(513, 220);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Custom";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(763, 53);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 22);
            this.textBox2.TabIndex = 47;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(759, 30);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(79, 20);
            this.label35.TabIndex = 48;
            this.label35.Text = "Prefix (!):";
            // 
            // wver
            // 
            this.wver.AutoSize = true;
            this.wver.BackColor = System.Drawing.SystemColors.ControlText;
            this.wver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wver.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.wver.Location = new System.Drawing.Point(1004, 370);
            this.wver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wver.Name = "wver";
            this.wver.Size = new System.Drawing.Size(42, 25);
            this.wver.TabIndex = 46;
            this.wver.Text = "zxc";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.ControlText;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label27.Location = new System.Drawing.Point(757, 370);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(139, 25);
            this.label27.TabIndex = 45;
            this.label27.Text = "Latest version:";
            // 
            // uver
            // 
            this.uver.AutoSize = true;
            this.uver.BackColor = System.Drawing.SystemColors.ControlText;
            this.uver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uver.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.uver.Location = new System.Drawing.Point(1004, 326);
            this.uver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uver.Name = "uver";
            this.uver.Size = new System.Drawing.Size(42, 25);
            this.uver.TabIndex = 44;
            this.uver.Text = "zxc";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.ControlText;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label25.Location = new System.Drawing.Point(757, 326);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(127, 25);
            this.label25.TabIndex = 43;
            this.label25.Text = "Your version:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(763, 464);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(284, 28);
            this.progressBar1.TabIndex = 42;
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(763, 420);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(192, 37);
            this.button14.TabIndex = 41;
            this.button14.Text = "Update HTClient";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "black-white",
            "black-green",
            "black-yellow",
            "black-blue"});
            this.comboBox3.Location = new System.Drawing.Point(21, 62);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(184, 24);
            this.comboBox3.TabIndex = 40;
            this.comboBox3.Text = "black-blue";
            // 
            // button13
            // 
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(21, 98);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(185, 37);
            this.button13.TabIndex = 8;
            this.button13.Text = "Background-Image";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(215, 54);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 37);
            this.button6.TabIndex = 7;
            this.button6.Text = "Select";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(107, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "black-blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Theme:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.InfoText;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.button20);
            this.tabPage4.Controls.Add(this.button19);
            this.tabPage4.Controls.Add(this.logs);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.debugmentions);
            this.tabPage4.Controls.Add(this.debugchat);
            this.tabPage4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1071, 529);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Console";
            // 
            // button20
            // 
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button20.Location = new System.Drawing.Point(840, 487);
            this.button20.Margin = new System.Windows.Forms.Padding(4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(101, 28);
            this.button20.TabIndex = 23;
            this.button20.Text = "Load";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button19.Location = new System.Drawing.Point(840, 452);
            this.button19.Margin = new System.Windows.Forms.Padding(4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(101, 28);
            this.button19.TabIndex = 22;
            this.button19.Text = "Dump";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // logs
            // 
            this.logs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs.ForeColor = System.Drawing.Color.DodgerBlue;
            this.logs.Location = new System.Drawing.Point(25, 22);
            this.logs.Margin = new System.Windows.Forms.Padding(4);
            this.logs.Multiline = true;
            this.logs.Name = "logs";
            this.logs.ReadOnly = true;
            this.logs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logs.Size = new System.Drawing.Size(995, 422);
            this.logs.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(961, 452);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 28);
            this.button3.TabIndex = 14;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // debugmentions
            // 
            this.debugmentions.AutoSize = true;
            this.debugmentions.BackColor = System.Drawing.SystemColors.InfoText;
            this.debugmentions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debugmentions.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.debugmentions.Location = new System.Drawing.Point(93, 452);
            this.debugmentions.Margin = new System.Windows.Forms.Padding(4);
            this.debugmentions.Name = "debugmentions";
            this.debugmentions.Size = new System.Drawing.Size(79, 20);
            this.debugmentions.TabIndex = 21;
            this.debugmentions.Text = "Mentions";
            this.debugmentions.UseVisualStyleBackColor = false;
            // 
            // debugchat
            // 
            this.debugchat.AutoSize = true;
            this.debugchat.BackColor = System.Drawing.SystemColors.InfoText;
            this.debugchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debugchat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.debugchat.Location = new System.Drawing.Point(25, 452);
            this.debugchat.Margin = new System.Windows.Forms.Padding(4);
            this.debugchat.Name = "debugchat";
            this.debugchat.Size = new System.Drawing.Size(52, 20);
            this.debugchat.TabIndex = 12;
            this.debugchat.Text = "Chat";
            this.debugchat.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.InfoText;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.label38);
            this.tabPage3.Controls.Add(this.label36);
            this.tabPage3.Controls.Add(this.label37);
            this.tabPage3.Controls.Add(this.the_id_to_dump);
            this.tabPage3.Controls.Add(this.the_sid_to_dump);
            this.tabPage3.Controls.Add(this.button17);
            this.tabPage3.Controls.Add(this.button18);
            this.tabPage3.Controls.Add(this.button12);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.activity_text);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.nicker_text);
            this.tabPage3.Controls.Add(this.nicker_guild);
            this.tabPage3.Controls.Add(this.nicker_limit);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.checkBox4);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.checkBox2);
            this.tabPage3.Controls.Add(this.bot_messages);
            this.tabPage3.Controls.Add(this.bot_channel);
            this.tabPage3.Controls.Add(this.bot_limit);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1071, 529);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Exploits";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.SystemColors.InfoText;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label38.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label38.Location = new System.Drawing.Point(424, 270);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(221, 29);
            this.label38.TabIndex = 53;
            this.label38.Text = "Members Dumper";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(425, 364);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(65, 24);
            this.label36.TabIndex = 52;
            this.label36.Text = "Chan:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(425, 336);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(65, 24);
            this.label37.TabIndex = 51;
            this.label37.Text = "Guild:";
            // 
            // the_id_to_dump
            // 
            this.the_id_to_dump.BackColor = System.Drawing.SystemColors.InfoText;
            this.the_id_to_dump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.the_id_to_dump.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.the_id_to_dump.FormattingEnabled = true;
            this.the_id_to_dump.Location = new System.Drawing.Point(499, 332);
            this.the_id_to_dump.Margin = new System.Windows.Forms.Padding(4);
            this.the_id_to_dump.Name = "the_id_to_dump";
            this.the_id_to_dump.Size = new System.Drawing.Size(195, 24);
            this.the_id_to_dump.TabIndex = 49;
            this.the_id_to_dump.SelectedIndexChanged += new System.EventHandler(this.the_id_to_dump_SelectedIndexChanged_1);
            // 
            // the_sid_to_dump
            // 
            this.the_sid_to_dump.BackColor = System.Drawing.SystemColors.InfoText;
            this.the_sid_to_dump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.the_sid_to_dump.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.the_sid_to_dump.FormattingEnabled = true;
            this.the_sid_to_dump.Location = new System.Drawing.Point(499, 366);
            this.the_sid_to_dump.Margin = new System.Windows.Forms.Padding(4);
            this.the_sid_to_dump.Name = "the_sid_to_dump";
            this.the_sid_to_dump.Size = new System.Drawing.Size(195, 24);
            this.the_sid_to_dump.TabIndex = 50;
            // 
            // button17
            // 
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(579, 415);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(116, 38);
            this.button17.TabIndex = 48;
            this.button17.Text = "Clear";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(429, 415);
            this.button18.Margin = new System.Windows.Forms.Padding(4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(116, 38);
            this.button18.TabIndex = 47;
            this.button18.Text = "Dump";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button12.Location = new System.Drawing.Point(917, 369);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(129, 28);
            this.button12.TabIndex = 46;
            this.button12.Text = "Update";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.InfoText;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label18.Location = new System.Drawing.Point(888, 270);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 29);
            this.label18.TabIndex = 45;
            this.label18.Text = "HypeSquad";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "bravery",
            "brilliance",
            "balance"});
            this.comboBox2.Location = new System.Drawing.Point(841, 332);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(204, 24);
            this.comboBox2.TabIndex = 44;
            this.comboBox2.Text = "squad";
            // 
            // activity_text
            // 
            this.activity_text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.activity_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activity_text.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.activity_text.Location = new System.Drawing.Point(841, 126);
            this.activity_text.Margin = new System.Windows.Forms.Padding(4);
            this.activity_text.Name = "activity_text";
            this.activity_text.Size = new System.Drawing.Size(205, 22);
            this.activity_text.TabIndex = 43;
            this.activity_text.Text = "text";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button10.Location = new System.Drawing.Point(917, 158);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(129, 28);
            this.button10.TabIndex = 41;
            this.button10.Text = "Update";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.InfoText;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label17.Location = new System.Drawing.Point(783, 31);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(262, 29);
            this.label17.TabIndex = 40;
            this.label17.Text = "ACTIVITY-CHANGER";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "streaming",
            "playing",
            "watching",
            "listening",
            "default"});
            this.comboBox1.Location = new System.Drawing.Point(841, 89);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 24);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.Text = "Activity";
            // 
            // nicker_text
            // 
            this.nicker_text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nicker_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nicker_text.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nicker_text.Location = new System.Drawing.Point(103, 401);
            this.nicker_text.Margin = new System.Windows.Forms.Padding(4);
            this.nicker_text.Name = "nicker_text";
            this.nicker_text.Size = new System.Drawing.Size(205, 22);
            this.nicker_text.TabIndex = 38;
            // 
            // nicker_guild
            // 
            this.nicker_guild.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nicker_guild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nicker_guild.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nicker_guild.Location = new System.Drawing.Point(103, 334);
            this.nicker_guild.Margin = new System.Windows.Forms.Padding(4);
            this.nicker_guild.Name = "nicker_guild";
            this.nicker_guild.Size = new System.Drawing.Size(205, 22);
            this.nicker_guild.TabIndex = 32;
            // 
            // nicker_limit
            // 
            this.nicker_limit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nicker_limit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nicker_limit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nicker_limit.Location = new System.Drawing.Point(103, 366);
            this.nicker_limit.Margin = new System.Windows.Forms.Padding(4);
            this.nicker_limit.Name = "nicker_limit";
            this.nicker_limit.Size = new System.Drawing.Size(205, 22);
            this.nicker_limit.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.InfoText;
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(28, 401);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "Text:";
            // 
            // checkBox4
            // 
            this.checkBox4.BackColor = System.Drawing.SystemColors.InfoText;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBox4.Location = new System.Drawing.Point(247, 433);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(61, 28);
            this.checkBox4.TabIndex = 36;
            this.checkBox4.Text = "Run";
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button9.Location = new System.Drawing.Point(32, 433);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(111, 28);
            this.button9.TabIndex = 33;
            this.button9.Text = "Update";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.InfoText;
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(28, 342);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "Guild: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.InfoText;
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(28, 369);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 16);
            this.label16.TabIndex = 35;
            this.label16.Text = "Limit:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.InfoText;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(27, 270);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 29);
            this.label13.TabIndex = 30;
            this.label13.Text = "Nick-Changer";
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBox2.Location = new System.Drawing.Point(316, 118);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(117, 28);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "On_Message";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // bot_messages
            // 
            this.bot_messages.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bot_messages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bot_messages.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bot_messages.Location = new System.Drawing.Point(103, 158);
            this.bot_messages.Margin = new System.Windows.Forms.Padding(4);
            this.bot_messages.Name = "bot_messages";
            this.bot_messages.Size = new System.Drawing.Size(205, 22);
            this.bot_messages.TabIndex = 28;
            // 
            // bot_channel
            // 
            this.bot_channel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bot_channel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bot_channel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bot_channel.Location = new System.Drawing.Point(103, 90);
            this.bot_channel.Margin = new System.Windows.Forms.Padding(4);
            this.bot_channel.Name = "bot_channel";
            this.bot_channel.Size = new System.Drawing.Size(205, 22);
            this.bot_channel.TabIndex = 12;
            // 
            // bot_limit
            // 
            this.bot_limit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bot_limit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bot_limit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bot_limit.Location = new System.Drawing.Point(103, 122);
            this.bot_limit.Margin = new System.Windows.Forms.Padding(4);
            this.bot_limit.Name = "bot_limit";
            this.bot_limit.Size = new System.Drawing.Size(205, 22);
            this.bot_limit.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.InfoText;
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(28, 158);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Messages:";
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBox1.Location = new System.Drawing.Point(247, 190);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 28);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Run";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.InfoText;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(27, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 29);
            this.label11.TabIndex = 16;
            this.label11.Text = "XP-BOT";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button7.Location = new System.Drawing.Point(32, 190);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 28);
            this.button7.TabIndex = 13;
            this.button7.Text = "Update";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.InfoText;
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(28, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Channel:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.InfoText;
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(28, 126);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Limit:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InfoText;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.button26);
            this.tabPage1.Controls.Add(this.button25);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.newjoinedusa);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.xdmeme);
            this.tabPage1.Controls.Add(this.button15);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.checkBox5);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.accp);
            this.tabPage1.Controls.Add(this.accd);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1071, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // button26
            // 
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Location = new System.Drawing.Point(851, 369);
            this.button26.Margin = new System.Windows.Forms.Padding(4);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(184, 53);
            this.button26.TabIndex = 47;
            this.button26.Text = "Stop-Recording";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Location = new System.Drawing.Point(851, 311);
            this.button25.Margin = new System.Windows.Forms.Padding(4);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(184, 50);
            this.button25.TabIndex = 46;
            this.button25.Text = "Record-Audio";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InfoText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(425, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 29);
            this.label5.TabIndex = 45;
            this.label5.Text = "Cracked by Jaba";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // newjoinedusa
            // 
            this.newjoinedusa.AutoSize = true;
            this.newjoinedusa.BackColor = System.Drawing.SystemColors.ControlText;
            this.newjoinedusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newjoinedusa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.newjoinedusa.Location = new System.Drawing.Point(25, 212);
            this.newjoinedusa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newjoinedusa.Name = "newjoinedusa";
            this.newjoinedusa.Size = new System.Drawing.Size(207, 31);
            this.newjoinedusa.TabIndex = 44;
            this.newjoinedusa.Text = "You joined us: ";
            // 
            // checkBox3
            // 
            this.checkBox3.BackColor = System.Drawing.SystemColors.InfoText;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBox3.Location = new System.Drawing.Point(851, 108);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(199, 28);
            this.checkBox3.TabIndex = 43;
            this.checkBox3.Text = "Rainbow Text";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // xdmeme
            // 
            this.xdmeme.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xdmeme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xdmeme.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.xdmeme.Location = new System.Drawing.Point(44, 398);
            this.xdmeme.Margin = new System.Windows.Forms.Padding(4);
            this.xdmeme.Name = "xdmeme";
            this.xdmeme.Size = new System.Drawing.Size(247, 22);
            this.xdmeme.TabIndex = 42;
            this.xdmeme.TextChanged += new System.EventHandler(this.xdmeme_TextChanged);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.Desktop;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(44, 430);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(67, 28);
            this.button15.TabIndex = 41;
            this.button15.Text = "View";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(39, 369);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(109, 25);
            this.label26.TabIndex = 40;
            this.label26.Text = "WhiteList:";
            // 
            // checkBox5
            // 
            this.checkBox5.BackColor = System.Drawing.SystemColors.InfoText;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBox5.Location = new System.Drawing.Point(851, 73);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(199, 28);
            this.checkBox5.TabIndex = 31;
            this.checkBox5.Text = "Always on top";
            this.checkBox5.UseVisualStyleBackColor = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button8.Location = new System.Drawing.Point(851, 431);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(184, 65);
            this.button8.TabIndex = 27;
            this.button8.Text = "Logout";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // accp
            // 
            this.accp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.accp.Location = new System.Drawing.Point(31, 73);
            this.accp.Margin = new System.Windows.Forms.Padding(4);
            this.accp.Name = "accp";
            this.accp.Size = new System.Drawing.Size(127, 111);
            this.accp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.accp.TabIndex = 11;
            this.accp.TabStop = false;
            // 
            // accd
            // 
            this.accd.AutoSize = true;
            this.accd.BackColor = System.Drawing.SystemColors.ControlText;
            this.accd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.accd.Location = new System.Drawing.Point(181, 73);
            this.accd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accd.Name = "accd";
            this.accd.Size = new System.Drawing.Size(88, 31);
            this.accd.TabIndex = 4;
            this.accd.Text = "NULL";
            this.accd.Click += new System.EventHandler(this.accd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(-5, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1079, 558);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.InfoText;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.bully_target_msg);
            this.tabPage2.Controls.Add(this.bully_target_user);
            this.tabPage2.Controls.Add(this.bully_target_title_message);
            this.tabPage2.Controls.Add(this.bully_target_title_name);
            this.tabPage2.Controls.Add(this.bully_target_pfp);
            this.tabPage2.Controls.Add(this.bully_target_title);
            this.tabPage2.Controls.Add(this.button22);
            this.tabPage2.Controls.Add(this.checkBox6);
            this.tabPage2.Controls.Add(this.button21);
            this.tabPage2.Controls.Add(this.ispingg);
            this.tabPage2.Controls.Add(this.isHruk);
            this.tabPage2.Controls.Add(this.isbuillerchannel);
            this.tabPage2.Controls.Add(this.promotion);
            this.tabPage2.Controls.Add(this.hohol);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button16);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.cfish);
            this.tabPage2.Controls.Add(this.tobully);
            this.tabPage2.Controls.Add(this.clownc);
            this.tabPage2.Controls.Add(this.clown_id);
            this.tabPage2.Controls.Add(this.dwaksakfo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lims);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1071, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Targets";
            // 
            // bully_target_msg
            // 
            this.bully_target_msg.AutoSize = true;
            this.bully_target_msg.BackColor = System.Drawing.SystemColors.InfoText;
            this.bully_target_msg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bully_target_msg.Location = new System.Drawing.Point(508, 170);
            this.bully_target_msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bully_target_msg.Name = "bully_target_msg";
            this.bully_target_msg.Size = new System.Drawing.Size(67, 16);
            this.bully_target_msg.TabIndex = 38;
            this.bully_target_msg.Text = "Message:";
            // 
            // bully_target_user
            // 
            this.bully_target_user.AutoSize = true;
            this.bully_target_user.BackColor = System.Drawing.SystemColors.InfoText;
            this.bully_target_user.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bully_target_user.Location = new System.Drawing.Point(480, 148);
            this.bully_target_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bully_target_user.Name = "bully_target_user";
            this.bully_target_user.Size = new System.Drawing.Size(39, 16);
            this.bully_target_user.TabIndex = 37;
            this.bully_target_user.Text = "User:";
            // 
            // bully_target_title_message
            // 
            this.bully_target_title_message.AutoSize = true;
            this.bully_target_title_message.BackColor = System.Drawing.SystemColors.InfoText;
            this.bully_target_title_message.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bully_target_title_message.Location = new System.Drawing.Point(440, 170);
            this.bully_target_title_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bully_target_title_message.Name = "bully_target_title_message";
            this.bully_target_title_message.Size = new System.Drawing.Size(67, 16);
            this.bully_target_title_message.TabIndex = 36;
            this.bully_target_title_message.Text = "Message:";
            // 
            // bully_target_title_name
            // 
            this.bully_target_title_name.AutoSize = true;
            this.bully_target_title_name.BackColor = System.Drawing.SystemColors.InfoText;
            this.bully_target_title_name.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bully_target_title_name.Location = new System.Drawing.Point(440, 146);
            this.bully_target_title_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bully_target_title_name.Name = "bully_target_title_name";
            this.bully_target_title_name.Size = new System.Drawing.Size(39, 16);
            this.bully_target_title_name.TabIndex = 35;
            this.bully_target_title_name.Text = "User:";
            // 
            // bully_target_pfp
            // 
            this.bully_target_pfp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bully_target_pfp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bully_target_pfp.Cursor = System.Windows.Forms.Cursors.Default;
            this.bully_target_pfp.Location = new System.Drawing.Point(329, 144);
            this.bully_target_pfp.Margin = new System.Windows.Forms.Padding(4);
            this.bully_target_pfp.Name = "bully_target_pfp";
            this.bully_target_pfp.Size = new System.Drawing.Size(103, 92);
            this.bully_target_pfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bully_target_pfp.TabIndex = 34;
            this.bully_target_pfp.TabStop = false;
            // 
            // bully_target_title
            // 
            this.bully_target_title.AutoSize = true;
            this.bully_target_title.BackColor = System.Drawing.SystemColors.InfoText;
            this.bully_target_title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bully_target_title.Location = new System.Drawing.Point(325, 124);
            this.bully_target_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bully_target_title.Name = "bully_target_title";
            this.bully_target_title.Size = new System.Drawing.Size(68, 16);
            this.bully_target_title.TabIndex = 33;
            this.bully_target_title.Text = "Targeting:";
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button22.Location = new System.Drawing.Point(29, 244);
            this.button22.Margin = new System.Windows.Forms.Padding(4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(72, 28);
            this.button22.TabIndex = 32;
            this.button22.Text = "CLEAR";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.BackColor = System.Drawing.SystemColors.InfoText;
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBox6.Location = new System.Drawing.Point(204, 251);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(92, 20);
            this.checkBox6.TabIndex = 31;
            this.checkBox6.Text = "MultiTarget";
            this.checkBox6.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button21.Location = new System.Drawing.Point(117, 244);
            this.button21.Margin = new System.Windows.Forms.Padding(4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(72, 28);
            this.button21.TabIndex = 30;
            this.button21.Text = "VIEW";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // ispingg
            // 
            this.ispingg.AutoSize = true;
            this.ispingg.BackColor = System.Drawing.SystemColors.InfoText;
            this.ispingg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ispingg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ispingg.Location = new System.Drawing.Point(137, 215);
            this.ispingg.Margin = new System.Windows.Forms.Padding(4);
            this.ispingg.Name = "ispingg";
            this.ispingg.Size = new System.Drawing.Size(52, 20);
            this.ispingg.TabIndex = 29;
            this.ispingg.Text = "Ping";
            this.ispingg.UseVisualStyleBackColor = false;
            // 
            // isHruk
            // 
            this.isHruk.AutoSize = true;
            this.isHruk.BackColor = System.Drawing.SystemColors.InfoText;
            this.isHruk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isHruk.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.isHruk.Location = new System.Drawing.Point(961, 229);
            this.isHruk.Margin = new System.Windows.Forms.Padding(4);
            this.isHruk.Name = "isHruk";
            this.isHruk.Size = new System.Drawing.Size(61, 20);
            this.isHruk.TabIndex = 28;
            this.isHruk.Text = "Hohol";
            this.isHruk.UseVisualStyleBackColor = false;
            this.isHruk.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // isbuillerchannel
            // 
            this.isbuillerchannel.AutoSize = true;
            this.isbuillerchannel.BackColor = System.Drawing.SystemColors.InfoText;
            this.isbuillerchannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isbuillerchannel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.isbuillerchannel.Location = new System.Drawing.Point(213, 215);
            this.isbuillerchannel.Margin = new System.Windows.Forms.Padding(4);
            this.isbuillerchannel.Name = "isbuillerchannel";
            this.isbuillerchannel.Size = new System.Drawing.Size(84, 20);
            this.isbuillerchannel.TabIndex = 27;
            this.isbuillerchannel.Text = "isChannel";
            this.isbuillerchannel.UseVisualStyleBackColor = false;
            // 
            // promotion
            // 
            this.promotion.AutoSize = true;
            this.promotion.BackColor = System.Drawing.SystemColors.InfoText;
            this.promotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.promotion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.promotion.Location = new System.Drawing.Point(16, 489);
            this.promotion.Margin = new System.Windows.Forms.Padding(4);
            this.promotion.Name = "promotion";
            this.promotion.Size = new System.Drawing.Size(93, 20);
            this.promotion.TabIndex = 26;
            this.promotion.Text = "PROMOTE";
            this.promotion.UseVisualStyleBackColor = false;
            // 
            // hohol
            // 
            this.hohol.AutoSize = true;
            this.hohol.BackColor = System.Drawing.SystemColors.InfoText;
            this.hohol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hohol.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hohol.Location = new System.Drawing.Point(137, 79);
            this.hohol.Margin = new System.Windows.Forms.Padding(4);
            this.hohol.Name = "hohol";
            this.hohol.Size = new System.Drawing.Size(61, 20);
            this.hohol.TabIndex = 25;
            this.hohol.Text = "Hohol";
            this.hohol.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clowner:";
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button16.Location = new System.Drawing.Point(769, 222);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 28);
            this.button16.TabIndex = 24;
            this.button16.Text = "Update";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button5_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Location = new System.Drawing.Point(768, 222);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 24;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(29, 208);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(769, 190);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 22);
            this.textBox1.TabIndex = 23;
            // 
            // cfish
            // 
            this.cfish.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cfish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cfish.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cfish.Location = new System.Drawing.Point(768, 190);
            this.cfish.Margin = new System.Windows.Forms.Padding(4);
            this.cfish.Name = "cfish";
            this.cfish.Size = new System.Drawing.Size(259, 22);
            this.cfish.TabIndex = 23;
            // 
            // tobully
            // 
            this.tobully.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tobully.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tobully.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tobully.Location = new System.Drawing.Point(29, 144);
            this.tobully.Margin = new System.Windows.Forms.Padding(4);
            this.tobully.Name = "tobully";
            this.tobully.Size = new System.Drawing.Size(259, 22);
            this.tobully.TabIndex = 6;
            this.tobully.TextChanged += new System.EventHandler(this.tobully_TextChanged);
            // 
            // clownc
            // 
            this.clownc.AutoSize = true;
            this.clownc.BackColor = System.Drawing.SystemColors.InfoText;
            this.clownc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clownc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clownc.Location = new System.Drawing.Point(213, 79);
            this.clownc.Margin = new System.Windows.Forms.Padding(4);
            this.clownc.Name = "clownc";
            this.clownc.Size = new System.Drawing.Size(84, 20);
            this.clownc.TabIndex = 13;
            this.clownc.Text = "isChannel";
            this.clownc.UseVisualStyleBackColor = false;
            // 
            // clown_id
            // 
            this.clown_id.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clown_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clown_id.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clown_id.Location = new System.Drawing.Point(29, 39);
            this.clown_id.Margin = new System.Windows.Forms.Padding(4);
            this.clown_id.Name = "clown_id";
            this.clown_id.Size = new System.Drawing.Size(259, 22);
            this.clown_id.TabIndex = 1;
            // 
            // dwaksakfo
            // 
            this.dwaksakfo.AutoSize = true;
            this.dwaksakfo.BackColor = System.Drawing.SystemColors.InfoText;
            this.dwaksakfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dwaksakfo.Location = new System.Drawing.Point(765, 170);
            this.dwaksakfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dwaksakfo.Name = "dwaksakfo";
            this.dwaksakfo.Size = new System.Drawing.Size(66, 16);
            this.dwaksakfo.TabIndex = 22;
            this.dwaksakfo.Text = "Clownfish:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InfoText;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(25, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bullier:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(29, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InfoText;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(25, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Limit:";
            // 
            // lims
            // 
            this.lims.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lims.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lims.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lims.Location = new System.Drawing.Point(84, 176);
            this.lims.Margin = new System.Windows.Forms.Padding(4);
            this.lims.Name = "lims";
            this.lims.Size = new System.Drawing.Size(205, 22);
            this.lims.TabIndex = 9;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Black;
            this.tabPage6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage6.Controls.Add(this.label39);
            this.tabPage6.Controls.Add(this.label34);
            this.tabPage6.Controls.Add(this.label33);
            this.tabPage6.Controls.Add(this.label32);
            this.tabPage6.Controls.Add(this.label31);
            this.tabPage6.Controls.Add(this.label30);
            this.tabPage6.Controls.Add(this.label28);
            this.tabPage6.Controls.Add(this.label21);
            this.tabPage6.Controls.Add(this.label54);
            this.tabPage6.Controls.Add(this.label53);
            this.tabPage6.Controls.Add(this.label52);
            this.tabPage6.Controls.Add(this.label51);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Controls.Add(this.label50);
            this.tabPage6.Controls.Add(this.label49);
            this.tabPage6.Controls.Add(this.label48);
            this.tabPage6.Controls.Add(this.label47);
            this.tabPage6.Controls.Add(this.label46);
            this.tabPage6.Controls.Add(this.label41);
            this.tabPage6.Controls.Add(this.label29);
            this.tabPage6.Controls.Add(this.label20);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage6.Size = new System.Drawing.Size(1071, 529);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Credits";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.SystemColors.InfoText;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label39.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label39.Location = new System.Drawing.Point(673, 475);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(252, 25);
            this.label39.TabIndex = 51;
            this.label39.Text = "[-] Removed voice assistant";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.SystemColors.InfoText;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label34.Location = new System.Drawing.Point(673, 450);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(276, 25);
            this.label34.TabIndex = 50;
            this.label34.Text = "[+] Added delete-cache button";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.SystemColors.InfoText;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label33.Location = new System.Drawing.Point(673, 426);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(197, 25);
            this.label33.TabIndex = 49;
            this.label33.Text = "[+] Added auto-setup";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.SystemColors.InfoText;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label32.Location = new System.Drawing.Point(673, 352);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(258, 25);
            this.label32.TabIndex = 48;
            this.label32.Text = "[+] Added auto-save for girls";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.SystemColors.InfoText;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label31.Location = new System.Drawing.Point(673, 401);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(238, 25);
            this.label31.TabIndex = 47;
            this.label31.Text = "[ / ] Improved Error-Debug";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.SystemColors.InfoText;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label30.Location = new System.Drawing.Point(673, 377);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(218, 25);
            this.label30.TabIndex = 46;
            this.label30.Text = "[ / ] Improved Protection";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.InfoText;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label28.Location = new System.Drawing.Point(673, 327);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(284, 25);
            this.label28.TabIndex = 45;
            this.label28.Text = "[+] Added Bullier -> MultiTarget";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.InfoText;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label21.Location = new System.Drawing.Point(673, 303);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(280, 25);
            this.label21.TabIndex = 44;
            this.label21.Text = "[+] Added Bullier -> Target Info";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.SystemColors.InfoText;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label54.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label54.Location = new System.Drawing.Point(673, 254);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(233, 25);
            this.label54.TabIndex = 43;
            this.label54.Text = "[-] Removed custom RPC";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.SystemColors.InfoText;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label53.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label53.Location = new System.Drawing.Point(673, 229);
            this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(305, 25);
            this.label53.TabIndex = 42;
            this.label53.Text = "[+] Credits -> Added YOUR name";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.SystemColors.InfoText;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label52.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label52.Location = new System.Drawing.Point(255, 170);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(0, 29);
            this.label52.TabIndex = 41;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.SystemColors.InfoText;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label51.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label51.Location = new System.Drawing.Point(673, 204);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(261, 25);
            this.label51.TabIndex = 40;
            this.label51.Text = "[+] Console -> Dump + Load";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InfoText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(673, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "[+] Voice messages";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InfoText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(673, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "[+] !sw, !dick, !copyserver";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.SystemColors.InfoText;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label50.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label50.Location = new System.Drawing.Point(673, 130);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(182, 25);
            this.label50.TabIndex = 37;
            this.label50.Text = "[+] Settings -> RPC";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.SystemColors.InfoText;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label49.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label49.Location = new System.Drawing.Point(673, 107);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(223, 25);
            this.label49.TabIndex = 36;
            this.label49.Text = "[ / ] Improved Main page";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.SystemColors.InfoText;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label48.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label48.Location = new System.Drawing.Point(673, 82);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(206, 25);
            this.label48.TabIndex = 35;
            this.label48.Text = "[+] Added !copyserver";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.SystemColors.InfoText;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label47.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label47.Location = new System.Drawing.Point(673, 58);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(161, 25);
            this.label47.TabIndex = 34;
            this.label47.Text = "[+] Updated RPC";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.SystemColors.InfoText;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label46.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label46.Location = new System.Drawing.Point(673, 33);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(166, 25);
            this.label46.TabIndex = 33;
            this.label46.Text = "[ / ] Fixed whitelist";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.SystemColors.InfoText;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label41.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label41.Location = new System.Drawing.Point(673, 4);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(329, 29);
            this.label41.TabIndex = 32;
            this.label41.Text = "ChangeLog [ReMake | 1.1]:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.SystemColors.InfoText;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label29.Location = new System.Drawing.Point(673, 278);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(139, 25);
            this.label29.TabIndex = 24;
            this.label29.Text = "[+] Added girls";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.InfoText;
            this.label20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label20.Location = new System.Drawing.Point(191, 46);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 29);
            this.label20.TabIndex = 18;
            this.label20.Text = "Jaba";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.InfoText;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label19.Location = new System.Drawing.Point(16, 46);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 29);
            this.label19.TabIndex = 17;
            this.label19.Text = "Thanks to:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(1081, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 532);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1457, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "HTClient V2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.tabPage12.ResumeLayout(false);
            this.tabPage12.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accp)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bully_target_pfp)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

	}

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void accd_Click(object sender, EventArgs e)
    {

    }
}
