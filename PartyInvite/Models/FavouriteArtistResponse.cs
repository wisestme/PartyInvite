using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvite.Models
{
    public class FavouriteArtistResponse
    {
        public string UserName { get; set; }
        public string ArtistName { get; set; }
        public string YourFavouriteTrack { get; set; }
        public int NumberOfAlbum { get; set; }
        public DateTime ArtistDOB { get; set; }
    }
}