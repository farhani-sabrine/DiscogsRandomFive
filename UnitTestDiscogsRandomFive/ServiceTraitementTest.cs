using DiscogsRandomFive.Exceptions;
using DiscogsRandomFive.Model;
using DiscogsRandomFive.Services.Implementations;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace UnitTestDiscogsRandomFive
{
    [TestClass]
    public class ServiceTraitementTest
    {
       CollectionRelease colRelease;
        ServiceTraitement serviceTrait;

        [TestInitialize]
        public void TestInitialize()
        {
           var listeRelease = new List<Release>();
            for(int i=0; i < 5; i++)
            {
                var release = new Release()
                {
                    InstanceId = i,
                    DateAdded = DateTime.Now,
                    BasicInformation=null,
                    Id=i,
                    Rating=i
                };
                listeRelease.Add(release);
            }
            colRelease = new CollectionRelease()
            {
                Releases = listeRelease,
                Paginations = null
            };

             serviceTrait = new ServiceTraitement();
        }

        [TestMethod]
        public void GetReleaseByNumber_NombreDisqueEntreUnEtCinq_Vrai()
        {

            //Arrange
            //creation des variable pour le test
          


            for (sbyte nombre=1; nombre<=5; nombre++) {
                //Act
                var resultat = serviceTrait.GetReleaseByNumber(nombre, colRelease);

            //Assert
            //retourne vrai si le nombre de collection est entre 1 et 5
            Assert.IsTrue(resultat.Count == nombre);
            }
        }

        [TestMethod]
        public void GetReleaseByNumber_ComparerDeuxDisquesAleatoire_Vrai()
        {
            //Arrange
            //creation des variable pour le test
            sbyte numberRelease = 1;

            //Act
            var res1= serviceTrait.GetReleaseByNumber(numberRelease, colRelease);
            var res2 = serviceTrait.GetReleaseByNumber(numberRelease, colRelease);

            //Assert
            CollectionAssert.AreNotEqual(res1,res2);
        }

        [TestMethod]
        public void GetReleaseByNumber_NombreDisqueInferieurAUn_ExceptionLevee()
        {

            //Arrange
            //creation des variable pour le test
            sbyte numberRelease =- 1;

                //Act
                Action invocation = () => serviceTrait.GetReleaseByNumber(numberRelease, colRelease);


                // resultat = serviceTrait.GetReleaseByNumber(nombre, Release.GetCollectionRealease()

                //Act
                //leve l'execption InvalidNumberException si le nombre negative ou egale a zero
               Assert.ThrowsException<InvalidNumberException>(invocation);
            
        }

        [TestMethod]
        public void GetReleaseByNumber_NombreDisqueSuperieurACinq_ExceptionLevee()
        {

            //Arrange
            //creation des variable pour le test
            sbyte numberRelease = 6;

            //Act
            Action invocation = () => serviceTrait.GetReleaseByNumber(numberRelease, colRelease);


            // resultat = serviceTrait.GetReleaseByNumber(nombre, Release.GetCollectionRealease()

            //Act
            //leve l'execption InvalidNumberException si le nombre negative ou egale a zero
            Assert.ThrowsException<InvalidNumberException>(invocation);

        }
    }

}

   
