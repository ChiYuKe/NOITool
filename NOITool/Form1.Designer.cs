namespace NOITool
{
    partial class NOITool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NOITool));
            this.label1 = new System.Windows.Forms.Label();
            this.tB1_建筑ID = new System.Windows.Forms.TextBox();
            this.tTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tB4_贴图名称 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB5_建筑血量 = new System.Windows.Forms.TextBox();
            this.生成 = new System.Windows.Forms.Button();
            this.tB2_建筑宽度 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB3_建筑高度 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tB6_建造时间 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cB1_建筑材料 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tB8_建筑熔点 = new System.Windows.Forms.TextBox();
            this.cB2_建造位置规则 = new System.Windows.Forms.ComboBox();
            this.cB3_建筑质量 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nB_装饰度 = new System.Windows.Forms.NumericUpDown();
            this.nB_装饰半径 = new System.Windows.Forms.NumericUpDown();
            this.rB_模板 = new System.Windows.Forms.RichTextBox();
            this.cB_yaml文件 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nB_装饰度)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nB_装饰半径)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "建筑ID：";
            this.tTip1.SetToolTip(this.label1, "1.ID是唯一的，不要与游戏内ID发生冲突\r\n2.ID请使用英文，并且ID首字母大写");
            // 
            // tB1_建筑ID
            // 
            this.tB1_建筑ID.Location = new System.Drawing.Point(68, 52);
            this.tB1_建筑ID.Name = "tB1_建筑ID";
            this.tB1_建筑ID.Size = new System.Drawing.Size(182, 27);
            this.tB1_建筑ID.TabIndex = 1;
            this.tTip1.SetToolTip(this.tB1_建筑ID, "1.ID是唯一的，不要与游戏内ID发生冲突\r\n2.ID请使用英文，并且ID首字母大写");
            // 
            // tTip1
            // 
            this.tTip1.AutomaticDelay = 300;
            this.tTip1.AutoPopDelay = 5000;
            this.tTip1.BackColor = System.Drawing.Color.IndianRed;
            this.tTip1.ForeColor = System.Drawing.Color.DarkSalmon;
            this.tTip1.InitialDelay = 300;
            this.tTip1.ReshowDelay = 60;
            this.tTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tTip1.ToolTipTitle = "建议";
            // 
            // tB4_贴图名称
            // 
            this.tB4_贴图名称.Location = new System.Drawing.Point(102, 151);
            this.tB4_贴图名称.Name = "tB4_贴图名称";
            this.tB4_贴图名称.Size = new System.Drawing.Size(148, 27);
            this.tB4_贴图名称.TabIndex = 8;
            this.tB4_贴图名称.Text = "waterpurifier";
            this.tTip1.SetToolTip(this.tB4_贴图名称, "1.名称后面不需要加“_kanim”后缀，默认已添加\r\n2.默认用的是净水器的贴图名称\r\n");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(4, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "贴图名称：";
            this.tTip1.SetToolTip(this.label4, "1.名称后面不需要加“_kanim”后缀，默认已添加\r\n2.默认用的是净水器的贴图名称");
            // 
            // tB5_建筑血量
            // 
            this.tB5_建筑血量.Location = new System.Drawing.Point(102, 184);
            this.tB5_建筑血量.Name = "tB5_建筑血量";
            this.tB5_建筑血量.Size = new System.Drawing.Size(148, 27);
            this.tB5_建筑血量.TabIndex = 10;
            // 
            // 生成
            // 
            this.生成.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.生成.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.生成.Location = new System.Drawing.Point(4, 434);
            this.生成.Name = "生成";
            this.生成.Size = new System.Drawing.Size(246, 127);
            this.生成.TabIndex = 2;
            this.生成.Text = "生成";
            this.生成.UseVisualStyleBackColor = true;
            this.生成.Click += new System.EventHandler(this.生成_Click);
            // 
            // tB2_建筑宽度
            // 
            this.tB2_建筑宽度.Location = new System.Drawing.Point(102, 85);
            this.tB2_建筑宽度.Name = "tB2_建筑宽度";
            this.tB2_建筑宽度.Size = new System.Drawing.Size(148, 27);
            this.tB2_建筑宽度.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "建筑宽度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "建筑高度：";
            // 
            // tB3_建筑高度
            // 
            this.tB3_建筑高度.Location = new System.Drawing.Point(102, 118);
            this.tB3_建筑高度.Name = "tB3_建筑高度";
            this.tB3_建筑高度.Size = new System.Drawing.Size(148, 27);
            this.tB3_建筑高度.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(4, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "建筑质量：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(4, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "建筑建造时间：";
            // 
            // tB6_建造时间
            // 
            this.tB6_建造时间.Location = new System.Drawing.Point(128, 217);
            this.tB6_建造时间.Name = "tB6_建造时间";
            this.tB6_建造时间.Size = new System.Drawing.Size(122, 27);
            this.tB6_建造时间.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(4, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "建筑血量：";
            // 
            // cB1_建筑材料
            // 
            this.cB1_建筑材料.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB1_建筑材料.FormattingEnabled = true;
            this.cB1_建筑材料.Items.AddRange(new object[] {
            "所有金属",
            "原始金属",
            "精炼金属",
            "合金",
            "所有矿物",
            "原始矿物",
            "精炼矿物",
            "珍贵岩石",
            "可耕种的",
            "水管材料",
            "塑料",
            "玻璃",
            "透明材料",
            "植物纤维",
            "任意可建造的",
            "飞行生物食物",
            "辐射防护"});
            this.cB1_建筑材料.Location = new System.Drawing.Point(99, 283);
            this.cB1_建筑材料.Name = "cB1_建筑材料";
            this.cB1_建筑材料.Size = new System.Drawing.Size(151, 28);
            this.cB1_建筑材料.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(4, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "建筑材料：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(4, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "建筑熔点：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(4, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "建造位置规则：";
            // 
            // tB8_建筑熔点
            // 
            this.tB8_建筑熔点.Location = new System.Drawing.Point(102, 321);
            this.tB8_建筑熔点.Name = "tB8_建筑熔点";
            this.tB8_建筑熔点.Size = new System.Drawing.Size(148, 27);
            this.tB8_建筑熔点.TabIndex = 19;
            // 
            // cB2_建造位置规则
            // 
            this.cB2_建造位置规则.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB2_建造位置规则.FormattingEnabled = true;
            this.cB2_建造位置规则.Items.AddRange(new object[] {
            "任意位置",
            "在地板上",
            "在地板上方",
            "在天花板上",
            "在墙壁上",
            "在角落",
            "方块",
            "不在方块内",
            "导管",
            "逻辑桥",
            "电线桥",
            "高电力桥方块",
            "建筑附着点",
            "在地板上或建筑附着点上",
            "在可旋转的基础上",
            "在火箭天花板下方",
            "在火箭外壳上",
            "墙壁与地板",
            "原点无液体导管"});
            this.cB2_建造位置规则.Location = new System.Drawing.Point(128, 354);
            this.cB2_建造位置规则.Name = "cB2_建造位置规则";
            this.cB2_建造位置规则.Size = new System.Drawing.Size(122, 28);
            this.cB2_建造位置规则.TabIndex = 20;
            // 
            // cB3_建筑质量
            // 
            this.cB3_建筑质量.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB3_建筑质量.FormattingEnabled = true;
            this.cB3_建筑质量.Items.AddRange(new object[] {
            "5f",
            "25f",
            "50f",
            "100f",
            "200f",
            "400f",
            "800f",
            "1200f",
            "2000f"});
            this.cB3_建筑质量.Location = new System.Drawing.Point(99, 250);
            this.cB3_建筑质量.Name = "cB3_建筑质量";
            this.cB3_建筑质量.Size = new System.Drawing.Size(151, 28);
            this.cB3_建筑质量.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(4, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "装饰度：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(119, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "装饰半径：";
            // 
            // nB_装饰度
            // 
            this.nB_装饰度.Location = new System.Drawing.Point(68, 392);
            this.nB_装饰度.Name = "nB_装饰度";
            this.nB_装饰度.Size = new System.Drawing.Size(45, 27);
            this.nB_装饰度.TabIndex = 24;
            // 
            // nB_装饰半径
            // 
            this.nB_装饰半径.Location = new System.Drawing.Point(206, 392);
            this.nB_装饰半径.Name = "nB_装饰半径";
            this.nB_装饰半径.Size = new System.Drawing.Size(44, 27);
            this.nB_装饰半径.TabIndex = 25;
            // 
            // rB_模板
            // 
            this.rB_模板.Location = new System.Drawing.Point(264, 52);
            this.rB_模板.Name = "rB_模板";
            this.rB_模板.Size = new System.Drawing.Size(526, 159);
            this.rB_模板.TabIndex = 26;
            this.rB_模板.Text = "";
            // 
            // cB_yaml文件
            // 
            this.cB_yaml文件.AutoSize = true;
            this.cB_yaml文件.Location = new System.Drawing.Point(4, 22);
            this.cB_yaml文件.Name = "cB_yaml文件";
            this.cB_yaml文件.Size = new System.Drawing.Size(155, 24);
            this.cB_yaml文件.TabIndex = 27;
            this.cB_yaml文件.Text = "生成基本yaml文件";
            this.cB_yaml文件.UseVisualStyleBackColor = true;
            this.cB_yaml文件.CheckedChanged += new System.EventHandler(this.cB_yaml文件_CheckedChanged);
            // 
            // NOITool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(802, 564);
            this.Controls.Add(this.cB_yaml文件);
            this.Controls.Add(this.rB_模板);
            this.Controls.Add(this.nB_装饰半径);
            this.Controls.Add(this.nB_装饰度);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cB3_建筑质量);
            this.Controls.Add(this.cB2_建造位置规则);
            this.Controls.Add(this.tB8_建筑熔点);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cB1_建筑材料);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tB6_建造时间);
            this.Controls.Add(this.tB5_建筑血量);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tB4_贴图名称);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tB3_建筑高度);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB2_建筑宽度);
            this.Controls.Add(this.生成);
            this.Controls.Add(this.tB1_建筑ID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NOITool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOITool";
            this.Load += new System.EventHandler(this.NOITool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nB_装饰度)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nB_装饰半径)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolTip tTip1;
        private Label label1;
        private Label label2;
        private TextBox tB1_建筑ID;
        private TextBox tB2_建筑宽度;
        private Button 生成;
        private Label label3;
        private TextBox tB3_建筑高度;
        private TextBox tB4_贴图名称;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox tB6_建造时间;
        private TextBox tB5_建筑血量;
        private Label label8;
        private ComboBox cB1_建筑材料;
        private Label label5;
        private Label label9;
        private Label label10;
        private TextBox tB8_建筑熔点;
        private ComboBox cB2_建造位置规则;
        private ComboBox cB3_建筑质量;
        private Label label11;
        private Label label12;
        private NumericUpDown nB_装饰度;
        private NumericUpDown nB_装饰半径;
        private RichTextBox rB_模板;
        private CheckBox cB_yaml文件;
    }
}