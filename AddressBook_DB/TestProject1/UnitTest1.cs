using AdvanceAddressBook;
using NUnit.Framework;

namespace AddressBookTesting
{
    public class Test
    {
        Details details;
        AddressBook addressBook;
        [SetUp]
        public void Setup()
        {
            details = new Details();
            addressBook = new AddressBook();
        }
        /// <summary>
        /// UC -Get all the Address Book Data 
        /// </summary>
        [Test]
        public void Get_AllAddressBookData()
        {
            var expected = 11;
            var result = Details.GetAddressBookDetails();
            Assert.AreEqual(expected, result.Count);
        }
        [Test]
        public void Update_AddressBook_ContactInDB()
        {
            bool expected = true;
            addressBook.First_Name = "Atish";
            addressBook.Last_Name = "Shelke";
            addressBook.Address = "Street 07";
            addressBook.City = "Pune";
            addressBook.State = "MH";
            addressBook.Zip = 340045;
            addressBook.PhoneNumber = 8805320078;
            addressBook.Email = "satishshelke123@gmail.com";
            addressBook.AddressBookName = "FrinedCircle";
            addressBook.Type = "Firend";
            bool result = details.UpdateContact(addressBook);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Get_Data_ByUsingCityAndState()
        {
            bool expected = true;
            addressBook.City = "Pune";
            addressBook.State = "MH";
            bool result = details.GetDataFromCityAndState(addressBook);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Add_AddressBook_ContactInDB()
        {
            bool expected = true;
            addressBook.First_Name = "Raju";
            addressBook.Last_Name = "Wayal";
            addressBook.Address = "Street 45";
            addressBook.City = "Haydrabad";
            addressBook.State = "Telangana";
            addressBook.Zip = 940045;
            addressBook.PhoneNumber = 9805310008;
            addressBook.Email = "raju13@gmail.com";
            addressBook.AddressBookName = "CollageBook";
            addressBook.Type = "Friend";
            bool result = details.AddContact(addressBook);
            Assert.AreEqual(expected, result);
        }
    }
}