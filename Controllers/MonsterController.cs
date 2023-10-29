using Microsoft.AspNetCore.Mvc;
using Test_Monsters.Models;

namespace Test_Monsters.Controllers
{
	public class MonsterController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			MonsterData hero = new MonsterData();

			hero.Hitpoints = 0;
			hero.Mana = 0;
			hero.Stamina = 0;
			hero.Strength = 0;

			return View(hero);
		}

		[HttpPost]
		public IActionResult Index(MonsterData hero)
		{
			hero.Name = $"Name: {hero.Name}";
			hero.Hitpoints = 35;
			hero.Stamina = 100;
			hero.Strength = 12;
			hero.Mana = 0;

			return View(hero);
		}
	}
}
