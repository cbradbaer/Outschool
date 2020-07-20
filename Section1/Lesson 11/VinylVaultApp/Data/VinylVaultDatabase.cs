using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VinylVaultApp.Model;

namespace VinylVaultApp.Data
{
    public class VinylVaultDatabase
    {
       readonly SQLiteAsyncConnection database;

        public VinylVaultDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<album>().Wait();

        }

        public async Task<int> InsertAlbum(album alb)
        {
           int retval =  await database.InsertAsync(alb);
            return retval;

        }

        public async Task<int> DeleteAlbum(album alb)
        {
            album retval = await database.ExecuteScalarAsync<album>("DELETE FROM [album] WHERE TITLE= ?", alb.Title);
            if (retval == null)
                return 0;
            else
                return 1;
        }

        public async Task<int> UpdateAlbum(album alb)
        {
            album retval = await database.ExecuteScalarAsync<album>("UPDATE [album] SET ARTIST = ?, THUMBIMAGE = ?, GENRE = ?, LOCATION = ? WHERE TITLE = ?", alb.Artist, alb.ThumbImage, alb.Genre, alb.Location, alb.Title);
            if (retval == null)
                return 0;
            else
                return 1;

        }


        public async Task<List<album>> GetAlbumsAsync()
        {

            return await database.Table<album>().ToListAsync();
        }





    }
}
