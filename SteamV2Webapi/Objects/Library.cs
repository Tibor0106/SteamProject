﻿namespace SteamV2Webapi.Objects
{
    public class Library
    {
        public int userId {  get; set; }
        public int gameId { get; set; }
        public DateTime purchased_since { get; set; }
    }
}