namespace Models
{
    public class Person
    {
        #region поля

        private string name = "Введите имя";
        private DateTime age;
        private int passNumber;

        #endregion

        #region Свойства

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Age
        {
            get { return age; }
            set { age = value; }
        }

        public int PassNumber
        {
            get { return passNumber; }
            set { passNumber = value; }
        }

        #endregion

    }
}