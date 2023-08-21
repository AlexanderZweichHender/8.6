namespace Task4_8._6.Items
{
    public struct Contact
    {
        public string FullName;
        public string Street;

        public int HouseNumber;
        public int FlatNumber;

        public string MobilePhoneNumber;
        public string HomePhoneNumber;

        public Contact(string name, string street, int houseNumber
            ,int flatNumber, string mobileNumber, string homePhoneNumber)
        {
            FullName = name;
            Street = street;

            HouseNumber = houseNumber;
            FlatNumber = flatNumber;

            MobilePhoneNumber = mobileNumber;
            HomePhoneNumber = homePhoneNumber;
        }
    }
}
