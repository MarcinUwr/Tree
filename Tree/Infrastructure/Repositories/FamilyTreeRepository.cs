using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Domain.Models.FamilyTree;
using Domain.Models.FamilyTree.Repositories;
using Domain.Models.Person;

namespace Infrastructure.Repositories
{
    public class FamilyTreeRepository : RepositoryBase<FamilyTree>, IFamilyTreeRepository
    {
        //todo: move this to function call
        private readonly List<FamilyTree> _trees;

        public FamilyTreeRepository(DbContext dataContext) : base(dataContext)
        {
            _trees = dataContext.Set<FamilyTree>().Include(t => t.Members).ToList();
        }

        public void Add(int id, Person person)
        {
            var tree = DbSet.Find(id);
            person.FamilyTree = tree;
            if (tree != null)
            {
                if (tree.Root == null)
                {
                    tree.Root = person;
                }
                else
                {
                    tree.Members.Add(person);
                }
                DbContext.SaveChanges();
            }
        }

        public new FamilyTree GetById(int id)
        {
            {
                return _trees.FirstOrDefault(t => t.Id == id);
            }
        }
    }
}