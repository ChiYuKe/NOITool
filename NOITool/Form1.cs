namespace NOITool
{
    public partial class NOITool : Form
    {
        private bool Button_Clicked = false;
        public NOITool()
        {
            InitializeComponent();
        }

        private void NOITool_Load(object sender, EventArgs e)
        {   //设置下拉框的默认值
            cB1_建筑材料.SelectedIndex = 0;
            cB3_建筑质量.SelectedIndex = 4;
            cB2_建造位置规则.SelectedIndex = 1;
        }
        public static class FilePathManager
        {
            public static string? FolderPath_Get { get; set; }
        }

        private void 生成_Click(object sender, EventArgs e)
        {
            Button_Clicked = true;
            // 获取 TextBox 中的文本值
            string userInput = tB1_建筑ID.Text;
            string widthInput = tB2_建筑宽度.Text;
            string heightInput = tB3_建筑高度.Text;
            string animInput = tB4_贴图名称.Text;
            string hitpointsInput = tB5_建筑血量.Text;
            string construction_timeInput = tB6_建造时间.Text;
            string construction_massInput = cB3_建筑质量.Text;
            string construction_materialsInput = cB1_建筑材料.Text;
            string melting_pointInput = tB8_建筑熔点.Text;
            string build_location_ruleInput = cB2_建造位置规则.Text;
            string tier2_amountInput = nB_装饰度.Text;
            string tier2_radiusInput = nB_装饰半径.Text;
            string muban = rB_模板.Text;
           


            if (string.IsNullOrEmpty(userInput))
            {
                // userInput为空，弹出警告框
                Logger.Log("输入的ID为空，跳出警告窗口");
                MessageBox.Show("建筑ID不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                //直接使用ID作为文件夹名字
                string relativeFolderPath = $" {userInput}";
                // 获取当前工作目录
                string currentDirectory = Directory.GetCurrentDirectory();
                // 拼接相对路径和当前工作目录，得到完整路径
                string folderPath = Path.Combine(currentDirectory, relativeFolderPath);
                FilePathManager.FolderPath_Get = folderPath;
                // 创建文件夹
                Directory.CreateDirectory(folderPath);
                Logger.Log("文件夹成功创建");

                //在程序运行目录创建cs文件
                string exportFilePath = $"{folderPath}\\{userInput}.cs";
                // 将模板导出到文件
                using (StreamWriter writer = new StreamWriter(exportFilePath))
                {
                    string Btemplate = BasicTemplate.Obtain_Template(userInput, widthInput, heightInput, animInput, hitpointsInput, construction_timeInput, construction_massInput, construction_materialsInput, melting_pointInput, build_location_ruleInput, tier2_amountInput, tier2_radiusInput, muban);
                    writer.Write(Btemplate);
                }
                //在程序运行目录创建csproj文件
                string exportFilePath2 = $"{folderPath}\\{userInput}.csproj";
                using (StreamWriter writer = new StreamWriter(exportFilePath2))
                {
                    writer.Write(BasicTemplate.Obtain_DLL);
                }
                Console.WriteLine("模板文件已经成功生成");
                MessageBox.Show("模板生成成功！");
                //点击“生成”按钮时，调用它
                cB_yaml文件_CheckedChanged(sender, e);
                
            }
        }

        private void cB_yaml文件_CheckedChanged(object sender, EventArgs e)
        {
            bool yamlOut = cB_yaml文件.Checked;
            //获得点击“生成”按钮时的bool值
            bool isButtonClicked = Button_Clicked; 

            if (yamlOut)
            {
                Logger.Log("已勾选“生成基本yaml文件”选项");
            }
            else
            {
                Logger.Log("取消勾选“生成基本yaml文件”选项");
            }

            if (yamlOut && isButtonClicked)
            {
                //在程序运行目录新建文件夹
                string currentDirectory = Directory.GetCurrentDirectory();
                string folderPath = Path.Combine(currentDirectory, "yourMod");
                Directory.CreateDirectory(folderPath);
                //新建文件并把模板填充到mod文件内
                string exportFilePath_modyml = Path.Combine(folderPath, "mod.yaml");
                using (StreamWriter writer = new StreamWriter(exportFilePath_modyml))
                {
                    writer.Write(BasicTemplate.Obtain_modyml);
                }
                Console.WriteLine("modyml模板文件已经成功生成");
                Logger.Log("mod.yaml文件生成成功");
                //新建文件并把模板填充到mod_info文件内
                string exportFilePath_mod_infoyml = Path.Combine(folderPath, "mod_info.yaml");
                using (StreamWriter writer = new StreamWriter(exportFilePath_mod_infoyml))
                {
                    writer.Write(BasicTemplate.Obtain_mod_infoyml);
                }
                Console.WriteLine("Obtain_mod_infoyml模板文件已经成功生成");
                Logger.Log("mod_info.yaml文件生成成功");
            }
            else if (yamlOut && !isButtonClicked)
            {
                Logger.Log("未执行生成操作，因为“生成”未被点击");
            }
            else if (!yamlOut && isButtonClicked)
            {
                Logger.Log("未生yaml文件，因为取消了勾选");
            }
        }

        //退出按键
        private void tsm_退出_Click_1(object sender, EventArgs e)
        {
            Close();
            Logger.Log("点击了“退出”，程序结束运行");
        }

        private void bT_高级_Click(object sender, EventArgs e)
        {

        }
    }
}