namespace HueSandbox_Form
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ConnectLight = new System.Windows.Forms.Button();
            this.btn_GetLights = new System.Windows.Forms.Button();
            this.cbx_LightSelector = new System.Windows.Forms.ComboBox();
            this.pgr_LightDetails = new System.Windows.Forms.PropertyGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pgr_BridgeDetails = new System.Windows.Forms.PropertyGrid();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ConnectBridge = new System.Windows.Forms.Button();
            this.btn_SearchBridges = new System.Windows.Forms.Button();
            this.cbx_BridgeSelector = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_SetBrigthness = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Brigthness = new System.Windows.Forms.TextBox();
            this.btn_SetColor = new System.Windows.Forms.Button();
            this.btn_On = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Off = new System.Windows.Forms.Button();
            this.txt_Red = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Green = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Blue = new System.Windows.Forms.TextBox();
            this.pgr_StateDetails = new System.Windows.Forms.PropertyGrid();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(315, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hue Device";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbx_LightSelector, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pgr_LightDetails, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(300, 362);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel5.Controls.Add(this.btn_ConnectLight, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_GetLights, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 332);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(300, 30);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // btn_ConnectLight
            // 
            this.btn_ConnectLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ConnectLight.Enabled = false;
            this.btn_ConnectLight.Location = new System.Drawing.Point(105, 3);
            this.btn_ConnectLight.Name = "btn_ConnectLight";
            this.btn_ConnectLight.Size = new System.Drawing.Size(192, 24);
            this.btn_ConnectLight.TabIndex = 3;
            this.btn_ConnectLight.Text = "Verbinden";
            this.btn_ConnectLight.UseVisualStyleBackColor = true;
            this.btn_ConnectLight.Click += new System.EventHandler(this.btn_ConnectLight_Click);
            // 
            // btn_GetLights
            // 
            this.btn_GetLights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_GetLights.Enabled = false;
            this.btn_GetLights.Location = new System.Drawing.Point(3, 3);
            this.btn_GetLights.Name = "btn_GetLights";
            this.btn_GetLights.Size = new System.Drawing.Size(96, 24);
            this.btn_GetLights.TabIndex = 4;
            this.btn_GetLights.Text = "Abrufen";
            this.btn_GetLights.UseVisualStyleBackColor = true;
            this.btn_GetLights.Click += new System.EventHandler(this.btn_GetLights_Click);
            // 
            // cbx_LightSelector
            // 
            this.cbx_LightSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_LightSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_LightSelector.FormattingEnabled = true;
            this.cbx_LightSelector.Location = new System.Drawing.Point(3, 3);
            this.cbx_LightSelector.Name = "cbx_LightSelector";
            this.cbx_LightSelector.Size = new System.Drawing.Size(294, 21);
            this.cbx_LightSelector.TabIndex = 0;
            this.cbx_LightSelector.SelectedIndexChanged += new System.EventHandler(this.cbx_LightSelector_SelectedIndexChanged);
            // 
            // pgr_LightDetails
            // 
            this.pgr_LightDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgr_LightDetails.HelpVisible = false;
            this.pgr_LightDetails.Location = new System.Drawing.Point(3, 43);
            this.pgr_LightDetails.Name = "pgr_LightDetails";
            this.pgr_LightDetails.Size = new System.Drawing.Size(294, 286);
            this.pgr_LightDetails.TabIndex = 1;
            this.pgr_LightDetails.ToolbarVisible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 381);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hue Bridge";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.pgr_BridgeDetails, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbx_BridgeSelector, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(300, 362);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // pgr_BridgeDetails
            // 
            this.pgr_BridgeDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgr_BridgeDetails.HelpVisible = false;
            this.pgr_BridgeDetails.Location = new System.Drawing.Point(3, 43);
            this.pgr_BridgeDetails.Name = "pgr_BridgeDetails";
            this.pgr_BridgeDetails.Size = new System.Drawing.Size(294, 286);
            this.pgr_BridgeDetails.TabIndex = 1;
            this.pgr_BridgeDetails.ToolbarVisible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel4.Controls.Add(this.btn_ConnectBridge, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_SearchBridges, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 332);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(300, 30);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // btn_ConnectBridge
            // 
            this.btn_ConnectBridge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ConnectBridge.Enabled = false;
            this.btn_ConnectBridge.Location = new System.Drawing.Point(105, 3);
            this.btn_ConnectBridge.Name = "btn_ConnectBridge";
            this.btn_ConnectBridge.Size = new System.Drawing.Size(192, 24);
            this.btn_ConnectBridge.TabIndex = 2;
            this.btn_ConnectBridge.Text = "Verbinden";
            this.btn_ConnectBridge.UseVisualStyleBackColor = true;
            this.btn_ConnectBridge.Click += new System.EventHandler(this.btn_ConnectBridge_Click);
            // 
            // btn_SearchBridges
            // 
            this.btn_SearchBridges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SearchBridges.Location = new System.Drawing.Point(3, 3);
            this.btn_SearchBridges.Name = "btn_SearchBridges";
            this.btn_SearchBridges.Size = new System.Drawing.Size(96, 24);
            this.btn_SearchBridges.TabIndex = 3;
            this.btn_SearchBridges.Text = "Suchen";
            this.btn_SearchBridges.UseVisualStyleBackColor = true;
            this.btn_SearchBridges.Click += new System.EventHandler(this.btn_SearchBridges_Click);
            // 
            // cbx_BridgeSelector
            // 
            this.cbx_BridgeSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_BridgeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_BridgeSelector.FormattingEnabled = true;
            this.cbx_BridgeSelector.Location = new System.Drawing.Point(3, 3);
            this.cbx_BridgeSelector.Name = "cbx_BridgeSelector";
            this.cbx_BridgeSelector.Size = new System.Drawing.Size(294, 21);
            this.cbx_BridgeSelector.TabIndex = 0;
            this.cbx_BridgeSelector.SelectedIndexChanged += new System.EventHandler(this.cbx_BridgeSelector_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 387);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(630, 787);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btn_On);
            this.groupBox3.Controls.Add(this.btn_Off);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 376);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Steuerung";
            // 
            // btn_SetBrigthness
            // 
            this.btn_SetBrigthness.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SetBrigthness.Location = new System.Drawing.Point(168, 28);
            this.btn_SetBrigthness.Name = "btn_SetBrigthness";
            this.btn_SetBrigthness.Size = new System.Drawing.Size(77, 31);
            this.btn_SetBrigthness.TabIndex = 17;
            this.btn_SetBrigthness.Text = "Set";
            this.btn_SetBrigthness.UseVisualStyleBackColor = true;
            this.btn_SetBrigthness.Click += new System.EventHandler(this.btn_SetBrigthness_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Helligkeit";
            // 
            // txt_Brigthness
            // 
            this.txt_Brigthness.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Brigthness.Location = new System.Drawing.Point(64, 28);
            this.txt_Brigthness.Name = "txt_Brigthness";
            this.txt_Brigthness.Size = new System.Drawing.Size(88, 31);
            this.txt_Brigthness.TabIndex = 15;
            // 
            // btn_SetColor
            // 
            this.btn_SetColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SetColor.Location = new System.Drawing.Point(168, 21);
            this.btn_SetColor.Name = "btn_SetColor";
            this.btn_SetColor.Size = new System.Drawing.Size(77, 121);
            this.btn_SetColor.TabIndex = 14;
            this.btn_SetColor.Text = "Set";
            this.btn_SetColor.UseVisualStyleBackColor = true;
            this.btn_SetColor.Click += new System.EventHandler(this.btn_SetColor_Click);
            // 
            // btn_On
            // 
            this.btn_On.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_On.Location = new System.Drawing.Point(153, 30);
            this.btn_On.Name = "btn_On";
            this.btn_On.Size = new System.Drawing.Size(110, 31);
            this.btn_On.TabIndex = 7;
            this.btn_On.Text = "AN";
            this.btn_On.UseVisualStyleBackColor = true;
            this.btn_On.Click += new System.EventHandler(this.btn_On_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Grün";
            // 
            // btn_Off
            // 
            this.btn_Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Off.Location = new System.Drawing.Point(27, 30);
            this.btn_Off.Name = "btn_Off";
            this.btn_Off.Size = new System.Drawing.Size(110, 31);
            this.btn_Off.TabIndex = 6;
            this.btn_Off.Text = "AUS";
            this.btn_Off.UseVisualStyleBackColor = true;
            this.btn_Off.Click += new System.EventHandler(this.btn_Off_Click);
            // 
            // txt_Red
            // 
            this.txt_Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Red.Location = new System.Drawing.Point(64, 21);
            this.txt_Red.Name = "txt_Red";
            this.txt_Red.Size = new System.Drawing.Size(88, 31);
            this.txt_Red.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Blau";
            // 
            // txt_Green
            // 
            this.txt_Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Green.Location = new System.Drawing.Point(64, 66);
            this.txt_Green.Name = "txt_Green";
            this.txt_Green.Size = new System.Drawing.Size(88, 31);
            this.txt_Green.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rot";
            // 
            // txt_Blue
            // 
            this.txt_Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Blue.Location = new System.Drawing.Point(64, 111);
            this.txt_Blue.Name = "txt_Blue";
            this.txt_Blue.Size = new System.Drawing.Size(88, 31);
            this.txt_Blue.TabIndex = 9;
            // 
            // pgr_StateDetails
            // 
            this.pgr_StateDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgr_StateDetails.HelpVisible = false;
            this.pgr_StateDetails.Location = new System.Drawing.Point(3, 16);
            this.pgr_StateDetails.Name = "pgr_StateDetails";
            this.pgr_StateDetails.Size = new System.Drawing.Size(294, 357);
            this.pgr_StateDetails.TabIndex = 18;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txt_Blue);
            this.groupBox4.Controls.Add(this.txt_Green);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txt_Red);
            this.groupBox4.Controls.Add(this.btn_SetColor);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(18, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 155);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Farbe";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txt_Brigthness);
            this.groupBox5.Controls.Add(this.btn_SetBrigthness);
            this.groupBox5.Location = new System.Drawing.Point(18, 239);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 72);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupBox6, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 396);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(624, 388);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pgr_StateDetails);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(318, 6);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(300, 376);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hue Device - Details (State)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 787);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Name = "Form1";
            this.Text = "HueSandbox - Workbench v0.1";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_GetLights;
        private System.Windows.Forms.Button btn_ConnectLight;
        private System.Windows.Forms.PropertyGrid pgr_LightDetails;
        private System.Windows.Forms.ComboBox cbx_LightSelector;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_SearchBridges;
        private System.Windows.Forms.Button btn_ConnectBridge;
        private System.Windows.Forms.PropertyGrid pgr_BridgeDetails;
        private System.Windows.Forms.ComboBox cbx_BridgeSelector;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox txt_Red;
        private System.Windows.Forms.Button btn_Off;
        private System.Windows.Forms.Button btn_On;
        private System.Windows.Forms.TextBox txt_Green;
        private System.Windows.Forms.TextBox txt_Blue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_SetColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_SetBrigthness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Brigthness;
        private System.Windows.Forms.PropertyGrid pgr_StateDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

