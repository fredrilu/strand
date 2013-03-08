using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HelloWorldUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UserName = Environment.UserName;
        Label1.Text = UserName;
    }

    public string UserName { get; set; }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "Button clicked!";
        Thread.Sleep(2000);
        Label1.Text = UserName;
    }
}