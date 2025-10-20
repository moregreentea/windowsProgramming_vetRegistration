using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis2255_vetRegistration_cmoreland
{
    internal class Registration
    {
        // Private attributes
        private string name;
        private string animalType;
        private string birthDate;
        private string visitReason;
        private string contactNumber;

        // Default constructor
        public Registration() { }

        // Custom constructor
        public Registration(string name, string animalType, string birthDate, string visitReason, string contactNumber)
        {
            Name = name;
            AnimalType = animalType;
            BirthDate = birthDate;
            VisitReason = visitReason;
            ContactNumber = contactNumber;
        }

        // Getter & Setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string AnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string VisitReason
        {
            get { return visitReason; }
            set { visitReason = value; }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        public static List<Registration> allRegistrations = new List<Registration>();

        public override string ToString()
        {
            return $"{Name} - {AnimalType} - {BirthDate} - {VisitReason} - {ContactNumber}";
        }
        

    }
}
