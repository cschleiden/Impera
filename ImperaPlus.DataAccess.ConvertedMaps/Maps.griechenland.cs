
using ImperaPlus.Domain.Map;

namespace ImperaPlus.DataAccess.ConvertedMaps
{
    public static partial class Maps
    {
        public static MapTemplate griechenland()
        {

var mapTemplate = new MapTemplate("griechenland") { Image = "griechenland.jpg" };
var country1 = new CountryTemplate("1", "Korfu") { X = 33, Y = 288 };
mapTemplate.Countries.Add(country1);
var country2 = new CountryTemplate("2", "Lefkada") { X = 129, Y = 413 };
mapTemplate.Countries.Add(country2);
var country3 = new CountryTemplate("3", "Kefallinia") { X = 119, Y = 483 };
mapTemplate.Countries.Add(country3);
var country4 = new CountryTemplate("4", "Zakynthos") { X = 142, Y = 547 };
mapTemplate.Countries.Add(country4);
var country5 = new CountryTemplate("5", "Ioannina") { X = 169, Y = 255 };
mapTemplate.Countries.Add(country5);
var country6 = new CountryTemplate("6", "Thesprotia") { X = 121, Y = 293 };
mapTemplate.Countries.Add(country6);
var country7 = new CountryTemplate("7", "Preveza") { X = 145, Y = 358 };
mapTemplate.Countries.Add(country7);
var country8 = new CountryTemplate("8", "Arta") { X = 200, Y = 330 };
mapTemplate.Countries.Add(country8);
var country9 = new CountryTemplate("9", "Florina") { X = 248, Y = 147 };
mapTemplate.Countries.Add(country9);
var country10 = new CountryTemplate("10", "Kastoria") { X = 189, Y = 190 };
mapTemplate.Countries.Add(country10);
var country11 = new CountryTemplate("11", "Kozani") { X = 286, Y = 204 };
mapTemplate.Countries.Add(country11);
var country12 = new CountryTemplate("12", "Grevena") { X = 235, Y = 226 };
mapTemplate.Countries.Add(country12);
var country13 = new CountryTemplate("13", "Pella") { X = 311, Y = 127 };
mapTemplate.Countries.Add(country13);
var country14 = new CountryTemplate("14", "Kilkis") { X = 369, Y = 103 };
mapTemplate.Countries.Add(country14);
var country15 = new CountryTemplate("15", "Serres") { X = 480, Y = 104 };
mapTemplate.Countries.Add(country15);
var country16 = new CountryTemplate("16", "Thessaloniki") { X = 458, Y = 142 };
mapTemplate.Countries.Add(country16);
var country17 = new CountryTemplate("17", "Chalkidiki") { X = 468, Y = 193 };
mapTemplate.Countries.Add(country17);
var country18 = new CountryTemplate("18", "Pieria") { X = 354, Y = 227 };
mapTemplate.Countries.Add(country18);
var country19 = new CountryTemplate("19", "Imathia") { X = 331, Y = 177 };
mapTemplate.Countries.Add(country19);
var country20 = new CountryTemplate("20", "Drama") { X = 538, Y = 75 };
mapTemplate.Countries.Add(country20);
var country21 = new CountryTemplate("21", "Xanthi") { X = 627, Y = 90 };
mapTemplate.Countries.Add(country21);
var country22 = new CountryTemplate("22", "Rodopi") { X = 698, Y = 81 };
mapTemplate.Countries.Add(country22);
var country23 = new CountryTemplate("23", "Evros") { X = 766, Y = 80 };
mapTemplate.Countries.Add(country23);
var country24 = new CountryTemplate("24", "Kavala") { X = 555, Y = 117 };
mapTemplate.Countries.Add(country24);
var country25 = new CountryTemplate("25", "Lesbos") { X = 651, Y = 258 };
mapTemplate.Countries.Add(country25);
var country26 = new CountryTemplate("26", "Chios") { X = 740, Y = 453 };
mapTemplate.Countries.Add(country26);
var country27 = new CountryTemplate("27", "Samos") { X = 785, Y = 551 };
mapTemplate.Countries.Add(country27);
var country28 = new CountryTemplate("28", "Dadekanes") { X = 854, Y = 688 };
mapTemplate.Countries.Add(country28);
var country29 = new CountryTemplate("29", "Kykladen") { X = 668, Y = 634 };
mapTemplate.Countries.Add(country29);
var country30 = new CountryTemplate("30", "Ätolien-Arkananien") { X = 247, Y = 444 };
mapTemplate.Countries.Add(country30);
var country31 = new CountryTemplate("31", "Achaia") { X = 297, Y = 506 };
mapTemplate.Countries.Add(country31);
var country32 = new CountryTemplate("32", "Elis") { X = 249, Y = 572 };
mapTemplate.Countries.Add(country32);
var country33 = new CountryTemplate("33", "Trikala") { X = 247, Y = 293 };
mapTemplate.Countries.Add(country33);
var country34 = new CountryTemplate("34", "Larissa") { X = 333, Y = 284 };
mapTemplate.Countries.Add(country34);
var country35 = new CountryTemplate("35", "Magnisia") { X = 367, Y = 341 };
mapTemplate.Countries.Add(country35);
var country36 = new CountryTemplate("36", "Karditsa") { X = 296, Y = 345 };
mapTemplate.Countries.Add(country36);
var country37 = new CountryTemplate("37", "Evrytania") { X = 269, Y = 400 };
mapTemplate.Countries.Add(country37);
var country38 = new CountryTemplate("38", "Fthiodita") { X = 337, Y = 399 };
mapTemplate.Countries.Add(country38);
var country39 = new CountryTemplate("39", "Fokida") { X = 321, Y = 428 };
mapTemplate.Countries.Add(country39);
var country40 = new CountryTemplate("40", "Böotien") { X = 414, Y = 469 };
mapTemplate.Countries.Add(country40);
var country41 = new CountryTemplate("41", "Euböa") { X = 576, Y = 414 };
mapTemplate.Countries.Add(country41);
var country42 = new CountryTemplate("42", "Westattika") { X = 443, Y = 501 };
mapTemplate.Countries.Add(country42);
var country43 = new CountryTemplate("43", "Athen") { X = 491, Y = 526 };
mapTemplate.Countries.Add(country43);
var country44 = new CountryTemplate("44", "Ostattika") { X = 502, Y = 485 };
mapTemplate.Countries.Add(country44);
var country45 = new CountryTemplate("45", "Piräus") { X = 458, Y = 572 };
mapTemplate.Countries.Add(country45);
var country46 = new CountryTemplate("46", "Korinthien") { X = 399, Y = 540 };
mapTemplate.Countries.Add(country46);
var country47 = new CountryTemplate("47", "Argolis") { X = 365, Y = 579 };
mapTemplate.Countries.Add(country47);
var country48 = new CountryTemplate("48", "Arkadien") { X = 318, Y = 593 };
mapTemplate.Countries.Add(country48);
var country49 = new CountryTemplate("49", "Messenien") { X = 278, Y = 620 };
mapTemplate.Countries.Add(country49);
var country50 = new CountryTemplate("50", "Lakonien") { X = 343, Y = 647 };
mapTemplate.Countries.Add(country50);
var country51 = new CountryTemplate("51", "Chania") { X = 509, Y = 878 };
mapTemplate.Countries.Add(country51);
var country52 = new CountryTemplate("52", "Rethymna") { X = 589, Y = 899 };
mapTemplate.Countries.Add(country52);
var country53 = new CountryTemplate("53", "Iraklia") { X = 647, Y = 908 };
mapTemplate.Countries.Add(country53);
var country54 = new CountryTemplate("54", "Lasithi") { X = 711, Y = 899 };
mapTemplate.Countries.Add(country54);
var continent1 = new Continent("1", 3);
continent1.Countries.Add(country1);
continent1.Countries.Add(country2);
continent1.Countries.Add(country3);
continent1.Countries.Add(country4);
mapTemplate.Continents.Add(continent1);
var continent2 = new Continent("2", 3);
continent2.Countries.Add(country5);
continent2.Countries.Add(country6);
continent2.Countries.Add(country7);
continent2.Countries.Add(country8);
mapTemplate.Continents.Add(continent2);
var continent3 = new Continent("3", 3);
continent3.Countries.Add(country9);
continent3.Countries.Add(country10);
continent3.Countries.Add(country11);
continent3.Countries.Add(country12);
mapTemplate.Continents.Add(continent3);
var continent4 = new Continent("4", 4);
continent4.Countries.Add(country13);
continent4.Countries.Add(country14);
continent4.Countries.Add(country15);
continent4.Countries.Add(country16);
continent4.Countries.Add(country17);
continent4.Countries.Add(country18);
continent4.Countries.Add(country19);
mapTemplate.Continents.Add(continent4);
var continent5 = new Continent("5", 3);
continent5.Countries.Add(country20);
continent5.Countries.Add(country21);
continent5.Countries.Add(country22);
continent5.Countries.Add(country23);
continent5.Countries.Add(country24);
mapTemplate.Continents.Add(continent5);
var continent6 = new Continent("6", 2);
continent6.Countries.Add(country25);
continent6.Countries.Add(country26);
continent6.Countries.Add(country27);
mapTemplate.Continents.Add(continent6);
var continent7 = new Continent("7", 1);
continent7.Countries.Add(country28);
continent7.Countries.Add(country29);
mapTemplate.Continents.Add(continent7);
var continent8 = new Continent("8", 2);
continent8.Countries.Add(country30);
continent8.Countries.Add(country31);
continent8.Countries.Add(country32);
mapTemplate.Continents.Add(continent8);
var continent9 = new Continent("9", 3);
continent9.Countries.Add(country33);
continent9.Countries.Add(country34);
continent9.Countries.Add(country35);
continent9.Countries.Add(country36);
mapTemplate.Continents.Add(continent9);
var continent10 = new Continent("10", 3);
continent10.Countries.Add(country37);
continent10.Countries.Add(country38);
continent10.Countries.Add(country39);
continent10.Countries.Add(country40);
continent10.Countries.Add(country41);
mapTemplate.Continents.Add(continent10);
var continent11 = new Continent("11", 3);
continent11.Countries.Add(country42);
continent11.Countries.Add(country43);
continent11.Countries.Add(country44);
continent11.Countries.Add(country45);
mapTemplate.Continents.Add(continent11);
var continent12 = new Continent("12", 3);
continent12.Countries.Add(country46);
continent12.Countries.Add(country47);
continent12.Countries.Add(country48);
continent12.Countries.Add(country49);
continent12.Countries.Add(country50);
mapTemplate.Continents.Add(continent12);
var continent13 = new Continent("13", 2);
continent13.Countries.Add(country51);
continent13.Countries.Add(country52);
continent13.Countries.Add(country53);
continent13.Countries.Add(country54);
mapTemplate.Continents.Add(continent13);
mapTemplate.Connections.Add(new Connection("1", "2"));
mapTemplate.Connections.Add(new Connection("1", "6"));
mapTemplate.Connections.Add(new Connection("2", "3"));
mapTemplate.Connections.Add(new Connection("2", "7"));
mapTemplate.Connections.Add(new Connection("2", "1"));
mapTemplate.Connections.Add(new Connection("3", "4"));
mapTemplate.Connections.Add(new Connection("3", "30"));
mapTemplate.Connections.Add(new Connection("3", "2"));
mapTemplate.Connections.Add(new Connection("4", "32"));
mapTemplate.Connections.Add(new Connection("4", "3"));
mapTemplate.Connections.Add(new Connection("5", "6"));
mapTemplate.Connections.Add(new Connection("5", "8"));
mapTemplate.Connections.Add(new Connection("5", "7"));
mapTemplate.Connections.Add(new Connection("5", "10"));
mapTemplate.Connections.Add(new Connection("5", "12"));
mapTemplate.Connections.Add(new Connection("5", "33"));
mapTemplate.Connections.Add(new Connection("6", "1"));
mapTemplate.Connections.Add(new Connection("6", "7"));
mapTemplate.Connections.Add(new Connection("6", "5"));
mapTemplate.Connections.Add(new Connection("7", "2"));
mapTemplate.Connections.Add(new Connection("7", "6"));
mapTemplate.Connections.Add(new Connection("7", "8"));
mapTemplate.Connections.Add(new Connection("7", "5"));
mapTemplate.Connections.Add(new Connection("8", "7"));
mapTemplate.Connections.Add(new Connection("8", "30"));
mapTemplate.Connections.Add(new Connection("8", "37"));
mapTemplate.Connections.Add(new Connection("8", "5"));
mapTemplate.Connections.Add(new Connection("8", "33"));
mapTemplate.Connections.Add(new Connection("8", "36"));
mapTemplate.Connections.Add(new Connection("9", "11"));
mapTemplate.Connections.Add(new Connection("9", "13"));
mapTemplate.Connections.Add(new Connection("9", "10"));
mapTemplate.Connections.Add(new Connection("10", "5"));
mapTemplate.Connections.Add(new Connection("10", "12"));
mapTemplate.Connections.Add(new Connection("10", "11"));
mapTemplate.Connections.Add(new Connection("10", "9"));
mapTemplate.Connections.Add(new Connection("11", "34"));
mapTemplate.Connections.Add(new Connection("11", "12"));
mapTemplate.Connections.Add(new Connection("11", "9"));
mapTemplate.Connections.Add(new Connection("11", "10"));
mapTemplate.Connections.Add(new Connection("11", "13"));
mapTemplate.Connections.Add(new Connection("11", "19"));
mapTemplate.Connections.Add(new Connection("11", "18"));
mapTemplate.Connections.Add(new Connection("12", "5"));
mapTemplate.Connections.Add(new Connection("12", "33"));
mapTemplate.Connections.Add(new Connection("12", "34"));
mapTemplate.Connections.Add(new Connection("12", "11"));
mapTemplate.Connections.Add(new Connection("12", "10"));
mapTemplate.Connections.Add(new Connection("13", "14"));
mapTemplate.Connections.Add(new Connection("13", "16"));
mapTemplate.Connections.Add(new Connection("13", "9"));
mapTemplate.Connections.Add(new Connection("13", "11"));
mapTemplate.Connections.Add(new Connection("13", "19"));
mapTemplate.Connections.Add(new Connection("14", "15"));
mapTemplate.Connections.Add(new Connection("14", "16"));
mapTemplate.Connections.Add(new Connection("14", "13"));
mapTemplate.Connections.Add(new Connection("15", "20"));
mapTemplate.Connections.Add(new Connection("15", "24"));
mapTemplate.Connections.Add(new Connection("15", "16"));
mapTemplate.Connections.Add(new Connection("15", "14"));
mapTemplate.Connections.Add(new Connection("16", "15"));
mapTemplate.Connections.Add(new Connection("16", "17"));
mapTemplate.Connections.Add(new Connection("16", "19"));
mapTemplate.Connections.Add(new Connection("16", "14"));
mapTemplate.Connections.Add(new Connection("16", "13"));
mapTemplate.Connections.Add(new Connection("17", "25"));
mapTemplate.Connections.Add(new Connection("17", "16"));
mapTemplate.Connections.Add(new Connection("18", "19"));
mapTemplate.Connections.Add(new Connection("18", "34"));
mapTemplate.Connections.Add(new Connection("18", "11"));
mapTemplate.Connections.Add(new Connection("19", "18"));
mapTemplate.Connections.Add(new Connection("19", "16"));
mapTemplate.Connections.Add(new Connection("19", "11"));
mapTemplate.Connections.Add(new Connection("19", "13"));
mapTemplate.Connections.Add(new Connection("20", "24"));
mapTemplate.Connections.Add(new Connection("20", "21"));
mapTemplate.Connections.Add(new Connection("20", "15"));
mapTemplate.Connections.Add(new Connection("21", "22"));
mapTemplate.Connections.Add(new Connection("21", "24"));
mapTemplate.Connections.Add(new Connection("21", "20"));
mapTemplate.Connections.Add(new Connection("22", "23"));
mapTemplate.Connections.Add(new Connection("22", "25"));
mapTemplate.Connections.Add(new Connection("22", "21"));
mapTemplate.Connections.Add(new Connection("23", "22"));
mapTemplate.Connections.Add(new Connection("24", "20"));
mapTemplate.Connections.Add(new Connection("24", "21"));
mapTemplate.Connections.Add(new Connection("24", "15"));
mapTemplate.Connections.Add(new Connection("25", "26"));
mapTemplate.Connections.Add(new Connection("25", "22"));
mapTemplate.Connections.Add(new Connection("25", "17"));
mapTemplate.Connections.Add(new Connection("26", "27"));
mapTemplate.Connections.Add(new Connection("26", "25"));
mapTemplate.Connections.Add(new Connection("26", "41"));
mapTemplate.Connections.Add(new Connection("27", "28"));
mapTemplate.Connections.Add(new Connection("27", "26"));
mapTemplate.Connections.Add(new Connection("28", "54"));
mapTemplate.Connections.Add(new Connection("28", "27"));
mapTemplate.Connections.Add(new Connection("28", "29"));
mapTemplate.Connections.Add(new Connection("29", "52"));
mapTemplate.Connections.Add(new Connection("29", "41"));
mapTemplate.Connections.Add(new Connection("29", "44"));
mapTemplate.Connections.Add(new Connection("29", "28"));
mapTemplate.Connections.Add(new Connection("30", "31"));
mapTemplate.Connections.Add(new Connection("30", "3"));
mapTemplate.Connections.Add(new Connection("30", "8"));
mapTemplate.Connections.Add(new Connection("30", "37"));
mapTemplate.Connections.Add(new Connection("30", "38"));
mapTemplate.Connections.Add(new Connection("30", "39"));
mapTemplate.Connections.Add(new Connection("31", "48"));
mapTemplate.Connections.Add(new Connection("31", "32"));
mapTemplate.Connections.Add(new Connection("31", "30"));
mapTemplate.Connections.Add(new Connection("31", "46"));
mapTemplate.Connections.Add(new Connection("32", "49"));
mapTemplate.Connections.Add(new Connection("32", "48"));
mapTemplate.Connections.Add(new Connection("32", "31"));
mapTemplate.Connections.Add(new Connection("32", "4"));
mapTemplate.Connections.Add(new Connection("33", "5"));
mapTemplate.Connections.Add(new Connection("33", "8"));
mapTemplate.Connections.Add(new Connection("33", "12"));
mapTemplate.Connections.Add(new Connection("33", "34"));
mapTemplate.Connections.Add(new Connection("33", "36"));
mapTemplate.Connections.Add(new Connection("34", "33"));
mapTemplate.Connections.Add(new Connection("34", "36"));
mapTemplate.Connections.Add(new Connection("34", "35"));
mapTemplate.Connections.Add(new Connection("34", "18"));
mapTemplate.Connections.Add(new Connection("34", "11"));
mapTemplate.Connections.Add(new Connection("34", "12"));
mapTemplate.Connections.Add(new Connection("34", "38"));
mapTemplate.Connections.Add(new Connection("35", "38"));
mapTemplate.Connections.Add(new Connection("35", "34"));
mapTemplate.Connections.Add(new Connection("36", "37"));
mapTemplate.Connections.Add(new Connection("36", "8"));
mapTemplate.Connections.Add(new Connection("36", "33"));
mapTemplate.Connections.Add(new Connection("36", "38"));
mapTemplate.Connections.Add(new Connection("36", "34"));
mapTemplate.Connections.Add(new Connection("37", "30"));
mapTemplate.Connections.Add(new Connection("37", "38"));
mapTemplate.Connections.Add(new Connection("37", "36"));
mapTemplate.Connections.Add(new Connection("37", "8"));
mapTemplate.Connections.Add(new Connection("38", "30"));
mapTemplate.Connections.Add(new Connection("38", "41"));
mapTemplate.Connections.Add(new Connection("38", "39"));
mapTemplate.Connections.Add(new Connection("38", "37"));
mapTemplate.Connections.Add(new Connection("38", "36"));
mapTemplate.Connections.Add(new Connection("38", "35"));
mapTemplate.Connections.Add(new Connection("38", "40"));
mapTemplate.Connections.Add(new Connection("38", "34"));
mapTemplate.Connections.Add(new Connection("39", "30"));
mapTemplate.Connections.Add(new Connection("39", "38"));
mapTemplate.Connections.Add(new Connection("39", "40"));
mapTemplate.Connections.Add(new Connection("40", "39"));
mapTemplate.Connections.Add(new Connection("40", "42"));
mapTemplate.Connections.Add(new Connection("40", "43"));
mapTemplate.Connections.Add(new Connection("40", "44"));
mapTemplate.Connections.Add(new Connection("40", "38"));
mapTemplate.Connections.Add(new Connection("41", "26"));
mapTemplate.Connections.Add(new Connection("41", "29"));
mapTemplate.Connections.Add(new Connection("41", "38"));
mapTemplate.Connections.Add(new Connection("42", "46"));
mapTemplate.Connections.Add(new Connection("42", "40"));
mapTemplate.Connections.Add(new Connection("42", "43"));
mapTemplate.Connections.Add(new Connection("43", "40"));
mapTemplate.Connections.Add(new Connection("43", "42"));
mapTemplate.Connections.Add(new Connection("43", "44"));
mapTemplate.Connections.Add(new Connection("44", "29"));
mapTemplate.Connections.Add(new Connection("44", "40"));
mapTemplate.Connections.Add(new Connection("44", "43"));
mapTemplate.Connections.Add(new Connection("45", "47"));
mapTemplate.Connections.Add(new Connection("46", "47"));
mapTemplate.Connections.Add(new Connection("46", "42"));
mapTemplate.Connections.Add(new Connection("46", "31"));
mapTemplate.Connections.Add(new Connection("46", "48"));
mapTemplate.Connections.Add(new Connection("47", "48"));
mapTemplate.Connections.Add(new Connection("47", "46"));
mapTemplate.Connections.Add(new Connection("47", "45"));
mapTemplate.Connections.Add(new Connection("48", "50"));
mapTemplate.Connections.Add(new Connection("48", "32"));
mapTemplate.Connections.Add(new Connection("48", "47"));
mapTemplate.Connections.Add(new Connection("48", "31"));
mapTemplate.Connections.Add(new Connection("48", "49"));
mapTemplate.Connections.Add(new Connection("48", "46"));
mapTemplate.Connections.Add(new Connection("49", "50"));
mapTemplate.Connections.Add(new Connection("49", "32"));
mapTemplate.Connections.Add(new Connection("49", "48"));
mapTemplate.Connections.Add(new Connection("50", "51"));
mapTemplate.Connections.Add(new Connection("50", "49"));
mapTemplate.Connections.Add(new Connection("50", "48"));
mapTemplate.Connections.Add(new Connection("51", "50"));
mapTemplate.Connections.Add(new Connection("51", "52"));
mapTemplate.Connections.Add(new Connection("52", "51"));
mapTemplate.Connections.Add(new Connection("52", "53"));
mapTemplate.Connections.Add(new Connection("52", "29"));
mapTemplate.Connections.Add(new Connection("53", "52"));
mapTemplate.Connections.Add(new Connection("53", "54"));
mapTemplate.Connections.Add(new Connection("54", "53"));
mapTemplate.Connections.Add(new Connection("54", "28"));

            return mapTemplate;
		}
    }
}

