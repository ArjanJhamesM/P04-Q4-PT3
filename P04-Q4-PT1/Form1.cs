using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using P04_Q4_PT3;
using static System.Math;


namespace P04_Q4_PT3
{
    public partial class Form1 : Form
    {
        private Image Background_Image;
        
        private int Previous_Height;

        public Form1()
        {
            InitializeComponent();

            // Code for background image
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            Background_Image = Image.FromFile("CIIT - Weave Pattern-05.png");

            this.DoubleBuffered = true;
            this.ResizeRedraw = true;

            Previous_Height = this.Height;

            this.Resize += Form1_Resize;
            ScalePhotoSize();

            CallAllScaleFontSizeMethods();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CheckFormSizeForScaling();
        }

        private void ScalePhotoSize()
        {
            int Current_Photo_Width = Student_Photo_Section.Size.Width;
            int Mininum_Photo_Width = 150;
            int Maximum_Photo_Width = 300;


            if (this.ClientSize.Height >= 900)
            {
                Current_Photo_Width = (int)Math.Round((float)this.ClientSize.Height / 3.38);
            }
            else
            {
                Current_Photo_Width = (int)Math.Round((float)this.ClientSize.Height / 5);
            }

            Current_Photo_Width = Math.Max(Mininum_Photo_Width, Math.Min(Maximum_Photo_Width, Current_Photo_Width));

            Student_Photo_Section.Size = new Size(Current_Photo_Width, Current_Photo_Width);
        }

        private void CheckFormSizeForScaling()
        {
            if (this.Height > Previous_Height)
            {
                CallAllScaleFontSizeMethods();
                ScalePhotoSize();
            }
            else
            {
                CallAllScaleFontSizeMethods();
                ScalePhotoSize();
            }
        }

        private void ScaleFontSize(string Kind_Of_Text, Label Information_Label)
        {
            float Current_Font_Size = Information_Label.Font.Size;
            float Minimum_Font_Size = 0;
            float Maximum_Font_Size = 0;

            switch (Kind_Of_Text)
            {
                case "Label":
                    Minimum_Font_Size = 10.0F;
                    Maximum_Font_Size = 12.0F;

                    Current_Font_Size = (float)Math.Round((float)this.ClientSize.Height / 72);

                    break;

                case "Output":
                    Minimum_Font_Size = 15.0F;
                    Maximum_Font_Size = 22.0F;

                    Current_Font_Size = (float)Math.Round((float)this.ClientSize.Height / 48);

                    break;

                case "Smaller_Output":
                    Minimum_Font_Size = 12.0F;
                    Maximum_Font_Size = 14.0F;

                    Current_Font_Size = (float)Math.Round((float)this.ClientSize.Height / 64.9);

                    break;
            }

            Current_Font_Size = Math.Max(Minimum_Font_Size, Math.Min(Maximum_Font_Size, Current_Font_Size));

            Information_Label.Font = new Font(Information_Label.Font.Name, Current_Font_Size, Information_Label.Font.Style);
        }

        private void CallAllScaleFontSizeMethods()
        {
            ScaleFontSize("Label", Name_Label);
            ScaleFontSize("Output", Name_Output);

            ScaleFontSize("Label", Grade_And_Section_Label);
            ScaleFontSize("Smaller_Output", Grade_And_Section_Output);

            ScaleFontSize("Label", Age_Label);
            ScaleFontSize("Smaller_Output", Age_Output);

            ScaleFontSize("Label", Birthdate_Label);
            ScaleFontSize("Smaller_Output", Birthdate_Output);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Get the form's client area size
            var clientSize = this.ClientSize;

            // Calculate the scaling factor to ensure the image covers the whole form
            float ratioX = (float)clientSize.Width / Background_Image.Width;
            float ratioY = (float)clientSize.Height / Background_Image.Height;

            // We want to fill the entire form, so use the larger of the two scaling ratios
            float ratio = Math.Max(ratioX, ratioY);

            // Calculate the new width and height for the image
            int newWidth = (int)(Background_Image.Width * ratio);
            int newHeight = (int)(Background_Image.Height * ratio);

            // Calculate the position to center the image (optional, as the image might be clipped)
            int x = (clientSize.Width - newWidth) / 2;
            int y = (clientSize.Height - newHeight) / 2;

            e.Graphics.DrawImage(Background_Image, new Rectangle(x, y, newWidth, newHeight));
        }

        private void Student_Id_Submit_Button_Click(object sender, EventArgs e)
        {
            // Code for retrieving and displaying JSON values
            LoadJsonFiles Load_And_Save_Json_Files = new LoadJsonFiles();
            CurrentJsonVariables Current_Json_Variables = new CurrentJsonVariables();

            int Student_Id_Search_Input;

            try
            {
                Student_Id_Search_Input = Convert.ToInt32(Student_Id_Search_Textbox.Text);

                try
                {
                    Load_And_Save_Json_Files.LoadJsonFile(Current_Json_Variables, Student_Id_Search_Input);

                    Student_Photo_Section.Image = Image.FromFile(@"Student_Photos/Student_Photo_" + Student_Id_Search_Textbox.Text + ".png");

                    Name_Output.Text = Current_Json_Variables.Current_Name;
                    Student_Id_Number_Output.Text = Convert.ToString(Current_Json_Variables.Current_Student_Id);
                    Grade_And_Section_Output.Text = Convert.ToString(Current_Json_Variables.Current_Grade_Level) + " - " + Current_Json_Variables.Current_Section;
                    Age_Output.Text = Convert.ToString(Current_Json_Variables.Current_Age);
                    Birthdate_Output.Text = Current_Json_Variables.Current_Birthday_Month + " " + Convert.ToString(Current_Json_Variables.Current_Birthday_Day) + ", " + Convert.ToString(Current_Json_Variables.Current_Birthday_Year);
                }
                catch (FileNotFoundException)
                {
                    ShowMissingMessageBox();
                }
            }
            catch (FormatException)
            {
                ShowMissingMessageBox();
            }
        }

        private void ShowMissingMessageBox()
        {
            DialogResult Error_Message = MessageBox.Show("No student ID number found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    // Because transparency in table layout panel flickers the screen
    public class DoubleBufferedTableLayoutPanel : TableLayoutPanel
    {
        public DoubleBufferedTableLayoutPanel()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }
    }

    public class DoubleBufferedPictureBox : PictureBox
    {
        public DoubleBufferedPictureBox()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }
    }

    public class JsonVariables
    {
        public int Student_Id;
        public string Name;
        public int Grade_Level;
        public string Section;
        public int Age;
        public int Birthday_Day;
        public string Birthday_Month;
        public int Birthday_Year;
    }

    public class CurrentJsonVariables
    {
        public int Current_Student_Id;
        public string Current_Name;
        public int Current_Grade_Level;
        public string Current_Section;
        public int Current_Age;
        public int Current_Birthday_Day;
        public string Current_Birthday_Month;
        public int Current_Birthday_Year;
    }

    public class LoadJsonFiles
    {
        public void LoadJsonFile(CurrentJsonVariables Current_Json_Variables, int Student_Id_Search = 0)
        {
            JsonVariables Json_Variables = new JsonVariables(); 

            JsonVariables Json_File = JsonConvert.DeserializeObject<JsonVariables>(File.ReadAllText("Student_JSONs/Student_Data_" + Student_Id_Search + ".json"));

            Current_Json_Variables.Current_Student_Id = Json_File.Student_Id;
            Current_Json_Variables.Current_Name = Json_File.Name;
            Current_Json_Variables.Current_Age = Json_File.Age;
            Current_Json_Variables.Current_Grade_Level = Json_File.Grade_Level;
            Current_Json_Variables.Current_Section = Json_File.Section;
            Current_Json_Variables.Current_Birthday_Day = Json_File.Birthday_Day;
            Current_Json_Variables.Current_Birthday_Month = Json_File.Birthday_Month;
            Current_Json_Variables.Current_Birthday_Year = Json_File.Birthday_Year;
        }
    }
}