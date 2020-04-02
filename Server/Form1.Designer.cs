namespace Server
{
    partial class ServerForm
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtMsgRecieve = new System.Windows.Forms.RichTextBox();
            this.List_Clients = new System.Windows.Forms.CheckedListBox();
            this.btn_Send_Selected = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSend.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSend.Location = new System.Drawing.Point(288, 361);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(133, 57);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Broadcast Message";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMsg.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtMsg.Location = new System.Drawing.Point(12, 453);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(270, 32);
            this.txtMsg.TabIndex = 2;
            // 
            // txtMsgRecieve
            // 
            this.txtMsgRecieve.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMsgRecieve.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtMsgRecieve.Location = new System.Drawing.Point(12, 47);
            this.txtMsgRecieve.Name = "txtMsgRecieve";
            this.txtMsgRecieve.Size = new System.Drawing.Size(270, 391);
            this.txtMsgRecieve.TabIndex = 3;
            this.txtMsgRecieve.Text = "";
            // 
            // List_Clients
            // 
            this.List_Clients.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.List_Clients.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.List_Clients.FormattingEnabled = true;
            this.List_Clients.Location = new System.Drawing.Point(288, 47);
            this.List_Clients.Name = "List_Clients";
            this.List_Clients.Size = new System.Drawing.Size(133, 304);
            this.List_Clients.TabIndex = 4;
            this.List_Clients.SelectedIndexChanged += new System.EventHandler(this.List_Clients_SelectedIndexChanged);
            // 
            // btn_Send_Selected
            // 
            this.btn_Send_Selected.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Send_Selected.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send_Selected.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Send_Selected.Location = new System.Drawing.Point(288, 424);
            this.btn_Send_Selected.Name = "btn_Send_Selected";
            this.btn_Send_Selected.Size = new System.Drawing.Size(136, 61);
            this.btn_Send_Selected.TabIndex = 5;
            this.btn_Send_Selected.Text = "Send Message To Selected Client";
            this.btn_Send_Selected.UseVisualStyleBackColor = false;
            this.btn_Send_Selected.Click += new System.EventHandler(this.btn_Send_Selected_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbl.Location = new System.Drawing.Point(176, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(79, 28);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Server";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(436, 495);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn_Send_Selected);
            this.Controls.Add(this.List_Clients);
            this.Controls.Add(this.txtMsgRecieve);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnSend);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.RichTextBox txtMsgRecieve;
        public System.Windows.Forms.CheckedListBox List_Clients;
        private System.Windows.Forms.Button btn_Send_Selected;
        private System.Windows.Forms.Label lbl;
    }
}

