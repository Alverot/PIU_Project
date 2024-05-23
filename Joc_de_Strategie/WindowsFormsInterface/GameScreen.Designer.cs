namespace WindowsFormsInterface
{
    partial class GameScreen
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Spearman(50w,100f)");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Archers(75w,75f)");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Horsemans(25w,125f)");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Man at arms(75g,100f)");
            this.Back_to_menu = new System.Windows.Forms.Button();
            this.NextTurn = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.FoodLable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WoodLable = new System.Windows.Forms.Label();
            this.StoneLable = new System.Windows.Forms.Label();
            this.GoldLable = new System.Windows.Forms.Label();
            this.SelectTileButon = new System.Windows.Forms.Button();
            this.TurnLable = new System.Windows.Forms.Label();
            this.ErorOutOfMap = new System.Windows.Forms.Label();
            this.TileInfoBox = new System.Windows.Forms.ListBox();
            this.ClamT = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.ConsVillage = new System.Windows.Forms.Button();
            this.ConstFarm = new System.Windows.Forms.Button();
            this.ConsCamp = new System.Windows.Forms.Button();
            this.ConsMine = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.UpgradeB = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.Trade = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_to_menu
            // 
            this.Back_to_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_to_menu.ForeColor = System.Drawing.Color.DarkCyan;
            this.Back_to_menu.Location = new System.Drawing.Point(12, 12);
            this.Back_to_menu.Name = "Back_to_menu";
            this.Back_to_menu.Size = new System.Drawing.Size(172, 58);
            this.Back_to_menu.TabIndex = 0;
            this.Back_to_menu.Text = "Save and Exit";
            this.Back_to_menu.UseVisualStyleBackColor = true;
            this.Back_to_menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // NextTurn
            // 
            this.NextTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextTurn.ForeColor = System.Drawing.Color.DarkCyan;
            this.NextTurn.Location = new System.Drawing.Point(708, 635);
            this.NextTurn.Name = "NextTurn";
            this.NextTurn.Size = new System.Drawing.Size(172, 58);
            this.NextTurn.TabIndex = 5;
            this.NextTurn.Text = "Next Turn";
            this.NextTurn.UseVisualStyleBackColor = true;
            this.NextTurn.Click += new System.EventHandler(this.NextTurn_Click);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(964, 265);
            this.treeView1.Name = "treeView1";
            treeNode9.Name = "SpearmanTr";
            treeNode9.Text = "Spearman(50w,100f)";
            treeNode10.Name = "ArchersTr";
            treeNode10.Text = "Archers(75w,75f)";
            treeNode11.Name = "HorsemansTr";
            treeNode11.Text = "Horsemans(25w,125f)";
            treeNode12.Name = "Man_at_armsTr";
            treeNode12.Text = "Man at arms(75g,100f)";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(206, 105);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(734, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Buidings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(1009, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Army training";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(778, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Curent tile :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(886, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "x:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(898, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Actions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(309, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Player collor :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(800, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Resourses";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(3, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Food:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(3, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Wood:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(565, 34);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FoodLable);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.WoodLable);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Size = new System.Drawing.Size(281, 45);
            this.splitContainer1.SplitterDistance = 131;
            this.splitContainer1.TabIndex = 22;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(852, 34);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.StoneLable);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.GoldLable);
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Size = new System.Drawing.Size(281, 45);
            this.splitContainer2.SplitterDistance = 131;
            this.splitContainer2.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(3, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "Stone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(3, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 22);
            this.label11.TabIndex = 21;
            this.label11.Text = "Gold:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(971, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 22);
            this.label12.TabIndex = 24;
            this.label12.Text = "y:";
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(916, 168);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(49, 22);
            this.XTextBox.TabIndex = 25;
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(994, 170);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(49, 22);
            this.YTextBox.TabIndex = 26;
            // 
            // FoodLable
            // 
            this.FoodLable.AutoSize = true;
            this.FoodLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodLable.ForeColor = System.Drawing.Color.DarkCyan;
            this.FoodLable.Location = new System.Drawing.Point(56, 12);
            this.FoodLable.Name = "FoodLable";
            this.FoodLable.Size = new System.Drawing.Size(24, 22);
            this.FoodLable.TabIndex = 27;
            this.FoodLable.Text = "x:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsInterface.Properties.Resources.Blue;
            this.pictureBox1.Location = new System.Drawing.Point(450, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // WoodLable
            // 
            this.WoodLable.AutoSize = true;
            this.WoodLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WoodLable.ForeColor = System.Drawing.Color.DarkCyan;
            this.WoodLable.Location = new System.Drawing.Point(60, 14);
            this.WoodLable.Name = "WoodLable";
            this.WoodLable.Size = new System.Drawing.Size(24, 22);
            this.WoodLable.TabIndex = 28;
            this.WoodLable.Text = "x:";
            // 
            // StoneLable
            // 
            this.StoneLable.AutoSize = true;
            this.StoneLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoneLable.ForeColor = System.Drawing.Color.DarkCyan;
            this.StoneLable.Location = new System.Drawing.Point(60, 14);
            this.StoneLable.Name = "StoneLable";
            this.StoneLable.Size = new System.Drawing.Size(24, 22);
            this.StoneLable.TabIndex = 28;
            this.StoneLable.Text = "x:";
            // 
            // GoldLable
            // 
            this.GoldLable.AutoSize = true;
            this.GoldLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldLable.ForeColor = System.Drawing.Color.DarkCyan;
            this.GoldLable.Location = new System.Drawing.Point(56, 14);
            this.GoldLable.Name = "GoldLable";
            this.GoldLable.Size = new System.Drawing.Size(24, 22);
            this.GoldLable.TabIndex = 28;
            this.GoldLable.Text = "x:";
            // 
            // SelectTileButon
            // 
            this.SelectTileButon.Location = new System.Drawing.Point(1058, 170);
            this.SelectTileButon.Name = "SelectTileButon";
            this.SelectTileButon.Size = new System.Drawing.Size(75, 23);
            this.SelectTileButon.TabIndex = 28;
            this.SelectTileButon.Text = "Select";
            this.SelectTileButon.UseVisualStyleBackColor = true;
            this.SelectTileButon.Click += new System.EventHandler(this.SelectTileButon_Click);
            // 
            // TurnLable
            // 
            this.TurnLable.AutoSize = true;
            this.TurnLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnLable.ForeColor = System.Drawing.Color.DarkCyan;
            this.TurnLable.Location = new System.Drawing.Point(927, 653);
            this.TurnLable.Name = "TurnLable";
            this.TurnLable.Size = new System.Drawing.Size(58, 22);
            this.TurnLable.TabIndex = 29;
            this.TurnLable.Text = "Turn :\r\n";
            // 
            // ErorOutOfMap
            // 
            this.ErorOutOfMap.AutoSize = true;
            this.ErorOutOfMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErorOutOfMap.ForeColor = System.Drawing.Color.DarkCyan;
            this.ErorOutOfMap.Location = new System.Drawing.Point(917, 134);
            this.ErorOutOfMap.Name = "ErorOutOfMap";
            this.ErorOutOfMap.Size = new System.Drawing.Size(0, 22);
            this.ErorOutOfMap.TabIndex = 30;
            // 
            // TileInfoBox
            // 
            this.TileInfoBox.FormattingEnabled = true;
            this.TileInfoBox.ItemHeight = 16;
            this.TileInfoBox.Location = new System.Drawing.Point(707, 439);
            this.TileInfoBox.Name = "TileInfoBox";
            this.TileInfoBox.Size = new System.Drawing.Size(173, 100);
            this.TileInfoBox.TabIndex = 31;
            // 
            // ClamT
            // 
            this.ClamT.Location = new System.Drawing.Point(890, 467);
            this.ClamT.Name = "ClamT";
            this.ClamT.Size = new System.Drawing.Size(123, 33);
            this.ClamT.TabIndex = 32;
            this.ClamT.Text = "Claim Teritory";
            this.ClamT.UseVisualStyleBackColor = true;
            this.ClamT.Click += new System.EventHandler(this.ClamT_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkCyan;
            this.label13.Location = new System.Drawing.Point(1019, 470);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 22);
            this.label13.TabIndex = 33;
            this.label13.Text = "150 G";
            // 
            // ConsVillage
            // 
            this.ConsVillage.Location = new System.Drawing.Point(716, 262);
            this.ConsVillage.Name = "ConsVillage";
            this.ConsVillage.Size = new System.Drawing.Size(123, 33);
            this.ConsVillage.TabIndex = 34;
            this.ConsVillage.Text = "Village";
            this.ConsVillage.UseVisualStyleBackColor = true;
            this.ConsVillage.Click += new System.EventHandler(this.ConsVillage_Click);
            // 
            // ConstFarm
            // 
            this.ConstFarm.Location = new System.Drawing.Point(716, 301);
            this.ConstFarm.Name = "ConstFarm";
            this.ConstFarm.Size = new System.Drawing.Size(123, 33);
            this.ConstFarm.TabIndex = 35;
            this.ConstFarm.Text = "Farm";
            this.ConstFarm.UseVisualStyleBackColor = true;
            this.ConstFarm.Click += new System.EventHandler(this.ConstFarm_Click);
            // 
            // ConsCamp
            // 
            this.ConsCamp.Location = new System.Drawing.Point(716, 340);
            this.ConsCamp.Name = "ConsCamp";
            this.ConsCamp.Size = new System.Drawing.Size(123, 33);
            this.ConsCamp.TabIndex = 36;
            this.ConsCamp.Text = "Lumber Camp";
            this.ConsCamp.UseVisualStyleBackColor = true;
            this.ConsCamp.Click += new System.EventHandler(this.ConsCamp_Click);
            // 
            // ConsMine
            // 
            this.ConsMine.Location = new System.Drawing.Point(716, 379);
            this.ConsMine.Name = "ConsMine";
            this.ConsMine.Size = new System.Drawing.Size(123, 33);
            this.ConsMine.TabIndex = 37;
            this.ConsMine.Text = "Mine";
            this.ConsMine.UseVisualStyleBackColor = true;
            this.ConsMine.Click += new System.EventHandler(this.ConsMine_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkCyan;
            this.label14.Location = new System.Drawing.Point(833, 265);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 22);
            this.label14.TabIndex = 38;
            this.label14.Text = "100 F 50 W";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkCyan;
            this.label15.Location = new System.Drawing.Point(845, 304);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 22);
            this.label15.TabIndex = 39;
            this.label15.Text = "50 W 25 S";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkCyan;
            this.label16.Location = new System.Drawing.Point(845, 345);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 22);
            this.label16.TabIndex = 40;
            this.label16.Text = "50 F 25 W";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkCyan;
            this.label17.Location = new System.Drawing.Point(845, 382);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 22);
            this.label17.TabIndex = 41;
            this.label17.Text = "50 W 50 F";
            // 
            // UpgradeB
            // 
            this.UpgradeB.Location = new System.Drawing.Point(890, 506);
            this.UpgradeB.Name = "UpgradeB";
            this.UpgradeB.Size = new System.Drawing.Size(123, 33);
            this.UpgradeB.TabIndex = 42;
            this.UpgradeB.Text = "Upgrade Building";
            this.UpgradeB.UseVisualStyleBackColor = true;
            this.UpgradeB.Click += new System.EventHandler(this.UpgradeB_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkCyan;
            this.label18.Location = new System.Drawing.Point(1019, 509);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 22);
            this.label18.TabIndex = 43;
            this.label18.Text = "50 W 50 S 50 F";
            // 
            // Trade
            // 
            this.Trade.Location = new System.Drawing.Point(862, 545);
            this.Trade.Name = "Trade";
            this.Trade.Size = new System.Drawing.Size(123, 33);
            this.Trade.TabIndex = 44;
            this.Trade.Text = "Trade resources";
            this.Trade.UseVisualStyleBackColor = true;
            this.Trade.Click += new System.EventHandler(this.Trade_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkCyan;
            this.label19.Location = new System.Drawing.Point(991, 548);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(195, 22);
            this.label19.TabIndex = 45;
            this.label19.Text = "50 G = 10 F 10 W 10 S";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 705);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Trade);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.UpgradeB);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ConsMine);
            this.Controls.Add(this.ConsCamp);
            this.Controls.Add(this.ConstFarm);
            this.Controls.Add(this.ConsVillage);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ClamT);
            this.Controls.Add(this.TileInfoBox);
            this.Controls.Add(this.ErorOutOfMap);
            this.Controls.Add(this.TurnLable);
            this.Controls.Add(this.SelectTileButon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.NextTurn);
            this.Controls.Add(this.Back_to_menu);
            this.Name = "GameScreen";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_to_menu;
        private System.Windows.Forms.Button NextTurn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.Label FoodLable;
        private System.Windows.Forms.Label WoodLable;
        private System.Windows.Forms.Label StoneLable;
        private System.Windows.Forms.Label GoldLable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SelectTileButon;
        private System.Windows.Forms.Label TurnLable;
        private System.Windows.Forms.Label ErorOutOfMap;
        private System.Windows.Forms.ListBox TileInfoBox;
        private System.Windows.Forms.Button ClamT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ConsVillage;
        private System.Windows.Forms.Button ConstFarm;
        private System.Windows.Forms.Button ConsCamp;
        private System.Windows.Forms.Button ConsMine;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button UpgradeB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button Trade;
        private System.Windows.Forms.Label label19;
    }
}