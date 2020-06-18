using System;
using shb_bank.Entity;
using shb_bank.Helper;
using shb_bank.Model;

namespace shb_bank.Controller
{
    public class AccountController
    {
        AccountModel accountModel = new AccountModel();

        public void Register()
        {
            while (true)
            {
                try
                {
                    var account = new Account();
                    Console.WriteLine("Create a new account!");
                    Console.WriteLine("Enter Account Number:");
                    account.AccountNumber = Console.ReadLine();
                    Console.WriteLine("Enter Username:");
                    account.Username = Console.ReadLine();
                    Console.WriteLine("Enter Password:");
                    var password = Console.ReadLine();
                    account.Salt = PasswordHelper.GenerateSalt();
                    account.PasswordHash = PasswordHelper.MD5Hash(password + account.Salt);
                    Console.WriteLine("Enter Email:");
                    account.Email = Console.ReadLine();
                    Console.WriteLine("Enter Fullname:");
                    account.Fullname = Console.ReadLine();
                    Console.WriteLine("Enter Phone:");
                    account.Phone = Console.ReadLine();
                    account.Balance = 0;
                    account.Role = AccountRole.User;
                    account.Status = AccountStatus.Active;
                    var result = accountModel.InsertAccount(account);
                    if (result)
                    {
                        Console.WriteLine("Đăng ký thành công!!");
                    }
                    else
                    {
                        Console.WriteLine("Đăn ký thất bại, số tài khoản, số điện thoại hoặc email đã có người sử dụng!!");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static Account CurrentAccount = null;
    }
}