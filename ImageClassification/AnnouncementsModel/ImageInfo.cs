using System;

namespace AnnouncementsModel
{
    public class ImageInfo
    {
        private String _imagePath;
        private String _roomType;

        public string ImagePath
        {
            get => _imagePath;
            set => _imagePath = value;
        }

        public string RoomType
        {
            get => _roomType;
            set => _roomType = value;
        }
    }
}