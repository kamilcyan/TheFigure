using ConsoleApp11;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ObjectTest()
        {
            var expected = true;

            List<Punkt> wierzcholki = new List<Punkt>();
            wierzcholki.Add(new Punkt { X = 5.0, Y = 2.9 });
            wierzcholki.Add(new Punkt { X = 2.2, Y = 4.55 });
            wierzcholki.Add(new Punkt { X = 9.2, Y = 0.55 });
            wierzcholki.Add(new Punkt { X = 2.7, Y = 3.33 });
            
            var fig = new Figura(wierzcholki);

            //Assert.AreEqual(expected, fig.DoesContain);
        }

        [Test]
        public void MiddleTest()
        {
            var expected = true;

            List<Punkt> wierzcholki = new List<Punkt>();
            wierzcholki.Add(new Punkt { X = 5.0, Y = 2.9 });
            wierzcholki.Add(new Punkt { X = 2.2, Y = 4.55 });
            wierzcholki.Add(new Punkt { X = 9.2, Y = 0.55 });
            wierzcholki.Add(new Punkt { X = 2.7, Y = 3.33 });

            var fig = new Figura(wierzcholki);
            

            Assert.AreEqual(expected, fig.DoesContains(point));

        }
    }
}