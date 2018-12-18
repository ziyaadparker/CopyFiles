using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CopyFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        public void Copy()
        {
            string fileName = "test.txt";
            string fileName2 = "test2.txt";
            string sourcePath = @"C:\Users\Ziyaad\Documents\Visual Studio 2012\Projects\CopyFiles\CopyFiles\bin\Debug\Test1";
            string targetPath = @"C:\Users\Ziyaad\Documents\Visual Studio 2012\Projects\CopyFiles\CopyFiles\bin\Debug\Test2";

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string targetFile = System.IO.Path.Combine(targetPath, fileName2);

            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            System.IO.File.Copy(sourceFile, targetFile);

        }

        void CopyDirectory(string sourceDir, string targetDir)
        {
            System.IO.Directory.CreateDirectory(targetDir);

            foreach (var file in System.IO.Directory.GetFiles(sourceDir))
                System.IO.File.Copy(file, System.IO.Path.Combine(targetDir, System.IO.Path.GetFileName(file)));

            foreach (var directory in System.IO.Directory.GetDirectories(sourceDir))
                System.IO.File.Copy(directory, System.IO.Path.Combine(targetDir, System.IO.Path.GetFileName(directory)));
        }
    }
}
