using Microsoft.AspNetCore.Mvc;
using AllForOneAPI.Services.MadLib;

namespace AllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
    private readonly IMadLibService _madLibService;

    public MadLibController(IMadLibService madLibService)
    {
        _madLibService = madLibService;
    }

    [HttpGet]
    [Route("{nameOne}/{pronoun}/{nounOne}/{warriorsWeapon}/{creatureOne}/{locationOne}/{nameTwo}/{ageOne}/{toolOne}/{pocketItem}")]
    public string MakeStory(string nameOne, string pronoun, string nounOne, string warriorsWeapon, string creatureOne, string locationOne, string nameTwo, string ageOne, string toolOne, string pocketItem)
    {
        return _madLibService.MakeStory(nameOne, pronoun, nounOne, warriorsWeapon, creatureOne, locationOne, nameTwo, ageOne, toolOne, pocketItem);
    }

}
