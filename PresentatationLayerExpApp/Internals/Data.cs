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
            if (UserRepository.Table.Count == 0) {
                Fill();
            }
        }

        private void Fill()
        {
            //User
            UserRepository.Table.Add(new User("1", "123", "Simon", "admin"));

            //Member
            MemberRepository.Table.Add(new Member(1, "Simon", "Landenberg", "070-1234567", "s193508@student.hb.se"));

            //Book
            BookRepository.Table.Add(new Book(123123123, "Test"));
        }
    }
}