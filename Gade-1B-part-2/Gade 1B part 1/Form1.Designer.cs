namespace GADE6112_POE
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
            this.RedOutput = new System.Windows.Forms.RichTextBox();
            this.CmbListOfEnemies = new System.Windows.Forms.ComboBox();
            this.AttackButton = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.bntUp = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.redPlayArea = new System.Windows.Forms.RichTextBox();
            this.redEnemies = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RedOutput
            // 
            this.RedOutput.Location = new System.Drawing.Point(1252, 455);
            this.RedOutput.Margin = new System.Windows.Forms.Padding(4);
            this.RedOutput.Name = "RedOutput";
            this.RedOutput.Size = new System.Drawing.Size(348, 350);
            this.RedOutput.TabIndex = 18;
            this.RedOutput.Text = "";
            // 
            // CmbListOfEnemies
            // 
            this.CmbListOfEnemies.FormattingEnabled = true;
            this.CmbListOfEnemies.Location = new System.Drawing.Point(1331, 391);
            this.CmbListOfEnemies.Margin = new System.Windows.Forms.Padding(4);
            this.CmbListOfEnemies.Name = "CmbListOfEnemies";
            this.CmbListOfEnemies.Size = new System.Drawing.Size(435, 33);
            this.CmbListOfEnemies.TabIndex = 17;
            // 
            // AttackButton
            // 
            this.AttackButton.Location = new System.Drawing.Point(1628, 455);
            this.AttackButton.Margin = new System.Windows.Forms.Padding(2);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(201, 176);
            this.AttackButton.TabIndex = 16;
            this.AttackButton.Text = "Attack";
            this.AttackButton.UseVisualStyleBackColor = true;
            this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(1613, 254);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(112, 34);
            this.btnRight.TabIndex = 15;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(1374, 254);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(112, 34);
            this.btnLeft.TabIndex = 14;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(1497, 304);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(112, 34);
            this.btnDown.TabIndex = 13;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // bntUp
            // 
            this.bntUp.Location = new System.Drawing.Point(1497, 206);
            this.bntUp.Margin = new System.Windows.Forms.Padding(2);
            this.bntUp.Name = "bntUp";
            this.bntUp.Size = new System.Drawing.Size(112, 34);
            this.bntUp.TabIndex = 12;
            this.bntUp.Text = "Up";
            this.bntUp.UseVisualStyleBackColor = true;
            this.bntUp.Click += new System.EventHandler(this.bntUp_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1488, 110);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 34);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // redPlayArea
            // 
            this.redPlayArea.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.redPlayArea.Location = new System.Drawing.Point(103, 110);
            this.redPlayArea.Margin = new System.Windows.Forms.Padding(2);
            this.redPlayArea.Name = "redPlayArea";
            this.redPlayArea.Size = new System.Drawing.Size(1095, 1058);
            this.redPlayArea.TabIndex = 10;
            this.redPlayArea.Text = "";
            // 
            // redEnemies
            // 
            this.redEnemies.Location = new System.Drawing.Point(1252, 849);
            this.redEnemies.Margin = new System.Windows.Forms.Padding(4);
            this.redEnemies.Name = "redEnemies";
            this.redEnemies.Size = new System.Drawing.Size(348, 319);
            this.redEnemies.TabIndex = 19;
            this.redEnemies.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1710, 849);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 67);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save Game";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1710, 943);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(151, 67);
            this.btnLoad.TabIndex = 21;
            this.btnLoad.Text = "Load Game";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 1312);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.redEnemies);
            this.Controls.Add(this.RedOutput);
            this.Controls.Add(this.CmbListOfEnemies);
            this.Controls.Add(this.AttackButton);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.bntUp);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.redPlayArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox RedOutput;
        private ComboBox CmbListOfEnemies;
        private Button AttackButton;
        private Button btnRight;
        private Button btnLeft;
        private Button btnDown;
        private Button bntUp;
        private Button btnStart;
        private RichTextBox redPlayArea;
        private RichTextBox redEnemies;
        private Button btnSave;
        private Button btnLoad;
    }
}