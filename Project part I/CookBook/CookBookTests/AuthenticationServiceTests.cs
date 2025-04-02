using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using CookBook.Services.InputReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Services;

namespace CookBookTests
{
    [TestClass]
    public class AuthenticationServiceTests
    {
        private AuthenticationService _authService;
        private Mock<IInputReader> _mockInputReader;
        [TestInitialize]
        public void Setup()
        {
            _mockInputReader = new Mock<IInputReader>();
            _authService = new AuthenticationService(_mockInputReader.Object);

        }

        [TestMethod]
        //public void CitajLozinku_ValidInput_ReturnsCorrectPassword()
        //{
        //    _mockInputReader.SetupSequence(reader => reader.ReadKey(true))
        //        .Returns(new ConsoleKeyInfo('p', ConsoleKey.P, false, false, false))
        //        .Returns(new ConsoleKeyInfo('a', ConsoleKey.A, false, false, false))
        //        .Returns(new ConsoleKeyInfo('s', ConsoleKey.S, false, false, false))
        //        .Returns(new ConsoleKeyInfo('s', ConsoleKey.S, false, false, false))
        //        .Returns(new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false))
        //        .Returns(new ConsoleKeyInfo('o', ConsoleKey.O, false, false, false))
        //        .Returns(new ConsoleKeyInfo('r', ConsoleKey.R, false, false, false))
        //        .Returns(new ConsoleKeyInfo('d', ConsoleKey.D, false, false, false))
        //        .Returns(new ConsoleKeyInfo('1', ConsoleKey.D1, false, false, false))
        //        .Returns(new ConsoleKeyInfo('2', ConsoleKey.D2, false, false, false))
        //        .Returns(new ConsoleKeyInfo('3', ConsoleKey.D3, false, false, false))
        //        .Returns(new ConsoleKeyInfo('\r', ConsoleKey.Enter, false, false, false));

        //    string result = _authService.CitajLozinku();

        //    Assert.AreEqual("password123", result, "Lozinka nije pravilno pročitana.");
        //}

        //[TestMethod]
        //public void CitajLozinku_InputWithBackspace_HandlesBackspaceCorrectly()
        //{
        //    _mockInputReader.SetupSequence(reader => reader.ReadKey(true))
        //        .Returns(new ConsoleKeyInfo('p', ConsoleKey.P, false, false, false))
        //        .Returns(new ConsoleKeyInfo('a', ConsoleKey.A, false, false, false))
        //        .Returns(new ConsoleKeyInfo('s', ConsoleKey.S, false, false, false))
        //        .Returns(new ConsoleKeyInfo('s', ConsoleKey.S, false, false, false))
        //        .Returns(new ConsoleKeyInfo('\b', ConsoleKey.Backspace, false, false, false))
        //        .Returns(new ConsoleKeyInfo('\b', ConsoleKey.Backspace, false, false, false))
        //        .Returns(new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false))
        //        .Returns(new ConsoleKeyInfo('o', ConsoleKey.O, false, false, false))
        //        .Returns(new ConsoleKeyInfo('r', ConsoleKey.R, false, false, false))
        //        .Returns(new ConsoleKeyInfo('d', ConsoleKey.D, false, false, false))
        //        .Returns(new ConsoleKeyInfo('\r', ConsoleKey.Enter, false, false, false));

        //    string result = _authService.CitajLozinku();

        //    Assert.AreEqual("paword", result, "Backspace nije pravilno obrađen.");
        //}

        //[TestMethod]
        //public void CitajLozinku_InputWithBackspaceEmptyPassword_HandlesBackspaceCorrectly()
        //{
        //    _mockInputReader.SetupSequence(reader => reader.ReadKey(true))
        //        .Returns(new ConsoleKeyInfo('\b', ConsoleKey.Backspace, false, false, false))
        //        .Returns(new ConsoleKeyInfo('\b', ConsoleKey.Backspace, false, false, false))
        //        .Returns(new ConsoleKeyInfo('\r', ConsoleKey.Enter, false, false, false));

        //    string result = _authService.CitajLozinku();

        //    Assert.AreEqual("", result, "Backspace nije pravilno obrađen.");
        //}

        //[TestMethod]
        //public void CitajLozinku_EmptyInput_ReturnsEmptyString()
        //{
        //    _mockInputReader.Setup(reader => reader.ReadKey(true))
        //        .Returns(new ConsoleKeyInfo('\r', ConsoleKey.Enter, false, false, false));

        //    string result = _authService.CitajLozinku();

        //    Assert.AreEqual(string.Empty, result, "Metoda nije vratila prazan string za prazan unos.");
        //}

        //[TestMethod]
        //public void RegistrujKorisnika_NoviKorisnik_RegistracijaUspjesna()
        //{
        //    string korisnickoIme = "testKorisnik";
        //    string lozinka = "testLozinka";

        //    bool rezultat = _authService.RegistrujKorisnika(korisnickoIme, lozinka);

        //    Assert.IsTrue(rezultat, "Korisnik nije uspješno registrovan.");
        //}

        //[TestMethod]
        //public void RegistrujKorisnika_PostojeceKorisnickoIme_RegistracijaNeuspjesna()
        //{

        //    string korisnickoIme = "testKorisnik";
        //    string lozinka = "testLozinka";
        //    _authService.RegistrujKorisnika(korisnickoIme, lozinka);

        //    bool rezultat = _authService.RegistrujKorisnika(korisnickoIme, lozinka);

        //    Assert.IsFalse(rezultat, "Korisnik je registrovan sa postojećim korisničkim imenom.");
        //}

        //[TestMethod]
        //public void AutentifikujKorisnika_ValidniPodaci_AutentifikacijaUspjesna()
        //{
        //    string korisnickoIme = "testKorisnik";
        //    string lozinka = "testLozinka";
        //    _authService.RegistrujKorisnika(korisnickoIme, lozinka);

        //    bool rezultat = _authService.AutentifikujKorisnika(korisnickoIme, lozinka);

        //    Assert.IsTrue(rezultat, "Autentifikacija nije uspjela za validne podatke.");
        //}

        //[TestMethod]
        //public void AutentifikujKorisnika_NevalidniPodaci_AutentifikacijaNeuspjesna()
        //{
        //    string korisnickoIme = "testKorisnik";
        //    string lozinka = "testLozinka";
        //    string pogresnaLozinka = "pogresnaLozinka";
        //    _authService.RegistrujKorisnika(korisnickoIme, lozinka);

        //    bool rezultat = _authService.AutentifikujKorisnika(korisnickoIme, pogresnaLozinka);

        //    Assert.IsFalse(rezultat, "Autentifikacija je uspjela sa pogrešnim podacima.");
        //}


        //[TestMethod]
        //public void AutentifikujKorisnika_KorisnikNePostoji_AutentifikacijaNeuspjesna()
        //{
        //    // Arrange
        //    string korisnickoIme = "nepostojeciKorisnik";
        //    string lozinka = "nekaLozinka";

        //    // Act
        //    bool rezultat = _authService.AutentifikujKorisnika(korisnickoIme, lozinka);

        //    // Assert
        //    Assert.IsFalse(rezultat, "Autentifikacija je uspela za nepostojećeg korisnika.");
        //}


        //[TestMethod]
        //public void HashLozinka_ReflectionTest()
        //{
        //    Type type = typeof(AuthenticationService);
        //    object authServiceInstance = Activator.CreateInstance(type);
        //    MethodInfo metoda = type.GetMethod("HashLozinka", BindingFlags.NonPublic | BindingFlags.Instance);

        //    string lozinka = "testLozinka";
        //    object[] parametri = { lozinka };

        //    string hash = (string)metoda.Invoke(authServiceInstance, parametri);

        //    Assert.IsNotNull(hash, "Hash nije generisan.");
        //    Assert.AreNotEqual(lozinka, hash, "Hash vrednost ne sme biti ista kao lozinka.");
        //}

    }
}