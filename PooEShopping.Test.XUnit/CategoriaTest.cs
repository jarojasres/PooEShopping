using PooEShopping.Models;
using System;
using Xunit;

namespace PooEShopping.Test.XUnit
{
    public class CategoriaTest
    {
        [Fact]
        public void IdMenorIgualCeroTest()
        {
            int newIdValue = -2;

            var categoria = new Categoria();

            Assert.Throws<ArgumentOutOfRangeException>(() => categoria.Id = newIdValue);
        }

        [Fact]
        public void IdNuloTest()
        {
            int? newIdValue = null;

            var categoria = new Categoria();

            Assert.Throws<ArgumentNullException>(() => categoria.Id = newIdValue);
        }

        [Fact]
        public void NombreVacioTest()
        {
            string newNameValue = string.Empty;

            var categoria = new Categoria();

            Assert.Throws<ArgumentException>(() => categoria.Nombre = newNameValue);
        }

        [Fact]
        public void NombreNuloTest()
        {
            string newNameValue = null;

            var categoria = new Categoria();

            Assert.Throws<ArgumentNullException>(() => categoria.Nombre = newNameValue);
        }

        [Fact]
        public void LongitudNombreMenorTresTest()
        {
            string newNameValue = "Na";

            var categoria = new Categoria();

            Assert.Throws<ArgumentException>(() => categoria.Nombre = newNameValue);
        }

        [Fact]
        public void CategoriaSinParametrosConstructorTest()
        {
            var categoria = new Categoria();

            Assert.Equal(categoria.Nombre, string.Empty);
        }
    }
}
