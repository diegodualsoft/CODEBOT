using FastColoredTextBoxNS;
namespace Codebot
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.dgvcolumnas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltabla = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvtablas = new System.Windows.Forms.DataGridView();
            this.TABLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDb = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LoadDefaul = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.code = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcolumnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtablas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.code)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(36, 423);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Select";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(122, 423);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(57, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Delete";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(200, 423);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(61, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Update";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // dgvcolumnas
            // 
            this.dgvcolumnas.AllowUserToAddRows = false;
            this.dgvcolumnas.AllowUserToDeleteRows = false;
            this.dgvcolumnas.AllowUserToResizeColumns = false;
            this.dgvcolumnas.AllowUserToResizeRows = false;
            this.dgvcolumnas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcolumnas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcolumnas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcolumnas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcolumnas.Location = new System.Drawing.Point(36, 265);
            this.dgvcolumnas.Name = "dgvcolumnas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcolumnas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcolumnas.RowHeadersVisible = false;
            this.dgvcolumnas.Size = new System.Drawing.Size(738, 146);
            this.dgvcolumnas.TabIndex = 3;
            this.dgvcolumnas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcolumnas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TABLA";
            // 
            // lbltabla
            // 
            this.lbltabla.AutoSize = true;
            this.lbltabla.Location = new System.Drawing.Point(91, 229);
            this.lbltabla.Name = "lbltabla";
            this.lbltabla.Size = new System.Drawing.Size(40, 13);
            this.lbltabla.TabIndex = 5;
            this.lbltabla.Text = "lbltabla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CAMPOS";
            // 
            // dgvtablas
            // 
            this.dgvtablas.AllowUserToAddRows = false;
            this.dgvtablas.AllowUserToDeleteRows = false;
            this.dgvtablas.AllowUserToResizeColumns = false;
            this.dgvtablas.AllowUserToResizeRows = false;
            this.dgvtablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtablas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvtablas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TABLA});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtablas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtablas.Location = new System.Drawing.Point(32, 65);
            this.dgvtablas.Name = "dgvtablas";
            this.dgvtablas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtablas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvtablas.RowHeadersVisible = false;
            this.dgvtablas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvtablas.ShowCellErrors = false;
            this.dgvtablas.ShowCellToolTips = false;
            this.dgvtablas.ShowEditingIcon = false;
            this.dgvtablas.ShowRowErrors = false;
            this.dgvtablas.Size = new System.Drawing.Size(282, 152);
            this.dgvtablas.TabIndex = 7;
            this.dgvtablas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtablas_CellClick);
            this.dgvtablas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtablas_CellContentClick);
            // 
            // TABLA
            // 
            this.TABLA.HeaderText = "TABLAS";
            this.TABLA.Name = "TABLA";
            this.TABLA.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "TABLAS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(433, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Generar Codigo C#";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(433, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "CARGAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Datos Del Servidor";
            // 
            // txtDb
            // 
            this.txtDb.Location = new System.Drawing.Point(528, 110);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(208, 20);
            this.txtDb.TabIndex = 15;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(528, 84);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(208, 20);
            this.txtIp.TabIndex = 16;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(528, 136);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(208, 20);
            this.txtuser.TabIndex = 17;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(528, 163);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(208, 20);
            this.txtpass.TabIndex = 18;
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(528, 188);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(208, 20);
            this.txtport.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Direccion Del Servidor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nombre Base De Datos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Usuario Servidor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Contraseña Servidor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Puerto";
            // 
            // LoadDefaul
            // 
            this.LoadDefaul.AutoSize = true;
            this.LoadDefaul.Location = new System.Drawing.Point(528, 49);
            this.LoadDefaul.Name = "LoadDefaul";
            this.LoadDefaul.Size = new System.Drawing.Size(117, 17);
            this.LoadDefaul.TabIndex = 25;
            this.LoadDefaul.Text = "Cargar Por Defecto";
            this.LoadDefaul.UseVisualStyleBackColor = true;
            this.LoadDefaul.CheckedChanged += new System.EventHandler(this.LoadDefaul_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(279, 423);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(52, 17);
            this.checkBox4.TabIndex = 26;
            this.checkBox4.Text = "Insert";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // code
            // 
            this.code.AutoCompleteBrackets = true;
            this.code.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.code.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);\n";
            this.code.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.code.BackBrush = null;
            this.code.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.code.CharHeight = 14;
            this.code.CharWidth = 8;
            this.code.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.code.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.code.IsReplaceMode = false;
            this.code.Language = FastColoredTextBoxNS.Language.CSharp;
            this.code.LeftBracket = '(';
            this.code.LeftBracket2 = '{';
            this.code.Location = new System.Drawing.Point(12, 474);
            this.code.Name = "code";
            this.code.Paddings = new System.Windows.Forms.Padding(0);
            this.code.ReadOnly = true;
            this.code.RightBracket = ')';
            this.code.RightBracket2 = '}';
            this.code.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.code.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("code.ServiceColors")));
            this.code.ShowFoldingLines = true;
            this.code.Size = new System.Drawing.Size(762, 194);
            this.code.TabIndex = 28;
            this.code.UseWaitCursor = true;
            this.code.VirtualSpace = true;
            this.code.WideCaret = true;
            this.code.WordWrap = true;
            this.code.Zoom = 100;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(823, 680);
            this.Controls.Add(this.code);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.LoadDefaul);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.txtDb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvtablas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltabla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvcolumnas);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcolumnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtablas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.code)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.DataGridView dgvcolumnas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltabla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvtablas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TABLA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox LoadDefaul;
        public System.Windows.Forms.TextBox txtDb;
        public System.Windows.Forms.TextBox txtIp;
        public System.Windows.Forms.TextBox txtuser;
        public System.Windows.Forms.TextBox txtpass;
        public System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.CheckBox checkBox4;
        private FastColoredTextBox code;
    }
}

