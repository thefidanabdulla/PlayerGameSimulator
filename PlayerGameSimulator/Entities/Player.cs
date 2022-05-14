using PlayerGameSimulator.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerGameSimulator.Entities
{
    public class Player : IEntities
    {
        public Player (int Id, string FirstName, string Lastname , int YearOfBirth)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.Lastname = Lastname;
            this.YearOfBirth = YearOfBirth;

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int YearOfBirth { get; set; }
    }
}
