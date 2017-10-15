
using ImperaPlus.Domain.Map;

namespace ImperaPlus.DataAccess.ConvertedMaps
{
    public static partial class Maps
    {
        public static MapTemplate Imperaolympiade()
        {

var mapTemplate = new MapTemplate("Imperaolympiade") { Image = "imperaolympiade.jpg" };
var country1 = new CountryTemplate("1", "Berlin") { X = 49, Y = 187 };
mapTemplate.Countries.Add(country1);
var country2 = new CountryTemplate("2", "London") { X = 220, Y = 155 };
mapTemplate.Countries.Add(country2);
var country3 = new CountryTemplate("3", "Madrid") { X = 42, Y = 367 };
mapTemplate.Countries.Add(country3);
var country4 = new CountryTemplate("4", "Istanbul") { X = 187, Y = 420 };
mapTemplate.Countries.Add(country4);
var country5 = new CountryTemplate("5", "Moskau") { X = 297, Y = 284 };
mapTemplate.Countries.Add(country5);
var country6 = new CountryTemplate("6", "Rom") { X = 270, Y = 364 };
mapTemplate.Countries.Add(country6);
var country7 = new CountryTemplate("7", "Lagos") { X = 407, Y = 177 };
mapTemplate.Countries.Add(country7);
var country8 = new CountryTemplate("8", "Khartum") { X = 595, Y = 176 };
mapTemplate.Countries.Add(country8);
var country9 = new CountryTemplate("9", "Johannesburg") { X = 642, Y = 283 };
mapTemplate.Countries.Add(country9);
var country10 = new CountryTemplate("10", "Sydney") { X = 532, Y = 419 };
mapTemplate.Countries.Add(country10);
var country11 = new CountryTemplate("11", "Bombay") { X = 469, Y = 418 };
mapTemplate.Countries.Add(country11);
var country12 = new CountryTemplate("12", "Kairo") { X = 359, Y = 285 };
mapTemplate.Countries.Add(country12);
var country13 = new CountryTemplate("13", "LosAngeles") { X = 782, Y = 156 };
mapTemplate.Countries.Add(country13);
var country14 = new CountryTemplate("14", "SaoPaulo") { X = 956, Y = 193 };
mapTemplate.Countries.Add(country14);
var country15 = new CountryTemplate("15", "NewYork") { X = 950, Y = 376 };
mapTemplate.Countries.Add(country15);
var country16 = new CountryTemplate("16", "Perth") { X = 815, Y = 419 };
mapTemplate.Countries.Add(country16);
var country17 = new CountryTemplate("17", "Mexiko") { X = 737, Y = 372 };
mapTemplate.Countries.Add(country17);
var country18 = new CountryTemplate("18", "Chicago") { X = 704, Y = 285 };
mapTemplate.Countries.Add(country18);
var country19 = new CountryTemplate("19", "Tokio") { X = 239, Y = 532 };
mapTemplate.Countries.Add(country19);
var country20 = new CountryTemplate("20", "Seoul") { X = 414, Y = 535 };
mapTemplate.Countries.Add(country20);
var country21 = new CountryTemplate("21", "Melbourne") { X = 586, Y = 534 };
mapTemplate.Countries.Add(country21);
var country22 = new CountryTemplate("22", "Brisbane") { X = 761, Y = 533 };
mapTemplate.Countries.Add(country22);
var continent1 = new Continent("1", 2);
continent1.Countries.Add(country1);
continent1.Countries.Add(country2);
continent1.Countries.Add(country3);
continent1.Countries.Add(country4);
continent1.Countries.Add(country5);
continent1.Countries.Add(country6);
mapTemplate.Continents.Add(continent1);
var continent2 = new Continent("2", 2);
continent2.Countries.Add(country13);
continent2.Countries.Add(country14);
continent2.Countries.Add(country15);
continent2.Countries.Add(country16);
continent2.Countries.Add(country17);
continent2.Countries.Add(country18);
mapTemplate.Continents.Add(continent2);
var continent3 = new Continent("3", 4);
continent3.Countries.Add(country7);
continent3.Countries.Add(country8);
continent3.Countries.Add(country9);
continent3.Countries.Add(country10);
continent3.Countries.Add(country11);
continent3.Countries.Add(country12);
mapTemplate.Continents.Add(continent3);
var continent4 = new Continent("4", 4);
continent4.Countries.Add(country19);
continent4.Countries.Add(country20);
continent4.Countries.Add(country4);
continent4.Countries.Add(country5);
continent4.Countries.Add(country12);
continent4.Countries.Add(country11);
mapTemplate.Continents.Add(continent4);
var continent5 = new Continent("5", 4);
continent5.Countries.Add(country21);
continent5.Countries.Add(country22);
continent5.Countries.Add(country10);
continent5.Countries.Add(country9);
continent5.Countries.Add(country18);
continent5.Countries.Add(country16);
mapTemplate.Continents.Add(continent5);
mapTemplate.Connections.Add(new Connection("1", "2"));
mapTemplate.Connections.Add(new Connection("2", "5"));
mapTemplate.Connections.Add(new Connection("3", "1"));
mapTemplate.Connections.Add(new Connection("4", "3"));
mapTemplate.Connections.Add(new Connection("4", "5"));
mapTemplate.Connections.Add(new Connection("5", "6"));
mapTemplate.Connections.Add(new Connection("5", "12"));
mapTemplate.Connections.Add(new Connection("6", "4"));
mapTemplate.Connections.Add(new Connection("7", "8"));
mapTemplate.Connections.Add(new Connection("8", "9"));
mapTemplate.Connections.Add(new Connection("9", "10"));
mapTemplate.Connections.Add(new Connection("9", "18"));
mapTemplate.Connections.Add(new Connection("10", "11"));
mapTemplate.Connections.Add(new Connection("10", "9"));
mapTemplate.Connections.Add(new Connection("11", "20"));
mapTemplate.Connections.Add(new Connection("11", "12"));
mapTemplate.Connections.Add(new Connection("12", "11"));
mapTemplate.Connections.Add(new Connection("12", "7"));
mapTemplate.Connections.Add(new Connection("13", "14"));
mapTemplate.Connections.Add(new Connection("14", "15"));
mapTemplate.Connections.Add(new Connection("15", "16"));
mapTemplate.Connections.Add(new Connection("16", "17"));
mapTemplate.Connections.Add(new Connection("16", "22"));
mapTemplate.Connections.Add(new Connection("17", "18"));
mapTemplate.Connections.Add(new Connection("18", "13"));
mapTemplate.Connections.Add(new Connection("18", "16"));
mapTemplate.Connections.Add(new Connection("19", "4"));
mapTemplate.Connections.Add(new Connection("20", "19"));
mapTemplate.Connections.Add(new Connection("21", "10"));
mapTemplate.Connections.Add(new Connection("22", "21"));

            return mapTemplate;
		}
    }
}

