using NUnit.Framework;
using UnitTestAndDebug;

namespace Tests
{
    public class PersonTests
    {
       [SetUp]
        public void Setup()
        {
            username = new IsNullOrEmpty("Ricardo");
            cedula = new IsValid(5280242);
        }

        [Test]
        public void IntroduceYourself()
        {
            string name = username.IsNullOrEmpty("");
            int id = cedula.IsValid();
        }
    }
}