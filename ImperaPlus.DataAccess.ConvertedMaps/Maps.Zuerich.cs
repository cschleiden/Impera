
using ImperaPlus.Domain.Map;

namespace ImperaPlus.DataAccess.ConvertedMaps
{
    public static partial class Maps
    {
        public static MapTemplate Zuerich()
        {

var mapTemplate = new MapTemplate("Zuerich") { Image = "zuerich.jpg" };
var country1 = new CountryTemplate("1", "Rathaus") { X = 746, Y = 601 };
mapTemplate.Countries.Add(country1);
var country2 = new CountryTemplate("2", "City") { X = 783, Y = 632 };
mapTemplate.Countries.Add(country2);
var country3 = new CountryTemplate("3", "Wollishofen") { X = 664, Y = 930 };
mapTemplate.Countries.Add(country3);
var country4 = new CountryTemplate("4", "Enge") { X = 671, Y = 732 };
mapTemplate.Countries.Add(country4);
var country5 = new CountryTemplate("5", "Leimbach") { X = 540, Y = 931 };
mapTemplate.Countries.Add(country5);
var country6 = new CountryTemplate("6", "Friesenberg") { X = 487, Y = 798 };
mapTemplate.Countries.Add(country6);
var country7 = new CountryTemplate("7", "Altwiedikon") { X = 593, Y = 717 };
mapTemplate.Countries.Add(country7);
var country8 = new CountryTemplate("8", "Sihlfeld") { X = 522, Y = 554 };
mapTemplate.Countries.Add(country8);
var country9 = new CountryTemplate("9", "Werd") { X = 648, Y = 602 };
mapTemplate.Countries.Add(country9);
var country10 = new CountryTemplate("10", "Langstrasse") { X = 653, Y = 551 };
mapTemplate.Countries.Add(country10);
var country11 = new CountryTemplate("11", "Hard") { X = 549, Y = 518 };
mapTemplate.Countries.Add(country11);
var country12 = new CountryTemplate("12", "Gewerbeschule") { X = 705, Y = 500 };
mapTemplate.Countries.Add(country12);
var country13 = new CountryTemplate("13", "Escher Wyss") { X = 604, Y = 419 };
mapTemplate.Countries.Add(country13);
var country14 = new CountryTemplate("14", "Oberstrass") { X = 804, Y = 439 };
mapTemplate.Countries.Add(country14);
var country15 = new CountryTemplate("15", "Unterstrass") { X = 729, Y = 409 };
mapTemplate.Countries.Add(country15);
var country16 = new CountryTemplate("16", "Witikon") { X = 1115, Y = 721 };
mapTemplate.Countries.Add(country16);
var country17 = new CountryTemplate("17", "Hirsladen") { X = 929, Y = 671 };
mapTemplate.Countries.Add(country17);
var country18 = new CountryTemplate("18", "Hottingen") { X = 902, Y = 593 };
mapTemplate.Countries.Add(country18);
var country19 = new CountryTemplate("19", "Fluntern") { X = 873, Y = 513 };
mapTemplate.Countries.Add(country19);
var country20 = new CountryTemplate("20", "Weinegg") { X = 918, Y = 753 };
mapTemplate.Countries.Add(country20);
var country21 = new CountryTemplate("21", "Mühlebach") { X = 807, Y = 663 };
mapTemplate.Countries.Add(country21);
var country22 = new CountryTemplate("22", "Seefeld") { X = 810, Y = 732 };
mapTemplate.Countries.Add(country22);
var country23 = new CountryTemplate("23", "Albisrieden") { X = 364, Y = 633 };
mapTemplate.Countries.Add(country23);
var country24 = new CountryTemplate("24", "Altstetten") { X = 330, Y = 474 };
mapTemplate.Countries.Add(country24);
var country25 = new CountryTemplate("25", "Höngg") { X = 460, Y = 284 };
mapTemplate.Countries.Add(country25);
var country26 = new CountryTemplate("26", "Wipkingen") { X = 623, Y = 365 };
mapTemplate.Countries.Add(country26);
var country27 = new CountryTemplate("27", "Affoltern") { X = 519, Y = 149 };
mapTemplate.Countries.Add(country27);
var country28 = new CountryTemplate("28", "Seebach") { X = 734, Y = 137 };
mapTemplate.Countries.Add(country28);
var country29 = new CountryTemplate("29", "Oerlikon") { X = 772, Y = 266 };
mapTemplate.Countries.Add(country29);
var country30 = new CountryTemplate("30", "Saatlen") { X = 886, Y = 223 };
mapTemplate.Countries.Add(country30);
var country31 = new CountryTemplate("31", "Schwamendingen Mitte") { X = 898, Y = 353 };
mapTemplate.Countries.Add(country31);
var country32 = new CountryTemplate("32", "Hirzenbach") { X = 1004, Y = 363 };
mapTemplate.Countries.Add(country32);
var country33 = new CountryTemplate("33", "Tankstelle") { X = 1203, Y = 294 };
mapTemplate.Countries.Add(country33);
var country34 = new CountryTemplate("34", "Restaurant") { X = 1207, Y = 409 };
mapTemplate.Countries.Add(country34);
var country35 = new CountryTemplate("35", "Shoppingcenter") { X = 1210, Y = 530 };
mapTemplate.Countries.Add(country35);
var continent1 = new Continent("1", 1);
continent1.Countries.Add(country1);
continent1.Countries.Add(country2);
mapTemplate.Continents.Add(continent1);
var continent2 = new Continent("2", 2);
continent2.Countries.Add(country3);
continent2.Countries.Add(country4);
continent2.Countries.Add(country5);
mapTemplate.Continents.Add(continent2);
var continent3 = new Continent("3", 2);
continent3.Countries.Add(country6);
continent3.Countries.Add(country7);
continent3.Countries.Add(country8);
mapTemplate.Continents.Add(continent3);
var continent4 = new Continent("4", 2);
continent4.Countries.Add(country9);
continent4.Countries.Add(country10);
continent4.Countries.Add(country11);
mapTemplate.Continents.Add(continent4);
var continent5 = new Continent("5", 1);
continent5.Countries.Add(country12);
continent5.Countries.Add(country13);
mapTemplate.Continents.Add(continent5);
var continent6 = new Continent("6", 1);
continent6.Countries.Add(country14);
continent6.Countries.Add(country15);
mapTemplate.Continents.Add(continent6);
var continent7 = new Continent("7", 3);
continent7.Countries.Add(country16);
continent7.Countries.Add(country17);
continent7.Countries.Add(country18);
continent7.Countries.Add(country19);
mapTemplate.Continents.Add(continent7);
var continent8 = new Continent("8", 2);
continent8.Countries.Add(country20);
continent8.Countries.Add(country21);
continent8.Countries.Add(country22);
mapTemplate.Continents.Add(continent8);
var continent9 = new Continent("9", 1);
continent9.Countries.Add(country23);
continent9.Countries.Add(country24);
mapTemplate.Continents.Add(continent9);
var continent10 = new Continent("10", 1);
continent10.Countries.Add(country25);
continent10.Countries.Add(country26);
mapTemplate.Continents.Add(continent10);
var continent11 = new Continent("11", 2);
continent11.Countries.Add(country27);
continent11.Countries.Add(country28);
continent11.Countries.Add(country29);
mapTemplate.Continents.Add(continent11);
var continent12 = new Continent("12", 2);
continent12.Countries.Add(country30);
continent12.Countries.Add(country31);
continent12.Countries.Add(country32);
mapTemplate.Continents.Add(continent12);
var continent13 = new Continent("13", 1);
continent13.Countries.Add(country33);
mapTemplate.Continents.Add(continent13);
var continent14 = new Continent("14", 1);
continent14.Countries.Add(country34);
mapTemplate.Continents.Add(continent14);
var continent15 = new Continent("15", 1);
continent15.Countries.Add(country35);
mapTemplate.Continents.Add(continent15);
mapTemplate.Connections.Add(new Connection("1", "2"));
mapTemplate.Connections.Add(new Connection("2", "4"));
mapTemplate.Connections.Add(new Connection("2", "1"));
mapTemplate.Connections.Add(new Connection("2", "22"));
mapTemplate.Connections.Add(new Connection("2", "21"));
mapTemplate.Connections.Add(new Connection("2", "18"));
mapTemplate.Connections.Add(new Connection("2", "19"));
mapTemplate.Connections.Add(new Connection("2", "14"));
mapTemplate.Connections.Add(new Connection("2", "15"));
mapTemplate.Connections.Add(new Connection("3", "5"));
mapTemplate.Connections.Add(new Connection("3", "4"));
mapTemplate.Connections.Add(new Connection("3", "22"));
mapTemplate.Connections.Add(new Connection("3", "15"));
mapTemplate.Connections.Add(new Connection("3", "31"));
mapTemplate.Connections.Add(new Connection("3", "28"));
mapTemplate.Connections.Add(new Connection("3", "27"));
mapTemplate.Connections.Add(new Connection("3", "24"));
mapTemplate.Connections.Add(new Connection("3", "34"));
mapTemplate.Connections.Add(new Connection("3", "35"));
mapTemplate.Connections.Add(new Connection("3", "33"));
mapTemplate.Connections.Add(new Connection("4", "7"));
mapTemplate.Connections.Add(new Connection("4", "3"));
mapTemplate.Connections.Add(new Connection("4", "2"));
mapTemplate.Connections.Add(new Connection("5", "3"));
mapTemplate.Connections.Add(new Connection("5", "6"));
mapTemplate.Connections.Add(new Connection("6", "5"));
mapTemplate.Connections.Add(new Connection("6", "7"));
mapTemplate.Connections.Add(new Connection("6", "23"));
mapTemplate.Connections.Add(new Connection("6", "8"));
mapTemplate.Connections.Add(new Connection("7", "6"));
mapTemplate.Connections.Add(new Connection("7", "4"));
mapTemplate.Connections.Add(new Connection("7", "8"));
mapTemplate.Connections.Add(new Connection("8", "6"));
mapTemplate.Connections.Add(new Connection("8", "7"));
mapTemplate.Connections.Add(new Connection("8", "11"));
mapTemplate.Connections.Add(new Connection("8", "10"));
mapTemplate.Connections.Add(new Connection("8", "9"));
mapTemplate.Connections.Add(new Connection("8", "23"));
mapTemplate.Connections.Add(new Connection("8", "24"));
mapTemplate.Connections.Add(new Connection("9", "8"));
mapTemplate.Connections.Add(new Connection("9", "10"));
mapTemplate.Connections.Add(new Connection("10", "12"));
mapTemplate.Connections.Add(new Connection("10", "8"));
mapTemplate.Connections.Add(new Connection("10", "9"));
mapTemplate.Connections.Add(new Connection("10", "11"));
mapTemplate.Connections.Add(new Connection("10", "13"));
mapTemplate.Connections.Add(new Connection("11", "24"));
mapTemplate.Connections.Add(new Connection("11", "8"));
mapTemplate.Connections.Add(new Connection("11", "13"));
mapTemplate.Connections.Add(new Connection("11", "10"));
mapTemplate.Connections.Add(new Connection("11", "12"));
mapTemplate.Connections.Add(new Connection("12", "26"));
mapTemplate.Connections.Add(new Connection("12", "13"));
mapTemplate.Connections.Add(new Connection("12", "10"));
mapTemplate.Connections.Add(new Connection("12", "11"));
mapTemplate.Connections.Add(new Connection("13", "24"));
mapTemplate.Connections.Add(new Connection("13", "12"));
mapTemplate.Connections.Add(new Connection("13", "11"));
mapTemplate.Connections.Add(new Connection("13", "10"));
mapTemplate.Connections.Add(new Connection("14", "19"));
mapTemplate.Connections.Add(new Connection("14", "2"));
mapTemplate.Connections.Add(new Connection("14", "15"));
mapTemplate.Connections.Add(new Connection("14", "31"));
mapTemplate.Connections.Add(new Connection("14", "29"));
mapTemplate.Connections.Add(new Connection("14", "32"));
mapTemplate.Connections.Add(new Connection("15", "2"));
mapTemplate.Connections.Add(new Connection("15", "14"));
mapTemplate.Connections.Add(new Connection("15", "29"));
mapTemplate.Connections.Add(new Connection("15", "27"));
mapTemplate.Connections.Add(new Connection("15", "26"));
mapTemplate.Connections.Add(new Connection("15", "3"));
mapTemplate.Connections.Add(new Connection("15", "24"));
mapTemplate.Connections.Add(new Connection("15", "28"));
mapTemplate.Connections.Add(new Connection("15", "31"));
mapTemplate.Connections.Add(new Connection("15", "33"));
mapTemplate.Connections.Add(new Connection("15", "34"));
mapTemplate.Connections.Add(new Connection("15", "35"));
mapTemplate.Connections.Add(new Connection("16", "18"));
mapTemplate.Connections.Add(new Connection("16", "17"));
mapTemplate.Connections.Add(new Connection("16", "20"));
mapTemplate.Connections.Add(new Connection("17", "18"));
mapTemplate.Connections.Add(new Connection("17", "16"));
mapTemplate.Connections.Add(new Connection("17", "20"));
mapTemplate.Connections.Add(new Connection("18", "21"));
mapTemplate.Connections.Add(new Connection("18", "20"));
mapTemplate.Connections.Add(new Connection("18", "17"));
mapTemplate.Connections.Add(new Connection("18", "16"));
mapTemplate.Connections.Add(new Connection("18", "19"));
mapTemplate.Connections.Add(new Connection("18", "2"));
mapTemplate.Connections.Add(new Connection("18", "32"));
mapTemplate.Connections.Add(new Connection("19", "18"));
mapTemplate.Connections.Add(new Connection("19", "2"));
mapTemplate.Connections.Add(new Connection("19", "32"));
mapTemplate.Connections.Add(new Connection("19", "14"));
mapTemplate.Connections.Add(new Connection("19", "31"));
mapTemplate.Connections.Add(new Connection("20", "21"));
mapTemplate.Connections.Add(new Connection("20", "18"));
mapTemplate.Connections.Add(new Connection("20", "17"));
mapTemplate.Connections.Add(new Connection("20", "16"));
mapTemplate.Connections.Add(new Connection("21", "22"));
mapTemplate.Connections.Add(new Connection("21", "2"));
mapTemplate.Connections.Add(new Connection("21", "20"));
mapTemplate.Connections.Add(new Connection("21", "18"));
mapTemplate.Connections.Add(new Connection("22", "3"));
mapTemplate.Connections.Add(new Connection("22", "2"));
mapTemplate.Connections.Add(new Connection("22", "21"));
mapTemplate.Connections.Add(new Connection("23", "6"));
mapTemplate.Connections.Add(new Connection("23", "24"));
mapTemplate.Connections.Add(new Connection("23", "8"));
mapTemplate.Connections.Add(new Connection("24", "25"));
mapTemplate.Connections.Add(new Connection("24", "23"));
mapTemplate.Connections.Add(new Connection("24", "11"));
mapTemplate.Connections.Add(new Connection("24", "13"));
mapTemplate.Connections.Add(new Connection("24", "3"));
mapTemplate.Connections.Add(new Connection("24", "15"));
mapTemplate.Connections.Add(new Connection("24", "27"));
mapTemplate.Connections.Add(new Connection("24", "28"));
mapTemplate.Connections.Add(new Connection("24", "31"));
mapTemplate.Connections.Add(new Connection("24", "8"));
mapTemplate.Connections.Add(new Connection("24", "33"));
mapTemplate.Connections.Add(new Connection("24", "34"));
mapTemplate.Connections.Add(new Connection("24", "35"));
mapTemplate.Connections.Add(new Connection("25", "27"));
mapTemplate.Connections.Add(new Connection("25", "26"));
mapTemplate.Connections.Add(new Connection("25", "24"));
mapTemplate.Connections.Add(new Connection("26", "27"));
mapTemplate.Connections.Add(new Connection("26", "25"));
mapTemplate.Connections.Add(new Connection("26", "15"));
mapTemplate.Connections.Add(new Connection("26", "12"));
mapTemplate.Connections.Add(new Connection("27", "28"));
mapTemplate.Connections.Add(new Connection("27", "29"));
mapTemplate.Connections.Add(new Connection("27", "25"));
mapTemplate.Connections.Add(new Connection("27", "26"));
mapTemplate.Connections.Add(new Connection("27", "15"));
mapTemplate.Connections.Add(new Connection("27", "3"));
mapTemplate.Connections.Add(new Connection("27", "24"));
mapTemplate.Connections.Add(new Connection("27", "33"));
mapTemplate.Connections.Add(new Connection("27", "34"));
mapTemplate.Connections.Add(new Connection("27", "35"));
mapTemplate.Connections.Add(new Connection("27", "31"));
mapTemplate.Connections.Add(new Connection("28", "29"));
mapTemplate.Connections.Add(new Connection("28", "27"));
mapTemplate.Connections.Add(new Connection("28", "30"));
mapTemplate.Connections.Add(new Connection("28", "3"));
mapTemplate.Connections.Add(new Connection("28", "24"));
mapTemplate.Connections.Add(new Connection("28", "15"));
mapTemplate.Connections.Add(new Connection("28", "31"));
mapTemplate.Connections.Add(new Connection("28", "33"));
mapTemplate.Connections.Add(new Connection("28", "34"));
mapTemplate.Connections.Add(new Connection("28", "35"));
mapTemplate.Connections.Add(new Connection("29", "31"));
mapTemplate.Connections.Add(new Connection("29", "15"));
mapTemplate.Connections.Add(new Connection("29", "30"));
mapTemplate.Connections.Add(new Connection("29", "28"));
mapTemplate.Connections.Add(new Connection("29", "27"));
mapTemplate.Connections.Add(new Connection("29", "14"));
mapTemplate.Connections.Add(new Connection("30", "31"));
mapTemplate.Connections.Add(new Connection("30", "29"));
mapTemplate.Connections.Add(new Connection("30", "28"));
mapTemplate.Connections.Add(new Connection("31", "14"));
mapTemplate.Connections.Add(new Connection("31", "32"));
mapTemplate.Connections.Add(new Connection("31", "30"));
mapTemplate.Connections.Add(new Connection("31", "29"));
mapTemplate.Connections.Add(new Connection("31", "3"));
mapTemplate.Connections.Add(new Connection("31", "24"));
mapTemplate.Connections.Add(new Connection("31", "15"));
mapTemplate.Connections.Add(new Connection("31", "28"));
mapTemplate.Connections.Add(new Connection("31", "33"));
mapTemplate.Connections.Add(new Connection("31", "34"));
mapTemplate.Connections.Add(new Connection("31", "35"));
mapTemplate.Connections.Add(new Connection("31", "27"));
mapTemplate.Connections.Add(new Connection("31", "19"));
mapTemplate.Connections.Add(new Connection("32", "19"));
mapTemplate.Connections.Add(new Connection("32", "31"));
mapTemplate.Connections.Add(new Connection("32", "18"));
mapTemplate.Connections.Add(new Connection("32", "14"));
mapTemplate.Connections.Add(new Connection("33", "28"));
mapTemplate.Connections.Add(new Connection("33", "27"));
mapTemplate.Connections.Add(new Connection("33", "31"));
mapTemplate.Connections.Add(new Connection("33", "15"));
mapTemplate.Connections.Add(new Connection("33", "3"));
mapTemplate.Connections.Add(new Connection("33", "24"));
mapTemplate.Connections.Add(new Connection("34", "28"));
mapTemplate.Connections.Add(new Connection("34", "27"));
mapTemplate.Connections.Add(new Connection("34", "31"));
mapTemplate.Connections.Add(new Connection("34", "15"));
mapTemplate.Connections.Add(new Connection("34", "3"));
mapTemplate.Connections.Add(new Connection("34", "24"));
mapTemplate.Connections.Add(new Connection("35", "28"));
mapTemplate.Connections.Add(new Connection("35", "27"));
mapTemplate.Connections.Add(new Connection("35", "31"));
mapTemplate.Connections.Add(new Connection("35", "15"));
mapTemplate.Connections.Add(new Connection("35", "3"));
mapTemplate.Connections.Add(new Connection("35", "24"));

            return mapTemplate;
		}
    }
}

