
using ImperaPlus.Domain.Map;

namespace ImperaPlus.DataAccess.ConvertedMaps
{
    public static partial class Maps
    {
        public static MapTemplate Minenkolonie()
        {

var mapTemplate = new MapTemplate("Minenkolonie") { Image = "minenkolonie.png" };
var country1 = new CountryTemplate("1", "Austauschplatz") { X = 552, Y = 107 };
mapTemplate.Countries.Add(country1);
var country2 = new CountryTemplate("2", "Weg zum Pass") { X = 547, Y = 182 };
mapTemplate.Countries.Add(country2);
var country3 = new CountryTemplate("3", "Westliches Umland") { X = 435, Y = 377 };
mapTemplate.Countries.Add(country3);
var country4 = new CountryTemplate("4", "N�rdliches Umland") { X = 616, Y = 332 };
mapTemplate.Countries.Add(country4);
var country5 = new CountryTemplate("5", "S�dliches Umland") { X = 548, Y = 430 };
mapTemplate.Countries.Add(country5);
var country6 = new CountryTemplate("6", "Burg") { X = 511, Y = 355 };
mapTemplate.Countries.Add(country6);
var country7 = new CountryTemplate("7", "�u�erer Ring") { X = 513, Y = 389 };
mapTemplate.Countries.Add(country7);
var country8 = new CountryTemplate("8", "Insel") { X = 542, Y = 239 };
mapTemplate.Countries.Add(country8);
var country9 = new CountryTemplate("9", "Klosterruine") { X = 694, Y = 242 };
mapTemplate.Countries.Add(country9);
var country10 = new CountryTemplate("10", "Nebelturm") { X = 752, Y = 247 };
mapTemplate.Countries.Add(country10);
var country11 = new CountryTemplate("11", "N�rdlicher Wald") { X = 701, Y = 317 };
mapTemplate.Countries.Add(country11);
var country12 = new CountryTemplate("12", "Fokusplatz") { X = 845, Y = 310 };
mapTemplate.Countries.Add(country12);
var country13 = new CountryTemplate("13", "Bucht") { X = 801, Y = 267 };
mapTemplate.Countries.Add(country13);
var country14 = new CountryTemplate("14", "S�dlicher Wald") { X = 666, Y = 424 };
mapTemplate.Countries.Add(country14);
var country15 = new CountryTemplate("15", "Pass am Wasserfall") { X = 807, Y = 370 };
mapTemplate.Countries.Add(country15);
var country16 = new CountryTemplate("16", "Orkfriedhof") { X = 809, Y = 527 };
mapTemplate.Countries.Add(country16);
var country17 = new CountryTemplate("17", "Tempelviertel") { X = 895, Y = 370 };
mapTemplate.Countries.Add(country17);
var country18 = new CountryTemplate("18", "Sumpflager") { X = 934, Y = 434 };
mapTemplate.Countries.Add(country18);
var country19 = new CountryTemplate("19", "Sumpf") { X = 923, Y = 549 };
mapTemplate.Countries.Add(country19);
var country20 = new CountryTemplate("20", "Felsenfestung") { X = 715, Y = 621 };
mapTemplate.Countries.Add(country20);
var country21 = new CountryTemplate("21", "Kastell") { X = 557, Y = 509 };
mapTemplate.Countries.Add(country21);
var country22 = new CountryTemplate("22", "�stliches Orkgebiet") { X = 489, Y = 544 };
mapTemplate.Countries.Add(country22);
var country23 = new CountryTemplate("23", "Westliches Orkgebiet") { X = 386, Y = 550 };
mapTemplate.Countries.Add(country23);
var country24 = new CountryTemplate("24", "Xardas Turm") { X = 429, Y = 638 };
mapTemplate.Countries.Add(country24);
var country25 = new CountryTemplate("25", "Orkdorf") { X = 303, Y = 523 };
mapTemplate.Countries.Add(country25);
var country26 = new CountryTemplate("26", "Schl�fertempel") { X = 251, Y = 558 };
mapTemplate.Countries.Add(country26);
var country27 = new CountryTemplate("27", "Stonehenge") { X = 269, Y = 430 };
mapTemplate.Countries.Add(country27);
var country28 = new CountryTemplate("28", "Orktempel") { X = 388, Y = 394 };
mapTemplate.Countries.Add(country28);
var country29 = new CountryTemplate("29", "Cavalorns H�tte") { X = 367, Y = 327 };
mapTemplate.Countries.Add(country29);
var country30 = new CountryTemplate("30", "Fischersee") { X = 222, Y = 352 };
mapTemplate.Countries.Add(country30);
var country31 = new CountryTemplate("31", "Bergpfad") { X = 183, Y = 322 };
mapTemplate.Countries.Add(country31);
var country32 = new CountryTemplate("32", "Aidans H�tte") { X = 285, Y = 336 };
mapTemplate.Countries.Add(country32);
var country33 = new CountryTemplate("33", "Wegkreuzung") { X = 283, Y = 261 };
mapTemplate.Countries.Add(country33);
var country34 = new CountryTemplate("34", "Freie Mine") { X = 139, Y = 458 };
mapTemplate.Countries.Add(country34);
var country35 = new CountryTemplate("35", "Pass zu freien Mine") { X = 85, Y = 396 };
mapTemplate.Countries.Add(country35);
var country36 = new CountryTemplate("36", "Wohnh�hle") { X = 115, Y = 310 };
mapTemplate.Countries.Add(country36);
var country37 = new CountryTemplate("37", "Stausee") { X = 93, Y = 173 };
mapTemplate.Countries.Add(country37);
var country38 = new CountryTemplate("38", "Reisfelder") { X = 178, Y = 262 };
mapTemplate.Countries.Add(country38);
var country39 = new CountryTemplate("39", "Dunkler Wald") { X = 358, Y = 201 };
mapTemplate.Countries.Add(country39);
var country40 = new CountryTemplate("40", "J�gerlager") { X = 495, Y = 185 };
mapTemplate.Countries.Add(country40);
var country41 = new CountryTemplate("41", "Banditenlager") { X = 471, Y = 79 };
mapTemplate.Countries.Add(country41);
var country42 = new CountryTemplate("42", "Trollschlucht") { X = 385, Y = 68 };
mapTemplate.Countries.Add(country42);
var country43 = new CountryTemplate("43", "Pass zur alten Mine") { X = 278, Y = 166 };
mapTemplate.Countries.Add(country43);
var country44 = new CountryTemplate("44", "Alte Mine") { X = 296, Y = 110 };
mapTemplate.Countries.Add(country44);
var country45 = new CountryTemplate("45", "Massiv") { X = 701, Y = 539 };
mapTemplate.Countries.Add(country45);
var continent1 = new Continent("1", 6);
continent1.Countries.Add(country1);
continent1.Countries.Add(country2);
continent1.Countries.Add(country3);
continent1.Countries.Add(country4);
continent1.Countries.Add(country5);
continent1.Countries.Add(country6);
continent1.Countries.Add(country7);
mapTemplate.Continents.Add(continent1);
var continent2 = new Continent("2", 2);
continent2.Countries.Add(country34);
continent2.Countries.Add(country35);
continent2.Countries.Add(country36);
continent2.Countries.Add(country37);
continent2.Countries.Add(country38);
mapTemplate.Continents.Add(continent2);
var continent3 = new Continent("3", 3);
continent3.Countries.Add(country14);
continent3.Countries.Add(country15);
continent3.Countries.Add(country16);
continent3.Countries.Add(country17);
continent3.Countries.Add(country18);
continent3.Countries.Add(country19);
continent3.Countries.Add(country45);
mapTemplate.Continents.Add(continent3);
var continent4 = new Continent("4", 5);
continent4.Countries.Add(country20);
continent4.Countries.Add(country21);
continent4.Countries.Add(country22);
continent4.Countries.Add(country23);
continent4.Countries.Add(country24);
continent4.Countries.Add(country25);
continent4.Countries.Add(country26);
mapTemplate.Continents.Add(continent4);
var continent5 = new Continent("5", 3);
continent5.Countries.Add(country8);
continent5.Countries.Add(country9);
continent5.Countries.Add(country10);
continent5.Countries.Add(country11);
continent5.Countries.Add(country12);
continent5.Countries.Add(country13);
mapTemplate.Continents.Add(continent5);
var continent6 = new Continent("6", 3);
continent6.Countries.Add(country39);
continent6.Countries.Add(country40);
continent6.Countries.Add(country41);
continent6.Countries.Add(country42);
continent6.Countries.Add(country43);
continent6.Countries.Add(country44);
mapTemplate.Continents.Add(continent6);
var continent7 = new Continent("7", 4);
continent7.Countries.Add(country27);
continent7.Countries.Add(country28);
continent7.Countries.Add(country29);
continent7.Countries.Add(country30);
continent7.Countries.Add(country31);
continent7.Countries.Add(country32);
continent7.Countries.Add(country33);
mapTemplate.Continents.Add(continent7);
mapTemplate.Connections.Add(new Connection("1", "2"));
mapTemplate.Connections.Add(new Connection("1", "40"));
mapTemplate.Connections.Add(new Connection("2", "3"));
mapTemplate.Connections.Add(new Connection("2", "40"));
mapTemplate.Connections.Add(new Connection("2", "1"));
mapTemplate.Connections.Add(new Connection("2", "8"));
mapTemplate.Connections.Add(new Connection("3", "29"));
mapTemplate.Connections.Add(new Connection("3", "5"));
mapTemplate.Connections.Add(new Connection("3", "7"));
mapTemplate.Connections.Add(new Connection("3", "4"));
mapTemplate.Connections.Add(new Connection("3", "40"));
mapTemplate.Connections.Add(new Connection("3", "2"));
mapTemplate.Connections.Add(new Connection("3", "39"));
mapTemplate.Connections.Add(new Connection("4", "7"));
mapTemplate.Connections.Add(new Connection("4", "5"));
mapTemplate.Connections.Add(new Connection("4", "3"));
mapTemplate.Connections.Add(new Connection("4", "9"));
mapTemplate.Connections.Add(new Connection("4", "11"));
mapTemplate.Connections.Add(new Connection("5", "27"));
mapTemplate.Connections.Add(new Connection("5", "3"));
mapTemplate.Connections.Add(new Connection("5", "7"));
mapTemplate.Connections.Add(new Connection("5", "4"));
mapTemplate.Connections.Add(new Connection("5", "22"));
mapTemplate.Connections.Add(new Connection("6", "7"));
mapTemplate.Connections.Add(new Connection("7", "5"));
mapTemplate.Connections.Add(new Connection("7", "3"));
mapTemplate.Connections.Add(new Connection("7", "6"));
mapTemplate.Connections.Add(new Connection("7", "4"));
mapTemplate.Connections.Add(new Connection("8", "9"));
mapTemplate.Connections.Add(new Connection("8", "2"));
mapTemplate.Connections.Add(new Connection("9", "8"));
mapTemplate.Connections.Add(new Connection("9", "4"));
mapTemplate.Connections.Add(new Connection("9", "11"));
mapTemplate.Connections.Add(new Connection("9", "10"));
mapTemplate.Connections.Add(new Connection("10", "9"));
mapTemplate.Connections.Add(new Connection("10", "13"));
mapTemplate.Connections.Add(new Connection("10", "11"));
mapTemplate.Connections.Add(new Connection("11", "4"));
mapTemplate.Connections.Add(new Connection("11", "9"));
mapTemplate.Connections.Add(new Connection("11", "12"));
mapTemplate.Connections.Add(new Connection("11", "13"));
mapTemplate.Connections.Add(new Connection("11", "10"));
mapTemplate.Connections.Add(new Connection("11", "14"));
mapTemplate.Connections.Add(new Connection("11", "15"));
mapTemplate.Connections.Add(new Connection("12", "13"));
mapTemplate.Connections.Add(new Connection("12", "11"));
mapTemplate.Connections.Add(new Connection("13", "10"));
mapTemplate.Connections.Add(new Connection("13", "12"));
mapTemplate.Connections.Add(new Connection("13", "11"));
mapTemplate.Connections.Add(new Connection("14", "11"));
mapTemplate.Connections.Add(new Connection("14", "16"));
mapTemplate.Connections.Add(new Connection("14", "15"));
mapTemplate.Connections.Add(new Connection("14", "45"));
mapTemplate.Connections.Add(new Connection("15", "11"));
mapTemplate.Connections.Add(new Connection("15", "14"));
mapTemplate.Connections.Add(new Connection("15", "17"));
mapTemplate.Connections.Add(new Connection("15", "18"));
mapTemplate.Connections.Add(new Connection("15", "19"));
mapTemplate.Connections.Add(new Connection("16", "14"));
mapTemplate.Connections.Add(new Connection("16", "45"));
mapTemplate.Connections.Add(new Connection("17", "18"));
mapTemplate.Connections.Add(new Connection("17", "15"));
mapTemplate.Connections.Add(new Connection("18", "19"));
mapTemplate.Connections.Add(new Connection("18", "17"));
mapTemplate.Connections.Add(new Connection("18", "15"));
mapTemplate.Connections.Add(new Connection("19", "18"));
mapTemplate.Connections.Add(new Connection("19", "15"));
mapTemplate.Connections.Add(new Connection("20", "21"));
mapTemplate.Connections.Add(new Connection("20", "45"));
mapTemplate.Connections.Add(new Connection("21", "22"));
mapTemplate.Connections.Add(new Connection("21", "20"));
mapTemplate.Connections.Add(new Connection("21", "45"));
mapTemplate.Connections.Add(new Connection("22", "23"));
mapTemplate.Connections.Add(new Connection("22", "5"));
mapTemplate.Connections.Add(new Connection("22", "24"));
mapTemplate.Connections.Add(new Connection("22", "21"));
mapTemplate.Connections.Add(new Connection("23", "27"));
mapTemplate.Connections.Add(new Connection("23", "25"));
mapTemplate.Connections.Add(new Connection("23", "22"));
mapTemplate.Connections.Add(new Connection("23", "24"));
mapTemplate.Connections.Add(new Connection("24", "23"));
mapTemplate.Connections.Add(new Connection("24", "22"));
mapTemplate.Connections.Add(new Connection("25", "23"));
mapTemplate.Connections.Add(new Connection("25", "26"));
mapTemplate.Connections.Add(new Connection("26", "25"));
mapTemplate.Connections.Add(new Connection("27", "34"));
mapTemplate.Connections.Add(new Connection("27", "31"));
mapTemplate.Connections.Add(new Connection("27", "32"));
mapTemplate.Connections.Add(new Connection("27", "29"));
mapTemplate.Connections.Add(new Connection("27", "23"));
mapTemplate.Connections.Add(new Connection("27", "5"));
mapTemplate.Connections.Add(new Connection("27", "30"));
mapTemplate.Connections.Add(new Connection("27", "28"));
mapTemplate.Connections.Add(new Connection("28", "29"));
mapTemplate.Connections.Add(new Connection("28", "27"));
mapTemplate.Connections.Add(new Connection("29", "33"));
mapTemplate.Connections.Add(new Connection("29", "27"));
mapTemplate.Connections.Add(new Connection("29", "28"));
mapTemplate.Connections.Add(new Connection("29", "3"));
mapTemplate.Connections.Add(new Connection("29", "32"));
mapTemplate.Connections.Add(new Connection("30", "33"));
mapTemplate.Connections.Add(new Connection("30", "31"));
mapTemplate.Connections.Add(new Connection("30", "32"));
mapTemplate.Connections.Add(new Connection("30", "27"));
mapTemplate.Connections.Add(new Connection("31", "33"));
mapTemplate.Connections.Add(new Connection("31", "27"));
mapTemplate.Connections.Add(new Connection("31", "30"));
mapTemplate.Connections.Add(new Connection("32", "33"));
mapTemplate.Connections.Add(new Connection("32", "27"));
mapTemplate.Connections.Add(new Connection("32", "30"));
mapTemplate.Connections.Add(new Connection("32", "29"));
mapTemplate.Connections.Add(new Connection("33", "38"));
mapTemplate.Connections.Add(new Connection("33", "32"));
mapTemplate.Connections.Add(new Connection("33", "29"));
mapTemplate.Connections.Add(new Connection("33", "30"));
mapTemplate.Connections.Add(new Connection("33", "31"));
mapTemplate.Connections.Add(new Connection("33", "43"));
mapTemplate.Connections.Add(new Connection("33", "39"));
mapTemplate.Connections.Add(new Connection("34", "35"));
mapTemplate.Connections.Add(new Connection("34", "27"));
mapTemplate.Connections.Add(new Connection("35", "34"));
mapTemplate.Connections.Add(new Connection("35", "36"));
mapTemplate.Connections.Add(new Connection("35", "37"));
mapTemplate.Connections.Add(new Connection("36", "35"));
mapTemplate.Connections.Add(new Connection("36", "37"));
mapTemplate.Connections.Add(new Connection("37", "35"));
mapTemplate.Connections.Add(new Connection("37", "36"));
mapTemplate.Connections.Add(new Connection("37", "38"));
mapTemplate.Connections.Add(new Connection("38", "37"));
mapTemplate.Connections.Add(new Connection("38", "33"));
mapTemplate.Connections.Add(new Connection("39", "33"));
mapTemplate.Connections.Add(new Connection("39", "40"));
mapTemplate.Connections.Add(new Connection("39", "3"));
mapTemplate.Connections.Add(new Connection("39", "41"));
mapTemplate.Connections.Add(new Connection("39", "42"));
mapTemplate.Connections.Add(new Connection("39", "43"));
mapTemplate.Connections.Add(new Connection("40", "3"));
mapTemplate.Connections.Add(new Connection("40", "39"));
mapTemplate.Connections.Add(new Connection("40", "2"));
mapTemplate.Connections.Add(new Connection("40", "1"));
mapTemplate.Connections.Add(new Connection("41", "39"));
mapTemplate.Connections.Add(new Connection("41", "42"));
mapTemplate.Connections.Add(new Connection("42", "39"));
mapTemplate.Connections.Add(new Connection("42", "41"));
mapTemplate.Connections.Add(new Connection("43", "33"));
mapTemplate.Connections.Add(new Connection("43", "44"));
mapTemplate.Connections.Add(new Connection("43", "39"));
mapTemplate.Connections.Add(new Connection("44", "43"));
mapTemplate.Connections.Add(new Connection("45", "14"));
mapTemplate.Connections.Add(new Connection("45", "16"));
mapTemplate.Connections.Add(new Connection("45", "21"));
mapTemplate.Connections.Add(new Connection("45", "20"));

            return mapTemplate;
		}
    }
}

