using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OccupationalAnnuityConvert
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string srcPath = @"G:\j\机构转换程序\职业年金投监系统数据传输（泰康系统）\1007";
            //string aimPath = @"G:\j\机构转换程序\职业年金投监系统数据传输（泰康系统）\1007\aim";
            //CopyDir(srcPath,aimPath);
          
            test();
        }

        private void test()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.AddRange(ofd.FileNames);
                string[] a = ofd.FileNames;
                if (a.Length!=0)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        File.Copy(a[i], @"G:\j\机构转换程序\职业年金投监系统数据传输（泰康系统）\1007"+"_"+i.ToString());
                    }
                }
            }
        }

        private void test2()
        {
            string path = @"d:\temp\MyTest.txt";
            string path2 = @"d:\temp\temp.txt";
            File.Copy(path, path2);//不允许bai覆du盖目的zhi地的同名文dao件
            File.Copy(path, path2, true);//允许覆盖目的地的同名文件
        }

        public void CopyDir(string srcPath, string aimPath)
        {
            try
            {
                //检查目标目录bai是否以目录分割字符
                //结束如du果不是则添加之
                if (aimPath[aimPath.Length - 1] != System.IO.Path.DirectorySeparatorChar)
                 aimPath += System.IO.Path.DirectorySeparatorChar;
                //判断目标目录是否存dao在如果不存在则新建之
                if (!Directory.Exists(aimPath))
                    Directory.CreateDirectory(aimPath);
                //得到源目录的文件列表,该里面是包含
                //文件以及目录路径的一个数组
                //如果你指向copy目标文件下面的文件
                //而不包含目录请使用下面的方法
                //string[]fileList= Directory.GetFiles(srcPath);
                string[] fileList =
                Directory.GetFileSystemEntries(srcPath);
                //遍历所有的文件和目录
                foreach (string file in fileList)
                {
                    //先当作目录处理如果存在这个
                    //目录就递归Copy该目录下面的文件
                    if (Directory.Exists(file))
                        CopyDir(
                        file,
                        aimPath + System.IO.Path.GetFileName(file));
                    //否则直接Copy文件
                    else
                        File.Copy(
                        file,
                        aimPath + System.IO.Path.GetFileName(file),
                        true);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
        }
    }
}
