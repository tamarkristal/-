namespace Apartment_project_codeFirstToDb
{
    partial class SearchForm
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
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_showAll = new System.Windows.Forms.Button();
            this.btn_mewrent = new System.Windows.Forms.Button();
            this.cm_search = new System.Windows.Forms.ComboBox();
            this.tx_city = new System.Windows.Forms.TextBox();
            this.lb_street_city = new System.Windows.Forms.Label();
            this.tx_id_owner = new System.Windows.Forms.TextBox();
            this.dg_show_search = new System.Windows.Forms.DataGridView();
            this.lb_owner = new System.Windows.Forms.Label();
            this.tx_street = new System.Windows.Forms.TextBox();
            this.btn_newSold = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_show_search)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(835, 540);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(79, 36);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "חפש";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(66, 540);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(84, 37);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "מחק";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_showAll
            // 
            this.btn_showAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_showAll.ForeColor = System.Drawing.Color.Black;
            this.btn_showAll.Location = new System.Drawing.Point(666, 540);
            this.btn_showAll.Margin = new System.Windows.Forms.Padding(2);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(81, 37);
            this.btn_showAll.TabIndex = 2;
            this.btn_showAll.Text = "הצג הכל";
            this.btn_showAll.UseVisualStyleBackColor = true;
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // btn_mewrent
            // 
            this.btn_mewrent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_mewrent.ForeColor = System.Drawing.Color.Black;
            this.btn_mewrent.Location = new System.Drawing.Point(443, 535);
            this.btn_mewrent.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mewrent.Name = "btn_mewrent";
            this.btn_mewrent.Size = new System.Drawing.Size(159, 46);
            this.btn_mewrent.TabIndex = 3;
            this.btn_mewrent.Text = "דירה להשכרה חדשה";
            this.btn_mewrent.UseVisualStyleBackColor = true;
            this.btn_mewrent.Click += new System.EventHandler(this.btn_mew_Click);
            // 
            // cm_search
            // 
            this.cm_search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cm_search.FormattingEnabled = true;
            this.cm_search.Items.AddRange(new object[] {
            "דירות להשכרה",
            "דירות למכירה",
            "דירות שמחירן נמוך מהממוצע",
            "דירות שיש להן ריהוט",
            "סווג הדירות בחלוקה עפי מחיר מקסימאלי ומחיר מינמאלי לפי ערים"});
            this.cm_search.Location = new System.Drawing.Point(596, 74);
            this.cm_search.Margin = new System.Windows.Forms.Padding(2);
            this.cm_search.Name = "cm_search";
            this.cm_search.Size = new System.Drawing.Size(359, 27);
            this.cm_search.TabIndex = 4;
            this.cm_search.Text = "אפשרויות לחיפוש";
            // 
            // tx_city
            // 
            this.tx_city.Location = new System.Drawing.Point(34, 79);
            this.tx_city.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tx_city.Name = "tx_city";
            this.tx_city.Size = new System.Drawing.Size(116, 22);
            this.tx_city.TabIndex = 6;
            // 
            // lb_street_city
            // 
            this.lb_street_city.AutoSize = true;
            this.lb_street_city.BackColor = System.Drawing.Color.Transparent;
            this.lb_street_city.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_street_city.ForeColor = System.Drawing.Color.Black;
            this.lb_street_city.Location = new System.Drawing.Point(31, 44);
            this.lb_street_city.Name = "lb_street_city";
            this.lb_street_city.Size = new System.Drawing.Size(164, 19);
            this.lb_street_city.TabIndex = 7;
            this.lb_street_city.Text = ":הכנס עיר ורחוב לחיפוש";
            // 
            // tx_id_owner
            // 
            this.tx_id_owner.Location = new System.Drawing.Point(213, 79);
            this.tx_id_owner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tx_id_owner.Name = "tx_id_owner";
            this.tx_id_owner.Size = new System.Drawing.Size(116, 22);
            this.tx_id_owner.TabIndex = 12;
            // 
            // dg_show_search
            // 
            this.dg_show_search.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dg_show_search.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_show_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_show_search.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dg_show_search.Location = new System.Drawing.Point(63, 340);
            this.dg_show_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dg_show_search.Name = "dg_show_search";
            this.dg_show_search.Size = new System.Drawing.Size(851, 172);
            this.dg_show_search.TabIndex = 16;
            this.dg_show_search.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_show_search_RowHeaderMouseDoubleClick);
            // 
            // lb_owner
            // 
            this.lb_owner.AutoSize = true;
            this.lb_owner.BackColor = System.Drawing.Color.Transparent;
            this.lb_owner.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_owner.ForeColor = System.Drawing.Color.Black;
            this.lb_owner.Location = new System.Drawing.Point(210, 44);
            this.lb_owner.Name = "lb_owner";
            this.lb_owner.Size = new System.Drawing.Size(165, 19);
            this.lb_owner.TabIndex = 9;
            this.lb_owner.Text = "חפש לפי תז של הבעלים";
            // 
            // tx_street
            // 
            this.tx_street.Location = new System.Drawing.Point(34, 109);
            this.tx_street.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tx_street.Name = "tx_street";
            this.tx_street.Size = new System.Drawing.Size(116, 22);
            this.tx_street.TabIndex = 17;
            // 
            // btn_newSold
            // 
            this.btn_newSold.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_newSold.ForeColor = System.Drawing.Color.Black;
            this.btn_newSold.Location = new System.Drawing.Point(213, 535);
            this.btn_newSold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_newSold.Name = "btn_newSold";
            this.btn_newSold.Size = new System.Drawing.Size(163, 46);
            this.btn_newSold.TabIndex = 18;
            this.btn_newSold.Text = "דירה למכירה חדשה";
            this.btn_newSold.UseVisualStyleBackColor = true;
            this.btn_newSold.Click += new System.EventHandler(this.btn_newSold_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(372, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "משרד תיווך דירות ";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Apartment_project_codeFirstToDb.Properties.Resources.s1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_newSold);
            this.Controls.Add(this.tx_street);
            this.Controls.Add(this.dg_show_search);
            this.Controls.Add(this.tx_id_owner);
            this.Controls.Add(this.lb_owner);
            this.Controls.Add(this.lb_street_city);
            this.Controls.Add(this.tx_city);
            this.Controls.Add(this.cm_search);
            this.Controls.Add(this.btn_mewrent);
            this.Controls.Add(this.btn_showAll);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_search);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchForm";
            this.Text = "Form1";

            ((System.ComponentModel.ISupportInitialize)(this.dg_show_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_showAll;
        private System.Windows.Forms.Button btn_mewrent;
        private System.Windows.Forms.ComboBox cm_search;
        private System.Windows.Forms.TextBox tx_city;
        private System.Windows.Forms.Label lb_street_city;
        private System.Windows.Forms.TextBox tx_id_owner;
        private System.Windows.Forms.DataGridView dg_show_search;
        private System.Windows.Forms.Label lb_owner;
        private System.Windows.Forms.TextBox tx_street;
        private System.Windows.Forms.Button btn_newSold;
        private System.Windows.Forms.Label label1;
    }
}

