
namespace GadgetBD
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.btnPayBkash = new System.Windows.Forms.Button();
            this.btnPayNagad = new System.Windows.Forms.Button();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPayBkash
            // 
            this.btnPayBkash.Image = ((System.Drawing.Image)(resources.GetObject("btnPayBkash.Image")));
            this.btnPayBkash.Location = new System.Drawing.Point(107, 112);
            this.btnPayBkash.Name = "btnPayBkash";
            this.btnPayBkash.Size = new System.Drawing.Size(147, 134);
            this.btnPayBkash.TabIndex = 0;
            this.btnPayBkash.UseVisualStyleBackColor = true;
            this.btnPayBkash.Click += new System.EventHandler(this.btnPayBkash_Click);
            // 
            // btnPayNagad
            // 
            this.btnPayNagad.Image = ((System.Drawing.Image)(resources.GetObject("btnPayNagad.Image")));
            this.btnPayNagad.Location = new System.Drawing.Point(432, 112);
            this.btnPayNagad.Name = "btnPayNagad";
            this.btnPayNagad.Size = new System.Drawing.Size(147, 134);
            this.btnPayNagad.TabIndex = 1;
            this.btnPayNagad.UseVisualStyleBackColor = true;
            this.btnPayNagad.Click += new System.EventHandler(this.btnPayNagad_Click);
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.btnConfirmPayment.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment.Location = new System.Drawing.Point(263, 306);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(174, 54);
            this.btnConfirmPayment.TabIndex = 2;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(607, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 67);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUser
            // 
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.Location = new System.Drawing.Point(12, 8);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(61, 56);
            this.btnUser.TabIndex = 4;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(188)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.btnPayNagad);
            this.Controls.Add(this.btnPayBkash);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPayBkash;
        private System.Windows.Forms.Button btnPayNagad;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUser;
    }
}