
namespace KidsSP
{
    partial class RegisterFamilyUnitForm
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
            this.lblFamilyUnitName = new System.Windows.Forms.Label();
            this.tbxFamilyUnitName = new System.Windows.Forms.TextBox();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblChildren = new System.Windows.Forms.Label();
            this.lblParents = new System.Windows.Forms.Label();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.tbxParentFirstName = new System.Windows.Forms.TextBox();
            this.lblParentFirstName = new System.Windows.Forms.Label();
            this.lblParentLastName = new System.Windows.Forms.Label();
            this.lblParentPhoneNr = new System.Windows.Forms.Label();
            this.lblParentDoB = new System.Windows.Forms.Label();
            this.tbxParentLastName = new System.Windows.Forms.TextBox();
            this.tbxParentPhoneNr = new System.Windows.Forms.TextBox();
            this.dtpParentDoB = new System.Windows.Forms.DateTimePicker();
            this.dtpChildDoB = new System.Windows.Forms.DateTimePicker();
            this.tbxChildLastName = new System.Windows.Forms.TextBox();
            this.lblChildDoB = new System.Windows.Forms.Label();
            this.lblChildLastName = new System.Windows.Forms.Label();
            this.tbxChildFirstName = new System.Windows.Forms.TextBox();
            this.lblChildFirstName = new System.Windows.Forms.Label();
            this.lbxChildren = new System.Windows.Forms.ListBox();
            this.lblChildrenListBox = new System.Windows.Forms.Label();
            this.btnRegisterFamilyUnit = new System.Windows.Forms.Button();
            this.lbxParents = new System.Windows.Forms.ListBox();
            this.lblParentsListBox = new System.Windows.Forms.Label();
            this.btnAddParent = new System.Windows.Forms.Button();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFamilyUnitName
            // 
            this.lblFamilyUnitName.AutoSize = true;
            this.lblFamilyUnitName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilyUnitName.Location = new System.Drawing.Point(12, 22);
            this.lblFamilyUnitName.Name = "lblFamilyUnitName";
            this.lblFamilyUnitName.Size = new System.Drawing.Size(171, 22);
            this.lblFamilyUnitName.TabIndex = 0;
            this.lblFamilyUnitName.Text = "Family Unit Name:";
            // 
            // tbxFamilyUnitName
            // 
            this.tbxFamilyUnitName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFamilyUnitName.Location = new System.Drawing.Point(189, 19);
            this.tbxFamilyUnitName.Name = "tbxFamilyUnitName";
            this.tbxFamilyUnitName.Size = new System.Drawing.Size(180, 30);
            this.tbxFamilyUnitName.TabIndex = 1;
            // 
            // btnAddChild
            // 
            this.btnAddChild.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChild.Location = new System.Drawing.Point(635, 440);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(100, 34);
            this.btnAddChild.TabIndex = 2;
            this.btnAddChild.Text = "Add Child";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(12, 62);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(206, 22);
            this.lblComment.TabIndex = 3;
            this.lblComment.Text = "Comment (Optional):";
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildren.Location = new System.Drawing.Point(396, 285);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(91, 22);
            this.lblChildren.TabIndex = 4;
            this.lblChildren.Text = "Children:";
            // 
            // lblParents
            // 
            this.lblParents.AutoSize = true;
            this.lblParents.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParents.Location = new System.Drawing.Point(396, 22);
            this.lblParents.Name = "lblParents";
            this.lblParents.Size = new System.Drawing.Size(83, 22);
            this.lblParents.TabIndex = 5;
            this.lblParents.Text = "Parents:";
            // 
            // rtbComment
            // 
            this.rtbComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbComment.Location = new System.Drawing.Point(16, 87);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(353, 136);
            this.rtbComment.TabIndex = 6;
            this.rtbComment.Text = "";
            // 
            // tbxParentFirstName
            // 
            this.tbxParentFirstName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxParentFirstName.Location = new System.Drawing.Point(528, 54);
            this.tbxParentFirstName.Name = "tbxParentFirstName";
            this.tbxParentFirstName.Size = new System.Drawing.Size(207, 30);
            this.tbxParentFirstName.TabIndex = 8;
            // 
            // lblParentFirstName
            // 
            this.lblParentFirstName.AutoSize = true;
            this.lblParentFirstName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentFirstName.Location = new System.Drawing.Point(396, 62);
            this.lblParentFirstName.Name = "lblParentFirstName";
            this.lblParentFirstName.Size = new System.Drawing.Size(103, 22);
            this.lblParentFirstName.TabIndex = 7;
            this.lblParentFirstName.Text = "FirstName:";
            // 
            // lblParentLastName
            // 
            this.lblParentLastName.AutoSize = true;
            this.lblParentLastName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentLastName.Location = new System.Drawing.Point(396, 101);
            this.lblParentLastName.Name = "lblParentLastName";
            this.lblParentLastName.Size = new System.Drawing.Size(107, 22);
            this.lblParentLastName.TabIndex = 9;
            this.lblParentLastName.Text = "LastName:";
            // 
            // lblParentPhoneNr
            // 
            this.lblParentPhoneNr.AutoSize = true;
            this.lblParentPhoneNr.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentPhoneNr.Location = new System.Drawing.Point(396, 187);
            this.lblParentPhoneNr.Name = "lblParentPhoneNr";
            this.lblParentPhoneNr.Size = new System.Drawing.Size(153, 22);
            this.lblParentPhoneNr.TabIndex = 10;
            this.lblParentPhoneNr.Text = "Phone Number:";
            // 
            // lblParentDoB
            // 
            this.lblParentDoB.AutoSize = true;
            this.lblParentDoB.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentDoB.Location = new System.Drawing.Point(396, 231);
            this.lblParentDoB.Name = "lblParentDoB";
            this.lblParentDoB.Size = new System.Drawing.Size(133, 22);
            this.lblParentDoB.TabIndex = 11;
            this.lblParentDoB.Text = "Date Of Birth:";
            // 
            // tbxParentLastName
            // 
            this.tbxParentLastName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxParentLastName.Location = new System.Drawing.Point(528, 101);
            this.tbxParentLastName.Name = "tbxParentLastName";
            this.tbxParentLastName.Size = new System.Drawing.Size(207, 30);
            this.tbxParentLastName.TabIndex = 12;
            // 
            // tbxParentPhoneNr
            // 
            this.tbxParentPhoneNr.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxParentPhoneNr.Location = new System.Drawing.Point(555, 184);
            this.tbxParentPhoneNr.Name = "tbxParentPhoneNr";
            this.tbxParentPhoneNr.Size = new System.Drawing.Size(180, 30);
            this.tbxParentPhoneNr.TabIndex = 13;
            // 
            // dtpParentDoB
            // 
            this.dtpParentDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpParentDoB.Location = new System.Drawing.Point(528, 226);
            this.dtpParentDoB.Name = "dtpParentDoB";
            this.dtpParentDoB.Size = new System.Drawing.Size(207, 29);
            this.dtpParentDoB.TabIndex = 14;
            // 
            // dtpChildDoB
            // 
            this.dtpChildDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChildDoB.Location = new System.Drawing.Point(528, 399);
            this.dtpChildDoB.Name = "dtpChildDoB";
            this.dtpChildDoB.Size = new System.Drawing.Size(207, 29);
            this.dtpChildDoB.TabIndex = 22;
            // 
            // tbxChildLastName
            // 
            this.tbxChildLastName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxChildLastName.Location = new System.Drawing.Point(528, 363);
            this.tbxChildLastName.Name = "tbxChildLastName";
            this.tbxChildLastName.Size = new System.Drawing.Size(207, 30);
            this.tbxChildLastName.TabIndex = 20;
            // 
            // lblChildDoB
            // 
            this.lblChildDoB.AutoSize = true;
            this.lblChildDoB.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildDoB.Location = new System.Drawing.Point(396, 404);
            this.lblChildDoB.Name = "lblChildDoB";
            this.lblChildDoB.Size = new System.Drawing.Size(133, 22);
            this.lblChildDoB.TabIndex = 19;
            this.lblChildDoB.Text = "Date Of Birth:";
            // 
            // lblChildLastName
            // 
            this.lblChildLastName.AutoSize = true;
            this.lblChildLastName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildLastName.Location = new System.Drawing.Point(396, 366);
            this.lblChildLastName.Name = "lblChildLastName";
            this.lblChildLastName.Size = new System.Drawing.Size(107, 22);
            this.lblChildLastName.TabIndex = 17;
            this.lblChildLastName.Text = "LastName:";
            // 
            // tbxChildFirstName
            // 
            this.tbxChildFirstName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxChildFirstName.Location = new System.Drawing.Point(528, 319);
            this.tbxChildFirstName.Name = "tbxChildFirstName";
            this.tbxChildFirstName.Size = new System.Drawing.Size(207, 30);
            this.tbxChildFirstName.TabIndex = 16;
            // 
            // lblChildFirstName
            // 
            this.lblChildFirstName.AutoSize = true;
            this.lblChildFirstName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildFirstName.Location = new System.Drawing.Point(396, 327);
            this.lblChildFirstName.Name = "lblChildFirstName";
            this.lblChildFirstName.Size = new System.Drawing.Size(103, 22);
            this.lblChildFirstName.TabIndex = 15;
            this.lblChildFirstName.Text = "FirstName:";
            // 
            // lbxChildren
            // 
            this.lbxChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxChildren.FormattingEnabled = true;
            this.lbxChildren.ItemHeight = 24;
            this.lbxChildren.Location = new System.Drawing.Point(16, 259);
            this.lbxChildren.Name = "lbxChildren";
            this.lbxChildren.Size = new System.Drawing.Size(167, 172);
            this.lbxChildren.TabIndex = 23;
            // 
            // lblChildrenListBox
            // 
            this.lblChildrenListBox.AutoSize = true;
            this.lblChildrenListBox.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildrenListBox.Location = new System.Drawing.Point(12, 234);
            this.lblChildrenListBox.Name = "lblChildrenListBox";
            this.lblChildrenListBox.Size = new System.Drawing.Size(91, 22);
            this.lblChildrenListBox.TabIndex = 24;
            this.lblChildrenListBox.Text = "Children:";
            // 
            // btnRegisterFamilyUnit
            // 
            this.btnRegisterFamilyUnit.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterFamilyUnit.Location = new System.Drawing.Point(16, 440);
            this.btnRegisterFamilyUnit.Name = "btnRegisterFamilyUnit";
            this.btnRegisterFamilyUnit.Size = new System.Drawing.Size(353, 34);
            this.btnRegisterFamilyUnit.TabIndex = 25;
            this.btnRegisterFamilyUnit.Text = "Register Family Unit";
            this.btnRegisterFamilyUnit.UseVisualStyleBackColor = true;
            this.btnRegisterFamilyUnit.Click += new System.EventHandler(this.btnRegisterFamilyUnit_Click);
            // 
            // lbxParents
            // 
            this.lbxParents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxParents.FormattingEnabled = true;
            this.lbxParents.ItemHeight = 24;
            this.lbxParents.Location = new System.Drawing.Point(202, 259);
            this.lbxParents.Name = "lbxParents";
            this.lbxParents.Size = new System.Drawing.Size(167, 172);
            this.lbxParents.TabIndex = 26;
            // 
            // lblParentsListBox
            // 
            this.lblParentsListBox.AutoSize = true;
            this.lblParentsListBox.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentsListBox.Location = new System.Drawing.Point(198, 234);
            this.lblParentsListBox.Name = "lblParentsListBox";
            this.lblParentsListBox.Size = new System.Drawing.Size(83, 22);
            this.lblParentsListBox.TabIndex = 27;
            this.lblParentsListBox.Text = "Parents:";
            // 
            // btnAddParent
            // 
            this.btnAddParent.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddParent.Location = new System.Drawing.Point(635, 261);
            this.btnAddParent.Name = "btnAddParent";
            this.btnAddParent.Size = new System.Drawing.Size(100, 34);
            this.btnAddParent.TabIndex = 28;
            this.btnAddParent.Text = "Add Child";
            this.btnAddParent.UseVisualStyleBackColor = true;
            this.btnAddParent.Click += new System.EventHandler(this.btnAddParent_Click);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(528, 145);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(207, 30);
            this.tbxEmail.TabIndex = 30;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(396, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 22);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "Email:";
            // 
            // RegisterFamilyUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnAddParent);
            this.Controls.Add(this.lblParentsListBox);
            this.Controls.Add(this.lbxParents);
            this.Controls.Add(this.btnRegisterFamilyUnit);
            this.Controls.Add(this.lblChildrenListBox);
            this.Controls.Add(this.lbxChildren);
            this.Controls.Add(this.dtpChildDoB);
            this.Controls.Add(this.tbxChildLastName);
            this.Controls.Add(this.lblChildDoB);
            this.Controls.Add(this.lblChildLastName);
            this.Controls.Add(this.tbxChildFirstName);
            this.Controls.Add(this.lblChildFirstName);
            this.Controls.Add(this.dtpParentDoB);
            this.Controls.Add(this.tbxParentPhoneNr);
            this.Controls.Add(this.tbxParentLastName);
            this.Controls.Add(this.lblParentDoB);
            this.Controls.Add(this.lblParentPhoneNr);
            this.Controls.Add(this.lblParentLastName);
            this.Controls.Add(this.tbxParentFirstName);
            this.Controls.Add(this.lblParentFirstName);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.lblParents);
            this.Controls.Add(this.lblChildren);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.btnAddChild);
            this.Controls.Add(this.tbxFamilyUnitName);
            this.Controls.Add(this.lblFamilyUnitName);
            this.Name = "RegisterFamilyUnitForm";
            this.Text = "RegisterFamilyUnitForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterFamilyUnitForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFamilyUnitName;
        private System.Windows.Forms.TextBox tbxFamilyUnitName;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.Label lblParents;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.TextBox tbxParentFirstName;
        private System.Windows.Forms.Label lblParentFirstName;
        private System.Windows.Forms.Label lblParentLastName;
        private System.Windows.Forms.Label lblParentPhoneNr;
        private System.Windows.Forms.Label lblParentDoB;
        private System.Windows.Forms.TextBox tbxParentLastName;
        private System.Windows.Forms.TextBox tbxParentPhoneNr;
        private System.Windows.Forms.DateTimePicker dtpParentDoB;
        private System.Windows.Forms.DateTimePicker dtpChildDoB;
        private System.Windows.Forms.TextBox tbxChildLastName;
        private System.Windows.Forms.Label lblChildDoB;
        private System.Windows.Forms.Label lblChildLastName;
        private System.Windows.Forms.TextBox tbxChildFirstName;
        private System.Windows.Forms.Label lblChildFirstName;
        private System.Windows.Forms.ListBox lbxChildren;
        private System.Windows.Forms.Label lblChildrenListBox;
        private System.Windows.Forms.Button btnRegisterFamilyUnit;
        private System.Windows.Forms.ListBox lbxParents;
        private System.Windows.Forms.Label lblParentsListBox;
        private System.Windows.Forms.Button btnAddParent;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}