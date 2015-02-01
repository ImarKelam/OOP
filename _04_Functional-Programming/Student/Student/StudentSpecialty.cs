namespace Student
{
    using System;

    class StudentSpecialty
    {
        private string specialityName;
        private string facNumber;

        public StudentSpecialty(string specialityName, string facNumber)
        {
            this.SpecialityName = specialityName;
            this.FacNumber = facNumber;
        }

        public string SpecialityName
        {
            get { return specialityName; }
            set { specialityName = value; }
        }

        public string FacNumber
        {
            get { return facNumber; }
            set { facNumber = value; }
        }
    }
}
