
using ImperaPlus.Domain.Map;

namespace ImperaPlus.DataAccess.ConvertedMaps
{
    public static partial class Maps
    {
        public static MapTemplate Polen()
        {

var mapTemplate = new MapTemplate("Polen") { Image = "polen.jpg" };
var country1 = new CountryTemplate("1", "Westpommern") { X = 158, Y = 105 };
mapTemplate.Countries.Add(country1);
var country2 = new CountryTemplate("2", "Pommern") { X = 264, Y = 69 };
mapTemplate.Countries.Add(country2);
var country3 = new CountryTemplate("3", "Ermland-Masuren") { X = 424, Y = 109 };
mapTemplate.Countries.Add(country3);
var country4 = new CountryTemplate("4", "Podlachien") { X = 498, Y = 166 };
mapTemplate.Countries.Add(country4);
var country5 = new CountryTemplate("5", "Masowien") { X = 399, Y = 228 };
mapTemplate.Countries.Add(country5);
var country6 = new CountryTemplate("6", "Kujawien-Pommern") { X = 305, Y = 161 };
mapTemplate.Countries.Add(country6);
var country7 = new CountryTemplate("7", "Grosspolen") { X = 221, Y = 239 };
mapTemplate.Countries.Add(country7);
var country8 = new CountryTemplate("8", "Lebus") { X = 97, Y = 214 };
mapTemplate.Countries.Add(country8);
var country9 = new CountryTemplate("9", "Niederschlesien") { X = 127, Y = 362 };
mapTemplate.Countries.Add(country9);
var country10 = new CountryTemplate("10", "Oppeln") { X = 215, Y = 412 };
mapTemplate.Countries.Add(country10);
var country11 = new CountryTemplate("11", "Schlesien") { X = 302, Y = 429 };
mapTemplate.Countries.Add(country11);
var country12 = new CountryTemplate("12", "Kleinpolen") { X = 403, Y = 467 };
mapTemplate.Countries.Add(country12);
var country13 = new CountryTemplate("13", "Karpatenvorland") { X = 466, Y = 473 };
mapTemplate.Countries.Add(country13);
var country14 = new CountryTemplate("14", "Lublin") { X = 547, Y = 379 };
mapTemplate.Countries.Add(country14);
var country15 = new CountryTemplate("15", "Heiligkreuz") { X = 388, Y = 391 };
mapTemplate.Countries.Add(country15);
var country16 = new CountryTemplate("16", "Lodsch") { X = 349, Y = 319 };
mapTemplate.Countries.Add(country16);
var continent1 = new Continent("1", 1);
continent1.Countries.Add(country3);
continent1.Countries.Add(country4);
mapTemplate.Continents.Add(continent1);
var continent2 = new Continent("2", 1);
continent2.Countries.Add(country13);
continent2.Countries.Add(country14);
mapTemplate.Continents.Add(continent2);
var continent3 = new Continent("3", 1);
continent3.Countries.Add(country5);
continent3.Countries.Add(country16);
mapTemplate.Continents.Add(continent3);
var continent4 = new Continent("4", 1);
continent4.Countries.Add(country8);
continent4.Countries.Add(country9);
mapTemplate.Continents.Add(continent4);
var continent5 = new Continent("5", 1);
continent5.Countries.Add(country6);
continent5.Countries.Add(country7);
mapTemplate.Continents.Add(continent5);
var continent6 = new Continent("6", 1);
continent6.Countries.Add(country10);
continent6.Countries.Add(country11);
mapTemplate.Continents.Add(continent6);
var continent7 = new Continent("7", 1);
continent7.Countries.Add(country1);
continent7.Countries.Add(country2);
mapTemplate.Continents.Add(continent7);
var continent8 = new Continent("8", 1);
continent8.Countries.Add(country12);
continent8.Countries.Add(country15);
mapTemplate.Continents.Add(continent8);
mapTemplate.Connections.Add(new Connection("1", "8"));
mapTemplate.Connections.Add(new Connection("1", "7"));
mapTemplate.Connections.Add(new Connection("1", "2"));
mapTemplate.Connections.Add(new Connection("2", "3"));
mapTemplate.Connections.Add(new Connection("2", "1"));
mapTemplate.Connections.Add(new Connection("2", "6"));
mapTemplate.Connections.Add(new Connection("2", "7"));
mapTemplate.Connections.Add(new Connection("3", "2"));
mapTemplate.Connections.Add(new Connection("3", "4"));
mapTemplate.Connections.Add(new Connection("3", "6"));
mapTemplate.Connections.Add(new Connection("3", "5"));
mapTemplate.Connections.Add(new Connection("4", "3"));
mapTemplate.Connections.Add(new Connection("4", "5"));
mapTemplate.Connections.Add(new Connection("4", "14"));
mapTemplate.Connections.Add(new Connection("5", "4"));
mapTemplate.Connections.Add(new Connection("5", "14"));
mapTemplate.Connections.Add(new Connection("5", "3"));
mapTemplate.Connections.Add(new Connection("5", "6"));
mapTemplate.Connections.Add(new Connection("5", "15"));
mapTemplate.Connections.Add(new Connection("5", "16"));
mapTemplate.Connections.Add(new Connection("6", "2"));
mapTemplate.Connections.Add(new Connection("6", "7"));
mapTemplate.Connections.Add(new Connection("6", "3"));
mapTemplate.Connections.Add(new Connection("6", "5"));
mapTemplate.Connections.Add(new Connection("6", "16"));
mapTemplate.Connections.Add(new Connection("7", "10"));
mapTemplate.Connections.Add(new Connection("7", "9"));
mapTemplate.Connections.Add(new Connection("7", "8"));
mapTemplate.Connections.Add(new Connection("7", "1"));
mapTemplate.Connections.Add(new Connection("7", "2"));
mapTemplate.Connections.Add(new Connection("7", "6"));
mapTemplate.Connections.Add(new Connection("7", "16"));
mapTemplate.Connections.Add(new Connection("8", "9"));
mapTemplate.Connections.Add(new Connection("8", "7"));
mapTemplate.Connections.Add(new Connection("8", "1"));
mapTemplate.Connections.Add(new Connection("9", "10"));
mapTemplate.Connections.Add(new Connection("9", "7"));
mapTemplate.Connections.Add(new Connection("9", "8"));
mapTemplate.Connections.Add(new Connection("10", "11"));
mapTemplate.Connections.Add(new Connection("10", "16"));
mapTemplate.Connections.Add(new Connection("10", "7"));
mapTemplate.Connections.Add(new Connection("10", "9"));
mapTemplate.Connections.Add(new Connection("11", "12"));
mapTemplate.Connections.Add(new Connection("11", "15"));
mapTemplate.Connections.Add(new Connection("11", "16"));
mapTemplate.Connections.Add(new Connection("11", "10"));
mapTemplate.Connections.Add(new Connection("12", "13"));
mapTemplate.Connections.Add(new Connection("12", "15"));
mapTemplate.Connections.Add(new Connection("12", "11"));
mapTemplate.Connections.Add(new Connection("13", "14"));
mapTemplate.Connections.Add(new Connection("13", "15"));
mapTemplate.Connections.Add(new Connection("13", "12"));
mapTemplate.Connections.Add(new Connection("14", "4"));
mapTemplate.Connections.Add(new Connection("14", "5"));
mapTemplate.Connections.Add(new Connection("14", "15"));
mapTemplate.Connections.Add(new Connection("14", "13"));
mapTemplate.Connections.Add(new Connection("15", "14"));
mapTemplate.Connections.Add(new Connection("15", "13"));
mapTemplate.Connections.Add(new Connection("15", "12"));
mapTemplate.Connections.Add(new Connection("15", "11"));
mapTemplate.Connections.Add(new Connection("15", "5"));
mapTemplate.Connections.Add(new Connection("15", "16"));
mapTemplate.Connections.Add(new Connection("16", "11"));
mapTemplate.Connections.Add(new Connection("16", "10"));
mapTemplate.Connections.Add(new Connection("16", "15"));
mapTemplate.Connections.Add(new Connection("16", "7"));
mapTemplate.Connections.Add(new Connection("16", "6"));
mapTemplate.Connections.Add(new Connection("16", "5"));

            return mapTemplate;
		}
    }
}

