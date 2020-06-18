using System;
using MySql.Data.MySqlClient;
using shb_bank.Entity;
using shb_bank.Helper;

namespace shb_bank.Model
{
    public class AccountModel
    {
        public bool InsertAccount(Account account)
        {
            try
            {
                var cnn = ConnectionHelper.GetConnection();
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into shbaccount (accountNumber, balance, username, passwordHAsh, salt, role, email , fullname, phone, status) "
                                                    + $"values( '{account.AccountNumber}',{account.Balance},'{account.Username}', '{account.PasswordHash}', '{account.Salt}', {(int) account.Role},'{account.Email}', '{account.Fullname}', '{account.Phone}', {(int) account.Status})",
                    cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}