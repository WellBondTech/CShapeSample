public void PanelShowForm(Form form)
{
	//清除panel,*****非常重要
	this.panel1.Controls.Clear();
	//准备显示的窗体设置为非顶级控件,*****非常重要
	form.TopLevel = false;
	//边框去掉
	form.FormBorderStyle = FormBorderStyle.None;
	//窗体随容器大小调整
	form.Dock = DockStyle.Fill;
	//设置父容器为panel
	form.Parent = this.panel1;
	//显示窗体
	form.Show();
}

//调用方法
private void btnPanelShowForm_Click(object sender, EventArgs e)
{
	Form form2 = new form2();
	PanelShowForm(form2);
}
