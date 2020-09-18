using NUnit.Framework;
using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup ()
        {
            Person john = new Person ("", "1.234.567-2");
            Person toto = new Person ("Jane Doe", "8.765.432-");
        }

        [Test]
        public void idValido ()
        {
            string idValido = "4.827.407-3";
            Person test = new Person ("", idValido);
            Assert.AreEqual (idValido, test.ID);
        }

        [Test]
        public void idInvalido ()
        {
            string idInvalido = "123456789";
            Person test = new Person ("", idInvalido);
            Assert.AreEqual (null, test.ID);
        }

        [Test]
        public void nombreValido () 
        {
            string nombreValido = "Albert";
            Person test = new Person (nombreValido, "");
            Assert.AreEqual (nombreValido, test.Name);
        }

        [Test]
        public void nombreInvalido ()
        {
            string nombreInvalido = "";
            Person test = new Person (nombreInvalido, "");
            Assert.AreEqual (null, test.Name);
        }

    }
}