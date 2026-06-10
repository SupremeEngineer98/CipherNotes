using Cipher_Notes.Models;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Cipher_Notes.Services
{
    public class NoteService
    {
        private readonly DatabaseService databaseService;
        private readonly EncryptionService encryptionService;

        public NoteService(DatabaseService db, EncryptionService crypto)
        {
            databaseService = db;
            encryptionService = crypto;
        }

        //create note method
        public async Task CreateNote(string title, string content, string password)
        {
            try
            {
                var (cipher, salt, iv) = encryptionService.EncryptNote(content, password);

                var note = new SecureNotes
                {
                    Title = title,
                    Encrypted_content = cipher,
                    Salt = salt,
                    IV = iv,
                    Created_at = DateTime.Now
                };

                await databaseService.Create(note);
            }
            catch (Exception ex)
            {
                throw new Exception("Cannot create the note", ex);
            }


            //update note method

            public async Task UpdateNote(int id,string title, string content)
        }
    }
}   