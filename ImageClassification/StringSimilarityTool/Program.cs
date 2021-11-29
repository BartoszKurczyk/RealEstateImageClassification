using System;
using F23.StringSimilarity;

namespace StringSimilarityTool
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new JaroWinkler();
            var string1 = "Na wynajem 2 pok. 34m2 zlokalizowane na 4 piętrze 4 piętrowego bloku na Pomorzanach. " +
                          "Mieszkanie składa się z dwóch pokoi w tym jeden przejściowy, osobnej, widnej kuchni i łazienki z wanną i WC. " +
                          "Mieszkanie w pełni umeblowane. Ogrzewanie i ciepła woda z sieci miejskiej, czynsz 330zł(w tym zaliczki na co i cw), " +
                          "dodatkowo płatny prąd. Świetna lokazliacja, w pobliżu sklepy, szpital, PUM, komunikacja miejska. Mieszkanie wolne od zaraz. " +
                          "Najem okazjonalny. 1500zł+czynsz 360zł+prąd Kaucja 1860 zł Zapraszam na prezentację. " +
                          "Sprawdź naszą pełną ofertę na stronie E L I T E . N I E R U C H O M O S C I . P L " +
                          "*KUPUJEMY MIESZKANIA Z OBCIĄŻENIAMI I DŁUGAMI ZA GOTÓWKĘ* ZADZWOŃ 502-424-064 " +
                          "Powyższe ogłoszenie ma wyłącznie charakter informacyjny. Nie stanowi ono oferty w myśl art. 66 i n. ustawy z dnia 23.04.1964r. " +
                          "Kodeks cywilny (Dz.U. 1964r. Nr 16, poz. 93, ze zm.). Oferta wysłana z programu dla biur nieruchomości ASARI CRM ();";
            var string2 = "Na wynajem 2 pok. 34m2 zlokalizowane na 4 piętrze 4 piętrowego bloku na Pomorzanach. " +
                          "Mieszkanie składa się z dwóch pokoi w tym jeden przejściowy, osobnej, widnej kuchni i łazienki z wanną i WC. " +
                          "Mieszkanie w pełni umeblowane. Ogrzewanie i ciepła woda z sieci miejskiej, czynsz 330zł(w tym zaliczki na co i cw), " +
                          "dodatkowo płatny prąd. Świetna lokazliacja, w pobliżu sklepy, szpital, PUM, komunikacja miejska. Mieszkanie wolne od zaraz. " +
                          "Najem okazjonalny. 1500zł+czynsz 360zł+prąd Kaucja 1860 zł Zapraszam na prezentację. " +
                          "Sprawdź naszą pełną ofertę na stronie E L I T E . N I E R U C H O M O S C I . P L " +
                          "*KUPUJEMY MIESZKANIA Z OBCIĄŻENIAMI I DŁUGAMI ZA GOTÓWKĘ* ZADZWOŃ 502-424-064 ";
            var string3 =
                "Na wynajem nowo wykończone 2 pokojowe mieszkanie o powierzchni 46,9m2 znajdujące się na 2 piętrze apartamentowca z 2020 roku na Pomorzanach. " +
                "Na powierzchnię użytkową nieruchomości składa się: korytarz, sypialnia, łazienka oraz przestronny salon z aneksem kuchennym. Mieszkanie jest nowe, jeszcze niezamieszkałe, " +
                "prezentuje zdecydowanie wysoki standard. Sypialnia wyposażona w łóżko ( będzie jeszcze szafa ). Łazienka z kabiną prysznicową. " +
                "Salon z w pełni wyposażoną kuchnią ( zmywarka, piekarnik, lodówka, mikrofala ). Mieszkanie jest przestronne i bardzo dobrze nasłonecznione. " +
                "Dodatkowo, z salonu mamy wyjście na balkon. Nieruchomość zlokalizowana jest na Pomorzanach. Czynsz wynosi 394,50 zł, dodatkowo należy doliczyć opłaty za prąd. " +
                "Jest również możliwość wynajęcia miejsca postojowego w podziemnym parkingu za kwotę ok. 300 zł. Serdecznie zapraszam na prezentację.";
            Console.WriteLine(l.Similarity(string1,string2));
            Console.WriteLine(l.Similarity(string1, string3));


            var xd = new QGram(4);
            Console.WriteLine(xd.Distance(string1,string2));

            Console.WriteLine(xd.Distance(string1, string3));
        }
    }
}
