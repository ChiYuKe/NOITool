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
        {   //�����������Ĭ��ֵ
            cB1_��������.SelectedIndex = 0;
            cB3_��������.SelectedIndex = 4;
            cB2_����λ�ù���.SelectedIndex = 1;
        }
        public static class FilePathManager
        {
            public static string? FolderPath_Get { get; set; }
        }

        private void ����_Click(object sender, EventArgs e)
        {
            Button_Clicked = true;
            // ��ȡ TextBox �е��ı�ֵ
            string userInput = tB1_����ID.Text;
            string widthInput = tB2_�������.Text;
            string heightInput = tB3_�����߶�.Text;
            string animInput = tB4_��ͼ����.Text;
            string hitpointsInput = tB5_����Ѫ��.Text;
            string construction_timeInput = tB6_����ʱ��.Text;
            string construction_massInput = cB3_��������.Text;
            string construction_materialsInput = cB1_��������.Text;
            string melting_pointInput = tB8_�����۵�.Text;
            string build_location_ruleInput = cB2_����λ�ù���.Text;
            string tier2_amountInput = nB_װ�ζ�.Text;
            string tier2_radiusInput = nB_װ�ΰ뾶.Text;
            string muban = rB_ģ��.Text;
           


            if (string.IsNullOrEmpty(userInput))
            {
                // userInputΪ�գ����������
                Logger.Log("�����IDΪ�գ��������洰��");
                MessageBox.Show("����ID����Ϊ�գ�", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                //ֱ��ʹ��ID��Ϊ�ļ�������
                string relativeFolderPath = $" {userInput}";
                // ��ȡ��ǰ����Ŀ¼
                string currentDirectory = Directory.GetCurrentDirectory();
                // ƴ�����·���͵�ǰ����Ŀ¼���õ�����·��
                string folderPath = Path.Combine(currentDirectory, relativeFolderPath);
                FilePathManager.FolderPath_Get = folderPath;
                // �����ļ���
                Directory.CreateDirectory(folderPath);
                Logger.Log("�ļ��гɹ�����");

                //�ڳ�������Ŀ¼����cs�ļ�
                string exportFilePath = $"{folderPath}\\{userInput}.cs";
                // ��ģ�嵼�����ļ�
                using (StreamWriter writer = new StreamWriter(exportFilePath))
                {
                    string Btemplate = BasicTemplate.Obtain_Template(userInput, widthInput, heightInput, animInput, hitpointsInput, construction_timeInput, construction_massInput, construction_materialsInput, melting_pointInput, build_location_ruleInput, tier2_amountInput, tier2_radiusInput, muban);
                    writer.Write(Btemplate);
                }
                //�ڳ�������Ŀ¼����csproj�ļ�
                string exportFilePath2 = $"{folderPath}\\{userInput}.csproj";
                using (StreamWriter writer = new StreamWriter(exportFilePath2))
                {
                    writer.Write(BasicTemplate.Obtain_DLL);
                }
                Console.WriteLine("ģ���ļ��Ѿ��ɹ�����");
                MessageBox.Show("ģ�����ɳɹ���");
                //��������ɡ���ťʱ��������
                cB_yaml�ļ�_CheckedChanged(sender, e);
                
            }
        }

        private void cB_yaml�ļ�_CheckedChanged(object sender, EventArgs e)
        {
            bool yamlOut = cB_yaml�ļ�.Checked;
            //��õ�������ɡ���ťʱ��boolֵ
            bool isButtonClicked = Button_Clicked; 

            if (yamlOut)
            {
                Logger.Log("�ѹ�ѡ�����ɻ���yaml�ļ���ѡ��");
            }
            else
            {
                Logger.Log("ȡ����ѡ�����ɻ���yaml�ļ���ѡ��");
            }

            if (yamlOut && isButtonClicked)
            {
                //�ڳ�������Ŀ¼�½��ļ���
                string currentDirectory = Directory.GetCurrentDirectory();
                string folderPath = Path.Combine(currentDirectory, "yourMod");
                Directory.CreateDirectory(folderPath);
                //�½��ļ�����ģ����䵽mod�ļ���
                string exportFilePath_modyml = Path.Combine(folderPath, "mod.yaml");
                using (StreamWriter writer = new StreamWriter(exportFilePath_modyml))
                {
                    writer.Write(BasicTemplate.Obtain_modyml);
                }
                Console.WriteLine("modymlģ���ļ��Ѿ��ɹ�����");
                Logger.Log("mod.yaml�ļ����ɳɹ�");
                //�½��ļ�����ģ����䵽mod_info�ļ���
                string exportFilePath_mod_infoyml = Path.Combine(folderPath, "mod_info.yaml");
                using (StreamWriter writer = new StreamWriter(exportFilePath_mod_infoyml))
                {
                    writer.Write(BasicTemplate.Obtain_mod_infoyml);
                }
                Console.WriteLine("Obtain_mod_infoymlģ���ļ��Ѿ��ɹ�����");
                Logger.Log("mod_info.yaml�ļ����ɳɹ�");
            }
            else if (yamlOut && !isButtonClicked)
            {
                Logger.Log("δִ�����ɲ�������Ϊ�����ɡ�δ�����");
            }
            else if (!yamlOut && isButtonClicked)
            {
                Logger.Log("δ��yaml�ļ�����Ϊȡ���˹�ѡ");
            }
        }

        //�˳�����
        private void tsm_�˳�_Click_1(object sender, EventArgs e)
        {
            Close();
            Logger.Log("����ˡ��˳����������������");
        }

        private void bT_�߼�_Click(object sender, EventArgs e)
        {

        }
    }
}