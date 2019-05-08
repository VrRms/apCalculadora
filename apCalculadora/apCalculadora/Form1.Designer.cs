namespace apCalculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnAbreParent = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnFechaParent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnApagarUm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSequencias = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.BackColor = System.Drawing.SystemColors.Control;
            this.txtVisor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVisor.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.Location = new System.Drawing.Point(8, 9);
            this.txtVisor.MaxLength = 20;
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.ReadOnly = true;
            this.txtVisor.Size = new System.Drawing.Size(376, 31);
            this.txtVisor.TabIndex = 0;
            this.txtVisor.TabStop = false;
            this.txtVisor.Text = "0";
            this.txtVisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResultado
            // 
            this.txtResultado.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.CausesValidation = false;
            this.txtResultado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(8, 44);
            this.txtResultado.MaxLength = 18;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(376, 31);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.TabStop = false;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAbreParent
            // 
            this.btnAbreParent.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAbreParent.BackColor = System.Drawing.Color.Transparent;
            this.btnAbreParent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbreParent.BackgroundImage")));
            this.btnAbreParent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbreParent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbreParent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbreParent.FlatAppearance.BorderSize = 0;
            this.btnAbreParent.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAbreParent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAbreParent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAbreParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbreParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbreParent.ForeColor = System.Drawing.Color.White;
            this.btnAbreParent.Location = new System.Drawing.Point(90, 30);
            this.btnAbreParent.Name = "btnAbreParent";
            this.btnAbreParent.Size = new System.Drawing.Size(60, 56);
            this.btnAbreParent.TabIndex = 36;
            this.btnAbreParent.TabStop = false;
            this.btnAbreParent.Text = "(";
            this.btnAbreParent.UseVisualStyleBackColor = false;
            this.btnAbreParent.Click += new System.EventHandler(this.btnAbreParent_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(229, 274);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 56);
            this.btnClear.TabIndex = 37;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnIgual.BackColor = System.Drawing.Color.Transparent;
            this.btnIgual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIgual.BackgroundImage")));
            this.btnIgual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIgual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIgual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIgual.FlatAppearance.BorderSize = 0;
            this.btnIgual.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnIgual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIgual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.Color.White;
            this.btnIgual.Location = new System.Drawing.Point(297, 213);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(60, 144);
            this.btnIgual.TabIndex = 0;
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnZero
            // 
            this.btnZero.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnZero.BackColor = System.Drawing.Color.Transparent;
            this.btnZero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZero.BackgroundImage")));
            this.btnZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnZero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.Color.White;
            this.btnZero.Location = new System.Drawing.Point(90, 274);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(60, 56);
            this.btnZero.TabIndex = 39;
            this.btnZero.TabStop = false;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnNumerico_Click);
            // 
            // btnUm
            // 
            this.btnUm.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnUm.BackColor = System.Drawing.Color.Transparent;
            this.btnUm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUm.BackgroundImage")));
            this.btnUm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUm.FlatAppearance.BorderSize = 0;
            this.btnUm.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnUm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUm.ForeColor = System.Drawing.Color.White;
            this.btnUm.Location = new System.Drawing.Point(20, 213);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(60, 56);
            this.btnUm.TabIndex = 40;
            this.btnUm.TabStop = false;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = false;
            this.btnUm.Click += new System.EventHandler(this.btnNumerico_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnQuatro.BackColor = System.Drawing.Color.Transparent;
            this.btnQuatro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuatro.BackgroundImage")));
            this.btnQuatro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuatro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuatro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuatro.FlatAppearance.BorderSize = 0;
            this.btnQuatro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnQuatro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuatro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatro.ForeColor = System.Drawing.Color.White;
            this.btnQuatro.Location = new System.Drawing.Point(20, 152);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(60, 56);
            this.btnQuatro.TabIndex = 41;
            this.btnQuatro.TabStop = false;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = false;
            this.btnQuatro.Click += new System.EventHandler(this.btnNumerico_Click);
            // 
            // btnSete
            // 
            this.btnSete.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSete.BackColor = System.Drawing.Color.Transparent;
            this.btnSete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSete.BackgroundImage")));
            this.btnSete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSete.FlatAppearance.BorderSize = 0;
            this.btnSete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSete.ForeColor = System.Drawing.Color.White;
            this.btnSete.Location = new System.Drawing.Point(20, 91);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(60, 56);
            this.btnSete.TabIndex = 42;
            this.btnSete.TabStop = false;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = false;
            this.btnSete.Click += new System.EventHandler(this.btnNumerico_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnPotencia.BackColor = System.Drawing.Color.Transparent;
            this.btnPotencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPotencia.BackgroundImage")));
            this.btnPotencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPotencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPotencia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPotencia.FlatAppearance.BorderSize = 0;
            this.btnPotencia.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPotencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPotencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPotencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotencia.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.ForeColor = System.Drawing.Color.White;
            this.btnPotencia.Location = new System.Drawing.Point(20, 30);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(64, 56);
            this.btnPotencia.TabIndex = 43;
            this.btnPotencia.TabStop = false;
            this.btnPotencia.Text = "^";
            this.btnPotencia.UseVisualStyleBackColor = false;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDivisao.BackColor = System.Drawing.Color.Transparent;
            this.btnDivisao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDivisao.BackgroundImage")));
            this.btnDivisao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDivisao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivisao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDivisao.FlatAppearance.BorderSize = 0;
            this.btnDivisao.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDivisao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDivisao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.ForeColor = System.Drawing.Color.White;
            this.btnDivisao.Location = new System.Drawing.Point(229, 30);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(60, 55);
            this.btnDivisao.TabIndex = 47;
            this.btnDivisao.TabStop = false;
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnOito
            // 
            this.btnOito.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnOito.BackColor = System.Drawing.Color.Transparent;
            this.btnOito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOito.BackgroundImage")));
            this.btnOito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOito.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOito.FlatAppearance.BorderSize = 0;
            this.btnOito.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnOito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOito.ForeColor = System.Drawing.Color.White;
            this.btnOito.Location = new System.Drawing.Point(90, 91);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(60, 56);
            this.btnOito.TabIndex = 46;
            this.btnOito.TabStop = false;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = false;
            this.btnOito.Click += new System.EventHandler(this.btnNumerico_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCinco.BackColor = System.Drawing.Color.Transparent;
            this.btnCinco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCinco.BackgroundImage")));
            this.btnCinco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCinco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCinco.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCinco.FlatAppearance.BorderSize = 0;
            this.btnCinco.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCinco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCinco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.Color.White;
            this.btnCinco.Location = new System.Drawing.Point(90, 152);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(60, 56);
            this.btnCinco.TabIndex = 45;
            this.btnCinco.TabStop = false;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnNumerico_Click);
            // 
            // btnDois
            // 
            this.btnDois.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDois.BackColor = System.Drawing.Color.Transparent;
            this.btnDois.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDois.BackgroundImage")));
            this.btnDois.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDois.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDois.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDois.FlatAppearance.BorderSize = 0;
            this.btnDois.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDois.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDois.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDois.ForeColor = System.Drawing.Color.White;
            this.btnDois.Location = new System.Drawing.Point(90, 213);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(60, 56);
            this.btnDois.TabIndex = 44;
            this.btnDois.TabStop = false;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = false;
            this.btnDois.Click += new System.EventHandler(this.btnNumerico_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.Transparent;
            this.btnMult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMult.BackgroundImage")));
            this.btnMult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMult.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMult.FlatAppearance.BorderSize = 0;
            this.btnMult.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.Color.White;
            this.btnMult.Location = new System.Drawing.Point(229, 90);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(60, 56);
            this.btnMult.TabIndex = 51;
            this.btnMult.TabStop = false;
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnNove
            // 
            this.btnNove.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnNove.BackColor = System.Drawing.Color.Transparent;
            this.btnNove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNove.BackgroundImage")));
            this.btnNove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNove.FlatAppearance.BorderSize = 0;
            this.btnNove.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNove.ForeColor = System.Drawing.Color.White;
            this.btnNove.Location = new System.Drawing.Point(160, 91);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(60, 56);
            this.btnNove.TabIndex = 50;
            this.btnNove.TabStop = false;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = false;
            this.btnNove.Click += new System.EventHandler(this.btnNumerico_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSeis.BackColor = System.Drawing.Color.Transparent;
            this.btnSeis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeis.BackgroundImage")));
            this.btnSeis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSeis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSeis.FlatAppearance.BorderSize = 0;
            this.btnSeis.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSeis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSeis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.Color.White;
            this.btnSeis.Location = new System.Drawing.Point(160, 152);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(60, 56);
            this.btnSeis.TabIndex = 49;
            this.btnSeis.TabStop = false;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnNumerico_Click);
            // 
            // btnTres
            // 
            this.btnTres.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnTres.BackColor = System.Drawing.Color.Transparent;
            this.btnTres.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTres.BackgroundImage")));
            this.btnTres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTres.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTres.FlatAppearance.BorderSize = 0;
            this.btnTres.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnTres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.Color.White;
            this.btnTres.Location = new System.Drawing.Point(160, 213);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(60, 56);
            this.btnTres.TabIndex = 48;
            this.btnTres.TabStop = false;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btnNumerico_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSubtracao.BackColor = System.Drawing.Color.Transparent;
            this.btnSubtracao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubtracao.BackgroundImage")));
            this.btnSubtracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubtracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubtracao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubtracao.FlatAppearance.BorderSize = 0;
            this.btnSubtracao.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSubtracao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSubtracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSubtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.ForeColor = System.Drawing.Color.White;
            this.btnSubtracao.Location = new System.Drawing.Point(229, 151);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(60, 56);
            this.btnSubtracao.TabIndex = 55;
            this.btnSubtracao.TabStop = false;
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSoma.BackColor = System.Drawing.Color.Transparent;
            this.btnSoma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSoma.BackgroundImage")));
            this.btnSoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSoma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoma.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSoma.FlatAppearance.BorderSize = 0;
            this.btnSoma.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSoma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSoma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.ForeColor = System.Drawing.Color.White;
            this.btnSoma.Location = new System.Drawing.Point(229, 212);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(60, 56);
            this.btnSoma.TabIndex = 54;
            this.btnSoma.TabStop = false;
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnPonto.BackColor = System.Drawing.Color.Transparent;
            this.btnPonto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPonto.BackgroundImage")));
            this.btnPonto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPonto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPonto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPonto.FlatAppearance.BorderSize = 0;
            this.btnPonto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPonto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPonto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonto.ForeColor = System.Drawing.Color.White;
            this.btnPonto.Location = new System.Drawing.Point(298, 151);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(60, 56);
            this.btnPonto.TabIndex = 53;
            this.btnPonto.TabStop = false;
            this.btnPonto.UseVisualStyleBackColor = false;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btnFechaParent
            // 
            this.btnFechaParent.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnFechaParent.BackColor = System.Drawing.Color.Transparent;
            this.btnFechaParent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechaParent.BackgroundImage")));
            this.btnFechaParent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechaParent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechaParent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechaParent.FlatAppearance.BorderSize = 0;
            this.btnFechaParent.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnFechaParent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFechaParent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFechaParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechaParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechaParent.ForeColor = System.Drawing.Color.White;
            this.btnFechaParent.Location = new System.Drawing.Point(160, 30);
            this.btnFechaParent.Name = "btnFechaParent";
            this.btnFechaParent.Size = new System.Drawing.Size(60, 56);
            this.btnFechaParent.TabIndex = 52;
            this.btnFechaParent.TabStop = false;
            this.btnFechaParent.Text = ")";
            this.btnFechaParent.UseVisualStyleBackColor = false;
            this.btnFechaParent.Click += new System.EventHandler(this.btnFechaParent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.btnRaiz);
            this.groupBox2.Controls.Add(this.btnApagarUm);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnSete);
            this.groupBox2.Controls.Add(this.btnSubtracao);
            this.groupBox2.Controls.Add(this.btnAbreParent);
            this.groupBox2.Controls.Add(this.btnSoma);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnPonto);
            this.groupBox2.Controls.Add(this.btnIgual);
            this.groupBox2.Controls.Add(this.btnFechaParent);
            this.groupBox2.Controls.Add(this.btnZero);
            this.groupBox2.Controls.Add(this.btnMult);
            this.groupBox2.Controls.Add(this.btnUm);
            this.groupBox2.Controls.Add(this.btnNove);
            this.groupBox2.Controls.Add(this.btnQuatro);
            this.groupBox2.Controls.Add(this.btnSeis);
            this.groupBox2.Controls.Add(this.btnPotencia);
            this.groupBox2.Controls.Add(this.btnTres);
            this.groupBox2.Controls.Add(this.btnDois);
            this.groupBox2.Controls.Add(this.btnDivisao);
            this.groupBox2.Controls.Add(this.btnCinco);
            this.groupBox2.Controls.Add(this.btnOito);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(-2, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 363);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            // 
            // btnRaiz
            // 
            this.btnRaiz.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnRaiz.BackColor = System.Drawing.Color.Transparent;
            this.btnRaiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRaiz.BackgroundImage")));
            this.btnRaiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRaiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaiz.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRaiz.FlatAppearance.BorderSize = 0;
            this.btnRaiz.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRaiz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRaiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.ForeColor = System.Drawing.Color.White;
            this.btnRaiz.Location = new System.Drawing.Point(297, 92);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(60, 56);
            this.btnRaiz.TabIndex = 58;
            this.btnRaiz.TabStop = false;
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnApagarUm
            // 
            this.btnApagarUm.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnApagarUm.BackColor = System.Drawing.Color.Transparent;
            this.btnApagarUm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApagarUm.BackgroundImage")));
            this.btnApagarUm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApagarUm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagarUm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnApagarUm.FlatAppearance.BorderSize = 0;
            this.btnApagarUm.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnApagarUm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnApagarUm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnApagarUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarUm.ForeColor = System.Drawing.Color.White;
            this.btnApagarUm.Location = new System.Drawing.Point(298, 30);
            this.btnApagarUm.Name = "btnApagarUm";
            this.btnApagarUm.Size = new System.Drawing.Size(62, 56);
            this.btnApagarUm.TabIndex = 57;
            this.btnApagarUm.TabStop = false;
            this.btnApagarUm.UseVisualStyleBackColor = false;
            this.btnApagarUm.Click += new System.EventHandler(this.btnApagarUm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(172)))), ((int)(((byte)(198)))));
            this.pictureBox1.Location = new System.Drawing.Point(373, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 350);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lbSequencias);
            this.panel1.Controls.Add(this.txtResultado);
            this.panel1.Controls.Add(this.txtVisor);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 121);
            this.panel1.TabIndex = 58;
            // 
            // lbSequencias
            // 
            this.lbSequencias.AutoSize = true;
            this.lbSequencias.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSequencias.Location = new System.Drawing.Point(5, 82);
            this.lbSequencias.Name = "lbSequencias";
            this.lbSequencias.Size = new System.Drawing.Size(98, 36);
            this.lbSequencias.TabIndex = 2;
            this.lbSequencias.Text = "Posfixa:\r\nInfixa : ";
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(405, 479);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCalculadora_KeyDown);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnAbreParent;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnFechaParent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSequencias;
        private System.Windows.Forms.Button btnApagarUm;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

