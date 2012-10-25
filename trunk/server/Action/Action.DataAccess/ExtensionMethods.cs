﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;

namespace Action.DataAccess
{
    public static class ExtensionMethods
    {
        public static MongoCollection<T> GetCollection<T>(this MongoDatabase db)
        {
            return db.GetCollection<T>(typeof(T).Name);
        }

    }
}