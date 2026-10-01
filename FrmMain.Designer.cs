namespace GUI26100102
{
    partial class FrmMain
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
            txt1stOp = new TextBox();
            lblInfo01 = new Label();
            txt2nbOp = new TextBox();
            lblInfo02 = new Label();
            txtResult = new TextBox();
            lblInfo03 = new Label();
            btnAdd = new Button();
            btnSub = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // txt1stOp
            // 
            txt1stOp.Location = new Point(24, 62);
            txt1stOp.Margin = new Padding(15, 3, 3, 3);
            txt1stOp.Name = "txt1stOp";
            txt1stOp.Size = new Size(100, 32);
            txt1stOp.TabIndex = 0;
            // 
            // lblInfo01
            // 
            lblInfo01.AutoSize = true;
            lblInfo01.Font = new Font("Segoe UI", 10F);
            lblInfo01.Location = new Point(24, 40);
            lblInfo01.Name = "lblInfo01";
            lblInfo01.Size = new Size(78, 19);
            lblInfo01.TabIndex = 1;
            lblInfo01.Text = "1ˢᵗ operand";
            // 
            // txt2nbOp
            // 
            txt2nbOp.Location = new Point(217, 62);
            txt2nbOp.Margin = new Padding(3, 3, 15, 3);
            txt2nbOp.Name = "txt2nbOp";
            txt2nbOp.Size = new Size(100, 32);
            txt2nbOp.TabIndex = 0;
            // 
            // lblInfo02
            // 
            lblInfo02.AutoSize = true;
            lblInfo02.Font = new Font("Segoe UI", 10F);
            lblInfo02.Location = new Point(217, 40);
            lblInfo02.Name = "lblInfo02";
            lblInfo02.Size = new Size(82, 19);
            lblInfo02.TabIndex = 1;
            lblInfo02.Text = "2ⁿᵈ operand";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(131, 332);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(81, 32);
            txtResult.TabIndex = 0;
            // 
            // lblInfo03
            // 
            lblInfo03.AutoSize = true;
            lblInfo03.Font = new Font("Segoe UI", 10F);
            lblInfo03.Location = new Point(150, 310);
            lblInfo03.Name = "lblInfo03";
            lblInfo03.Size = new Size(43, 19);
            lblInfo03.TabIndex = 1;
            lblInfo03.Text = "result";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 162);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(147, 41);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "addition";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(182, 162);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(147, 41);
            btnSub.TabIndex = 2;
            btnSub.Text = "subtraction";
            btnSub.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(12, 223);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(147, 41);
            btnMult.TabIndex = 2;
            btnMult.Text = "multiplication";
            btnMult.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(182, 223);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(147, 41);
            btnDiv.TabIndex = 2;
            btnDiv.Text = "division";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 395);
            Controls.Add(btnDiv);
            Controls.Add(btnSub);
            Controls.Add(btnMult);
            Controls.Add(btnAdd);
            Controls.Add(lblInfo02);
            Controls.Add(lblInfo03);
            Controls.Add(lblInfo01);
            Controls.Add(txt2nbOp);
            Controls.Add(txtResult);
            Controls.Add(txt1stOp);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FrmMain";
            Text = "calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1stOp;
        private Label lblInfo01;
        private TextBox txt2nbOp;
        private Label lblInfo02;
        private TextBox txtResult;
        private Label lblInfo03;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMult;
        private Button btnDiv;
    }
}
