namespace ATMWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textCardNumber = new System.Windows.Forms.TextBox();
            this.butNumContinue = new System.Windows.Forms.Button();
            this.labelCard = new System.Windows.Forms.Label();
            this.labelPIN = new System.Windows.Forms.Label();
            this.textPIN = new System.Windows.Forms.TextBox();
            this.butPINContinue = new System.Windows.Forms.Button();
            this.butBalance = new System.Windows.Forms.Button();
            this.butWithdraw = new System.Windows.Forms.Button();
            this.butPutMoney = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.labelCommon = new System.Windows.Forms.Label();
            this.labSum = new System.Windows.Forms.Label();
            this.textSum = new System.Windows.Forms.TextBox();
            this.butStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCardNumber
            // 
            this.textCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCardNumber.Location = new System.Drawing.Point(583, 284);
            this.textCardNumber.MaxLength = 16;
            this.textCardNumber.Name = "textCardNumber";
            this.textCardNumber.ShortcutsEnabled = false;
            this.textCardNumber.Size = new System.Drawing.Size(174, 24);
            this.textCardNumber.TabIndex = 0;
            this.textCardNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCardNumber_KeyDown);
            this.textCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCardNumber_KeyPress);
            // 
            // butNumContinue
            // 
            this.butNumContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butNumContinue.BackColor = System.Drawing.SystemColors.Control;
            this.butNumContinue.Location = new System.Drawing.Point(583, 334);
            this.butNumContinue.Name = "butNumContinue";
            this.butNumContinue.Size = new System.Drawing.Size(174, 66);
            this.butNumContinue.TabIndex = 1;
            this.butNumContinue.Text = "Продолжить";
            this.butNumContinue.UseVisualStyleBackColor = false;
            this.butNumContinue.Click += new System.EventHandler(this.butNumContinue_Click);
            // 
            // labelCard
            // 
            this.labelCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCard.AutoSize = true;
            this.labelCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCard.Location = new System.Drawing.Point(580, 247);
            this.labelCard.Name = "labelCard";
            this.labelCard.Size = new System.Drawing.Size(177, 20);
            this.labelCard.TabIndex = 2;
            this.labelCard.Text = "Введите номер карты";
            // 
            // labelPIN
            // 
            this.labelPIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPIN.AutoSize = true;
            this.labelPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPIN.Location = new System.Drawing.Point(12, 247);
            this.labelPIN.Name = "labelPIN";
            this.labelPIN.Size = new System.Drawing.Size(106, 20);
            this.labelPIN.TabIndex = 3;
            this.labelPIN.Text = "Введите PIN";
            this.labelPIN.Visible = false;
            // 
            // textPIN
            // 
            this.textPIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPIN.Location = new System.Drawing.Point(12, 284);
            this.textPIN.MaxLength = 4;
            this.textPIN.Name = "textPIN";
            this.textPIN.PasswordChar = '•';
            this.textPIN.ShortcutsEnabled = false;
            this.textPIN.Size = new System.Drawing.Size(174, 35);
            this.textPIN.TabIndex = 4;
            this.textPIN.Visible = false;
            this.textPIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPIN_KeyDown);
            this.textPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPIN_KeyPress);
            // 
            // butPINContinue
            // 
            this.butPINContinue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.butPINContinue.Location = new System.Drawing.Point(12, 326);
            this.butPINContinue.Name = "butPINContinue";
            this.butPINContinue.Size = new System.Drawing.Size(174, 74);
            this.butPINContinue.TabIndex = 5;
            this.butPINContinue.Text = "Продолжить";
            this.butPINContinue.UseVisualStyleBackColor = true;
            this.butPINContinue.Visible = false;
            this.butPINContinue.Click += new System.EventHandler(this.butPINContinue_Click);
            // 
            // butBalance
            // 
            this.butBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butBalance.Location = new System.Drawing.Point(275, 12);
            this.butBalance.Name = "butBalance";
            this.butBalance.Size = new System.Drawing.Size(219, 57);
            this.butBalance.TabIndex = 7;
            this.butBalance.Text = "Баланс";
            this.butBalance.UseVisualStyleBackColor = true;
            this.butBalance.Visible = false;
            this.butBalance.Click += new System.EventHandler(this.butBalance_Click);
            // 
            // butWithdraw
            // 
            this.butWithdraw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butWithdraw.Location = new System.Drawing.Point(275, 93);
            this.butWithdraw.Name = "butWithdraw";
            this.butWithdraw.Size = new System.Drawing.Size(219, 57);
            this.butWithdraw.TabIndex = 8;
            this.butWithdraw.Text = "Снять деньги";
            this.butWithdraw.UseVisualStyleBackColor = true;
            this.butWithdraw.Visible = false;
            this.butWithdraw.Click += new System.EventHandler(this.butWithdraw_Click);
            // 
            // butPutMoney
            // 
            this.butPutMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butPutMoney.Location = new System.Drawing.Point(275, 167);
            this.butPutMoney.Name = "butPutMoney";
            this.butPutMoney.Size = new System.Drawing.Size(219, 57);
            this.butPutMoney.TabIndex = 9;
            this.butPutMoney.Text = "Положить деньги";
            this.butPutMoney.UseVisualStyleBackColor = true;
            this.butPutMoney.Visible = false;
            this.butPutMoney.Click += new System.EventHandler(this.butPutMoney_Click);
            // 
            // butExit
            // 
            this.butExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butExit.AutoSize = true;
            this.butExit.BackColor = System.Drawing.Color.Red;
            this.butExit.ForeColor = System.Drawing.Color.Black;
            this.butExit.Location = new System.Drawing.Point(616, 12);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(129, 66);
            this.butExit.TabIndex = 10;
            this.butExit.Text = "Завершить работу";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // labelCommon
            // 
            this.labelCommon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCommon.Location = new System.Drawing.Point(275, 333);
            this.labelCommon.Name = "labelCommon";
            this.labelCommon.Size = new System.Drawing.Size(277, 86);
            this.labelCommon.TabIndex = 11;
            this.labelCommon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labSum
            // 
            this.labSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSum.Location = new System.Drawing.Point(275, 233);
            this.labSum.Name = "labSum";
            this.labSum.Size = new System.Drawing.Size(219, 32);
            this.labSum.TabIndex = 12;
            this.labSum.Text = "Введите сумму";
            this.labSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labSum.Visible = false;
            // 
            // textSum
            // 
            this.textSum.Location = new System.Drawing.Point(318, 268);
            this.textSum.MaxLength = 6;
            this.textSum.Name = "textSum";
            this.textSum.ShortcutsEnabled = false;
            this.textSum.Size = new System.Drawing.Size(130, 20);
            this.textSum.TabIndex = 13;
            this.textSum.Visible = false;
            this.textSum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSum_KeyDown);
            this.textSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSum_KeyPress);
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(16, 13);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(170, 65);
            this.butStart.TabIndex = 14;
            this.butStart.Text = "В начало";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 436);
            this.ControlBox = false;
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.textSum);
            this.Controls.Add(this.labSum);
            this.Controls.Add(this.labelCommon);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butPutMoney);
            this.Controls.Add(this.butWithdraw);
            this.Controls.Add(this.butBalance);
            this.Controls.Add(this.butPINContinue);
            this.Controls.Add(this.textPIN);
            this.Controls.Add(this.labelPIN);
            this.Controls.Add(this.labelCard);
            this.Controls.Add(this.butNumContinue);
            this.Controls.Add(this.textCardNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCardNumber;
        private System.Windows.Forms.Button butNumContinue;
        private System.Windows.Forms.Label labelCard;
        private System.Windows.Forms.Label labelPIN;
        private System.Windows.Forms.TextBox textPIN;
        private System.Windows.Forms.Button butPINContinue;
        private System.Windows.Forms.Button butBalance;
        private System.Windows.Forms.Button butWithdraw;
        private System.Windows.Forms.Button butPutMoney;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label labelCommon;
        private System.Windows.Forms.Label labSum;
        private System.Windows.Forms.TextBox textSum;
        private System.Windows.Forms.Button butStart;
    }
}

