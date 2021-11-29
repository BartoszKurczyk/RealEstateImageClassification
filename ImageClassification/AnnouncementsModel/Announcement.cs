using System;
using System.Collections.Generic;

namespace AnnouncementsModel
{

    public enum DistrictEnum
    {
        Centrum,
        Pomorzany,
        Gumience,
        Niebuszewo,
        Osow
    }
    public class Announcement
    {
        private String _description;

        private DistrictEnum _district;

        private double _area;

        private int _numberOfRooms;
        
        private List<ImageInfo> _imageInfos = null;


        #region Getters and Setters
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public DistrictEnum District
        {
            get => _district;
            set => _district = value;
        }

        public double Area
        {
            get => _area;
            set => _area = value;
        }

        public int NumberOfRooms
        {
            get => _numberOfRooms;
            set => _numberOfRooms = value;
        }

        public List<ImageInfo> ImageInfos
        {
            get => _imageInfos;
            set => _imageInfos = value;
        }
        #endregion
    }
}
