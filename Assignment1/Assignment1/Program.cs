using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://github.com/AliMickey/UTS_.NetApplicationDev_Spring_2020/commits/master
            Bank bank = new Bank();
            bank.LoginInit();
        }      
    }
}
