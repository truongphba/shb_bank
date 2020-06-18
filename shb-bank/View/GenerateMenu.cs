using System;
using shb_bank.Controller;
using shb_bank.Entity;

namespace shb_bank.View
{
    public class GenerateMenu
    {
        public void GetMenu()
        {
            
            if (AccountController.CurrentAccount == null)
            {
                GuessView.GenerateGuessMenu();
            }
            else
            {
                if (AccountController.CurrentAccount.Role == AccountRole.User)
                {
                    UserView.GenerateUserMenu();
                }
                else if(AccountController.CurrentAccount.Role == AccountRole.Admin )
                {
                    AdminView.GenerateAdminMenu();
                }
            }
        }
    }
}