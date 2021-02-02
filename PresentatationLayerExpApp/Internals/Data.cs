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
            UserRepository.Table.Add(new User("1", "123", "Simon", "admin"));

            //Member
            MemberRepository.Table.Add(new Member("1", "Simon", "Landenberg", "070-1234567", "s193508@student.hb.se"));

            //Booking
            //BookingRepository.Table.Add(new Booking("B1", "U1", "C1", 12367978919, DateTime.Now, DateTime.Now));
            //BookingRepository.Table.Add(new Booking("B2", "U2", "C2", 12367978919, DateTime.Now, DateTime.Now));


            //Book
            BookRepository.Table.Add(new Book(1234567890987654, "Harry Potter", 14));
            BookRepository.Table.Add(new Book(123456789, "Utvandrarna"));
            BookRepository.Table.Add(new Book(234567890, "Potter"));
            BookRepository.Table.Add(new Book(345678901, "Häst"));
            BookRepository.Table.Add(new Book(456789012, "Hund"));
            BookRepository.Table.Add(new Book(567890123, "Fotboll"));
            BookRepository.Table.Add(new Book(6789012345, "Curling"));
            BookRepository.Table.Add(new Book(7890123456, "Test"));
            BookRepository.Table.Add(new Book(8901234567, "Test1"));
            BookRepository.Table.Add(new Book(9012345678, "Test2"));
            BookRepository.Table.Add(new Book(9876543210, "Test3"));
        }
    }
}