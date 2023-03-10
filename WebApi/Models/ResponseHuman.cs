using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Entities;

namespace WebApi.Models
{
    public class ResponseHuman
    {
        public ResponseHuman(Human human) {
            ID = human.ID;
            Surname = human.Surname;
            Firstname = human.Firstname;
            Patronymic = human.Patronymic;
            DateOfBirth = human.DateOfBirth;
            PassportSeries = human.PassportSeries;
            PassportNumber = human.PassportNumber;
            PassportFile = human.PassportFile;


        }

        public int ID { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string PassportFile { get; set; }
    }
}