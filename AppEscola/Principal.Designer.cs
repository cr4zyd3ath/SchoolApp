
namespace AppEscola
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLivros = new System.Windows.Forms.TabPage();
            this.tabelaLivros = new System.Windows.Forms.DataGridView();
            this.tabEditoras = new System.Windows.Forms.TabPage();
            this.tabelaEditora = new System.Windows.Forms.DataGridView();
            this.tabCategorias = new System.Windows.Forms.TabPage();
            this.tabelaCategorias = new System.Windows.Forms.DataGridView();
            this.tabAutores = new System.Windows.Forms.TabPage();
            this.tabelaAutores = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemCrescenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabLivros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaLivros)).BeginInit();
            this.tabEditoras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEditora)).BeginInit();
            this.tabCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCategorias)).BeginInit();
            this.tabAutores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaAutores)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLivros);
            this.tabControl1.Controls.Add(this.tabEditoras);
            this.tabControl1.Controls.Add(this.tabCategorias);
            this.tabControl1.Controls.Add(this.tabAutores);
            this.tabControl1.Location = new System.Drawing.Point(6, 22);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(959, 425);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabLivros
            // 
            this.tabLivros.Controls.Add(this.tabelaLivros);
            this.tabLivros.Location = new System.Drawing.Point(4, 22);
            this.tabLivros.Margin = new System.Windows.Forms.Padding(2);
            this.tabLivros.Name = "tabLivros";
            this.tabLivros.Padding = new System.Windows.Forms.Padding(2);
            this.tabLivros.Size = new System.Drawing.Size(951, 399);
            this.tabLivros.TabIndex = 0;
            this.tabLivros.Text = "Livros";
            this.tabLivros.UseVisualStyleBackColor = true;
            this.tabLivros.Click += new System.EventHandler(this.tabLivros_Click);
            // 
            // tabelaLivros
            // 
            this.tabelaLivros.AllowUserToAddRows = false;
            this.tabelaLivros.AllowUserToDeleteRows = false;
            this.tabelaLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaLivros.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabelaLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaLivros.Location = new System.Drawing.Point(2, 2);
            this.tabelaLivros.Margin = new System.Windows.Forms.Padding(2);
            this.tabelaLivros.Name = "tabelaLivros";
            this.tabelaLivros.ReadOnly = true;
            this.tabelaLivros.RowHeadersWidth = 62;
            this.tabelaLivros.RowTemplate.Height = 28;
            this.tabelaLivros.Size = new System.Drawing.Size(942, 393);
            this.tabelaLivros.TabIndex = 1;
            this.tabelaLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaLivros_CellContentClick);
            // 
            // tabEditoras
            // 
            this.tabEditoras.Controls.Add(this.tabelaEditora);
            this.tabEditoras.Location = new System.Drawing.Point(4, 22);
            this.tabEditoras.Margin = new System.Windows.Forms.Padding(2);
            this.tabEditoras.Name = "tabEditoras";
            this.tabEditoras.Padding = new System.Windows.Forms.Padding(2);
            this.tabEditoras.Size = new System.Drawing.Size(951, 399);
            this.tabEditoras.TabIndex = 1;
            this.tabEditoras.Text = "Editoras";
            this.tabEditoras.UseVisualStyleBackColor = true;
            // 
            // tabelaEditora
            // 
            this.tabelaEditora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaEditora.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabelaEditora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaEditora.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabelaEditora.Location = new System.Drawing.Point(4, 4);
            this.tabelaEditora.Margin = new System.Windows.Forms.Padding(2);
            this.tabelaEditora.Name = "tabelaEditora";
            this.tabelaEditora.RowHeadersWidth = 62;
            this.tabelaEditora.RowTemplate.Height = 28;
            this.tabelaEditora.Size = new System.Drawing.Size(940, 391);
            this.tabelaEditora.TabIndex = 0;
            this.tabelaEditora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaEditora_CellContentClick);
            // 
            // tabCategorias
            // 
            this.tabCategorias.Controls.Add(this.tabelaCategorias);
            this.tabCategorias.Location = new System.Drawing.Point(4, 22);
            this.tabCategorias.Name = "tabCategorias";
            this.tabCategorias.Size = new System.Drawing.Size(951, 399);
            this.tabCategorias.TabIndex = 2;
            this.tabCategorias.Text = "Categorias";
            this.tabCategorias.UseVisualStyleBackColor = true;
            // 
            // tabelaCategorias
            // 
            this.tabelaCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaCategorias.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabelaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaCategorias.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabelaCategorias.Location = new System.Drawing.Point(4, 4);
            this.tabelaCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.tabelaCategorias.Name = "tabelaCategorias";
            this.tabelaCategorias.RowHeadersWidth = 62;
            this.tabelaCategorias.RowTemplate.Height = 28;
            this.tabelaCategorias.Size = new System.Drawing.Size(940, 391);
            this.tabelaCategorias.TabIndex = 0;
            this.tabelaCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabAutores
            // 
            this.tabAutores.Controls.Add(this.tabelaAutores);
            this.tabAutores.Location = new System.Drawing.Point(4, 22);
            this.tabAutores.Name = "tabAutores";
            this.tabAutores.Size = new System.Drawing.Size(951, 399);
            this.tabAutores.TabIndex = 3;
            this.tabAutores.Text = "Autores";
            this.tabAutores.UseVisualStyleBackColor = true;
            // 
            // tabelaAutores
            // 
            this.tabelaAutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaAutores.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabelaAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaAutores.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabelaAutores.Location = new System.Drawing.Point(4, 4);
            this.tabelaAutores.Margin = new System.Windows.Forms.Padding(2);
            this.tabelaAutores.Name = "tabelaAutores";
            this.tabelaAutores.RowHeadersWidth = 62;
            this.tabelaAutores.RowTemplate.Height = 28;
            this.tabelaAutores.Size = new System.Drawing.Size(940, 391);
            this.tabelaAutores.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorasToolStripMenuItem,
            this.livrosToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(975, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // editorasToolStripMenuItem
            // 
            this.editorasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.editorasToolStripMenuItem.Name = "editorasToolStripMenuItem";
            this.editorasToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.editorasToolStripMenuItem.Text = "Editoras";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inserirToolStripMenuItem.Image")));
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.ShortcutKeyDisplayString = "Alt+I";
            this.inserirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.inserirToolStripMenuItem.Text = "Inserir";
            this.inserirToolStripMenuItem.Click += new System.EventHandler(this.inserirToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarToolStripMenuItem.Image")));
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem1,
            this.listarToolStripMenuItem1,
            this.consultarToolStripMenuItem,
            this.eliminarToolStripMenuItem1});
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.livrosToolStripMenuItem.Text = "Livros";
            // 
            // inserirToolStripMenuItem1
            // 
            this.inserirToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("inserirToolStripMenuItem1.Image")));
            this.inserirToolStripMenuItem1.Name = "inserirToolStripMenuItem1";
            this.inserirToolStripMenuItem1.Size = new System.Drawing.Size(188, 30);
            this.inserirToolStripMenuItem1.Text = "Inserir";
            this.inserirToolStripMenuItem1.Click += new System.EventHandler(this.inserirToolStripMenuItem1_Click);
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("listarToolStripMenuItem1.Image")));
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(188, 30);
            this.listarToolStripMenuItem1.Text = "Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordemCrescenteToolStripMenuItem});
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // ordemCrescenteToolStripMenuItem
            // 
            this.ordemCrescenteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ordemCrescenteToolStripMenuItem.Image")));
            this.ordemCrescenteToolStripMenuItem.Name = "ordemCrescenteToolStripMenuItem";
            this.ordemCrescenteToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.ordemCrescenteToolStripMenuItem.Text = "Ordem Crescente";
            this.ordemCrescenteToolStripMenuItem.Click += new System.EventHandler(this.ordemCrescenteToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(188, 30);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click_1);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem2,
            this.listarToolStripMenuItem2,
            this.eliminarToolStripMenuItem2});
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.autoresToolStripMenuItem.Text = "Autores";
            // 
            // inserirToolStripMenuItem2
            // 
            this.inserirToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("inserirToolStripMenuItem2.Image")));
            this.inserirToolStripMenuItem2.Name = "inserirToolStripMenuItem2";
            this.inserirToolStripMenuItem2.Size = new System.Drawing.Size(188, 30);
            this.inserirToolStripMenuItem2.Text = "Inserir";
            this.inserirToolStripMenuItem2.Click += new System.EventHandler(this.inserirToolStripMenuItem2_Click);
            // 
            // listarToolStripMenuItem2
            // 
            this.listarToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("listarToolStripMenuItem2.Image")));
            this.listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            this.listarToolStripMenuItem2.Size = new System.Drawing.Size(188, 30);
            this.listarToolStripMenuItem2.Text = "Listar";
            this.listarToolStripMenuItem2.Click += new System.EventHandler(this.listarToolStripMenuItem2_Click);
            // 
            // eliminarToolStripMenuItem2
            // 
            this.eliminarToolStripMenuItem2.Name = "eliminarToolStripMenuItem2";
            this.eliminarToolStripMenuItem2.Size = new System.Drawing.Size(188, 30);
            this.eliminarToolStripMenuItem2.Text = "Eliminar";
            this.eliminarToolStripMenuItem2.Click += new System.EventHandler(this.eliminarToolStripMenuItem2_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem3,
            this.listarToolStripMenuItem3,
            this.eliminarToolStripMenuItem3});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // inserirToolStripMenuItem3
            // 
            this.inserirToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("inserirToolStripMenuItem3.Image")));
            this.inserirToolStripMenuItem3.Name = "inserirToolStripMenuItem3";
            this.inserirToolStripMenuItem3.Size = new System.Drawing.Size(117, 22);
            this.inserirToolStripMenuItem3.Text = "Inserir";
            this.inserirToolStripMenuItem3.Click += new System.EventHandler(this.inserirToolStripMenuItem3_Click);
            // 
            // listarToolStripMenuItem3
            // 
            this.listarToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("listarToolStripMenuItem3.Image")));
            this.listarToolStripMenuItem3.Name = "listarToolStripMenuItem3";
            this.listarToolStripMenuItem3.Size = new System.Drawing.Size(117, 22);
            this.listarToolStripMenuItem3.Text = "Listar";
            this.listarToolStripMenuItem3.Click += new System.EventHandler(this.listarToolStripMenuItem3_Click);
            // 
            // eliminarToolStripMenuItem3
            // 
            this.eliminarToolStripMenuItem3.Name = "eliminarToolStripMenuItem3";
            this.eliminarToolStripMenuItem3.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem3.Text = "Eliminar";
            this.eliminarToolStripMenuItem3.Click += new System.EventHandler(this.eliminarToolStripMenuItem3_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.sairToolStripMenuItem.Text = "sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(975, 458);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Gestão de uma Biblioteca";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLivros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaLivros)).EndInit();
            this.tabEditoras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEditora)).EndInit();
            this.tabCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCategorias)).EndInit();
            this.tabAutores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaAutores)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLivros;
        private System.Windows.Forms.DataGridView tabelaLivros;
        private System.Windows.Forms.TabPage tabEditoras;
        private System.Windows.Forms.DataGridView tabelaEditora;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemCrescenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem1;
        private System.Windows.Forms.TabPage tabCategorias;
        private System.Windows.Forms.TabPage tabAutores;
        private System.Windows.Forms.DataGridView tabelaAutores;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem3;
        private System.Windows.Forms.DataGridView tabelaCategorias;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
    }
}

