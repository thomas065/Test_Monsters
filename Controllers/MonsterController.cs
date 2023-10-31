using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Test_Monsters.Models;

namespace Test_Monsters.Controllers
{
	public class MonsterController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			ViewData["HeroImage"] = "/img/main.gif";
			MonsterData hero = new MonsterData();

			hero.Hitpoints = 0;
			hero.Mana = 0;
			hero.Stamina = 0;
			hero.Strength = 0;

			return View(hero);
		}

		[HttpPost]
		public IActionResult Index(MonsterData hero, string archetype)
		{
			if (archetype == "Warrior")
			{
				ViewData["HeroImage"] = "/img/warrior.gif";
				hero.Name = hero.Name;
				hero.Hitpoints = 35;
				hero.Stamina = 100;
				hero.Strength = 12;
				hero.Mana = 0;
			}
			else if (archetype == "Illusionist")
			{
				ViewData["HeroImage"] = "/img/mage.gif";
				hero.Name = hero.Name;
				hero.Hitpoints = 23;
				hero.Stamina = 0;
				hero.Strength = 7;
				hero.Mana = 100;
			}
			else if (archetype == "Rogue")
			{
				ViewData["HeroImage"] = "/img/thief.gif";
				hero.Name = hero.Name;
				hero.Hitpoints = 30;
				hero.Stamina = 100;
				hero.Strength = 10;
				hero.Mana = 25;
			}
			else if (archetype == "Necromancer")
			{
				ViewData["HeroImage"] = "/img/necromancy.gif";
				hero.Name = hero.Name;
				hero.Hitpoints = 21;
				hero.Stamina = 0;
				hero.Strength = 5;
				hero.Mana = 100;
			}
			else if (archetype == "Healer")
			{
				ViewData["HeroImage"] = "/img/healer.gif";
				hero.Name = hero.Name;
				hero.Hitpoints = 22;
				hero.Stamina = 0;
				hero.Strength = 4;
				hero.Mana = 100;
			}
			else if (archetype == "Paladin")
			{
				ViewData["HeroImage"] = "/img/paladin.gif";
				hero.Name = hero.Name;
				hero.Hitpoints = 35;
				hero.Stamina = 40;
				hero.Strength = 14;
				hero.Mana = 80;
			}

			return View(hero);
		}
	}
}
