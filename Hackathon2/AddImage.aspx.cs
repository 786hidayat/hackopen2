﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hackathon2
{
    public partial class AddImage : System.Web.UI.Page
    {
        string connectionString = @"Data Source=PGADDAMJ8PW9S3;Initial Catalog=HackathonIMG;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //add image
        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        using (SqlConnection sqlConnection = new SqlConnection(connectionString)) 
        //        {
        //            if (FileUpload1.HasFile)
        //            {
        //                sqlConnection.Open();
        //                string query = "INSERT INTO Imagedetails (ImageID,ImageName,Size,IMG) VALUES (@ImageID,@ImageName,@Size,@IMG)";
        //                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        //                FileUpload1.SaveAs(Server.MapPath("~/ImageImg") + System.IO.Path.GetFileName(FileUpload1.FileName));
        //                string linkPath = "ImageImg/" + System.IO.Path.GetFileName(FileUpload1.FileName);
        //                sqlCommand.Parameters.AddWithValue("@ImageID", TextBoxID.Text);
        //                sqlCommand.Parameters.AddWithValue("@ImageName", ImagetextName.Text);
        //                sqlCommand.Parameters.AddWithValue("@Size", Size.Text);
        //                sqlCommand.Parameters.AddWithValue("@IMG", linkPath);
        //                sqlCommand.ExecuteNonQuery();
        //                sqlConnection.Close();

        //            }
        //        }
        //        System.Windows.MessageBox.Show("Add successful");
        //    }




        //    catch(Exception ex)
        //    {
        //        System.Windows.MessageBox.Show("Add Failed");
        //    }

        //}

        //protected void ButtonBack_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("~/Default.aspx");
        //}

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            System.IO.Stream fs = FileUpload2.PostedFile.InputStream;
            System.IO.BinaryReader br = new System.IO.BinaryReader(fs);
            Byte[] bytes = br.ReadBytes((Int32)fs.Length);
            string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
            Image1.ImageUrl = base64String;
            string finalIMG = Image1.ImageUrl;

        }
    }
}