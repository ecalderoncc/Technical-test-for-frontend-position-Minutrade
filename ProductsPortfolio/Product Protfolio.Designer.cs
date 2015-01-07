namespace ProductsPortfolio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel_update = new System.Windows.Forms.Panel();
            this.groupBox_update = new System.Windows.Forms.GroupBox();
            this.label_category_update = new System.Windows.Forms.Label();
            this.textBox_price_update = new System.Windows.Forms.TextBox();
            this.label_price_update = new System.Windows.Forms.Label();
            this.textBox_name_update = new System.Windows.Forms.TextBox();
            this.label_name_update = new System.Windows.Forms.Label();
            this.button_back_update = new System.Windows.Forms.Button();
            this.button_reset_update = new System.Windows.Forms.Button();
            this.button_accept_update = new System.Windows.Forms.Button();
            this.panel_create = new System.Windows.Forms.Panel();
            this.groupBox_create = new System.Windows.Forms.GroupBox();
            this.label_category_create = new System.Windows.Forms.Label();
            this.textBox_price_create = new System.Windows.Forms.TextBox();
            this.label_price_create = new System.Windows.Forms.Label();
            this.textBox_name_create = new System.Windows.Forms.TextBox();
            this.label_name_create = new System.Windows.Forms.Label();
            this.btn_back_create = new System.Windows.Forms.Button();
            this.btn_reset_create = new System.Windows.Forms.Button();
            this.btn_accept_create = new System.Windows.Forms.Button();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.textBox_category_update = new System.Windows.Forms.TextBox();
            this.textBox_category_create = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_update.SuspendLayout();
            this.groupBox_update.SuspendLayout();
            this.panel_create.SuspendLayout();
            this.groupBox_create.SuspendLayout();
            this.panel_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_update);
            this.splitContainer1.Panel1.Controls.Add(this.btn_delete);
            this.splitContainer1.Panel1.Controls.Add(this.btn_create);
            this.splitContainer1.Panel1.Controls.Add(this.btn_exit);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_update);
            this.splitContainer1.Panel2.Controls.Add(this.panel_create);
            this.splitContainer1.Panel2.Controls.Add(this.panel_principal);
            this.splitContainer1.Size = new System.Drawing.Size(884, 412);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 1;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_update.Location = new System.Drawing.Point(3, 75);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(173, 46);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_delete.Location = new System.Drawing.Point(3, 127);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(173, 46);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_create.Location = new System.Drawing.Point(3, 23);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(173, 46);
            this.btn_create.TabIndex = 1;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_exit.Location = new System.Drawing.Point(3, 346);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(173, 46);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel_update
            // 
            this.panel_update.Controls.Add(this.groupBox_update);
            this.panel_update.Controls.Add(this.button_back_update);
            this.panel_update.Controls.Add(this.button_reset_update);
            this.panel_update.Controls.Add(this.button_accept_update);
            this.panel_update.Location = new System.Drawing.Point(4, 0);
            this.panel_update.Name = "panel_update";
            this.panel_update.Size = new System.Drawing.Size(698, 403);
            this.panel_update.TabIndex = 1;
            // 
            // groupBox_update
            // 
            this.groupBox_update.Controls.Add(this.textBox_category_update);
            this.groupBox_update.Controls.Add(this.label_category_update);
            this.groupBox_update.Controls.Add(this.textBox_price_update);
            this.groupBox_update.Controls.Add(this.label_price_update);
            this.groupBox_update.Controls.Add(this.textBox_name_update);
            this.groupBox_update.Controls.Add(this.label_name_update);
            this.groupBox_update.Location = new System.Drawing.Point(37, 54);
            this.groupBox_update.Name = "groupBox_update";
            this.groupBox_update.Size = new System.Drawing.Size(630, 175);
            this.groupBox_update.TabIndex = 13;
            this.groupBox_update.TabStop = false;
            this.groupBox_update.Text = "Update Product Information";
            // 
            // label_category_update
            // 
            this.label_category_update.AutoSize = true;
            this.label_category_update.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label_category_update.Location = new System.Drawing.Point(340, 112);
            this.label_category_update.Name = "label_category_update";
            this.label_category_update.Size = new System.Drawing.Size(88, 25);
            this.label_category_update.TabIndex = 12;
            this.label_category_update.Text = "Category";
            // 
            // textBox_price_update
            // 
            this.textBox_price_update.Location = new System.Drawing.Point(131, 115);
            this.textBox_price_update.Multiline = true;
            this.textBox_price_update.Name = "textBox_price_update";
            this.textBox_price_update.Size = new System.Drawing.Size(101, 25);
            this.textBox_price_update.TabIndex = 9;
            // 
            // label_price_update
            // 
            this.label_price_update.AutoSize = true;
            this.label_price_update.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label_price_update.Location = new System.Drawing.Point(63, 115);
            this.label_price_update.Name = "label_price_update";
            this.label_price_update.Size = new System.Drawing.Size(54, 25);
            this.label_price_update.TabIndex = 10;
            this.label_price_update.Text = "Price";
            // 
            // textBox_name_update
            // 
            this.textBox_name_update.Location = new System.Drawing.Point(131, 63);
            this.textBox_name_update.Multiline = true;
            this.textBox_name_update.Name = "textBox_name_update";
            this.textBox_name_update.Size = new System.Drawing.Size(403, 25);
            this.textBox_name_update.TabIndex = 7;
            // 
            // label_name_update
            // 
            this.label_name_update.AutoSize = true;
            this.label_name_update.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label_name_update.Location = new System.Drawing.Point(63, 63);
            this.label_name_update.Name = "label_name_update";
            this.label_name_update.Size = new System.Drawing.Size(62, 25);
            this.label_name_update.TabIndex = 8;
            this.label_name_update.Text = "Name";
            // 
            // button_back_update
            // 
            this.button_back_update.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button_back_update.Location = new System.Drawing.Point(430, 307);
            this.button_back_update.Name = "button_back_update";
            this.button_back_update.Size = new System.Drawing.Size(173, 46);
            this.button_back_update.TabIndex = 12;
            this.button_back_update.Text = "Back";
            this.button_back_update.UseVisualStyleBackColor = true;
            this.button_back_update.Click += new System.EventHandler(this.button_back_update_Click);
            // 
            // button_reset_update
            // 
            this.button_reset_update.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button_reset_update.Location = new System.Drawing.Point(251, 307);
            this.button_reset_update.Name = "button_reset_update";
            this.button_reset_update.Size = new System.Drawing.Size(173, 46);
            this.button_reset_update.TabIndex = 11;
            this.button_reset_update.Text = "Reset";
            this.button_reset_update.UseVisualStyleBackColor = true;
            this.button_reset_update.Click += new System.EventHandler(this.button_reset_update_Click);
            // 
            // button_accept_update
            // 
            this.button_accept_update.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button_accept_update.Location = new System.Drawing.Point(72, 307);
            this.button_accept_update.Name = "button_accept_update";
            this.button_accept_update.Size = new System.Drawing.Size(173, 46);
            this.button_accept_update.TabIndex = 10;
            this.button_accept_update.Text = "Accept";
            this.button_accept_update.UseVisualStyleBackColor = true;
            this.button_accept_update.Click += new System.EventHandler(this.button_accept_update_Click);
            // 
            // panel_create
            // 
            this.panel_create.Controls.Add(this.groupBox_create);
            this.panel_create.Controls.Add(this.btn_back_create);
            this.panel_create.Controls.Add(this.btn_reset_create);
            this.panel_create.Controls.Add(this.btn_accept_create);
            this.panel_create.Location = new System.Drawing.Point(1, 3);
            this.panel_create.Name = "panel_create";
            this.panel_create.Size = new System.Drawing.Size(698, 403);
            this.panel_create.TabIndex = 0;
            // 
            // groupBox_create
            // 
            this.groupBox_create.Controls.Add(this.textBox_category_create);
            this.groupBox_create.Controls.Add(this.label_category_create);
            this.groupBox_create.Controls.Add(this.textBox_price_create);
            this.groupBox_create.Controls.Add(this.label_price_create);
            this.groupBox_create.Controls.Add(this.textBox_name_create);
            this.groupBox_create.Controls.Add(this.label_name_create);
            this.groupBox_create.Location = new System.Drawing.Point(40, 51);
            this.groupBox_create.Name = "groupBox_create";
            this.groupBox_create.Size = new System.Drawing.Size(630, 175);
            this.groupBox_create.TabIndex = 9;
            this.groupBox_create.TabStop = false;
            this.groupBox_create.Text = "Create Product";
            // 
            // label_category_create
            // 
            this.label_category_create.AutoSize = true;
            this.label_category_create.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label_category_create.Location = new System.Drawing.Point(340, 112);
            this.label_category_create.Name = "label_category_create";
            this.label_category_create.Size = new System.Drawing.Size(88, 25);
            this.label_category_create.TabIndex = 12;
            this.label_category_create.Text = "Category";
            // 
            // textBox_price_create
            // 
            this.textBox_price_create.Location = new System.Drawing.Point(131, 115);
            this.textBox_price_create.Multiline = true;
            this.textBox_price_create.Name = "textBox_price_create";
            this.textBox_price_create.Size = new System.Drawing.Size(101, 25);
            this.textBox_price_create.TabIndex = 9;
            // 
            // label_price_create
            // 
            this.label_price_create.AutoSize = true;
            this.label_price_create.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label_price_create.Location = new System.Drawing.Point(63, 115);
            this.label_price_create.Name = "label_price_create";
            this.label_price_create.Size = new System.Drawing.Size(54, 25);
            this.label_price_create.TabIndex = 10;
            this.label_price_create.Text = "Price";
            // 
            // textBox_name_create
            // 
            this.textBox_name_create.Location = new System.Drawing.Point(131, 63);
            this.textBox_name_create.Multiline = true;
            this.textBox_name_create.Name = "textBox_name_create";
            this.textBox_name_create.Size = new System.Drawing.Size(403, 25);
            this.textBox_name_create.TabIndex = 7;
            // 
            // label_name_create
            // 
            this.label_name_create.AutoSize = true;
            this.label_name_create.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label_name_create.Location = new System.Drawing.Point(63, 63);
            this.label_name_create.Name = "label_name_create";
            this.label_name_create.Size = new System.Drawing.Size(62, 25);
            this.label_name_create.TabIndex = 8;
            this.label_name_create.Text = "Name";
            // 
            // btn_back_create
            // 
            this.btn_back_create.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_back_create.Location = new System.Drawing.Point(433, 304);
            this.btn_back_create.Name = "btn_back_create";
            this.btn_back_create.Size = new System.Drawing.Size(173, 46);
            this.btn_back_create.TabIndex = 6;
            this.btn_back_create.Text = "Back";
            this.btn_back_create.UseVisualStyleBackColor = true;
            this.btn_back_create.Click += new System.EventHandler(this.btn_back_create_Click);
            // 
            // btn_reset_create
            // 
            this.btn_reset_create.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_reset_create.Location = new System.Drawing.Point(254, 304);
            this.btn_reset_create.Name = "btn_reset_create";
            this.btn_reset_create.Size = new System.Drawing.Size(173, 46);
            this.btn_reset_create.TabIndex = 5;
            this.btn_reset_create.Text = "Reset";
            this.btn_reset_create.UseVisualStyleBackColor = true;
            this.btn_reset_create.Click += new System.EventHandler(this.btn_reset_create_Click);
            // 
            // btn_accept_create
            // 
            this.btn_accept_create.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_accept_create.Location = new System.Drawing.Point(75, 304);
            this.btn_accept_create.Name = "btn_accept_create";
            this.btn_accept_create.Size = new System.Drawing.Size(173, 46);
            this.btn_accept_create.TabIndex = 4;
            this.btn_accept_create.Text = "Accept";
            this.btn_accept_create.UseVisualStyleBackColor = true;
            this.btn_accept_create.Click += new System.EventHandler(this.btn_accept_create_Click);
            // 
            // panel_principal
            // 
            this.panel_principal.Controls.Add(this.dataGridView1);
            this.panel_principal.Location = new System.Drawing.Point(1, 3);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(704, 406);
            this.panel_principal.TabIndex = 1;
            // 
            // textBox_category_update
            // 
            this.textBox_category_update.Location = new System.Drawing.Point(434, 115);
            this.textBox_category_update.Multiline = true;
            this.textBox_category_update.Name = "textBox_category_update";
            this.textBox_category_update.Size = new System.Drawing.Size(101, 25);
            this.textBox_category_update.TabIndex = 13;
            // 
            // textBox_category_create
            // 
            this.textBox_category_create.Location = new System.Drawing.Point(434, 115);
            this.textBox_category_create.Multiline = true;
            this.textBox_category_create.Name = "textBox_category_create";
            this.textBox_category_create.Size = new System.Drawing.Size(101, 25);
            this.textBox_category_create.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 412);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(902, 459);
            this.MinimumSize = new System.Drawing.Size(902, 459);
            this.Name = "Form1";
            this.Text = "Product Portfolio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_update.ResumeLayout(false);
            this.groupBox_update.ResumeLayout(false);
            this.groupBox_update.PerformLayout();
            this.panel_create.ResumeLayout(false);
            this.groupBox_create.ResumeLayout(false);
            this.groupBox_create.PerformLayout();
            this.panel_principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Panel panel_update;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.Panel panel_create;
        private System.Windows.Forms.GroupBox groupBox_create;
        private System.Windows.Forms.TextBox textBox_name_create;
        private System.Windows.Forms.Label label_name_create;
        private System.Windows.Forms.Button btn_back_create;
        private System.Windows.Forms.Button btn_reset_create;
        private System.Windows.Forms.Button btn_accept_create;
        private System.Windows.Forms.Label label_category_create;
        private System.Windows.Forms.TextBox textBox_price_create;
        private System.Windows.Forms.Label label_price_create;
        private System.Windows.Forms.GroupBox groupBox_update;
        private System.Windows.Forms.Label label_category_update;
        private System.Windows.Forms.TextBox textBox_price_update;
        private System.Windows.Forms.Label label_price_update;
        private System.Windows.Forms.TextBox textBox_name_update;
        private System.Windows.Forms.Label label_name_update;
        private System.Windows.Forms.Button button_back_update;
        private System.Windows.Forms.Button button_reset_update;
        private System.Windows.Forms.Button button_accept_update;
        private System.Windows.Forms.TextBox textBox_category_update;
        private System.Windows.Forms.TextBox textBox_category_create;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}

