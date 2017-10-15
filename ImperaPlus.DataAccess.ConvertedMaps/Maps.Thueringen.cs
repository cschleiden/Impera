
using ImperaPlus.Domain.Map;

namespace ImperaPlus.DataAccess.ConvertedMaps
{
    public static partial class Maps
    {
        public static MapTemplate Thueringen()
        {

var mapTemplate = new MapTemplate("Thueringen") { Image = "thueringen1.png" };
var country1 = new CountryTemplate("1", "Heiligenstadt") { X = 84, Y = 156 };
mapTemplate.Countries.Add(country1);
var country2 = new CountryTemplate("2", "Worbis") { X = 208, Y = 96 };
mapTemplate.Countries.Add(country2);
var country3 = new CountryTemplate("3", "Dingelst�dt") { X = 125, Y = 212 };
mapTemplate.Countries.Add(country3);
var country4 = new CountryTemplate("4", "Leinefelde") { X = 187, Y = 164 };
mapTemplate.Countries.Add(country4);
var country5 = new CountryTemplate("5", "Werther") { X = 290, Y = 83 };
mapTemplate.Countries.Add(country5);
var country6 = new CountryTemplate("6", "Ellrich") { X = 372, Y = 41 };
mapTemplate.Countries.Add(country6);
var country7 = new CountryTemplate("7", "Nordhausen") { X = 380, Y = 98 };
mapTemplate.Countries.Add(country7);
var country8 = new CountryTemplate("8", "M�hlhausen") { X = 191, Y = 290 };
mapTemplate.Countries.Add(country8);
var country9 = new CountryTemplate("9", "Schlotheim") { X = 258, Y = 238 };
mapTemplate.Countries.Add(country9);
var country10 = new CountryTemplate("10", "Bad Tennstedt") { X = 355, Y = 306 };
mapTemplate.Countries.Add(country10);
var country11 = new CountryTemplate("11", "Bad Langensalza") { X = 260, Y = 311 };
mapTemplate.Countries.Add(country11);
var country12 = new CountryTemplate("12", "Sondershausen") { X = 346, Y = 191 };
mapTemplate.Countries.Add(country12);
var country13 = new CountryTemplate("13", "Artern") { X = 479, Y = 177 };
mapTemplate.Countries.Add(country13);
var country14 = new CountryTemplate("14", "Rossleben") { X = 571, Y = 179 };
mapTemplate.Countries.Add(country14);
var country15 = new CountryTemplate("15", "Bad Frankenhausen") { X = 402, Y = 218 };
mapTemplate.Countries.Add(country15);
var country16 = new CountryTemplate("16", "Creuzburg") { X = 149, Y = 354 };
mapTemplate.Countries.Add(country16);
var country17 = new CountryTemplate("17", "Ruhla") { X = 213, Y = 430 };
mapTemplate.Countries.Add(country17);
var country18 = new CountryTemplate("18", "Vacha") { X = 88, Y = 453 };
mapTemplate.Countries.Add(country18);
var country19 = new CountryTemplate("19", "Bad Liebenstein") { X = 153, Y = 492 };
mapTemplate.Countries.Add(country19);
var country20 = new CountryTemplate("20", "Bad Salzungen") { X = 71, Y = 552 };
mapTemplate.Countries.Add(country20);
var country21 = new CountryTemplate("21", "Eisenach") { X = 158, Y = 421 };
mapTemplate.Countries.Add(country21);
var country22 = new CountryTemplate("22", "Stregda") { X = 170, Y = 395 };
mapTemplate.Countries.Add(country22);
var country23 = new CountryTemplate("23", "Schmalkalden") { X = 172, Y = 571 };
mapTemplate.Countries.Add(country23);
var country24 = new CountryTemplate("24", "Oberhof") { X = 307, Y = 601 };
mapTemplate.Countries.Add(country24);
var country25 = new CountryTemplate("25", "Zella-Mehlis") { X = 220, Y = 659 };
mapTemplate.Countries.Add(country25);
var country26 = new CountryTemplate("26", "Meiningen") { X = 226, Y = 733 };
mapTemplate.Countries.Add(country26);
var country27 = new CountryTemplate("27", "Suhl") { X = 300, Y = 652 };
mapTemplate.Countries.Add(country27);
var country28 = new CountryTemplate("28", "Goldlauter") { X = 338, Y = 635 };
mapTemplate.Countries.Add(country28);
var country29 = new CountryTemplate("29", "Schleusingen") { X = 304, Y = 698 };
mapTemplate.Countries.Add(country29);
var country30 = new CountryTemplate("30", "Hildburghausen") { X = 305, Y = 745 };
mapTemplate.Countries.Add(country30);
var country31 = new CountryTemplate("31", "Eisfeld") { X = 406, Y = 749 };
mapTemplate.Countries.Add(country31);
var country32 = new CountryTemplate("32", "Heldburg") { X = 314, Y = 821 };
mapTemplate.Countries.Add(country32);
var country33 = new CountryTemplate("33", "Steinach") { X = 483, Y = 727 };
mapTemplate.Countries.Add(country33);
var country34 = new CountryTemplate("34", "Schalkau") { X = 477, Y = 760 };
mapTemplate.Countries.Add(country34);
var country35 = new CountryTemplate("35", "Sonneberg") { X = 534, Y = 797 };
mapTemplate.Countries.Add(country35);
var country36 = new CountryTemplate("36", "S�mmerda") { X = 503, Y = 279 };
mapTemplate.Countries.Add(country36);
var country37 = new CountryTemplate("37", "Elxleben") { X = 458, Y = 314 };
mapTemplate.Countries.Add(country37);
var country38 = new CountryTemplate("38", "Buttst�dt") { X = 572, Y = 317 };
mapTemplate.Countries.Add(country38);
var country39 = new CountryTemplate("39", "Erfurt") { X = 428, Y = 403 };
mapTemplate.Countries.Add(country39);
var country40 = new CountryTemplate("40", "Vieselbach") { X = 472, Y = 380 };
mapTemplate.Countries.Add(country40);
var country41 = new CountryTemplate("41", "Egstedt") { X = 469, Y = 427 };
mapTemplate.Countries.Add(country41);
var country42 = new CountryTemplate("42", "Gotha") { X = 366, Y = 390 };
mapTemplate.Countries.Add(country42);
var country43 = new CountryTemplate("43", "Waltershausen") { X = 306, Y = 411 };
mapTemplate.Countries.Add(country43);
var country44 = new CountryTemplate("44", "Friedrichroda") { X = 327, Y = 482 };
mapTemplate.Countries.Add(country44);
var country45 = new CountryTemplate("45", "Ohrdruf") { X = 322, Y = 554 };
mapTemplate.Countries.Add(country45);
var country46 = new CountryTemplate("46", "Weimar") { X = 596, Y = 425 };
mapTemplate.Countries.Add(country46);
var country47 = new CountryTemplate("47", "Tiefurt") { X = 580, Y = 400 };
mapTemplate.Countries.Add(country47);
var country48 = new CountryTemplate("48", "Neumark") { X = 603, Y = 370 };
mapTemplate.Countries.Add(country48);
var country49 = new CountryTemplate("49", "Apolda") { X = 662, Y = 379 };
mapTemplate.Countries.Add(country49);
var country50 = new CountryTemplate("50", "Bad Berka") { X = 543, Y = 473 };
mapTemplate.Countries.Add(country50);
var country51 = new CountryTemplate("51", "Magdala") { X = 613, Y = 483 };
mapTemplate.Countries.Add(country51);
var country52 = new CountryTemplate("52", "Arnstadt") { X = 443, Y = 506 };
mapTemplate.Countries.Add(country52);
var country53 = new CountryTemplate("53", "Ilmenau") { X = 393, Y = 582 };
mapTemplate.Countries.Add(country53);
var country54 = new CountryTemplate("54", "Stadtilm") { X = 484, Y = 559 };
mapTemplate.Countries.Add(country54);
var country55 = new CountryTemplate("55", "Grossbreitenbach") { X = 448, Y = 660 };
mapTemplate.Countries.Add(country55);
var country56 = new CountryTemplate("56", "Rudolstadt") { X = 581, Y = 567 };
mapTemplate.Countries.Add(country56);
var country57 = new CountryTemplate("57", "Bad Blankenburg") { X = 529, Y = 620 };
mapTemplate.Countries.Add(country57);
var country58 = new CountryTemplate("58", "Saalfeld") { X = 630, Y = 642 };
mapTemplate.Countries.Add(country58);
var country59 = new CountryTemplate("59", "Lehesten") { X = 654, Y = 677 };
mapTemplate.Countries.Add(country59);
var country60 = new CountryTemplate("60", "Jena") { X = 702, Y = 462 };
mapTemplate.Countries.Add(country60);
var country61 = new CountryTemplate("61", "Jena-Zw�tzen") { X = 705, Y = 434 };
mapTemplate.Countries.Add(country61);
var country62 = new CountryTemplate("62", "Dornburg-Camburg") { X = 753, Y = 437 };
mapTemplate.Countries.Add(country62);
var country63 = new CountryTemplate("63", "Eisenberg") { X = 819, Y = 416 };
mapTemplate.Countries.Add(country63);
var country64 = new CountryTemplate("64", "Kahla") { X = 684, Y = 511 };
mapTemplate.Countries.Add(country64);
var country65 = new CountryTemplate("65", "Stadtroda") { X = 776, Y = 482 };
mapTemplate.Countries.Add(country65);
var country66 = new CountryTemplate("66", "Neustadt") { X = 790, Y = 592 };
mapTemplate.Countries.Add(country66);
var country67 = new CountryTemplate("67", "P�ssneck") { X = 701, Y = 611 };
mapTemplate.Countries.Add(country67);
var country68 = new CountryTemplate("68", "Schleiz") { X = 783, Y = 656 };
mapTemplate.Countries.Add(country68);
var country69 = new CountryTemplate("69", "Bad Lobenstein") { X = 714, Y = 723 };
mapTemplate.Countries.Add(country69);
var country70 = new CountryTemplate("70", "Hirschberg") { X = 794, Y = 736 };
mapTemplate.Countries.Add(country70);
var country71 = new CountryTemplate("71", "Gera") { X = 902, Y = 493 };
mapTemplate.Countries.Add(country71);
var country72 = new CountryTemplate("72", "Gera-Langenberg") { X = 905, Y = 457 };
mapTemplate.Countries.Add(country72);
var country73 = new CountryTemplate("73", "Weida") { X = 854, Y = 508 };
mapTemplate.Countries.Add(country73);
var country74 = new CountryTemplate("74", "Ronneburg") { X = 934, Y = 541 };
mapTemplate.Countries.Add(country74);
var country75 = new CountryTemplate("75", "Zeulenroda") { X = 867, Y = 615 };
mapTemplate.Countries.Add(country75);
var country76 = new CountryTemplate("76", "Greiz") { X = 949, Y = 594 };
mapTemplate.Countries.Add(country76);
var country77 = new CountryTemplate("77", "Meuselwitz") { X = 1010, Y = 397 };
mapTemplate.Countries.Add(country77);
var country78 = new CountryTemplate("78", "Altenburg") { X = 1069, Y = 442 };
mapTemplate.Countries.Add(country78);
var country79 = new CountryTemplate("79", "Schm�lln") { X = 1001, Y = 474 };
mapTemplate.Countries.Add(country79);
var continent1 = new Continent("1", 2);
continent1.Countries.Add(country1);
continent1.Countries.Add(country2);
continent1.Countries.Add(country3);
continent1.Countries.Add(country4);
mapTemplate.Continents.Add(continent1);
var continent2 = new Continent("2", 2);
continent2.Countries.Add(country5);
continent2.Countries.Add(country6);
continent2.Countries.Add(country7);
mapTemplate.Continents.Add(continent2);
var continent3 = new Continent("3", 3);
continent3.Countries.Add(country8);
continent3.Countries.Add(country9);
continent3.Countries.Add(country10);
continent3.Countries.Add(country11);
mapTemplate.Continents.Add(continent3);
var continent4 = new Continent("4", 3);
continent4.Countries.Add(country12);
continent4.Countries.Add(country13);
continent4.Countries.Add(country14);
continent4.Countries.Add(country15);
mapTemplate.Continents.Add(continent4);
var continent5 = new Continent("5", 4);
continent5.Countries.Add(country16);
continent5.Countries.Add(country17);
continent5.Countries.Add(country18);
continent5.Countries.Add(country19);
continent5.Countries.Add(country20);
mapTemplate.Continents.Add(continent5);
var continent6 = new Continent("6", 1);
continent6.Countries.Add(country21);
continent6.Countries.Add(country22);
mapTemplate.Continents.Add(continent6);
var continent7 = new Continent("7", 3);
continent7.Countries.Add(country23);
continent7.Countries.Add(country24);
continent7.Countries.Add(country25);
continent7.Countries.Add(country26);
mapTemplate.Continents.Add(continent7);
var continent8 = new Continent("8", 1);
continent8.Countries.Add(country27);
continent8.Countries.Add(country28);
mapTemplate.Continents.Add(continent8);
var continent9 = new Continent("9", 3);
continent9.Countries.Add(country29);
continent9.Countries.Add(country30);
continent9.Countries.Add(country31);
continent9.Countries.Add(country32);
mapTemplate.Continents.Add(continent9);
var continent10 = new Continent("10", 2);
continent10.Countries.Add(country33);
continent10.Countries.Add(country34);
continent10.Countries.Add(country35);
mapTemplate.Continents.Add(continent10);
var continent11 = new Continent("11", 2);
continent11.Countries.Add(country36);
continent11.Countries.Add(country37);
continent11.Countries.Add(country38);
mapTemplate.Continents.Add(continent11);
var continent12 = new Continent("12", 2);
continent12.Countries.Add(country39);
continent12.Countries.Add(country40);
continent12.Countries.Add(country41);
mapTemplate.Continents.Add(continent12);
var continent13 = new Continent("13", 3);
continent13.Countries.Add(country42);
continent13.Countries.Add(country43);
continent13.Countries.Add(country44);
continent13.Countries.Add(country45);
mapTemplate.Continents.Add(continent13);
var continent14 = new Continent("14", 1);
continent14.Countries.Add(country46);
continent14.Countries.Add(country47);
mapTemplate.Continents.Add(continent14);
var continent15 = new Continent("15", 3);
continent15.Countries.Add(country48);
continent15.Countries.Add(country49);
continent15.Countries.Add(country50);
continent15.Countries.Add(country51);
mapTemplate.Continents.Add(continent15);
var continent16 = new Continent("16", 3);
continent16.Countries.Add(country52);
continent16.Countries.Add(country53);
continent16.Countries.Add(country54);
continent16.Countries.Add(country55);
mapTemplate.Continents.Add(continent16);
var continent17 = new Continent("17", 3);
continent17.Countries.Add(country56);
continent17.Countries.Add(country57);
continent17.Countries.Add(country58);
continent17.Countries.Add(country59);
mapTemplate.Continents.Add(continent17);
var continent18 = new Continent("18", 1);
continent18.Countries.Add(country60);
continent18.Countries.Add(country61);
mapTemplate.Continents.Add(continent18);
var continent19 = new Continent("19", 3);
continent19.Countries.Add(country62);
continent19.Countries.Add(country63);
continent19.Countries.Add(country64);
continent19.Countries.Add(country65);
mapTemplate.Continents.Add(continent19);
var continent20 = new Continent("20", 3);
continent20.Countries.Add(country66);
continent20.Countries.Add(country67);
continent20.Countries.Add(country68);
continent20.Countries.Add(country69);
continent20.Countries.Add(country70);
mapTemplate.Continents.Add(continent20);
var continent21 = new Continent("21", 3);
continent21.Countries.Add(country73);
continent21.Countries.Add(country74);
continent21.Countries.Add(country75);
continent21.Countries.Add(country76);
mapTemplate.Continents.Add(continent21);
var continent22 = new Continent("22", 1);
continent22.Countries.Add(country71);
continent22.Countries.Add(country72);
mapTemplate.Continents.Add(continent22);
var continent23 = new Continent("23", 2);
continent23.Countries.Add(country77);
continent23.Countries.Add(country78);
continent23.Countries.Add(country79);
mapTemplate.Continents.Add(continent23);
mapTemplate.Connections.Add(new Connection("1", "2"));
mapTemplate.Connections.Add(new Connection("1", "3"));
mapTemplate.Connections.Add(new Connection("1", "4"));
mapTemplate.Connections.Add(new Connection("2", "4"));
mapTemplate.Connections.Add(new Connection("2", "5"));
mapTemplate.Connections.Add(new Connection("2", "1"));
mapTemplate.Connections.Add(new Connection("3", "8"));
mapTemplate.Connections.Add(new Connection("3", "4"));
mapTemplate.Connections.Add(new Connection("3", "1"));
mapTemplate.Connections.Add(new Connection("4", "8"));
mapTemplate.Connections.Add(new Connection("4", "9"));
mapTemplate.Connections.Add(new Connection("4", "5"));
mapTemplate.Connections.Add(new Connection("4", "12"));
mapTemplate.Connections.Add(new Connection("4", "1"));
mapTemplate.Connections.Add(new Connection("4", "3"));
mapTemplate.Connections.Add(new Connection("4", "2"));
mapTemplate.Connections.Add(new Connection("5", "6"));
mapTemplate.Connections.Add(new Connection("5", "7"));
mapTemplate.Connections.Add(new Connection("5", "12"));
mapTemplate.Connections.Add(new Connection("5", "4"));
mapTemplate.Connections.Add(new Connection("5", "2"));
mapTemplate.Connections.Add(new Connection("6", "5"));
mapTemplate.Connections.Add(new Connection("6", "7"));
mapTemplate.Connections.Add(new Connection("7", "5"));
mapTemplate.Connections.Add(new Connection("7", "6"));
mapTemplate.Connections.Add(new Connection("7", "12"));
mapTemplate.Connections.Add(new Connection("7", "13"));
mapTemplate.Connections.Add(new Connection("8", "3"));
mapTemplate.Connections.Add(new Connection("8", "4"));
mapTemplate.Connections.Add(new Connection("8", "9"));
mapTemplate.Connections.Add(new Connection("8", "10"));
mapTemplate.Connections.Add(new Connection("8", "11"));
mapTemplate.Connections.Add(new Connection("8", "16"));
mapTemplate.Connections.Add(new Connection("9", "4"));
mapTemplate.Connections.Add(new Connection("9", "12"));
mapTemplate.Connections.Add(new Connection("9", "8"));
mapTemplate.Connections.Add(new Connection("9", "10"));
mapTemplate.Connections.Add(new Connection("9", "15"));
mapTemplate.Connections.Add(new Connection("10", "11"));
mapTemplate.Connections.Add(new Connection("10", "8"));
mapTemplate.Connections.Add(new Connection("10", "9"));
mapTemplate.Connections.Add(new Connection("10", "15"));
mapTemplate.Connections.Add(new Connection("10", "37"));
mapTemplate.Connections.Add(new Connection("10", "42"));
mapTemplate.Connections.Add(new Connection("11", "16"));
mapTemplate.Connections.Add(new Connection("11", "17"));
mapTemplate.Connections.Add(new Connection("11", "8"));
mapTemplate.Connections.Add(new Connection("11", "10"));
mapTemplate.Connections.Add(new Connection("11", "42"));
mapTemplate.Connections.Add(new Connection("11", "43"));
mapTemplate.Connections.Add(new Connection("12", "4"));
mapTemplate.Connections.Add(new Connection("12", "5"));
mapTemplate.Connections.Add(new Connection("12", "7"));
mapTemplate.Connections.Add(new Connection("12", "13"));
mapTemplate.Connections.Add(new Connection("12", "15"));
mapTemplate.Connections.Add(new Connection("12", "9"));
mapTemplate.Connections.Add(new Connection("13", "7"));
mapTemplate.Connections.Add(new Connection("13", "12"));
mapTemplate.Connections.Add(new Connection("13", "14"));
mapTemplate.Connections.Add(new Connection("13", "15"));
mapTemplate.Connections.Add(new Connection("13", "36"));
mapTemplate.Connections.Add(new Connection("14", "13"));
mapTemplate.Connections.Add(new Connection("14", "36"));
mapTemplate.Connections.Add(new Connection("14", "38"));
mapTemplate.Connections.Add(new Connection("15", "12"));
mapTemplate.Connections.Add(new Connection("15", "13"));
mapTemplate.Connections.Add(new Connection("15", "36"));
mapTemplate.Connections.Add(new Connection("15", "37"));
mapTemplate.Connections.Add(new Connection("15", "9"));
mapTemplate.Connections.Add(new Connection("15", "10"));
mapTemplate.Connections.Add(new Connection("16", "8"));
mapTemplate.Connections.Add(new Connection("16", "11"));
mapTemplate.Connections.Add(new Connection("16", "17"));
mapTemplate.Connections.Add(new Connection("16", "21"));
mapTemplate.Connections.Add(new Connection("16", "22"));
mapTemplate.Connections.Add(new Connection("17", "16"));
mapTemplate.Connections.Add(new Connection("17", "11"));
mapTemplate.Connections.Add(new Connection("17", "43"));
mapTemplate.Connections.Add(new Connection("17", "44"));
mapTemplate.Connections.Add(new Connection("17", "21"));
mapTemplate.Connections.Add(new Connection("17", "22"));
mapTemplate.Connections.Add(new Connection("17", "18"));
mapTemplate.Connections.Add(new Connection("17", "19"));
mapTemplate.Connections.Add(new Connection("18", "17"));
mapTemplate.Connections.Add(new Connection("18", "19"));
mapTemplate.Connections.Add(new Connection("18", "20"));
mapTemplate.Connections.Add(new Connection("18", "21"));
mapTemplate.Connections.Add(new Connection("19", "17"));
mapTemplate.Connections.Add(new Connection("19", "18"));
mapTemplate.Connections.Add(new Connection("19", "20"));
mapTemplate.Connections.Add(new Connection("19", "44"));
mapTemplate.Connections.Add(new Connection("19", "23"));
mapTemplate.Connections.Add(new Connection("20", "18"));
mapTemplate.Connections.Add(new Connection("20", "19"));
mapTemplate.Connections.Add(new Connection("20", "23"));
mapTemplate.Connections.Add(new Connection("21", "16"));
mapTemplate.Connections.Add(new Connection("21", "17"));
mapTemplate.Connections.Add(new Connection("21", "18"));
mapTemplate.Connections.Add(new Connection("21", "22"));
mapTemplate.Connections.Add(new Connection("22", "16"));
mapTemplate.Connections.Add(new Connection("22", "17"));
mapTemplate.Connections.Add(new Connection("22", "21"));
mapTemplate.Connections.Add(new Connection("23", "19"));
mapTemplate.Connections.Add(new Connection("23", "20"));
mapTemplate.Connections.Add(new Connection("23", "44"));
mapTemplate.Connections.Add(new Connection("23", "24"));
mapTemplate.Connections.Add(new Connection("23", "25"));
mapTemplate.Connections.Add(new Connection("23", "26"));
mapTemplate.Connections.Add(new Connection("24", "44"));
mapTemplate.Connections.Add(new Connection("24", "45"));
mapTemplate.Connections.Add(new Connection("24", "23"));
mapTemplate.Connections.Add(new Connection("24", "25"));
mapTemplate.Connections.Add(new Connection("24", "27"));
mapTemplate.Connections.Add(new Connection("24", "28"));
mapTemplate.Connections.Add(new Connection("24", "53"));
mapTemplate.Connections.Add(new Connection("25", "23"));
mapTemplate.Connections.Add(new Connection("25", "24"));
mapTemplate.Connections.Add(new Connection("25", "26"));
mapTemplate.Connections.Add(new Connection("25", "27"));
mapTemplate.Connections.Add(new Connection("25", "29"));
mapTemplate.Connections.Add(new Connection("26", "23"));
mapTemplate.Connections.Add(new Connection("26", "25"));
mapTemplate.Connections.Add(new Connection("26", "29"));
mapTemplate.Connections.Add(new Connection("26", "30"));
mapTemplate.Connections.Add(new Connection("27", "24"));
mapTemplate.Connections.Add(new Connection("27", "25"));
mapTemplate.Connections.Add(new Connection("27", "28"));
mapTemplate.Connections.Add(new Connection("27", "29"));
mapTemplate.Connections.Add(new Connection("28", "24"));
mapTemplate.Connections.Add(new Connection("28", "27"));
mapTemplate.Connections.Add(new Connection("28", "29"));
mapTemplate.Connections.Add(new Connection("28", "53"));
mapTemplate.Connections.Add(new Connection("28", "55"));
mapTemplate.Connections.Add(new Connection("29", "27"));
mapTemplate.Connections.Add(new Connection("29", "28"));
mapTemplate.Connections.Add(new Connection("29", "25"));
mapTemplate.Connections.Add(new Connection("29", "26"));
mapTemplate.Connections.Add(new Connection("29", "55"));
mapTemplate.Connections.Add(new Connection("29", "57"));
mapTemplate.Connections.Add(new Connection("29", "30"));
mapTemplate.Connections.Add(new Connection("29", "31"));
mapTemplate.Connections.Add(new Connection("29", "33"));
mapTemplate.Connections.Add(new Connection("30", "31"));
mapTemplate.Connections.Add(new Connection("30", "32"));
mapTemplate.Connections.Add(new Connection("30", "26"));
mapTemplate.Connections.Add(new Connection("30", "29"));
mapTemplate.Connections.Add(new Connection("31", "29"));
mapTemplate.Connections.Add(new Connection("31", "30"));
mapTemplate.Connections.Add(new Connection("31", "33"));
mapTemplate.Connections.Add(new Connection("31", "34"));
mapTemplate.Connections.Add(new Connection("32", "30"));
mapTemplate.Connections.Add(new Connection("33", "34"));
mapTemplate.Connections.Add(new Connection("33", "35"));
mapTemplate.Connections.Add(new Connection("33", "57"));
mapTemplate.Connections.Add(new Connection("33", "31"));
mapTemplate.Connections.Add(new Connection("33", "29"));
mapTemplate.Connections.Add(new Connection("34", "31"));
mapTemplate.Connections.Add(new Connection("34", "33"));
mapTemplate.Connections.Add(new Connection("34", "35"));
mapTemplate.Connections.Add(new Connection("35", "33"));
mapTemplate.Connections.Add(new Connection("35", "34"));
mapTemplate.Connections.Add(new Connection("36", "37"));
mapTemplate.Connections.Add(new Connection("36", "38"));
mapTemplate.Connections.Add(new Connection("36", "13"));
mapTemplate.Connections.Add(new Connection("36", "14"));
mapTemplate.Connections.Add(new Connection("36", "15"));
mapTemplate.Connections.Add(new Connection("37", "10"));
mapTemplate.Connections.Add(new Connection("37", "42"));
mapTemplate.Connections.Add(new Connection("37", "39"));
mapTemplate.Connections.Add(new Connection("37", "40"));
mapTemplate.Connections.Add(new Connection("37", "36"));
mapTemplate.Connections.Add(new Connection("37", "38"));
mapTemplate.Connections.Add(new Connection("37", "15"));
mapTemplate.Connections.Add(new Connection("38", "14"));
mapTemplate.Connections.Add(new Connection("38", "40"));
mapTemplate.Connections.Add(new Connection("38", "48"));
mapTemplate.Connections.Add(new Connection("38", "50"));
mapTemplate.Connections.Add(new Connection("38", "36"));
mapTemplate.Connections.Add(new Connection("38", "37"));
mapTemplate.Connections.Add(new Connection("38", "49"));
mapTemplate.Connections.Add(new Connection("39", "37"));
mapTemplate.Connections.Add(new Connection("39", "42"));
mapTemplate.Connections.Add(new Connection("39", "40"));
mapTemplate.Connections.Add(new Connection("39", "41"));
mapTemplate.Connections.Add(new Connection("40", "37"));
mapTemplate.Connections.Add(new Connection("40", "38"));
mapTemplate.Connections.Add(new Connection("40", "50"));
mapTemplate.Connections.Add(new Connection("40", "39"));
mapTemplate.Connections.Add(new Connection("40", "41"));
mapTemplate.Connections.Add(new Connection("41", "39"));
mapTemplate.Connections.Add(new Connection("41", "40"));
mapTemplate.Connections.Add(new Connection("41", "42"));
mapTemplate.Connections.Add(new Connection("41", "52"));
mapTemplate.Connections.Add(new Connection("41", "50"));
mapTemplate.Connections.Add(new Connection("42", "43"));
mapTemplate.Connections.Add(new Connection("42", "44"));
mapTemplate.Connections.Add(new Connection("42", "45"));
mapTemplate.Connections.Add(new Connection("42", "10"));
mapTemplate.Connections.Add(new Connection("42", "11"));
mapTemplate.Connections.Add(new Connection("42", "37"));
mapTemplate.Connections.Add(new Connection("42", "39"));
mapTemplate.Connections.Add(new Connection("42", "41"));
mapTemplate.Connections.Add(new Connection("42", "52"));
mapTemplate.Connections.Add(new Connection("42", "53"));
mapTemplate.Connections.Add(new Connection("43", "11"));
mapTemplate.Connections.Add(new Connection("43", "17"));
mapTemplate.Connections.Add(new Connection("43", "42"));
mapTemplate.Connections.Add(new Connection("43", "44"));
mapTemplate.Connections.Add(new Connection("44", "17"));
mapTemplate.Connections.Add(new Connection("44", "19"));
mapTemplate.Connections.Add(new Connection("44", "23"));
mapTemplate.Connections.Add(new Connection("44", "24"));
mapTemplate.Connections.Add(new Connection("44", "42"));
mapTemplate.Connections.Add(new Connection("44", "45"));
mapTemplate.Connections.Add(new Connection("44", "43"));
mapTemplate.Connections.Add(new Connection("45", "42"));
mapTemplate.Connections.Add(new Connection("45", "53"));
mapTemplate.Connections.Add(new Connection("45", "44"));
mapTemplate.Connections.Add(new Connection("45", "24"));
mapTemplate.Connections.Add(new Connection("46", "50"));
mapTemplate.Connections.Add(new Connection("46", "51"));
mapTemplate.Connections.Add(new Connection("46", "47"));
mapTemplate.Connections.Add(new Connection("46", "49"));
mapTemplate.Connections.Add(new Connection("47", "48"));
mapTemplate.Connections.Add(new Connection("47", "50"));
mapTemplate.Connections.Add(new Connection("47", "46"));
mapTemplate.Connections.Add(new Connection("47", "49"));
mapTemplate.Connections.Add(new Connection("48", "38"));
mapTemplate.Connections.Add(new Connection("48", "47"));
mapTemplate.Connections.Add(new Connection("48", "49"));
mapTemplate.Connections.Add(new Connection("48", "50"));
mapTemplate.Connections.Add(new Connection("49", "48"));
mapTemplate.Connections.Add(new Connection("49", "51"));
mapTemplate.Connections.Add(new Connection("49", "46"));
mapTemplate.Connections.Add(new Connection("49", "47"));
mapTemplate.Connections.Add(new Connection("49", "61"));
mapTemplate.Connections.Add(new Connection("49", "62"));
mapTemplate.Connections.Add(new Connection("49", "38"));
mapTemplate.Connections.Add(new Connection("50", "40"));
mapTemplate.Connections.Add(new Connection("50", "41"));
mapTemplate.Connections.Add(new Connection("50", "38"));
mapTemplate.Connections.Add(new Connection("50", "46"));
mapTemplate.Connections.Add(new Connection("50", "47"));
mapTemplate.Connections.Add(new Connection("50", "51"));
mapTemplate.Connections.Add(new Connection("50", "52"));
mapTemplate.Connections.Add(new Connection("50", "54"));
mapTemplate.Connections.Add(new Connection("50", "56"));
mapTemplate.Connections.Add(new Connection("50", "48"));
mapTemplate.Connections.Add(new Connection("51", "49"));
mapTemplate.Connections.Add(new Connection("51", "50"));
mapTemplate.Connections.Add(new Connection("51", "60"));
mapTemplate.Connections.Add(new Connection("51", "61"));
mapTemplate.Connections.Add(new Connection("51", "46"));
mapTemplate.Connections.Add(new Connection("51", "56"));
mapTemplate.Connections.Add(new Connection("51", "64"));
mapTemplate.Connections.Add(new Connection("52", "41"));
mapTemplate.Connections.Add(new Connection("52", "42"));
mapTemplate.Connections.Add(new Connection("52", "53"));
mapTemplate.Connections.Add(new Connection("52", "54"));
mapTemplate.Connections.Add(new Connection("52", "50"));
mapTemplate.Connections.Add(new Connection("53", "42"));
mapTemplate.Connections.Add(new Connection("53", "45"));
mapTemplate.Connections.Add(new Connection("53", "24"));
mapTemplate.Connections.Add(new Connection("53", "28"));
mapTemplate.Connections.Add(new Connection("53", "55"));
mapTemplate.Connections.Add(new Connection("53", "52"));
mapTemplate.Connections.Add(new Connection("53", "54"));
mapTemplate.Connections.Add(new Connection("54", "52"));
mapTemplate.Connections.Add(new Connection("54", "53"));
mapTemplate.Connections.Add(new Connection("54", "55"));
mapTemplate.Connections.Add(new Connection("54", "56"));
mapTemplate.Connections.Add(new Connection("54", "57"));
mapTemplate.Connections.Add(new Connection("54", "50"));
mapTemplate.Connections.Add(new Connection("55", "54"));
mapTemplate.Connections.Add(new Connection("55", "57"));
mapTemplate.Connections.Add(new Connection("55", "29"));
mapTemplate.Connections.Add(new Connection("55", "28"));
mapTemplate.Connections.Add(new Connection("55", "53"));
mapTemplate.Connections.Add(new Connection("56", "57"));
mapTemplate.Connections.Add(new Connection("56", "58"));
mapTemplate.Connections.Add(new Connection("56", "50"));
mapTemplate.Connections.Add(new Connection("56", "51"));
mapTemplate.Connections.Add(new Connection("56", "54"));
mapTemplate.Connections.Add(new Connection("56", "64"));
mapTemplate.Connections.Add(new Connection("56", "67"));
mapTemplate.Connections.Add(new Connection("57", "33"));
mapTemplate.Connections.Add(new Connection("57", "54"));
mapTemplate.Connections.Add(new Connection("57", "55"));
mapTemplate.Connections.Add(new Connection("57", "56"));
mapTemplate.Connections.Add(new Connection("57", "58"));
mapTemplate.Connections.Add(new Connection("57", "59"));
mapTemplate.Connections.Add(new Connection("57", "29"));
mapTemplate.Connections.Add(new Connection("58", "56"));
mapTemplate.Connections.Add(new Connection("58", "57"));
mapTemplate.Connections.Add(new Connection("58", "59"));
mapTemplate.Connections.Add(new Connection("58", "67"));
mapTemplate.Connections.Add(new Connection("59", "57"));
mapTemplate.Connections.Add(new Connection("59", "58"));
mapTemplate.Connections.Add(new Connection("59", "67"));
mapTemplate.Connections.Add(new Connection("59", "68"));
mapTemplate.Connections.Add(new Connection("59", "69"));
mapTemplate.Connections.Add(new Connection("60", "61"));
mapTemplate.Connections.Add(new Connection("60", "64"));
mapTemplate.Connections.Add(new Connection("60", "65"));
mapTemplate.Connections.Add(new Connection("60", "51"));
mapTemplate.Connections.Add(new Connection("61", "60"));
mapTemplate.Connections.Add(new Connection("61", "65"));
mapTemplate.Connections.Add(new Connection("61", "62"));
mapTemplate.Connections.Add(new Connection("61", "49"));
mapTemplate.Connections.Add(new Connection("61", "51"));
mapTemplate.Connections.Add(new Connection("62", "49"));
mapTemplate.Connections.Add(new Connection("62", "61"));
mapTemplate.Connections.Add(new Connection("62", "63"));
mapTemplate.Connections.Add(new Connection("62", "65"));
mapTemplate.Connections.Add(new Connection("63", "62"));
mapTemplate.Connections.Add(new Connection("63", "65"));
mapTemplate.Connections.Add(new Connection("63", "72"));
mapTemplate.Connections.Add(new Connection("63", "73"));
mapTemplate.Connections.Add(new Connection("64", "51"));
mapTemplate.Connections.Add(new Connection("64", "56"));
mapTemplate.Connections.Add(new Connection("64", "67"));
mapTemplate.Connections.Add(new Connection("64", "66"));
mapTemplate.Connections.Add(new Connection("64", "65"));
mapTemplate.Connections.Add(new Connection("64", "60"));
mapTemplate.Connections.Add(new Connection("65", "62"));
mapTemplate.Connections.Add(new Connection("65", "63"));
mapTemplate.Connections.Add(new Connection("65", "64"));
mapTemplate.Connections.Add(new Connection("65", "60"));
mapTemplate.Connections.Add(new Connection("65", "61"));
mapTemplate.Connections.Add(new Connection("65", "66"));
mapTemplate.Connections.Add(new Connection("65", "73"));
mapTemplate.Connections.Add(new Connection("66", "64"));
mapTemplate.Connections.Add(new Connection("66", "65"));
mapTemplate.Connections.Add(new Connection("66", "67"));
mapTemplate.Connections.Add(new Connection("66", "68"));
mapTemplate.Connections.Add(new Connection("66", "73"));
mapTemplate.Connections.Add(new Connection("66", "75"));
mapTemplate.Connections.Add(new Connection("67", "66"));
mapTemplate.Connections.Add(new Connection("67", "68"));
mapTemplate.Connections.Add(new Connection("67", "59"));
mapTemplate.Connections.Add(new Connection("67", "58"));
mapTemplate.Connections.Add(new Connection("67", "56"));
mapTemplate.Connections.Add(new Connection("67", "64"));
mapTemplate.Connections.Add(new Connection("68", "70"));
mapTemplate.Connections.Add(new Connection("68", "69"));
mapTemplate.Connections.Add(new Connection("68", "59"));
mapTemplate.Connections.Add(new Connection("68", "66"));
mapTemplate.Connections.Add(new Connection("68", "67"));
mapTemplate.Connections.Add(new Connection("68", "75"));
mapTemplate.Connections.Add(new Connection("69", "68"));
mapTemplate.Connections.Add(new Connection("69", "70"));
mapTemplate.Connections.Add(new Connection("69", "59"));
mapTemplate.Connections.Add(new Connection("70", "68"));
mapTemplate.Connections.Add(new Connection("70", "69"));
mapTemplate.Connections.Add(new Connection("71", "72"));
mapTemplate.Connections.Add(new Connection("71", "73"));
mapTemplate.Connections.Add(new Connection("71", "74"));
mapTemplate.Connections.Add(new Connection("72", "71"));
mapTemplate.Connections.Add(new Connection("72", "73"));
mapTemplate.Connections.Add(new Connection("72", "74"));
mapTemplate.Connections.Add(new Connection("72", "63"));
mapTemplate.Connections.Add(new Connection("73", "65"));
mapTemplate.Connections.Add(new Connection("73", "63"));
mapTemplate.Connections.Add(new Connection("73", "66"));
mapTemplate.Connections.Add(new Connection("73", "75"));
mapTemplate.Connections.Add(new Connection("73", "74"));
mapTemplate.Connections.Add(new Connection("73", "71"));
mapTemplate.Connections.Add(new Connection("73", "72"));
mapTemplate.Connections.Add(new Connection("74", "73"));
mapTemplate.Connections.Add(new Connection("74", "75"));
mapTemplate.Connections.Add(new Connection("74", "76"));
mapTemplate.Connections.Add(new Connection("74", "71"));
mapTemplate.Connections.Add(new Connection("74", "72"));
mapTemplate.Connections.Add(new Connection("74", "79"));
mapTemplate.Connections.Add(new Connection("74", "77"));
mapTemplate.Connections.Add(new Connection("75", "68"));
mapTemplate.Connections.Add(new Connection("75", "66"));
mapTemplate.Connections.Add(new Connection("75", "73"));
mapTemplate.Connections.Add(new Connection("75", "74"));
mapTemplate.Connections.Add(new Connection("75", "76"));
mapTemplate.Connections.Add(new Connection("76", "74"));
mapTemplate.Connections.Add(new Connection("76", "75"));
mapTemplate.Connections.Add(new Connection("77", "78"));
mapTemplate.Connections.Add(new Connection("77", "79"));
mapTemplate.Connections.Add(new Connection("77", "74"));
mapTemplate.Connections.Add(new Connection("78", "79"));
mapTemplate.Connections.Add(new Connection("78", "77"));
mapTemplate.Connections.Add(new Connection("79", "77"));
mapTemplate.Connections.Add(new Connection("79", "78"));
mapTemplate.Connections.Add(new Connection("79", "74"));

            return mapTemplate;
		}
    }
}

