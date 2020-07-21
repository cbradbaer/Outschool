﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VinylVaultApp.Model;

namespace VinylVaultApp.Data
{
    public class VinylVaultDatabase
    {

        SQLiteAsyncConnection database;

        public VinylVaultDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<AlbumModel>().Wait();
        }


        public async Task<bool> InsertAlbum(AlbumModel alb)
        {
            await database.InsertAsync(alb);
            return true;

        }

        public async Task<bool> DeleteAlbum(AlbumModel alb)
        {
            await database.ExecuteScalarAsync<AlbumModel>("DELETE FROM [AlbumModel] WHERE TITLE = ?", alb.Title);
            return true;
        }

        public async Task<bool> UpdateAlbum(AlbumModel alb)
        {
            await database.ExecuteScalarAsync<AlbumModel>("UPDATE [AlbumModel] SET ARTIST = ?, THUMBIMAGE = ?, GENRE = ?, LOCATION = ? WHERE TITLE = ?",alb.Artist, alb.ThumbImage, alb.Genre, alb.Location, alb.Title);
            return true;
        }


        public async Task<List<AlbumModel>> GetAlbumsAsync()
        {

            return await database.Table<AlbumModel>().ToListAsync();

        }



    }
}
