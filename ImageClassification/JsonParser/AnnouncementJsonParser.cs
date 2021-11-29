using AnnouncementsModel;
using System;
using System.IO;
using Newtonsoft.Json;

namespace JsonParser
{
    public class AnnouncementJsonParser
    {
        public void ObjectToJson(Announcement announcement, String path)
        {
            var jsonString = JsonConvert.SerializeObject(announcement, Formatting.Indented);
            File.WriteAllText(path,jsonString);
        }

        public Announcement JsonToObject(String path)
        {
            var jsonString = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<Announcement>(jsonString);
        }
    }
}
