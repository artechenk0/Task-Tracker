using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using System.Xml;
using System.Drawing;
using System.Data;


namespace Tracker2000
{
    public partial class Main : Form
    {
        private const string path = "C:\\TaskTracker\\Tasks.xml";
        private const string pathDirectory = "C:\\TaskTracker";
        UserInterface ucLast;

        static public UserInterface[] ucSave = new UserInterface[4];

        private Button currentButton;
        Random rand = new Random();
        private int TempIndex;
        private Color SelectProgramm()
        {
            int index = rand.Next(ColorProgramm.ColorList.Count);
            while (TempIndex == index)
            {
                index = rand.Next(ColorProgramm.ColorList.Count);
            }
            TempIndex = index;
            string color = ColorProgramm.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        public Main()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
                ucSave[i] = new UserInterface();
            ucLast = new UserInterface();
            CheckXML(ucSave);
        }
        
        private void ActivateButton(object btnsender)
        {
            DisableButton();
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    Color color = SelectProgramm();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                    panelTitle.BackColor = color;
                    InfoPanel.BackColor = ColorProgramm.ChangeColorBrig(color, -0,3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previusbtn in MenuPanel.Controls)
            {
                if (previusbtn.GetType() == typeof(Button))
                {
                    previusbtn.BackColor = Color.FromArgb(51, 51, 76);
                    previusbtn.ForeColor = Color.Gainsboro;
                    previusbtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }
        private void UcInterface(UserInterface a)
        {
            a.Parent = DataPanel;
            a.Show();
            if (ucLast != a)
                ucLast.Hide();
            ucLast = a;
        }

        private void ButtonYesterday(object sender, EventArgs e)
        {
            ActivateButton(sender);
            UcInterface(ucSave[0]);
        }
       
            
        private void ButtonWeek(object sender, EventArgs e)
        { 
            ActivateButton(sender);
            UcInterface(ucSave[1]);
        }
        private void ButtonMounth(object sender, EventArgs e)
        {
            ActivateButton(sender);
            UcInterface(ucSave[2]);
        }
        private void ButtonImportant(object sender, EventArgs e)
        {
            ActivateButton(sender);
            UcInterface(ucSave[3]);
        }
        
        private void CheckXML(UserInterface[] userInterface)
        {
            if (!File.Exists(path))
                return;

            string[] elem = new string[4];
            object[] elemToArray = new object[4];

            XmlDocument xml = new XmlDocument();
            xml.Load(path);

            XmlElement xRoot = xml.DocumentElement;

            for (int i = 0; i < 4; i++)
            {
                elem[i] = xRoot.ChildNodes.Item(i).InnerText;
                elemToArray[i] = elem[i].Split(new string[] { "***" }, StringSplitOptions.None);
            }

            for (int i = 0; i < 4; i++)
            {
                foreach (var item in (string[])elemToArray[i])
                {
                    userInterface[i].TaskOutput.Items.Add(item);
                }
            }           
        }
        private void ConvertXML()
        {
            if (!Directory.Exists(pathDirectory))
                Directory.CreateDirectory(pathDirectory);

            if (File.Exists(path))
                File.Delete(path);

            

            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), new XElement("Tasks"));

            foreach (var item in ucSave)
               xml.Root.Add(new XElement("Task", string.Join("***", item.TaskOutput.Items.Cast<string>())));
                
            xml.Save(path);
        }
        private void Exitbutton(object sender, EventArgs e)
        {
            ConvertXML();
            Close();
        }
    }
}

