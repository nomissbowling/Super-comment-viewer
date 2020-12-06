using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace super_comment_viewer.model.json.jsonmodel
{
    public class Movie
    {
        [JsonInclude]
        public int id { get; set; }
        [JsonIgnore]
        public bool is_on_live { get; set; } 
    }
    
    public class UserMovieInfoModel
    {
        [JsonIgnore]
        public int update_interval_sec;
        [JsonInclude]
        public Movie movie;

        public override string ToString()
        {
            return $"update_interval_sec : {update_interval_sec}\n movie:{movie.id}";
        }

        public override int GetHashCode()
        {
            int hash = 31;
            hash = hash * 31 + update_interval_sec;
            hash = hash * 31 + movie.GetHashCode();
            return hash;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is UserMovieInfoModel)) return false;
            if (!((obj as UserMovieInfoModel).movie.id == this.movie.id)) return false;
            return true;
        }
    }
}
