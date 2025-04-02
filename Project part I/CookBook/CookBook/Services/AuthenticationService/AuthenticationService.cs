using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly Dictionary<string, string> korisnici = new Dictionary<string, string>();
        private readonly IInputReader _inputReader;

        public AuthenticationService(IInputReader inputReader)
        {
            _inputReader = inputReader;
        }

        public string CitajLozinku()
        {
            string lozinka = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = _inputReader.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace)
                {
                    if (lozinka.Length > 0)
                    {
                        Console.Write("\b \b");
                        lozinka = lozinka[0..^1];
                    }
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    lozinka += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);

            Console.WriteLine();
            return lozinka;
        }

        public bool registrujkorisnika(string korisnickoime, string lozinka)
        {
            if (korisnici.containskey(korisnickoime))
                return false;

            korisnici[korisnickoime] = hashlozinka(lozinka);
            return true;
        }

        public bool autentifikujkorisnika(string korisnickoime, string lozinka)
        {
            return korisnici.trygetvalue(korisnickoime, out string hash) && hash == hashlozinka(lozinka);
        }

        private string hashlozinka(string lozinka)
        {
            using var sha256 = sha256.create();
            byte[] hashbytes = sha256.computehash(encoding.utf8.getbytes(lozinka));
            return convert.tobase64string(hashbytes);
        }
    }
}
