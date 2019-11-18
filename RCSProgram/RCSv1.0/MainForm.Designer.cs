﻿namespace RCSv1._0
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlRibbon = new System.Windows.Forms.Panel();
            this.lbRibbon = new System.Windows.Forms.Label();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlKineticsInput = new System.Windows.Forms.Panel();
            this.pnlDoseOutput = new System.Windows.Forms.Panel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnDose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnHomeInput = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnKineticsInput = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnModelsInput = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNuclideInput = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHomeInput = new System.Windows.Forms.Panel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlModelsInput = new System.Windows.Forms.Panel();
            this.pnlNuclideInput = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pnlRibbon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlHomeInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlRibbon;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnlRibbon
            // 
            this.pnlRibbon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlRibbon.Controls.Add(this.lbRibbon);
            this.pnlRibbon.Controls.Add(this.btnMinimize);
            this.pnlRibbon.Controls.Add(this.btnClose);
            this.pnlRibbon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRibbon.Location = new System.Drawing.Point(0, 0);
            this.pnlRibbon.Name = "pnlRibbon";
            this.pnlRibbon.Size = new System.Drawing.Size(1009, 38);
            this.pnlRibbon.TabIndex = 0;
            // 
            // lbRibbon
            // 
            this.lbRibbon.AutoSize = true;
            this.lbRibbon.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRibbon.Location = new System.Drawing.Point(12, 7);
            this.lbRibbon.Name = "lbRibbon";
            this.lbRibbon.Size = new System.Drawing.Size(98, 24);
            this.lbRibbon.TabIndex = 2;
            this.lbRibbon.Text = "RCS v1.0";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(948, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 26);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 20;
            this.btnMinimize.Click += new System.EventHandler(this.BunifuImageButton2_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(979, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 20;
            this.btnClose.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // pnlKineticsInput
            // 
            this.pnlKineticsInput.Location = new System.Drawing.Point(245, 38);
            this.pnlKineticsInput.Name = "pnlKineticsInput";
            this.pnlKineticsInput.Size = new System.Drawing.Size(764, 519);
            this.pnlKineticsInput.TabIndex = 0;
            // 
            // pnlDoseOutput
            // 
            this.pnlDoseOutput.Location = new System.Drawing.Point(245, 38);
            this.pnlDoseOutput.Name = "pnlDoseOutput";
            this.pnlDoseOutput.Size = new System.Drawing.Size(764, 519);
            this.pnlDoseOutput.TabIndex = 0;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lbRibbon;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnDose);
            this.bunifuGradientPanel1.Controls.Add(this.btnHomeInput);
            this.bunifuGradientPanel1.Controls.Add(this.btnKineticsInput);
            this.bunifuGradientPanel1.Controls.Add(this.btnModelsInput);
            this.bunifuGradientPanel1.Controls.Add(this.btnNuclideInput);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Yellow;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Yellow;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 38);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(235, 528);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // btnDose
            // 
            this.btnDose.ActiveBorderThickness = 1;
            this.btnDose.ActiveCornerRadius = 20;
            this.btnDose.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDose.ActiveForecolor = System.Drawing.Color.White;
            this.btnDose.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDose.BackColor = System.Drawing.Color.Transparent;
            this.btnDose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDose.BackgroundImage")));
            this.btnDose.ButtonText = "Tính liều";
            this.btnDose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDose.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDose.ForeColor = System.Drawing.Color.Black;
            this.btnDose.IdleBorderThickness = 1;
            this.btnDose.IdleCornerRadius = 20;
            this.btnDose.IdleFillColor = System.Drawing.Color.White;
            this.btnDose.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDose.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDose.Location = new System.Drawing.Point(14, 326);
            this.btnDose.Margin = new System.Windows.Forms.Padding(5);
            this.btnDose.Name = "btnDose";
            this.btnDose.Size = new System.Drawing.Size(206, 70);
            this.btnDose.TabIndex = 9;
            this.btnDose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDose.Click += new System.EventHandler(this.BtnDose_Click);
            // 
            // btnHomeInput
            // 
            this.btnHomeInput.ActiveBorderThickness = 1;
            this.btnHomeInput.ActiveCornerRadius = 20;
            this.btnHomeInput.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnHomeInput.ActiveForecolor = System.Drawing.Color.White;
            this.btnHomeInput.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnHomeInput.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHomeInput.BackgroundImage")));
            this.btnHomeInput.ButtonText = "Trang chủ";
            this.btnHomeInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomeInput.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeInput.ForeColor = System.Drawing.Color.Black;
            this.btnHomeInput.IdleBorderThickness = 1;
            this.btnHomeInput.IdleCornerRadius = 20;
            this.btnHomeInput.IdleFillColor = System.Drawing.Color.White;
            this.btnHomeInput.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnHomeInput.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnHomeInput.Location = new System.Drawing.Point(15, 6);
            this.btnHomeInput.Margin = new System.Windows.Forms.Padding(5);
            this.btnHomeInput.Name = "btnHomeInput";
            this.btnHomeInput.Size = new System.Drawing.Size(206, 70);
            this.btnHomeInput.TabIndex = 8;
            this.btnHomeInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHomeInput.Click += new System.EventHandler(this.BtnHomeInput_Click);
            // 
            // btnKineticsInput
            // 
            this.btnKineticsInput.ActiveBorderThickness = 1;
            this.btnKineticsInput.ActiveCornerRadius = 20;
            this.btnKineticsInput.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnKineticsInput.ActiveForecolor = System.Drawing.Color.White;
            this.btnKineticsInput.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnKineticsInput.BackColor = System.Drawing.Color.Transparent;
            this.btnKineticsInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKineticsInput.BackgroundImage")));
            this.btnKineticsInput.ButtonText = "Nhập thời gian lưu trú";
            this.btnKineticsInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKineticsInput.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKineticsInput.ForeColor = System.Drawing.Color.Black;
            this.btnKineticsInput.IdleBorderThickness = 1;
            this.btnKineticsInput.IdleCornerRadius = 20;
            this.btnKineticsInput.IdleFillColor = System.Drawing.Color.White;
            this.btnKineticsInput.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnKineticsInput.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnKineticsInput.Location = new System.Drawing.Point(14, 246);
            this.btnKineticsInput.Margin = new System.Windows.Forms.Padding(5);
            this.btnKineticsInput.Name = "btnKineticsInput";
            this.btnKineticsInput.Size = new System.Drawing.Size(206, 70);
            this.btnKineticsInput.TabIndex = 7;
            this.btnKineticsInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKineticsInput.Click += new System.EventHandler(this.BtnKineticsInput_Click);
            // 
            // btnModelsInput
            // 
            this.btnModelsInput.ActiveBorderThickness = 1;
            this.btnModelsInput.ActiveCornerRadius = 20;
            this.btnModelsInput.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnModelsInput.ActiveForecolor = System.Drawing.Color.White;
            this.btnModelsInput.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnModelsInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnModelsInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModelsInput.BackgroundImage")));
            this.btnModelsInput.ButtonText = "Chọn mô hình người";
            this.btnModelsInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModelsInput.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModelsInput.ForeColor = System.Drawing.Color.Black;
            this.btnModelsInput.IdleBorderThickness = 1;
            this.btnModelsInput.IdleCornerRadius = 20;
            this.btnModelsInput.IdleFillColor = System.Drawing.Color.White;
            this.btnModelsInput.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnModelsInput.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnModelsInput.Location = new System.Drawing.Point(15, 166);
            this.btnModelsInput.Margin = new System.Windows.Forms.Padding(5);
            this.btnModelsInput.Name = "btnModelsInput";
            this.btnModelsInput.Size = new System.Drawing.Size(206, 70);
            this.btnModelsInput.TabIndex = 6;
            this.btnModelsInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModelsInput.Click += new System.EventHandler(this.BtnModelsInput_Click);
            // 
            // btnNuclideInput
            // 
            this.btnNuclideInput.ActiveBorderThickness = 1;
            this.btnNuclideInput.ActiveCornerRadius = 20;
            this.btnNuclideInput.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnNuclideInput.ActiveForecolor = System.Drawing.Color.White;
            this.btnNuclideInput.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNuclideInput.BackColor = System.Drawing.Color.Transparent;
            this.btnNuclideInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuclideInput.BackgroundImage")));
            this.btnNuclideInput.ButtonText = "Chọn đồng vị phóng xạ";
            this.btnNuclideInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuclideInput.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuclideInput.ForeColor = System.Drawing.Color.Black;
            this.btnNuclideInput.IdleBorderThickness = 1;
            this.btnNuclideInput.IdleCornerRadius = 20;
            this.btnNuclideInput.IdleFillColor = System.Drawing.Color.White;
            this.btnNuclideInput.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnNuclideInput.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNuclideInput.Location = new System.Drawing.Point(15, 86);
            this.btnNuclideInput.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuclideInput.Name = "btnNuclideInput";
            this.btnNuclideInput.Size = new System.Drawing.Size(206, 70);
            this.btnNuclideInput.TabIndex = 5;
            this.btnNuclideInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuclideInput.Click += new System.EventHandler(this.BtnNuclideInput_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlHomeInput);
            this.panel1.Controls.Add(this.pnlModelsInput);
            this.panel1.Controls.Add(this.pnlNuclideInput);
            this.panel1.Controls.Add(this.pnlDoseOutput);
            this.panel1.Controls.Add(this.pnlKineticsInput);
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.panel1.Controls.Add(this.pnlRibbon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 566);
            this.panel1.TabIndex = 1;
            // 
            // pnlHomeInput
            // 
            this.pnlHomeInput.Controls.Add(this.textBox11);
            this.pnlHomeInput.Controls.Add(this.textBox12);
            this.pnlHomeInput.Controls.Add(this.textBox13);
            this.pnlHomeInput.Controls.Add(this.textBox14);
            this.pnlHomeInput.Controls.Add(this.textBox15);
            this.pnlHomeInput.Controls.Add(this.textBox16);
            this.pnlHomeInput.Controls.Add(this.textBox17);
            this.pnlHomeInput.Controls.Add(this.textBox18);
            this.pnlHomeInput.Controls.Add(this.textBox19);
            this.pnlHomeInput.Controls.Add(this.textBox20);
            this.pnlHomeInput.Controls.Add(this.textBox10);
            this.pnlHomeInput.Controls.Add(this.textBox9);
            this.pnlHomeInput.Controls.Add(this.textBox8);
            this.pnlHomeInput.Controls.Add(this.textBox7);
            this.pnlHomeInput.Controls.Add(this.textBox6);
            this.pnlHomeInput.Controls.Add(this.textBox5);
            this.pnlHomeInput.Controls.Add(this.textBox4);
            this.pnlHomeInput.Controls.Add(this.textBox3);
            this.pnlHomeInput.Controls.Add(this.textBox2);
            this.pnlHomeInput.Controls.Add(this.textBox1);
            this.pnlHomeInput.Controls.Add(this.bunifuThinButton22);
            this.pnlHomeInput.Controls.Add(this.bunifuThinButton21);
            this.pnlHomeInput.Location = new System.Drawing.Point(245, 38);
            this.pnlHomeInput.Name = "pnlHomeInput";
            this.pnlHomeInput.Size = new System.Drawing.Size(764, 519);
            this.pnlHomeInput.TabIndex = 0;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(578, 445);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(150, 25);
            this.textBox11.TabIndex = 21;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(578, 414);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(150, 25);
            this.textBox12.TabIndex = 20;
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(578, 383);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(150, 25);
            this.textBox13.TabIndex = 19;
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(578, 352);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(150, 25);
            this.textBox14.TabIndex = 18;
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(578, 321);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(150, 25);
            this.textBox15.TabIndex = 17;
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(578, 290);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(150, 25);
            this.textBox16.TabIndex = 16;
            // 
            // textBox17
            // 
            this.textBox17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(578, 259);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(150, 25);
            this.textBox17.TabIndex = 15;
            // 
            // textBox18
            // 
            this.textBox18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.Location = new System.Drawing.Point(578, 228);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(150, 25);
            this.textBox18.TabIndex = 14;
            // 
            // textBox19
            // 
            this.textBox19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.Location = new System.Drawing.Point(578, 197);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(150, 25);
            this.textBox19.TabIndex = 13;
            // 
            // textBox20
            // 
            this.textBox20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.Location = new System.Drawing.Point(578, 166);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(150, 25);
            this.textBox20.TabIndex = 12;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(39, 445);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(150, 25);
            this.textBox10.TabIndex = 11;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(39, 414);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(150, 25);
            this.textBox9.TabIndex = 10;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(39, 383);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(150, 25);
            this.textBox8.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(39, 352);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(150, 25);
            this.textBox7.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(39, 321);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 25);
            this.textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(39, 290);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 25);
            this.textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(39, 259);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 25);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(39, 228);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 25);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(39, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 25);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(39, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 25);
            this.textBox1.TabIndex = 2;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Mô hình sau     >>";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(533, 92);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(195, 54);
            this.bunifuThinButton22.TabIndex = 1;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "<<     Mô hình trước";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(39, 92);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(195, 54);
            this.bunifuThinButton21.TabIndex = 0;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlModelsInput
            // 
            this.pnlModelsInput.Location = new System.Drawing.Point(245, 38);
            this.pnlModelsInput.Name = "pnlModelsInput";
            this.pnlModelsInput.Size = new System.Drawing.Size(764, 519);
            this.pnlModelsInput.TabIndex = 0;
            // 
            // pnlNuclideInput
            // 
            this.pnlNuclideInput.Location = new System.Drawing.Point(245, 38);
            this.pnlNuclideInput.Name = "pnlNuclideInput";
            this.pnlNuclideInput.Size = new System.Drawing.Size(764, 519);
            this.pnlNuclideInput.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 566);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Radiation Software Calculation v1.0";
            this.pnlRibbon.ResumeLayout(false);
            this.pnlRibbon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlHomeInput.ResumeLayout(false);
            this.pnlHomeInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKineticsInput;
        private Bunifu.Framework.UI.BunifuThinButton2 btnModelsInput;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNuclideInput;
        private System.Windows.Forms.Panel pnlRibbon;
        private System.Windows.Forms.Label lbRibbon;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel pnlNuclideInput;
        private System.Windows.Forms.Panel pnlModelsInput;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHomeInput;
        private System.Windows.Forms.Panel pnlHomeInput;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDose;
        private System.Windows.Forms.Panel pnlDoseOutput;
        private System.Windows.Forms.Panel pnlKineticsInput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

