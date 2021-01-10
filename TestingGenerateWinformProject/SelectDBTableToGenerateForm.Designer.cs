
namespace TestingGenerateWinformProject
{
    partial class SelectDBTableToGenerateForm
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
            this.btnConnectDB = new System.Windows.Forms.Button();
            this.listBoxDBTable = new System.Windows.Forms.ListBox();
            this.btnStartGenerate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbProjectName = new System.Windows.Forms.Label();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.lbSolutionName = new System.Windows.Forms.Label();
            this.tbSolutionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnectDB
            // 
            this.btnConnectDB.Location = new System.Drawing.Point(12, 12);
            this.btnConnectDB.Name = "btnConnectDB";
            this.btnConnectDB.Size = new System.Drawing.Size(129, 37);
            this.btnConnectDB.TabIndex = 0;
            this.btnConnectDB.Text = "Connect DB";
            this.btnConnectDB.UseVisualStyleBackColor = true;
            // 
            // listBoxDBTable
            // 
            this.listBoxDBTable.FormattingEnabled = true;
            this.listBoxDBTable.ItemHeight = 16;
            this.listBoxDBTable.Location = new System.Drawing.Point(12, 99);
            this.listBoxDBTable.Name = "listBoxDBTable";
            this.listBoxDBTable.Size = new System.Drawing.Size(986, 308);
            this.listBoxDBTable.TabIndex = 1;
            // 
            // btnStartGenerate
            // 
            this.btnStartGenerate.Location = new System.Drawing.Point(740, 607);
            this.btnStartGenerate.Name = "btnStartGenerate";
            this.btnStartGenerate.Size = new System.Drawing.Size(129, 37);
            this.btnStartGenerate.TabIndex = 2;
            this.btnStartGenerate.Text = "Generate";
            this.btnStartGenerate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(892, 607);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(146, 522);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(577, 22);
            this.tbLocation.TabIndex = 4;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(63, 525);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(66, 17);
            this.lbLocation.TabIndex = 5;
            this.lbLocation.Text = "Location:";
            // 
            // lbProjectName
            // 
            this.lbProjectName.AutoSize = true;
            this.lbProjectName.Location = new System.Drawing.Point(32, 436);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(97, 17);
            this.lbProjectName.TabIndex = 6;
            this.lbProjectName.Text = "Project Name:";
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(146, 431);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(310, 22);
            this.tbProjectName.TabIndex = 7;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(739, 515);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(129, 36);
            this.btnBrowser.TabIndex = 8;
            this.btnBrowser.Text = "Browser ...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            // 
            // lbSolutionName
            // 
            this.lbSolutionName.AutoSize = true;
            this.lbSolutionName.Location = new System.Drawing.Point(25, 479);
            this.lbSolutionName.Name = "lbSolutionName";
            this.lbSolutionName.Size = new System.Drawing.Size(104, 17);
            this.lbSolutionName.TabIndex = 9;
            this.lbSolutionName.Text = "Solution Name:";
            // 
            // tbSolutionName
            // 
            this.tbSolutionName.Location = new System.Drawing.Point(146, 476);
            this.tbSolutionName.Name = "tbSolutionName";
            this.tbSolutionName.Size = new System.Drawing.Size(310, 22);
            this.tbSolutionName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Which table you wanna gen?";
            // 
            // SelectDBTableToGenerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 671);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSolutionName);
            this.Controls.Add(this.lbSolutionName);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.tbProjectName);
            this.Controls.Add(this.lbProjectName);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStartGenerate);
            this.Controls.Add(this.listBoxDBTable);
            this.Controls.Add(this.btnConnectDB);
            this.Name = "SelectDBTableToGenerateForm";
            this.Text = "SelectDBTableToGenerateForm";
            this.Shown += new System.EventHandler(this.SelectDBTableToGenerateForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectDB;
        private System.Windows.Forms.ListBox listBoxDBTable;
        private System.Windows.Forms.Button btnStartGenerate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbProjectName;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Label lbSolutionName;
        private System.Windows.Forms.TextBox tbSolutionName;
        private System.Windows.Forms.Label label1;
    }
}