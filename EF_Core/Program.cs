using EF_Core.Models;
using EF_Core.Repos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EF_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            App dupa = new Dupa2();
            dupa.Run();
        }
    }
}
