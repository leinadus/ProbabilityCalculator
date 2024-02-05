namespace ProbabilityCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_percent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_attempts = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_enhance = new System.Windows.Forms.Button();
            this.lbl_odds = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_successes = new System.Windows.Forms.Label();
            this.lbl_fails = new System.Windows.Forms.Label();
            this.lbl_attempts = new System.Windows.Forms.Label();
            this.lbl_successRate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tekton Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Probability Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_percent
            // 
            this.tb_percent.Location = new System.Drawing.Point(160, 82);
            this.tb_percent.Name = "tb_percent";
            this.tb_percent.Size = new System.Drawing.Size(99, 20);
            this.tb_percent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Probability in %";
            // 
            // tb_attempts
            // 
            this.tb_attempts.Location = new System.Drawing.Point(160, 120);
            this.tb_attempts.Name = "tb_attempts";
            this.tb_attempts.Size = new System.Drawing.Size(99, 20);
            this.tb_attempts.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of attempts";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(124, 161);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 5;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(63, 389);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 14;
            this.btn_reset.Text = "Reset";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click_1);
            // 
            // btn_enhance
            // 
            this.btn_enhance.Location = new System.Drawing.Point(195, 389);
            this.btn_enhance.Name = "btn_enhance";
            this.btn_enhance.Size = new System.Drawing.Size(75, 23);
            this.btn_enhance.TabIndex = 12;
            this.btn_enhance.Text = "Enhance";
            this.btn_enhance.UseVisualStyleBackColor = true;
            this.btn_enhance.Click += new System.EventHandler(this.Btn_enhance_Click);
            // 
            // lbl_odds
            // 
            this.lbl_odds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_odds.Location = new System.Drawing.Point(64, 199);
            this.lbl_odds.Name = "lbl_odds";
            this.lbl_odds.Size = new System.Drawing.Size(195, 13);
            this.lbl_odds.TabIndex = 13;
            this.lbl_odds.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(64, 248);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(195, 13);
            this.lbl_result.TabIndex = 6;
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_successes
            // 
            this.lbl_successes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_successes.Location = new System.Drawing.Point(64, 280);
            this.lbl_successes.Name = "lbl_successes";
            this.lbl_successes.Size = new System.Drawing.Size(195, 13);
            this.lbl_successes.TabIndex = 7;
            this.lbl_successes.Text = "Successes: 0";
            this.lbl_successes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_fails
            // 
            this.lbl_fails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fails.Location = new System.Drawing.Point(64, 303);
            this.lbl_fails.Name = "lbl_fails";
            this.lbl_fails.Size = new System.Drawing.Size(195, 13);
            this.lbl_fails.TabIndex = 8;
            this.lbl_fails.Text = "Fails: 0";
            this.lbl_fails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_attempts
            // 
            this.lbl_attempts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_attempts.Location = new System.Drawing.Point(64, 326);
            this.lbl_attempts.Name = "lbl_attempts";
            this.lbl_attempts.Size = new System.Drawing.Size(195, 13);
            this.lbl_attempts.TabIndex = 9;
            this.lbl_attempts.Text = "Attempts: 0";
            this.lbl_attempts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_successRate
            // 
            this.lbl_successRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_successRate.Location = new System.Drawing.Point(64, 349);
            this.lbl_successRate.Name = "lbl_successRate";
            this.lbl_successRate.Size = new System.Drawing.Size(195, 13);
            this.lbl_successRate.TabIndex = 10;
            this.lbl_successRate.Text = "Success Rate: 0.00%";
            this.lbl_successRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 424);
            this.Controls.Add(this.lbl_odds);
            this.Controls.Add(this.btn_enhance);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_successRate);
            this.Controls.Add(this.lbl_attempts);
            this.Controls.Add(this.lbl_fails);
            this.Controls.Add(this.lbl_successes);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_attempts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_percent);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 463);
            this.MinimumSize = new System.Drawing.Size(350, 463);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Probability Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_percent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_attempts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_enhance;
        private System.Windows.Forms.Label lbl_odds;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_successes;
        private System.Windows.Forms.Label lbl_fails;
        private System.Windows.Forms.Label lbl_attempts;
        private System.Windows.Forms.Label lbl_successRate;
    }
}

