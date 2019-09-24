using GerenciadorDeAniversarios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeAniversarios.Domain.Contexts
{
    public class FriendsContext : DbContext
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fabioper\workspace\faculdade\dotnet\fundamentos-csharp\gerenciador-de-aniversarios\GerenciadorDeAniversarios.Domain\FriendsDB.mdf;Integrated Security=True";

        public DbSet<Friend> Friends { get; set; }

        public FriendsContext() : base(ConnectionString)
        {

        }
    }
}
