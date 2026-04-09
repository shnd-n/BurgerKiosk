namespace BurgerKiosk
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            title = new Label();
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            grpMenu = new GroupBox();
            chickPic = new PictureBox();
            bulPic = new PictureBox();
            hamPic = new PictureBox();
            grpOption = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCoke = new CheckBox();
            chkPotato = new CheckBox();
            grpOrder = new GroupBox();
            lblTotalcost = new Label();
            listOrder = new ListBox();
            btnOrder = new Button();
            btnInit = new Button();
            lblWarning = new Label();
            grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chickPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bulPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hamPic).BeginInit();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            title.ForeColor = Color.Blue;
            title.Location = new Point(30, 22);
            title.Name = "title";
            title.Size = new Size(298, 45);
            title.TabIndex = 0;
            title.Text = "버거 주문 키오스크";
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            rdoHamBurger.Location = new Point(18, 62);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(87, 29);
            rdoHamBurger.TabIndex = 1;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            rdoBulgogiBurger.Location = new Point(18, 129);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(125, 29);
            rdoBulgogiBurger.TabIndex = 2;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            rdoChickenBurger.Location = new Point(18, 202);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(106, 29);
            rdoChickenBurger.TabIndex = 3;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(chickPic);
            grpMenu.Controls.Add(bulPic);
            grpMenu.Controls.Add(hamPic);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpMenu.Location = new Point(30, 88);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(275, 273);
            grpMenu.TabIndex = 2;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // chickPic
            // 
            chickPic.Image = (Image)resources.GetObject("chickPic.Image");
            chickPic.Location = new Point(182, 202);
            chickPic.Name = "chickPic";
            chickPic.Size = new Size(76, 49);
            chickPic.SizeMode = PictureBoxSizeMode.Zoom;
            chickPic.TabIndex = 6;
            chickPic.TabStop = false;
            // 
            // bulPic
            // 
            bulPic.Image = (Image)resources.GetObject("bulPic.Image");
            bulPic.Location = new Point(182, 129);
            bulPic.Name = "bulPic";
            bulPic.Size = new Size(76, 49);
            bulPic.SizeMode = PictureBoxSizeMode.Zoom;
            bulPic.TabIndex = 5;
            bulPic.TabStop = false;
            // 
            // hamPic
            // 
            hamPic.BackgroundImageLayout = ImageLayout.None;
            hamPic.Image = (Image)resources.GetObject("hamPic.Image");
            hamPic.Location = new Point(182, 62);
            hamPic.Name = "hamPic";
            hamPic.Size = new Size(76, 49);
            hamPic.SizeMode = PictureBoxSizeMode.Zoom;
            hamPic.TabIndex = 4;
            hamPic.TabStop = false;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkCoke);
            grpOption.Controls.Add(chkPotato);
            grpOption.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOption.Location = new Point(336, 106);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(161, 213);
            grpOption.TabIndex = 3;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkSauce.Location = new Point(11, 174);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(84, 21);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkCheese.Location = new Point(11, 131);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(84, 21);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCoke
            // 
            chkCoke.AutoSize = true;
            chkCoke.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkCoke.Location = new Point(11, 91);
            chkCoke.Name = "chkCoke";
            chkCoke.Size = new Size(53, 21);
            chkCoke.TabIndex = 1;
            chkCoke.Text = "콜라";
            chkCoke.UseVisualStyleBackColor = true;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkPotato.Location = new Point(11, 54);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(79, 21);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalcost);
            grpOrder.Controls.Add(listOrder);
            grpOrder.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOrder.Location = new Point(522, 106);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(299, 255);
            grpOrder.TabIndex = 4;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // lblTotalcost
            // 
            lblTotalcost.AutoSize = true;
            lblTotalcost.Location = new Point(6, 208);
            lblTotalcost.Name = "lblTotalcost";
            lblTotalcost.Size = new Size(154, 32);
            lblTotalcost.TabIndex = 1;
            lblTotalcost.Text = "총 금액 : 0원";
            // 
            // listOrder
            // 
            listOrder.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            listOrder.FormattingEnabled = true;
            listOrder.Location = new Point(6, 44);
            listOrder.Name = "listOrder";
            listOrder.Size = new Size(287, 151);
            listOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(128, 255, 128);
            btnOrder.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(522, 375);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(154, 54);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnInit
            // 
            btnInit.BackColor = Color.Red;
            btnInit.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnInit.ForeColor = Color.White;
            btnInit.Location = new Point(698, 375);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(117, 54);
            btnInit.TabIndex = 6;
            btnInit.Text = "초기화";
            btnInit.UseVisualStyleBackColor = false;
            btnInit.Click += btnInit_Click;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(522, 63);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(202, 21);
            lblWarning.TabIndex = 1;
            lblWarning.Text = "메뉴를 선택하여 주십시오.";
            lblWarning.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 441);
            Controls.Add(lblWarning);
            Controls.Add(btnInit);
            Controls.Add(btnOrder);
            Controls.Add(grpOrder);
            Controls.Add(grpOption);
            Controls.Add(grpMenu);
            Controls.Add(title);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chickPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)bulPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)hamPic).EndInit();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private GroupBox grpMenu;
        private GroupBox grpOption;
        private GroupBox grpOrder;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCoke;
        private CheckBox chkPotato;
        private Label lblTotalcost;
        private ListBox listOrder;
        private PictureBox chickPic;
        private PictureBox bulPic;
        private PictureBox hamPic;
        private Button btnOrder;
        private Button btnInit;
        private Label lblWarning;
    }
}
