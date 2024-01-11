﻿namespace libraryManagementFinal
{
    partial class AddBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.addBooks_importBtn = new System.Windows.Forms.Button();
            this.addBooks_clearBtn = new System.Windows.Forms.Button();
            this.addBooks_deleteBtn = new System.Windows.Forms.Button();
            this.addBooks_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addBooks_published = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.addBooks_updateBtn = new System.Windows.Forms.Button();
            this.addBooks_addBtn = new System.Windows.Forms.Button();
            this.addBooks_author = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addBooks_bookTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addBooks_picture = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbcolumn = new System.Windows.Forms.ComboBox();
            this.librarySystemDataSet = new libraryManagementFinal.LibrarySystemDataSet();
            this.librarySystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new libraryManagementFinal.LibrarySystemDataSetTableAdapters.booksTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBooks_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.addBooks_importBtn);
            this.panel1.Controls.Add(this.addBooks_clearBtn);
            this.panel1.Controls.Add(this.addBooks_deleteBtn);
            this.panel1.Controls.Add(this.addBooks_status);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addBooks_published);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addBooks_updateBtn);
            this.panel1.Controls.Add(this.addBooks_addBtn);
            this.panel1.Controls.Add(this.addBooks_author);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.addBooks_bookTitle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.addBooks_picture);
            this.panel1.Location = new System.Drawing.Point(12, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 693);
            this.panel1.TabIndex = 3;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Black;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(311, 236);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(96, 35);
            this.SearchBtn.TabIndex = 25;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(133, 236);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(170, 35);
            this.txt_search.TabIndex = 24;
            // 
            // addBooks_importBtn
            // 
            this.addBooks_importBtn.BackColor = System.Drawing.Color.Teal;
            this.addBooks_importBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_importBtn.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_importBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_importBtn.Location = new System.Drawing.Point(142, 153);
            this.addBooks_importBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBooks_importBtn.Name = "addBooks_importBtn";
            this.addBooks_importBtn.Size = new System.Drawing.Size(143, 35);
            this.addBooks_importBtn.TabIndex = 23;
            this.addBooks_importBtn.Text = "Import";
            this.addBooks_importBtn.UseVisualStyleBackColor = false;
            this.addBooks_importBtn.Click += new System.EventHandler(this.addBooks_importBtn_Click);
            // 
            // addBooks_clearBtn
            // 
            this.addBooks_clearBtn.BackColor = System.Drawing.Color.Teal;
            this.addBooks_clearBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_clearBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_clearBtn.Location = new System.Drawing.Point(259, 577);
            this.addBooks_clearBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBooks_clearBtn.Name = "addBooks_clearBtn";
            this.addBooks_clearBtn.Size = new System.Drawing.Size(148, 52);
            this.addBooks_clearBtn.TabIndex = 22;
            this.addBooks_clearBtn.Text = "CLEAR";
            this.addBooks_clearBtn.UseVisualStyleBackColor = false;
            this.addBooks_clearBtn.Click += new System.EventHandler(this.addBooks_clearBtn_Click);
            // 
            // addBooks_deleteBtn
            // 
            this.addBooks_deleteBtn.BackColor = System.Drawing.Color.Teal;
            this.addBooks_deleteBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_deleteBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_deleteBtn.Location = new System.Drawing.Point(24, 577);
            this.addBooks_deleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBooks_deleteBtn.Name = "addBooks_deleteBtn";
            this.addBooks_deleteBtn.Size = new System.Drawing.Size(148, 52);
            this.addBooks_deleteBtn.TabIndex = 21;
            this.addBooks_deleteBtn.Text = "DELETE";
            this.addBooks_deleteBtn.UseVisualStyleBackColor = false;
            this.addBooks_deleteBtn.Click += new System.EventHandler(this.addBooks_deleteBtn_Click);
            // 
            // addBooks_status
            // 
            this.addBooks_status.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_status.FormattingEnabled = true;
            this.addBooks_status.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.addBooks_status.Location = new System.Drawing.Point(133, 439);
            this.addBooks_status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBooks_status.Name = "addBooks_status";
            this.addBooks_status.Size = new System.Drawing.Size(274, 32);
            this.addBooks_status.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 447);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Status:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addBooks_published
            // 
            this.addBooks_published.Location = new System.Drawing.Point(133, 387);
            this.addBooks_published.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBooks_published.Name = "addBooks_published";
            this.addBooks_published.Size = new System.Drawing.Size(274, 26);
            this.addBooks_published.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 389);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Published:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addBooks_updateBtn
            // 
            this.addBooks_updateBtn.BackColor = System.Drawing.Color.Teal;
            this.addBooks_updateBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_updateBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_updateBtn.Location = new System.Drawing.Point(259, 492);
            this.addBooks_updateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBooks_updateBtn.Name = "addBooks_updateBtn";
            this.addBooks_updateBtn.Size = new System.Drawing.Size(148, 52);
            this.addBooks_updateBtn.TabIndex = 16;
            this.addBooks_updateBtn.Text = "UPDATE";
            this.addBooks_updateBtn.UseVisualStyleBackColor = false;
            this.addBooks_updateBtn.Click += new System.EventHandler(this.addBooks_updateBtn_Click);
            // 
            // addBooks_addBtn
            // 
            this.addBooks_addBtn.BackColor = System.Drawing.Color.Teal;
            this.addBooks_addBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_addBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_addBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_addBtn.Location = new System.Drawing.Point(24, 492);
            this.addBooks_addBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBooks_addBtn.Name = "addBooks_addBtn";
            this.addBooks_addBtn.Size = new System.Drawing.Size(148, 52);
            this.addBooks_addBtn.TabIndex = 15;
            this.addBooks_addBtn.Text = "ADD";
            this.addBooks_addBtn.UseVisualStyleBackColor = false;
            this.addBooks_addBtn.Click += new System.EventHandler(this.addBooks_addBtn_Click);
            // 
            // addBooks_author
            // 
            this.addBooks_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_author.Location = new System.Drawing.Point(133, 335);
            this.addBooks_author.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBooks_author.Name = "addBooks_author";
            this.addBooks_author.Size = new System.Drawing.Size(274, 30);
            this.addBooks_author.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 341);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Author:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addBooks_bookTitle
            // 
            this.addBooks_bookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_bookTitle.Location = new System.Drawing.Point(133, 281);
            this.addBooks_bookTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBooks_bookTitle.Name = "addBooks_bookTitle";
            this.addBooks_bookTitle.Size = new System.Drawing.Size(274, 30);
            this.addBooks_bookTitle.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Book TItle:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addBooks_picture
            // 
            this.addBooks_picture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addBooks_picture.Location = new System.Drawing.Point(142, 16);
            this.addBooks_picture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBooks_picture.Name = "addBooks_picture";
            this.addBooks_picture.Size = new System.Drawing.Size(143, 127);
            this.addBooks_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addBooks_picture.TabIndex = 8;
            this.addBooks_picture.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(17, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(445, 601);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Issued Books";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbcolumn);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(454, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 693);
            this.panel2.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(177, 36);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(285, 28);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbcolumn
            // 
            this.cbcolumn.FormattingEnabled = true;
            this.cbcolumn.Items.AddRange(new object[] {
            "All",
            "ID ",
            "bookTitle",
            "Author"});
            this.cbcolumn.Location = new System.Drawing.Point(17, 36);
            this.cbcolumn.Name = "cbcolumn";
            this.cbcolumn.Size = new System.Drawing.Size(154, 28);
            this.cbcolumn.TabIndex = 6;
            // 
            // librarySystemDataSet
            // 
            this.librarySystemDataSet.DataSetName = "LibrarySystemDataSet";
            this.librarySystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librarySystemDataSetBindingSource
            // 
            this.librarySystemDataSetBindingSource.DataSource = this.librarySystemDataSet;
            this.librarySystemDataSetBindingSource.Position = 0;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.librarySystemDataSetBindingSource;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddBooks";
            this.Size = new System.Drawing.Size(940, 728);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBooks_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addBooks_importBtn;
        private System.Windows.Forms.Button addBooks_clearBtn;
        private System.Windows.Forms.Button addBooks_deleteBtn;
        private System.Windows.Forms.ComboBox addBooks_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker addBooks_published;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBooks_updateBtn;
        private System.Windows.Forms.Button addBooks_addBtn;
        private System.Windows.Forms.TextBox addBooks_author;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addBooks_bookTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox addBooks_picture;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbcolumn;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.BindingSource librarySystemDataSetBindingSource;
        private LibrarySystemDataSet librarySystemDataSet;
        private LibrarySystemDataSetTableAdapters.booksTableAdapter booksTableAdapter;
    }
}
