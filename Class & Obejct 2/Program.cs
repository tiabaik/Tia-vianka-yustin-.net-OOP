﻿using System;

namespace UserBootcamp
{
    class User
    {
        static void Main(string[] args)
        {
            UserBootcamp11 _userBootcamp11 = new UserBootcamp11();
            _userBootcamp11.NamaUser = "TIa";
            Console.WriteLine("Nama : " + _userBootcamp11.NamaUser);
        }
    }
    public class UserBootcamp11
    {
       
        string nama;
        string role;
        int emoney;

        public string NamaUser
        {
            get { return nama; }
            set { nama = value; }
        }

        public string RoleUser
        {
            get { return role; }
            set { role = value; }
        }

        public int EMoney
        {
            get { return emoney; }
            set { emoney = value; }
        }
    }

}