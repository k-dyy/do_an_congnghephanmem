﻿using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace DTO4
{
     class Taikhoan
    {
        string username, password;
        bool isAdmin;
        public string Username { get => username; }
        public string Password { get => password; }
        public bool IsAdmin { get => isAdmin; }

    }
}
