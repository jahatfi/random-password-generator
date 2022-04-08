namespace Random_Password_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.includeSymbols = new System.Windows.Forms.RadioButton();
            this.excludeSymbols = new System.Windows.Forms.RadioButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exludeAll = new System.Windows.Forms.RadioButton();
            this.includeAll = new System.Windows.Forms.RadioButton();
            this.doublequoteCheckBox = new System.Windows.Forms.CheckBox();
            this.forwardSlashCheckBox = new System.Windows.Forms.CheckBox();
            this.questionMarkCheckBox = new System.Windows.Forms.CheckBox();
            this.periodCheckBox = new System.Windows.Forms.CheckBox();
            this.commaCheckBox = new System.Windows.Forms.CheckBox();
            this.angleBracketsCheckBox = new System.Windows.Forms.CheckBox();
            this.semicolonCheckBox = new System.Windows.Forms.CheckBox();
            this.colonCheckBox = new System.Windows.Forms.CheckBox();
            this.backslashCheckBox = new System.Windows.Forms.CheckBox();
            this.pipeCheckBox = new System.Windows.Forms.CheckBox();
            this.bracketsCheckBox = new System.Windows.Forms.CheckBox();
            this.bracesCheckBox = new System.Windows.Forms.CheckBox();
            this.equalsCheckBox = new System.Windows.Forms.CheckBox();
            this.plusCheckBox = new System.Windows.Forms.CheckBox();
            this.emDashCheckBox = new System.Windows.Forms.CheckBox();
            this.dashCheckBox = new System.Windows.Forms.CheckBox();
            this.paranthesesCheckBox = new System.Windows.Forms.CheckBox();
            this.splatCheckBox = new System.Windows.Forms.CheckBox();
            this.ampersandCheckBox = new System.Windows.Forms.CheckBox();
            this.caratCheckBox = new System.Windows.Forms.CheckBox();
            this.percentCheckBox = new System.Windows.Forms.CheckBox();
            this.dollarCheckBox = new System.Windows.Forms.CheckBox();
            this.hashCheckBox = new System.Windows.Forms.CheckBox();
            this.atCheckBox = new System.Windows.Forms.CheckBox();
            this.exclamationCheckBox = new System.Windows.Forms.CheckBox();
            this.tackCheckbox = new System.Windows.Forms.CheckBox();
            this.tildeCheckbox = new System.Windows.Forms.CheckBox();
            this.numbersCheckbox = new System.Windows.Forms.CheckBox();
            this.lowerCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.upperCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLength = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.autoClipboardCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // includeSymbols
            // 
            this.includeSymbols.AutoSize = true;
            this.includeSymbols.Checked = true;
            this.includeSymbols.Location = new System.Drawing.Point(10, 8);
            this.includeSymbols.Name = "includeSymbols";
            this.includeSymbols.Size = new System.Drawing.Size(257, 17);
            this.includeSymbols.TabIndex = 1;
            this.includeSymbols.TabStop = true;
            this.includeSymbols.Text = "Include the following symbols (exclude by default)";
            this.includeSymbols.UseVisualStyleBackColor = true;
            this.includeSymbols.CheckedChanged += new System.EventHandler(this.includeSymbols_CheckedChanged);
            // 
            // excludeSymbols
            // 
            this.excludeSymbols.AutoSize = true;
            this.excludeSymbols.Location = new System.Drawing.Point(10, 31);
            this.excludeSymbols.Name = "excludeSymbols";
            this.excludeSymbols.Size = new System.Drawing.Size(258, 17);
            this.excludeSymbols.TabIndex = 2;
            this.excludeSymbols.Text = "Exclude the following symbols (Include by default)";
            this.excludeSymbols.UseVisualStyleBackColor = true;
            this.excludeSymbols.CheckedChanged += new System.EventHandler(this.excludeSymbols_CheckedChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 436);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.exludeAll);
            this.panel1.Controls.Add(this.includeAll);
            this.panel1.Controls.Add(this.doublequoteCheckBox);
            this.panel1.Controls.Add(this.forwardSlashCheckBox);
            this.panel1.Controls.Add(this.questionMarkCheckBox);
            this.panel1.Controls.Add(this.periodCheckBox);
            this.panel1.Controls.Add(this.commaCheckBox);
            this.panel1.Controls.Add(this.angleBracketsCheckBox);
            this.panel1.Controls.Add(this.semicolonCheckBox);
            this.panel1.Controls.Add(this.colonCheckBox);
            this.panel1.Controls.Add(this.backslashCheckBox);
            this.panel1.Controls.Add(this.pipeCheckBox);
            this.panel1.Controls.Add(this.bracketsCheckBox);
            this.panel1.Controls.Add(this.bracesCheckBox);
            this.panel1.Controls.Add(this.equalsCheckBox);
            this.panel1.Controls.Add(this.plusCheckBox);
            this.panel1.Controls.Add(this.emDashCheckBox);
            this.panel1.Controls.Add(this.dashCheckBox);
            this.panel1.Controls.Add(this.paranthesesCheckBox);
            this.panel1.Controls.Add(this.splatCheckBox);
            this.panel1.Controls.Add(this.ampersandCheckBox);
            this.panel1.Controls.Add(this.caratCheckBox);
            this.panel1.Controls.Add(this.percentCheckBox);
            this.panel1.Controls.Add(this.dollarCheckBox);
            this.panel1.Controls.Add(this.hashCheckBox);
            this.panel1.Controls.Add(this.atCheckBox);
            this.panel1.Controls.Add(this.exclamationCheckBox);
            this.panel1.Controls.Add(this.tackCheckbox);
            this.panel1.Controls.Add(this.tildeCheckbox);
            this.panel1.Controls.Add(this.excludeSymbols);
            this.panel1.Controls.Add(this.includeSymbols);
            this.panel1.Location = new System.Drawing.Point(294, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 328);
            this.panel1.TabIndex = 5;
            // 
            // exludeAll
            // 
            this.exludeAll.AutoSize = true;
            this.exludeAll.Location = new System.Drawing.Point(10, 77);
            this.exludeAll.Name = "exludeAll";
            this.exludeAll.Size = new System.Drawing.Size(76, 17);
            this.exludeAll.TabIndex = 31;
            this.exludeAll.Text = "Exclude all";
            this.exludeAll.UseVisualStyleBackColor = true;
            this.exludeAll.CheckedChanged += new System.EventHandler(this.exludeAll_CheckedChanged);
            // 
            // includeAll
            // 
            this.includeAll.AutoSize = true;
            this.includeAll.Location = new System.Drawing.Point(10, 54);
            this.includeAll.Name = "includeAll";
            this.includeAll.Size = new System.Drawing.Size(73, 17);
            this.includeAll.TabIndex = 30;
            this.includeAll.Text = "Include all";
            this.includeAll.UseVisualStyleBackColor = true;
            this.includeAll.CheckedChanged += new System.EventHandler(this.includeAll_CheckedChanged);
            // 
            // doublequoteCheckBox
            // 
            this.doublequoteCheckBox.AutoSize = true;
            this.doublequoteCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doublequoteCheckBox.Location = new System.Drawing.Point(133, 202);
            this.doublequoteCheckBox.Name = "doublequoteCheckBox";
            this.doublequoteCheckBox.Size = new System.Drawing.Size(35, 24);
            this.doublequoteCheckBox.TabIndex = 29;
            this.doublequoteCheckBox.Text = "\"";
            this.doublequoteCheckBox.UseVisualStyleBackColor = true;
            // 
            // forwardSlashCheckBox
            // 
            this.forwardSlashCheckBox.AutoSize = true;
            this.forwardSlashCheckBox.Checked = true;
            this.forwardSlashCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.forwardSlashCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forwardSlashCheckBox.Location = new System.Drawing.Point(133, 294);
            this.forwardSlashCheckBox.Name = "forwardSlashCheckBox";
            this.forwardSlashCheckBox.Size = new System.Drawing.Size(33, 24);
            this.forwardSlashCheckBox.TabIndex = 28;
            this.forwardSlashCheckBox.Text = "/";
            this.forwardSlashCheckBox.UseVisualStyleBackColor = true;
            // 
            // questionMarkCheckBox
            // 
            this.questionMarkCheckBox.AutoSize = true;
            this.questionMarkCheckBox.Checked = true;
            this.questionMarkCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.questionMarkCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionMarkCheckBox.Location = new System.Drawing.Point(133, 271);
            this.questionMarkCheckBox.Name = "questionMarkCheckBox";
            this.questionMarkCheckBox.Size = new System.Drawing.Size(38, 24);
            this.questionMarkCheckBox.TabIndex = 27;
            this.questionMarkCheckBox.Text = "?";
            this.questionMarkCheckBox.UseVisualStyleBackColor = true;
            // 
            // periodCheckBox
            // 
            this.periodCheckBox.AutoSize = true;
            this.periodCheckBox.Checked = true;
            this.periodCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.periodCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodCheckBox.Location = new System.Drawing.Point(133, 248);
            this.periodCheckBox.Name = "periodCheckBox";
            this.periodCheckBox.Size = new System.Drawing.Size(33, 24);
            this.periodCheckBox.TabIndex = 26;
            this.periodCheckBox.Text = ".";
            this.periodCheckBox.UseVisualStyleBackColor = true;
            // 
            // commaCheckBox
            // 
            this.commaCheckBox.AutoSize = true;
            this.commaCheckBox.Checked = true;
            this.commaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.commaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commaCheckBox.Location = new System.Drawing.Point(133, 225);
            this.commaCheckBox.Name = "commaCheckBox";
            this.commaCheckBox.Size = new System.Drawing.Size(33, 24);
            this.commaCheckBox.TabIndex = 25;
            this.commaCheckBox.Text = ",";
            this.commaCheckBox.UseVisualStyleBackColor = true;
            // 
            // angleBracketsCheckBox
            // 
            this.angleBracketsCheckBox.AutoSize = true;
            this.angleBracketsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angleBracketsCheckBox.Location = new System.Drawing.Point(133, 179);
            this.angleBracketsCheckBox.Name = "angleBracketsCheckBox";
            this.angleBracketsCheckBox.Size = new System.Drawing.Size(53, 24);
            this.angleBracketsCheckBox.TabIndex = 24;
            this.angleBracketsCheckBox.Text = "< >";
            this.angleBracketsCheckBox.UseVisualStyleBackColor = true;
            // 
            // semicolonCheckBox
            // 
            this.semicolonCheckBox.AutoSize = true;
            this.semicolonCheckBox.Checked = true;
            this.semicolonCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.semicolonCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semicolonCheckBox.Location = new System.Drawing.Point(133, 156);
            this.semicolonCheckBox.Name = "semicolonCheckBox";
            this.semicolonCheckBox.Size = new System.Drawing.Size(33, 24);
            this.semicolonCheckBox.TabIndex = 23;
            this.semicolonCheckBox.Text = ";";
            this.semicolonCheckBox.UseVisualStyleBackColor = true;
            // 
            // colonCheckBox
            // 
            this.colonCheckBox.AutoSize = true;
            this.colonCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colonCheckBox.Location = new System.Drawing.Point(133, 133);
            this.colonCheckBox.Name = "colonCheckBox";
            this.colonCheckBox.Size = new System.Drawing.Size(33, 24);
            this.colonCheckBox.TabIndex = 22;
            this.colonCheckBox.Text = ":";
            this.colonCheckBox.UseVisualStyleBackColor = true;
            // 
            // backslashCheckBox
            // 
            this.backslashCheckBox.AutoSize = true;
            this.backslashCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backslashCheckBox.Location = new System.Drawing.Point(133, 110);
            this.backslashCheckBox.Name = "backslashCheckBox";
            this.backslashCheckBox.Size = new System.Drawing.Size(33, 24);
            this.backslashCheckBox.TabIndex = 21;
            this.backslashCheckBox.Text = "\\";
            this.backslashCheckBox.UseVisualStyleBackColor = true;
            // 
            // pipeCheckBox
            // 
            this.pipeCheckBox.AutoSize = true;
            this.pipeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pipeCheckBox.Location = new System.Drawing.Point(73, 294);
            this.pipeCheckBox.Name = "pipeCheckBox";
            this.pipeCheckBox.Size = new System.Drawing.Size(34, 24);
            this.pipeCheckBox.TabIndex = 20;
            this.pipeCheckBox.Text = "|";
            this.pipeCheckBox.UseVisualStyleBackColor = true;
            // 
            // bracketsCheckBox
            // 
            this.bracketsCheckBox.AutoSize = true;
            this.bracketsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bracketsCheckBox.Location = new System.Drawing.Point(73, 271);
            this.bracketsCheckBox.Name = "bracketsCheckBox";
            this.bracketsCheckBox.Size = new System.Drawing.Size(43, 24);
            this.bracketsCheckBox.TabIndex = 19;
            this.bracketsCheckBox.Text = "[ ]";
            this.bracketsCheckBox.UseVisualStyleBackColor = true;
            // 
            // bracesCheckBox
            // 
            this.bracesCheckBox.AutoSize = true;
            this.bracesCheckBox.Checked = true;
            this.bracesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bracesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bracesCheckBox.Location = new System.Drawing.Point(73, 248);
            this.bracesCheckBox.Name = "bracesCheckBox";
            this.bracesCheckBox.Size = new System.Drawing.Size(45, 24);
            this.bracesCheckBox.TabIndex = 18;
            this.bracesCheckBox.Text = "{ }";
            this.bracesCheckBox.UseVisualStyleBackColor = true;
            // 
            // equalsCheckBox
            // 
            this.equalsCheckBox.AutoSize = true;
            this.equalsCheckBox.Checked = true;
            this.equalsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.equalsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsCheckBox.Location = new System.Drawing.Point(73, 225);
            this.equalsCheckBox.Name = "equalsCheckBox";
            this.equalsCheckBox.Size = new System.Drawing.Size(38, 24);
            this.equalsCheckBox.TabIndex = 17;
            this.equalsCheckBox.Text = "=";
            this.equalsCheckBox.UseVisualStyleBackColor = true;
            // 
            // plusCheckBox
            // 
            this.plusCheckBox.AutoSize = true;
            this.plusCheckBox.Checked = true;
            this.plusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.plusCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusCheckBox.Location = new System.Drawing.Point(73, 202);
            this.plusCheckBox.Name = "plusCheckBox";
            this.plusCheckBox.Size = new System.Drawing.Size(38, 24);
            this.plusCheckBox.TabIndex = 16;
            this.plusCheckBox.Text = "+";
            this.plusCheckBox.UseVisualStyleBackColor = true;
            // 
            // emDashCheckBox
            // 
            this.emDashCheckBox.AutoSize = true;
            this.emDashCheckBox.Checked = true;
            this.emDashCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.emDashCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emDashCheckBox.Location = new System.Drawing.Point(73, 179);
            this.emDashCheckBox.Name = "emDashCheckBox";
            this.emDashCheckBox.Size = new System.Drawing.Size(38, 24);
            this.emDashCheckBox.TabIndex = 15;
            this.emDashCheckBox.Text = "_";
            this.emDashCheckBox.UseVisualStyleBackColor = true;
            // 
            // dashCheckBox
            // 
            this.dashCheckBox.AutoSize = true;
            this.dashCheckBox.Checked = true;
            this.dashCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dashCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashCheckBox.Location = new System.Drawing.Point(73, 156);
            this.dashCheckBox.Name = "dashCheckBox";
            this.dashCheckBox.Size = new System.Drawing.Size(34, 24);
            this.dashCheckBox.TabIndex = 14;
            this.dashCheckBox.Text = "-";
            this.dashCheckBox.UseVisualStyleBackColor = true;
            // 
            // paranthesesCheckBox
            // 
            this.paranthesesCheckBox.AutoSize = true;
            this.paranthesesCheckBox.Checked = true;
            this.paranthesesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.paranthesesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paranthesesCheckBox.Location = new System.Drawing.Point(73, 133);
            this.paranthesesCheckBox.Name = "paranthesesCheckBox";
            this.paranthesesCheckBox.Size = new System.Drawing.Size(45, 24);
            this.paranthesesCheckBox.TabIndex = 13;
            this.paranthesesCheckBox.Text = "( )";
            this.paranthesesCheckBox.UseVisualStyleBackColor = true;
            // 
            // splatCheckBox
            // 
            this.splatCheckBox.AutoSize = true;
            this.splatCheckBox.Checked = true;
            this.splatCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.splatCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splatCheckBox.Location = new System.Drawing.Point(73, 110);
            this.splatCheckBox.Name = "splatCheckBox";
            this.splatCheckBox.Size = new System.Drawing.Size(35, 24);
            this.splatCheckBox.TabIndex = 12;
            this.splatCheckBox.Text = "*";
            this.splatCheckBox.UseVisualStyleBackColor = true;
            // 
            // ampersandCheckBox
            // 
            this.ampersandCheckBox.AutoSize = true;
            this.ampersandCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ampersandCheckBox.Location = new System.Drawing.Point(18, 294);
            this.ampersandCheckBox.Name = "ampersandCheckBox";
            this.ampersandCheckBox.Size = new System.Drawing.Size(40, 24);
            this.ampersandCheckBox.TabIndex = 11;
            this.ampersandCheckBox.Text = "&&";
            this.ampersandCheckBox.UseVisualStyleBackColor = true;
            // 
            // caratCheckBox
            // 
            this.caratCheckBox.AutoSize = true;
            this.caratCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caratCheckBox.Location = new System.Drawing.Point(18, 271);
            this.caratCheckBox.Name = "caratCheckBox";
            this.caratCheckBox.Size = new System.Drawing.Size(36, 24);
            this.caratCheckBox.TabIndex = 10;
            this.caratCheckBox.Text = "^";
            this.caratCheckBox.UseVisualStyleBackColor = true;
            // 
            // percentCheckBox
            // 
            this.percentCheckBox.AutoSize = true;
            this.percentCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentCheckBox.Location = new System.Drawing.Point(18, 248);
            this.percentCheckBox.Name = "percentCheckBox";
            this.percentCheckBox.Size = new System.Drawing.Size(43, 24);
            this.percentCheckBox.TabIndex = 9;
            this.percentCheckBox.Text = "%";
            this.percentCheckBox.UseVisualStyleBackColor = true;
            // 
            // dollarCheckBox
            // 
            this.dollarCheckBox.AutoSize = true;
            this.dollarCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarCheckBox.Location = new System.Drawing.Point(18, 225);
            this.dollarCheckBox.Name = "dollarCheckBox";
            this.dollarCheckBox.Size = new System.Drawing.Size(38, 24);
            this.dollarCheckBox.TabIndex = 8;
            this.dollarCheckBox.Text = "$";
            this.dollarCheckBox.UseVisualStyleBackColor = true;
            // 
            // hashCheckBox
            // 
            this.hashCheckBox.AutoSize = true;
            this.hashCheckBox.Checked = true;
            this.hashCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hashCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashCheckBox.Location = new System.Drawing.Point(18, 202);
            this.hashCheckBox.Name = "hashCheckBox";
            this.hashCheckBox.Size = new System.Drawing.Size(38, 24);
            this.hashCheckBox.TabIndex = 7;
            this.hashCheckBox.Text = "#";
            this.hashCheckBox.UseVisualStyleBackColor = true;
            // 
            // atCheckBox
            // 
            this.atCheckBox.AutoSize = true;
            this.atCheckBox.Checked = true;
            this.atCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.atCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atCheckBox.Location = new System.Drawing.Point(18, 179);
            this.atCheckBox.Name = "atCheckBox";
            this.atCheckBox.Size = new System.Drawing.Size(45, 24);
            this.atCheckBox.TabIndex = 6;
            this.atCheckBox.Text = "@";
            this.atCheckBox.UseVisualStyleBackColor = true;
            // 
            // exclamationCheckBox
            // 
            this.exclamationCheckBox.AutoSize = true;
            this.exclamationCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exclamationCheckBox.Location = new System.Drawing.Point(18, 156);
            this.exclamationCheckBox.Name = "exclamationCheckBox";
            this.exclamationCheckBox.Size = new System.Drawing.Size(33, 24);
            this.exclamationCheckBox.TabIndex = 5;
            this.exclamationCheckBox.Text = "!";
            this.exclamationCheckBox.UseVisualStyleBackColor = true;
            // 
            // tackCheckbox
            // 
            this.tackCheckbox.AutoSize = true;
            this.tackCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tackCheckbox.Location = new System.Drawing.Point(18, 133);
            this.tackCheckbox.Name = "tackCheckbox";
            this.tackCheckbox.Size = new System.Drawing.Size(34, 24);
            this.tackCheckbox.TabIndex = 4;
            this.tackCheckbox.Text = "`";
            this.tackCheckbox.UseVisualStyleBackColor = true;
            // 
            // tildeCheckbox
            // 
            this.tildeCheckbox.AutoSize = true;
            this.tildeCheckbox.Checked = true;
            this.tildeCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tildeCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tildeCheckbox.Location = new System.Drawing.Point(18, 110);
            this.tildeCheckbox.Name = "tildeCheckbox";
            this.tildeCheckbox.Size = new System.Drawing.Size(38, 24);
            this.tildeCheckbox.TabIndex = 3;
            this.tildeCheckbox.Text = "~";
            this.tildeCheckbox.UseVisualStyleBackColor = true;
            // 
            // numbersCheckbox
            // 
            this.numbersCheckbox.AutoSize = true;
            this.numbersCheckbox.Checked = true;
            this.numbersCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numbersCheckbox.Location = new System.Drawing.Point(28, 103);
            this.numbersCheckbox.Name = "numbersCheckbox";
            this.numbersCheckbox.Size = new System.Drawing.Size(149, 17);
            this.numbersCheckbox.TabIndex = 6;
            this.numbersCheckbox.Text = "Include numbers (e.g. 0-9)";
            this.numbersCheckbox.UseVisualStyleBackColor = true;
            // 
            // lowerCaseCheckBox
            // 
            this.lowerCaseCheckBox.AutoSize = true;
            this.lowerCaseCheckBox.Checked = true;
            this.lowerCaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowerCaseCheckBox.Location = new System.Drawing.Point(28, 164);
            this.lowerCaseCheckBox.Name = "lowerCaseCheckBox";
            this.lowerCaseCheckBox.Size = new System.Drawing.Size(187, 17);
            this.lowerCaseCheckBox.TabIndex = 7;
            this.lowerCaseCheckBox.Text = "Include lowercase letters (e.g. a-z)";
            this.lowerCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // upperCaseCheckBox
            // 
            this.upperCaseCheckBox.AutoSize = true;
            this.upperCaseCheckBox.Checked = true;
            this.upperCaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.upperCaseCheckBox.Location = new System.Drawing.Point(28, 233);
            this.upperCaseCheckBox.Name = "upperCaseCheckBox";
            this.upperCaseCheckBox.Size = new System.Drawing.Size(192, 17);
            this.upperCaseCheckBox.TabIndex = 8;
            this.upperCaseCheckBox.Text = "Include uppercase letters (e.g. A-Z)";
            this.upperCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(245, 351);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 9;
            this.generateButton.Text = "Generate!";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(159, 389);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(266, 20);
            this.passwordTextBox.TabIndex = 10;
            this.passwordTextBox.Text = "Your password will appear here.";
            // 
            // passwordLength
            // 
            this.passwordLength.Location = new System.Drawing.Point(28, 61);
            this.passwordLength.Name = "passwordLength";
            this.passwordLength.Size = new System.Drawing.Size(100, 20);
            this.passwordLength.TabIndex = 11;
            this.passwordLength.Text = "24";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(28, 42);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(89, 13);
            this.lengthLabel.TabIndex = 12;
            this.lengthLabel.Text = "Password Length";
            // 
            // autoClipboardCheckBox
            // 
            this.autoClipboardCheckBox.AutoSize = true;
            this.autoClipboardCheckBox.Checked = true;
            this.autoClipboardCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoClipboardCheckBox.Location = new System.Drawing.Point(28, 295);
            this.autoClipboardCheckBox.Name = "autoClipboardCheckBox";
            this.autoClipboardCheckBox.Size = new System.Drawing.Size(220, 17);
            this.autoClipboardCheckBox.TabIndex = 13;
            this.autoClipboardCheckBox.Text = "Automatically send password to clipboard";
            this.autoClipboardCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 436);
            this.Controls.Add(this.autoClipboardCheckBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.passwordLength);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.upperCaseCheckBox);
            this.Controls.Add(this.lowerCaseCheckBox);
            this.Controls.Add(this.numbersCheckbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(625, 474);
            this.MinimumSize = new System.Drawing.Size(600, 425);
            this.Name = "Form1";
            this.Text = "Random Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton includeSymbols;
        private System.Windows.Forms.RadioButton excludeSymbols;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ampersandCheckBox;
        private System.Windows.Forms.CheckBox caratCheckBox;
        private System.Windows.Forms.CheckBox percentCheckBox;
        private System.Windows.Forms.CheckBox dollarCheckBox;
        private System.Windows.Forms.CheckBox hashCheckBox;
        private System.Windows.Forms.CheckBox atCheckBox;
        private System.Windows.Forms.CheckBox exclamationCheckBox;     
        private System.Windows.Forms.CheckBox tackCheckbox;
        private System.Windows.Forms.CheckBox tildeCheckbox;
        private System.Windows.Forms.CheckBox forwardSlashCheckBox;
        private System.Windows.Forms.CheckBox questionMarkCheckBox;
        private System.Windows.Forms.CheckBox periodCheckBox;
        private System.Windows.Forms.CheckBox commaCheckBox;
        private System.Windows.Forms.CheckBox angleBracketsCheckBox;
        private System.Windows.Forms.CheckBox semicolonCheckBox;
        private System.Windows.Forms.CheckBox colonCheckBox;
        private System.Windows.Forms.CheckBox backslashCheckBox;
        private System.Windows.Forms.CheckBox pipeCheckBox;
        private System.Windows.Forms.CheckBox bracketsCheckBox;
        private System.Windows.Forms.CheckBox bracesCheckBox;
        private System.Windows.Forms.CheckBox equalsCheckBox;
        private System.Windows.Forms.CheckBox plusCheckBox;
        private System.Windows.Forms.CheckBox emDashCheckBox;
        private System.Windows.Forms.CheckBox dashCheckBox;
        private System.Windows.Forms.CheckBox paranthesesCheckBox;
        private System.Windows.Forms.CheckBox splatCheckBox;
        private System.Windows.Forms.CheckBox numbersCheckbox;
        private System.Windows.Forms.CheckBox lowerCaseCheckBox;
        private System.Windows.Forms.CheckBox upperCaseCheckBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox doublequoteCheckBox;
        private System.Windows.Forms.TextBox passwordLength;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.RadioButton exludeAll;
        private System.Windows.Forms.RadioButton includeAll;
        private System.Windows.Forms.CheckBox autoClipboardCheckBox;
    }
}

