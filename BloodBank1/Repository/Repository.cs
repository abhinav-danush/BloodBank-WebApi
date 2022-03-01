using BloodBank1.model;

using BloodBank1.view_model;
using bloodbank23.data;
using bloodbank23.model;
using BlooodBank.model;
using Microsoft.AspNetCore.Mvc;

namespace BloodBank1.Repository  //need to ask
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _db;



        public Repository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<BloodDetails> Create(BloodDetails obj)
        {

            var result = _db.BloodDetails.Add(obj);
            _db.SaveChanges();

            return result.Entity; //need to ask
        }

        public void Delete(int Id)
        {
            var BloodDb = _db.BloodDetails.Find(Id);
            _db.BloodDetails.Remove(BloodDb);
            _db.SaveChanges();

        }

        public List<BloodDetails> Get()
        {
            var ObjBloodList = _db.BloodDetails.ToList();
            return ObjBloodList;
        }

        public async Task<BloodDetails> Get(string Name)
        {
            var result = _db.BloodDetails.FirstOrDefault(m => m.Name == Name);
            return result;
        }

        public async Task<BloodDetails> GetById(int Id)
        {
            var result = _db.BloodDetails.Find(Id);
            return result;
        }

        public async Task<BloodDetails> Update(UpdateBlood request)
        {
            var BloodToDb = _db.BloodDetails.Find(request.Id);
            BloodToDb.Name = request.Name;
            BloodToDb.Address = request.Address;
            BloodToDb.Number = (int)request.Number; // doubt
            BloodToDb.BloodId = request.BloodId;
            
            _db.BloodDetails.Update(BloodToDb);
            _db.SaveChanges();
            return BloodToDb;
        }


        public List<BloodName> GetbloodN()
        {
            var BloodNameList = _db.BloodNames.ToList();
            return BloodNameList;
        }
        public List<KindOfOrg> Getbloodk()
        {
            var KindOfOrgList = _db.Kindoforgi.ToList();
            return KindOfOrgList;
        }
        public List<Hemoglobin> GetbloodH()
        {
            var HemoglobinList = _db.Hemoglobins.ToList();
            return HemoglobinList;
        }
       
    
    }
}
