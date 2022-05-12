using NUnit.Framework;
using EloadasProject;
using System;

namespace TestEloadasProject
{
    public class Tests
    {
        Eloadas eloadas;
        Eloadas eloadas2;

        [SetUp]
        public void Setup()
        {
            eloadas = new Eloadas(20, 30);
            eloadas2 = new Eloadas(2, 2);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void Foglalas_ervenyes()
        {
            Assert.DoesNotThrow(() => eloadas.lefoglal());
        }
        //[Test]
        //public void Foglalas_ervenytelen()
        //{
        //    eloadas2.Foglalt(1, 1);
        //    //eloadas2.Foglalt(2, 1);
        //    //eloadas2.Foglalt(1, 2);
        //    //eloadas2.Foglalt(2, 2);
        //    Assert.Throws<NullReferenceException>(()=>eloadas2.lefoglal());
        //}
        [Test]
        public void SzabadHely()
        {
            Assert.DoesNotThrow(() => eloadas.SzabadHelyek());
        }
        [Test]
        public void SzabadHely_ures()
        {
            Assert.AreNotEqual(eloadas.Teli(), eloadas.SzabadHelyek());
        }

        [Test]
        public void Tele()
        {
            eloadas2.lefoglal();
            eloadas2.lefoglal();
            eloadas2.SzabadHelyek();
            Assert.IsTrue(eloadas2.Teli());
        }

        [Test]
        public void Tele_hamis()
        {
            Assert.IsFalse(eloadas.Teli());
        }
        [Test]
        public void Foglalt_ervenyes()
        {
            Assert.DoesNotThrow(() => eloadas.Foglalt(15, 20));
        }
        [Test]
        public void Foglalt_ervenyes_foglalt_hellyel()
        {
            Assert.IsFalse(eloadas.Foglalt(15, 20));
        }
        [Test]
        public void Foglalt_ervenytelen_negativErtek()
        {
            Assert.Throws<ArgumentException>(() => eloadas.Foglalt(-1, -1));
        }
        [Test]
        public void Foglalt_ervenytelen_magasabbErtek()
        {
            Assert.Throws<IndexOutOfRangeException>(() => eloadas.Foglalt(20, 40));
        }
    }
}