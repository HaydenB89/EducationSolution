using System;
using System.Collections.Generic;

namespace EducationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Major> majors = new List<Major>();

            Major business = new Major("Business", 1000);
            majors.Add(business);
            Major nursing = new Major("Nursing", 1200);
            majors.Add(nursing);
            Major theater = new Major("Theater", 1100);
            majors.Add(theater);

        }
    }
}
