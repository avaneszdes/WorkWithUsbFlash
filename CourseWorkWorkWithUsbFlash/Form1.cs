using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace CourseWorkWorkWithUsbFlash
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr SecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        [DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true, CharSet = CharSet.Auto)]
        private static extern bool DeviceIoControl(IntPtr hDevice, uint dwIoControlCode, IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, IntPtr lpOverlapped);

        [DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true, CharSet = CharSet.Auto)]
        private static extern bool DeviceIoControl(IntPtr hDevice, uint dwIoControlCode, byte[] lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, IntPtr lpOverlapped);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr hObject);

        private IntPtr handle = IntPtr.Zero;

        const uint GENERIC_READ = 0x80000000;
        const uint GENERIC_WRITE = 0x40000000;
        const int FILE_SHARE_READ = 0x1;
        const int FILE_SHARE_WRITE = 0x2;
        const int FSCTL_LOCK_VOLUME = 0x00090018;
        const int FSCTL_DISMOUNT_VOLUME = 0x00090020;
        const int IOCTL_STORAGE_EJECT_MEDIA = 0x2D4808;
        const int IOCTL_STORAGE_MEDIA_REMOVAL = 0x002D4804;
        private string s;
        private StreamReader stream;
        int index = 0;
        private Point _mouseOffset;
        private bool _isMouseDown = false;
        List<string> listOFExpansions = new List<string> { ".jpg", ".txt", ".mp3", ".docx", "doc" };


        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.FromArgb(44, 62, 66);
            button6.BackColor = Color.FromArgb(57, 81, 87);
            deleteFile.BackColor = Color.FromArgb(57, 81, 87);
            writeToFile.BackColor = Color.FromArgb(57, 81, 87);
            readFromFile.BackColor = Color.FromArgb(57, 81, 87);
            formatButton.BackColor = Color.FromArgb(57, 81, 87);
            deleteFile.BackColor = Color.FromArgb(57, 81, 87);
            copyFile.BackColor = Color.FromArgb(57, 81, 87);
            usbPropertiesButton.BackColor = Color.FromArgb(57, 81, 87);
            button8.BackColor = Color.FromArgb(44, 62, 66);
            button9.BackColor = Color.FromArgb(44, 62, 66);
            panel1.BackColor = Color.FromArgb(44, 62, 66);
            label1.BackColor = Color.FromArgb(44, 62, 66);
            label3.BackColor = Color.FromArgb(44, 62, 66);

        }

        private void UsbPropertiesButton_Click(object sender, EventArgs e)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable && drive.IsReady == true)
                {
                    resultTextBox.Paste($" Название: {drive.Name}\r\n Размер:\t{drive.TotalSize.ToString().Substring(0, 3).Insert(1, ",")} Gb\r\n" +
                        $" Доступное свободное пространство:\t{drive.AvailableFreeSpace.ToString().Substring(0, 5).Insert(1, ",") } Gb\r\n" +
                        $" Общее свободное пространство:\t{ drive.TotalFreeSpace.ToString().Substring(0, 5).Insert(1, ",")} Gb \r\n Формат диска:\t{drive.DriveFormat}\r\n");
                }
            }
        }

        private void FormatUsbFlash_Click(object sender, EventArgs e)
        {
            if (comboBoxOfUsbFlashes.SelectedItem == null)
            {
                MessageBox.Show("Выберите Usb Flash");
                return;
            }

            Process.Start("FORMAT", comboBoxOfUsbFlashes.SelectedItem.ToString()[0] + ":/FS:NTFS");
        }
        private void WriteInFileButton_Click(object sender, EventArgs e)
        {
            if (IsDataCorrect())
            {
                using (StreamWriter sw = new StreamWriter(@comboBoxOfUsbFlashes.SelectedItem + fileNameTextBox.Text + ".txt", true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(resultTextBox.Text);
                }

                MessageBox.Show("Запись прошла успешно!");
                resultTextBox.Text = string.Empty;
            }
        }

        private void ReadFromFileButton_Click(object sender, EventArgs e)
        {
           
            if (IsDataCorrect())
            {
                resultTextBox.Clear();
                try
                {
                    foreach (var expansion in listOFExpansions)
                    {
                        if (File.Exists(@comboBoxOfUsbFlashes.SelectedItem + fileNameTextBox.Text + expansion))
                        {
                            stream = new StreamReader($"{comboBoxOfUsbFlashes.SelectedItem}{fileNameTextBox.Text}{expansion}");
                            string line;
                            while ((line = stream.ReadLine()) != null)
                            {
                                resultTextBox.Paste(stream.ReadLine());
                            }
                            stream.Dispose();
                            break;
                        }
                        resultTextBox.Text = "Файл с таким именем не найден";
                    }
                }
                catch (Exception)
                {
                    resultTextBox.Text = "Файл с таким именем не найден";
                }

            }
        }

        private void DeleteFileButton_Click(object sender, EventArgs e)
        {

            if (IsDataCorrect())
            {
                foreach (var expansion in listOFExpansions)
                {

                    if (File.Exists(@comboBoxOfUsbFlashes.SelectedItem + fileNameTextBox.Text + expansion))
                    {
                        File.Delete($"{comboBoxOfUsbFlashes.SelectedItem}{fileNameTextBox.Text + expansion}");
                        MessageBox.Show($"Файл {fileNameTextBox.Text} удален!");
                        break;
                    }
                    else if (File.Exists(@comboBoxOfUsbFlashes.SelectedItem + fileNameTextBox.Text))
                    {
                        File.Delete($"{comboBoxOfUsbFlashes.SelectedItem}{fileNameTextBox.Text}");
                        MessageBox.Show($"Файл {fileNameTextBox.Text} удален!");
                        break;
                    }
                    else if (index == 5)
                    {
                        MessageBox.Show($"Файл {fileNameTextBox.Text} не найден");
                        break;
                    }
                    index++;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DropDown_Click(object sender, EventArgs e)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable && drive.IsReady == true)
                {
                    if (!comboBoxOfUsbFlashes.Items.Contains(drive.Name))
                    {
                        comboBoxOfUsbFlashes.Items.Add(drive.Name);
                    }

                }
            }
        }

        public IntPtr USBEject(string driveLetter)
        {
            string filename = @"\\.\" + driveLetter[0] + ":";
            return CreateFile(filename, GENERIC_READ | GENERIC_WRITE, FILE_SHARE_READ | FILE_SHARE_WRITE, IntPtr.Zero, 0x3, 0, IntPtr.Zero);
        }

        public bool Eject(IntPtr handle)
        {
            bool result = false;

            if (LockVolume(handle) && DismountVolume(handle))
            {
                PreventRemovalOfVolume(handle, false);
                result = AutoEjectVolume(handle);
            }
            CloseHandle(handle);
            return result;
        }

        private bool LockVolume(IntPtr handle)
        {
            uint byteReturned;

            for (int i = 0; i < 10; i++)
            {
                if (DeviceIoControl(handle, FSCTL_LOCK_VOLUME, IntPtr.Zero, 0, IntPtr.Zero, 0, out byteReturned, IntPtr.Zero))
                {
                    MessageBox.Show("USB извлечно успешно!");
                    return true;
                }
                Thread.Sleep(500);
            }
            return false;
        }

        private bool PreventRemovalOfVolume(IntPtr handle, bool prevent)
        {
            byte[] buf = new byte[1];
            uint retVal;

            buf[0] = (prevent) ? (byte)1 : (byte)0;
            return DeviceIoControl(handle, IOCTL_STORAGE_MEDIA_REMOVAL, buf, 1, IntPtr.Zero, 0, out retVal, IntPtr.Zero);
        }

        private bool DismountVolume(IntPtr handle)
        {
            uint byteReturned;
            return DeviceIoControl(handle, FSCTL_DISMOUNT_VOLUME, IntPtr.Zero, 0, IntPtr.Zero, 0, out byteReturned, IntPtr.Zero);
        }

        private bool AutoEjectVolume(IntPtr handle)
        {
            uint byteReturned;
            return DeviceIoControl(handle, IOCTL_STORAGE_EJECT_MEDIA, IntPtr.Zero, 0, IntPtr.Zero, 0, out byteReturned, IntPtr.Zero);
        }

        private bool CloseVolume(IntPtr handle)
        {
            return CloseHandle(handle);
        }

        private void EjectUsbButton_Click(object sender, EventArgs e)
        {

            if (comboBoxOfUsbFlashes.SelectedItem == null)
            {
                MessageBox.Show("Выберите Usb Flash");
                return;
            }

            Eject(USBEject(comboBoxOfUsbFlashes.SelectedItem.ToString()[0] + ":"));

        }

        private void CopyFileButton_Click(object sender, EventArgs e)
        {
            if (IsDataCorrect())
            {
                try
                {
                    folderBrowserDialog1 = new FolderBrowserDialog();
                    folderBrowserDialog1.ShowDialog();
                    foreach (var expansion in listOFExpansions)
                    {
                        if (File.Exists(@comboBoxOfUsbFlashes.SelectedItem + fileNameTextBox.Text + expansion))
                        {
                            File.Copy(Path.Combine(@comboBoxOfUsbFlashes.SelectedItem.ToString(), fileNameTextBox.Text + expansion), Path.Combine(folderBrowserDialog1.SelectedPath, fileNameTextBox.Text + expansion));
                        }
                    }

                }
                catch (IOException copyError)
                {
                    MessageBox.Show(copyError.Message);
                }
            }

        }

        private bool IsDataCorrect()
        {
            if (string.IsNullOrWhiteSpace(fileNameTextBox.Text))
            {
                MessageBox.Show("Введите название файла");
                return false;
            }

            if (comboBoxOfUsbFlashes.SelectedItem == null)
            {
                MessageBox.Show("Выберите Usb Flash");
                return false;
            }

            return true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                          SystemInformation.FrameBorderSize.Height;
                _mouseOffset = new Point(xOffset, yOffset);
                _isMouseDown = true;
            }
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (_isMouseDown)
            {
                Point mousePos = MousePosition;
                mousePos.Offset(_mouseOffset.X, _mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isMouseDown = false;
            }
        }
    }
}
