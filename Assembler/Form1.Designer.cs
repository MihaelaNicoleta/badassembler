namespace Assembler
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.assembleButton = new System.Windows.Forms.Button();
            this.microcodeButton = new System.Windows.Forms.Button();
            this.asmButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.asmCode = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IR = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.MDR = new System.Windows.Forms.Label();
            this.ADR = new System.Windows.Forms.Label();
            this.IVR = new System.Windows.Forms.Label();
            this.PC = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Label();
            this.SP = new System.Windows.Forms.Label();
            this.flags = new System.Windows.Forms.Label();
            this.R15 = new System.Windows.Forms.Label();
            this.R14 = new System.Windows.Forms.Label();
            this.R13 = new System.Windows.Forms.Label();
            this.R12 = new System.Windows.Forms.Label();
            this.R11 = new System.Windows.Forms.Label();
            this.R10 = new System.Windows.Forms.Label();
            this.R9 = new System.Windows.Forms.Label();
            this.R8 = new System.Windows.Forms.Label();
            this.R7 = new System.Windows.Forms.Label();
            this.R6 = new System.Windows.Forms.Label();
            this.R5 = new System.Windows.Forms.Label();
            this.R4 = new System.Windows.Forms.Label();
            this.R3 = new System.Windows.Forms.Label();
            this.R2 = new System.Windows.Forms.Label();
            this.R1 = new System.Windows.Forms.Label();
            this.R0 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.messagesTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.assembleButton);
            this.panel1.Controls.Add(this.microcodeButton);
            this.panel1.Controls.Add(this.asmButton);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 122);
            this.panel1.TabIndex = 0;
            // 
            // assembleButton
            // 
            this.assembleButton.Location = new System.Drawing.Point(3, 32);
            this.assembleButton.Name = "assembleButton";
            this.assembleButton.Size = new System.Drawing.Size(110, 23);
            this.assembleButton.TabIndex = 2;
            this.assembleButton.Text = "Assemble";
            this.assembleButton.UseVisualStyleBackColor = true;
            this.assembleButton.Click += new System.EventHandler(this.assembleButton_Click);
            // 
            // microcodeButton
            // 
            this.microcodeButton.Location = new System.Drawing.Point(3, 61);
            this.microcodeButton.Name = "microcodeButton";
            this.microcodeButton.Size = new System.Drawing.Size(110, 23);
            this.microcodeButton.TabIndex = 1;
            this.microcodeButton.Text = "Open microcode";
            this.microcodeButton.UseVisualStyleBackColor = true;
            this.microcodeButton.Click += new System.EventHandler(this.microcodeButton_Click);
            // 
            // asmButton
            // 
            this.asmButton.Location = new System.Drawing.Point(3, 3);
            this.asmButton.Name = "asmButton";
            this.asmButton.Size = new System.Drawing.Size(110, 23);
            this.asmButton.TabIndex = 0;
            this.asmButton.Text = "Read asm code";
            this.asmButton.UseVisualStyleBackColor = true;
            this.asmButton.Click += new System.EventHandler(this.asmButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.asmCode);
            this.panel2.Location = new System.Drawing.Point(2, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 497);
            this.panel2.TabIndex = 1;
            // 
            // asmCode
            // 
            this.asmCode.Location = new System.Drawing.Point(3, 0);
            this.asmCode.Name = "asmCode";
            this.asmCode.Size = new System.Drawing.Size(189, 361);
            this.asmCode.TabIndex = 3;
            this.asmCode.Text = "ASM CODE";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.IR);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.MDR);
            this.panel3.Controls.Add(this.ADR);
            this.panel3.Controls.Add(this.IVR);
            this.panel3.Controls.Add(this.PC);
            this.panel3.Controls.Add(this.T);
            this.panel3.Controls.Add(this.SP);
            this.panel3.Controls.Add(this.flags);
            this.panel3.Controls.Add(this.R15);
            this.panel3.Controls.Add(this.R14);
            this.panel3.Controls.Add(this.R13);
            this.panel3.Controls.Add(this.R12);
            this.panel3.Controls.Add(this.R11);
            this.panel3.Controls.Add(this.R10);
            this.panel3.Controls.Add(this.R9);
            this.panel3.Controls.Add(this.R8);
            this.panel3.Controls.Add(this.R7);
            this.panel3.Controls.Add(this.R6);
            this.panel3.Controls.Add(this.R5);
            this.panel3.Controls.Add(this.R4);
            this.panel3.Controls.Add(this.R3);
            this.panel3.Controls.Add(this.R2);
            this.panel3.Controls.Add(this.R1);
            this.panel3.Controls.Add(this.R0);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.shapeContainer1);
            this.panel3.Location = new System.Drawing.Point(348, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1124, 643);
            this.panel3.TabIndex = 2;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(960, 304);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 13);
            this.label24.TabIndex = 51;
            this.label24.Text = "FLAGS";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(51, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(18, 13);
            this.label23.TabIndex = 50;
            this.label23.Text = "IR";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(171, 304);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 13);
            this.label22.TabIndex = 49;
            this.label22.Text = "MDR";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(231, 304);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "ADR";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(308, 304);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "IVR";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(379, 304);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "PC";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(460, 304);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "T";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(524, 304);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "SP";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(896, 304);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "R15";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(872, 304);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "R14";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(844, 304);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "R13";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(820, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "R12";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(796, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "R11";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(773, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "R10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(746, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "R9";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(727, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "R8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(708, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "R7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(689, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "R6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(670, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "R5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(651, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "R4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "R3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "R2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "R1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "R0";
            // 
            // IR
            // 
            this.IR.Location = new System.Drawing.Point(78, 47);
            this.IR.Name = "IR";
            this.IR.Size = new System.Drawing.Size(105, 20);
            this.IR.TabIndex = 27;
            this.IR.Text = "0000000000000000";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Assembler.Properties.Resources.muxR;
            this.pictureBox3.Location = new System.Drawing.Point(107, 522);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 40);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // MDR
            // 
            this.MDR.Location = new System.Drawing.Point(180, 329);
            this.MDR.Name = "MDR";
            this.MDR.Size = new System.Drawing.Size(13, 210);
            this.MDR.TabIndex = 25;
            this.MDR.Text = "0000000000000000";
            // 
            // ADR
            // 
            this.ADR.Location = new System.Drawing.Point(248, 329);
            this.ADR.Name = "ADR";
            this.ADR.Size = new System.Drawing.Size(13, 210);
            this.ADR.TabIndex = 24;
            this.ADR.Text = "0000000000000000";
            // 
            // IVR
            // 
            this.IVR.Location = new System.Drawing.Point(320, 329);
            this.IVR.Name = "IVR";
            this.IVR.Size = new System.Drawing.Size(13, 210);
            this.IVR.TabIndex = 23;
            this.IVR.Text = "0000000000000000";
            // 
            // PC
            // 
            this.PC.Location = new System.Drawing.Point(387, 329);
            this.PC.Name = "PC";
            this.PC.Size = new System.Drawing.Size(13, 210);
            this.PC.TabIndex = 22;
            this.PC.Text = "0000000000000000";
            // 
            // T
            // 
            this.T.Location = new System.Drawing.Point(460, 329);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(13, 210);
            this.T.TabIndex = 21;
            this.T.Text = "0000000000000000";
            // 
            // SP
            // 
            this.SP.Location = new System.Drawing.Point(532, 329);
            this.SP.Name = "SP";
            this.SP.Size = new System.Drawing.Size(13, 210);
            this.SP.TabIndex = 20;
            this.SP.Text = "0000000000000000";
            // 
            // flags
            // 
            this.flags.Location = new System.Drawing.Point(968, 329);
            this.flags.Name = "flags";
            this.flags.Size = new System.Drawing.Size(13, 210);
            this.flags.TabIndex = 19;
            this.flags.Text = "0000000000000000";
            // 
            // R15
            // 
            this.R15.Location = new System.Drawing.Point(896, 329);
            this.R15.Name = "R15";
            this.R15.Size = new System.Drawing.Size(13, 210);
            this.R15.TabIndex = 18;
            this.R15.Text = "0000000000000000";
            // 
            // R14
            // 
            this.R14.Location = new System.Drawing.Point(872, 329);
            this.R14.Name = "R14";
            this.R14.Size = new System.Drawing.Size(13, 210);
            this.R14.TabIndex = 18;
            this.R14.Text = "0000000000000000";
            // 
            // R13
            // 
            this.R13.Location = new System.Drawing.Point(853, 329);
            this.R13.Name = "R13";
            this.R13.Size = new System.Drawing.Size(13, 210);
            this.R13.TabIndex = 18;
            this.R13.Text = "0000000000000000";
            // 
            // R12
            // 
            this.R12.Location = new System.Drawing.Point(829, 329);
            this.R12.Name = "R12";
            this.R12.Size = new System.Drawing.Size(13, 210);
            this.R12.TabIndex = 18;
            this.R12.Text = "0000000000000000";
            // 
            // R11
            // 
            this.R11.Location = new System.Drawing.Point(810, 329);
            this.R11.Name = "R11";
            this.R11.Size = new System.Drawing.Size(13, 210);
            this.R11.TabIndex = 18;
            this.R11.Text = "0000000000000000";
            // 
            // R10
            // 
            this.R10.Location = new System.Drawing.Point(773, 329);
            this.R10.Name = "R10";
            this.R10.Size = new System.Drawing.Size(13, 210);
            this.R10.TabIndex = 18;
            this.R10.Text = "0000000000000000";
            // 
            // R9
            // 
            this.R9.Location = new System.Drawing.Point(754, 329);
            this.R9.Name = "R9";
            this.R9.Size = new System.Drawing.Size(13, 210);
            this.R9.TabIndex = 18;
            this.R9.Text = "0000000000000000";
            // 
            // R8
            // 
            this.R8.Location = new System.Drawing.Point(735, 329);
            this.R8.Name = "R8";
            this.R8.Size = new System.Drawing.Size(13, 210);
            this.R8.TabIndex = 18;
            this.R8.Text = "0000000000000000";
            // 
            // R7
            // 
            this.R7.Location = new System.Drawing.Point(716, 329);
            this.R7.Name = "R7";
            this.R7.Size = new System.Drawing.Size(13, 210);
            this.R7.TabIndex = 18;
            this.R7.Text = "0000000000000000";
            // 
            // R6
            // 
            this.R6.Location = new System.Drawing.Point(697, 329);
            this.R6.Name = "R6";
            this.R6.Size = new System.Drawing.Size(13, 210);
            this.R6.TabIndex = 18;
            this.R6.Text = "0000000000000000";
            // 
            // R5
            // 
            this.R5.Location = new System.Drawing.Point(678, 329);
            this.R5.Name = "R5";
            this.R5.Size = new System.Drawing.Size(13, 210);
            this.R5.TabIndex = 18;
            this.R5.Text = "0000000000000000";
            // 
            // R4
            // 
            this.R4.Location = new System.Drawing.Point(659, 329);
            this.R4.Name = "R4";
            this.R4.Size = new System.Drawing.Size(13, 210);
            this.R4.TabIndex = 18;
            this.R4.Text = "0000000000000000";
            // 
            // R3
            // 
            this.R3.Location = new System.Drawing.Point(642, 329);
            this.R3.Name = "R3";
            this.R3.Size = new System.Drawing.Size(13, 210);
            this.R3.TabIndex = 18;
            this.R3.Text = "0000000000000000";
            // 
            // R2
            // 
            this.R2.Location = new System.Drawing.Point(623, 329);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(13, 210);
            this.R2.TabIndex = 18;
            this.R2.Text = "0000000000000000";
            // 
            // R1
            // 
            this.R1.Location = new System.Drawing.Point(604, 329);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(13, 210);
            this.R1.TabIndex = 18;
            this.R1.Text = "0000000000000000";
            // 
            // R0
            // 
            this.R0.Location = new System.Drawing.Point(585, 329);
            this.R0.Name = "R0";
            this.R0.Size = new System.Drawing.Size(13, 210);
            this.R0.TabIndex = 18;
            this.R0.Text = "0000000000000000";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(947, 563);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 25);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(987, 471);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 52);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1124, 643);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderWidth = 10;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 81;
            this.lineShape3.X2 = 1086;
            this.lineShape3.Y1 = 614;
            this.lineShape3.Y2 = 610;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderWidth = 10;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 71;
            this.lineShape2.X2 = 1082;
            this.lineShape2.Y1 = 220;
            this.lineShape2.Y2 = 219;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 10;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 70;
            this.lineShape1.X2 = 1081;
            this.lineShape1.Y1 = 125;
            this.lineShape1.Y2 = 116;
            // 
            // messagesTextBox
            // 
            this.messagesTextBox.Location = new System.Drawing.Point(208, 68);
            this.messagesTextBox.Multiline = true;
            this.messagesTextBox.Name = "messagesTextBox";
            this.messagesTextBox.Size = new System.Drawing.Size(134, 122);
            this.messagesTextBox.TabIndex = 3;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 658);
            this.Controls.Add(this.messagesTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "mainForm";
            this.Text = "Assembler";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label R15;
        private System.Windows.Forms.Label R14;
        private System.Windows.Forms.Label R13;
        private System.Windows.Forms.Label R12;
        private System.Windows.Forms.Label R11;
        private System.Windows.Forms.Label R10;
        private System.Windows.Forms.Label R9;
        private System.Windows.Forms.Label R8;
        private System.Windows.Forms.Label R7;
        private System.Windows.Forms.Label R6;
        private System.Windows.Forms.Label R5;
        private System.Windows.Forms.Label R4;
        private System.Windows.Forms.Label R3;
        private System.Windows.Forms.Label R2;
        private System.Windows.Forms.Label R1;
        private System.Windows.Forms.Label R0;
        private System.Windows.Forms.Label flags;
        private System.Windows.Forms.Label SP;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.Label PC;
        private System.Windows.Forms.Label IVR;
        private System.Windows.Forms.Label ADR;
        private System.Windows.Forms.Label MDR;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label IR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label asmCode;
        private System.Windows.Forms.Button microcodeButton;
        private System.Windows.Forms.Button asmButton;
        private System.Windows.Forms.TextBox messagesTextBox;
        private System.Windows.Forms.Button assembleButton;
    }
}

