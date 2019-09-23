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
        public DbSet<Friend> Friends { get; set; }

        public FriendsContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fabio\workspace\faculdade\dotnet\gerenciador-de-aniversarios\GerenciadorDeAniversarios.Domain\Data.mdf;Integrated Security=True")
        {

        }
    }
}
