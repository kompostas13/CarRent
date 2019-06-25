using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{

    private string to_search;
    private string[] infos = new string[5];

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void login_button_Click(object sender, EventArgs e)
    {
        if (password_text.Text != "" & username_text.Text != "")
        {
            to_search = username_text.Text + " " + password_text.Text;
            search(to_search);
        }
        else
        {
            Response.Write("<script>alert('WRONG CREDENTIALS');</script>");
        }
    }

    private void search(string str)
    {
        bool notfound = true;
        string line;
        System.IO.StreamReader cont_searcher = new System.IO.StreamReader("D:/WebSites/RentACarWebsite/users.txt");
        //System.IO.StreamReader with_info = new System.IO.StreamReader("info.txt");
        while ((line = cont_searcher.ReadLine()) != null)
        {
            if (str == "")
            {
                break;
            }
            if (line.Equals(str))
            {
                notfound = false;
                infos[0] = str;
                //infos[0] = with_info.ReadLine();
                //infos[1] = with_info.ReadLine();
                //infos[2] = with_info.ReadLine();
                //infos[3] = with_info.ReadLine();
                //infos[4] = with_info.ReadLine();
                //infos[5] = with_info.ReadLine();
                break;
            }
            line = cont_searcher.ReadLine();
        }
        cont_searcher.Close();
        if (notfound)
        {
            Response.Write("<script>alert('Nothing matched your search!');</script>");
        }
        else
        {
            Response.Redirect("main.aspx");

        }
    }

    protected void create_account_button_Click(object sender, EventArgs e)
    {
        Response.Redirect("create_account.aspx");
    }

}