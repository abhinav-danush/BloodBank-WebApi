using BloodBank1.model;
using BloodBank1.reference;
using BloodBank1.Repository;
using BloodBank1.view_model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace BloodBank1.Controllers
{

    [Route("api/[controller]")]
    
    [ApiController]
    
    public class BloodController : ControllerBase
    {
        private readonly IRepository _db;
        private readonly object Id;
        private readonly CustomLogging _customLogging;
        public BloodController(IRepository db)
        {
            _db = db;
            

        }
        //GET ALL DATA FROM DB
        [HttpGet]
        [Authorize]
        public List<BloodDetailsResultDto> Get()
        {
            try
            {
                // _customLogging.LogMessage(CustomLogging.TracingLevel.INFO, "GetAll method called");
                var ObjBloodList = _db.Get();//master table
                var BloodNameList = _db.GetbloodN();
                var KindOfOrgList = _db.Getbloodk();
                var HemoglobinList = _db.GetbloodH();

                var result = from b in ObjBloodList
                             join b1 in BloodNameList
                             on b.BloodId equals b1.BloodId
                             join b2 in KindOfOrgList
                             on b.OrgId equals b2.OrgId
                             join b3 in HemoglobinList
                             on b.HemoglobinId equals b3.HemoglobinId
                             select new BloodDetailsResultDto
                             {
                                 BloodRecived = b.BloodRecived,
                                 BloodId = b1.BType,
                                 Id = b.Id,
                                 Address = b.Address,
                                 Name = b.Name,
                                 Number = b.Number,
                                 isVaccinate = b.isVaccinate,
                                 LastVaccination = b.LastVaccination,
                                 HemoglobinId = b3.HemoglobinLevel,
                                 OrgId = b2.OrgName
                             };


                return (result.ToList());
            }
            catch (Exception ex)
            {
                _customLogging.LogMessage(CustomLogging.TracingLevel.ERROR, ex.Message);
                return null;
            }
        }
        //CREATE A NEW DATA IN DB
        [HttpPost]
        public ActionResult Create(BloodDetails obj)
        {
            var res = _db.Create(obj);
            // _db.SaveChanges();
            return Ok(res);

        }
        //DELETE DATA IN DB
        [HttpDelete("{Id}")]
        public async Task<ActionResult<BloodDetails>> Delete(int Id)
        {
            try
            {
                _db.Delete(Id);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error in deleting data");
            }
        }
        //GET BY ID FROM DB
        [HttpGet]
        [Route("{Id:int}")]
        public async Task<ActionResult<BloodDetails>> Getby(int Id)
        {
            var ObjBloodList = _db.Get();//master table
            var BloodNameList = _db.GetbloodN();
            var KindOfOrgList = _db.Getbloodk();
            var HemoglobinList = _db.GetbloodH();

            var result = from b in ObjBloodList
                         join b1 in BloodNameList
                         on b.BloodId equals b1.BloodId
                         join b2 in KindOfOrgList
                         on b.OrgId equals b2.OrgId
                         join b3 in HemoglobinList
                         on b.HemoglobinId equals b3.HemoglobinId
                         select new BloodDetailsResultDto
                         {
                             BloodRecived = b.BloodRecived,
                             BloodId = b1.BType,
                             Id = b.Id,
                             Address = b.Address,
                             Name = b.Name,
                             Number = b.Number,
                             isVaccinate = b.isVaccinate,
                             LastVaccination = b.LastVaccination,
                             HemoglobinId = b3.HemoglobinLevel,
                             OrgId = b2.OrgName
                         };


            var result1 = result.First(i => i.Id == Id);

            return Ok(result1);
        }

       
        //EDIT DATA IN DB BY ID

        [HttpPut]
        public ActionResult<BloodDetails> Update(UpdateBlood request)
        {
            _db.Update(request);
            return Ok();
        }
        //GET DATA FROM DB BY NAME.
        [HttpGet("{Name}")]
        public IActionResult Get(string Name)
        {
            var ObjBloodList = _db.Get();
            var BloodNameList = _db.GetbloodN();
            var KindOfOrgList = _db.Getbloodk();
            var HemoglobinList = _db.GetbloodH();
            var result = from b in ObjBloodList
                         join b1 in BloodNameList on b.BloodId equals b1.BloodId
                         join b2 in KindOfOrgList on b.OrgId equals b2.OrgId
                         join b3 in HemoglobinList on b.HemoglobinId equals b3.HemoglobinId
                         select new { b.Id, b.Name, b.Number, b.BloodRecived, b.Address, b.isVaccinate, b.LastVaccination, b1.BType, b2.OrgName, b3.HemoglobinLevel };

            return Ok(result.FirstOrDefault(a => a.Name == Name));
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetbloodN()
        {
            var BloodNameList = _db.GetbloodN();


            return Ok(BloodNameList);
        }
        [HttpGet]
        [Route("KindOfOrg/[controller]")]
        public IActionResult Getbloodk()
        {
            var BloodNameList = _db.Getbloodk();


            return Ok(BloodNameList);
        }
        [HttpGet]
        [Route("Hemoglobin/[controller]")]
        public IActionResult GetbloodH()
        {
            var BloodNameList = _db.GetbloodH();


            return Ok(BloodNameList);
        }
    }
}
