﻿using ExpeditApplikation.Internals;
using ExpeditApplikation.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpeditApplikation
{
    /// <summary>
    ///  This is the facade of the business layer.
    /// </summary>
    public class BookingSystem
    {
        public User LoggedIn {
            get; private set;
        }

        /// <summary>
        ///  The LogIn system operation.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string LogIn(string userId, string password)
        {
            data = new Data();
            // Stupid solution. Not completely after the DSD where Get(id) is a Repository method.
            foreach (User user in data.UserRepository.Table) {
                if (user.UserID == userId && user.VerifyPassword(password)) {
                    LoggedIn = user;
                    return user.Role;
                }
            }
            return "false";
        }

        public IList<Book> AvailableBooks()
        {
            data = new Data();
            List<Book> availableBooks = new List<Book>();
            foreach (Book book in data.BookRepository.Table)
            {
                if (book.Available == true)
                    availableBooks.Add(book);

            }
            return availableBooks;
        }

        private Internals.Data data;
    }
}
