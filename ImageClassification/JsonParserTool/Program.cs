using System;
using System.Collections.Generic;
using AnnouncementsModel;
using JsonParser;

namespace JsonParserTool
{
    class Program
    {
        static void Main()
        {
            Announcement announcement = new Announcement();
            announcement.Description =
                "Na wynajem 2 pok. 34m2 zlokalizowane na 4 piętrze 4 piętrowego bloku na Pomorzanach. " +
                "Mieszkanie składa się z dwóch pokoi w tym jeden przejściowy, osobnej, widnej kuchni i łazienki z wanną i WC. " +
                "Mieszkanie w pełni umeblowane. Ogrzewanie i ciepła woda z sieci miejskiej, czynsz 330zł(w tym zaliczki na co i cw), " +
                "dodatkowo płatny prąd. Świetna lokazliacja, w pobliżu sklepy, szpital, PUM, komunikacja miejska. Mieszkanie wolne od zaraz. " +
                "Najem okazjonalny. 1500zł+czynsz 360zł+prąd Kaucja 1860 zł Zapraszam na prezentację. " +
                "Sprawdź naszą pełną ofertę na stronie E L I T E . N I E R U C H O M O S C I . P L " +
                "*KUPUJEMY MIESZKANIA Z OBCIĄŻENIAMI I DŁUGAMI ZA GOTÓWKĘ* ZADZWOŃ 502-424-064 " +
                "Powyższe ogłoszenie ma wyłącznie charakter informacyjny. Nie stanowi ono oferty w myśl art. 66 i n. ustawy z dnia 23.04.1964r. " +
                "Kodeks cywilny (Dz.U. 1964r. Nr 16, poz. 93, ze zm.). Oferta wysłana z programu dla biur nieruchomości ASARI CRM ();";
            var listOfImageInfos = new List<ImageInfo>();
            ImageInfo tmp = new ImageInfo();
            tmp.ImagePath = @"C:\ML.NET\HouseData\Ogloszenia\02\01.png";
            tmp.RoomType = "Badroom";
            listOfImageInfos.Add(tmp);

            tmp = new ImageInfo();
            tmp.ImagePath = @"C:\ML.NET\HouseData\Ogloszenia\02\02.png";
            tmp.RoomType = "Badroom";
            listOfImageInfos.Add(tmp);

            tmp = new ImageInfo();
            tmp.ImagePath = @"C:\ML.NET\HouseData\Ogloszenia\02\03.png";
            tmp.RoomType = "Badroom";
            listOfImageInfos.Add(tmp);

            tmp = new ImageInfo();
            tmp.ImagePath = @"C:\ML.NET\HouseData\Ogloszenia\02\04.png";
            tmp.RoomType = "Badroom";
            listOfImageInfos.Add(tmp);

            tmp = new ImageInfo();
            tmp.ImagePath = @"C:\ML.NET\HouseData\Ogloszenia\02\05.png";
            tmp.RoomType = "Badroom";
            listOfImageInfos.Add(tmp);

            tmp = new ImageInfo();
            tmp.ImagePath = @"C:\ML.NET\HouseData\Ogloszenia\02\06.png";
            tmp.RoomType = "Livingroom";
            listOfImageInfos.Add(tmp);

            tmp = new ImageInfo();
            tmp.ImagePath = @"C:\ML.NET\HouseData\Ogloszenia\02\07.png";
            tmp.RoomType = "Kitchen";
            listOfImageInfos.Add(tmp);

            tmp = new ImageInfo();
            tmp.ImagePath = @"C:\ML.NET\HouseData\Ogloszenia\02\08.png";
            tmp.RoomType = "Livingroom";
            listOfImageInfos.Add(tmp);

            tmp = new ImageInfo();
            tmp.ImagePath = @"C:\ML.NET\HouseData\Ogloszenia\02\09.png";
            tmp.RoomType = "Kitchen";
            listOfImageInfos.Add(tmp);

            tmp = new ImageInfo();
            tmp.ImagePath = @"C:\ML.NET\HouseData\Ogloszenia\02\10.png";
            tmp.RoomType = "Bathroom";
            listOfImageInfos.Add(tmp);

            announcement.ImageInfos = listOfImageInfos;

            AnnouncementJsonParser jsonParser = new AnnouncementJsonParser();
            jsonParser.ObjectToJson(announcement, @"C:\ML.NET\HouseData\Ogloszenia\02\Announcment.json");
        }
    }
}
