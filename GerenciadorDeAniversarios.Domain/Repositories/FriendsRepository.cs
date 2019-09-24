using GerenciadorDeAniversarios.Domain.Contexts;
using GerenciadorDeAniversarios.Domain.Entities;
using GerenciadorDeAniversarios.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GerenciadorDeAniversarios.Domain.Repositories
{
    public class FriendsRepository : IRepository<Friend>
    {
        private readonly FriendsContext db;
        private static FriendsRepository _instance;
        public static FriendsRepository Instance
        {
            get
            {
                _instance = _instance ?? new FriendsRepository();

                return _instance;
            }
        }

        private FriendsRepository()
        {
            db = new FriendsContext();
        }

        public IEnumerable<Friend> GetAll()
        {
            var query = from friend in db.Friends
                        orderby friend.Id
                        select friend;

            return query;
        }

        public void Insert(Friend entity)
        {
            var friend = new Friend()
            {
                Name = entity.Name,
                FamilyName = entity.FamilyName,
                Birthdate = entity.Birthdate
            };

            db.Friends.Add(friend);
            db.SaveChanges();
        }

        public void Remove(int id)
        {
            var friend = GetById(id);
            db.Friends.Remove(friend);
            db.SaveChanges();
        }

        public void Update(Friend entity)
        {
            var friend = db.Friends.Find(entity.Id);
            friend.Name = entity.Name;
            friend.FamilyName = entity.FamilyName;
            friend.Birthdate = entity.Birthdate;

            db.SaveChanges();
        }

        public Friend GetById(int id)
        {
            return db.Friends.Find(id);
        }

        public IEnumerable<Friend> GetByKeyword(string query)
        {
            return db.Friends.Where(f => f.Name.Contains(query)
                                         || f.FamilyName.Contains(query));
        }
    }
}
