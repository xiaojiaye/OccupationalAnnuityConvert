namespace OccupationalAnnuityConvert
{
    partial class Frm_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlTaikang = new System.Windows.Forms.TabControl();
            this.tabPageTaikang = new System.Windows.Forms.TabPage();
            this.tabPageGuoshou = new System.Windows.Forms.TabPage();
            this.gboxTaiKangChooseBusType = new System.Windows.Forms.GroupBox();
            this.rad1004Taikang = new System.Windows.Forms.RadioButton();
            this.rad1007Taikang = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControlTaikang.SuspendLayout();
            this.tabPageTaikang.SuspendLayout();
            this.gboxTaiKangChooseBusType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTaikang
            // 
            this.tabControlTaikang.Controls.Add(this.tabPageTaikang);
            this.tabControlTaikang.Controls.Add(this.tabPageGuoshou);
            this.tabControlTaikang.Location = new System.Drawing.Point(12, 12);
            this.tabControlTaikang.Name = "tabControlTaikang";
            this.tabControlTaikang.SelectedIndex = 0;
            this.tabControlTaikang.Size = new System.Drawing.Size(1218, 602);
            this.tabControlTaikang.TabIndex = 0;
            // 
            // tabPageTaikang
            // 
            this.tabPageTaikang.Controls.Add(this.listBox1);
            this.tabPageTaikang.Controls.Add(this.button1);
            this.tabPageTaikang.Controls.Add(this.gboxTaiKangChooseBusType);
            this.tabPageTaikang.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPageTaikang.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPageTaikang.Location = new System.Drawing.Point(4, 22);
            this.tabPageTaikang.Name = "tabPageTaikang";
            this.tabPageTaikang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTaikang.Size = new System.Drawing.Size(1210, 576);
            this.tabPageTaikang.TabIndex = 0;
            this.tabPageTaikang.Text = "泰康接口数据转换";
            this.tabPageTaikang.UseVisualStyleBackColor = true;
            // 
            // tabPageGuoshou
            // 
            this.tabPageGuoshou.Location = new System.Drawing.Point(4, 22);
            this.tabPageGuoshou.Name = "tabPageGuoshou";
            this.tabPageGuoshou.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGuoshou.Size = new System.Drawing.Size(1210, 576);
            this.tabPageGuoshou.TabIndex = 1;
            this.tabPageGuoshou.Text = "国寿接口数据转换";
            this.tabPageGuoshou.UseVisualStyleBackColor = true;
            // 
            // gboxTaiKangChooseBusType
            // 
            this.gboxTaiKangChooseBusType.Controls.Add(this.rad1007Taikang);
            this.gboxTaiKangChooseBusType.Controls.Add(this.rad1004Taikang);
            this.gboxTaiKangChooseBusType.Location = new System.Drawing.Point(6, 17);
            this.gboxTaiKangChooseBusType.Name = "gboxTaiKangChooseBusType";
            this.gboxTaiKangChooseBusType.Size = new System.Drawing.Size(262, 51);
            this.gboxTaiKangChooseBusType.TabIndex = 0;
            this.gboxTaiKangChooseBusType.TabStop = false;
            this.gboxTaiKangChooseBusType.Text = "选择来源数据的接口版本";
            // 
            // rad1004Taikang
            // 
            this.rad1004Taikang.AutoSize = true;
            this.rad1004Taikang.Location = new System.Drawing.Point(30, 20);
            this.rad1004Taikang.Name = "rad1004Taikang";
            this.rad1004Taikang.Size = new System.Drawing.Size(71, 16);
            this.rad1004Taikang.TabIndex = 0;
            this.rad1004Taikang.TabStop = true;
            this.rad1004Taikang.Text = "1004接口";
            this.rad1004Taikang.UseVisualStyleBackColor = true;
            // 
            // rad1007Taikang
            // 
            this.rad1007Taikang.AutoSize = true;
            this.rad1007Taikang.Location = new System.Drawing.Point(121, 20);
            this.rad1007Taikang.Name = "rad1007Taikang";
            this.rad1007Taikang.Size = new System.Drawing.Size(71, 16);
            this.rad1007Taikang.TabIndex = 1;
            this.rad1007Taikang.TabStop = true;
            this.rad1007Taikang.Text = "1007接口";
            this.rad1007Taikang.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(27, 106);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1083, 136);
            this.listBox1.TabIndex = 2;
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 635);
            this.Controls.Add(this.tabControlTaikang);
            this.Name = "Frm_main";
            this.Text = "职业年金投监系统数据传输转换";
            this.tabControlTaikang.ResumeLayout(false);
            this.tabPageTaikang.ResumeLayout(false);
            this.gboxTaiKangChooseBusType.ResumeLayout(false);
            this.gboxTaiKangChooseBusType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTaikang;
        private System.Windows.Forms.TabPage tabPageTaikang;
        private System.Windows.Forms.TabPage tabPageGuoshou;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gboxTaiKangChooseBusType;
        private System.Windows.Forms.RadioButton rad1007Taikang;
        private System.Windows.Forms.RadioButton rad1004Taikang;
        private System.Windows.Forms.ListBox listBox1;
    }
}

