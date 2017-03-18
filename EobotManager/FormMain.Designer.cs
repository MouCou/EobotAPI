namespace EobotManager
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabEobot = new System.Windows.Forms.TabControl();
            this.tabMining = new System.Windows.Forms.TabPage();
            this.tabBalance = new System.Windows.Forms.TabPage();
            this.tabRates = new System.Windows.Forms.TabPage();
            this.pLogin = new System.Windows.Forms.Panel();
            this.bLogin = new System.Windows.Forms.Button();
            this.ePassword = new System.Windows.Forms.TextBox();
            this.eEmail = new System.Windows.Forms.TextBox();
            this.eUserId = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lUserId = new System.Windows.Forms.Label();
            this.pCoin = new System.Windows.Forms.PictureBox();
            this.TimerLog = new System.Windows.Forms.Timer(this.components);
            this.gridBalances = new System.Windows.Forms.DataGridView();
            this.gridRates = new System.Windows.Forms.DataGridView();
            this.lRate = new System.Windows.Forms.Label();
            this.lBalance = new System.Windows.Forms.Label();
            this.cSelectMinning = new System.Windows.Forms.ComboBox();
            this.TimerChangeMinning = new System.Windows.Forms.Timer(this.components);
            this.TimerGetMinning = new System.Windows.Forms.Timer(this.components);
            this.lCode = new System.Windows.Forms.Label();
            this.gridCloud = new System.Windows.Forms.DataGridView();
            this.lCloud = new System.Windows.Forms.Label();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.lFrom = new System.Windows.Forms.Label();
            this.lAmount = new System.Windows.Forms.Label();
            this.lTo = new System.Windows.Forms.Label();
            this.bEstimate = new System.Windows.Forms.Button();
            this.cFrom = new System.Windows.Forms.ComboBox();
            this.cTo = new System.Windows.Forms.ComboBox();
            this.eAmount = new System.Windows.Forms.TextBox();
            this.eEstimate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cCoinWallet = new System.Windows.Forms.ComboBox();
            this.lWalletAddress = new System.Windows.Forms.Label();
            this.eWalletAddress = new System.Windows.Forms.TextBox();
            this.tabEobot.SuspendLayout();
            this.tabMining.SuspendLayout();
            this.tabBalance.SuspendLayout();
            this.tabRates.SuspendLayout();
            this.pLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBalances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCloud)).BeginInit();
            this.tabOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEobot
            // 
            this.tabEobot.Controls.Add(this.tabMining);
            this.tabEobot.Controls.Add(this.tabBalance);
            this.tabEobot.Controls.Add(this.tabRates);
            this.tabEobot.Controls.Add(this.tabOther);
            this.tabEobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEobot.Location = new System.Drawing.Point(1, 1);
            this.tabEobot.Name = "tabEobot";
            this.tabEobot.SelectedIndex = 0;
            this.tabEobot.Size = new System.Drawing.Size(428, 535);
            this.tabEobot.TabIndex = 2;
            this.tabEobot.Visible = false;
            // 
            // tabMining
            // 
            this.tabMining.Controls.Add(this.lCloud);
            this.tabMining.Controls.Add(this.gridCloud);
            this.tabMining.Controls.Add(this.lCode);
            this.tabMining.Controls.Add(this.cSelectMinning);
            this.tabMining.Controls.Add(this.lBalance);
            this.tabMining.Controls.Add(this.lRate);
            this.tabMining.Controls.Add(this.pCoin);
            this.tabMining.Location = new System.Drawing.Point(4, 42);
            this.tabMining.Name = "tabMining";
            this.tabMining.Padding = new System.Windows.Forms.Padding(3);
            this.tabMining.Size = new System.Drawing.Size(420, 489);
            this.tabMining.TabIndex = 0;
            this.tabMining.Text = "Mining";
            this.tabMining.UseVisualStyleBackColor = true;
            // 
            // tabBalance
            // 
            this.tabBalance.Controls.Add(this.gridBalances);
            this.tabBalance.Location = new System.Drawing.Point(4, 42);
            this.tabBalance.Name = "tabBalance";
            this.tabBalance.Padding = new System.Windows.Forms.Padding(3);
            this.tabBalance.Size = new System.Drawing.Size(420, 489);
            this.tabBalance.TabIndex = 1;
            this.tabBalance.Text = "Balances";
            this.tabBalance.UseVisualStyleBackColor = true;
            // 
            // tabRates
            // 
            this.tabRates.Controls.Add(this.gridRates);
            this.tabRates.Location = new System.Drawing.Point(4, 42);
            this.tabRates.Name = "tabRates";
            this.tabRates.Padding = new System.Windows.Forms.Padding(3);
            this.tabRates.Size = new System.Drawing.Size(420, 489);
            this.tabRates.TabIndex = 2;
            this.tabRates.Text = "Rates";
            this.tabRates.UseVisualStyleBackColor = true;
            // 
            // pLogin
            // 
            this.pLogin.Controls.Add(this.bLogin);
            this.pLogin.Controls.Add(this.ePassword);
            this.pLogin.Controls.Add(this.eEmail);
            this.pLogin.Controls.Add(this.eUserId);
            this.pLogin.Controls.Add(this.lPassword);
            this.pLogin.Controls.Add(this.lEmail);
            this.pLogin.Controls.Add(this.lUserId);
            this.pLogin.Location = new System.Drawing.Point(0, 0);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(429, 446);
            this.pLogin.TabIndex = 3;
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(71, 315);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(289, 50);
            this.bLogin.TabIndex = 6;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // ePassword
            // 
            this.ePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ePassword.Location = new System.Drawing.Point(71, 264);
            this.ePassword.Name = "ePassword";
            this.ePassword.Size = new System.Drawing.Size(289, 41);
            this.ePassword.TabIndex = 5;
            this.ePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ePassword.UseSystemPasswordChar = true;
            // 
            // eEmail
            // 
            this.eEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eEmail.Location = new System.Drawing.Point(71, 167);
            this.eEmail.Name = "eEmail";
            this.eEmail.Size = new System.Drawing.Size(288, 41);
            this.eEmail.TabIndex = 4;
            this.eEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eUserId
            // 
            this.eUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eUserId.Location = new System.Drawing.Point(70, 70);
            this.eUserId.Name = "eUserId";
            this.eUserId.Size = new System.Drawing.Size(290, 41);
            this.eUserId.TabIndex = 3;
            this.eUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassword.Location = new System.Drawing.Point(142, 218);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(147, 36);
            this.lPassword.TabIndex = 2;
            this.lPassword.Text = "Password";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(171, 121);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(88, 36);
            this.lEmail.TabIndex = 1;
            this.lEmail.Text = "Email";
            // 
            // lUserId
            // 
            this.lUserId.AutoSize = true;
            this.lUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserId.Location = new System.Drawing.Point(158, 24);
            this.lUserId.Name = "lUserId";
            this.lUserId.Size = new System.Drawing.Size(115, 36);
            this.lUserId.TabIndex = 0;
            this.lUserId.Text = "User ID";
            // 
            // pCoin
            // 
            this.pCoin.Location = new System.Drawing.Point(7, 6);
            this.pCoin.Name = "pCoin";
            this.pCoin.Size = new System.Drawing.Size(110, 69);
            this.pCoin.TabIndex = 0;
            this.pCoin.TabStop = false;
            // 
            // TimerLog
            // 
            this.TimerLog.Interval = 5000;
            this.TimerLog.Tick += new System.EventHandler(this.TimerLog_Tick);
            // 
            // gridBalances
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBalances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBalances.DefaultCellStyle = dataGridViewCellStyle9;
            this.gridBalances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBalances.Location = new System.Drawing.Point(3, 3);
            this.gridBalances.Name = "gridBalances";
            this.gridBalances.Size = new System.Drawing.Size(414, 483);
            this.gridBalances.TabIndex = 0;
            this.gridBalances.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBalances_CellContentClick);
            // 
            // gridRates
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRates.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridRates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRates.Location = new System.Drawing.Point(3, 3);
            this.gridRates.Name = "gridRates";
            this.gridRates.Size = new System.Drawing.Size(414, 483);
            this.gridRates.TabIndex = 0;
            // 
            // lRate
            // 
            this.lRate.AutoSize = true;
            this.lRate.Location = new System.Drawing.Point(19, 91);
            this.lRate.Name = "lRate";
            this.lRate.Size = new System.Drawing.Size(95, 36);
            this.lRate.TabIndex = 1;
            this.lRate.Text = "label1";
            // 
            // lBalance
            // 
            this.lBalance.AutoSize = true;
            this.lBalance.Location = new System.Drawing.Point(19, 129);
            this.lBalance.Name = "lBalance";
            this.lBalance.Size = new System.Drawing.Size(95, 36);
            this.lBalance.TabIndex = 2;
            this.lBalance.Text = "label1";
            // 
            // cSelectMinning
            // 
            this.cSelectMinning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSelectMinning.FormattingEnabled = true;
            this.cSelectMinning.Location = new System.Drawing.Point(25, 194);
            this.cSelectMinning.Name = "cSelectMinning";
            this.cSelectMinning.Size = new System.Drawing.Size(259, 41);
            this.cSelectMinning.Sorted = true;
            this.cSelectMinning.TabIndex = 3;
            this.cSelectMinning.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TimerChangeMinning
            // 
            this.TimerChangeMinning.Interval = 3000;
            this.TimerChangeMinning.Tick += new System.EventHandler(this.TimerChangeMinning_Tick);
            // 
            // TimerGetMinning
            // 
            this.TimerGetMinning.Interval = 5000;
            this.TimerGetMinning.Tick += new System.EventHandler(this.TimerGetMinning_Tick);
            // 
            // lCode
            // 
            this.lCode.AutoSize = true;
            this.lCode.Location = new System.Drawing.Point(164, 26);
            this.lCode.Name = "lCode";
            this.lCode.Size = new System.Drawing.Size(95, 36);
            this.lCode.TabIndex = 4;
            this.lCode.Text = "label1";
            // 
            // gridCloud
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCloud.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridCloud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCloud.DefaultCellStyle = dataGridViewCellStyle13;
            this.gridCloud.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridCloud.Location = new System.Drawing.Point(3, 328);
            this.gridCloud.Name = "gridCloud";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCloud.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.gridCloud.Size = new System.Drawing.Size(414, 158);
            this.gridCloud.TabIndex = 5;
            // 
            // lCloud
            // 
            this.lCloud.AutoSize = true;
            this.lCloud.Location = new System.Drawing.Point(16, 287);
            this.lCloud.Name = "lCloud";
            this.lCloud.Size = new System.Drawing.Size(359, 36);
            this.lCloud.TabIndex = 6;
            this.lCloud.Text = "Mining and Cloud Speeds";
            // 
            // tabOther
            // 
            this.tabOther.Controls.Add(this.eWalletAddress);
            this.tabOther.Controls.Add(this.lWalletAddress);
            this.tabOther.Controls.Add(this.cCoinWallet);
            this.tabOther.Controls.Add(this.label2);
            this.tabOther.Controls.Add(this.label1);
            this.tabOther.Controls.Add(this.eEstimate);
            this.tabOther.Controls.Add(this.eAmount);
            this.tabOther.Controls.Add(this.cTo);
            this.tabOther.Controls.Add(this.cFrom);
            this.tabOther.Controls.Add(this.bEstimate);
            this.tabOther.Controls.Add(this.lTo);
            this.tabOther.Controls.Add(this.lAmount);
            this.tabOther.Controls.Add(this.lFrom);
            this.tabOther.Location = new System.Drawing.Point(4, 42);
            this.tabOther.Name = "tabOther";
            this.tabOther.Padding = new System.Windows.Forms.Padding(3);
            this.tabOther.Size = new System.Drawing.Size(420, 489);
            this.tabOther.TabIndex = 3;
            this.tabOther.Text = "Other";
            this.tabOther.UseVisualStyleBackColor = true;
            // 
            // lFrom
            // 
            this.lFrom.AutoSize = true;
            this.lFrom.Location = new System.Drawing.Point(6, 43);
            this.lFrom.Name = "lFrom";
            this.lFrom.Size = new System.Drawing.Size(83, 36);
            this.lFrom.TabIndex = 0;
            this.lFrom.Text = "From";
            // 
            // lAmount
            // 
            this.lAmount.AutoSize = true;
            this.lAmount.Location = new System.Drawing.Point(6, 90);
            this.lAmount.Name = "lAmount";
            this.lAmount.Size = new System.Drawing.Size(118, 36);
            this.lAmount.TabIndex = 1;
            this.lAmount.Text = "Amount";
            // 
            // lTo
            // 
            this.lTo.AutoSize = true;
            this.lTo.Location = new System.Drawing.Point(6, 134);
            this.lTo.Name = "lTo";
            this.lTo.Size = new System.Drawing.Size(50, 36);
            this.lTo.TabIndex = 2;
            this.lTo.Text = "To";
            // 
            // bEstimate
            // 
            this.bEstimate.Location = new System.Drawing.Point(6, 182);
            this.bEstimate.Name = "bEstimate";
            this.bEstimate.Size = new System.Drawing.Size(165, 40);
            this.bEstimate.TabIndex = 3;
            this.bEstimate.Text = "Estimate";
            this.bEstimate.UseVisualStyleBackColor = true;
            this.bEstimate.Click += new System.EventHandler(this.bEstimate_Click);
            // 
            // cFrom
            // 
            this.cFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cFrom.FormattingEnabled = true;
            this.cFrom.Location = new System.Drawing.Point(206, 43);
            this.cFrom.Name = "cFrom";
            this.cFrom.Size = new System.Drawing.Size(207, 41);
            this.cFrom.Sorted = true;
            this.cFrom.TabIndex = 4;
            // 
            // cTo
            // 
            this.cTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cTo.FormattingEnabled = true;
            this.cTo.Location = new System.Drawing.Point(206, 134);
            this.cTo.Name = "cTo";
            this.cTo.Size = new System.Drawing.Size(207, 41);
            this.cTo.Sorted = true;
            this.cTo.TabIndex = 5;
            // 
            // eAmount
            // 
            this.eAmount.Location = new System.Drawing.Point(206, 90);
            this.eAmount.Name = "eAmount";
            this.eAmount.Size = new System.Drawing.Size(207, 41);
            this.eAmount.TabIndex = 6;
            // 
            // eEstimate
            // 
            this.eEstimate.Location = new System.Drawing.Point(206, 181);
            this.eEstimate.Name = "eEstimate";
            this.eEstimate.Size = new System.Drawing.Size(207, 41);
            this.eEstimate.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Estimate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Wallet Address";
            // 
            // cCoinWallet
            // 
            this.cCoinWallet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cCoinWallet.FormattingEnabled = true;
            this.cCoinWallet.Location = new System.Drawing.Point(7, 295);
            this.cCoinWallet.Name = "cCoinWallet";
            this.cCoinWallet.Size = new System.Drawing.Size(117, 41);
            this.cCoinWallet.Sorted = true;
            this.cCoinWallet.TabIndex = 10;
            this.cCoinWallet.SelectedIndexChanged += new System.EventHandler(this.cCoinWallet_SelectedIndexChanged);
            // 
            // lWalletAddress
            // 
            this.lWalletAddress.AutoSize = true;
            this.lWalletAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWalletAddress.Location = new System.Drawing.Point(138, 305);
            this.lWalletAddress.Name = "lWalletAddress";
            this.lWalletAddress.Size = new System.Drawing.Size(0, 26);
            this.lWalletAddress.TabIndex = 11;
            // 
            // eWalletAddress
            // 
            this.eWalletAddress.Location = new System.Drawing.Point(130, 295);
            this.eWalletAddress.Name = "eWalletAddress";
            this.eWalletAddress.ReadOnly = true;
            this.eWalletAddress.Size = new System.Drawing.Size(284, 41);
            this.eWalletAddress.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 538);
            this.Controls.Add(this.tabEobot);
            this.Controls.Add(this.pLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Eobot Manager";
            this.tabEobot.ResumeLayout(false);
            this.tabMining.ResumeLayout(false);
            this.tabMining.PerformLayout();
            this.tabBalance.ResumeLayout(false);
            this.tabRates.ResumeLayout(false);
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBalances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCloud)).EndInit();
            this.tabOther.ResumeLayout(false);
            this.tabOther.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabEobot;
        private System.Windows.Forms.TabPage tabMining;
        private System.Windows.Forms.TabPage tabBalance;
        private System.Windows.Forms.TabPage tabRates;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.TextBox ePassword;
        private System.Windows.Forms.TextBox eEmail;
        private System.Windows.Forms.TextBox eUserId;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lUserId;
        private System.Windows.Forms.PictureBox pCoin;
        private System.Windows.Forms.Timer TimerLog;
        private System.Windows.Forms.DataGridView gridBalances;
        private System.Windows.Forms.DataGridView gridRates;
        private System.Windows.Forms.ComboBox cSelectMinning;
        private System.Windows.Forms.Label lBalance;
        private System.Windows.Forms.Label lRate;
        private System.Windows.Forms.Timer TimerChangeMinning;
        private System.Windows.Forms.Timer TimerGetMinning;
        private System.Windows.Forms.Label lCode;
        private System.Windows.Forms.DataGridView gridCloud;
        private System.Windows.Forms.Label lCloud;
        private System.Windows.Forms.TabPage tabOther;
        private System.Windows.Forms.TextBox eEstimate;
        private System.Windows.Forms.TextBox eAmount;
        private System.Windows.Forms.ComboBox cTo;
        private System.Windows.Forms.ComboBox cFrom;
        private System.Windows.Forms.Button bEstimate;
        private System.Windows.Forms.Label lTo;
        private System.Windows.Forms.Label lAmount;
        private System.Windows.Forms.Label lFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lWalletAddress;
        private System.Windows.Forms.ComboBox cCoinWallet;
        private System.Windows.Forms.TextBox eWalletAddress;
    }
}

