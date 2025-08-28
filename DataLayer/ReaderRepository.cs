﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using System.Data.SqlClient;
using Shared;
namespace DataLayer
{
    public class ReaderRepository
    {
        public List<ReaderDTO> GetAllReaders()
        {
            var list = new List<ReaderDTO>();
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                string query = "SELECT * FROM Reader";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ReaderDTO
                    {
                        ReaderID = (int)reader["readerID"],
                        FirstName = reader["firstName"].ToString(),
                        LastName = reader["lastName"].ToString(),
                        Gender = reader["gender"].ToString(),
                        DateOfBirth = reader["dateOfBirth"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["dateOfBirth"]),
                        Gmail = reader["gmail"].ToString(),
                        Address = reader["address"].ToString(),
                        Phone = reader["phone"].ToString(),                      
                        CreatedDate = reader["created_date"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["created_date"])
                    }) ;
                }
            }
            return list;
        }
        // 2. Thêm bạn đọc mới
        public bool InsertReader(ReaderDTO reader)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                string query = @"INSERT INTO Reader 
                                (firstName, lastName, gender, dateOfBirth, gmail, address, phone)
                                VALUES (@FirstName, @LastName, @Gender, @DOB, @Gmail, @Address, @Phone)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", reader.FirstName);
                cmd.Parameters.AddWithValue("@LastName", reader.LastName);
                cmd.Parameters.AddWithValue("@Gender", reader.Gender);
                cmd.Parameters.AddWithValue("@DOB", reader.DateOfBirth);
                cmd.Parameters.AddWithValue("@Gmail", reader.Gmail);
                cmd.Parameters.AddWithValue("@Address", reader.Address);
                cmd.Parameters.AddWithValue("@Phone", reader.Phone);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool UpdateReader(ReaderDTO reader)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                string query = @"UPDATE Reader SET 
                                firstName = @FirstName, 
                                lastName = @LastName,
                                gender = @Gender,
                                dateOfBirth = @DOB,
                                gmail = @Gmail,
                                address = @Address,
                                phone = @Phone
                                WHERE readerID = @ReaderID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ReaderID", reader.ReaderID);
                cmd.Parameters.AddWithValue("@FirstName", reader.FirstName);
                cmd.Parameters.AddWithValue("@LastName", reader.LastName);
                cmd.Parameters.AddWithValue("@Gender", reader.Gender);
                cmd.Parameters.AddWithValue("@DOB", reader.DateOfBirth);
                cmd.Parameters.AddWithValue("@Gmail", reader.Gmail);
                cmd.Parameters.AddWithValue("@Address", reader.Address);
                cmd.Parameters.AddWithValue("@Phone", reader.Phone);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool DeleteReader(int readerID)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                string query = "DELETE FROM Reader WHERE readerID = @ReaderID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ReaderID", readerID);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 5. Tìm kiếm bạn đọc theo tên
        public List<ReaderDTO> SearchByName(string keyword)
        {
            var list = new List<ReaderDTO>();
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                string query = "SELECT * FROM Reader WHERE firstName LIKE @Keyword OR lastName LIKE @Keyword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", $"%{keyword}%");

                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ReaderDTO
                    {
                        ReaderID = (int)reader["readerID"],
                        FirstName = reader["firstName"].ToString(),
                        LastName = reader["lastName"].ToString(),
                        Gender = reader["gender"].ToString(),
                        DateOfBirth = Convert.ToDateTime(reader["dateOfBirth"]),
                        Gmail = reader["gmail"].ToString(),
                        Address = reader["address"].ToString(),
                        Phone = reader["phone"].ToString(),
                        CreatedDate = Convert.ToDateTime(reader["created_date"])
                    });
                }
            }
            return list;
        }
    }
}
