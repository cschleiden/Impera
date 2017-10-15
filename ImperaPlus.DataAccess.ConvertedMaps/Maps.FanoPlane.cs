
using ImperaPlus.Domain.Map;

namespace ImperaPlus.DataAccess.ConvertedMaps
{
    public static partial class Maps
    {
        public static MapTemplate FanoPlane()
        {

var mapTemplate = new MapTemplate("FanoPlane") { Image = "fanoplane.jpg" };
var country1 = new CountryTemplate("1", "cyan1") { X = 457, Y = 65 };
mapTemplate.Countries.Add(country1);
var country2 = new CountryTemplate("2", "cyan2") { X = 398, Y = 126 };
mapTemplate.Countries.Add(country2);
var country3 = new CountryTemplate("3", "cyan3") { X = 376, Y = 202 };
mapTemplate.Countries.Add(country3);
var country4 = new CountryTemplate("4", "cyan4") { X = 508, Y = 126 };
mapTemplate.Countries.Add(country4);
var country5 = new CountryTemplate("5", "cyan5") { X = 453, Y = 158 };
mapTemplate.Countries.Add(country5);
var country6 = new CountryTemplate("6", "cyan6") { X = 454, Y = 220 };
mapTemplate.Countries.Add(country6);
var country7 = new CountryTemplate("7", "cyan7") { X = 533, Y = 203 };
mapTemplate.Countries.Add(country7);
var country8 = new CountryTemplate("8", "green1") { X = 259, Y = 315 };
mapTemplate.Countries.Add(country8);
var country9 = new CountryTemplate("9", "green2") { X = 204, Y = 373 };
mapTemplate.Countries.Add(country9);
var country10 = new CountryTemplate("10", "green3") { X = 181, Y = 450 };
mapTemplate.Countries.Add(country10);
var country11 = new CountryTemplate("11", "green4") { X = 311, Y = 373 };
mapTemplate.Countries.Add(country11);
var country12 = new CountryTemplate("12", "green5") { X = 259, Y = 404 };
mapTemplate.Countries.Add(country12);
var country13 = new CountryTemplate("13", "green6") { X = 260, Y = 466 };
mapTemplate.Countries.Add(country13);
var country14 = new CountryTemplate("14", "green7") { X = 336, Y = 451 };
mapTemplate.Countries.Add(country14);
var country15 = new CountryTemplate("15", "red1") { X = 647, Y = 318 };
mapTemplate.Countries.Add(country15);
var country16 = new CountryTemplate("16", "red2") { X = 592, Y = 375 };
mapTemplate.Countries.Add(country16);
var country17 = new CountryTemplate("17", "red3") { X = 570, Y = 451 };
mapTemplate.Countries.Add(country17);
var country18 = new CountryTemplate("18", "red4") { X = 701, Y = 374 };
mapTemplate.Countries.Add(country18);
var country19 = new CountryTemplate("19", "red5") { X = 649, Y = 407 };
mapTemplate.Countries.Add(country19);
var country20 = new CountryTemplate("20", "red6") { X = 649, Y = 469 };
mapTemplate.Countries.Add(country20);
var country21 = new CountryTemplate("21", "red7") { X = 726, Y = 453 };
mapTemplate.Countries.Add(country21);
var country22 = new CountryTemplate("22", "brown1") { X = 453, Y = 432 };
mapTemplate.Countries.Add(country22);
var country23 = new CountryTemplate("23", "brown2") { X = 399, Y = 489 };
mapTemplate.Countries.Add(country23);
var country24 = new CountryTemplate("24", "brown3") { X = 376, Y = 565 };
mapTemplate.Countries.Add(country24);
var country25 = new CountryTemplate("25", "brown4") { X = 506, Y = 489 };
mapTemplate.Countries.Add(country25);
var country26 = new CountryTemplate("26", "brown5") { X = 453, Y = 519 };
mapTemplate.Countries.Add(country26);
var country27 = new CountryTemplate("27", "brown6") { X = 456, Y = 582 };
mapTemplate.Countries.Add(country27);
var country28 = new CountryTemplate("28", "brown7") { X = 533, Y = 566 };
mapTemplate.Countries.Add(country28);
var country29 = new CountryTemplate("29", "blue1") { X = 141, Y = 610 };
mapTemplate.Countries.Add(country29);
var country30 = new CountryTemplate("30", "blue2") { X = 84, Y = 667 };
mapTemplate.Countries.Add(country30);
var country31 = new CountryTemplate("31", "blue3") { X = 63, Y = 743 };
mapTemplate.Countries.Add(country31);
var country32 = new CountryTemplate("32", "blue4") { X = 195, Y = 667 };
mapTemplate.Countries.Add(country32);
var country33 = new CountryTemplate("33", "blue5") { X = 141, Y = 699 };
mapTemplate.Countries.Add(country33);
var country34 = new CountryTemplate("34", "blue6") { X = 141, Y = 764 };
mapTemplate.Countries.Add(country34);
var country35 = new CountryTemplate("35", "blue7") { X = 219, Y = 747 };
mapTemplate.Countries.Add(country35);
var country36 = new CountryTemplate("36", "yellow1") { X = 454, Y = 653 };
mapTemplate.Countries.Add(country36);
var country37 = new CountryTemplate("37", "yellow2") { X = 399, Y = 711 };
mapTemplate.Countries.Add(country37);
var country38 = new CountryTemplate("38", "yellow3") { X = 376, Y = 789 };
mapTemplate.Countries.Add(country38);
var country39 = new CountryTemplate("39", "yellow4") { X = 508, Y = 712 };
mapTemplate.Countries.Add(country39);
var country40 = new CountryTemplate("40", "yellow5") { X = 454, Y = 742 };
mapTemplate.Countries.Add(country40);
var country41 = new CountryTemplate("41", "yellow6") { X = 455, Y = 807 };
mapTemplate.Countries.Add(country41);
var country42 = new CountryTemplate("42", "yellow7") { X = 533, Y = 790 };
mapTemplate.Countries.Add(country42);
var country43 = new CountryTemplate("43", "magenta1") { X = 766, Y = 610 };
mapTemplate.Countries.Add(country43);
var country44 = new CountryTemplate("44", "magenta2") { X = 711, Y = 667 };
mapTemplate.Countries.Add(country44);
var country45 = new CountryTemplate("45", "magenta3") { X = 687, Y = 745 };
mapTemplate.Countries.Add(country45);
var country46 = new CountryTemplate("46", "magenta4") { X = 818, Y = 667 };
mapTemplate.Countries.Add(country46);
var country47 = new CountryTemplate("47", "magenta5") { X = 765, Y = 698 };
mapTemplate.Countries.Add(country47);
var country48 = new CountryTemplate("48", "magenta6") { X = 765, Y = 762 };
mapTemplate.Countries.Add(country48);
var country49 = new CountryTemplate("49", "magenta7") { X = 846, Y = 746 };
mapTemplate.Countries.Add(country49);
var continent1 = new Continent("1", 1);
continent1.Countries.Add(country1);
continent1.Countries.Add(country2);
continent1.Countries.Add(country3);
mapTemplate.Continents.Add(continent1);
var continent2 = new Continent("2", 1);
continent2.Countries.Add(country1);
continent2.Countries.Add(country5);
continent2.Countries.Add(country6);
mapTemplate.Continents.Add(continent2);
var continent3 = new Continent("3", 1);
continent3.Countries.Add(country1);
continent3.Countries.Add(country4);
continent3.Countries.Add(country7);
mapTemplate.Continents.Add(continent3);
var continent4 = new Continent("4", 1);
continent4.Countries.Add(country2);
continent4.Countries.Add(country4);
continent4.Countries.Add(country6);
mapTemplate.Continents.Add(continent4);
var continent5 = new Continent("5", 1);
continent5.Countries.Add(country2);
continent5.Countries.Add(country5);
continent5.Countries.Add(country7);
mapTemplate.Continents.Add(continent5);
var continent6 = new Continent("6", 1);
continent6.Countries.Add(country3);
continent6.Countries.Add(country6);
continent6.Countries.Add(country7);
mapTemplate.Continents.Add(continent6);
var continent7 = new Continent("7", 1);
continent7.Countries.Add(country3);
continent7.Countries.Add(country5);
continent7.Countries.Add(country4);
mapTemplate.Continents.Add(continent7);
var continent8 = new Continent("8", 1);
continent8.Countries.Add(country8);
continent8.Countries.Add(country9);
continent8.Countries.Add(country10);
mapTemplate.Continents.Add(continent8);
var continent9 = new Continent("9", 1);
continent9.Countries.Add(country8);
continent9.Countries.Add(country12);
continent9.Countries.Add(country13);
mapTemplate.Continents.Add(continent9);
var continent10 = new Continent("10", 1);
continent10.Countries.Add(country8);
continent10.Countries.Add(country11);
continent10.Countries.Add(country14);
mapTemplate.Continents.Add(continent10);
var continent11 = new Continent("11", 1);
continent11.Countries.Add(country9);
continent11.Countries.Add(country11);
continent11.Countries.Add(country13);
mapTemplate.Continents.Add(continent11);
var continent12 = new Continent("12", 1);
continent12.Countries.Add(country9);
continent12.Countries.Add(country12);
continent12.Countries.Add(country14);
mapTemplate.Continents.Add(continent12);
var continent13 = new Continent("13", 1);
continent13.Countries.Add(country10);
continent13.Countries.Add(country13);
continent13.Countries.Add(country14);
mapTemplate.Continents.Add(continent13);
var continent14 = new Continent("14", 1);
continent14.Countries.Add(country10);
continent14.Countries.Add(country12);
continent14.Countries.Add(country11);
mapTemplate.Continents.Add(continent14);
var continent15 = new Continent("15", 1);
continent15.Countries.Add(country15);
continent15.Countries.Add(country16);
continent15.Countries.Add(country17);
mapTemplate.Continents.Add(continent15);
var continent16 = new Continent("16", 1);
continent16.Countries.Add(country15);
continent16.Countries.Add(country19);
continent16.Countries.Add(country20);
mapTemplate.Continents.Add(continent16);
var continent17 = new Continent("17", 1);
continent17.Countries.Add(country15);
continent17.Countries.Add(country18);
continent17.Countries.Add(country21);
mapTemplate.Continents.Add(continent17);
var continent18 = new Continent("18", 1);
continent18.Countries.Add(country16);
continent18.Countries.Add(country18);
continent18.Countries.Add(country20);
mapTemplate.Continents.Add(continent18);
var continent19 = new Continent("19", 1);
continent19.Countries.Add(country16);
continent19.Countries.Add(country19);
continent19.Countries.Add(country21);
mapTemplate.Continents.Add(continent19);
var continent20 = new Continent("20", 1);
continent20.Countries.Add(country17);
continent20.Countries.Add(country20);
continent20.Countries.Add(country21);
mapTemplate.Continents.Add(continent20);
var continent21 = new Continent("21", 1);
continent21.Countries.Add(country17);
continent21.Countries.Add(country19);
continent21.Countries.Add(country18);
mapTemplate.Continents.Add(continent21);
var continent22 = new Continent("22", 1);
continent22.Countries.Add(country22);
continent22.Countries.Add(country23);
continent22.Countries.Add(country24);
mapTemplate.Continents.Add(continent22);
var continent23 = new Continent("23", 1);
continent23.Countries.Add(country22);
continent23.Countries.Add(country26);
continent23.Countries.Add(country27);
mapTemplate.Continents.Add(continent23);
var continent24 = new Continent("24", 1);
continent24.Countries.Add(country22);
continent24.Countries.Add(country25);
continent24.Countries.Add(country28);
mapTemplate.Continents.Add(continent24);
var continent25 = new Continent("25", 1);
continent25.Countries.Add(country23);
continent25.Countries.Add(country25);
continent25.Countries.Add(country27);
mapTemplate.Continents.Add(continent25);
var continent26 = new Continent("26", 1);
continent26.Countries.Add(country23);
continent26.Countries.Add(country26);
continent26.Countries.Add(country28);
mapTemplate.Continents.Add(continent26);
var continent27 = new Continent("27", 1);
continent27.Countries.Add(country24);
continent27.Countries.Add(country27);
continent27.Countries.Add(country28);
mapTemplate.Continents.Add(continent27);
var continent28 = new Continent("28", 1);
continent28.Countries.Add(country24);
continent28.Countries.Add(country26);
continent28.Countries.Add(country25);
mapTemplate.Continents.Add(continent28);
var continent29 = new Continent("29", 1);
continent29.Countries.Add(country29);
continent29.Countries.Add(country30);
continent29.Countries.Add(country31);
mapTemplate.Continents.Add(continent29);
var continent30 = new Continent("30", 1);
continent30.Countries.Add(country29);
continent30.Countries.Add(country33);
continent30.Countries.Add(country34);
mapTemplate.Continents.Add(continent30);
var continent31 = new Continent("31", 1);
continent31.Countries.Add(country29);
continent31.Countries.Add(country32);
continent31.Countries.Add(country35);
mapTemplate.Continents.Add(continent31);
var continent32 = new Continent("32", 1);
continent32.Countries.Add(country30);
continent32.Countries.Add(country32);
continent32.Countries.Add(country34);
mapTemplate.Continents.Add(continent32);
var continent33 = new Continent("33", 1);
continent33.Countries.Add(country30);
continent33.Countries.Add(country33);
continent33.Countries.Add(country35);
mapTemplate.Continents.Add(continent33);
var continent34 = new Continent("34", 1);
continent34.Countries.Add(country31);
continent34.Countries.Add(country34);
continent34.Countries.Add(country35);
mapTemplate.Continents.Add(continent34);
var continent35 = new Continent("35", 1);
continent35.Countries.Add(country31);
continent35.Countries.Add(country33);
continent35.Countries.Add(country32);
mapTemplate.Continents.Add(continent35);
var continent36 = new Continent("36", 1);
continent36.Countries.Add(country36);
continent36.Countries.Add(country37);
continent36.Countries.Add(country38);
mapTemplate.Continents.Add(continent36);
var continent37 = new Continent("37", 1);
continent37.Countries.Add(country36);
continent37.Countries.Add(country40);
continent37.Countries.Add(country41);
mapTemplate.Continents.Add(continent37);
var continent38 = new Continent("38", 1);
continent38.Countries.Add(country36);
continent38.Countries.Add(country39);
continent38.Countries.Add(country42);
mapTemplate.Continents.Add(continent38);
var continent39 = new Continent("39", 1);
continent39.Countries.Add(country37);
continent39.Countries.Add(country39);
continent39.Countries.Add(country41);
mapTemplate.Continents.Add(continent39);
var continent40 = new Continent("40", 1);
continent40.Countries.Add(country37);
continent40.Countries.Add(country40);
continent40.Countries.Add(country42);
mapTemplate.Continents.Add(continent40);
var continent41 = new Continent("41", 1);
continent41.Countries.Add(country38);
continent41.Countries.Add(country41);
continent41.Countries.Add(country42);
mapTemplate.Continents.Add(continent41);
var continent42 = new Continent("42", 1);
continent42.Countries.Add(country38);
continent42.Countries.Add(country40);
continent42.Countries.Add(country39);
mapTemplate.Continents.Add(continent42);
var continent43 = new Continent("43", 1);
continent43.Countries.Add(country43);
continent43.Countries.Add(country44);
continent43.Countries.Add(country45);
mapTemplate.Continents.Add(continent43);
var continent44 = new Continent("44", 1);
continent44.Countries.Add(country43);
continent44.Countries.Add(country47);
continent44.Countries.Add(country48);
mapTemplate.Continents.Add(continent44);
var continent45 = new Continent("45", 1);
continent45.Countries.Add(country43);
continent45.Countries.Add(country46);
continent45.Countries.Add(country49);
mapTemplate.Continents.Add(continent45);
var continent46 = new Continent("46", 1);
continent46.Countries.Add(country44);
continent46.Countries.Add(country46);
continent46.Countries.Add(country48);
mapTemplate.Continents.Add(continent46);
var continent47 = new Continent("47", 1);
continent47.Countries.Add(country44);
continent47.Countries.Add(country47);
continent47.Countries.Add(country49);
mapTemplate.Continents.Add(continent47);
var continent48 = new Continent("48", 1);
continent48.Countries.Add(country45);
continent48.Countries.Add(country48);
continent48.Countries.Add(country49);
mapTemplate.Continents.Add(continent48);
var continent49 = new Continent("49", 1);
continent49.Countries.Add(country45);
continent49.Countries.Add(country47);
continent49.Countries.Add(country46);
mapTemplate.Continents.Add(continent49);
mapTemplate.Connections.Add(new Connection("1", "2"));
mapTemplate.Connections.Add(new Connection("1", "4"));
mapTemplate.Connections.Add(new Connection("1", "5"));
mapTemplate.Connections.Add(new Connection("1", "8"));
mapTemplate.Connections.Add(new Connection("1", "15"));
mapTemplate.Connections.Add(new Connection("1", "22"));
mapTemplate.Connections.Add(new Connection("2", "1"));
mapTemplate.Connections.Add(new Connection("2", "3"));
mapTemplate.Connections.Add(new Connection("2", "4"));
mapTemplate.Connections.Add(new Connection("2", "5"));
mapTemplate.Connections.Add(new Connection("2", "6"));
mapTemplate.Connections.Add(new Connection("2", "9"));
mapTemplate.Connections.Add(new Connection("2", "16"));
mapTemplate.Connections.Add(new Connection("2", "23"));
mapTemplate.Connections.Add(new Connection("3", "2"));
mapTemplate.Connections.Add(new Connection("3", "5"));
mapTemplate.Connections.Add(new Connection("3", "6"));
mapTemplate.Connections.Add(new Connection("3", "10"));
mapTemplate.Connections.Add(new Connection("3", "17"));
mapTemplate.Connections.Add(new Connection("3", "24"));
mapTemplate.Connections.Add(new Connection("4", "1"));
mapTemplate.Connections.Add(new Connection("4", "2"));
mapTemplate.Connections.Add(new Connection("4", "5"));
mapTemplate.Connections.Add(new Connection("4", "6"));
mapTemplate.Connections.Add(new Connection("4", "7"));
mapTemplate.Connections.Add(new Connection("4", "11"));
mapTemplate.Connections.Add(new Connection("4", "18"));
mapTemplate.Connections.Add(new Connection("4", "25"));
mapTemplate.Connections.Add(new Connection("5", "1"));
mapTemplate.Connections.Add(new Connection("5", "2"));
mapTemplate.Connections.Add(new Connection("5", "3"));
mapTemplate.Connections.Add(new Connection("5", "4"));
mapTemplate.Connections.Add(new Connection("5", "6"));
mapTemplate.Connections.Add(new Connection("5", "7"));
mapTemplate.Connections.Add(new Connection("5", "12"));
mapTemplate.Connections.Add(new Connection("5", "19"));
mapTemplate.Connections.Add(new Connection("5", "26"));
mapTemplate.Connections.Add(new Connection("6", "2"));
mapTemplate.Connections.Add(new Connection("6", "3"));
mapTemplate.Connections.Add(new Connection("6", "4"));
mapTemplate.Connections.Add(new Connection("6", "5"));
mapTemplate.Connections.Add(new Connection("6", "7"));
mapTemplate.Connections.Add(new Connection("6", "13"));
mapTemplate.Connections.Add(new Connection("6", "20"));
mapTemplate.Connections.Add(new Connection("6", "27"));
mapTemplate.Connections.Add(new Connection("7", "4"));
mapTemplate.Connections.Add(new Connection("7", "5"));
mapTemplate.Connections.Add(new Connection("7", "6"));
mapTemplate.Connections.Add(new Connection("7", "14"));
mapTemplate.Connections.Add(new Connection("7", "21"));
mapTemplate.Connections.Add(new Connection("7", "28"));
mapTemplate.Connections.Add(new Connection("8", "9"));
mapTemplate.Connections.Add(new Connection("8", "11"));
mapTemplate.Connections.Add(new Connection("8", "12"));
mapTemplate.Connections.Add(new Connection("8", "1"));
mapTemplate.Connections.Add(new Connection("8", "15"));
mapTemplate.Connections.Add(new Connection("8", "22"));
mapTemplate.Connections.Add(new Connection("8", "29"));
mapTemplate.Connections.Add(new Connection("8", "36"));
mapTemplate.Connections.Add(new Connection("9", "8"));
mapTemplate.Connections.Add(new Connection("9", "10"));
mapTemplate.Connections.Add(new Connection("9", "11"));
mapTemplate.Connections.Add(new Connection("9", "12"));
mapTemplate.Connections.Add(new Connection("9", "13"));
mapTemplate.Connections.Add(new Connection("9", "2"));
mapTemplate.Connections.Add(new Connection("9", "16"));
mapTemplate.Connections.Add(new Connection("9", "23"));
mapTemplate.Connections.Add(new Connection("9", "30"));
mapTemplate.Connections.Add(new Connection("9", "37"));
mapTemplate.Connections.Add(new Connection("10", "9"));
mapTemplate.Connections.Add(new Connection("10", "12"));
mapTemplate.Connections.Add(new Connection("10", "13"));
mapTemplate.Connections.Add(new Connection("10", "3"));
mapTemplate.Connections.Add(new Connection("10", "17"));
mapTemplate.Connections.Add(new Connection("10", "24"));
mapTemplate.Connections.Add(new Connection("10", "31"));
mapTemplate.Connections.Add(new Connection("10", "38"));
mapTemplate.Connections.Add(new Connection("11", "8"));
mapTemplate.Connections.Add(new Connection("11", "9"));
mapTemplate.Connections.Add(new Connection("11", "12"));
mapTemplate.Connections.Add(new Connection("11", "13"));
mapTemplate.Connections.Add(new Connection("11", "14"));
mapTemplate.Connections.Add(new Connection("11", "4"));
mapTemplate.Connections.Add(new Connection("11", "18"));
mapTemplate.Connections.Add(new Connection("11", "25"));
mapTemplate.Connections.Add(new Connection("11", "32"));
mapTemplate.Connections.Add(new Connection("11", "39"));
mapTemplate.Connections.Add(new Connection("12", "8"));
mapTemplate.Connections.Add(new Connection("12", "9"));
mapTemplate.Connections.Add(new Connection("12", "10"));
mapTemplate.Connections.Add(new Connection("12", "11"));
mapTemplate.Connections.Add(new Connection("12", "13"));
mapTemplate.Connections.Add(new Connection("12", "14"));
mapTemplate.Connections.Add(new Connection("12", "5"));
mapTemplate.Connections.Add(new Connection("12", "19"));
mapTemplate.Connections.Add(new Connection("12", "26"));
mapTemplate.Connections.Add(new Connection("12", "33"));
mapTemplate.Connections.Add(new Connection("12", "40"));
mapTemplate.Connections.Add(new Connection("13", "9"));
mapTemplate.Connections.Add(new Connection("13", "10"));
mapTemplate.Connections.Add(new Connection("13", "11"));
mapTemplate.Connections.Add(new Connection("13", "12"));
mapTemplate.Connections.Add(new Connection("13", "14"));
mapTemplate.Connections.Add(new Connection("13", "6"));
mapTemplate.Connections.Add(new Connection("13", "20"));
mapTemplate.Connections.Add(new Connection("13", "27"));
mapTemplate.Connections.Add(new Connection("13", "34"));
mapTemplate.Connections.Add(new Connection("13", "41"));
mapTemplate.Connections.Add(new Connection("14", "11"));
mapTemplate.Connections.Add(new Connection("14", "12"));
mapTemplate.Connections.Add(new Connection("14", "13"));
mapTemplate.Connections.Add(new Connection("14", "7"));
mapTemplate.Connections.Add(new Connection("14", "21"));
mapTemplate.Connections.Add(new Connection("14", "28"));
mapTemplate.Connections.Add(new Connection("14", "35"));
mapTemplate.Connections.Add(new Connection("14", "42"));
mapTemplate.Connections.Add(new Connection("15", "16"));
mapTemplate.Connections.Add(new Connection("15", "18"));
mapTemplate.Connections.Add(new Connection("15", "19"));
mapTemplate.Connections.Add(new Connection("15", "1"));
mapTemplate.Connections.Add(new Connection("15", "8"));
mapTemplate.Connections.Add(new Connection("15", "22"));
mapTemplate.Connections.Add(new Connection("15", "36"));
mapTemplate.Connections.Add(new Connection("15", "43"));
mapTemplate.Connections.Add(new Connection("16", "15"));
mapTemplate.Connections.Add(new Connection("16", "17"));
mapTemplate.Connections.Add(new Connection("16", "18"));
mapTemplate.Connections.Add(new Connection("16", "19"));
mapTemplate.Connections.Add(new Connection("16", "20"));
mapTemplate.Connections.Add(new Connection("16", "2"));
mapTemplate.Connections.Add(new Connection("16", "9"));
mapTemplate.Connections.Add(new Connection("16", "23"));
mapTemplate.Connections.Add(new Connection("16", "37"));
mapTemplate.Connections.Add(new Connection("16", "44"));
mapTemplate.Connections.Add(new Connection("17", "16"));
mapTemplate.Connections.Add(new Connection("17", "19"));
mapTemplate.Connections.Add(new Connection("17", "20"));
mapTemplate.Connections.Add(new Connection("17", "3"));
mapTemplate.Connections.Add(new Connection("17", "10"));
mapTemplate.Connections.Add(new Connection("17", "24"));
mapTemplate.Connections.Add(new Connection("17", "38"));
mapTemplate.Connections.Add(new Connection("17", "45"));
mapTemplate.Connections.Add(new Connection("18", "15"));
mapTemplate.Connections.Add(new Connection("18", "16"));
mapTemplate.Connections.Add(new Connection("18", "19"));
mapTemplate.Connections.Add(new Connection("18", "20"));
mapTemplate.Connections.Add(new Connection("18", "21"));
mapTemplate.Connections.Add(new Connection("18", "4"));
mapTemplate.Connections.Add(new Connection("18", "11"));
mapTemplate.Connections.Add(new Connection("18", "25"));
mapTemplate.Connections.Add(new Connection("18", "39"));
mapTemplate.Connections.Add(new Connection("18", "46"));
mapTemplate.Connections.Add(new Connection("19", "15"));
mapTemplate.Connections.Add(new Connection("19", "16"));
mapTemplate.Connections.Add(new Connection("19", "17"));
mapTemplate.Connections.Add(new Connection("19", "18"));
mapTemplate.Connections.Add(new Connection("19", "20"));
mapTemplate.Connections.Add(new Connection("19", "21"));
mapTemplate.Connections.Add(new Connection("19", "5"));
mapTemplate.Connections.Add(new Connection("19", "12"));
mapTemplate.Connections.Add(new Connection("19", "26"));
mapTemplate.Connections.Add(new Connection("19", "40"));
mapTemplate.Connections.Add(new Connection("19", "47"));
mapTemplate.Connections.Add(new Connection("20", "16"));
mapTemplate.Connections.Add(new Connection("20", "17"));
mapTemplate.Connections.Add(new Connection("20", "18"));
mapTemplate.Connections.Add(new Connection("20", "19"));
mapTemplate.Connections.Add(new Connection("20", "21"));
mapTemplate.Connections.Add(new Connection("20", "6"));
mapTemplate.Connections.Add(new Connection("20", "13"));
mapTemplate.Connections.Add(new Connection("20", "27"));
mapTemplate.Connections.Add(new Connection("20", "41"));
mapTemplate.Connections.Add(new Connection("20", "48"));
mapTemplate.Connections.Add(new Connection("21", "18"));
mapTemplate.Connections.Add(new Connection("21", "19"));
mapTemplate.Connections.Add(new Connection("21", "20"));
mapTemplate.Connections.Add(new Connection("21", "7"));
mapTemplate.Connections.Add(new Connection("21", "14"));
mapTemplate.Connections.Add(new Connection("21", "28"));
mapTemplate.Connections.Add(new Connection("21", "42"));
mapTemplate.Connections.Add(new Connection("21", "49"));
mapTemplate.Connections.Add(new Connection("22", "23"));
mapTemplate.Connections.Add(new Connection("22", "25"));
mapTemplate.Connections.Add(new Connection("22", "26"));
mapTemplate.Connections.Add(new Connection("22", "1"));
mapTemplate.Connections.Add(new Connection("22", "8"));
mapTemplate.Connections.Add(new Connection("22", "15"));
mapTemplate.Connections.Add(new Connection("22", "29"));
mapTemplate.Connections.Add(new Connection("22", "36"));
mapTemplate.Connections.Add(new Connection("22", "43"));
mapTemplate.Connections.Add(new Connection("23", "22"));
mapTemplate.Connections.Add(new Connection("23", "24"));
mapTemplate.Connections.Add(new Connection("23", "25"));
mapTemplate.Connections.Add(new Connection("23", "26"));
mapTemplate.Connections.Add(new Connection("23", "27"));
mapTemplate.Connections.Add(new Connection("23", "2"));
mapTemplate.Connections.Add(new Connection("23", "9"));
mapTemplate.Connections.Add(new Connection("23", "16"));
mapTemplate.Connections.Add(new Connection("23", "30"));
mapTemplate.Connections.Add(new Connection("23", "37"));
mapTemplate.Connections.Add(new Connection("23", "44"));
mapTemplate.Connections.Add(new Connection("24", "23"));
mapTemplate.Connections.Add(new Connection("24", "26"));
mapTemplate.Connections.Add(new Connection("24", "27"));
mapTemplate.Connections.Add(new Connection("24", "3"));
mapTemplate.Connections.Add(new Connection("24", "10"));
mapTemplate.Connections.Add(new Connection("24", "17"));
mapTemplate.Connections.Add(new Connection("24", "31"));
mapTemplate.Connections.Add(new Connection("24", "38"));
mapTemplate.Connections.Add(new Connection("24", "45"));
mapTemplate.Connections.Add(new Connection("25", "22"));
mapTemplate.Connections.Add(new Connection("25", "23"));
mapTemplate.Connections.Add(new Connection("25", "26"));
mapTemplate.Connections.Add(new Connection("25", "27"));
mapTemplate.Connections.Add(new Connection("25", "28"));
mapTemplate.Connections.Add(new Connection("25", "4"));
mapTemplate.Connections.Add(new Connection("25", "11"));
mapTemplate.Connections.Add(new Connection("25", "18"));
mapTemplate.Connections.Add(new Connection("25", "32"));
mapTemplate.Connections.Add(new Connection("25", "39"));
mapTemplate.Connections.Add(new Connection("25", "46"));
mapTemplate.Connections.Add(new Connection("26", "22"));
mapTemplate.Connections.Add(new Connection("26", "23"));
mapTemplate.Connections.Add(new Connection("26", "24"));
mapTemplate.Connections.Add(new Connection("26", "25"));
mapTemplate.Connections.Add(new Connection("26", "27"));
mapTemplate.Connections.Add(new Connection("26", "28"));
mapTemplate.Connections.Add(new Connection("26", "5"));
mapTemplate.Connections.Add(new Connection("26", "12"));
mapTemplate.Connections.Add(new Connection("26", "19"));
mapTemplate.Connections.Add(new Connection("26", "33"));
mapTemplate.Connections.Add(new Connection("26", "40"));
mapTemplate.Connections.Add(new Connection("26", "47"));
mapTemplate.Connections.Add(new Connection("27", "23"));
mapTemplate.Connections.Add(new Connection("27", "24"));
mapTemplate.Connections.Add(new Connection("27", "25"));
mapTemplate.Connections.Add(new Connection("27", "26"));
mapTemplate.Connections.Add(new Connection("27", "28"));
mapTemplate.Connections.Add(new Connection("27", "6"));
mapTemplate.Connections.Add(new Connection("27", "13"));
mapTemplate.Connections.Add(new Connection("27", "20"));
mapTemplate.Connections.Add(new Connection("27", "34"));
mapTemplate.Connections.Add(new Connection("27", "41"));
mapTemplate.Connections.Add(new Connection("27", "48"));
mapTemplate.Connections.Add(new Connection("28", "25"));
mapTemplate.Connections.Add(new Connection("28", "26"));
mapTemplate.Connections.Add(new Connection("28", "27"));
mapTemplate.Connections.Add(new Connection("28", "7"));
mapTemplate.Connections.Add(new Connection("28", "14"));
mapTemplate.Connections.Add(new Connection("28", "21"));
mapTemplate.Connections.Add(new Connection("28", "35"));
mapTemplate.Connections.Add(new Connection("28", "42"));
mapTemplate.Connections.Add(new Connection("28", "49"));
mapTemplate.Connections.Add(new Connection("29", "30"));
mapTemplate.Connections.Add(new Connection("29", "32"));
mapTemplate.Connections.Add(new Connection("29", "33"));
mapTemplate.Connections.Add(new Connection("29", "8"));
mapTemplate.Connections.Add(new Connection("29", "22"));
mapTemplate.Connections.Add(new Connection("29", "36"));
mapTemplate.Connections.Add(new Connection("30", "29"));
mapTemplate.Connections.Add(new Connection("30", "31"));
mapTemplate.Connections.Add(new Connection("30", "32"));
mapTemplate.Connections.Add(new Connection("30", "33"));
mapTemplate.Connections.Add(new Connection("30", "34"));
mapTemplate.Connections.Add(new Connection("30", "9"));
mapTemplate.Connections.Add(new Connection("30", "23"));
mapTemplate.Connections.Add(new Connection("30", "37"));
mapTemplate.Connections.Add(new Connection("31", "30"));
mapTemplate.Connections.Add(new Connection("31", "33"));
mapTemplate.Connections.Add(new Connection("31", "34"));
mapTemplate.Connections.Add(new Connection("31", "10"));
mapTemplate.Connections.Add(new Connection("31", "24"));
mapTemplate.Connections.Add(new Connection("31", "38"));
mapTemplate.Connections.Add(new Connection("32", "29"));
mapTemplate.Connections.Add(new Connection("32", "30"));
mapTemplate.Connections.Add(new Connection("32", "33"));
mapTemplate.Connections.Add(new Connection("32", "34"));
mapTemplate.Connections.Add(new Connection("32", "35"));
mapTemplate.Connections.Add(new Connection("32", "11"));
mapTemplate.Connections.Add(new Connection("32", "25"));
mapTemplate.Connections.Add(new Connection("32", "39"));
mapTemplate.Connections.Add(new Connection("33", "29"));
mapTemplate.Connections.Add(new Connection("33", "30"));
mapTemplate.Connections.Add(new Connection("33", "31"));
mapTemplate.Connections.Add(new Connection("33", "32"));
mapTemplate.Connections.Add(new Connection("33", "34"));
mapTemplate.Connections.Add(new Connection("33", "35"));
mapTemplate.Connections.Add(new Connection("33", "12"));
mapTemplate.Connections.Add(new Connection("33", "26"));
mapTemplate.Connections.Add(new Connection("33", "40"));
mapTemplate.Connections.Add(new Connection("34", "30"));
mapTemplate.Connections.Add(new Connection("34", "31"));
mapTemplate.Connections.Add(new Connection("34", "32"));
mapTemplate.Connections.Add(new Connection("34", "33"));
mapTemplate.Connections.Add(new Connection("34", "35"));
mapTemplate.Connections.Add(new Connection("34", "13"));
mapTemplate.Connections.Add(new Connection("34", "27"));
mapTemplate.Connections.Add(new Connection("34", "41"));
mapTemplate.Connections.Add(new Connection("35", "32"));
mapTemplate.Connections.Add(new Connection("35", "33"));
mapTemplate.Connections.Add(new Connection("35", "34"));
mapTemplate.Connections.Add(new Connection("35", "14"));
mapTemplate.Connections.Add(new Connection("35", "28"));
mapTemplate.Connections.Add(new Connection("35", "42"));
mapTemplate.Connections.Add(new Connection("36", "37"));
mapTemplate.Connections.Add(new Connection("36", "39"));
mapTemplate.Connections.Add(new Connection("36", "40"));
mapTemplate.Connections.Add(new Connection("36", "8"));
mapTemplate.Connections.Add(new Connection("36", "15"));
mapTemplate.Connections.Add(new Connection("36", "22"));
mapTemplate.Connections.Add(new Connection("36", "29"));
mapTemplate.Connections.Add(new Connection("36", "43"));
mapTemplate.Connections.Add(new Connection("37", "36"));
mapTemplate.Connections.Add(new Connection("37", "38"));
mapTemplate.Connections.Add(new Connection("37", "39"));
mapTemplate.Connections.Add(new Connection("37", "40"));
mapTemplate.Connections.Add(new Connection("37", "41"));
mapTemplate.Connections.Add(new Connection("37", "9"));
mapTemplate.Connections.Add(new Connection("37", "16"));
mapTemplate.Connections.Add(new Connection("37", "23"));
mapTemplate.Connections.Add(new Connection("37", "30"));
mapTemplate.Connections.Add(new Connection("37", "44"));
mapTemplate.Connections.Add(new Connection("38", "37"));
mapTemplate.Connections.Add(new Connection("38", "40"));
mapTemplate.Connections.Add(new Connection("38", "41"));
mapTemplate.Connections.Add(new Connection("38", "10"));
mapTemplate.Connections.Add(new Connection("38", "17"));
mapTemplate.Connections.Add(new Connection("38", "24"));
mapTemplate.Connections.Add(new Connection("38", "31"));
mapTemplate.Connections.Add(new Connection("38", "45"));
mapTemplate.Connections.Add(new Connection("39", "36"));
mapTemplate.Connections.Add(new Connection("39", "37"));
mapTemplate.Connections.Add(new Connection("39", "40"));
mapTemplate.Connections.Add(new Connection("39", "41"));
mapTemplate.Connections.Add(new Connection("39", "42"));
mapTemplate.Connections.Add(new Connection("39", "11"));
mapTemplate.Connections.Add(new Connection("39", "18"));
mapTemplate.Connections.Add(new Connection("39", "25"));
mapTemplate.Connections.Add(new Connection("39", "32"));
mapTemplate.Connections.Add(new Connection("39", "46"));
mapTemplate.Connections.Add(new Connection("40", "36"));
mapTemplate.Connections.Add(new Connection("40", "37"));
mapTemplate.Connections.Add(new Connection("40", "38"));
mapTemplate.Connections.Add(new Connection("40", "39"));
mapTemplate.Connections.Add(new Connection("40", "41"));
mapTemplate.Connections.Add(new Connection("40", "42"));
mapTemplate.Connections.Add(new Connection("40", "12"));
mapTemplate.Connections.Add(new Connection("40", "19"));
mapTemplate.Connections.Add(new Connection("40", "26"));
mapTemplate.Connections.Add(new Connection("40", "33"));
mapTemplate.Connections.Add(new Connection("40", "47"));
mapTemplate.Connections.Add(new Connection("41", "37"));
mapTemplate.Connections.Add(new Connection("41", "38"));
mapTemplate.Connections.Add(new Connection("41", "39"));
mapTemplate.Connections.Add(new Connection("41", "40"));
mapTemplate.Connections.Add(new Connection("41", "42"));
mapTemplate.Connections.Add(new Connection("41", "13"));
mapTemplate.Connections.Add(new Connection("41", "20"));
mapTemplate.Connections.Add(new Connection("41", "27"));
mapTemplate.Connections.Add(new Connection("41", "34"));
mapTemplate.Connections.Add(new Connection("41", "48"));
mapTemplate.Connections.Add(new Connection("42", "39"));
mapTemplate.Connections.Add(new Connection("42", "40"));
mapTemplate.Connections.Add(new Connection("42", "41"));
mapTemplate.Connections.Add(new Connection("42", "14"));
mapTemplate.Connections.Add(new Connection("42", "21"));
mapTemplate.Connections.Add(new Connection("42", "28"));
mapTemplate.Connections.Add(new Connection("42", "35"));
mapTemplate.Connections.Add(new Connection("42", "49"));
mapTemplate.Connections.Add(new Connection("43", "44"));
mapTemplate.Connections.Add(new Connection("43", "46"));
mapTemplate.Connections.Add(new Connection("43", "47"));
mapTemplate.Connections.Add(new Connection("43", "15"));
mapTemplate.Connections.Add(new Connection("43", "22"));
mapTemplate.Connections.Add(new Connection("43", "36"));
mapTemplate.Connections.Add(new Connection("44", "43"));
mapTemplate.Connections.Add(new Connection("44", "45"));
mapTemplate.Connections.Add(new Connection("44", "46"));
mapTemplate.Connections.Add(new Connection("44", "47"));
mapTemplate.Connections.Add(new Connection("44", "48"));
mapTemplate.Connections.Add(new Connection("44", "16"));
mapTemplate.Connections.Add(new Connection("44", "23"));
mapTemplate.Connections.Add(new Connection("44", "37"));
mapTemplate.Connections.Add(new Connection("45", "44"));
mapTemplate.Connections.Add(new Connection("45", "47"));
mapTemplate.Connections.Add(new Connection("45", "48"));
mapTemplate.Connections.Add(new Connection("45", "17"));
mapTemplate.Connections.Add(new Connection("45", "24"));
mapTemplate.Connections.Add(new Connection("45", "38"));
mapTemplate.Connections.Add(new Connection("46", "43"));
mapTemplate.Connections.Add(new Connection("46", "44"));
mapTemplate.Connections.Add(new Connection("46", "47"));
mapTemplate.Connections.Add(new Connection("46", "48"));
mapTemplate.Connections.Add(new Connection("46", "49"));
mapTemplate.Connections.Add(new Connection("46", "18"));
mapTemplate.Connections.Add(new Connection("46", "25"));
mapTemplate.Connections.Add(new Connection("46", "39"));
mapTemplate.Connections.Add(new Connection("47", "43"));
mapTemplate.Connections.Add(new Connection("47", "44"));
mapTemplate.Connections.Add(new Connection("47", "45"));
mapTemplate.Connections.Add(new Connection("47", "46"));
mapTemplate.Connections.Add(new Connection("47", "48"));
mapTemplate.Connections.Add(new Connection("47", "49"));
mapTemplate.Connections.Add(new Connection("47", "19"));
mapTemplate.Connections.Add(new Connection("47", "26"));
mapTemplate.Connections.Add(new Connection("47", "40"));
mapTemplate.Connections.Add(new Connection("48", "44"));
mapTemplate.Connections.Add(new Connection("48", "45"));
mapTemplate.Connections.Add(new Connection("48", "46"));
mapTemplate.Connections.Add(new Connection("48", "47"));
mapTemplate.Connections.Add(new Connection("48", "49"));
mapTemplate.Connections.Add(new Connection("48", "20"));
mapTemplate.Connections.Add(new Connection("48", "27"));
mapTemplate.Connections.Add(new Connection("48", "41"));
mapTemplate.Connections.Add(new Connection("49", "46"));
mapTemplate.Connections.Add(new Connection("49", "47"));
mapTemplate.Connections.Add(new Connection("49", "48"));
mapTemplate.Connections.Add(new Connection("49", "21"));
mapTemplate.Connections.Add(new Connection("49", "28"));
mapTemplate.Connections.Add(new Connection("49", "42"));

            return mapTemplate;
		}
    }
}

