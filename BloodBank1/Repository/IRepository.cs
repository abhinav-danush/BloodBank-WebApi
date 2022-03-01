using BloodBank1.model;
using BloodBank1.view_model;
using bloodbank23.model;
using BlooodBank.model;
using Microsoft.AspNetCore.Mvc;

namespace BloodBank1.Repository


{
    public interface IRepository
    {
        

        void Delete(int id);
        List<BloodDetails> Get();
        Task<BloodDetails> Get(string Name);
        Task<BloodDetails> GetById(int Id);
        Task<BloodDetails> Update(UpdateBlood request);
        Task<BloodDetails> Create(BloodDetails obj);
        List<BloodName> GetbloodN();
        List<KindOfOrg> Getbloodk();
        List<Hemoglobin> GetbloodH();
        
    }
}