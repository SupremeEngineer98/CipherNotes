using Cipher_Notes.Services;

namespace Cipher_Notes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TestEncryption();
        }


        //test-encryption decryption
        private void TestEncryption()
        {
            var enc = new EncryptionService();
            var salt = enc.GenerateSalt();
            var iv = enc.GenerateIV();
            var (cipher, s, i) = enc.EncryptNote("hello i am gay", "password123");
            var decrypted = enc.DecryptContent(cipher, "password123", s, i);
            Console.WriteLine($"Decrypted: {decrypted}"); // πρέπει να δείξει "hello"
        }
    }
}
