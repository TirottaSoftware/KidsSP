
namespace KidsSP
{
    partial class ParentDashboard
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
            this.tcFamilyUnit = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnEditFamilyUnit = new System.Windows.Forms.Button();
            this.lblFamilyUnitName = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddParent = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblParentPhoneNumber = new System.Windows.Forms.Label();
            this.tbxParentPhoneNr = new System.Windows.Forms.TextBox();
            this.lblParentEmail = new System.Windows.Forms.Label();
            this.tbxParentEmail = new System.Windows.Forms.TextBox();
            this.lblParentLastName = new System.Windows.Forms.Label();
            this.tbxParentLastName = new System.Windows.Forms.TextBox();
            this.lblParentFirstName = new System.Windows.Forms.Label();
            this.btnSaveParent = new System.Windows.Forms.Button();
            this.tbxParentFirstName = new System.Windows.Forms.TextBox();
            this.lblParents = new System.Windows.Forms.Label();
            this.lbxParents = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveChild = new System.Windows.Forms.Button();
            this.btnBackChild = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.lblChildLastName = new System.Windows.Forms.Label();
            this.tbxChildLastName = new System.Windows.Forms.TextBox();
            this.lblChildFirstName = new System.Windows.Forms.Label();
            this.tbxChildFirstName = new System.Windows.Forms.TextBox();
            this.lblChildren = new System.Windows.Forms.Label();
            this.lbxChildren = new System.Windows.Forms.ListBox();
            this.tcFamilyUnit.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcFamilyUnit
            // 
            this.tcFamilyUnit.Controls.Add(this.tabPage3);
            this.tcFamilyUnit.Controls.Add(this.tabPage1);
            this.tcFamilyUnit.Controls.Add(this.tabPage2);
            this.tcFamilyUnit.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcFamilyUnit.Location = new System.Drawing.Point(12, 12);
            this.tcFamilyUnit.Name = "tcFamilyUnit";
            this.tcFamilyUnit.SelectedIndex = 0;
            this.tcFamilyUnit.Size = new System.Drawing.Size(613, 322);
            this.tcFamilyUnit.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnEditFamilyUnit);
            this.tabPage3.Controls.Add(this.lblFamilyUnitName);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(605, 287);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "My Family Unit";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnEditFamilyUnit
            // 
            this.btnEditFamilyUnit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditFamilyUnit.Location = new System.Drawing.Point(0, 251);
            this.btnEditFamilyUnit.Name = "btnEditFamilyUnit";
            this.btnEditFamilyUnit.Size = new System.Drawing.Size(605, 36);
            this.btnEditFamilyUnit.TabIndex = 3;
            this.btnEditFamilyUnit.Text = "Edit Family Unit";
            this.btnEditFamilyUnit.UseVisualStyleBackColor = true;
            // 
            // lblFamilyUnitName
            // 
            this.lblFamilyUnitName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFamilyUnitName.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilyUnitName.Location = new System.Drawing.Point(0, 0);
            this.lblFamilyUnitName.Name = "lblFamilyUnitName";
            this.lblFamilyUnitName.Size = new System.Drawing.Size(605, 287);
            this.lblFamilyUnitName.TabIndex = 2;
            this.lblFamilyUnitName.Text = "MyFamilyUnitName";
            this.lblFamilyUnitName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddParent);
            this.tabPage1.Controls.Add(this.btnBack);
            this.tabPage1.Controls.Add(this.lblParentPhoneNumber);
            this.tabPage1.Controls.Add(this.tbxParentPhoneNr);
            this.tabPage1.Controls.Add(this.lblParentEmail);
            this.tabPage1.Controls.Add(this.tbxParentEmail);
            this.tabPage1.Controls.Add(this.lblParentLastName);
            this.tabPage1.Controls.Add(this.tbxParentLastName);
            this.tabPage1.Controls.Add(this.lblParentFirstName);
            this.tabPage1.Controls.Add(this.btnSaveParent);
            this.tabPage1.Controls.Add(this.tbxParentFirstName);
            this.tabPage1.Controls.Add(this.lblParents);
            this.tabPage1.Controls.Add(this.lbxParents);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(605, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parents";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddParent
            // 
            this.btnAddParent.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddParent.Location = new System.Drawing.Point(3, 239);
            this.btnAddParent.Name = "btnAddParent";
            this.btnAddParent.Size = new System.Drawing.Size(237, 37);
            this.btnAddParent.TabIndex = 12;
            this.btnAddParent.Text = "Add Parent";
            this.btnAddParent.UseVisualStyleBackColor = true;
            this.btnAddParent.Click += new System.EventHandler(this.btnAddParent_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(257, 239);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 37);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblParentPhoneNumber
            // 
            this.lblParentPhoneNumber.AutoSize = true;
            this.lblParentPhoneNumber.Location = new System.Drawing.Point(253, 196);
            this.lblParentPhoneNumber.Name = "lblParentPhoneNumber";
            this.lblParentPhoneNumber.Size = new System.Drawing.Size(153, 22);
            this.lblParentPhoneNumber.TabIndex = 10;
            this.lblParentPhoneNumber.Text = "Phone Number:";
            // 
            // tbxParentPhoneNr
            // 
            this.tbxParentPhoneNr.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxParentPhoneNr.Location = new System.Drawing.Point(412, 193);
            this.tbxParentPhoneNr.Name = "tbxParentPhoneNr";
            this.tbxParentPhoneNr.Size = new System.Drawing.Size(170, 30);
            this.tbxParentPhoneNr.TabIndex = 9;
            // 
            // lblParentEmail
            // 
            this.lblParentEmail.AutoSize = true;
            this.lblParentEmail.Location = new System.Drawing.Point(253, 149);
            this.lblParentEmail.Name = "lblParentEmail";
            this.lblParentEmail.Size = new System.Drawing.Size(61, 22);
            this.lblParentEmail.TabIndex = 8;
            this.lblParentEmail.Text = "Email:";
            // 
            // tbxParentEmail
            // 
            this.tbxParentEmail.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxParentEmail.Location = new System.Drawing.Point(412, 141);
            this.tbxParentEmail.Name = "tbxParentEmail";
            this.tbxParentEmail.Size = new System.Drawing.Size(170, 30);
            this.tbxParentEmail.TabIndex = 7;
            // 
            // lblParentLastName
            // 
            this.lblParentLastName.AutoSize = true;
            this.lblParentLastName.Location = new System.Drawing.Point(253, 97);
            this.lblParentLastName.Name = "lblParentLastName";
            this.lblParentLastName.Size = new System.Drawing.Size(112, 22);
            this.lblParentLastName.TabIndex = 6;
            this.lblParentLastName.Text = "Last Name:";
            // 
            // tbxParentLastName
            // 
            this.tbxParentLastName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxParentLastName.Location = new System.Drawing.Point(412, 94);
            this.tbxParentLastName.Name = "tbxParentLastName";
            this.tbxParentLastName.Size = new System.Drawing.Size(170, 30);
            this.tbxParentLastName.TabIndex = 5;
            // 
            // lblParentFirstName
            // 
            this.lblParentFirstName.AutoSize = true;
            this.lblParentFirstName.Location = new System.Drawing.Point(252, 47);
            this.lblParentFirstName.Name = "lblParentFirstName";
            this.lblParentFirstName.Size = new System.Drawing.Size(113, 22);
            this.lblParentFirstName.TabIndex = 4;
            this.lblParentFirstName.Text = "First Name: ";
            // 
            // btnSaveParent
            // 
            this.btnSaveParent.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveParent.Location = new System.Drawing.Point(429, 239);
            this.btnSaveParent.Name = "btnSaveParent";
            this.btnSaveParent.Size = new System.Drawing.Size(153, 37);
            this.btnSaveParent.TabIndex = 3;
            this.btnSaveParent.Text = "Save";
            this.btnSaveParent.UseVisualStyleBackColor = true;
            this.btnSaveParent.Click += new System.EventHandler(this.btnSaveParent_Click);
            // 
            // tbxParentFirstName
            // 
            this.tbxParentFirstName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxParentFirstName.Location = new System.Drawing.Point(412, 44);
            this.tbxParentFirstName.Name = "tbxParentFirstName";
            this.tbxParentFirstName.Size = new System.Drawing.Size(170, 30);
            this.tbxParentFirstName.TabIndex = 2;
            // 
            // lblParents
            // 
            this.lblParents.AutoSize = true;
            this.lblParents.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParents.Location = new System.Drawing.Point(1, 3);
            this.lblParents.Name = "lblParents";
            this.lblParents.Size = new System.Drawing.Size(90, 26);
            this.lblParents.TabIndex = 1;
            this.lblParents.Text = "Parents";
            // 
            // lbxParents
            // 
            this.lbxParents.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxParents.FormattingEnabled = true;
            this.lbxParents.ItemHeight = 22;
            this.lbxParents.Location = new System.Drawing.Point(6, 30);
            this.lbxParents.Name = "lbxParents";
            this.lbxParents.Size = new System.Drawing.Size(234, 202);
            this.lbxParents.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveChild);
            this.tabPage2.Controls.Add(this.btnBackChild);
            this.tabPage2.Controls.Add(this.btnAddChild);
            this.tabPage2.Controls.Add(this.lblChildLastName);
            this.tabPage2.Controls.Add(this.tbxChildLastName);
            this.tabPage2.Controls.Add(this.lblChildFirstName);
            this.tabPage2.Controls.Add(this.tbxChildFirstName);
            this.tabPage2.Controls.Add(this.lblChildren);
            this.tabPage2.Controls.Add(this.lbxChildren);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(605, 287);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Children";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveChild
            // 
            this.btnSaveChild.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChild.Location = new System.Drawing.Point(432, 130);
            this.btnSaveChild.Name = "btnSaveChild";
            this.btnSaveChild.Size = new System.Drawing.Size(140, 37);
            this.btnSaveChild.TabIndex = 24;
            this.btnSaveChild.Text = "Save";
            this.btnSaveChild.UseVisualStyleBackColor = true;
            this.btnSaveChild.Click += new System.EventHandler(this.btnSaveChild_Click);
            // 
            // btnBackChild
            // 
            this.btnBackChild.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackChild.Location = new System.Drawing.Point(286, 130);
            this.btnBackChild.Name = "btnBackChild";
            this.btnBackChild.Size = new System.Drawing.Size(140, 37);
            this.btnBackChild.TabIndex = 23;
            this.btnBackChild.Text = "Back";
            this.btnBackChild.UseVisualStyleBackColor = true;
            // 
            // btnAddChild
            // 
            this.btnAddChild.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChild.Location = new System.Drawing.Point(6, 246);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(234, 37);
            this.btnAddChild.TabIndex = 22;
            this.btnAddChild.Text = "Add Child";
            this.btnAddChild.UseVisualStyleBackColor = true;
            // 
            // lblChildLastName
            // 
            this.lblChildLastName.AutoSize = true;
            this.lblChildLastName.Location = new System.Drawing.Point(282, 92);
            this.lblChildLastName.Name = "lblChildLastName";
            this.lblChildLastName.Size = new System.Drawing.Size(112, 22);
            this.lblChildLastName.TabIndex = 21;
            this.lblChildLastName.Text = "Last Name:";
            // 
            // tbxChildLastName
            // 
            this.tbxChildLastName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxChildLastName.Location = new System.Drawing.Point(400, 89);
            this.tbxChildLastName.Name = "tbxChildLastName";
            this.tbxChildLastName.Size = new System.Drawing.Size(170, 30);
            this.tbxChildLastName.TabIndex = 20;
            // 
            // lblChildFirstName
            // 
            this.lblChildFirstName.AutoSize = true;
            this.lblChildFirstName.Location = new System.Drawing.Point(282, 40);
            this.lblChildFirstName.Name = "lblChildFirstName";
            this.lblChildFirstName.Size = new System.Drawing.Size(108, 22);
            this.lblChildFirstName.TabIndex = 19;
            this.lblChildFirstName.Text = "First Name:";
            // 
            // tbxChildFirstName
            // 
            this.tbxChildFirstName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxChildFirstName.Location = new System.Drawing.Point(400, 37);
            this.tbxChildFirstName.Name = "tbxChildFirstName";
            this.tbxChildFirstName.Size = new System.Drawing.Size(170, 30);
            this.tbxChildFirstName.TabIndex = 18;
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildren.Location = new System.Drawing.Point(1, 5);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(101, 26);
            this.lblChildren.TabIndex = 12;
            this.lblChildren.Text = "Children";
            // 
            // lbxChildren
            // 
            this.lbxChildren.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxChildren.FormattingEnabled = true;
            this.lbxChildren.ItemHeight = 22;
            this.lbxChildren.Location = new System.Drawing.Point(6, 32);
            this.lbxChildren.Name = "lbxChildren";
            this.lbxChildren.Size = new System.Drawing.Size(234, 202);
            this.lbxChildren.TabIndex = 11;
            // 
            // ParentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 346);
            this.Controls.Add(this.tcFamilyUnit);
            this.Name = "ParentDashboard";
            this.Text = "ParentDashboard";
            this.tcFamilyUnit.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcFamilyUnit;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSaveParent;
        private System.Windows.Forms.TextBox tbxParentFirstName;
        private System.Windows.Forms.Label lblParents;
        private System.Windows.Forms.ListBox lbxParents;
        private System.Windows.Forms.Button btnAddParent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblParentPhoneNumber;
        private System.Windows.Forms.TextBox tbxParentPhoneNr;
        private System.Windows.Forms.Label lblParentEmail;
        private System.Windows.Forms.TextBox tbxParentEmail;
        private System.Windows.Forms.Label lblParentLastName;
        private System.Windows.Forms.TextBox tbxParentLastName;
        private System.Windows.Forms.Label lblParentFirstName;
        private System.Windows.Forms.Button btnSaveChild;
        private System.Windows.Forms.Button btnBackChild;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Label lblChildLastName;
        private System.Windows.Forms.TextBox tbxChildLastName;
        private System.Windows.Forms.Label lblChildFirstName;
        private System.Windows.Forms.TextBox tbxChildFirstName;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.ListBox lbxChildren;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnEditFamilyUnit;
        private System.Windows.Forms.Label lblFamilyUnitName;
    }
}