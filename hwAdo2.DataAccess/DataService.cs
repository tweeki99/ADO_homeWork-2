﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwAdo2.DataAccess
{
    public class DataService
    {
        private readonly string _connectionString;

        private readonly DbProviderFactory _providerFactory;

        public DataService()
        {
            _providerFactory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["HomeConnectionString"].ProviderName);
            _connectionString = ConfigurationManager.ConnectionStrings["HomeConnectionString"].ConnectionString;
        }

        public void CreateGruppaTable()
        {
            using (var connection = _providerFactory.CreateConnection())
            using (var command = connection.CreateCommand())
            {
                connection.ConnectionString = _connectionString;
                connection.Open();
                command.CommandText = @"CREATE TABLE [dbo].[Table] ( [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), [Name] NVARCHAR(50) NOT NULL)";
                command.ExecuteNonQuery();
            }
        }
    }
}
