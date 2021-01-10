
namespace TestingGenerateWinformProject
{
    partial class LoginDBForm
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
            this.components = new System.ComponentModel.Container();
            this.lbServerName = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbSelectDB = new System.Windows.Forms.Label();
            this.cbSelectDB = new System.Windows.Forms.ComboBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbServerName = new System.Windows.Forms.TextBox();
            this.bindingSourceLoginDB = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLoginDB)).BeginInit();
            this.SuspendLayout();
            // 
            // lbServerName
            // 
            this.lbServerName.AutoSize = true;
            this.lbServerName.Location = new System.Drawing.Point(65, 53);
            this.lbServerName.Name = "lbServerName";
            this.lbServerName.Size = new System.Drawing.Size(95, 17);
            this.lbServerName.TabIndex = 0;
            this.lbServerName.Text = "Server Name:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(77, 101);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(42, 17);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "User:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(209, 98);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(309, 22);
            this.tbUserName.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(209, 151);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(309, 22);
            this.tbPassword.TabIndex = 4;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(77, 154);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(73, 17);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password:";
            // 
            // lbSelectDB
            // 
            this.lbSelectDB.AutoSize = true;
            this.lbSelectDB.Location = new System.Drawing.Point(65, 259);
            this.lbSelectDB.Name = "lbSelectDB";
            this.lbSelectDB.Size = new System.Drawing.Size(116, 17);
            this.lbSelectDB.TabIndex = 6;
            this.lbSelectDB.Text = "Select Database:";
            // 
            // cbSelectDB
            // 
            this.cbSelectDB.FormattingEnabled = true;
            this.cbSelectDB.Location = new System.Drawing.Point(209, 256);
            this.cbSelectDB.Name = "cbSelectDB";
            this.cbSelectDB.Size = new System.Drawing.Size(309, 24);
            this.cbSelectDB.TabIndex = 7;
            this.cbSelectDB.DropDown += new System.EventHandler(this.cbSelectDB_DropDown);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(53, 328);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(128, 34);
            this.btnTestConnection.TabIndex = 8;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(316, 328);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(107, 34);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(446, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbServerName
            // 
            this.tbServerName.Location = new System.Drawing.Point(209, 50);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(309, 22);
            this.tbServerName.TabIndex = 11;
            // 
            // LoginDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 396);
            this.Controls.Add(this.tbServerName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.cbSelectDB);
            this.Controls.Add(this.lbSelectDB);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbServerName);
            this.Name = "LoginDBForm";
            this.Text = "LoginDBForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLoginDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbServerName;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbSelectDB;
        private System.Windows.Forms.ComboBox cbSelectDB;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbServerName;
        private System.Windows.Forms.BindingSource bindingSourceLoginDB;
    }
}