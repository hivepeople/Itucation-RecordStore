using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecordStore.Models
{
    public class RecordStoreDbInitializer : System.Data.Entity.DropCreateDatabaseAlways<RecordStoreDb>
    {
        protected override void Seed(RecordStoreDb context)
        {
            context.Artists.Add(new Artist { Name = "DJ Jeg hader nisser" });
            context.Genres.Add(new Genre { Name = "Jazz" });
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "WildAtHeart" },
                Genre = new Genre { Name = "Rock" },
                Price = 10.1m,
                Title = "Caravan"
            });
            base.Seed(context);
        }
    }
}