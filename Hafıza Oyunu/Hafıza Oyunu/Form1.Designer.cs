
namespace Hafıza_Oyunu
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
            components = new System.ComponentModel.Container();
            sureSayaci = new System.Windows.Forms.Timer(components);
            lblSure = new Label();
            panelSkor = new Panel();
            btnOyunuKapat = new Button();
            btnYenidenBaslat = new Button();
            btnSkoruKaydet = new Button();
            lstSkorlar = new ListBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button17 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            button30 = new Button();
            button31 = new Button();
            button32 = new Button();
            button33 = new Button();
            button34 = new Button();
            button35 = new Button();
            button36 = new Button();
            button37 = new Button();
            button38 = new Button();
            button39 = new Button();
            button40 = new Button();
            panelSkor.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSure
            // 
            lblSure.AutoSize = true;
            lblSure.BackColor = Color.MistyRose;
            lblSure.Location = new Point(23, 82);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(45, 20);
            lblSure.TabIndex = 1;
            lblSure.Text = "Süre :";
            // 
            // panelSkor
            // 
            panelSkor.Controls.Add(btnOyunuKapat);
            panelSkor.Controls.Add(btnYenidenBaslat);
            panelSkor.Controls.Add(btnSkoruKaydet);
            panelSkor.Controls.Add(lstSkorlar);
            panelSkor.Controls.Add(label1);
            panelSkor.Controls.Add(lblSure);
            panelSkor.Dock = DockStyle.Left;
            panelSkor.Location = new Point(0, 0);
            panelSkor.Name = "panelSkor";
            panelSkor.Size = new Size(190, 647);
            panelSkor.TabIndex = 2;
            // 
            // btnOyunuKapat
            // 
            btnOyunuKapat.BackColor = Color.FromArgb(255, 192, 192);
            btnOyunuKapat.Location = new Point(23, 508);
            btnOyunuKapat.Name = "btnOyunuKapat";
            btnOyunuKapat.Size = new Size(150, 29);
            btnOyunuKapat.TabIndex = 4;
            btnOyunuKapat.Text = "Kapat";
            btnOyunuKapat.UseVisualStyleBackColor = false;
            btnOyunuKapat.Click += btnYenidenBaslat_Click;
            // 
            // btnYenidenBaslat
            // 
            btnYenidenBaslat.BackColor = Color.FromArgb(192, 255, 255);
            btnYenidenBaslat.Location = new Point(23, 461);
            btnYenidenBaslat.Name = "btnYenidenBaslat";
            btnYenidenBaslat.Size = new Size(150, 29);
            btnYenidenBaslat.TabIndex = 4;
            btnYenidenBaslat.Text = "Yeniden Başlat";
            btnYenidenBaslat.UseVisualStyleBackColor = false;
            btnYenidenBaslat.Click += btnYenidenBaslat_Click;
            // 
            // btnSkoruKaydet
            // 
            btnSkoruKaydet.BackColor = Color.FromArgb(255, 255, 192);
            btnSkoruKaydet.Location = new Point(23, 409);
            btnSkoruKaydet.Name = "btnSkoruKaydet";
            btnSkoruKaydet.Size = new Size(150, 29);
            btnSkoruKaydet.TabIndex = 4;
            btnSkoruKaydet.Text = "Skor Kaydet";
            btnSkoruKaydet.UseVisualStyleBackColor = false;
            btnSkoruKaydet.Click += btnSkoruKaydet_Click;
            // 
            // lstSkorlar
            // 
            lstSkorlar.FormattingEnabled = true;
            lstSkorlar.Location = new Point(23, 130);
            lstSkorlar.Name = "lstSkorlar";
            lstSkorlar.Size = new Size(150, 244);
            lstSkorlar.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.FromArgb(255, 192, 255);
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 2;
            label1.Text = "Skor Alanı";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlLightLight;
            tableLayoutPanel1.CausesValidation = false;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.4913788F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0603447F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.8620682F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5862064F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(button5, 0, 1);
            tableLayoutPanel1.Controls.Add(button6, 1, 1);
            tableLayoutPanel1.Controls.Add(button7, 2, 1);
            tableLayoutPanel1.Controls.Add(button8, 3, 1);
            tableLayoutPanel1.Controls.Add(button9, 0, 2);
            tableLayoutPanel1.Controls.Add(button10, 1, 2);
            tableLayoutPanel1.Controls.Add(button11, 2, 2);
            tableLayoutPanel1.Controls.Add(button12, 3, 2);
            tableLayoutPanel1.Controls.Add(button13, 0, 3);
            tableLayoutPanel1.Controls.Add(button14, 1, 3);
            tableLayoutPanel1.Controls.Add(button15, 2, 3);
            tableLayoutPanel1.Controls.Add(button16, 3, 3);
            tableLayoutPanel1.Controls.Add(button18, 1, 4);
            tableLayoutPanel1.Controls.Add(button19, 2, 4);
            tableLayoutPanel1.Controls.Add(button20, 3, 4);
            tableLayoutPanel1.Controls.Add(button17, 0, 4);
            tableLayoutPanel1.Controls.Add(button21, 4, 0);
            tableLayoutPanel1.Controls.Add(button22, 5, 0);
            tableLayoutPanel1.Controls.Add(button23, 6, 0);
            tableLayoutPanel1.Controls.Add(button24, 7, 0);
            tableLayoutPanel1.Controls.Add(button25, 4, 1);
            tableLayoutPanel1.Controls.Add(button26, 4, 2);
            tableLayoutPanel1.Controls.Add(button27, 4, 3);
            tableLayoutPanel1.Controls.Add(button28, 4, 4);
            tableLayoutPanel1.Controls.Add(button29, 5, 4);
            tableLayoutPanel1.Controls.Add(button30, 5, 3);
            tableLayoutPanel1.Controls.Add(button31, 5, 2);
            tableLayoutPanel1.Controls.Add(button32, 5, 1);
            tableLayoutPanel1.Controls.Add(button33, 6, 1);
            tableLayoutPanel1.Controls.Add(button34, 6, 2);
            tableLayoutPanel1.Controls.Add(button35, 6, 3);
            tableLayoutPanel1.Controls.Add(button36, 6, 4);
            tableLayoutPanel1.Controls.Add(button37, 7, 4);
            tableLayoutPanel1.Controls.Add(button38, 7, 3);
            tableLayoutPanel1.Controls.Add(button39, 7, 2);
            tableLayoutPanel1.Controls.Add(button40, 7, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(190, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.040247F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.7430344F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(952, 647);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(4, 4);
            button1.Name = "button1";
            button1.Size = new Size(96, 122);
            button1.TabIndex = 0;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += KartTiklandi;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(107, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 122);
            button2.TabIndex = 0;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += KartTiklandi;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(208, 4);
            button3.Name = "button3";
            button3.Size = new Size(107, 122);
            button3.TabIndex = 0;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += KartTiklandi;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(322, 4);
            button4.Name = "button4";
            button4.Size = new Size(114, 122);
            button4.TabIndex = 0;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += KartTiklandi;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(4, 133);
            button5.Name = "button5";
            button5.Size = new Size(96, 116);
            button5.TabIndex = 0;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += KartTiklandi;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(107, 133);
            button6.Name = "button6";
            button6.Size = new Size(94, 116);
            button6.TabIndex = 0;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += KartTiklandi;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(208, 133);
            button7.Name = "button7";
            button7.Size = new Size(107, 116);
            button7.TabIndex = 0;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += KartTiklandi;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(322, 133);
            button8.Name = "button8";
            button8.Size = new Size(114, 116);
            button8.TabIndex = 0;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += KartTiklandi;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(4, 256);
            button9.Name = "button9";
            button9.Size = new Size(96, 127);
            button9.TabIndex = 0;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += KartTiklandi;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(107, 256);
            button10.Name = "button10";
            button10.Size = new Size(94, 127);
            button10.TabIndex = 0;
            button10.Text = "?";
            button10.UseVisualStyleBackColor = true;
            button10.Click += KartTiklandi;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(208, 256);
            button11.Name = "button11";
            button11.Size = new Size(107, 127);
            button11.TabIndex = 0;
            button11.Text = "?";
            button11.UseVisualStyleBackColor = true;
            button11.Click += KartTiklandi;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Fill;
            button12.Location = new Point(322, 256);
            button12.Name = "button12";
            button12.Size = new Size(114, 127);
            button12.TabIndex = 0;
            button12.Text = "?";
            button12.UseVisualStyleBackColor = true;
            button12.Click += KartTiklandi;
            // 
            // button13
            // 
            button13.Dock = DockStyle.Fill;
            button13.Location = new Point(4, 390);
            button13.Name = "button13";
            button13.Size = new Size(96, 122);
            button13.TabIndex = 0;
            button13.Text = "?";
            button13.UseVisualStyleBackColor = true;
            button13.Click += KartTiklandi;
            // 
            // button14
            // 
            button14.Dock = DockStyle.Fill;
            button14.Location = new Point(107, 390);
            button14.Name = "button14";
            button14.Size = new Size(94, 122);
            button14.TabIndex = 0;
            button14.Text = "?";
            button14.UseVisualStyleBackColor = true;
            button14.Click += KartTiklandi;
            // 
            // button15
            // 
            button15.Dock = DockStyle.Fill;
            button15.Location = new Point(208, 390);
            button15.Name = "button15";
            button15.Size = new Size(107, 122);
            button15.TabIndex = 0;
            button15.Text = "?";
            button15.UseVisualStyleBackColor = true;
            button15.Click += KartTiklandi;
            // 
            // button16
            // 
            button16.Dock = DockStyle.Fill;
            button16.Location = new Point(322, 390);
            button16.Name = "button16";
            button16.Size = new Size(114, 122);
            button16.TabIndex = 0;
            button16.Text = "?";
            button16.UseVisualStyleBackColor = true;
            button16.Click += KartTiklandi;
            // 
            // button18
            // 
            button18.Dock = DockStyle.Fill;
            button18.Location = new Point(107, 519);
            button18.Name = "button18";
            button18.Size = new Size(94, 124);
            button18.TabIndex = 0;
            button18.Text = "?";
            button18.UseVisualStyleBackColor = true;
            button18.Click += KartTiklandi;
            // 
            // button19
            // 
            button19.Dock = DockStyle.Fill;
            button19.Location = new Point(208, 519);
            button19.Name = "button19";
            button19.Size = new Size(107, 124);
            button19.TabIndex = 0;
            button19.Text = "?";
            button19.UseVisualStyleBackColor = true;
            button19.Click += KartTiklandi;
            // 
            // button20
            // 
            button20.Dock = DockStyle.Fill;
            button20.Location = new Point(322, 519);
            button20.Name = "button20";
            button20.Size = new Size(114, 124);
            button20.TabIndex = 0;
            button20.Text = "?";
            button20.UseVisualStyleBackColor = true;
            button20.Click += KartTiklandi;
            // 
            // button17
            // 
            button17.Dock = DockStyle.Fill;
            button17.Location = new Point(4, 519);
            button17.Name = "button17";
            button17.Size = new Size(96, 124);
            button17.TabIndex = 0;
            button17.Text = "?";
            button17.UseVisualStyleBackColor = true;
            button17.Click += KartTiklandi;
            // 
            // button21
            // 
            button21.Dock = DockStyle.Fill;
            button21.Location = new Point(443, 4);
            button21.Name = "button21";
            button21.Size = new Size(123, 122);
            button21.TabIndex = 0;
            button21.Text = "?";
            button21.UseVisualStyleBackColor = true;
            button21.Click += KartTiklandi;
            // 
            // button22
            // 
            button22.Dock = DockStyle.Fill;
            button22.Location = new Point(573, 4);
            button22.Name = "button22";
            button22.Size = new Size(122, 122);
            button22.TabIndex = 0;
            button22.Text = "?";
            button22.UseVisualStyleBackColor = true;
            button22.Click += KartTiklandi;
            // 
            // button23
            // 
            button23.Dock = DockStyle.Fill;
            button23.Location = new Point(702, 4);
            button23.Name = "button23";
            button23.Size = new Size(131, 122);
            button23.TabIndex = 0;
            button23.Text = "?";
            button23.UseVisualStyleBackColor = true;
            button23.Click += KartTiklandi;
            // 
            // button24
            // 
            button24.Dock = DockStyle.Fill;
            button24.Location = new Point(840, 4);
            button24.Name = "button24";
            button24.Size = new Size(108, 122);
            button24.TabIndex = 0;
            button24.Text = "?";
            button24.UseVisualStyleBackColor = true;
            button24.Click += KartTiklandi;
            // 
            // button25
            // 
            button25.Dock = DockStyle.Fill;
            button25.Location = new Point(443, 133);
            button25.Name = "button25";
            button25.Size = new Size(123, 116);
            button25.TabIndex = 0;
            button25.Text = "?";
            button25.UseVisualStyleBackColor = true;
            button25.Click += KartTiklandi;
            // 
            // button26
            // 
            button26.Dock = DockStyle.Fill;
            button26.Location = new Point(443, 256);
            button26.Name = "button26";
            button26.Size = new Size(123, 127);
            button26.TabIndex = 0;
            button26.Text = "?";
            button26.UseVisualStyleBackColor = true;
            button26.Click += KartTiklandi;
            // 
            // button27
            // 
            button27.Dock = DockStyle.Fill;
            button27.Location = new Point(443, 390);
            button27.Name = "button27";
            button27.Size = new Size(123, 122);
            button27.TabIndex = 0;
            button27.Text = "?";
            button27.UseVisualStyleBackColor = true;
            button27.Click += KartTiklandi;
            // 
            // button28
            // 
            button28.Dock = DockStyle.Fill;
            button28.Location = new Point(443, 519);
            button28.Name = "button28";
            button28.Size = new Size(123, 124);
            button28.TabIndex = 0;
            button28.Text = "?";
            button28.UseVisualStyleBackColor = true;
            button28.Click += KartTiklandi;
            // 
            // button29
            // 
            button29.Dock = DockStyle.Fill;
            button29.Location = new Point(573, 519);
            button29.Name = "button29";
            button29.Size = new Size(122, 124);
            button29.TabIndex = 0;
            button29.Text = "?";
            button29.UseVisualStyleBackColor = true;
            button29.Click += KartTiklandi;
            // 
            // button30
            // 
            button30.Dock = DockStyle.Fill;
            button30.Location = new Point(573, 390);
            button30.Name = "button30";
            button30.Size = new Size(122, 122);
            button30.TabIndex = 0;
            button30.Text = "?";
            button30.UseVisualStyleBackColor = true;
            button30.Click += KartTiklandi;
            // 
            // button31
            // 
            button31.Dock = DockStyle.Fill;
            button31.Location = new Point(573, 256);
            button31.Name = "button31";
            button31.Size = new Size(122, 127);
            button31.TabIndex = 0;
            button31.Text = "?";
            button31.UseVisualStyleBackColor = true;
            button31.Click += KartTiklandi;
            // 
            // button32
            // 
            button32.Dock = DockStyle.Fill;
            button32.Location = new Point(573, 133);
            button32.Name = "button32";
            button32.Size = new Size(122, 116);
            button32.TabIndex = 0;
            button32.Text = "?";
            button32.UseVisualStyleBackColor = true;
            button32.Click += KartTiklandi;
            // 
            // button33
            // 
            button33.Dock = DockStyle.Fill;
            button33.Location = new Point(702, 133);
            button33.Name = "button33";
            button33.Size = new Size(131, 116);
            button33.TabIndex = 0;
            button33.Text = "?";
            button33.UseVisualStyleBackColor = true;
            button33.Click += KartTiklandi;
            // 
            // button34
            // 
            button34.Dock = DockStyle.Fill;
            button34.Location = new Point(702, 256);
            button34.Name = "button34";
            button34.Size = new Size(131, 127);
            button34.TabIndex = 0;
            button34.Text = "?";
            button34.UseVisualStyleBackColor = true;
            button34.Click += KartTiklandi;
            // 
            // button35
            // 
            button35.Dock = DockStyle.Fill;
            button35.Location = new Point(702, 390);
            button35.Name = "button35";
            button35.Size = new Size(131, 122);
            button35.TabIndex = 0;
            button35.Text = "?";
            button35.UseVisualStyleBackColor = true;
            button35.Click += KartTiklandi;
            // 
            // button36
            // 
            button36.Dock = DockStyle.Fill;
            button36.Location = new Point(702, 519);
            button36.Name = "button36";
            button36.Size = new Size(131, 124);
            button36.TabIndex = 0;
            button36.Text = "?";
            button36.UseVisualStyleBackColor = true;
            button36.Click += KartTiklandi;
            // 
            // button37
            // 
            button37.Dock = DockStyle.Fill;
            button37.Location = new Point(840, 519);
            button37.Name = "button37";
            button37.Size = new Size(108, 124);
            button37.TabIndex = 0;
            button37.Text = "?";
            button37.UseVisualStyleBackColor = true;
            button37.Click += KartTiklandi;
            // 
            // button38
            // 
            button38.Dock = DockStyle.Fill;
            button38.Location = new Point(840, 390);
            button38.Name = "button38";
            button38.Size = new Size(108, 122);
            button38.TabIndex = 0;
            button38.Text = "?";
            button38.UseVisualStyleBackColor = true;
            button38.Click += KartTiklandi;
            // 
            // button39
            // 
            button39.Dock = DockStyle.Fill;
            button39.Location = new Point(840, 256);
            button39.Name = "button39";
            button39.Size = new Size(108, 127);
            button39.TabIndex = 0;
            button39.Text = "?";
            button39.UseVisualStyleBackColor = true;
            button39.Click += KartTiklandi;
            // 
            // button40
            // 
            button40.Dock = DockStyle.Fill;
            button40.Location = new Point(840, 133);
            button40.Name = "button40";
            button40.Size = new Size(108, 116);
            button40.TabIndex = 0;
            button40.Text = "?";
            button40.UseVisualStyleBackColor = true;
            button40.Click += KartTiklandi;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 647);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelSkor);
            Name = "Form1";
            Text = "Form1";
            panelSkor.ResumeLayout(false);
            panelSkor.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer sureSayaci;
        private Label lblSure;
        private Panel panelSkor;
        private Button btnYenidenBaslat;
        private Button btnSkoruKaydet;
        private ListBox lstSkorlar;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button17;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button button30;
        private Button button31;
        private Button button32;
        private Button button33;
        private Button button34;
        private Button button35;
        private Button button36;
        private Button button37;
        private Button button38;
        private Button button39;
        private Button button40;
        private Button btnOyunuKapat;
    }
}
