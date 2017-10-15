
using ImperaPlus.Domain.Map;

namespace ImperaPlus.DataAccess.ConvertedMaps
{
    public static partial class Maps
    {
        public static MapTemplate Deutschland()
        {

var mapTemplate = new MapTemplate("Deutschland") { Image = "deutsch1.jpg" };
var country1 = new CountryTemplate("1", "Schleswig-Holstein") { X = 180, Y = 60 };
mapTemplate.Countries.Add(country1);
var country2 = new CountryTemplate("2", "Mecklenburg-Vorpommern") { X = 320, Y = 110 };
mapTemplate.Countries.Add(country2);
var country3 = new CountryTemplate("3", "Hamburg") { X = 200, Y = 109 };
mapTemplate.Countries.Add(country3);
var country4 = new CountryTemplate("4", "Niedersachsen") { X = 200, Y = 200 };
mapTemplate.Countries.Add(country4);
var country5 = new CountryTemplate("5", "Bremen") { X = 135, Y = 148 };
mapTemplate.Countries.Add(country5);
var country6 = new CountryTemplate("6", "Berlin") { X = 360, Y = 195 };
mapTemplate.Countries.Add(country6);
var country7 = new CountryTemplate("7", "Brandenburg") { X = 400, Y = 240 };
mapTemplate.Countries.Add(country7);
var country8 = new CountryTemplate("8", "Sachsen-Anhalt") { X = 290, Y = 260 };
mapTemplate.Countries.Add(country8);
var country9 = new CountryTemplate("9", "Thueringen") { X = 250, Y = 345 };
mapTemplate.Countries.Add(country9);
var country10 = new CountryTemplate("10", "Sachsen") { X = 360, Y = 330 };
mapTemplate.Countries.Add(country10);
var country11 = new CountryTemplate("11", "Hessen") { X = 150, Y = 350 };
mapTemplate.Countries.Add(country11);
var country12 = new CountryTemplate("12", "Nordrhein-Westfalen") { X = 95, Y = 277 };
mapTemplate.Countries.Add(country12);
var country13 = new CountryTemplate("13", "Rheinland-Pfalz") { X = 63, Y = 410 };
mapTemplate.Countries.Add(country13);
var country14 = new CountryTemplate("14", "Saarland") { X = 40, Y = 453 };
mapTemplate.Countries.Add(country14);
var country15 = new CountryTemplate("15", "Nord-Bayern") { X = 280, Y = 450 };
mapTemplate.Countries.Add(country15);
var country16 = new CountryTemplate("16", "Nord-Baden_Wuerttemberg") { X = 183, Y = 484 };
mapTemplate.Countries.Add(country16);
var country17 = new CountryTemplate("17", "Sued-Baden_Wuerttemberg") { X = 165, Y = 560 };
mapTemplate.Countries.Add(country17);
var country18 = new CountryTemplate("18", "Sued-Bayern") { X = 283, Y = 560 };
mapTemplate.Countries.Add(country18);
var continent1 = new Continent("1", 2);
continent1.Countries.Add(country15);
continent1.Countries.Add(country16);
continent1.Countries.Add(country17);
continent1.Countries.Add(country18);
mapTemplate.Continents.Add(continent1);
var continent2 = new Continent("2", 2);
continent2.Countries.Add(country11);
continent2.Countries.Add(country12);
continent2.Countries.Add(country13);
continent2.Countries.Add(country14);
mapTemplate.Continents.Add(continent2);
var continent3 = new Continent("3", 3);
continent3.Countries.Add(country6);
continent3.Countries.Add(country7);
continent3.Countries.Add(country8);
continent3.Countries.Add(country9);
continent3.Countries.Add(country10);
mapTemplate.Continents.Add(continent3);
var continent4 = new Continent("4", 3);
continent4.Countries.Add(country1);
continent4.Countries.Add(country2);
continent4.Countries.Add(country3);
continent4.Countries.Add(country4);
continent4.Countries.Add(country5);
mapTemplate.Continents.Add(continent4);
mapTemplate.Connections.Add(new Connection("1", "2"));
mapTemplate.Connections.Add(new Connection("1", "3"));
mapTemplate.Connections.Add(new Connection("1", "4"));
mapTemplate.Connections.Add(new Connection("2", "1"));
mapTemplate.Connections.Add(new Connection("2", "4"));
mapTemplate.Connections.Add(new Connection("2", "7"));
mapTemplate.Connections.Add(new Connection("3", "1"));
mapTemplate.Connections.Add(new Connection("3", "4"));
mapTemplate.Connections.Add(new Connection("4", "12"));
mapTemplate.Connections.Add(new Connection("4", "11"));
mapTemplate.Connections.Add(new Connection("4", "9"));
mapTemplate.Connections.Add(new Connection("4", "8"));
mapTemplate.Connections.Add(new Connection("4", "7"));
mapTemplate.Connections.Add(new Connection("4", "1"));
mapTemplate.Connections.Add(new Connection("4", "2"));
mapTemplate.Connections.Add(new Connection("4", "3"));
mapTemplate.Connections.Add(new Connection("4", "5"));
mapTemplate.Connections.Add(new Connection("5", "4"));
mapTemplate.Connections.Add(new Connection("6", "7"));
mapTemplate.Connections.Add(new Connection("7", "6"));
mapTemplate.Connections.Add(new Connection("7", "2"));
mapTemplate.Connections.Add(new Connection("7", "4"));
mapTemplate.Connections.Add(new Connection("7", "8"));
mapTemplate.Connections.Add(new Connection("7", "10"));
mapTemplate.Connections.Add(new Connection("8", "7"));
mapTemplate.Connections.Add(new Connection("8", "10"));
mapTemplate.Connections.Add(new Connection("8", "9"));
mapTemplate.Connections.Add(new Connection("8", "4"));
mapTemplate.Connections.Add(new Connection("9", "4"));
mapTemplate.Connections.Add(new Connection("9", "8"));
mapTemplate.Connections.Add(new Connection("9", "10"));
mapTemplate.Connections.Add(new Connection("9", "11"));
mapTemplate.Connections.Add(new Connection("9", "15"));
mapTemplate.Connections.Add(new Connection("10", "7"));
mapTemplate.Connections.Add(new Connection("10", "8"));
mapTemplate.Connections.Add(new Connection("10", "9"));
mapTemplate.Connections.Add(new Connection("10", "15"));
mapTemplate.Connections.Add(new Connection("11", "4"));
mapTemplate.Connections.Add(new Connection("11", "12"));
mapTemplate.Connections.Add(new Connection("11", "13"));
mapTemplate.Connections.Add(new Connection("11", "16"));
mapTemplate.Connections.Add(new Connection("11", "15"));
mapTemplate.Connections.Add(new Connection("11", "9"));
mapTemplate.Connections.Add(new Connection("12", "4"));
mapTemplate.Connections.Add(new Connection("12", "11"));
mapTemplate.Connections.Add(new Connection("12", "13"));
mapTemplate.Connections.Add(new Connection("13", "12"));
mapTemplate.Connections.Add(new Connection("13", "14"));
mapTemplate.Connections.Add(new Connection("13", "11"));
mapTemplate.Connections.Add(new Connection("13", "16"));
mapTemplate.Connections.Add(new Connection("14", "13"));
mapTemplate.Connections.Add(new Connection("15", "18"));
mapTemplate.Connections.Add(new Connection("15", "16"));
mapTemplate.Connections.Add(new Connection("15", "9"));
mapTemplate.Connections.Add(new Connection("15", "10"));
mapTemplate.Connections.Add(new Connection("15", "11"));
mapTemplate.Connections.Add(new Connection("16", "17"));
mapTemplate.Connections.Add(new Connection("16", "13"));
mapTemplate.Connections.Add(new Connection("16", "15"));
mapTemplate.Connections.Add(new Connection("16", "18"));
mapTemplate.Connections.Add(new Connection("16", "11"));
mapTemplate.Connections.Add(new Connection("17", "16"));
mapTemplate.Connections.Add(new Connection("17", "18"));
mapTemplate.Connections.Add(new Connection("18", "17"));
mapTemplate.Connections.Add(new Connection("18", "16"));
mapTemplate.Connections.Add(new Connection("18", "15"));

            return mapTemplate;
		}
    }
}

