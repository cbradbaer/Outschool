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
            return 1;

        }

        public async Task<int> DeleteAlbum(AlbumModel am)
        {
            await database.ExecuteScalarAsync<AlbumModel>("DELETE FROM [AlbumModel] WHERE Title = ?", am.Title);
            return 1;
        }

        public async Task<int> UpdateAlbum(AlbumModel am)
        {

            await database.ExecuteScalarAsync<AlbumModel>("UPDATE [AlbumModel] SET Artist = ?, Genre = ?, Location = ?, ThumbImage = ? WHERE Title = ?",
                            am.Artist, am.Genre, am.Location, am.ThumbImage, am.Title );

            return 1;

        }


            



    }
}
