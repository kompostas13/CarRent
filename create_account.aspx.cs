using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class create_account : System.Web.UI.Page
{

    private string str1, str2;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void create_button_Click(object sender, EventArgs e)
    {
        if (username_text.Text != "" & password_text.Text != "" & first_text.Text != "" & last_text.Text != "")
        {
            str1 = first_text.Text + " " + last_text.Text;
            str2 = username_text.Text + " " + password_text.Text;
            create_acc(str1, str2);
        }
        else
        {
            Response.Write("<script>alert('EMPTY FIELD DETECTED!');</script>");
        }
    }

    private void create_acc(string s1, string s2)
    {

        using (System.IO.StreamWriter cont_writer = new System.IO.StreamWriter("D:/WebSites/RentACarWebsite/users.txt", true))
        {
            cont_writer.WriteLine(s1);
            cont_writer.WriteLine(s2);
        }
    }
}