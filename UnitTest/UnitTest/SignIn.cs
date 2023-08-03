using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class SignInManager
    {
        public static string SignIn(string userName, string userPwd)
        {
            string msg;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPwd))
            {
                msg = "provide username and password";
            }
            else
            {
                if ((userName == "Viya346") && (userPwd == "Viya050601"))
                {
                    msg = "SignIn success ";
                }
                else
                {
                    msg = "Signin Fail";
                }

            }
            return msg;
        }
        }
    }

