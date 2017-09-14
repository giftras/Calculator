namespace Calculator_Final
{
	partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.listBoxCurrency = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.percent = new System.Windows.Forms.Button();
			this.memory = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.n = new System.Windows.Forms.Button();
			this.number0 = new System.Windows.Forms.Button();
			this.dot = new System.Windows.Forms.Button();
			this.divide = new System.Windows.Forms.Button();
			this.equal = new System.Windows.Forms.Button();
			this.mod = new System.Windows.Forms.Button();
			this.expo10 = new System.Windows.Forms.Button();
			this.expo = new System.Windows.Forms.Button();
			this.DEL = new System.Windows.Forms.Button();
			this.expoy = new System.Windows.Forms.Button();
			this.expo3 = new System.Windows.Forms.Button();
			this.expo2 = new System.Windows.Forms.Button();
			this.C = new System.Windows.Forms.Button();
			this.multiply = new System.Windows.Forms.Button();
			this.minus = new System.Windows.Forms.Button();
			this.plus = new System.Windows.Forms.Button();
			this.CE = new System.Windows.Forms.Button();
			this.number3 = new System.Windows.Forms.Button();
			this.number2 = new System.Windows.Forms.Button();
			this.number1 = new System.Windows.Forms.Button();
			this.number6 = new System.Windows.Forms.Button();
			this.number5 = new System.Windows.Forms.Button();
			this.number4 = new System.Windows.Forms.Button();
			this.number9 = new System.Windows.Forms.Button();
			this.number8 = new System.Windows.Forms.Button();
			this.number7 = new System.Windows.Forms.Button();
			this.Mminus = new System.Windows.Forms.Button();
			this.Mplus = new System.Windows.Forms.Button();
			this.MC = new System.Windows.Forms.Button();
			this.maintextbox = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculartorInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.convertBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.button1.Location = new System.Drawing.Point(368, 238);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 49);
			this.button1.TabIndex = 77;
			this.button1.Text = "Convert";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBoxCurrency
			// 
			this.listBoxCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.listBoxCurrency.FormattingEnabled = true;
			this.listBoxCurrency.ItemHeight = 20;
			this.listBoxCurrency.Items.AddRange(new object[] {
            "THB -> USD",
            "USD -> THB"});
			this.listBoxCurrency.Location = new System.Drawing.Point(379, 180);
			this.listBoxCurrency.Name = "listBoxCurrency";
			this.listBoxCurrency.Size = new System.Drawing.Size(103, 44);
			this.listBoxCurrency.TabIndex = 76;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(356, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(151, 28);
			this.label3.TabIndex = 75;
			this.label3.Text = "Convert currency";
			// 
			// percent
			// 
			this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.percent.Location = new System.Drawing.Point(235, 295);
			this.percent.Name = "percent";
			this.percent.Size = new System.Drawing.Size(51, 49);
			this.percent.TabIndex = 74;
			this.percent.Text = "%";
			this.percent.UseVisualStyleBackColor = true;
			this.percent.Click += new System.EventHandler(this.percent_Click);
			// 
			// memory
			// 
			this.memory.Location = new System.Drawing.Point(348, 68);
			this.memory.Name = "memory";
			this.memory.Size = new System.Drawing.Size(159, 51);
			this.memory.TabIndex = 72;
			this.memory.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(356, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 28);
			this.label2.TabIndex = 71;
			this.label2.Text = "MEMORY";
			// 
			// n
			// 
			this.n.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.n.Location = new System.Drawing.Point(12, 295);
			this.n.Name = "n";
			this.n.Size = new System.Drawing.Size(50, 49);
			this.n.TabIndex = 70;
			this.n.Text = "n!";
			this.n.UseVisualStyleBackColor = true;
			this.n.Click += new System.EventHandler(this.onetimeoperation);
			// 
			// number0
			// 
			this.number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number0.Location = new System.Drawing.Point(68, 295);
			this.number0.Name = "number0";
			this.number0.Size = new System.Drawing.Size(50, 49);
			this.number0.TabIndex = 69;
			this.number0.Text = "0";
			this.number0.UseVisualStyleBackColor = true;
			this.number0.Click += new System.EventHandler(this.num_click);
			// 
			// dot
			// 
			this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.dot.Location = new System.Drawing.Point(125, 295);
			this.dot.Name = "dot";
			this.dot.Size = new System.Drawing.Size(50, 49);
			this.dot.TabIndex = 68;
			this.dot.Text = ".";
			this.dot.UseVisualStyleBackColor = true;
			this.dot.Click += new System.EventHandler(this.num_click);
			// 
			// divide
			// 
			this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.divide.Location = new System.Drawing.Point(181, 295);
			this.divide.Name = "divide";
			this.divide.Size = new System.Drawing.Size(50, 49);
			this.divide.TabIndex = 67;
			this.divide.Text = "/";
			this.divide.UseVisualStyleBackColor = true;
			this.divide.Click += new System.EventHandler(this.operationclick);
			// 
			// equal
			// 
			this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.equal.Location = new System.Drawing.Point(292, 293);
			this.equal.Name = "equal";
			this.equal.Size = new System.Drawing.Size(51, 49);
			this.equal.TabIndex = 66;
			this.equal.Text = "=";
			this.equal.UseVisualStyleBackColor = true;
			this.equal.Click += new System.EventHandler(this.operationclick);
			// 
			// mod
			// 
			this.mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.mod.Location = new System.Drawing.Point(293, 238);
			this.mod.Name = "mod";
			this.mod.Size = new System.Drawing.Size(50, 49);
			this.mod.TabIndex = 65;
			this.mod.Text = "Mod";
			this.mod.UseVisualStyleBackColor = true;
			this.mod.Click += new System.EventHandler(this.operationclick);
			// 
			// expo10
			// 
			this.expo10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.expo10.Location = new System.Drawing.Point(292, 128);
			this.expo10.Name = "expo10";
			this.expo10.Size = new System.Drawing.Size(50, 49);
			this.expo10.TabIndex = 64;
			this.expo10.Text = "10^";
			this.expo10.UseVisualStyleBackColor = true;
			this.expo10.Click += new System.EventHandler(this.onetimeoperation);
			// 
			// expo
			// 
			this.expo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.expo.Location = new System.Drawing.Point(292, 183);
			this.expo.Name = "expo";
			this.expo.Size = new System.Drawing.Size(50, 49);
			this.expo.TabIndex = 63;
			this.expo.Text = "Exp";
			this.expo.UseVisualStyleBackColor = true;
			this.expo.Click += new System.EventHandler(this.onetimeoperation);
			// 
			// DEL
			// 
			this.DEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.DEL.Location = new System.Drawing.Point(292, 68);
			this.DEL.Name = "DEL";
			this.DEL.Size = new System.Drawing.Size(50, 49);
			this.DEL.TabIndex = 62;
			this.DEL.Text = "del";
			this.DEL.UseVisualStyleBackColor = true;
			this.DEL.Click += new System.EventHandler(this.DEL_Click);
			// 
			// expoy
			// 
			this.expoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.expoy.Location = new System.Drawing.Point(237, 238);
			this.expoy.Name = "expoy";
			this.expoy.Size = new System.Drawing.Size(50, 49);
			this.expoy.TabIndex = 61;
			this.expoy.Text = "^";
			this.expoy.UseVisualStyleBackColor = true;
			this.expoy.Click += new System.EventHandler(this.operationclick);
			// 
			// expo3
			// 
			this.expo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.expo3.Location = new System.Drawing.Point(237, 183);
			this.expo3.Name = "expo3";
			this.expo3.Size = new System.Drawing.Size(50, 49);
			this.expo3.TabIndex = 60;
			this.expo3.Text = "^3";
			this.expo3.UseVisualStyleBackColor = true;
			this.expo3.Click += new System.EventHandler(this.onetimeoperation);
			// 
			// expo2
			// 
			this.expo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.expo2.Location = new System.Drawing.Point(236, 128);
			this.expo2.Name = "expo2";
			this.expo2.Size = new System.Drawing.Size(50, 49);
			this.expo2.TabIndex = 59;
			this.expo2.Text = "^2";
			this.expo2.UseVisualStyleBackColor = true;
			this.expo2.Click += new System.EventHandler(this.onetimeoperation);
			// 
			// C
			// 
			this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.C.Location = new System.Drawing.Point(237, 68);
			this.C.Name = "C";
			this.C.Size = new System.Drawing.Size(50, 49);
			this.C.TabIndex = 58;
			this.C.Text = "C";
			this.C.UseVisualStyleBackColor = true;
			this.C.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// multiply
			// 
			this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.multiply.Location = new System.Drawing.Point(181, 240);
			this.multiply.Name = "multiply";
			this.multiply.Size = new System.Drawing.Size(50, 49);
			this.multiply.TabIndex = 57;
			this.multiply.Text = "x";
			this.multiply.UseVisualStyleBackColor = true;
			this.multiply.Click += new System.EventHandler(this.operationclick);
			// 
			// minus
			// 
			this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.minus.Location = new System.Drawing.Point(181, 185);
			this.minus.Name = "minus";
			this.minus.Size = new System.Drawing.Size(50, 49);
			this.minus.TabIndex = 56;
			this.minus.Text = "-";
			this.minus.UseVisualStyleBackColor = true;
			this.minus.Click += new System.EventHandler(this.operationclick);
			// 
			// plus
			// 
			this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.plus.Location = new System.Drawing.Point(180, 128);
			this.plus.Name = "plus";
			this.plus.Size = new System.Drawing.Size(50, 49);
			this.plus.TabIndex = 55;
			this.plus.Text = "+";
			this.plus.UseVisualStyleBackColor = true;
			this.plus.Click += new System.EventHandler(this.operationclick);
			// 
			// CE
			// 
			this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.CE.Location = new System.Drawing.Point(181, 68);
			this.CE.Name = "CE";
			this.CE.Size = new System.Drawing.Size(50, 49);
			this.CE.TabIndex = 54;
			this.CE.Text = "CE";
			this.CE.UseVisualStyleBackColor = true;
			this.CE.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// number3
			// 
			this.number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number3.Location = new System.Drawing.Point(125, 240);
			this.number3.Name = "number3";
			this.number3.Size = new System.Drawing.Size(50, 49);
			this.number3.TabIndex = 53;
			this.number3.Text = "3";
			this.number3.UseVisualStyleBackColor = true;
			this.number3.Click += new System.EventHandler(this.num_click);
			// 
			// number2
			// 
			this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number2.Location = new System.Drawing.Point(69, 240);
			this.number2.Name = "number2";
			this.number2.Size = new System.Drawing.Size(50, 49);
			this.number2.TabIndex = 52;
			this.number2.Text = "2";
			this.number2.UseVisualStyleBackColor = true;
			this.number2.Click += new System.EventHandler(this.num_click);
			// 
			// number1
			// 
			this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number1.Location = new System.Drawing.Point(12, 240);
			this.number1.Name = "number1";
			this.number1.Size = new System.Drawing.Size(50, 49);
			this.number1.TabIndex = 51;
			this.number1.Text = "1";
			this.number1.UseVisualStyleBackColor = true;
			this.number1.Click += new System.EventHandler(this.num_click);
			// 
			// number6
			// 
			this.number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number6.Location = new System.Drawing.Point(125, 185);
			this.number6.Name = "number6";
			this.number6.Size = new System.Drawing.Size(50, 49);
			this.number6.TabIndex = 50;
			this.number6.Text = "6";
			this.number6.UseVisualStyleBackColor = true;
			this.number6.Click += new System.EventHandler(this.num_click);
			// 
			// number5
			// 
			this.number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number5.Location = new System.Drawing.Point(69, 183);
			this.number5.Name = "number5";
			this.number5.Size = new System.Drawing.Size(50, 49);
			this.number5.TabIndex = 49;
			this.number5.Text = "5";
			this.number5.UseVisualStyleBackColor = true;
			this.number5.Click += new System.EventHandler(this.num_click);
			// 
			// number4
			// 
			this.number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number4.Location = new System.Drawing.Point(13, 183);
			this.number4.Name = "number4";
			this.number4.Size = new System.Drawing.Size(50, 49);
			this.number4.TabIndex = 48;
			this.number4.Text = "4";
			this.number4.UseVisualStyleBackColor = true;
			this.number4.Click += new System.EventHandler(this.num_click);
			// 
			// number9
			// 
			this.number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number9.Location = new System.Drawing.Point(124, 128);
			this.number9.Name = "number9";
			this.number9.Size = new System.Drawing.Size(50, 49);
			this.number9.TabIndex = 47;
			this.number9.Text = "9";
			this.number9.UseVisualStyleBackColor = true;
			this.number9.Click += new System.EventHandler(this.num_click);
			// 
			// number8
			// 
			this.number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number8.Location = new System.Drawing.Point(68, 128);
			this.number8.Name = "number8";
			this.number8.Size = new System.Drawing.Size(50, 49);
			this.number8.TabIndex = 46;
			this.number8.Text = "8";
			this.number8.UseVisualStyleBackColor = true;
			this.number8.Click += new System.EventHandler(this.num_click);
			// 
			// number7
			// 
			this.number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.number7.Location = new System.Drawing.Point(13, 128);
			this.number7.Name = "number7";
			this.number7.Size = new System.Drawing.Size(50, 49);
			this.number7.TabIndex = 45;
			this.number7.Text = "7";
			this.number7.UseVisualStyleBackColor = true;
			this.number7.Click += new System.EventHandler(this.num_click);
			// 
			// Mminus
			// 
			this.Mminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Mminus.Location = new System.Drawing.Point(125, 68);
			this.Mminus.Name = "Mminus";
			this.Mminus.Size = new System.Drawing.Size(50, 49);
			this.Mminus.TabIndex = 44;
			this.Mminus.Text = "M-";
			this.Mminus.UseVisualStyleBackColor = true;
			this.Mminus.Click += new System.EventHandler(this.Memory);
			// 
			// Mplus
			// 
			this.Mplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Mplus.Location = new System.Drawing.Point(69, 68);
			this.Mplus.Name = "Mplus";
			this.Mplus.Size = new System.Drawing.Size(50, 49);
			this.Mplus.TabIndex = 43;
			this.Mplus.Text = "M+";
			this.Mplus.UseVisualStyleBackColor = true;
			this.Mplus.Click += new System.EventHandler(this.Memory);
			// 
			// MC
			// 
			this.MC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.MC.Location = new System.Drawing.Point(13, 68);
			this.MC.Name = "MC";
			this.MC.Size = new System.Drawing.Size(50, 49);
			this.MC.TabIndex = 42;
			this.MC.Text = "MC";
			this.MC.UseVisualStyleBackColor = true;
			this.MC.Click += new System.EventHandler(this.Memory);
			// 
			// maintextbox
			// 
			this.maintextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.maintextbox.Location = new System.Drawing.Point(12, 28);
			this.maintextbox.Name = "maintextbox";
			this.maintextbox.Size = new System.Drawing.Size(330, 38);
			this.maintextbox.TabIndex = 41;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(516, 24);
			this.menuStrip1.TabIndex = 73;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculartorInfoToolStripMenuItem,
            this.convertBinaryToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// calculartorInfoToolStripMenuItem
			// 
			this.calculartorInfoToolStripMenuItem.Name = "calculartorInfoToolStripMenuItem";
			this.calculartorInfoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.calculartorInfoToolStripMenuItem.Text = "CalculartorInfo";
			this.calculartorInfoToolStripMenuItem.Click += new System.EventHandler(this.calculartorInfoToolStripMenuItem_Click);
			// 
			// convertBinaryToolStripMenuItem
			// 
			this.convertBinaryToolStripMenuItem.Name = "convertBinaryToolStripMenuItem";
			this.convertBinaryToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.convertBinaryToolStripMenuItem.Text = "ConvertBinary";
			this.convertBinaryToolStripMenuItem.Click += new System.EventHandler(this.convertBinaryToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 349);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBoxCurrency);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.percent);
			this.Controls.Add(this.memory);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.n);
			this.Controls.Add(this.number0);
			this.Controls.Add(this.dot);
			this.Controls.Add(this.divide);
			this.Controls.Add(this.equal);
			this.Controls.Add(this.mod);
			this.Controls.Add(this.expo10);
			this.Controls.Add(this.expo);
			this.Controls.Add(this.DEL);
			this.Controls.Add(this.expoy);
			this.Controls.Add(this.expo3);
			this.Controls.Add(this.expo2);
			this.Controls.Add(this.C);
			this.Controls.Add(this.multiply);
			this.Controls.Add(this.minus);
			this.Controls.Add(this.plus);
			this.Controls.Add(this.CE);
			this.Controls.Add(this.number3);
			this.Controls.Add(this.number2);
			this.Controls.Add(this.number1);
			this.Controls.Add(this.number6);
			this.Controls.Add(this.number5);
			this.Controls.Add(this.number4);
			this.Controls.Add(this.number9);
			this.Controls.Add(this.number8);
			this.Controls.Add(this.number7);
			this.Controls.Add(this.Mminus);
			this.Controls.Add(this.Mplus);
			this.Controls.Add(this.MC);
			this.Controls.Add(this.maintextbox);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Form1";
			this.Text = "Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBoxCurrency;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button percent;
		private System.Windows.Forms.RichTextBox memory;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button n;
		private System.Windows.Forms.Button number0;
		private System.Windows.Forms.Button dot;
		private System.Windows.Forms.Button divide;
		private System.Windows.Forms.Button equal;
		private System.Windows.Forms.Button mod;
		private System.Windows.Forms.Button expo10;
		private System.Windows.Forms.Button expo;
		private System.Windows.Forms.Button DEL;
		private System.Windows.Forms.Button expoy;
		private System.Windows.Forms.Button expo3;
		private System.Windows.Forms.Button expo2;
		private System.Windows.Forms.Button C;
		private System.Windows.Forms.Button multiply;
		private System.Windows.Forms.Button minus;
		private System.Windows.Forms.Button plus;
		private System.Windows.Forms.Button CE;
		private System.Windows.Forms.Button number3;
		private System.Windows.Forms.Button number2;
		private System.Windows.Forms.Button number1;
		private System.Windows.Forms.Button number6;
		private System.Windows.Forms.Button number5;
		private System.Windows.Forms.Button number4;
		private System.Windows.Forms.Button number9;
		private System.Windows.Forms.Button number8;
		private System.Windows.Forms.Button number7;
		private System.Windows.Forms.Button Mminus;
		private System.Windows.Forms.Button Mplus;
		private System.Windows.Forms.Button MC;
		private System.Windows.Forms.TextBox maintextbox;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculartorInfoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem convertBinaryToolStripMenuItem;
	}
}

