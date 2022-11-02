namespace Craps
{
    partial class frmMain
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
            this.lblDice1 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblOutCome = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDice1
            // 
            this.lblDice1.AutoSize = true;
            this.lblDice1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDice1.Location = new System.Drawing.Point(174, 86);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(0, 30);
            this.lblDice1.TabIndex = 0;
            // 
            // lblDice2
            // 
            this.lblDice2.AutoSize = true;
            this.lblDice2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDice2.Location = new System.Drawing.Point(241, 86);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(0, 30);
            this.lblDice2.TabIndex = 0;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBank.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBank.Location = new System.Drawing.Point(12, 9);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(58, 34);
            this.lblBank.TabIndex = 2;
            this.lblBank.Text = "100";
            this.lblBank.Click += new System.EventHandler(this.lblBank_Click);
            // 
            // txtBet
            // 
            this.txtBet.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBet.Location = new System.Drawing.Point(10, 169);
            this.txtBet.Name = "txtBet";
            this.txtBet.PlaceholderText = "Enter your bet";
            this.txtBet.Size = new System.Drawing.Size(164, 39);
            this.txtBet.TabIndex = 3;
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRoll.Location = new System.Drawing.Point(12, 66);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(117, 68);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblOutCome
            // 
            this.lblOutCome.AutoSize = true;
            this.lblOutCome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutCome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutCome.Location = new System.Drawing.Point(203, 248);
            this.lblOutCome.Name = "lblOutCome";
            this.lblOutCome.Size = new System.Drawing.Size(79, 34);
            this.lblOutCome.TabIndex = 5;
            this.lblOutCome.Text = "Score";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPoints.Location = new System.Drawing.Point(26, 248);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(0, 32);
            this.lblPoints.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 304);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblOutCome);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.lblDice2);
            this.Controls.Add(this.lblDice1);
            this.Name = "frmMain";
            this.Text = "Craps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDice1;
        private Label lblDice2;
        private Label lblBank;
        private TextBox txtBet;
        private Button btnRoll;
        private Label lblOutCome;
        private Label lblPoints;
    }
}