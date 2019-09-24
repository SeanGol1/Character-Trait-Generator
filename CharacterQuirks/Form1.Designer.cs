namespace CharacterQuirks
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
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGen = new System.Windows.Forms.Button();
            this.database1DataSet = new CharacterQuirks.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTrait1Roll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrait1Name = new System.Windows.Forms.TextBox();
            this.txtTrait1Desc = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrait2Desc = new System.Windows.Forms.RichTextBox();
            this.txtTrait2Name = new System.Windows.Forms.TextBox();
            this.btnTrait2Roll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrait3Desc = new System.Windows.Forms.RichTextBox();
            this.txtTrait3Name = new System.Windows.Forms.TextBox();
            this.btnTrait3Roll = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhobiaDesc = new System.Windows.Forms.RichTextBox();
            this.txtPhobiaName = new System.Windows.Forms.TextBox();
            this.btnPhobiaRoll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTrait1 = new System.Windows.Forms.Label();
            this.lblTrait2 = new System.Windows.Forms.Label();
            this.lblTrait3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(12, 12);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(147, 54);
            this.btnGen.TabIndex = 0;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.button1_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // btnTrait1Roll
            // 
            this.btnTrait1Roll.Location = new System.Drawing.Point(458, 133);
            this.btnTrait1Roll.Name = "btnTrait1Roll";
            this.btnTrait1Roll.Size = new System.Drawing.Size(56, 23);
            this.btnTrait1Roll.TabIndex = 1;
            this.btnTrait1Roll.Text = "Reroll";
            this.btnTrait1Roll.UseVisualStyleBackColor = true;
            this.btnTrait1Roll.Click += new System.EventHandler(this.btnTrait1Roll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(60, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Negative Quirks";
            // 
            // txtTrait1Name
            // 
            this.txtTrait1Name.Location = new System.Drawing.Point(120, 136);
            this.txtTrait1Name.Multiline = true;
            this.txtTrait1Name.Name = "txtTrait1Name";
            this.txtTrait1Name.ReadOnly = true;
            this.txtTrait1Name.Size = new System.Drawing.Size(100, 20);
            this.txtTrait1Name.TabIndex = 4;
            // 
            // txtTrait1Desc
            // 
            this.txtTrait1Desc.Location = new System.Drawing.Point(226, 119);
            this.txtTrait1Desc.Name = "txtTrait1Desc";
            this.txtTrait1Desc.ReadOnly = true;
            this.txtTrait1Desc.Size = new System.Drawing.Size(226, 54);
            this.txtTrait1Desc.TabIndex = 6;
            this.txtTrait1Desc.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(32, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Trait 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(32, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Trait 2:";
            // 
            // txtTrait2Desc
            // 
            this.txtTrait2Desc.Location = new System.Drawing.Point(226, 180);
            this.txtTrait2Desc.Name = "txtTrait2Desc";
            this.txtTrait2Desc.ReadOnly = true;
            this.txtTrait2Desc.Size = new System.Drawing.Size(226, 54);
            this.txtTrait2Desc.TabIndex = 10;
            this.txtTrait2Desc.Text = "";
            // 
            // txtTrait2Name
            // 
            this.txtTrait2Name.Location = new System.Drawing.Point(120, 197);
            this.txtTrait2Name.Multiline = true;
            this.txtTrait2Name.Name = "txtTrait2Name";
            this.txtTrait2Name.ReadOnly = true;
            this.txtTrait2Name.Size = new System.Drawing.Size(100, 20);
            this.txtTrait2Name.TabIndex = 9;
            // 
            // btnTrait2Roll
            // 
            this.btnTrait2Roll.Location = new System.Drawing.Point(458, 194);
            this.btnTrait2Roll.Name = "btnTrait2Roll";
            this.btnTrait2Roll.Size = new System.Drawing.Size(56, 23);
            this.btnTrait2Roll.TabIndex = 8;
            this.btnTrait2Roll.Text = "Reroll";
            this.btnTrait2Roll.UseVisualStyleBackColor = true;
            this.btnTrait2Roll.Click += new System.EventHandler(this.btnTrait2Roll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(32, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Trait 3:";
            // 
            // txtTrait3Desc
            // 
            this.txtTrait3Desc.Location = new System.Drawing.Point(226, 244);
            this.txtTrait3Desc.Name = "txtTrait3Desc";
            this.txtTrait3Desc.ReadOnly = true;
            this.txtTrait3Desc.Size = new System.Drawing.Size(226, 54);
            this.txtTrait3Desc.TabIndex = 14;
            this.txtTrait3Desc.Text = "";
            // 
            // txtTrait3Name
            // 
            this.txtTrait3Name.Location = new System.Drawing.Point(120, 261);
            this.txtTrait3Name.Multiline = true;
            this.txtTrait3Name.Name = "txtTrait3Name";
            this.txtTrait3Name.ReadOnly = true;
            this.txtTrait3Name.Size = new System.Drawing.Size(100, 20);
            this.txtTrait3Name.TabIndex = 13;
            // 
            // btnTrait3Roll
            // 
            this.btnTrait3Roll.Location = new System.Drawing.Point(458, 258);
            this.btnTrait3Roll.Name = "btnTrait3Roll";
            this.btnTrait3Roll.Size = new System.Drawing.Size(56, 23);
            this.btnTrait3Roll.TabIndex = 12;
            this.btnTrait3Roll.Text = "Reroll";
            this.btnTrait3Roll.UseVisualStyleBackColor = true;
            this.btnTrait3Roll.Click += new System.EventHandler(this.btnTrait3Roll_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(32, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Phobia:";
            // 
            // txtPhobiaDesc
            // 
            this.txtPhobiaDesc.Location = new System.Drawing.Point(226, 365);
            this.txtPhobiaDesc.Name = "txtPhobiaDesc";
            this.txtPhobiaDesc.ReadOnly = true;
            this.txtPhobiaDesc.Size = new System.Drawing.Size(226, 54);
            this.txtPhobiaDesc.TabIndex = 18;
            this.txtPhobiaDesc.Text = "";
            // 
            // txtPhobiaName
            // 
            this.txtPhobiaName.Location = new System.Drawing.Point(120, 382);
            this.txtPhobiaName.Multiline = true;
            this.txtPhobiaName.Name = "txtPhobiaName";
            this.txtPhobiaName.ReadOnly = true;
            this.txtPhobiaName.Size = new System.Drawing.Size(100, 20);
            this.txtPhobiaName.TabIndex = 17;
            // 
            // btnPhobiaRoll
            // 
            this.btnPhobiaRoll.Location = new System.Drawing.Point(458, 379);
            this.btnPhobiaRoll.Name = "btnPhobiaRoll";
            this.btnPhobiaRoll.Size = new System.Drawing.Size(56, 23);
            this.btnPhobiaRoll.TabIndex = 16;
            this.btnPhobiaRoll.Text = "Reroll";
            this.btnPhobiaRoll.UseVisualStyleBackColor = true;
            this.btnPhobiaRoll.Click += new System.EventHandler(this.btnPhobiaRoll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(60, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Phobia";
            // 
            // lblTrait1
            // 
            this.lblTrait1.AutoSize = true;
            this.lblTrait1.Enabled = false;
            this.lblTrait1.Location = new System.Drawing.Point(120, 465);
            this.lblTrait1.Name = "lblTrait1";
            this.lblTrait1.Size = new System.Drawing.Size(0, 13);
            this.lblTrait1.TabIndex = 21;
            // 
            // lblTrait2
            // 
            this.lblTrait2.AutoSize = true;
            this.lblTrait2.Location = new System.Drawing.Point(86, 465);
            this.lblTrait2.Name = "lblTrait2";
            this.lblTrait2.Size = new System.Drawing.Size(0, 13);
            this.lblTrait2.TabIndex = 22;
            this.lblTrait2.Visible = false;
            // 
            // lblTrait3
            // 
            this.lblTrait3.AutoSize = true;
            this.lblTrait3.Location = new System.Drawing.Point(303, 478);
            this.lblTrait3.Name = "lblTrait3";
            this.lblTrait3.Size = new System.Drawing.Size(0, 13);
            this.lblTrait3.TabIndex = 23;
            this.lblTrait3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 503);
            this.Controls.Add(this.lblTrait3);
            this.Controls.Add(this.lblTrait2);
            this.Controls.Add(this.lblTrait1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhobiaDesc);
            this.Controls.Add(this.txtPhobiaName);
            this.Controls.Add(this.btnPhobiaRoll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTrait3Desc);
            this.Controls.Add(this.txtTrait3Name);
            this.Controls.Add(this.btnTrait3Roll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTrait2Desc);
            this.Controls.Add(this.txtTrait2Name);
            this.Controls.Add(this.btnTrait2Roll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTrait1Desc);
            this.Controls.Add(this.txtTrait1Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTrait1Roll);
            this.Controls.Add(this.btnGen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.Button btnTrait1Roll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrait1Name;
        private System.Windows.Forms.RichTextBox txtTrait1Desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtTrait2Desc;
        private System.Windows.Forms.TextBox txtTrait2Name;
        private System.Windows.Forms.Button btnTrait2Roll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtTrait3Desc;
        private System.Windows.Forms.TextBox txtTrait3Name;
        private System.Windows.Forms.Button btnTrait3Roll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtPhobiaDesc;
        private System.Windows.Forms.TextBox txtPhobiaName;
        private System.Windows.Forms.Button btnPhobiaRoll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTrait1;
        private System.Windows.Forms.Label lblTrait2;
        private System.Windows.Forms.Label lblTrait3;
    }
}

