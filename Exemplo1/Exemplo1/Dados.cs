using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Exemplo1
{
    public class Dados : IEquatable<Imovel>, IComparable<Imovel>
    {
        public static IList<Imovel> ListaImovel { get; private set; }
        static Dados()
        {
            var lista = new List<Imovel>();
            lista.Add(new Imovel() { Tipo = "Casa", Bairro = "Centro" });
            lista.Add(new Imovel() { Tipo = "Apartamento", Bairro = "Campolim" });
            lista.Add(new Imovel() { Tipo = "Terreno", Bairro = "Trujilo" });
            lista.Add(new Imovel() { Tipo = "Casa", Bairro = "Central Park" });
            lista.Add(new Imovel() { Tipo = "Terreno", Bairro = "Parque Três Meninos" });
            lista.Add(new Imovel() { Tipo = "Casa1", Bairro = "Centro" });
            lista.Add(new Imovel() { Tipo = "Apartamento", Bairro = "Campolim" });
            lista.Add(new Imovel() { Tipo = "Terreno", Bairro = "Trujilo" });
            lista.Add(new Imovel() { Tipo = "Casa", Bairro = "Central Park" });
            lista.Add(new Imovel() { Tipo = "Terreno", Bairro = "Parque Três Meninos" });
            lista.Add(new Imovel() { Tipo = "Casa2", Bairro = "Centro" });
            lista.Add(new Imovel() { Tipo = "Apartamento", Bairro = "Campolim" });
            lista.Add(new Imovel() { Tipo = "Terreno", Bairro = "Trujilo" });
            lista.Add(new Imovel() { Tipo = "Casa", Bairro = "Central Park" });
            lista.Add(new Imovel() { Tipo = "Terreno", Bairro = "Parque Três Meninos" });
            lista.Add(new Imovel() { Tipo = "Casa3", Bairro = "Centro" });
            lista.Add(new Imovel() { Tipo = "Apartamento", Bairro = "Campolim" });
            lista.Add(new Imovel() { Tipo = "Terreno", Bairro = "Trujilo" });
            lista.Add(new Imovel() { Tipo = "Casa", Bairro = "Central Park" });
            lista.Add(new Imovel() { Tipo = "Terreno", Bairro = "Parque Três Meninos" });
            lista.Add(new Imovel() { Tipo = "Casa4", Bairro = "Centro" });
            lista.Add(new Imovel() { Tipo = "Apartamento", Bairro = "Campolim" });
            lista.Add(new Imovel() { Tipo = "Terreno", Bairro = "Trujilo" });
            lista.Add(new Imovel() { Tipo = "Casa", Bairro = "Central Park" });
            lista.Add(new Imovel() { Tipo = "Terreno", Bairro = "Parque Três Meninos" });
            lista.Add(new Imovel() { Tipo = "Casa5", Bairro = "Centro" });
            lista.Add(new Imovel() { Tipo = "Apartamento", Bairro = "Campolim" });
            lista.Add(new Imovel() { Tipo = "Terreno", Bairro = "Trujilo" });
            lista.Add(new Imovel() { Tipo = "Casa", Bairro = "Central Park" });
            lista.Add(new Imovel() { Tipo = "Terreno", Bairro = "Parque Três Meninos" });
            lista.Add(new Imovel() { Tipo = "Casa6", Bairro = "Centro" });
            lista.Add(new Imovel() { Tipo = "Apartamento", Bairro = "Campolim" });
            lista.Add(new Imovel() { Tipo = "Terreno", Bairro = "Trujilo" });
            lista.Add(new Imovel() { Tipo = "Casa", Bairro = "Central Park" });
            lista.Add(new Imovel() { Tipo = "Terreno", Bairro = "Parque Três Meninos" });
            ListaImovel = lista;
        }

        public bool Equals(Imovel other)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Imovel other)
        {
            throw new NotImplementedException();
        }
    }
}
