
using ImperaPlus.Domain.Map;

namespace ImperaPlus.DataAccess.ConvertedMaps
{
    public static partial class Maps
    {
        public static MapTemplate Afrika()
        {

var mapTemplate = new MapTemplate("Afrika") { Image = "afrika.png" };
var country1 = new CountryTemplate("1", "Marokko") { X = 287, Y = 100 };
mapTemplate.Countries.Add(country1);
var country2 = new CountryTemplate("2", "Westsahara") { X = 173, Y = 225 };
mapTemplate.Countries.Add(country2);
var country3 = new CountryTemplate("3", "Mauretanien") { X = 222, Y = 251 };
mapTemplate.Countries.Add(country3);
var country4 = new CountryTemplate("4", "Senegal") { X = 154, Y = 318 };
mapTemplate.Countries.Add(country4);
var country5 = new CountryTemplate("5", "Gambia") { X = 66, Y = 329 };
mapTemplate.Countries.Add(country5);
var country6 = new CountryTemplate("6", "Guinea-Bissau") { X = 97, Y = 367 };
mapTemplate.Countries.Add(country6);
var country7 = new CountryTemplate("7", "Guinea") { X = 220, Y = 397 };
mapTemplate.Countries.Add(country7);
var country8 = new CountryTemplate("8", "Sierra Leone") { X = 175, Y = 424 };
mapTemplate.Countries.Add(country8);
var country9 = new CountryTemplate("9", "Liberia") { X = 215, Y = 453 };
mapTemplate.Countries.Add(country9);
var country10 = new CountryTemplate("10", "Elfenbeinkueste") { X = 271, Y = 417 };
mapTemplate.Countries.Add(country10);
var country11 = new CountryTemplate("11", "Ghana") { X = 328, Y = 416 };
mapTemplate.Countries.Add(country11);
var country12 = new CountryTemplate("12", "Burkina Faso") { X = 330, Y = 357 };
mapTemplate.Countries.Add(country12);
var country13 = new CountryTemplate("13", "Togo") { X = 364, Y = 467 };
mapTemplate.Countries.Add(country13);
var country14 = new CountryTemplate("14", "Benin") { X = 372, Y = 408 };
mapTemplate.Countries.Add(country14);
var country15 = new CountryTemplate("15", "Nigeria") { X = 439, Y = 397 };
mapTemplate.Countries.Add(country15);
var country16 = new CountryTemplate("16", "Mali") { X = 317, Y = 282 };
mapTemplate.Countries.Add(country16);
var country17 = new CountryTemplate("17", "Niger") { X = 458, Y = 289 };
mapTemplate.Countries.Add(country17);
var country18 = new CountryTemplate("18", "Algerien") { X = 386, Y = 155 };
mapTemplate.Countries.Add(country18);
var country19 = new CountryTemplate("19", "Tunesien") { X = 477, Y = 75 };
mapTemplate.Countries.Add(country19);
var country20 = new CountryTemplate("20", "Libyen") { X = 566, Y = 179 };
mapTemplate.Countries.Add(country20);
var country21 = new CountryTemplate("21", "Aegypten") { X = 708, Y = 181 };
mapTemplate.Countries.Add(country21);
var country22 = new CountryTemplate("22", "Tschad") { X = 575, Y = 328 };
mapTemplate.Countries.Add(country22);
var country23 = new CountryTemplate("23", "Sudan") { X = 720, Y = 344 };
mapTemplate.Countries.Add(country23);
var country24 = new CountryTemplate("24", "ZentrafrRepublik") { X = 611, Y = 431 };
mapTemplate.Countries.Add(country24);
var country25 = new CountryTemplate("25", "Eritrea") { X = 823, Y = 315 };
mapTemplate.Countries.Add(country25);
var country26 = new CountryTemplate("26", "Dschibuti") { X = 925, Y = 349 };
mapTemplate.Countries.Add(country26);
var country27 = new CountryTemplate("27", "Somalia") { X = 900, Y = 492 };
mapTemplate.Countries.Add(country27);
var country28 = new CountryTemplate("28", "Kenia") { X = 823, Y = 511 };
mapTemplate.Countries.Add(country28);
var country29 = new CountryTemplate("29", "Aethopien") { X = 844, Y = 406 };
mapTemplate.Countries.Add(country29);
var country30 = new CountryTemplate("30", "Kamerun") { X = 497, Y = 461 };
mapTemplate.Countries.Add(country30);
var country31 = new CountryTemplate("31", "SaoTome") { X = 391, Y = 516 };
mapTemplate.Countries.Add(country31);
var country32 = new CountryTemplate("32", "Gabun") { X = 489, Y = 525 };
mapTemplate.Countries.Add(country32);
var country33 = new CountryTemplate("33", "RepKongo") { X = 539, Y = 546 };
mapTemplate.Countries.Add(country33);
var country34 = new CountryTemplate("34", "Kongo") { X = 617, Y = 550 };
mapTemplate.Countries.Add(country34);
var country35 = new CountryTemplate("35", "Ruanda") { X = 677, Y = 543 };
mapTemplate.Countries.Add(country35);
var country36 = new CountryTemplate("36", "Burundi") { X = 678, Y = 587 };
mapTemplate.Countries.Add(country36);
var country37 = new CountryTemplate("37", "Uganda") { X = 762, Y = 500 };
mapTemplate.Countries.Add(country37);
var country38 = new CountryTemplate("38", "Tansania") { X = 789, Y = 600 };
mapTemplate.Countries.Add(country38);
var country39 = new CountryTemplate("39", "Angola") { X = 556, Y = 683 };
mapTemplate.Countries.Add(country39);
var country40 = new CountryTemplate("40", "Sambia") { X = 669, Y = 707 };
mapTemplate.Countries.Add(country40);
var country41 = new CountryTemplate("41", "Namibia") { X = 555, Y = 812 };
mapTemplate.Countries.Add(country41);
var country42 = new CountryTemplate("42", "Botsuana") { X = 640, Y = 805 };
mapTemplate.Countries.Add(country42);
var country43 = new CountryTemplate("43", "Simbabwe") { X = 715, Y = 768 };
mapTemplate.Countries.Add(country43);
var country44 = new CountryTemplate("44", "Suedafrika") { X = 620, Y = 920 };
mapTemplate.Countries.Add(country44);
var country45 = new CountryTemplate("45", "Lesotho") { X = 734, Y = 927 };
mapTemplate.Countries.Add(country45);
var country46 = new CountryTemplate("46", "Swasiland") { X = 777, Y = 884 };
mapTemplate.Countries.Add(country46);
var country47 = new CountryTemplate("47", "Malawi") { X = 784, Y = 724 };
mapTemplate.Countries.Add(country47);
var country48 = new CountryTemplate("48", "Mosambik") { X = 795, Y = 773 };
mapTemplate.Countries.Add(country48);
var country49 = new CountryTemplate("49", "Madagaskar") { X = 929, Y = 770 };
mapTemplate.Countries.Add(country49);
var country50 = new CountryTemplate("50", "Äquatorialguinea") { X = 406, Y = 555 };
mapTemplate.Countries.Add(country50);
var continent1 = new Continent("1", 2);
continent1.Countries.Add(country1);
continent1.Countries.Add(country2);
continent1.Countries.Add(country3);
mapTemplate.Continents.Add(continent1);
var continent2 = new Continent("2", 3);
continent2.Countries.Add(country16);
continent2.Countries.Add(country17);
continent2.Countries.Add(country18);
continent2.Countries.Add(country19);
mapTemplate.Continents.Add(continent2);
var continent3 = new Continent("3", 4);
continent3.Countries.Add(country9);
continent3.Countries.Add(country10);
continent3.Countries.Add(country11);
continent3.Countries.Add(country12);
continent3.Countries.Add(country13);
continent3.Countries.Add(country14);
continent3.Countries.Add(country15);
mapTemplate.Continents.Add(continent3);
var continent4 = new Continent("4", 3);
continent4.Countries.Add(country4);
continent4.Countries.Add(country5);
continent4.Countries.Add(country6);
continent4.Countries.Add(country7);
continent4.Countries.Add(country8);
mapTemplate.Continents.Add(continent4);
var continent5 = new Continent("5", 1);
continent5.Countries.Add(country20);
continent5.Countries.Add(country21);
mapTemplate.Continents.Add(continent5);
var continent6 = new Continent("6", 2);
continent6.Countries.Add(country22);
continent6.Countries.Add(country23);
continent6.Countries.Add(country24);
mapTemplate.Continents.Add(continent6);
var continent7 = new Continent("7", 3);
continent7.Countries.Add(country25);
continent7.Countries.Add(country26);
continent7.Countries.Add(country27);
continent7.Countries.Add(country28);
continent7.Countries.Add(country29);
mapTemplate.Continents.Add(continent7);
var continent8 = new Continent("8", 3);
continent8.Countries.Add(country34);
continent8.Countries.Add(country35);
continent8.Countries.Add(country36);
continent8.Countries.Add(country37);
continent8.Countries.Add(country38);
mapTemplate.Continents.Add(continent8);
var continent9 = new Continent("9", 2);
continent9.Countries.Add(country30);
continent9.Countries.Add(country31);
continent9.Countries.Add(country50);
mapTemplate.Continents.Add(continent9);
var continent10 = new Continent("10", 1);
continent10.Countries.Add(country32);
continent10.Countries.Add(country33);
mapTemplate.Continents.Add(continent10);
var continent11 = new Continent("11", 2);
continent11.Countries.Add(country43);
continent11.Countries.Add(country44);
continent11.Countries.Add(country45);
continent11.Countries.Add(country46);
mapTemplate.Continents.Add(continent11);
var continent12 = new Continent("12", 1);
continent12.Countries.Add(country41);
continent12.Countries.Add(country42);
mapTemplate.Continents.Add(continent12);
var continent13 = new Continent("13", 2);
continent13.Countries.Add(country47);
continent13.Countries.Add(country48);
continent13.Countries.Add(country49);
mapTemplate.Continents.Add(continent13);
var continent14 = new Continent("14", 2);
continent14.Countries.Add(country39);
continent14.Countries.Add(country40);
mapTemplate.Continents.Add(continent14);
mapTemplate.Connections.Add(new Connection("1", "2"));
mapTemplate.Connections.Add(new Connection("1", "18"));
mapTemplate.Connections.Add(new Connection("2", "1"));
mapTemplate.Connections.Add(new Connection("2", "3"));
mapTemplate.Connections.Add(new Connection("2", "18"));
mapTemplate.Connections.Add(new Connection("3", "2"));
mapTemplate.Connections.Add(new Connection("3", "4"));
mapTemplate.Connections.Add(new Connection("3", "16"));
mapTemplate.Connections.Add(new Connection("3", "18"));
mapTemplate.Connections.Add(new Connection("4", "3"));
mapTemplate.Connections.Add(new Connection("4", "5"));
mapTemplate.Connections.Add(new Connection("4", "6"));
mapTemplate.Connections.Add(new Connection("4", "7"));
mapTemplate.Connections.Add(new Connection("4", "16"));
mapTemplate.Connections.Add(new Connection("5", "4"));
mapTemplate.Connections.Add(new Connection("6", "4"));
mapTemplate.Connections.Add(new Connection("6", "7"));
mapTemplate.Connections.Add(new Connection("7", "4"));
mapTemplate.Connections.Add(new Connection("7", "6"));
mapTemplate.Connections.Add(new Connection("7", "8"));
mapTemplate.Connections.Add(new Connection("7", "9"));
mapTemplate.Connections.Add(new Connection("7", "10"));
mapTemplate.Connections.Add(new Connection("7", "16"));
mapTemplate.Connections.Add(new Connection("8", "7"));
mapTemplate.Connections.Add(new Connection("8", "9"));
mapTemplate.Connections.Add(new Connection("9", "7"));
mapTemplate.Connections.Add(new Connection("9", "8"));
mapTemplate.Connections.Add(new Connection("9", "10"));
mapTemplate.Connections.Add(new Connection("10", "7"));
mapTemplate.Connections.Add(new Connection("10", "9"));
mapTemplate.Connections.Add(new Connection("10", "16"));
mapTemplate.Connections.Add(new Connection("10", "12"));
mapTemplate.Connections.Add(new Connection("10", "11"));
mapTemplate.Connections.Add(new Connection("11", "10"));
mapTemplate.Connections.Add(new Connection("11", "12"));
mapTemplate.Connections.Add(new Connection("11", "13"));
mapTemplate.Connections.Add(new Connection("12", "10"));
mapTemplate.Connections.Add(new Connection("12", "11"));
mapTemplate.Connections.Add(new Connection("12", "13"));
mapTemplate.Connections.Add(new Connection("12", "14"));
mapTemplate.Connections.Add(new Connection("12", "16"));
mapTemplate.Connections.Add(new Connection("12", "17"));
mapTemplate.Connections.Add(new Connection("13", "11"));
mapTemplate.Connections.Add(new Connection("13", "12"));
mapTemplate.Connections.Add(new Connection("13", "14"));
mapTemplate.Connections.Add(new Connection("14", "13"));
mapTemplate.Connections.Add(new Connection("14", "12"));
mapTemplate.Connections.Add(new Connection("14", "15"));
mapTemplate.Connections.Add(new Connection("14", "17"));
mapTemplate.Connections.Add(new Connection("15", "14"));
mapTemplate.Connections.Add(new Connection("15", "17"));
mapTemplate.Connections.Add(new Connection("15", "30"));
mapTemplate.Connections.Add(new Connection("15", "22"));
mapTemplate.Connections.Add(new Connection("16", "3"));
mapTemplate.Connections.Add(new Connection("16", "4"));
mapTemplate.Connections.Add(new Connection("16", "7"));
mapTemplate.Connections.Add(new Connection("16", "10"));
mapTemplate.Connections.Add(new Connection("16", "12"));
mapTemplate.Connections.Add(new Connection("16", "18"));
mapTemplate.Connections.Add(new Connection("16", "17"));
mapTemplate.Connections.Add(new Connection("17", "14"));
mapTemplate.Connections.Add(new Connection("17", "12"));
mapTemplate.Connections.Add(new Connection("17", "15"));
mapTemplate.Connections.Add(new Connection("17", "16"));
mapTemplate.Connections.Add(new Connection("17", "18"));
mapTemplate.Connections.Add(new Connection("17", "20"));
mapTemplate.Connections.Add(new Connection("17", "22"));
mapTemplate.Connections.Add(new Connection("18", "1"));
mapTemplate.Connections.Add(new Connection("18", "2"));
mapTemplate.Connections.Add(new Connection("18", "3"));
mapTemplate.Connections.Add(new Connection("18", "16"));
mapTemplate.Connections.Add(new Connection("18", "17"));
mapTemplate.Connections.Add(new Connection("18", "19"));
mapTemplate.Connections.Add(new Connection("18", "20"));
mapTemplate.Connections.Add(new Connection("19", "18"));
mapTemplate.Connections.Add(new Connection("19", "20"));
mapTemplate.Connections.Add(new Connection("20", "19"));
mapTemplate.Connections.Add(new Connection("20", "17"));
mapTemplate.Connections.Add(new Connection("20", "21"));
mapTemplate.Connections.Add(new Connection("20", "22"));
mapTemplate.Connections.Add(new Connection("20", "23"));
mapTemplate.Connections.Add(new Connection("20", "18"));
mapTemplate.Connections.Add(new Connection("21", "20"));
mapTemplate.Connections.Add(new Connection("21", "23"));
mapTemplate.Connections.Add(new Connection("22", "15"));
mapTemplate.Connections.Add(new Connection("22", "20"));
mapTemplate.Connections.Add(new Connection("22", "30"));
mapTemplate.Connections.Add(new Connection("22", "23"));
mapTemplate.Connections.Add(new Connection("22", "24"));
mapTemplate.Connections.Add(new Connection("22", "17"));
mapTemplate.Connections.Add(new Connection("23", "20"));
mapTemplate.Connections.Add(new Connection("23", "21"));
mapTemplate.Connections.Add(new Connection("23", "22"));
mapTemplate.Connections.Add(new Connection("23", "24"));
mapTemplate.Connections.Add(new Connection("23", "34"));
mapTemplate.Connections.Add(new Connection("23", "37"));
mapTemplate.Connections.Add(new Connection("23", "28"));
mapTemplate.Connections.Add(new Connection("23", "29"));
mapTemplate.Connections.Add(new Connection("23", "25"));
mapTemplate.Connections.Add(new Connection("24", "30"));
mapTemplate.Connections.Add(new Connection("24", "22"));
mapTemplate.Connections.Add(new Connection("24", "23"));
mapTemplate.Connections.Add(new Connection("24", "34"));
mapTemplate.Connections.Add(new Connection("24", "33"));
mapTemplate.Connections.Add(new Connection("25", "23"));
mapTemplate.Connections.Add(new Connection("25", "29"));
mapTemplate.Connections.Add(new Connection("25", "26"));
mapTemplate.Connections.Add(new Connection("26", "25"));
mapTemplate.Connections.Add(new Connection("26", "29"));
mapTemplate.Connections.Add(new Connection("26", "27"));
mapTemplate.Connections.Add(new Connection("27", "26"));
mapTemplate.Connections.Add(new Connection("27", "29"));
mapTemplate.Connections.Add(new Connection("27", "28"));
mapTemplate.Connections.Add(new Connection("28", "23"));
mapTemplate.Connections.Add(new Connection("28", "27"));
mapTemplate.Connections.Add(new Connection("28", "29"));
mapTemplate.Connections.Add(new Connection("28", "37"));
mapTemplate.Connections.Add(new Connection("28", "38"));
mapTemplate.Connections.Add(new Connection("29", "23"));
mapTemplate.Connections.Add(new Connection("29", "25"));
mapTemplate.Connections.Add(new Connection("29", "26"));
mapTemplate.Connections.Add(new Connection("29", "27"));
mapTemplate.Connections.Add(new Connection("29", "28"));
mapTemplate.Connections.Add(new Connection("30", "15"));
mapTemplate.Connections.Add(new Connection("30", "31"));
mapTemplate.Connections.Add(new Connection("30", "32"));
mapTemplate.Connections.Add(new Connection("30", "50"));
mapTemplate.Connections.Add(new Connection("30", "33"));
mapTemplate.Connections.Add(new Connection("30", "22"));
mapTemplate.Connections.Add(new Connection("30", "24"));
mapTemplate.Connections.Add(new Connection("31", "30"));
mapTemplate.Connections.Add(new Connection("32", "30"));
mapTemplate.Connections.Add(new Connection("32", "50"));
mapTemplate.Connections.Add(new Connection("32", "33"));
mapTemplate.Connections.Add(new Connection("33", "32"));
mapTemplate.Connections.Add(new Connection("33", "30"));
mapTemplate.Connections.Add(new Connection("33", "24"));
mapTemplate.Connections.Add(new Connection("33", "34"));
mapTemplate.Connections.Add(new Connection("33", "39"));
mapTemplate.Connections.Add(new Connection("34", "23"));
mapTemplate.Connections.Add(new Connection("34", "24"));
mapTemplate.Connections.Add(new Connection("34", "33"));
mapTemplate.Connections.Add(new Connection("34", "39"));
mapTemplate.Connections.Add(new Connection("34", "35"));
mapTemplate.Connections.Add(new Connection("34", "36"));
mapTemplate.Connections.Add(new Connection("34", "38"));
mapTemplate.Connections.Add(new Connection("34", "37"));
mapTemplate.Connections.Add(new Connection("34", "40"));
mapTemplate.Connections.Add(new Connection("35", "34"));
mapTemplate.Connections.Add(new Connection("35", "37"));
mapTemplate.Connections.Add(new Connection("35", "36"));
mapTemplate.Connections.Add(new Connection("35", "38"));
mapTemplate.Connections.Add(new Connection("36", "34"));
mapTemplate.Connections.Add(new Connection("36", "35"));
mapTemplate.Connections.Add(new Connection("36", "38"));
mapTemplate.Connections.Add(new Connection("37", "23"));
mapTemplate.Connections.Add(new Connection("37", "28"));
mapTemplate.Connections.Add(new Connection("37", "34"));
mapTemplate.Connections.Add(new Connection("37", "35"));
mapTemplate.Connections.Add(new Connection("37", "38"));
mapTemplate.Connections.Add(new Connection("38", "28"));
mapTemplate.Connections.Add(new Connection("38", "34"));
mapTemplate.Connections.Add(new Connection("38", "37"));
mapTemplate.Connections.Add(new Connection("38", "36"));
mapTemplate.Connections.Add(new Connection("38", "40"));
mapTemplate.Connections.Add(new Connection("38", "47"));
mapTemplate.Connections.Add(new Connection("38", "48"));
mapTemplate.Connections.Add(new Connection("38", "35"));
mapTemplate.Connections.Add(new Connection("39", "33"));
mapTemplate.Connections.Add(new Connection("39", "34"));
mapTemplate.Connections.Add(new Connection("39", "40"));
mapTemplate.Connections.Add(new Connection("39", "41"));
mapTemplate.Connections.Add(new Connection("40", "39"));
mapTemplate.Connections.Add(new Connection("40", "34"));
mapTemplate.Connections.Add(new Connection("40", "38"));
mapTemplate.Connections.Add(new Connection("40", "48"));
mapTemplate.Connections.Add(new Connection("40", "42"));
mapTemplate.Connections.Add(new Connection("40", "41"));
mapTemplate.Connections.Add(new Connection("40", "43"));
mapTemplate.Connections.Add(new Connection("40", "47"));
mapTemplate.Connections.Add(new Connection("41", "39"));
mapTemplate.Connections.Add(new Connection("41", "44"));
mapTemplate.Connections.Add(new Connection("41", "40"));
mapTemplate.Connections.Add(new Connection("41", "42"));
mapTemplate.Connections.Add(new Connection("42", "44"));
mapTemplate.Connections.Add(new Connection("42", "40"));
mapTemplate.Connections.Add(new Connection("42", "43"));
mapTemplate.Connections.Add(new Connection("42", "41"));
mapTemplate.Connections.Add(new Connection("43", "48"));
mapTemplate.Connections.Add(new Connection("43", "42"));
mapTemplate.Connections.Add(new Connection("43", "40"));
mapTemplate.Connections.Add(new Connection("43", "44"));
mapTemplate.Connections.Add(new Connection("44", "41"));
mapTemplate.Connections.Add(new Connection("44", "42"));
mapTemplate.Connections.Add(new Connection("44", "45"));
mapTemplate.Connections.Add(new Connection("44", "46"));
mapTemplate.Connections.Add(new Connection("44", "48"));
mapTemplate.Connections.Add(new Connection("44", "43"));
mapTemplate.Connections.Add(new Connection("45", "44"));
mapTemplate.Connections.Add(new Connection("46", "44"));
mapTemplate.Connections.Add(new Connection("46", "48"));
mapTemplate.Connections.Add(new Connection("47", "38"));
mapTemplate.Connections.Add(new Connection("47", "48"));
mapTemplate.Connections.Add(new Connection("47", "40"));
mapTemplate.Connections.Add(new Connection("48", "38"));
mapTemplate.Connections.Add(new Connection("48", "49"));
mapTemplate.Connections.Add(new Connection("48", "46"));
mapTemplate.Connections.Add(new Connection("48", "47"));
mapTemplate.Connections.Add(new Connection("48", "43"));
mapTemplate.Connections.Add(new Connection("48", "40"));
mapTemplate.Connections.Add(new Connection("48", "44"));
mapTemplate.Connections.Add(new Connection("49", "48"));
mapTemplate.Connections.Add(new Connection("50", "30"));
mapTemplate.Connections.Add(new Connection("50", "32"));

            return mapTemplate;
		}
    }
}

