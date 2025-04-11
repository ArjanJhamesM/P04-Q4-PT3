namespace P04_Q4_PT3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Student_Info_UI = new P04_Q4_PT3.DoubleBufferedTableLayoutPanel();
            this.Information_Box = new System.Windows.Forms.Panel();
            this.Information_Box_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.Student_Id_Section = new System.Windows.Forms.FlowLayoutPanel();
            this.Student_Id_Search_Textbox_Label = new System.Windows.Forms.Label();
            this.Student_Id_Search_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.Student_Id_Submit_Button = new System.Windows.Forms.Button();
            this.Student_Id_Search_Textbox = new System.Windows.Forms.MaskedTextBox();
            this.App_Logo_And_Title_Section = new System.Windows.Forms.FlowLayoutPanel();
            this.App_Logo = new System.Windows.Forms.PictureBox();
            this.App_Title = new System.Windows.Forms.Label();
            this.Student_Photo_Section = new P04_Q4_PT3.DoubleBufferedPictureBox();
            this.Information_Section = new System.Windows.Forms.TableLayoutPanel();
            this.Name_Information = new System.Windows.Forms.FlowLayoutPanel();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Name_And_Student_Id_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.Name_Output = new System.Windows.Forms.Label();
            this.Student_Id_Number_Output = new System.Windows.Forms.Label();
            this.Age_Information = new System.Windows.Forms.FlowLayoutPanel();
            this.Age_Label = new System.Windows.Forms.Label();
            this.Age_Output = new System.Windows.Forms.Label();
            this.Birthdate_Information = new System.Windows.Forms.FlowLayoutPanel();
            this.Birthdate_Label = new System.Windows.Forms.Label();
            this.Birthdate_Output = new System.Windows.Forms.Label();
            this.Grade_And_Section_Information = new System.Windows.Forms.FlowLayoutPanel();
            this.Grade_And_Section_Label = new System.Windows.Forms.Label();
            this.Grade_And_Section_Output = new System.Windows.Forms.Label();
            this.Student_Info_UI.SuspendLayout();
            this.Information_Box.SuspendLayout();
            this.Information_Box_Layout.SuspendLayout();
            this.Student_Id_Section.SuspendLayout();
            this.Student_Id_Search_Layout.SuspendLayout();
            this.App_Logo_And_Title_Section.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.App_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Photo_Section)).BeginInit();
            this.Information_Section.SuspendLayout();
            this.Name_Information.SuspendLayout();
            this.Name_And_Student_Id_Layout.SuspendLayout();
            this.Age_Information.SuspendLayout();
            this.Birthdate_Information.SuspendLayout();
            this.Grade_And_Section_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // Student_Info_UI
            // 
            this.Student_Info_UI.BackColor = System.Drawing.Color.Transparent;
            this.Student_Info_UI.ColumnCount = 1;
            this.Student_Info_UI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Student_Info_UI.Controls.Add(this.Information_Box, 0, 0);
            this.Student_Info_UI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Student_Info_UI.Location = new System.Drawing.Point(0, 0);
            this.Student_Info_UI.Name = "Student_Info_UI";
            this.Student_Info_UI.RowCount = 1;
            this.Student_Info_UI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Student_Info_UI.Size = new System.Drawing.Size(1008, 681);
            this.Student_Info_UI.TabIndex = 0;
            // 
            // Information_Box
            // 
            this.Information_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Information_Box.BackColor = System.Drawing.Color.White;
            this.Information_Box.Controls.Add(this.Information_Box_Layout);
            this.Information_Box.Location = new System.Drawing.Point(154, 35);
            this.Information_Box.Margin = new System.Windows.Forms.Padding(35);
            this.Information_Box.MaximumSize = new System.Drawing.Size(700, 0);
            this.Information_Box.MinimumSize = new System.Drawing.Size(700, 0);
            this.Information_Box.Name = "Information_Box";
            this.Information_Box.Size = new System.Drawing.Size(700, 611);
            this.Information_Box.TabIndex = 0;
            // 
            // Information_Box_Layout
            // 
            this.Information_Box_Layout.ColumnCount = 1;
            this.Information_Box_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Information_Box_Layout.Controls.Add(this.Student_Id_Section, 0, 1);
            this.Information_Box_Layout.Controls.Add(this.App_Logo_And_Title_Section, 0, 0);
            this.Information_Box_Layout.Controls.Add(this.Student_Photo_Section, 0, 2);
            this.Information_Box_Layout.Controls.Add(this.Information_Section, 0, 3);
            this.Information_Box_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Information_Box_Layout.Location = new System.Drawing.Point(0, 0);
            this.Information_Box_Layout.Name = "Information_Box_Layout";
            this.Information_Box_Layout.RowCount = 4;
            this.Information_Box_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Information_Box_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Information_Box_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Information_Box_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Information_Box_Layout.Size = new System.Drawing.Size(700, 611);
            this.Information_Box_Layout.TabIndex = 0;
            // 
            // Student_Id_Section
            // 
            this.Student_Id_Section.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Student_Id_Section.AutoSize = true;
            this.Student_Id_Section.Controls.Add(this.Student_Id_Search_Textbox_Label);
            this.Student_Id_Section.Controls.Add(this.Student_Id_Search_Layout);
            this.Student_Id_Section.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Student_Id_Section.Location = new System.Drawing.Point(202, 119);
            this.Student_Id_Section.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.Student_Id_Section.Name = "Student_Id_Section";
            this.Student_Id_Section.Size = new System.Drawing.Size(296, 56);
            this.Student_Id_Section.TabIndex = 3;
            // 
            // Student_Id_Search_Textbox_Label
            // 
            this.Student_Id_Search_Textbox_Label.AutoSize = true;
            this.Student_Id_Search_Textbox_Label.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Id_Search_Textbox_Label.Location = new System.Drawing.Point(3, 0);
            this.Student_Id_Search_Textbox_Label.Name = "Student_Id_Search_Textbox_Label";
            this.Student_Id_Search_Textbox_Label.Size = new System.Drawing.Size(163, 18);
            this.Student_Id_Search_Textbox_Label.TabIndex = 3;
            this.Student_Id_Search_Textbox_Label.Text = "Enter Student ID Number";
            // 
            // Student_Id_Search_Layout
            // 
            this.Student_Id_Search_Layout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Student_Id_Search_Layout.AutoSize = true;
            this.Student_Id_Search_Layout.ColumnCount = 2;
            this.Student_Id_Search_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.Student_Id_Search_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.Student_Id_Search_Layout.Controls.Add(this.Student_Id_Submit_Button, 1, 0);
            this.Student_Id_Search_Layout.Controls.Add(this.Student_Id_Search_Textbox, 0, 0);
            this.Student_Id_Search_Layout.Location = new System.Drawing.Point(3, 21);
            this.Student_Id_Search_Layout.Name = "Student_Id_Search_Layout";
            this.Student_Id_Search_Layout.RowCount = 1;
            this.Student_Id_Search_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Student_Id_Search_Layout.Size = new System.Drawing.Size(290, 32);
            this.Student_Id_Search_Layout.TabIndex = 4;
            // 
            // Student_Id_Submit_Button
            // 
            this.Student_Id_Submit_Button.BackColor = System.Drawing.SystemColors.Menu;
            this.Student_Id_Submit_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Student_Id_Submit_Button.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Id_Submit_Button.Location = new System.Drawing.Point(206, 3);
            this.Student_Id_Submit_Button.Name = "Student_Id_Submit_Button";
            this.Student_Id_Submit_Button.Size = new System.Drawing.Size(81, 26);
            this.Student_Id_Submit_Button.TabIndex = 2;
            this.Student_Id_Submit_Button.Text = "Search";
            this.Student_Id_Submit_Button.UseVisualStyleBackColor = false;
            this.Student_Id_Submit_Button.Click += new System.EventHandler(this.Student_Id_Submit_Button_Click);
            // 
            // Student_Id_Search_Textbox
            // 
            this.Student_Id_Search_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.Student_Id_Search_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Student_Id_Search_Textbox.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Id_Search_Textbox.HidePromptOnLeave = true;
            this.Student_Id_Search_Textbox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.Student_Id_Search_Textbox.Location = new System.Drawing.Point(3, 3);
            this.Student_Id_Search_Textbox.Mask = "00000";
            this.Student_Id_Search_Textbox.Name = "Student_Id_Search_Textbox";
            this.Student_Id_Search_Textbox.PromptChar = ' ';
            this.Student_Id_Search_Textbox.Size = new System.Drawing.Size(197, 26);
            this.Student_Id_Search_Textbox.TabIndex = 3;
            this.Student_Id_Search_Textbox.ValidatingType = typeof(int);
            // 
            // App_Logo_And_Title_Section
            // 
            this.App_Logo_And_Title_Section.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.App_Logo_And_Title_Section.AutoSize = true;
            this.App_Logo_And_Title_Section.Controls.Add(this.App_Logo);
            this.App_Logo_And_Title_Section.Controls.Add(this.App_Title);
            this.App_Logo_And_Title_Section.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.App_Logo_And_Title_Section.Location = new System.Drawing.Point(240, 0);
            this.App_Logo_And_Title_Section.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.App_Logo_And_Title_Section.Name = "App_Logo_And_Title_Section";
            this.App_Logo_And_Title_Section.Size = new System.Drawing.Size(220, 99);
            this.App_Logo_And_Title_Section.TabIndex = 4;
            // 
            // App_Logo
            // 
            this.App_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.App_Logo.Image = global::P04_Q4_PT3.Properties.Resources.CIIT_SHS_logo_positive;
            this.App_Logo.Location = new System.Drawing.Point(13, 20);
            this.App_Logo.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.App_Logo.Name = "App_Logo";
            this.App_Logo.Size = new System.Drawing.Size(194, 38);
            this.App_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.App_Logo.TabIndex = 4;
            this.App_Logo.TabStop = false;
            // 
            // App_Title
            // 
            this.App_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.App_Title.AutoSize = true;
            this.App_Title.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(54)))), ((int)(((byte)(77)))));
            this.App_Title.Location = new System.Drawing.Point(5, 64);
            this.App_Title.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.App_Title.Name = "App_Title";
            this.App_Title.Size = new System.Drawing.Size(210, 30);
            this.App_Title.TabIndex = 5;
            this.App_Title.Text = "STUDENT INFO APP";
            // 
            // Student_Photo_Section
            // 
            this.Student_Photo_Section.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Student_Photo_Section.Location = new System.Drawing.Point(20, 200);
            this.Student_Photo_Section.Margin = new System.Windows.Forms.Padding(20, 20, 20, 15);
            this.Student_Photo_Section.MaximumSize = new System.Drawing.Size(0, 300);
            this.Student_Photo_Section.MinimumSize = new System.Drawing.Size(150, 150);
            this.Student_Photo_Section.Name = "Student_Photo_Section";
            this.Student_Photo_Section.Size = new System.Drawing.Size(660, 150);
            this.Student_Photo_Section.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Student_Photo_Section.TabIndex = 5;
            this.Student_Photo_Section.TabStop = false;
            // 
            // Information_Section
            // 
            this.Information_Section.AutoSize = true;
            this.Information_Section.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Information_Section.ColumnCount = 1;
            this.Information_Section.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Information_Section.Controls.Add(this.Name_Information, 0, 0);
            this.Information_Section.Controls.Add(this.Age_Information, 0, 2);
            this.Information_Section.Controls.Add(this.Birthdate_Information, 0, 3);
            this.Information_Section.Controls.Add(this.Grade_And_Section_Information, 0, 1);
            this.Information_Section.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Information_Section.Location = new System.Drawing.Point(12, 377);
            this.Information_Section.Margin = new System.Windows.Forms.Padding(12);
            this.Information_Section.Name = "Information_Section";
            this.Information_Section.RowCount = 4;
            this.Information_Section.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Information_Section.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Information_Section.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Information_Section.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Information_Section.Size = new System.Drawing.Size(676, 222);
            this.Information_Section.TabIndex = 6;
            // 
            // Name_Information
            // 
            this.Name_Information.AutoSize = true;
            this.Name_Information.Controls.Add(this.Name_Label);
            this.Name_Information.Controls.Add(this.Name_And_Student_Id_Layout);
            this.Name_Information.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Name_Information.Location = new System.Drawing.Point(3, 3);
            this.Name_Information.Name = "Name_Information";
            this.Name_Information.Size = new System.Drawing.Size(212, 51);
            this.Name_Information.TabIndex = 0;
            this.Name_Information.WrapContents = false;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.Name_Label.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.Location = new System.Drawing.Point(0, 0);
            this.Name_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(212, 20);
            this.Name_Label.TabIndex = 0;
            this.Name_Label.Text = "Name and Student ID Number";
            this.Name_Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Name_And_Student_Id_Layout
            // 
            this.Name_And_Student_Id_Layout.AutoSize = true;
            this.Name_And_Student_Id_Layout.Controls.Add(this.Name_Output);
            this.Name_And_Student_Id_Layout.Controls.Add(this.Student_Id_Number_Output);
            this.Name_And_Student_Id_Layout.Location = new System.Drawing.Point(0, 20);
            this.Name_And_Student_Id_Layout.Margin = new System.Windows.Forms.Padding(0);
            this.Name_And_Student_Id_Layout.Name = "Name_And_Student_Id_Layout";
            this.Name_And_Student_Id_Layout.Size = new System.Drawing.Size(82, 31);
            this.Name_And_Student_Id_Layout.TabIndex = 2;
            // 
            // Name_Output
            // 
            this.Name_Output.AutoSize = true;
            this.Name_Output.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Output.Location = new System.Drawing.Point(0, 0);
            this.Name_Output.Margin = new System.Windows.Forms.Padding(0);
            this.Name_Output.Name = "Name_Output";
            this.Name_Output.Size = new System.Drawing.Size(22, 31);
            this.Name_Output.TabIndex = 1;
            this.Name_Output.Text = "-";
            // 
            // Student_Id_Number_Output
            // 
            this.Student_Id_Number_Output.AutoSize = true;
            this.Student_Id_Number_Output.Dock = System.Windows.Forms.DockStyle.Left;
            this.Student_Id_Number_Output.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Id_Number_Output.Location = new System.Drawing.Point(22, 0);
            this.Student_Id_Number_Output.Margin = new System.Windows.Forms.Padding(0);
            this.Student_Id_Number_Output.Name = "Student_Id_Number_Output";
            this.Student_Id_Number_Output.Size = new System.Drawing.Size(60, 31);
            this.Student_Id_Number_Output.TabIndex = 3;
            this.Student_Id_Number_Output.Text = "00000";
            this.Student_Id_Number_Output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Age_Information
            // 
            this.Age_Information.AutoSize = true;
            this.Age_Information.Controls.Add(this.Age_Label);
            this.Age_Information.Controls.Add(this.Age_Output);
            this.Age_Information.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Age_Information.Location = new System.Drawing.Point(3, 111);
            this.Age_Information.Name = "Age_Information";
            this.Age_Information.Size = new System.Drawing.Size(35, 45);
            this.Age_Information.TabIndex = 2;
            this.Age_Information.WrapContents = false;
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.Age_Label.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_Label.Location = new System.Drawing.Point(0, 0);
            this.Age_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(35, 20);
            this.Age_Label.TabIndex = 0;
            this.Age_Label.Text = "Age";
            this.Age_Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Age_Output
            // 
            this.Age_Output.AutoSize = true;
            this.Age_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Age_Output.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_Output.Location = new System.Drawing.Point(0, 20);
            this.Age_Output.Margin = new System.Windows.Forms.Padding(0);
            this.Age_Output.Name = "Age_Output";
            this.Age_Output.Size = new System.Drawing.Size(35, 25);
            this.Age_Output.TabIndex = 1;
            this.Age_Output.Text = "-";
            // 
            // Birthdate_Information
            // 
            this.Birthdate_Information.AutoSize = true;
            this.Birthdate_Information.Controls.Add(this.Birthdate_Label);
            this.Birthdate_Information.Controls.Add(this.Birthdate_Output);
            this.Birthdate_Information.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Birthdate_Information.Location = new System.Drawing.Point(3, 162);
            this.Birthdate_Information.Name = "Birthdate_Information";
            this.Birthdate_Information.Size = new System.Drawing.Size(71, 45);
            this.Birthdate_Information.TabIndex = 3;
            this.Birthdate_Information.WrapContents = false;
            // 
            // Birthdate_Label
            // 
            this.Birthdate_Label.AutoSize = true;
            this.Birthdate_Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.Birthdate_Label.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthdate_Label.Location = new System.Drawing.Point(0, 0);
            this.Birthdate_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Birthdate_Label.Name = "Birthdate_Label";
            this.Birthdate_Label.Size = new System.Drawing.Size(71, 20);
            this.Birthdate_Label.TabIndex = 0;
            this.Birthdate_Label.Text = "Birthdate";
            this.Birthdate_Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Birthdate_Output
            // 
            this.Birthdate_Output.AutoSize = true;
            this.Birthdate_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Birthdate_Output.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthdate_Output.Location = new System.Drawing.Point(0, 20);
            this.Birthdate_Output.Margin = new System.Windows.Forms.Padding(0);
            this.Birthdate_Output.Name = "Birthdate_Output";
            this.Birthdate_Output.Size = new System.Drawing.Size(71, 25);
            this.Birthdate_Output.TabIndex = 1;
            this.Birthdate_Output.Text = "-";
            // 
            // Grade_And_Section_Information
            // 
            this.Grade_And_Section_Information.AutoSize = true;
            this.Grade_And_Section_Information.Controls.Add(this.Grade_And_Section_Label);
            this.Grade_And_Section_Information.Controls.Add(this.Grade_And_Section_Output);
            this.Grade_And_Section_Information.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Grade_And_Section_Information.Location = new System.Drawing.Point(3, 60);
            this.Grade_And_Section_Information.Name = "Grade_And_Section_Information";
            this.Grade_And_Section_Information.Size = new System.Drawing.Size(129, 45);
            this.Grade_And_Section_Information.TabIndex = 3;
            this.Grade_And_Section_Information.WrapContents = false;
            // 
            // Grade_And_Section_Label
            // 
            this.Grade_And_Section_Label.AutoSize = true;
            this.Grade_And_Section_Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.Grade_And_Section_Label.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grade_And_Section_Label.Location = new System.Drawing.Point(0, 0);
            this.Grade_And_Section_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Grade_And_Section_Label.Name = "Grade_And_Section_Label";
            this.Grade_And_Section_Label.Size = new System.Drawing.Size(129, 20);
            this.Grade_And_Section_Label.TabIndex = 0;
            this.Grade_And_Section_Label.Text = "Grade and Section";
            this.Grade_And_Section_Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Grade_And_Section_Output
            // 
            this.Grade_And_Section_Output.AutoSize = true;
            this.Grade_And_Section_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grade_And_Section_Output.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grade_And_Section_Output.Location = new System.Drawing.Point(0, 20);
            this.Grade_And_Section_Output.Margin = new System.Windows.Forms.Padding(0);
            this.Grade_And_Section_Output.Name = "Grade_And_Section_Output";
            this.Grade_And_Section_Output.Size = new System.Drawing.Size(129, 25);
            this.Grade_And_Section_Output.TabIndex = 1;
            this.Grade_And_Section_Output.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.Student_Info_UI);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "Form1";
            this.Text = "CIIT Student Info App";
            this.Student_Info_UI.ResumeLayout(false);
            this.Information_Box.ResumeLayout(false);
            this.Information_Box_Layout.ResumeLayout(false);
            this.Information_Box_Layout.PerformLayout();
            this.Student_Id_Section.ResumeLayout(false);
            this.Student_Id_Section.PerformLayout();
            this.Student_Id_Search_Layout.ResumeLayout(false);
            this.Student_Id_Search_Layout.PerformLayout();
            this.App_Logo_And_Title_Section.ResumeLayout(false);
            this.App_Logo_And_Title_Section.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.App_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Photo_Section)).EndInit();
            this.Information_Section.ResumeLayout(false);
            this.Information_Section.PerformLayout();
            this.Name_Information.ResumeLayout(false);
            this.Name_Information.PerformLayout();
            this.Name_And_Student_Id_Layout.ResumeLayout(false);
            this.Name_And_Student_Id_Layout.PerformLayout();
            this.Age_Information.ResumeLayout(false);
            this.Age_Information.PerformLayout();
            this.Birthdate_Information.ResumeLayout(false);
            this.Birthdate_Information.PerformLayout();
            this.Grade_And_Section_Information.ResumeLayout(false);
            this.Grade_And_Section_Information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private P04_Q4_PT3.DoubleBufferedTableLayoutPanel Student_Info_UI;
        private System.Windows.Forms.Panel Information_Box;
        private System.Windows.Forms.TableLayoutPanel Information_Box_Layout;
        private System.Windows.Forms.FlowLayoutPanel Student_Id_Section;
        private System.Windows.Forms.Label Student_Id_Search_Textbox_Label;
        private System.Windows.Forms.TableLayoutPanel Student_Id_Search_Layout;
        private System.Windows.Forms.Button Student_Id_Submit_Button;
        private System.Windows.Forms.MaskedTextBox Student_Id_Search_Textbox;
        private System.Windows.Forms.FlowLayoutPanel App_Logo_And_Title_Section;
        private System.Windows.Forms.PictureBox App_Logo;
        private System.Windows.Forms.Label App_Title;
        private DoubleBufferedPictureBox Student_Photo_Section;
        private System.Windows.Forms.TableLayoutPanel Information_Section;
        private System.Windows.Forms.FlowLayoutPanel Name_Information;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Name_Output;
        private System.Windows.Forms.FlowLayoutPanel Age_Information;
        private System.Windows.Forms.Label Age_Label;
        private System.Windows.Forms.Label Age_Output;
        private System.Windows.Forms.FlowLayoutPanel Birthdate_Information;
        private System.Windows.Forms.Label Birthdate_Label;
        private System.Windows.Forms.Label Birthdate_Output;
        private System.Windows.Forms.FlowLayoutPanel Grade_And_Section_Information;
        private System.Windows.Forms.Label Grade_And_Section_Label;
        private System.Windows.Forms.Label Grade_And_Section_Output;
        private System.Windows.Forms.FlowLayoutPanel Name_And_Student_Id_Layout;
        private System.Windows.Forms.Label Student_Id_Number_Output;
    }
}

