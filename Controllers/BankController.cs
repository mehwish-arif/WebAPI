using Microsoft.AspNetCore.Mvc;

namespace Class3RestApi.Controller
{


[Route("api/v1/bank")]

public class BankController : ControllerBase
{
private ILogic _logic;
    public BankController(ILogic logic)
    {
        _logic = logic;
    }


    //create
    [HttpPost]
    public void Post(AccountPoco item)
    {
        _logic.Create(item);
    }
    //Read
    [HttpGet]
    public IActionResult AccountPoco Get(int id)
    {
        AccountPoco result = _logic.Read(id);
        if(result!=null)
        {
            return Ok(_logic.Read(id));
        }
        else {
            return NotFount();
        }
    }
    //update
    [HttpPut]
     public void Update(AccountPoco item)
     {
         _logic.Update(item);
     }
    //delete

    public void Delete(int id)
    {
            _logic.Delete(item);
    }
}

}