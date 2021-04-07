using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        { 
        LoadRecord();
        }

    }
    //1. create connection to db , intiialize connection. put this connection out event, so that it can be reused by many events
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-H85CRF1\\FASIHAH;Initial Catalog=Fasihah;Integrated Security=True");
    protected void Button1_Click(object sender, EventArgs e)
    {
        //2. create new sql command
        SqlCommand cmd = new SqlCommand("insert into StudentInfo_Tab values('"+ int.Parse(TextBox1.Text) +"','"+ TextBox2.Text +"','"+ DropDownList1.SelectedValue +"','"+ double.Parse(TextBox3.Text) +"','" + TextBox4.Text +"') ",con);
        con.Open();

        cmd.ExecuteNonQuery();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Data berjaya disimpan')",true);
        con.Close();
        LoadRecord();
    }

    void LoadRecord()
    {
        SqlCommand cmd = new SqlCommand("select * from StudentInfo_Tab", con); //create new sql command
        SqlDataAdapter da = new SqlDataAdapter(cmd); // create new sql data adapter to hold that command
        DataTable dt = new DataTable(); //create new data table 
        da.Fill(dt); //fill datatable from data adapter that holds the command
        GridView1.DataSource = dt; //assign datatable as datasource to gridview
        GridView1.DataBind(); // bind data after assign datasource
    }

  

    protected void Button2_Click1(object sender, EventArgs e)
    {
        //2. create new sql command
        SqlCommand cmd = new SqlCommand("update  StudentInfo_Tab set StudentName = '" + TextBox2.Text + "',Address = '" + DropDownList1.SelectedValue + "',Age = '" + double.Parse(TextBox3.Text) + "', Contact = '" + TextBox4.Text + "' where StudentID ='" + int.Parse(TextBox1.Text) + "'", con);
        con.Open();

        cmd.ExecuteNonQuery();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Data berjaya dikemaskini')", true);
        con.Close();
        LoadRecord();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //2. create new sql command
        SqlCommand cmd = new SqlCommand("delete  StudentInfo_Tab where StudentID ='" + int.Parse(TextBox1.Text) + "'", con);
        con.Open();

        cmd.ExecuteNonQuery();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Data sudah dipadam')", true);
        con.Close();
        LoadRecord();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select * from StudentInfo_Tab where StudentName like  '%" + TextBox2.Text + "%'", con); //create new sql command
        SqlDataAdapter da = new SqlDataAdapter(cmd); // create new sql data adapter to hold that command
        DataTable dt = new DataTable(); //create new data table 
        da.Fill(dt); //fill datatable from data adapter that holds the command
        GridView1.DataSource = dt; //assign datatable as datasource to gridview
        GridView1.DataBind(); // bind data after assign datasource
    
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from StudentInfo_Tab where StudentName like  '%" + TextBox2.Text + "%'", con); //create new sql command
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
            {
            TextBox1.Text = dr.GetValue(0).ToString();
            TextBox2.Text = dr.GetValue(1).ToString(); // number by order of column in db table, start from 0
            DropDownList1.SelectedValue = dr.GetValue(2).ToString();
            TextBox3.Text = dr.GetValue(3).ToString();
            TextBox4.Text = dr.GetValue(4).ToString();
        }

    }

    void Clear()
    {
        TextBox1.Text = "";
        DropDownList1.SelectedValue = "0";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";

    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Clear();
    }
}