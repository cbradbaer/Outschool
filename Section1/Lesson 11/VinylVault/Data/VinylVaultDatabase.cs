using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VinylVault.Model;

namespace VinylVault.Data
{
    public class VinylVaultDatabase
    {

        SQLiteAsyncConnection database;



        public VinylVaultDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<AlbumModel>().Wait();


        }


        public async Task<List<AlbumModel>> GetAlbumsAsync()
        {
           return await database.Table<AlbumModel>().ToListAsync();
        }

        public async Task<int> InsertAlbum(AlbumModel am)
        {
            await database.InsertAsync(am);
            int ret = 1;
            return ret;

        }

        public async Task<int> DeleteAlbum(AlbumModel am)
        {
            await database.ExecuteScalarAsync<AlbumModel>("DELETE FROM [AlbumModel] WHERE Title = ?", am.Title);
            int ret = 1;
            return ret;
        }

        public async Task<int> UpdateAlbum(AlbumModel am)
        {
            await database.ExecuteScalarAsync<AlbumModel>("UPDATE [AlbumModel] SET ARTIST = ?, THUMBIMAGE = ?, GENRE = ?, LOCATION = ? WHERE TITLE = ?",
                                                            am.Artist, am.ThumbImage, am.Genre, am.Location, am.Title);
            int ret = 1;
            return ret;
        }




    }
}
