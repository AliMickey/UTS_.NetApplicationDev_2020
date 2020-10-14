﻿using System;

namespace Assignment2
{
    public class FormProvider
    {
        public static Login Log
        {
            get
            {
                if (_login == null)
                {
                    _login = new Login();
                }
                return _login;
            }
        }
        private static Login _login;
    }
}