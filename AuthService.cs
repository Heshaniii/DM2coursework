using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Threading.Tasks;

namespace DM2coursework
{
    public class AuthService
    {
        // Customer Signup
        public async Task<string> SignupCustomer(string p_cName, string p_cEmail, string p_cHashedPassword, string p_cPhone, string p_cAddress)
        {
            using (var conn = Database.GetConnection())
            {
                await conn.OpenAsync();
                using (var cmd = new OracleCommand("BEGIN :result := Signup_Customer(:p_cName, :p_cEmail, :p_cHashedPassword, :p_cPhone, :p_cAddress); END;", conn))
                {
                    cmd.Parameters.Add("result", OracleDbType.Varchar2, 36).Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add("p_cName", OracleDbType.Varchar2).Value = p_cName;
                    cmd.Parameters.Add("p_cEmail", OracleDbType.Varchar2).Value = p_cEmail.ToLower();
                    cmd.Parameters.Add("p_cHashedPassword", OracleDbType.Varchar2).Value = Utils.HashPassword(p_cHashedPassword);
                    cmd.Parameters.Add("p_cPhone", OracleDbType.Varchar2).Value = p_cPhone;
                    cmd.Parameters.Add("p_cAddress", OracleDbType.Varchar2).Value = p_cAddress;

                    await cmd.ExecuteNonQueryAsync();
                    return cmd.Parameters["result"].Value?.ToString();
                }
            }
        }

        // Customer Login
        public async Task<string> LoginCustomer(string p_cEmail, string p_cPassword)
        {
            using (var conn = Database.GetConnection())
            {
                await conn.OpenAsync();
                using (var cmd = new OracleCommand("BEGIN :result := Login_Customer(:p_cEmail, :p_cPassword); END;", conn))
                {
                    cmd.Parameters.Add("result", OracleDbType.Varchar2, 36).Direction = System.Data.ParameterDirection.ReturnValue;
                    cmd.Parameters.Add("p_cEmail", OracleDbType.Varchar2).Value = p_cEmail.ToLower();
                    cmd.Parameters.Add("p_cPassword", OracleDbType.Varchar2).Value = Utils.HashPassword(p_cPassword);

                    await cmd.ExecuteNonQueryAsync();
                    return cmd.Parameters["result"].Value?.ToString();
                }
            }
        }

        // Supplier Signup
        public async Task<string> SignupSupplier(string name, string p_sEmail, string sHashedPassword, string phone, string address)
        {
            using (var conn = Database.GetConnection())
            {
                await conn.OpenAsync();
                using (var cmd = new OracleCommand("BEGIN :result := Signup_Supplier(:name, :p_sEmail, :sPassword, :phone, :address); END;", conn))
                {
                    cmd.Parameters.Add("result", OracleDbType.Varchar2, 36).Direction = System.Data.ParameterDirection.ReturnValue;
                    cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    cmd.Parameters.Add("p_sEmail", OracleDbType.Varchar2).Value = p_sEmail.ToLower();
                    cmd.Parameters.Add("sPassword", OracleDbType.Varchar2).Value = sHashedPassword;
                    cmd.Parameters.Add("phone", OracleDbType.Varchar2).Value = phone;
                    cmd.Parameters.Add("address", OracleDbType.Varchar2).Value = address;

                    await cmd.ExecuteNonQueryAsync();
                    return cmd.Parameters["result"].Value?.ToString();
                }
            }
        }

        // Supplier Login
        public async Task<string> LoginSupplier(string p_sEmail, string sPassword)
        {
            using (var conn = Database.GetConnection())
            {
                await conn.OpenAsync();
                using (var cmd = new OracleCommand("BEGIN :result := Login_Supplier(:p_sEmail, :sPassword); END;", conn))
                {
                    cmd.Parameters.Add("result", OracleDbType.Varchar2, 36).Direction = System.Data.ParameterDirection.ReturnValue;
                    cmd.Parameters.Add("p_sEmail", OracleDbType.Varchar2).Value = p_sEmail.ToLower();
                    cmd.Parameters.Add("sPassword", OracleDbType.Varchar2).Value = Utils.HashPassword(sPassword);

                    await cmd.ExecuteNonQueryAsync();
                    return cmd.Parameters["result"].Value?.ToString();
                }
            }
        }
    }
}
