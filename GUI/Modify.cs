﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GUI
{
    internal class Modify
    {
        public Modify()
        {
        }

        SqlCommand sqlCommand;//dùng để truy vấn các câu lệnh insert,update,dête,...
        SqlDataReader dataReader; //dùng để đọc dữ liệu trong bảng 
        public List<TaiKhoan> TaiKhoans(string query)//dùng để check tài khoản 
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }

        public void Command(string query)//dùng để đăng ký tài  khoản 
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();//thực thi câu truy vấn 
                sqlConnection.Close();
            }
        }
    }
}
