namespace Optics_1._0
{
    partial class Form2
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
            this.checkPayment = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.Balancetxt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Advancetxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Totaltxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.L_ADDtxt = new System.Windows.Forms.TextBox();
            this.L_AXIStxt = new System.Windows.Forms.TextBox();
            this.L_CYLtxt = new System.Windows.Forms.TextBox();
            this.L_SPHtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Distancetxt = new System.Windows.Forms.TextBox();
            this.Readingtxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.optics_DBDataSet = new Optics_1._0.Optics_DBDataSet();
            this.opticsDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Optics_1._0.Optics_DBDataSetTableAdapters.CustomerTableAdapter();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rSPHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCYLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAXISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rADDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lSPHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCYLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lAXISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lADDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optics_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticsDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // checkPayment
            // 
            this.checkPayment.AutoSize = true;
            this.checkPayment.Location = new System.Drawing.Point(658, 114);
            this.checkPayment.Name = "checkPayment";
            this.checkPayment.Size = new System.Drawing.Size(15, 14);
            this.checkPayment.TabIndex = 71;
            this.checkPayment.UseVisualStyleBackColor = true;
            this.checkPayment.CheckedChanged += new System.EventHandler(this.checkPayment_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(793, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 23);
            this.label20.TabIndex = 70;
            this.label20.Text = "BALANCE :";
            // 
            // Balancetxt
            // 
            this.Balancetxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancetxt.Location = new System.Drawing.Point(913, 70);
            this.Balancetxt.Name = "Balancetxt";
            this.Balancetxt.Size = new System.Drawing.Size(189, 26);
            this.Balancetxt.TabIndex = 69;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(793, 112);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 23);
            this.label21.TabIndex = 68;
            this.label21.Text = "ADVANCE : ";
            // 
            // Advancetxt
            // 
            this.Advancetxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advancetxt.Location = new System.Drawing.Point(913, 109);
            this.Advancetxt.Name = "Advancetxt";
            this.Advancetxt.Size = new System.Drawing.Size(189, 26);
            this.Advancetxt.TabIndex = 67;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(793, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 23);
            this.label19.TabIndex = 66;
            this.label19.Text = "TOTAL :  ";
            // 
            // Totaltxt
            // 
            this.Totaltxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totaltxt.Location = new System.Drawing.Point(913, 30);
            this.Totaltxt.Name = "Totaltxt";
            this.Totaltxt.Size = new System.Drawing.Size(189, 26);
            this.Totaltxt.TabIndex = 65;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(471, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 23);
            this.label12.TabIndex = 64;
            this.label12.Text = "DELIVERED PAYMENT : ";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(133, 104);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(211, 26);
            this.txtPhone.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 61;
            this.label4.Text = "Phone : ";
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(133, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 26);
            this.txtName.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "Name : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Invoice # ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(133, 34);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(211, 24);
            this.txtID.TabIndex = 57;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.L_ADDtxt);
            this.panel2.Controls.Add(this.L_AXIStxt);
            this.panel2.Controls.Add(this.L_CYLtxt);
            this.panel2.Controls.Add(this.L_SPHtxt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(58, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 224);
            this.panel2.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 23);
            this.label10.TabIndex = 50;
            this.label10.Text = "ADD.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 23);
            this.label8.TabIndex = 49;
            this.label8.Text = "AXIS.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 23);
            this.label13.TabIndex = 48;
            this.label13.Text = "CYL.";
            // 
            // L_ADDtxt
            // 
            this.L_ADDtxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ADDtxt.Location = new System.Drawing.Point(83, 172);
            this.L_ADDtxt.Name = "L_ADDtxt";
            this.L_ADDtxt.Size = new System.Drawing.Size(156, 26);
            this.L_ADDtxt.TabIndex = 41;
            // 
            // L_AXIStxt
            // 
            this.L_AXIStxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_AXIStxt.Location = new System.Drawing.Point(83, 122);
            this.L_AXIStxt.Name = "L_AXIStxt";
            this.L_AXIStxt.Size = new System.Drawing.Size(156, 26);
            this.L_AXIStxt.TabIndex = 37;
            // 
            // L_CYLtxt
            // 
            this.L_CYLtxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_CYLtxt.Location = new System.Drawing.Point(83, 73);
            this.L_CYLtxt.Name = "L_CYLtxt";
            this.L_CYLtxt.Size = new System.Drawing.Size(156, 26);
            this.L_CYLtxt.TabIndex = 33;
            // 
            // L_SPHtxt
            // 
            this.L_SPHtxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_SPHtxt.Location = new System.Drawing.Point(83, 21);
            this.L_SPHtxt.Name = "L_SPHtxt";
            this.L_SPHtxt.Size = new System.Drawing.Size(156, 26);
            this.L_SPHtxt.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "SPH.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(470, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 26);
            this.label14.TabIndex = 43;
            this.label14.Text = "DISTANCE";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(62, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 26);
            this.label15.TabIndex = 44;
            this.label15.Text = "RIGHT EYE";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(62, 410);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 26);
            this.label16.TabIndex = 45;
            this.label16.Text = "LEFT EYE";
            // 
            // Distancetxt
            // 
            this.Distancetxt.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distancetxt.Location = new System.Drawing.Point(589, 33);
            this.Distancetxt.Name = "Distancetxt";
            this.Distancetxt.Size = new System.Drawing.Size(156, 30);
            this.Distancetxt.TabIndex = 52;
            // 
            // Readingtxt
            // 
            this.Readingtxt.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Readingtxt.Location = new System.Drawing.Point(589, 69);
            this.Readingtxt.Name = "Readingtxt";
            this.Readingtxt.Size = new System.Drawing.Size(156, 30);
            this.Readingtxt.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(470, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 26);
            this.label17.TabIndex = 46;
            this.label17.Text = "READING";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(58, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 224);
            this.panel1.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 50;
            this.label3.Text = "ADD.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 49;
            this.label5.Text = "AXIS.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 23);
            this.label6.TabIndex = 48;
            this.label6.Text = "CYL.";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(83, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 26);
            this.textBox1.TabIndex = 41;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(83, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 26);
            this.textBox2.TabIndex = 37;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(83, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 26);
            this.textBox3.TabIndex = 33;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(83, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 26);
            this.textBox4.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "SPH.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn,
            this.rSPHDataGridViewTextBoxColumn,
            this.rCYLDataGridViewTextBoxColumn,
            this.rAXISDataGridViewTextBoxColumn,
            this.rADDDataGridViewTextBoxColumn,
            this.lSPHDataGridViewTextBoxColumn,
            this.lCYLDataGridViewTextBoxColumn,
            this.lAXISDataGridViewTextBoxColumn,
            this.lADDDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.readingDataGridViewTextBoxColumn,
            this.deliveredDataGridViewCheckBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.advanceDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(354, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 543);
            this.dataGridView1.TabIndex = 72;
            // 
            // optics_DBDataSet
            // 
            this.optics_DBDataSet.DataSetName = "Optics_DBDataSet";
            this.optics_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opticsDBDataSetBindingSource
            // 
            this.opticsDBDataSetBindingSource.DataSource = this.optics_DBDataSet;
            this.opticsDBDataSetBindingSource.Position = 0;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.optics_DBDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            // 
            // rSPHDataGridViewTextBoxColumn
            // 
            this.rSPHDataGridViewTextBoxColumn.DataPropertyName = "R_SPH";
            this.rSPHDataGridViewTextBoxColumn.HeaderText = "R_SPH";
            this.rSPHDataGridViewTextBoxColumn.Name = "rSPHDataGridViewTextBoxColumn";
            // 
            // rCYLDataGridViewTextBoxColumn
            // 
            this.rCYLDataGridViewTextBoxColumn.DataPropertyName = "R_CYL";
            this.rCYLDataGridViewTextBoxColumn.HeaderText = "R_CYL";
            this.rCYLDataGridViewTextBoxColumn.Name = "rCYLDataGridViewTextBoxColumn";
            // 
            // rAXISDataGridViewTextBoxColumn
            // 
            this.rAXISDataGridViewTextBoxColumn.DataPropertyName = "R_AXIS";
            this.rAXISDataGridViewTextBoxColumn.HeaderText = "R_AXIS";
            this.rAXISDataGridViewTextBoxColumn.Name = "rAXISDataGridViewTextBoxColumn";
            // 
            // rADDDataGridViewTextBoxColumn
            // 
            this.rADDDataGridViewTextBoxColumn.DataPropertyName = "R_ADD";
            this.rADDDataGridViewTextBoxColumn.HeaderText = "R_ADD";
            this.rADDDataGridViewTextBoxColumn.Name = "rADDDataGridViewTextBoxColumn";
            // 
            // lSPHDataGridViewTextBoxColumn
            // 
            this.lSPHDataGridViewTextBoxColumn.DataPropertyName = "L_SPH";
            this.lSPHDataGridViewTextBoxColumn.HeaderText = "L_SPH";
            this.lSPHDataGridViewTextBoxColumn.Name = "lSPHDataGridViewTextBoxColumn";
            // 
            // lCYLDataGridViewTextBoxColumn
            // 
            this.lCYLDataGridViewTextBoxColumn.DataPropertyName = "L_CYL";
            this.lCYLDataGridViewTextBoxColumn.HeaderText = "L_CYL";
            this.lCYLDataGridViewTextBoxColumn.Name = "lCYLDataGridViewTextBoxColumn";
            // 
            // lAXISDataGridViewTextBoxColumn
            // 
            this.lAXISDataGridViewTextBoxColumn.DataPropertyName = "L_AXIS";
            this.lAXISDataGridViewTextBoxColumn.HeaderText = "L_AXIS";
            this.lAXISDataGridViewTextBoxColumn.Name = "lAXISDataGridViewTextBoxColumn";
            // 
            // lADDDataGridViewTextBoxColumn
            // 
            this.lADDDataGridViewTextBoxColumn.DataPropertyName = "L_ADD";
            this.lADDDataGridViewTextBoxColumn.HeaderText = "L_ADD";
            this.lADDDataGridViewTextBoxColumn.Name = "lADDDataGridViewTextBoxColumn";
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            // 
            // readingDataGridViewTextBoxColumn
            // 
            this.readingDataGridViewTextBoxColumn.DataPropertyName = "Reading";
            this.readingDataGridViewTextBoxColumn.HeaderText = "Reading";
            this.readingDataGridViewTextBoxColumn.Name = "readingDataGridViewTextBoxColumn";
            // 
            // deliveredDataGridViewCheckBoxColumn
            // 
            this.deliveredDataGridViewCheckBoxColumn.DataPropertyName = "Delivered";
            this.deliveredDataGridViewCheckBoxColumn.HeaderText = "Delivered";
            this.deliveredDataGridViewCheckBoxColumn.Name = "deliveredDataGridViewCheckBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // advanceDataGridViewTextBoxColumn
            // 
            this.advanceDataGridViewTextBoxColumn.DataPropertyName = "Advance";
            this.advanceDataGridViewTextBoxColumn.HeaderText = "Advance";
            this.advanceDataGridViewTextBoxColumn.Name = "advanceDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 703);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Readingtxt);
            this.Controls.Add(this.Distancetxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkPayment);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Balancetxt);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Advancetxt);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Totaltxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optics_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticsDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkPayment;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox Balancetxt;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox Advancetxt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Totaltxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox L_ADDtxt;
        private System.Windows.Forms.TextBox L_AXIStxt;
        private System.Windows.Forms.TextBox L_CYLtxt;
        private System.Windows.Forms.TextBox L_SPHtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Distancetxt;
        private System.Windows.Forms.TextBox Readingtxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource opticsDBDataSetBindingSource;
        private Optics_DBDataSet optics_DBDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Optics_DBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rSPHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCYLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAXISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rADDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lSPHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCYLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lAXISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lADDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deliveredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn advanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
    }
}