using static System.Environment;

namespace AllForOneAPI.Services.MadLib;

public class MadLibService : IMadLibService
{
    public string MakeStory(string nameOne, string pronoun, string nounOne, string warriorsWeapon, string creatureOne, string locationOne, string nameTwo, string ageOne, string toolOne, string pocketItem)
    {
        return $"There once was a dwarf named {nameOne}. {pronoun} was on the hunt for {nounOne} inside a dragon's lair. {pronoun} only carries {warriorsWeapon} to play kicking toons for the boys at the tavern. {nameOne} crossed gueling mountain passes and treacherous rivers, only to see a hoard of {creatureOne} outside of the cave where the dragon's lair is located. {nameOne}, in a blaze of glory, bravely runs away to the nearby town of {locationOne}." + NewLine + $"It is here that {nameOne} meets {nameTwo}, a {ageOne}-year-old street urchin. The two team up and, using {nameTwo}'s knowledge, deflty sneak into the dragon's lair. Once inside {nameOne} plays a rousing batlledance which motivates {nameTwo} to charge the Dragon Matriarch head-on. {nameTwo} uses a rusty {toolOne} to pierce the scales of the dragon. For {nameTwo}'s efforts, the dragon swallowed {nameTwo} whole. All alone, {nameOne} charged into the line of fire, quite literally as the dragon's mouth was like a blast furnace. {nameOne} was immediately disintegrated, and the Dragon Matriarch took {nameOne}'s only possesion that wasnt burned in the flame for herself: {pocketItem}.";
    }
}