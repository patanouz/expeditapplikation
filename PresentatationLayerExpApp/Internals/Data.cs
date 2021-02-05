using ExpeditApplikation.Model;
using System;
using System.Collections.Generic;

namespace ExpeditApplikation.Internals
{
    /// <summary>
    ///  This class is used to access the storage in the application.
    /// </summary>
    internal class Data
    {

        public Repository<Member> MemberRepository
        {
            get; private set;
        }
        public Repository<User> UserRepository {
            get; private set;
        }

        public Repository<Book> BookRepository
        {
            get;
        }

        public Repository<Booking> BookingRepository
        {
            get;
        }

        internal Data()
        {
            MemberRepository = new Repository<Member>();
            UserRepository = new Repository<User>();
            BookRepository = new Repository<Book>();
            BookingRepository = new Repository<Booking>();

            // Initialize the tables if this is the first UnitOfWork.
            if (UserRepository.Table.Count == 0 && BookRepository.Table.Count == 0) {
                Fill();
            }
        }

        private void Fill()
        {
            //User
            UserRepository.Table.Add(new User("admin", "123", "Simon", "admin"));

            //Member
            MemberRepository.Table.Add(new Member("M1", "Simon", "Landenberg", "070-1234567", "s193508@student.hb.se"));
            MemberRepository.Table.Add(new Member("M2", "Michael", "Haggren", "070-3434567", "s194508@student.hb.se"));
            MemberRepository.Table.Add(new Member("M3", "Olle", "Hansson", "070-3344567", "s184508@student.hb.se"));

            //Booking

            /*Lagt till dummydata som med försenade bokningar 
            så att han kan se att fakturafunktionen fungerar*/

            BookingRepository.Table.Add(new Booking("B100", "admin","Asterix och Obelix", "M3", 99367978919, DateTime.Now.AddDays(-14), DateTime.Now.AddDays(-20)));
            BookingRepository.Table.Add(new Booking("B101", "admin","Vargen", "M3", 45275432104, DateTime.Now.AddDays(-7), DateTime.Now.AddDays(-14)));
            //BookingRepository.Table.Add(new Booking("B2", "U2", "C2", 12367978919, DateTime.Now, DateTime.Now));


            //Book
            BookRepository.Table.Add(new Book(12344555694, "Hjärnstark"));
            BookRepository.Table.Add(new Book(66844555612, "Utvandrarna"));
            BookRepository.Table.Add(new Book(99844555614, "The Almanack"));
            BookRepository.Table.Add(new Book(26123425612, "Livet som häst"));
            BookRepository.Table.Add(new Book(10123425699, "Varför?"));
            BookRepository.Table.Add(new Book(84123425612, "Bert"));
            BookRepository.Table.Add(new Book(88890123451, "Bli proffs på curling"));
            BookRepository.Table.Add(new Book(23901234561, "Shuggie Bain"));
            BookRepository.Table.Add(new Book(34012345677, "Där kräftorna sjunger"));
            BookRepository.Table.Add(new Book(45123456786, "Smart Money"));
            BookRepository.Table.Add(new Book(95765432104, "Ondskan"));
            BookRepository.Table.Add(new Book(22901234561, "Veganska recept"));
            BookRepository.Table.Add(new Book(84012345677, "Förintelsens barn"));
            BookRepository.Table.Add(new Book(01123456786, "Ett förlovat land"));
            BookRepository.Table.Add(new Book(13744432104, "Psycho-Cybernetics"));
            BookRepository.Table.Add(new Book(67543456786, "Can't Hurt Me"));
            BookRepository.Table.Add(new Book(78545432104, "Burn After Writing"));
            BookRepository.Table.Add(new Book(54233456786, "Girl, Woman, Other"));
            BookRepository.Table.Add(new Book(81275432104, "We Were Liars"));
            BookRepository.Table.Add(new Book(99367978919, "Asterix och Obelix"));
            BookRepository.Table.Add(new Book(45275432104, "Vargen"));
        }
    }
}