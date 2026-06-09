using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Cipher_Notes.Models;

namespace Cipher_Notes.Services
{
    public class DatabaseService
    {
        //declaring variables!

        private const string db = "cipher_notes.db"; //declaring db's name!

        private readonly SQLiteAsyncConnection? _connection; //declaring a private readonly variable for the connection object!

        //connection method

        public async Task InitAsync()
        {
            //create table
            await _connection.CreateTableAsync<SecureNotes>();
        }

        //declare constructor!
        public DatabaseService()
        {
            //create the connection in cosntructor since _connection variable is readonly

            if (_connection != null) return; //if connection is active, the method does not initialize it again

            var db_path = Path.Combine(FileSystem.AppDataDirectory, db); //define db's file path

            _connection = new SQLiteAsyncConnection(db_path); //initialize the connection
        }
       
    }
}
