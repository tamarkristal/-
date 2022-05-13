namespace Apartment_project_codeFirstToDb
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkBox_airConditioner = new System.Windows.Forms.CheckBox();
            this.radioButton_D = new System.Windows.Forms.RadioButton();
            this.radioButton_MI = new System.Windows.Forms.RadioButton();
            this.radioButton_Z = new System.Windows.Forms.RadioButton();
            this.radioButton_ME = new System.Windows.Forms.RadioButton();
            this.groupBoxAirCondition = new System.Windows.Forms.GroupBox();
            this.checkBox_elevator = new System.Windows.Forms.CheckBox();
            this.l_city = new System.Windows.Forms.Label();
            this.l_street = new System.Windows.Forms.Label();
            this.textcity = new System.Windows.Forms.TextBox();
            this.textstreet = new System.Windows.Forms.TextBox();
            this.dataGridOwners = new System.Windows.Forms.DataGridView();
            this.dataGridFurniturs = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOwners = new System.Windows.Forms.Label();
            this.label_countRooms = new System.Windows.Forms.Label();
            this.textNumRooms = new System.Windows.Forms.TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textNumHome = new System.Windows.Forms.TextBox();
            this.label_numHouse = new System.Windows.Forms.Label();
            this.labelfloor = new System.Windows.Forms.Label();
            this.textfloor = new System.Windows.Forms.TextBox();
            this.groupBoxApartmentRent = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateOfEvacuation = new System.Windows.Forms.DateTimePicker();
            this.textBoxContractperiod = new System.Windows.Forms.TextBox();
            this.labeldate = new System.Windows.Forms.Label();
            this.label_choze = new System.Windows.Forms.Label();
            this.groupBoxApartmentsSold = new System.Windows.Forms.GroupBox();
            this.checkBoxTaboo = new System.Windows.Forms.CheckBox();
            this.textBoxNeighbers = new System.Windows.Forms.TextBox();
            this.label_neighbers = new System.Windows.Forms.Label();
            this.richTextBoxsoldApartment = new System.Windows.Forms.RichTextBox();
            this.btnNewSave = new System.Windows.Forms.Button();
            this.text_id = new System.Windows.Forms.TextBox();
            this.l_id = new System.Windows.Forms.Label();
            this.groupBoxAirCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOwners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFurniturs)).BeginInit();
            this.groupBoxApartmentRent.SuspendLayout();
            this.groupBoxApartmentsSold.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(408, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "טופס פרטים";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Indigo;
            this.btnSave.Location = new System.Drawing.Point(44, 481);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 41);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "שמור שינויים";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkBox_airConditioner
            // 
            this.checkBox_airConditioner.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_airConditioner.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_airConditioner.Location = new System.Drawing.Point(771, 351);
            this.checkBox_airConditioner.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_airConditioner.Name = "checkBox_airConditioner";
            this.checkBox_airConditioner.Size = new System.Drawing.Size(132, 25);
            this.checkBox_airConditioner.TabIndex = 2;
            this.checkBox_airConditioner.Text = "האם יש מזגן";
            this.checkBox_airConditioner.UseVisualStyleBackColor = false;
            // 
            // radioButton_D
            // 
            this.radioButton_D.AutoSize = true;
            this.radioButton_D.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_D.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_D.Location = new System.Drawing.Point(47, 45);
            this.radioButton_D.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_D.Name = "radioButton_D";
            this.radioButton_D.Size = new System.Drawing.Size(58, 23);
            this.radioButton_D.TabIndex = 3;
            this.radioButton_D.TabStop = true;
            this.radioButton_D.Text = "דרום";
            this.radioButton_D.UseVisualStyleBackColor = false;
            // 
            // radioButton_MI
            // 
            this.radioButton_MI.AutoSize = true;
            this.radioButton_MI.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_MI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_MI.ForeColor = System.Drawing.Color.Black;
            this.radioButton_MI.Location = new System.Drawing.Point(44, 123);
            this.radioButton_MI.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_MI.Name = "radioButton_MI";
            this.radioButton_MI.Size = new System.Drawing.Size(62, 23);
            this.radioButton_MI.TabIndex = 4;
            this.radioButton_MI.TabStop = true;
            this.radioButton_MI.Text = "מזרח";
            this.radioButton_MI.UseVisualStyleBackColor = false;
            // 
            // radioButton_Z
            // 
            this.radioButton_Z.AutoSize = true;
            this.radioButton_Z.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Z.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Z.Location = new System.Drawing.Point(44, 84);
            this.radioButton_Z.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Z.Name = "radioButton_Z";
            this.radioButton_Z.Size = new System.Drawing.Size(52, 23);
            this.radioButton_Z.TabIndex = 5;
            this.radioButton_Z.TabStop = true;
            this.radioButton_Z.Text = "צפון";
            this.radioButton_Z.UseVisualStyleBackColor = false;
            // 
            // radioButton_ME
            // 
            this.radioButton_ME.AutoSize = true;
            this.radioButton_ME.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_ME.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_ME.Location = new System.Drawing.Point(40, 161);
            this.radioButton_ME.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_ME.Name = "radioButton_ME";
            this.radioButton_ME.Size = new System.Drawing.Size(63, 23);
            this.radioButton_ME.TabIndex = 6;
            this.radioButton_ME.TabStop = true;
            this.radioButton_ME.Text = "מערב";
            this.radioButton_ME.UseVisualStyleBackColor = false;
            // 
            // groupBoxAirCondition
            // 
            this.groupBoxAirCondition.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAirCondition.Controls.Add(this.radioButton_D);
            this.groupBoxAirCondition.Controls.Add(this.radioButton_ME);
            this.groupBoxAirCondition.Controls.Add(this.radioButton_Z);
            this.groupBoxAirCondition.Controls.Add(this.radioButton_MI);
            this.groupBoxAirCondition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAirCondition.Location = new System.Drawing.Point(347, 217);
            this.groupBoxAirCondition.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAirCondition.Name = "groupBoxAirCondition";
            this.groupBoxAirCondition.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAirCondition.Size = new System.Drawing.Size(141, 207);
            this.groupBoxAirCondition.TabIndex = 7;
            this.groupBoxAirCondition.TabStop = false;
            this.groupBoxAirCondition.Text = "כיווני אויר";
            // 
            // checkBox_elevator
            // 
            this.checkBox_elevator.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_elevator.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_elevator.Location = new System.Drawing.Point(771, 320);
            this.checkBox_elevator.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_elevator.Name = "checkBox_elevator";
            this.checkBox_elevator.Size = new System.Drawing.Size(124, 23);
            this.checkBox_elevator.TabIndex = 8;
            this.checkBox_elevator.Text = "האם יש מעלית";
            this.checkBox_elevator.UseVisualStyleBackColor = false;
            // 
            // l_city
            // 
            this.l_city.AutoSize = true;
            this.l_city.BackColor = System.Drawing.Color.Transparent;
            this.l_city.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_city.Location = new System.Drawing.Point(819, 111);
            this.l_city.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_city.Name = "l_city";
            this.l_city.Size = new System.Drawing.Size(29, 19);
            this.l_city.TabIndex = 9;
            this.l_city.Text = "עיר";
            // 
            // l_street
            // 
            this.l_street.AutoSize = true;
            this.l_street.BackColor = System.Drawing.Color.Transparent;
            this.l_street.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_street.Location = new System.Drawing.Point(811, 153);
            this.l_street.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_street.Name = "l_street";
            this.l_street.Size = new System.Drawing.Size(38, 19);
            this.l_street.TabIndex = 10;
            this.l_street.Text = "רחוב";
            // 
            // textcity
            // 
            this.textcity.BackColor = System.Drawing.Color.Ivory;
            this.textcity.Location = new System.Drawing.Point(645, 108);
            this.textcity.Margin = new System.Windows.Forms.Padding(4);
            this.textcity.Name = "textcity";
            this.textcity.Size = new System.Drawing.Size(132, 22);
            this.textcity.TabIndex = 11;
            // 
            // textstreet
            // 
            this.textstreet.BackColor = System.Drawing.Color.Ivory;
            this.textstreet.Location = new System.Drawing.Point(645, 150);
            this.textstreet.Margin = new System.Windows.Forms.Padding(4);
            this.textstreet.Name = "textstreet";
            this.textstreet.Size = new System.Drawing.Size(132, 22);
            this.textstreet.TabIndex = 12;
            // 
            // dataGridOwners
            // 
            this.dataGridOwners.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOwners.Location = new System.Drawing.Point(168, 432);
            this.dataGridOwners.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridOwners.Name = "dataGridOwners";
            this.dataGridOwners.Size = new System.Drawing.Size(394, 107);
            this.dataGridOwners.TabIndex = 13;
            // 
            // dataGridFurniturs
            // 
            this.dataGridFurniturs.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridFurniturs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFurniturs.Location = new System.Drawing.Point(596, 432);
            this.dataGridFurniturs.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridFurniturs.Name = "dataGridFurniturs";
            this.dataGridFurniturs.Size = new System.Drawing.Size(394, 105);
            this.dataGridFurniturs.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(517, 412);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "בעלים";
            // 
            // labelOwners
            // 
            this.labelOwners.AutoSize = true;
            this.labelOwners.BackColor = System.Drawing.Color.Transparent;
            this.labelOwners.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOwners.Location = new System.Drawing.Point(940, 412);
            this.labelOwners.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOwners.Name = "labelOwners";
            this.labelOwners.Size = new System.Drawing.Size(52, 19);
            this.labelOwners.TabIndex = 16;
            this.labelOwners.Text = "רהיטים";
            // 
            // label_countRooms
            // 
            this.label_countRooms.AutoSize = true;
            this.label_countRooms.BackColor = System.Drawing.Color.Transparent;
            this.label_countRooms.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_countRooms.Location = new System.Drawing.Point(792, 220);
            this.label_countRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_countRooms.Name = "label_countRooms";
            this.label_countRooms.Size = new System.Drawing.Size(85, 19);
            this.label_countRooms.TabIndex = 17;
            this.label_countRooms.Text = "מספר חדרים";
            // 
            // textNumRooms
            // 
            this.textNumRooms.BackColor = System.Drawing.Color.Ivory;
            this.textNumRooms.Location = new System.Drawing.Point(645, 217);
            this.textNumRooms.Margin = new System.Windows.Forms.Padding(4);
            this.textNumRooms.Name = "textNumRooms";
            this.textNumRooms.Size = new System.Drawing.Size(132, 22);
            this.textNumRooms.TabIndex = 18;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.BackColor = System.Drawing.Color.Transparent;
            this.label_price.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.Location = new System.Drawing.Point(809, 290);
            this.label_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(39, 19);
            this.label_price.TabIndex = 19;
            this.label_price.Text = "מחיר";
            // 
            // textPrice
            // 
            this.textPrice.BackColor = System.Drawing.Color.Ivory;
            this.textPrice.Location = new System.Drawing.Point(645, 290);
            this.textPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(132, 22);
            this.textPrice.TabIndex = 20;
            // 
            // textNumHome
            // 
            this.textNumHome.BackColor = System.Drawing.Color.Ivory;
            this.textNumHome.Location = new System.Drawing.Point(645, 249);
            this.textNumHome.Margin = new System.Windows.Forms.Padding(4);
            this.textNumHome.Name = "textNumHome";
            this.textNumHome.Size = new System.Drawing.Size(132, 22);
            this.textNumHome.TabIndex = 21;
            // 
            // label_numHouse
            // 
            this.label_numHouse.AutoSize = true;
            this.label_numHouse.BackColor = System.Drawing.Color.Transparent;
            this.label_numHouse.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numHouse.Location = new System.Drawing.Point(792, 250);
            this.label_numHouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_numHouse.Name = "label_numHouse";
            this.label_numHouse.Size = new System.Drawing.Size(70, 19);
            this.label_numHouse.TabIndex = 22;
            this.label_numHouse.Text = "מספר בית";
            // 
            // labelfloor
            // 
            this.labelfloor.AutoSize = true;
            this.labelfloor.BackColor = System.Drawing.Color.Transparent;
            this.labelfloor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfloor.Location = new System.Drawing.Point(809, 188);
            this.labelfloor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfloor.Name = "labelfloor";
            this.labelfloor.Size = new System.Drawing.Size(40, 19);
            this.labelfloor.TabIndex = 25;
            this.labelfloor.Text = "קומה";
            // 
            // textfloor
            // 
            this.textfloor.BackColor = System.Drawing.SystemColors.Info;
            this.textfloor.Location = new System.Drawing.Point(645, 188);
            this.textfloor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textfloor.Name = "textfloor";
            this.textfloor.Size = new System.Drawing.Size(132, 22);
            this.textfloor.TabIndex = 26;
            // 
            // groupBoxApartmentRent
            // 
            this.groupBoxApartmentRent.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxApartmentRent.Controls.Add(this.dateTimePickerDateOfEvacuation);
            this.groupBoxApartmentRent.Controls.Add(this.textBoxContractperiod);
            this.groupBoxApartmentRent.Controls.Add(this.labeldate);
            this.groupBoxApartmentRent.Controls.Add(this.label_choze);
            this.groupBoxApartmentRent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxApartmentRent.Location = new System.Drawing.Point(33, 23);
            this.groupBoxApartmentRent.Name = "groupBoxApartmentRent";
            this.groupBoxApartmentRent.Size = new System.Drawing.Size(267, 194);
            this.groupBoxApartmentRent.TabIndex = 27;
            this.groupBoxApartmentRent.TabStop = false;
            this.groupBoxApartmentRent.Text = "פרטי דירה להשכרה";
            // 
            // dateTimePickerDateOfEvacuation
            // 
            this.dateTimePickerDateOfEvacuation.Location = new System.Drawing.Point(38, 139);
            this.dateTimePickerDateOfEvacuation.Name = "dateTimePickerDateOfEvacuation";
            this.dateTimePickerDateOfEvacuation.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerDateOfEvacuation.TabIndex = 4;
            // 
            // textBoxContractperiod
            // 
            this.textBoxContractperiod.Location = new System.Drawing.Point(38, 58);
            this.textBoxContractperiod.Name = "textBoxContractperiod";
            this.textBoxContractperiod.Size = new System.Drawing.Size(118, 26);
            this.textBoxContractperiod.TabIndex = 3;
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labeldate.Location = new System.Drawing.Point(162, 104);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(80, 19);
            this.labeldate.TabIndex = 2;
            this.labeldate.Text = "תאריך פינוי";
            // 
            // label_choze
            // 
            this.label_choze.AutoSize = true;
            this.label_choze.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_choze.Location = new System.Drawing.Point(162, 58);
            this.label_choze.Name = "label_choze";
            this.label_choze.Size = new System.Drawing.Size(88, 19);
            this.label_choze.TabIndex = 1;
            this.label_choze.Text = "תקופת חוזה";
            // 
            // groupBoxApartmentsSold
            // 
            this.groupBoxApartmentsSold.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxApartmentsSold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxApartmentsSold.Controls.Add(this.checkBoxTaboo);
            this.groupBoxApartmentsSold.Controls.Add(this.textBoxNeighbers);
            this.groupBoxApartmentsSold.Controls.Add(this.label_neighbers);
            this.groupBoxApartmentsSold.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxApartmentsSold.ForeColor = System.Drawing.Color.Black;
            this.groupBoxApartmentsSold.Location = new System.Drawing.Point(33, 23);
            this.groupBoxApartmentsSold.Name = "groupBoxApartmentsSold";
            this.groupBoxApartmentsSold.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxApartmentsSold.Size = new System.Drawing.Size(267, 165);
            this.groupBoxApartmentsSold.TabIndex = 28;
            this.groupBoxApartmentsSold.TabStop = false;
            this.groupBoxApartmentsSold.Text = "דירה למכירה";
            // 
            // checkBoxTaboo
            // 
            this.checkBoxTaboo.AutoSize = true;
            this.checkBoxTaboo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxTaboo.Location = new System.Drawing.Point(58, 110);
            this.checkBoxTaboo.Name = "checkBoxTaboo";
            this.checkBoxTaboo.Size = new System.Drawing.Size(106, 22);
            this.checkBoxTaboo.TabIndex = 2;
            this.checkBoxTaboo.Text = "טאבו משותף";
            this.checkBoxTaboo.UseVisualStyleBackColor = true;
            // 
            // textBoxNeighbers
            // 
            this.textBoxNeighbers.Location = new System.Drawing.Point(10, 47);
            this.textBoxNeighbers.Name = "textBoxNeighbers";
            this.textBoxNeighbers.Size = new System.Drawing.Size(100, 26);
            this.textBoxNeighbers.TabIndex = 1;
            // 
            // label_neighbers
            // 
            this.label_neighbers.AutoSize = true;
            this.label_neighbers.Location = new System.Drawing.Point(116, 53);
            this.label_neighbers.Name = "label_neighbers";
            this.label_neighbers.Size = new System.Drawing.Size(122, 19);
            this.label_neighbers.TabIndex = 0;
            this.label_neighbers.Text = "כמות שכנים בבנין";
            // 
            // richTextBoxsoldApartment
            // 
            this.richTextBoxsoldApartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.richTextBoxsoldApartment.BackColor = System.Drawing.Color.Tomato;
            this.richTextBoxsoldApartment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxsoldApartment.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBoxsoldApartment.ForeColor = System.Drawing.Color.White;
            this.richTextBoxsoldApartment.Location = new System.Drawing.Point(59, 239);
            this.richTextBoxsoldApartment.Name = "richTextBoxsoldApartment";
            this.richTextBoxsoldApartment.Size = new System.Drawing.Size(212, 127);
            this.richTextBoxsoldApartment.TabIndex = 29;
            this.richTextBoxsoldApartment.Text = "                   דירה למכירה";
            // 
            // btnNewSave
            // 
            this.btnNewSave.BackColor = System.Drawing.Color.Transparent;
            this.btnNewSave.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSave.ForeColor = System.Drawing.Color.Indigo;
            this.btnNewSave.Location = new System.Drawing.Point(44, 481);
            this.btnNewSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewSave.Name = "btnNewSave";
            this.btnNewSave.Size = new System.Drawing.Size(100, 41);
            this.btnNewSave.TabIndex = 30;
            this.btnNewSave.Text = "שמור ";
            this.btnNewSave.UseVisualStyleBackColor = false;
            this.btnNewSave.Click += new System.EventHandler(this.btnNewSave_Click);
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(645, 70);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(132, 22);
            this.text_id.TabIndex = 31;
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.BackColor = System.Drawing.Color.Transparent;
            this.l_id.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.l_id.Location = new System.Drawing.Point(803, 70);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(74, 18);
            this.l_id.TabIndex = 32;
            this.l_id.Text = "מזהה דירה";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Apartment_project_codeFirstToDb.Properties.Resources.דירה_להשכרה_במחיר_למשתכן;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 563);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.btnNewSave);
            this.Controls.Add(this.richTextBoxsoldApartment);
            this.Controls.Add(this.groupBoxApartmentsSold);
            this.Controls.Add(this.groupBoxApartmentRent);
            this.Controls.Add(this.textfloor);
            this.Controls.Add(this.labelfloor);
            this.Controls.Add(this.label_numHouse);
            this.Controls.Add(this.textNumHome);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.textNumRooms);
            this.Controls.Add(this.label_countRooms);
            this.Controls.Add(this.labelOwners);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridFurniturs);
            this.Controls.Add(this.dataGridOwners);
            this.Controls.Add(this.textstreet);
            this.Controls.Add(this.textcity);
            this.Controls.Add(this.l_street);
            this.Controls.Add(this.l_city);
            this.Controls.Add(this.checkBox_elevator);
            this.Controls.Add(this.groupBoxAirCondition);
            this.Controls.Add(this.checkBox_airConditioner);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBoxAirCondition.ResumeLayout(false);
            this.groupBoxAirCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOwners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFurniturs)).EndInit();
            this.groupBoxApartmentRent.ResumeLayout(false);
            this.groupBoxApartmentRent.PerformLayout();
            this.groupBoxApartmentsSold.ResumeLayout(false);
            this.groupBoxApartmentsSold.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkBox_airConditioner;
        private System.Windows.Forms.RadioButton radioButton_D;
        private System.Windows.Forms.RadioButton radioButton_MI;
        private System.Windows.Forms.RadioButton radioButton_Z;
        private System.Windows.Forms.RadioButton radioButton_ME;
        private System.Windows.Forms.GroupBox groupBoxAirCondition;
        private System.Windows.Forms.CheckBox checkBox_elevator;
        private System.Windows.Forms.Label l_city;
        private System.Windows.Forms.Label l_street;
        private System.Windows.Forms.TextBox textcity;
        private System.Windows.Forms.TextBox textstreet;
        private System.Windows.Forms.DataGridView dataGridOwners;
        private System.Windows.Forms.DataGridView dataGridFurniturs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelOwners;
        private System.Windows.Forms.Label label_countRooms;
        private System.Windows.Forms.TextBox textNumRooms;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textNumHome;
        private System.Windows.Forms.Label label_numHouse;
        private System.Windows.Forms.Label labelfloor;
        private System.Windows.Forms.TextBox textfloor;
        private System.Windows.Forms.GroupBox groupBoxApartmentRent;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfEvacuation;
        private System.Windows.Forms.TextBox textBoxContractperiod;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label label_choze;
        private System.Windows.Forms.GroupBox groupBoxApartmentsSold;
        private System.Windows.Forms.Label label_neighbers;
        private System.Windows.Forms.CheckBox checkBoxTaboo;
        private System.Windows.Forms.TextBox textBoxNeighbers;
        private System.Windows.Forms.RichTextBox richTextBoxsoldApartment;
        private System.Windows.Forms.Button btnNewSave;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label l_id;
    }
}