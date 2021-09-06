namespace WindowsFormsAppExamplesRWA
{
    partial class ParentChildForm
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
            this.dataGridViewChild = new System.Windows.Forms.DataGridView();
            this.textChildName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InsertChildObject = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSubclassAttribute = new System.Windows.Forms.TextBox();
            this.DeleteChildObject = new System.Windows.Forms.Button();
            this.UpdateChildObject = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textChildId = new System.Windows.Forms.TextBox();
            this.tblLampBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button10 = new System.Windows.Forms.Button();
            this.dataGridViewParent = new System.Windows.Forms.DataGridView();
            this.UpdateParentObject = new System.Windows.Forms.Button();
            this.DeleteParentObject = new System.Windows.Forms.Button();
            this.InsertParentObject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxParentId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxParentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxParentStatus = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchButton1 = new System.Windows.Forms.Button();
            this.SearchButton2 = new System.Windows.Forms.Button();
            this.btnHelloWorld = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLampBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewChild
            // 
            this.dataGridViewChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChild.Location = new System.Drawing.Point(200, 243);
            this.dataGridViewChild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewChild.Name = "dataGridViewChild";
            this.dataGridViewChild.RowHeadersWidth = 51;
            this.dataGridViewChild.RowTemplate.Height = 24;
            this.dataGridViewChild.Size = new System.Drawing.Size(548, 257);
            this.dataGridViewChild.TabIndex = 11;
            this.dataGridViewChild.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // textChildName
            // 
            this.textChildName.Location = new System.Drawing.Point(834, 345);
            this.textChildName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textChildName.Name = "textChildName";
            this.textChildName.Size = new System.Drawing.Size(100, 22);
            this.textChildName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(773, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name";
            // 
            // InsertChildObject
            // 
            this.InsertChildObject.Location = new System.Drawing.Point(200, 517);
            this.InsertChildObject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertChildObject.Name = "InsertChildObject";
            this.InsertChildObject.Size = new System.Drawing.Size(124, 37);
            this.InsertChildObject.TabIndex = 15;
            this.InsertChildObject.Text = "Voeg Child toe";
            this.InsertChildObject.UseVisualStyleBackColor = true;
            this.InsertChildObject.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(803, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Extra Attribuut Subclass";
            // 
            // textBoxSubclassAttribute
            // 
            this.textBoxSubclassAttribute.Location = new System.Drawing.Point(834, 423);
            this.textBoxSubclassAttribute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSubclassAttribute.Name = "textBoxSubclassAttribute";
            this.textBoxSubclassAttribute.Size = new System.Drawing.Size(100, 22);
            this.textBoxSubclassAttribute.TabIndex = 16;
            // 
            // DeleteChildObject
            // 
            this.DeleteChildObject.Location = new System.Drawing.Point(532, 520);
            this.DeleteChildObject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteChildObject.Name = "DeleteChildObject";
            this.DeleteChildObject.Size = new System.Drawing.Size(124, 30);
            this.DeleteChildObject.TabIndex = 18;
            this.DeleteChildObject.Text = "Verwijder Child";
            this.DeleteChildObject.UseVisualStyleBackColor = true;
            this.DeleteChildObject.Click += new System.EventHandler(this.button6_Click);
            // 
            // UpdateChildObject
            // 
            this.UpdateChildObject.Location = new System.Drawing.Point(342, 517);
            this.UpdateChildObject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateChildObject.Name = "UpdateChildObject";
            this.UpdateChildObject.Size = new System.Drawing.Size(124, 37);
            this.UpdateChildObject.TabIndex = 23;
            this.UpdateChildObject.Text = "Update Child";
            this.UpdateChildObject.UseVisualStyleBackColor = true;
            this.UpdateChildObject.Click += new System.EventHandler(this.button9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(773, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Id";
            // 
            // textChildId
            // 
            this.textChildId.Location = new System.Drawing.Point(834, 304);
            this.textChildId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textChildId.Name = "textChildId";
            this.textChildId.Size = new System.Drawing.Size(100, 22);
            this.textChildId.TabIndex = 24;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(34, 213);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(124, 61);
            this.button10.TabIndex = 28;
            this.button10.Text = "Vul DAL met gegegens in Database";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dataGridViewParent
            // 
            this.dataGridViewParent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParent.Location = new System.Drawing.Point(200, 37);
            this.dataGridViewParent.Name = "dataGridViewParent";
            this.dataGridViewParent.RowHeadersWidth = 51;
            this.dataGridViewParent.RowTemplate.Height = 24;
            this.dataGridViewParent.Size = new System.Drawing.Size(548, 133);
            this.dataGridViewParent.TabIndex = 29;
            this.dataGridViewParent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // UpdateParentObject
            // 
            this.UpdateParentObject.Location = new System.Drawing.Point(342, 187);
            this.UpdateParentObject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateParentObject.Name = "UpdateParentObject";
            this.UpdateParentObject.Size = new System.Drawing.Size(124, 37);
            this.UpdateParentObject.TabIndex = 32;
            this.UpdateParentObject.Text = "Update Parent";
            this.UpdateParentObject.UseVisualStyleBackColor = true;
            this.UpdateParentObject.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteParentObject
            // 
            this.DeleteParentObject.Location = new System.Drawing.Point(532, 190);
            this.DeleteParentObject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteParentObject.Name = "DeleteParentObject";
            this.DeleteParentObject.Size = new System.Drawing.Size(124, 30);
            this.DeleteParentObject.TabIndex = 31;
            this.DeleteParentObject.Text = "Verwijder Parent";
            this.DeleteParentObject.UseVisualStyleBackColor = true;
            this.DeleteParentObject.Click += new System.EventHandler(this.button2_Click);
            // 
            // InsertParentObject
            // 
            this.InsertParentObject.Location = new System.Drawing.Point(200, 187);
            this.InsertParentObject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertParentObject.Name = "InsertParentObject";
            this.InsertParentObject.Size = new System.Drawing.Size(124, 37);
            this.InsertParentObject.TabIndex = 30;
            this.InsertParentObject.Text = "Voeg Parent toe";
            this.InsertParentObject.UseVisualStyleBackColor = true;
            this.InsertParentObject.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(773, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Id";
            // 
            // textBoxParentId
            // 
            this.textBoxParentId.Location = new System.Drawing.Point(834, 63);
            this.textBoxParentId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxParentId.Name = "textBoxParentId";
            this.textBoxParentId.Size = new System.Drawing.Size(100, 22);
            this.textBoxParentId.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(773, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Name";
            // 
            // textBoxParentName
            // 
            this.textBoxParentName.Location = new System.Drawing.Point(834, 101);
            this.textBoxParentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxParentName.Name = "textBoxParentName";
            this.textBoxParentName.Size = new System.Drawing.Size(100, 22);
            this.textBoxParentName.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Status";
            // 
            // textBoxParentStatus
            // 
            this.textBoxParentStatus.Location = new System.Drawing.Point(834, 136);
            this.textBoxParentStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxParentStatus.Name = "textBoxParentStatus";
            this.textBoxParentStatus.Size = new System.Drawing.Size(100, 22);
            this.textBoxParentStatus.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 48);
            this.button1.TabIndex = 41;
            this.button1.Text = "Vul DAL met testgegevens";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SearchButton1
            // 
            this.SearchButton1.Location = new System.Drawing.Point(990, 190);
            this.SearchButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton1.Name = "SearchButton1";
            this.SearchButton1.Size = new System.Drawing.Size(202, 61);
            this.SearchButton1.TabIndex = 42;
            this.SearchButton1.Text = "Vul DAL met gegegens in Database met restrictie op  ingevulde parameters";
            this.SearchButton1.UseVisualStyleBackColor = true;
            this.SearchButton1.Click += new System.EventHandler(this.SearchButton1_Click);
            // 
            // SearchButton2
            // 
            this.SearchButton2.Location = new System.Drawing.Point(990, 284);
            this.SearchButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton2.Name = "SearchButton2";
            this.SearchButton2.Size = new System.Drawing.Size(202, 61);
            this.SearchButton2.TabIndex = 43;
            this.SearchButton2.Text = "Vul DAL met gegegens uit Model met restrictie op  ingevulde parameters";
            this.SearchButton2.UseVisualStyleBackColor = true;
            this.SearchButton2.Click += new System.EventHandler(this.SearchButton2_Click);
            // 
            // ParentChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 596);
            this.Controls.Add(this.btnHelloWorld);
            this.Controls.Add(this.SearchButton2);
            this.Controls.Add(this.SearchButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxParentStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxParentId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxParentName);
            this.Controls.Add(this.UpdateParentObject);
            this.Controls.Add(this.DeleteParentObject);
            this.Controls.Add(this.InsertParentObject);
            this.Controls.Add(this.dataGridViewParent);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textChildId);
            this.Controls.Add(this.UpdateChildObject);
            this.Controls.Add(this.DeleteChildObject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSubclassAttribute);
            this.Controls.Add(this.InsertChildObject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textChildName);
            this.Controls.Add(this.dataGridViewChild);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ParentChildForm";
            this.Text = "Gewijzigde Form Text Property";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLampBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewChild;
        private System.Windows.Forms.TextBox textChildName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button InsertChildObject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSubclassAttribute;
        private System.Windows.Forms.Button DeleteChildObject;
        private System.Windows.Forms.Button UpdateChildObject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textChildId;
        private System.Windows.Forms.BindingSource tblLampBindingSource;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView dataGridViewParent;
        private System.Windows.Forms.Button UpdateParentObject;
        private System.Windows.Forms.Button DeleteParentObject;
        private System.Windows.Forms.Button InsertParentObject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxParentId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxParentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxParentStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SearchButton1;
        private System.Windows.Forms.Button SearchButton2;
        private System.Windows.Forms.Button btnHelloWorld;
    }
}

