
namespace Bai1
{
    partial class frmLinkedList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbNext = new System.Windows.Forms.RadioButton();
            this.rbTail = new System.Windows.Forms.RadioButton();
            this.rbHead = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEnforcement = new System.Windows.Forms.Button();
            this.btnOperationOther = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbDestination = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbDeparture = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtDepartureDay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbCaptainName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbFlightCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.captainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.btnOperationOther);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 592);
            this.panel1.TabIndex = 0;
            // 
            // rbNext
            // 
            this.rbNext.AutoSize = true;
            this.rbNext.Location = new System.Drawing.Point(322, 59);
            this.rbNext.Name = "rbNext";
            this.rbNext.Size = new System.Drawing.Size(71, 17);
            this.rbNext.TabIndex = 13;
            this.rbNext.TabStop = true;
            this.rbNext.Text = "Sau node";
            this.rbNext.UseVisualStyleBackColor = true;
            // 
            // rbTail
            // 
            this.rbTail.AutoSize = true;
            this.rbTail.Location = new System.Drawing.Point(322, 36);
            this.rbTail.Name = "rbTail";
            this.rbTail.Size = new System.Drawing.Size(46, 17);
            this.rbTail.TabIndex = 13;
            this.rbTail.TabStop = true;
            this.rbTail.Text = "Cuối";
            this.rbTail.UseVisualStyleBackColor = true;
            // 
            // rbHead
            // 
            this.rbHead.AutoSize = true;
            this.rbHead.Location = new System.Drawing.Point(322, 11);
            this.rbHead.Name = "rbHead";
            this.rbHead.Size = new System.Drawing.Size(45, 17);
            this.rbHead.TabIndex = 12;
            this.rbHead.TabStop = true;
            this.rbHead.Text = "Đầu";
            this.rbHead.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(899, 536);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 37);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtSearch);
            this.panel11.Controls.Add(this.rbNext);
            this.panel11.Controls.Add(this.panel10);
            this.panel11.Controls.Add(this.rbTail);
            this.panel11.Controls.Add(this.rbHead);
            this.panel11.Controls.Add(this.panel9);
            this.panel11.Controls.Add(this.btnEnforcement);
            this.panel11.Location = new System.Drawing.Point(635, 358);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(402, 128);
            this.panel11.TabIndex = 11;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cbSort);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Location = new System.Drawing.Point(2, 2);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(315, 39);
            this.panel10.TabIndex = 8;
            // 
            // cbSort
            // 
            this.cbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Mã chuyến bay",
            "Tên cơ trưởng",
            "Thời gian khởi hành",
            "Giá vé"});
            this.cbSort.Location = new System.Drawing.Point(98, 8);
            this.cbSort.Margin = new System.Windows.Forms.Padding(2);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(216, 25);
            this.cbSort.TabIndex = 5;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sắp xếp";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbSearch);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Location = new System.Drawing.Point(2, 46);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(315, 39);
            this.panel9.TabIndex = 7;
            // 
            // cbSearch
            // 
            this.cbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Mã chuyến bay",
            "Tên cơ trưởng"});
            this.cbSearch.Location = new System.Drawing.Point(98, 6);
            this.cbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(216, 25);
            this.cbSearch.TabIndex = 5;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tìm kiếm";
            // 
            // btnEnforcement
            // 
            this.btnEnforcement.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnforcement.Location = new System.Drawing.Point(233, 90);
            this.btnEnforcement.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnforcement.Name = "btnEnforcement";
            this.btnEnforcement.Size = new System.Drawing.Size(84, 28);
            this.btnEnforcement.TabIndex = 6;
            this.btnEnforcement.Text = "Thực Thi";
            this.btnEnforcement.UseVisualStyleBackColor = true;
            this.btnEnforcement.Click += new System.EventHandler(this.btnEnforcement_Click);
            // 
            // btnOperationOther
            // 
            this.btnOperationOther.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperationOther.Location = new System.Drawing.Point(647, 536);
            this.btnOperationOther.Margin = new System.Windows.Forms.Padding(2);
            this.btnOperationOther.Name = "btnOperationOther";
            this.btnOperationOther.Size = new System.Drawing.Size(129, 37);
            this.btnOperationOther.TabIndex = 7;
            this.btnOperationOther.Text = "Thao tác khác";
            this.btnOperationOther.UseVisualStyleBackColor = true;
            this.btnOperationOther.Click += new System.EventHandler(this.btnOperationOther_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Location = new System.Drawing.Point(629, 20);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 323);
            this.panel3.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(284, 282);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 30);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(169, 282);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(71, 30);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(36, 282);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbDestination);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(2, 224);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(392, 39);
            this.panel8.TabIndex = 6;
            // 
            // txbDestination
            // 
            this.txbDestination.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDestination.Location = new System.Drawing.Point(122, 8);
            this.txbDestination.Margin = new System.Windows.Forms.Padding(2);
            this.txbDestination.Name = "txbDestination";
            this.txbDestination.Size = new System.Drawing.Size(269, 24);
            this.txbDestination.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nơi đến:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbDeparture);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(2, 180);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(392, 39);
            this.panel7.TabIndex = 5;
            // 
            // txbDeparture
            // 
            this.txbDeparture.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDeparture.Location = new System.Drawing.Point(122, 8);
            this.txbDeparture.Margin = new System.Windows.Forms.Padding(2);
            this.txbDeparture.Name = "txbDeparture";
            this.txbDeparture.Size = new System.Drawing.Size(269, 24);
            this.txbDeparture.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nơi đi:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtDepartureDay);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(2, 136);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(392, 39);
            this.panel6.TabIndex = 4;
            // 
            // dtDepartureDay
            // 
            this.dtDepartureDay.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDepartureDay.Location = new System.Drawing.Point(122, 8);
            this.dtDepartureDay.Margin = new System.Windows.Forms.Padding(2);
            this.dtDepartureDay.Name = "dtDepartureDay";
            this.dtDepartureDay.Size = new System.Drawing.Size(269, 24);
            this.dtDepartureDay.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Khởi hành:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbCaptainName);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(2, 93);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(392, 39);
            this.panel5.TabIndex = 3;
            // 
            // txbCaptainName
            // 
            this.txbCaptainName.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCaptainName.Location = new System.Drawing.Point(122, 8);
            this.txbCaptainName.Margin = new System.Windows.Forms.Padding(2);
            this.txbCaptainName.Name = "txbCaptainName";
            this.txbCaptainName.Size = new System.Drawing.Size(269, 24);
            this.txbCaptainName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cơ trưởng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin chuyến bay";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbFlightCode);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(2, 49);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(392, 39);
            this.panel4.TabIndex = 0;
            // 
            // txbFlightCode
            // 
            this.txbFlightCode.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFlightCode.Location = new System.Drawing.Point(122, 8);
            this.txbFlightCode.Margin = new System.Windows.Forms.Padding(2);
            this.txbFlightCode.Name = "txbFlightCode";
            this.txbFlightCode.Size = new System.Drawing.Size(269, 24);
            this.txbFlightCode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã chuyến bay:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(2, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 532);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách chuyến bay";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.captainName,
            this.departureDay,
            this.departure,
            this.destination});
            this.dataGridView1.Location = new System.Drawing.Point(2, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(604, 480);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Mã CB";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // captainName
            // 
            this.captainName.HeaderText = "Tên cơ trưởng";
            this.captainName.MinimumWidth = 6;
            this.captainName.Name = "captainName";
            this.captainName.ReadOnly = true;
            this.captainName.Width = 125;
            // 
            // departureDay
            // 
            this.departureDay.HeaderText = "Ngày khởi hành";
            this.departureDay.MinimumWidth = 6;
            this.departureDay.Name = "departureDay";
            this.departureDay.ReadOnly = true;
            this.departureDay.Width = 115;
            // 
            // departure
            // 
            this.departure.HeaderText = "Nơi đi";
            this.departure.MinimumWidth = 6;
            this.departure.Name = "departure";
            this.departure.ReadOnly = true;
            this.departure.Width = 160;
            // 
            // destination
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination.DefaultCellStyle = dataGridViewCellStyle4;
            this.destination.HeaderText = "Nơi đến";
            this.destination.MinimumWidth = 6;
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            this.destination.Width = 160;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(44, 89);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(176, 24);
            this.txtSearch.TabIndex = 1;
            // 
            // frmLinkedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 609);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLinkedList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doubly Linked List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLinkedList_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbDestination;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbDeparture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dtDepartureDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbCaptainName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbFlightCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn captainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOperationOther;
        private System.Windows.Forms.Button btnEnforcement;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbNext;
        private System.Windows.Forms.RadioButton rbTail;
        private System.Windows.Forms.RadioButton rbHead;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

