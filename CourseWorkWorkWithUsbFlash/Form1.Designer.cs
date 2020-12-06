
namespace CourseWorkWorkWithUsbFlash
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
            this.usbPropertiesButton = new System.Windows.Forms.Button();
            this.comboBoxOfUsbFlashes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.readFromFile = new System.Windows.Forms.Button();
            this.writeToFile = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteFile = new System.Windows.Forms.Button();
            this.copyFile = new System.Windows.Forms.Button();
            this.formatButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usbPropertiesButton
            // 
            this.usbPropertiesButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.usbPropertiesButton.FlatAppearance.BorderSize = 0;
            this.usbPropertiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usbPropertiesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usbPropertiesButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usbPropertiesButton.Location = new System.Drawing.Point(10, 456);
            this.usbPropertiesButton.Name = "usbPropertiesButton";
            this.usbPropertiesButton.Size = new System.Drawing.Size(417, 54);
            this.usbPropertiesButton.TabIndex = 27;
            this.usbPropertiesButton.Text = "Свойства USB";
            this.usbPropertiesButton.UseVisualStyleBackColor = false;
            this.usbPropertiesButton.Click += new System.EventHandler(this.UsbPropertiesButton_Click);
            // 
            // comboBoxOfUsbFlashes
            // 
            this.comboBoxOfUsbFlashes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxOfUsbFlashes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxOfUsbFlashes.FormattingEnabled = true;
            this.comboBoxOfUsbFlashes.Location = new System.Drawing.Point(10, 31);
            this.comboBoxOfUsbFlashes.Name = "comboBoxOfUsbFlashes";
            this.comboBoxOfUsbFlashes.Size = new System.Drawing.Size(105, 21);
            this.comboBoxOfUsbFlashes.TabIndex = 26;
            this.comboBoxOfUsbFlashes.DropDown += new System.EventHandler(this.DropDown_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(196, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Имя файла";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fileNameTextBox.Location = new System.Drawing.Point(121, 31);
            this.fileNameTextBox.Multiline = true;
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(224, 21);
            this.fileNameTextBox.TabIndex = 24;
            // 
            // readFromFile
            // 
            this.readFromFile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.readFromFile.FlatAppearance.BorderSize = 0;
            this.readFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.readFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.readFromFile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.readFromFile.Location = new System.Drawing.Point(292, 516);
            this.readFromFile.Name = "readFromFile";
            this.readFromFile.Size = new System.Drawing.Size(135, 54);
            this.readFromFile.TabIndex = 22;
            this.readFromFile.Text = "Чтение из файла";
            this.readFromFile.UseVisualStyleBackColor = false;
            this.readFromFile.Click += new System.EventHandler(this.ReadFromFileButton_Click);
            // 
            // writeToFile
            // 
            this.writeToFile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.writeToFile.FlatAppearance.BorderSize = 0;
            this.writeToFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.writeToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.writeToFile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.writeToFile.Location = new System.Drawing.Point(10, 516);
            this.writeToFile.Name = "writeToFile";
            this.writeToFile.Size = new System.Drawing.Size(135, 54);
            this.writeToFile.TabIndex = 21;
            this.writeToFile.Text = "Запись в файл";
            this.writeToFile.UseVisualStyleBackColor = false;
            this.writeToFile.Click += new System.EventHandler(this.WriteInFileButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.Location = new System.Drawing.Point(10, 58);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(417, 392);
            this.resultTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Накопители";
            // 
            // deleteFile
            // 
            this.deleteFile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.deleteFile.FlatAppearance.BorderSize = 0;
            this.deleteFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteFile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteFile.Location = new System.Drawing.Point(151, 516);
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(135, 54);
            this.deleteFile.TabIndex = 17;
            this.deleteFile.Text = "Удалить файл";
            this.deleteFile.UseVisualStyleBackColor = false;
            this.deleteFile.Click += new System.EventHandler(this.DeleteFileButton_Click);
            // 
            // copyFile
            // 
            this.copyFile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.copyFile.FlatAppearance.BorderSize = 0;
            this.copyFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.copyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.copyFile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.copyFile.Location = new System.Drawing.Point(151, 576);
            this.copyFile.Name = "copyFile";
            this.copyFile.Size = new System.Drawing.Size(135, 54);
            this.copyFile.TabIndex = 16;
            this.copyFile.Text = "Копирование\r\nфайла";
            this.copyFile.UseVisualStyleBackColor = false;
            this.copyFile.Click += new System.EventHandler(this.CopyFileButton_Click);
            // 
            // formatButton
            // 
            this.formatButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.formatButton.FlatAppearance.BorderSize = 0;
            this.formatButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.formatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.formatButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.formatButton.Location = new System.Drawing.Point(10, 576);
            this.formatButton.Name = "formatButton";
            this.formatButton.Size = new System.Drawing.Size(135, 54);
            this.formatButton.TabIndex = 15;
            this.formatButton.Text = "Форматирование";
            this.formatButton.UseVisualStyleBackColor = false;
            this.formatButton.Click += new System.EventHandler(this.FormatUsbFlash_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(292, 576);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 54);
            this.button6.TabIndex = 28;
            this.button6.Text = "Безопасное\r\nизвлечение";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.EjectUsbButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Location = new System.Drawing.Point(365, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 30);
            this.panel1.TabIndex = 29;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(47, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(25, 25);
            this.button8.TabIndex = 10;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(34, 32);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(437, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.usbPropertiesButton);
            this.Controls.Add(this.comboBoxOfUsbFlashes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.readFromFile);
            this.Controls.Add(this.writeToFile);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteFile);
            this.Controls.Add(this.copyFile);
            this.Controls.Add(this.formatButton);
            this.Name = "Form1";
            this.Text = "Work with Usb Flash";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp_1);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button usbPropertiesButton;
        private System.Windows.Forms.ComboBox comboBoxOfUsbFlashes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button readFromFile;
        private System.Windows.Forms.Button writeToFile;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteFile;
        private System.Windows.Forms.Button copyFile;
        private System.Windows.Forms.Button formatButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

