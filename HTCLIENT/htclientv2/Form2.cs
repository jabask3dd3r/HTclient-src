using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace htclientv2;

public class Form2 : Form
{
	private string[] a = new string[10] { "https://media.discordapp.net/attachments/973928224839073812/982171451857702912/girl3.png?width=374&height=676", "https://media.discordapp.net/attachments/973928224839073812/982171452302315560/girl6.png?width=499&height=676", "https://media.discordapp.net/attachments/973928224839073812/982171452595929108/girl7.png?width=478&height=676", "https://media.discordapp.net/attachments/973928224839073812/982171452939845642/girl16.png?width=498&height=677", "https://media.discordapp.net/attachments/973928224839073812/982171453749329950/girl17.png?width=402&height=676", "https://media.discordapp.net/attachments/973928224839073812/982171454030352404/girl19.png?width=448&height=676", "https://media.discordapp.net/attachments/973928224839073812/982171454315593758/girl20.png?width=470&height=677", "https://media.discordapp.net/attachments/973928224839073812/982171454630141994/girl1.png?width=534&height=676", "https://media.discordapp.net/attachments/973928224839073812/982171550981701642/girl21.jpg?width=476&height=676", "https://media.discordapp.net/attachments/973928224839073812/982171551254347797/girl22.jpg?width=478&height=676" };

	private int number = 1;

	private IContainer components = null;

	private Label label1;

	private Label label2;

	public Form2()
	{
		InitializeComponent();
	}

	private void installing(string url)
	{
		using (WebClient webClient = new WebClient())
		{
			webClient.DownloadFile(url, $"\\cache\\girls\\girl{number}.png");
		}
		number++;
		label2.Text = $"Скачиваем: {number}/10";
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		string[] array = a;
		foreach (string url in array)
		{
			installing(url);
		}
		File.WriteAllText("\\cache\\girls\\girl.txt", "1");
		label2.Text = "Вроде все установили, перезапустите хтклиент.";
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
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(76, 23);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(627, 20);
		this.label1.TabIndex = 0;
		this.label1.Text = "Подождите, сейчас мы установим необходимые ресурсы для хтклиента.";
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(74, 284);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(97, 16);
		this.label2.TabIndex = 2;
		this.label2.Text = "Скачиваем: ";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		base.ClientSize = new System.Drawing.Size(800, 450);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		this.ForeColor = System.Drawing.SystemColors.HotTrack;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "Form2";
		this.Text = "SetUp";
		base.Load += new System.EventHandler(Form2_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
