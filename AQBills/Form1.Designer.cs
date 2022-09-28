namespace AQBills
{
    partial class BillForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ItemsLbl = new System.Windows.Forms.Label();
            this.CheckPepsi = new System.Windows.Forms.CheckBox();
            this.CheckSprite = new System.Windows.Forms.CheckBox();
            this.CheckFanta = new System.Windows.Forms.CheckBox();
            this.CheckDew = new System.Windows.Forms.CheckBox();
            this.CheckTea = new System.Windows.Forms.CheckBox();
            this.CheckCoffee = new System.Windows.Forms.CheckBox();
            this.CheckRedbull = new System.Windows.Forms.CheckBox();
            this.PrcPepsi = new System.Windows.Forms.Label();
            this.PrcSprite = new System.Windows.Forms.Label();
            this.PrcFanta = new System.Windows.Forms.Label();
            this.PrcDew = new System.Windows.Forms.Label();
            this.PrcTea = new System.Windows.Forms.Label();
            this.PrcCoffee = new System.Windows.Forms.Label();
            this.PrcRedbull = new System.Windows.Forms.Label();
            this.drinksLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BillLbl = new System.Windows.Forms.Label();
            this.BillBtn = new System.Windows.Forms.Button();
            this.TotalItems = new System.Windows.Forms.Label();
            this.ItemsList = new System.Windows.Forms.Label();
            this.TotalAmountLbl = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.SnacksLbl = new System.Windows.Forms.Label();
            this.PrcSpecial = new System.Windows.Forms.Label();
            this.PrcBeef = new System.Windows.Forms.Label();
            this.PrcWrap = new System.Windows.Forms.Label();
            this.PrcClub = new System.Windows.Forms.Label();
            this.PrcLoaded = new System.Windows.Forms.Label();
            this.PrcFrench = new System.Windows.Forms.Label();
            this.PrcNachos = new System.Windows.Forms.Label();
            this.checkSpecial = new System.Windows.Forms.CheckBox();
            this.checkBeef = new System.Windows.Forms.CheckBox();
            this.checkWrap = new System.Windows.Forms.CheckBox();
            this.checkClub = new System.Windows.Forms.CheckBox();
            this.checkLoaded = new System.Windows.Forms.CheckBox();
            this.checkFrench = new System.Windows.Forms.CheckBox();
            this.checkNachos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(408, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "AQ\'s Cafe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(588, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 92);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ItemsLbl
            // 
            this.ItemsLbl.AutoSize = true;
            this.ItemsLbl.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ItemsLbl.ForeColor = System.Drawing.Color.Black;
            this.ItemsLbl.Location = new System.Drawing.Point(15, 109);
            this.ItemsLbl.Name = "ItemsLbl";
            this.ItemsLbl.Size = new System.Drawing.Size(210, 36);
            this.ItemsLbl.TabIndex = 2;
            this.ItemsLbl.Text = "Choose Items";
            this.ItemsLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // CheckPepsi
            // 
            this.CheckPepsi.AutoSize = true;
            this.CheckPepsi.BackColor = System.Drawing.Color.Transparent;
            this.CheckPepsi.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckPepsi.ForeColor = System.Drawing.Color.Black;
            this.CheckPepsi.Location = new System.Drawing.Point(469, 232);
            this.CheckPepsi.Name = "CheckPepsi";
            this.CheckPepsi.Size = new System.Drawing.Size(89, 36);
            this.CheckPepsi.TabIndex = 4;
            this.CheckPepsi.Text = "Pepsi";
            this.CheckPepsi.UseVisualStyleBackColor = false;
            // 
            // CheckSprite
            // 
            this.CheckSprite.AutoSize = true;
            this.CheckSprite.BackColor = System.Drawing.Color.Transparent;
            this.CheckSprite.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckSprite.ForeColor = System.Drawing.Color.Black;
            this.CheckSprite.Location = new System.Drawing.Point(470, 268);
            this.CheckSprite.Name = "CheckSprite";
            this.CheckSprite.Size = new System.Drawing.Size(97, 36);
            this.CheckSprite.TabIndex = 5;
            this.CheckSprite.Text = "Sprite";
            this.CheckSprite.UseVisualStyleBackColor = false;
            // 
            // CheckFanta
            // 
            this.CheckFanta.AutoSize = true;
            this.CheckFanta.BackColor = System.Drawing.Color.Transparent;
            this.CheckFanta.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckFanta.ForeColor = System.Drawing.Color.Black;
            this.CheckFanta.Location = new System.Drawing.Point(470, 303);
            this.CheckFanta.Name = "CheckFanta";
            this.CheckFanta.Size = new System.Drawing.Size(93, 36);
            this.CheckFanta.TabIndex = 6;
            this.CheckFanta.Text = "Fanta";
            this.CheckFanta.UseVisualStyleBackColor = false;
            // 
            // CheckDew
            // 
            this.CheckDew.AutoSize = true;
            this.CheckDew.BackColor = System.Drawing.Color.Transparent;
            this.CheckDew.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckDew.ForeColor = System.Drawing.Color.Black;
            this.CheckDew.Location = new System.Drawing.Point(470, 334);
            this.CheckDew.Name = "CheckDew";
            this.CheckDew.Size = new System.Drawing.Size(81, 36);
            this.CheckDew.TabIndex = 7;
            this.CheckDew.Text = "Dew";
            this.CheckDew.UseVisualStyleBackColor = false;
            // 
            // CheckTea
            // 
            this.CheckTea.AutoSize = true;
            this.CheckTea.BackColor = System.Drawing.Color.Transparent;
            this.CheckTea.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckTea.ForeColor = System.Drawing.Color.Black;
            this.CheckTea.Location = new System.Drawing.Point(470, 365);
            this.CheckTea.Name = "CheckTea";
            this.CheckTea.Size = new System.Drawing.Size(70, 36);
            this.CheckTea.TabIndex = 8;
            this.CheckTea.Text = "Tea";
            this.CheckTea.UseVisualStyleBackColor = false;
            // 
            // CheckCoffee
            // 
            this.CheckCoffee.AutoSize = true;
            this.CheckCoffee.BackColor = System.Drawing.Color.Transparent;
            this.CheckCoffee.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckCoffee.ForeColor = System.Drawing.Color.Black;
            this.CheckCoffee.Location = new System.Drawing.Point(469, 396);
            this.CheckCoffee.Name = "CheckCoffee";
            this.CheckCoffee.Size = new System.Drawing.Size(104, 36);
            this.CheckCoffee.TabIndex = 9;
            this.CheckCoffee.Text = "Coffee";
            this.CheckCoffee.UseVisualStyleBackColor = false;
            // 
            // CheckRedbull
            // 
            this.CheckRedbull.AutoSize = true;
            this.CheckRedbull.BackColor = System.Drawing.Color.Transparent;
            this.CheckRedbull.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckRedbull.ForeColor = System.Drawing.Color.Black;
            this.CheckRedbull.Location = new System.Drawing.Point(469, 427);
            this.CheckRedbull.Name = "CheckRedbull";
            this.CheckRedbull.Size = new System.Drawing.Size(114, 36);
            this.CheckRedbull.TabIndex = 10;
            this.CheckRedbull.Text = "Redbull";
            this.CheckRedbull.UseVisualStyleBackColor = false;
            // 
            // PrcPepsi
            // 
            this.PrcPepsi.AutoSize = true;
            this.PrcPepsi.BackColor = System.Drawing.Color.Transparent;
            this.PrcPepsi.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrcPepsi.ForeColor = System.Drawing.Color.Black;
            this.PrcPepsi.Location = new System.Drawing.Point(682, 236);
            this.PrcPepsi.Name = "PrcPepsi";
            this.PrcPepsi.Size = new System.Drawing.Size(40, 32);
            this.PrcPepsi.TabIndex = 11;
            this.PrcPepsi.Text = "35";
            // 
            // PrcSprite
            // 
            this.PrcSprite.AutoSize = true;
            this.PrcSprite.BackColor = System.Drawing.Color.Transparent;
            this.PrcSprite.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrcSprite.ForeColor = System.Drawing.Color.Black;
            this.PrcSprite.Location = new System.Drawing.Point(682, 271);
            this.PrcSprite.Name = "PrcSprite";
            this.PrcSprite.Size = new System.Drawing.Size(40, 32);
            this.PrcSprite.TabIndex = 12;
            this.PrcSprite.Text = "35";
            // 
            // PrcFanta
            // 
            this.PrcFanta.AutoSize = true;
            this.PrcFanta.BackColor = System.Drawing.Color.Transparent;
            this.PrcFanta.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrcFanta.ForeColor = System.Drawing.Color.Black;
            this.PrcFanta.Location = new System.Drawing.Point(683, 304);
            this.PrcFanta.Name = "PrcFanta";
            this.PrcFanta.Size = new System.Drawing.Size(40, 32);
            this.PrcFanta.TabIndex = 13;
            this.PrcFanta.Text = "35";
            // 
            // PrcDew
            // 
            this.PrcDew.AutoSize = true;
            this.PrcDew.BackColor = System.Drawing.Color.Transparent;
            this.PrcDew.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrcDew.ForeColor = System.Drawing.Color.Black;
            this.PrcDew.Location = new System.Drawing.Point(683, 335);
            this.PrcDew.Name = "PrcDew";
            this.PrcDew.Size = new System.Drawing.Size(40, 32);
            this.PrcDew.TabIndex = 14;
            this.PrcDew.Text = "35";
            // 
            // PrcTea
            // 
            this.PrcTea.AutoSize = true;
            this.PrcTea.BackColor = System.Drawing.Color.Transparent;
            this.PrcTea.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrcTea.ForeColor = System.Drawing.Color.Black;
            this.PrcTea.Location = new System.Drawing.Point(683, 368);
            this.PrcTea.Name = "PrcTea";
            this.PrcTea.Size = new System.Drawing.Size(50, 32);
            this.PrcTea.TabIndex = 15;
            this.PrcTea.Text = "150";
            // 
            // PrcCoffee
            // 
            this.PrcCoffee.AutoSize = true;
            this.PrcCoffee.BackColor = System.Drawing.Color.Transparent;
            this.PrcCoffee.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrcCoffee.ForeColor = System.Drawing.Color.Black;
            this.PrcCoffee.Location = new System.Drawing.Point(682, 398);
            this.PrcCoffee.Name = "PrcCoffee";
            this.PrcCoffee.Size = new System.Drawing.Size(53, 32);
            this.PrcCoffee.TabIndex = 16;
            this.PrcCoffee.Text = "200";
            // 
            // PrcRedbull
            // 
            this.PrcRedbull.AutoSize = true;
            this.PrcRedbull.BackColor = System.Drawing.Color.Transparent;
            this.PrcRedbull.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrcRedbull.ForeColor = System.Drawing.Color.Black;
            this.PrcRedbull.Location = new System.Drawing.Point(682, 428);
            this.PrcRedbull.Name = "PrcRedbull";
            this.PrcRedbull.Size = new System.Drawing.Size(53, 32);
            this.PrcRedbull.TabIndex = 17;
            this.PrcRedbull.Text = "350";
            // 
            // drinksLbl
            // 
            this.drinksLbl.AutoSize = true;
            this.drinksLbl.BackColor = System.Drawing.Color.Transparent;
            this.drinksLbl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.drinksLbl.ForeColor = System.Drawing.Color.Black;
            this.drinksLbl.Location = new System.Drawing.Point(465, 158);
            this.drinksLbl.Name = "drinksLbl";
            this.drinksLbl.Size = new System.Drawing.Size(105, 34);
            this.drinksLbl.TabIndex = 3;
            this.drinksLbl.Text = "Drinks";
            this.drinksLbl.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(567, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "250 ml";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BillLbl
            // 
            this.BillLbl.AutoSize = true;
            this.BillLbl.BackColor = System.Drawing.Color.Transparent;
            this.BillLbl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BillLbl.ForeColor = System.Drawing.Color.Black;
            this.BillLbl.Location = new System.Drawing.Point(824, 111);
            this.BillLbl.Name = "BillLbl";
            this.BillLbl.Size = new System.Drawing.Size(135, 34);
            this.BillLbl.TabIndex = 19;
            this.BillLbl.Text = "Total Bill";
            this.BillLbl.Visible = false;
            // 
            // BillBtn
            // 
            this.BillBtn.BackColor = System.Drawing.SystemColors.Info;
            this.BillBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BillBtn.Location = new System.Drawing.Point(527, 527);
            this.BillBtn.Name = "BillBtn";
            this.BillBtn.Size = new System.Drawing.Size(127, 32);
            this.BillBtn.TabIndex = 20;
            this.BillBtn.Text = "Generate Invoice";
            this.BillBtn.UseVisualStyleBackColor = false;
            this.BillBtn.Click += new System.EventHandler(this.BillBtn_Click);
            // 
            // TotalItems
            // 
            this.TotalItems.AutoEllipsis = true;
            this.TotalItems.AutoSize = true;
            this.TotalItems.BackColor = System.Drawing.Color.Transparent;
            this.TotalItems.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalItems.ForeColor = System.Drawing.Color.Black;
            this.TotalItems.Location = new System.Drawing.Point(927, 175);
            this.TotalItems.Name = "TotalItems";
            this.TotalItems.Size = new System.Drawing.Size(0, 23);
            this.TotalItems.TabIndex = 21;
            this.TotalItems.Visible = false;
            this.TotalItems.Click += new System.EventHandler(this.TotalItems_Click);
            // 
            // ItemsList
            // 
            this.ItemsList.AutoSize = true;
            this.ItemsList.BackColor = System.Drawing.Color.Transparent;
            this.ItemsList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemsList.ForeColor = System.Drawing.Color.Black;
            this.ItemsList.Location = new System.Drawing.Point(824, 146);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(123, 32);
            this.ItemsList.TabIndex = 22;
            this.ItemsList.Text = "Items List";
            this.ItemsList.Visible = false;
            // 
            // TotalAmountLbl
            // 
            this.TotalAmountLbl.AutoSize = true;
            this.TotalAmountLbl.BackColor = System.Drawing.Color.Transparent;
            this.TotalAmountLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalAmountLbl.ForeColor = System.Drawing.Color.Black;
            this.TotalAmountLbl.Location = new System.Drawing.Point(841, 524);
            this.TotalAmountLbl.Name = "TotalAmountLbl";
            this.TotalAmountLbl.Size = new System.Drawing.Size(148, 30);
            this.TotalAmountLbl.TabIndex = 24;
            this.TotalAmountLbl.Text = "Total Amount";
            this.TotalAmountLbl.Visible = false;
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoEllipsis = true;
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.TotalAmount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalAmount.ForeColor = System.Drawing.Color.Black;
            this.TotalAmount.Location = new System.Drawing.Point(996, 523);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(0, 30);
            this.TotalAmount.TabIndex = 23;
            this.TotalAmount.Visible = false;
            this.TotalAmount.Click += new System.EventHandler(this.TotalAmount_Click);
            // 
            // SnacksLbl
            // 
            this.SnacksLbl.AutoSize = true;
            this.SnacksLbl.BackColor = System.Drawing.Color.Transparent;
            this.SnacksLbl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SnacksLbl.ForeColor = System.Drawing.Color.Black;
            this.SnacksLbl.Location = new System.Drawing.Point(15, 158);
            this.SnacksLbl.Name = "SnacksLbl";
            this.SnacksLbl.Size = new System.Drawing.Size(116, 34);
            this.SnacksLbl.TabIndex = 25;
            this.SnacksLbl.Text = "Snacks";
            // 
            // PrcSpecial
            // 
            this.PrcSpecial.AutoSize = true;
            this.PrcSpecial.BackColor = System.Drawing.Color.Transparent;
            this.PrcSpecial.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrcSpecial.ForeColor = System.Drawing.Color.Black;
            this.PrcSpecial.Location = new System.Drawing.Point(318, 428);
            this.PrcSpecial.Name = "PrcSpecial";
            this.PrcSpecial.Size = new System.Drawing.Size(54, 32);
            this.PrcSpecial.TabIndex = 39;
            this.PrcSpecial.Text = "450";
            // 
            // PrcBeef
            // 
            this.PrcBeef.AutoSize = true;
            this.PrcBeef.BackColor = System.Drawing.Color.Transparent;
            this.PrcBeef.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrcBeef.ForeColor = System.Drawing.Color.Black;
            this.PrcBeef.Location = new System.Drawing.Point(318, 398);
            this.PrcBeef.Name = "PrcBeef";
            this.PrcBeef.Size = new System.Drawing.Size(54, 32);
            this.PrcBeef.TabIndex = 38;
            this.PrcBeef.Text = "400";
            // 
            // PrcWrap
            // 
            this.PrcWrap.AutoSize = true;
            this.PrcWrap.BackColor = System.Drawing.Color.Transparent;
            this.PrcWrap.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrcWrap.ForeColor = System.Drawing.Color.Black;
            this.PrcWrap.Location = new System.Drawing.Point(319, 368);
            this.PrcWrap.Name = "PrcWrap";
            this.PrcWrap.Size = new System.Drawing.Size(53, 32);
            this.PrcWrap.TabIndex = 37;
            this.PrcWrap.Text = "200";
            // 
            // PrcClub
            // 
            this.PrcClub.AutoSize = true;
            this.PrcClub.BackColor = System.Drawing.Color.Transparent;
            this.PrcClub.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrcClub.ForeColor = System.Drawing.Color.Black;
            this.PrcClub.Location = new System.Drawing.Point(319, 335);
            this.PrcClub.Name = "PrcClub";
            this.PrcClub.Size = new System.Drawing.Size(53, 32);
            this.PrcClub.TabIndex = 36;
            this.PrcClub.Text = "350";
            // 
            // PrcLoaded
            // 
            this.PrcLoaded.AutoSize = true;
            this.PrcLoaded.BackColor = System.Drawing.Color.Transparent;
            this.PrcLoaded.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrcLoaded.ForeColor = System.Drawing.Color.Black;
            this.PrcLoaded.Location = new System.Drawing.Point(319, 304);
            this.PrcLoaded.Name = "PrcLoaded";
            this.PrcLoaded.Size = new System.Drawing.Size(53, 32);
            this.PrcLoaded.TabIndex = 35;
            this.PrcLoaded.Text = "300";
            // 
            // PrcFrench
            // 
            this.PrcFrench.AutoSize = true;
            this.PrcFrench.BackColor = System.Drawing.Color.Transparent;
            this.PrcFrench.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrcFrench.ForeColor = System.Drawing.Color.Black;
            this.PrcFrench.Location = new System.Drawing.Point(318, 271);
            this.PrcFrench.Name = "PrcFrench";
            this.PrcFrench.Size = new System.Drawing.Size(50, 32);
            this.PrcFrench.TabIndex = 34;
            this.PrcFrench.Text = "150";
            // 
            // PrcNachos
            // 
            this.PrcNachos.AutoSize = true;
            this.PrcNachos.BackColor = System.Drawing.Color.Transparent;
            this.PrcNachos.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrcNachos.ForeColor = System.Drawing.Color.Black;
            this.PrcNachos.Location = new System.Drawing.Point(318, 236);
            this.PrcNachos.Name = "PrcNachos";
            this.PrcNachos.Size = new System.Drawing.Size(53, 32);
            this.PrcNachos.TabIndex = 33;
            this.PrcNachos.Text = "250";
            // 
            // checkSpecial
            // 
            this.checkSpecial.AutoSize = true;
            this.checkSpecial.BackColor = System.Drawing.Color.Transparent;
            this.checkSpecial.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkSpecial.ForeColor = System.Drawing.Color.Black;
            this.checkSpecial.Location = new System.Drawing.Point(26, 427);
            this.checkSpecial.Name = "checkSpecial";
            this.checkSpecial.Size = new System.Drawing.Size(246, 36);
            this.checkSpecial.TabIndex = 32;
            this.checkSpecial.Text = "AQ\'s Special Burger";
            this.checkSpecial.UseVisualStyleBackColor = false;
            // 
            // checkBeef
            // 
            this.checkBeef.AutoSize = true;
            this.checkBeef.BackColor = System.Drawing.Color.Transparent;
            this.checkBeef.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBeef.ForeColor = System.Drawing.Color.Black;
            this.checkBeef.Location = new System.Drawing.Point(26, 396);
            this.checkBeef.Name = "checkBeef";
            this.checkBeef.Size = new System.Drawing.Size(163, 36);
            this.checkBeef.TabIndex = 31;
            this.checkBeef.Text = "Beef Burger";
            this.checkBeef.UseVisualStyleBackColor = false;
            // 
            // checkWrap
            // 
            this.checkWrap.AutoSize = true;
            this.checkWrap.BackColor = System.Drawing.Color.Transparent;
            this.checkWrap.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkWrap.ForeColor = System.Drawing.Color.Black;
            this.checkWrap.Location = new System.Drawing.Point(27, 365);
            this.checkWrap.Name = "checkWrap";
            this.checkWrap.Size = new System.Drawing.Size(184, 36);
            this.checkWrap.TabIndex = 30;
            this.checkWrap.Text = "Arabian Wrap";
            this.checkWrap.UseVisualStyleBackColor = false;
            // 
            // checkClub
            // 
            this.checkClub.AutoSize = true;
            this.checkClub.BackColor = System.Drawing.Color.Transparent;
            this.checkClub.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkClub.ForeColor = System.Drawing.Color.Black;
            this.checkClub.Location = new System.Drawing.Point(27, 334);
            this.checkClub.Name = "checkClub";
            this.checkClub.Size = new System.Drawing.Size(192, 36);
            this.checkClub.TabIndex = 29;
            this.checkClub.Text = "Club Sandwich";
            this.checkClub.UseVisualStyleBackColor = false;
            // 
            // checkLoaded
            // 
            this.checkLoaded.AutoSize = true;
            this.checkLoaded.BackColor = System.Drawing.Color.Transparent;
            this.checkLoaded.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkLoaded.ForeColor = System.Drawing.Color.Black;
            this.checkLoaded.Location = new System.Drawing.Point(27, 303);
            this.checkLoaded.Name = "checkLoaded";
            this.checkLoaded.Size = new System.Drawing.Size(170, 36);
            this.checkLoaded.TabIndex = 28;
            this.checkLoaded.Text = "Loaded Fries";
            this.checkLoaded.UseVisualStyleBackColor = false;
            // 
            // checkFrench
            // 
            this.checkFrench.AutoSize = true;
            this.checkFrench.BackColor = System.Drawing.Color.Transparent;
            this.checkFrench.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkFrench.ForeColor = System.Drawing.Color.Black;
            this.checkFrench.Location = new System.Drawing.Point(27, 268);
            this.checkFrench.Name = "checkFrench";
            this.checkFrench.Size = new System.Drawing.Size(163, 36);
            this.checkFrench.TabIndex = 27;
            this.checkFrench.Text = "French Fries";
            this.checkFrench.UseVisualStyleBackColor = false;
            // 
            // checkNachos
            // 
            this.checkNachos.AutoSize = true;
            this.checkNachos.BackColor = System.Drawing.Color.Transparent;
            this.checkNachos.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkNachos.ForeColor = System.Drawing.Color.Black;
            this.checkNachos.Location = new System.Drawing.Point(26, 232);
            this.checkNachos.Name = "checkNachos";
            this.checkNachos.Size = new System.Drawing.Size(113, 36);
            this.checkNachos.TabIndex = 26;
            this.checkNachos.Text = "Nachos";
            this.checkNachos.UseVisualStyleBackColor = false;
            // 
            // BillForm
            // 
            this.AcceptButton = this.BillBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1095, 616);
            this.Controls.Add(this.PrcSpecial);
            this.Controls.Add(this.PrcBeef);
            this.Controls.Add(this.PrcWrap);
            this.Controls.Add(this.PrcClub);
            this.Controls.Add(this.PrcLoaded);
            this.Controls.Add(this.PrcFrench);
            this.Controls.Add(this.PrcNachos);
            this.Controls.Add(this.checkSpecial);
            this.Controls.Add(this.checkBeef);
            this.Controls.Add(this.checkWrap);
            this.Controls.Add(this.checkClub);
            this.Controls.Add(this.checkLoaded);
            this.Controls.Add(this.checkFrench);
            this.Controls.Add(this.checkNachos);
            this.Controls.Add(this.SnacksLbl);
            this.Controls.Add(this.TotalAmountLbl);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.TotalItems);
            this.Controls.Add(this.BillBtn);
            this.Controls.Add(this.BillLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrcRedbull);
            this.Controls.Add(this.PrcCoffee);
            this.Controls.Add(this.PrcTea);
            this.Controls.Add(this.PrcDew);
            this.Controls.Add(this.PrcFanta);
            this.Controls.Add(this.PrcSprite);
            this.Controls.Add(this.PrcPepsi);
            this.Controls.Add(this.CheckRedbull);
            this.Controls.Add(this.CheckCoffee);
            this.Controls.Add(this.CheckTea);
            this.Controls.Add(this.CheckDew);
            this.Controls.Add(this.CheckFanta);
            this.Controls.Add(this.CheckSprite);
            this.Controls.Add(this.CheckPepsi);
            this.Controls.Add(this.drinksLbl);
            this.Controls.Add(this.ItemsLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemsList);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BillForm";
            this.Text = "AQ\'s Bills";
            this.Load += new System.EventHandler(this.BillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label ItemsLbl;
        private CheckBox CheckPepsi;
        private CheckBox CheckSprite;
        private CheckBox CheckFanta;
        private CheckBox CheckDew;
        private CheckBox CheckTea;
        private CheckBox CheckCoffee;
        private CheckBox CheckRedbull;
        private Label PrcPepsi;
        private Label PrcSprite;
        private Label PrcFanta;
        private Label PrcDew;
        private Label PrcTea;
        private Label PrcCoffee;
        private Label PrcRedbull;
        private Label drinksLbl;
        private Label label3;
        private Label BillLbl;
        private Button BillBtn;
        private Label TotalItems;
        private Label ItemsList;
        private Label TotalAmountLbl;
        private Label TotalAmount;
        private Label SnacksLbl;
        private Label PrcSpecial;
        private Label PrcBeef;
        private Label PrcWrap;
        private Label PrcClub;
        private Label PrcLoaded;
        private Label PrcFrench;
        private Label PrcNachos;
        private CheckBox checkSpecial;
        private CheckBox checkBeef;
        private CheckBox checkWrap;
        private CheckBox checkClub;
        private CheckBox checkLoaded;
        private CheckBox checkFrench;
        private CheckBox checkNachos;
    }
}