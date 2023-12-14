using LinqWarsConsoleStart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqWarsConsoleStart.Data
{
	public static class CharacterManager
	{
		public static List<Character> Characters { get; set; }

		public static List<Character> GetAllCharacters()
		{
			if (Characters == null || !Characters.Any())
			{
				Characters = new List<Character>
				{
					new Character()
					{
						Name = "Yoda",
						Appearances = new List<string>()
						{
							"Star Wars: The Empire Strikes Back",
							"Star Wars: Return of the Jedi",
							"Star Wars: The Phantom Menace",
							"Star Wars: Attack of the Clones",
							"Star Wars: Revenge of the Sith",
							"Star Wars Rebels",
							"Star Wars: The Clone Wars"
						},
						Affilations =  new List<string>()
						{
							"Jedi Order",
						},
						Locations = new List<string>()
						{
							"Yoda's hut"
						},
						Height = 0.66f,
						Species = "Unknown",
						CharacterType = CharacterType.Hero,
						Weapons = new List<string>()
						{
							"Lightsaber"
						},
						Vehicles = new List<string>(),
						WikipediaPageViews = 4656892,
						ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/Yoda-Retina_2a7ecc26.jpeg?region=0%2C0%2C1536%2C864&width=768"
					},
					new Character()
					{
						Name = "Luke Skywalker",
						Appearances = new List<string>() {
							"Star Wars: A New Hope",
							"Star Wars: The Empire Strikes Back",
							"Star Wars: Return of the Jedi",
							"Star Wars: Revenge of the Sith",
							"Star Wars: The Force Awakens",
							"Star Wars: The Last Jedi",
							"Star Wars: The Rise of Skywalker",
							"Star Wars Rebels, The Mandalorian"
						},
						Affilations = new List<string>()
						{
							"Rebel Alliance",
							"Jedi Order"
						},
						Locations = new List<string>()
						{
							"Polis Massa",
							"Lars Moisture Farm",
							"Tatooine"
						},
						Height = 1.72f,
						Species = "Human",
						CharacterType = CharacterType.Hero,
						Weapons = new List<string>()
						{
							"Lightsaber",
							"Blaster Pistol",
							"Luke Skywalker's Lightsaber (Green Blade)",
							"Skywalker lightsaber"
						},
						Vehicles = new List<string>()
						{
							"T-16 Skyhopper",
							"X-34 Landspeeder",
							"X-wing Starfighter",
							"Snowspeeder"
						},
						WikipediaPageViews = 5432601,
						ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/luke-skywalker-main_92d422b0.jpeg?region=304%2C0%2C1778%2C1000&width=768"
					},
					new Character()
					{
						Name = "Han Solo",
						Appearances = new List<string>() {
							"Star Wars: A New Hope",
							"Star Wars: The Empire Strikes Back",
							"Star Wars: Return of the Jedi",
							"Star Wars: The Force Awakens",
							"Solo: A Star Wars Story",
							"Star Wars: The Rise of Skywalker"
						},
						Affilations = new List<string>()
						{
							"Rebel Alliance"
						},
						Locations = new List<string>()
						{
							"Mos Eisley Spaceport",
							"Corellia",
							"Numidian Prime"
						},
						Height = 1.8f,
						Species = "Human",
						CharacterType = CharacterType.Hero,
						Weapons = new List<string>()
						{
							"Blaster Pistol",
						},
						Vehicles = new List<string>()
						{
							"Millennium Falcon",
							"The Eravana"
						},
						WikipediaPageViews = 4541986,
						ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/han-solo-main_a4c8ff79.jpeg?region=0%2C0%2C1920%2C1080&width=768"
					},
					new Character()
					{
						Name = "Jar Jar Binks",
						Appearances = new List<string>()
						{
							"Star Wars: The Phantom Menace",
							"Star Wars: Attack of the Clones",
							"Star Wars: Revenge of the Sith",
							"Star Wars: The Clone Wars"
						},
						Affilations = new List<string>()
						{
							"Gungan Grand Army",
							"Galactic Republic"
						},
						Locations = new List<string>()
						{
							"Naboo"
						},
						Height = 1.96f,
						Species = "Gungan",
						CharacterType = CharacterType.Hero,
						Weapons = new List<string>()
						{
							"Energy Ball (Booma)",
							"Electropole"
						},
						Vehicles = new List<string>()
						{
							"Gungan Bongo Submarine"
						},
						WikipediaPageViews = 2475927,
						ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/databank_jarjarbinks_01_169_c70767ab.jpeg?region=0%2C0%2C1560%2C878&width=768"
					},
					new Character()
					{
						Name = "Chewbacca",
						Appearances = new List<string>()
						{
							"Star Wars: A New Hope",
							"Star Wars: The Empire Strikes Back",
							"Star Wars: Return of the Jedi",
							"Star Wars: Revenge of the Sith",
							"Star Wars: The Force Awakens",
							"Star Wars: The Last Jedi",
							"Solo: A Star Wars Story",
							"Star Wars: The Rise of Skywalker",
							"Star Wars: The Clone Wars"
						},
						Affilations = new List<string>()
						{
							"Rebel Alliance",
							"The Resistance"
						},
						Locations = new List<string>()
						{
							"Kashyyyk",
							"Numidian Prime"
						},
						Height = 2.28f,
						Species = "Wookie",
						CharacterType = CharacterType.Hero,
						Weapons = new List<string>()
						{
							"Bowcaster"
						},
						Vehicles = new List<string>()
						{
							"Millennium Falcon",
							"The Eravana"
						},
						WikipediaPageViews = 2816764,
						ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/chewie-main_e1968a8a.jpeg?region=131%2C0%2C951%2C536&width=768"
					},
					new Character()
					{
						Name = "Leia Organa",
						Appearances = new List<string>()
						{
							"Star Wars: A New Hope",
							"Star Wars: The Empire Strikes Back",
							"Star Wars: Return of the Jedi",
							"Star Wars: Revenge of the Sith",
							"Star Wars: The Force Awakens",
							"Rogue One: A Star Wars Story",
							"Star Wars: The Last Jedi",
							"Star Wars Rebels",
							"Star Wars Resistance"
						},
						Affilations = new List<string>()
						{
							"Rebel Alliance",
							"The Resistance",
							"Galactic Senate",
							"Alderaan Royal Family"
						},
						Locations =  new List<string>()
						{
							"Alderaan",
							"Polis Massa",
							"Crait"
						},
						Height = 1.5f,
						Species = "Human",
						CharacterType = CharacterType.Hero,
						Weapons = new List<string>()
						{
							"Blaster Pistol"
						},
						Vehicles = new List<string>()
						{
							"Tantive IV",
							"The Raddus"
						},
						WikipediaPageViews = 5781408,
						ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/leia-organa-feature-image_d0f5e953.jpeg?region=0%2C0%2C1280%2C720&width=768"
					},
					new Character()
					{
						Name = "Jabba the Hutt",
						Appearances = new List<string>()
						{
							"Star Wars: A New Hope",
							"Star Wars: Return of the Jedi",
							"Star Wars: The Phantom Menace",
							"Star Wars: The Clone Wars"
						},
						Affilations = new List<string>(),
						Locations = new List<string>()
						{
							"Jabba the Hutt's Palace",
							"Mos Eisley Spaceport",
							"Tatooine"
						},
						Height = 3.9f,
						Species = "Hutt",
						CharacterType = CharacterType.Villain,
						Weapons = new List<string>(),
						Vehicles = new List<string>()
						{
							"Jabba's Sail Barge"
						},
						WikipediaPageViews = 2271456,
						ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/Jabba-The-Hutt_b5a08a70.jpeg?region=0%2C0%2C1200%2C675&width=768"
					},
					new Character()
					{
						Name = "Boba Fett",
						Appearances = new List<string>()
						{
							"Star Wars: A New Hope",
							"Star Wars: The Empire Strikes Back",
							"Star Wars: Return of the Jedi",
							"Star Wars: Attack of the Clones",
							"Star Wars: The Clone Wars",
							"The Mandalorian"
						},
						Affilations = new List<string>(),
						Locations = new List<string>()
						{
							"Kamino"
						},
						Height = 1.83f,
						Species = "Human",
						CharacterType = CharacterType.Villain,
						Weapons = new List<string>()
						{
							"Z-6 Jetpack",
							"Blaster Rifle",
							"Flame Thrower"
						},
						Vehicles = new List<string>()
						{
							"Slave I"
						},
						WikipediaPageViews = 4855742,
						ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/boba-fett-main_75a5545c.jpeg?region=0%2C1%2C951%2C536&width=768",
					},
					new Character()
					{
						Name = "C-3PO",
						Appearances = new List<string>()
						{
							"Star Wars: A New Hope",
							"Star Wars: The Empire Strikes Back",
							"Star Wars: Return of the Jedi",
							"Star Wars: The Phantom Menace",
							"Star Wars: Attack of the Clones",
							"Star Wars: Revenge of the Sith",
							"Star Wars: The Force Awakens",
							"Rogue One: A Star Wars Story",
							"Star Wars: The Last Jedi",
							"Star Wars: The Rise of Skywalker",
							"Star Wars Rebels",
							"Star Wars: The Clone Wars"
						},
						Affilations = new List<string>()
						{
							"Rebel Alliance",
							"The Resistance"
						},
						Locations = new List<string>()
						{
							"Rebel Alliance",
							"The Resistance"
						},
						Height = 1.75f,
						Species = "Droid",
						CharacterType = CharacterType.Hero,
						Weapons = new List<string>(),
						Vehicles = new List<string>(),
						WikipediaPageViews = 1569785,
						ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/c-3po-main_417a2902.jpeg?region=176%2C0%2C951%2C536&width=768"
					},
					new Character()
					{
						Name = "Count Dooku",
						Appearances = new List<string>()
						{
							"Star Wars: Attack of the Clones",
							"Star Wars: Revenge of the Sith",
							"Star Wars: The Clone Wars"
						},
						Affilations = new List<string>()
						{
							"Jedi Order",
							"Confederacy of Independent Systems",
							"Sith"
						},
						Locations = new List<string>()
						{
							"Serenno"
						},
						Height = 1.93f,
						Species = "Human",
						CharacterType = CharacterType.Villain,
						Weapons = new List<string>()
						{
							"Lightsaber"
						},
						Vehicles = new List<string>()
						{
							"Solar Sailer",
							"Count Dooku's Speeder"
						},
						WikipediaPageViews = 1996194,
						ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/Count-Dooku_4f552149.jpeg?region=0%2C0%2C1436%2C808&width=768"
					},
					new Character()
					{
						Name = "Padmé Amidala",
						Appearances = new List<string>()
						{
							"Star Wars: The Phantom Menace",
							"Star Wars: Attack of the Clones",
							"Star Wars: Revenge of the Sith",
							"Star Wars: The Clone Wars"
						},
						Affilations = new List<string>()
						{
							"Galactic Republic",
							"Galactic Senate"
						},
						Locations = new List<string>()
						{
							"Naboo"
						},
						Height = 1.65f,
						Species = "Human",
						CharacterType = CharacterType.Hero,
						Weapons = new List<string>(),
						Vehicles = new List<string>()
						{
							"Naboo N-1 Starfighter",
							"Naboo Royal Starship",
							"Naboo Royal Cruiser"
						},
						WikipediaPageViews = 4397355,
						ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/Padme-Amidala_05d50c8a.jpeg?region=0%2C0%2C1536%2C864&width=768"
					},
					new Character()
					{
						Name = "R2-D2",
						Appearances = new List<string>()
						{
							"Star Wars: A New Hope",
							"Star Wars: The Empire Strikes Back",
							"Star Wars: Return of the Jedi",
							"Star Wars: The Phantom Menace",
							"Star Wars: Attack of the Clones",
							"Star Wars: Revenge of the Sith",
							"Star Wars: The Force Awakens",
							"Rogue One: A Star Wars Story",
							"Star Wars: The Last Jedi",
							"Star Wars: The Rise of Skywalker",
							"Star Wars Rebels",
							"Star Wars: The Clone Wars",
							"The Mandalorian"
						},
						Affilations = new List<string>()
						{
							"Rebel Alliance",
							"Galactic Republic",
							"The Resistance"
						},
						Locations = new List<string>()
						{
							"Naboo",
							"Havoc Outpost"
						},
						Height = 1.09f,
						Species = "Droid",
						CharacterType = CharacterType.Hero,
						Weapons = new List<string>(),
						Vehicles = new List<string>()
						{
							"X-wing Starfighter",
							"Poe Dameron’s X-wing fighter",
							"Jedi Starfighter"
						},
						WikipediaPageViews = 1723507,
						ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/r2-d2-main_86916bb6.jpeg?region=304%2C0%2C1778%2C1000&width=768"
					},
					new Character()
					{
						Name = "Lando Calrissian",
						Appearances = new List<string>()
						{
							"Star Wars: The Empire Strikes Back",
							"Star Wars: Return of the Jedi",
							"Solo: A Star Wars Story",
							"Star Wars: The Rise of Skywalker",
							"Star Wars Rebels"
						},
						Affilations = new List<string>()
						{
							"Rebel Alliance",
							"The Resistance"
						},
						Locations = new List<string>()
						{
							"Cloud City",
							"Bespin",
							"Numidian Prime",
							"Pasaana"
						},
						Height = 1.78f,
						Species = "Human",
						CharacterType = CharacterType.Hero,
						Weapons = new List<string>()
						{
							"SE-14 blaster pistol"
						},
						Vehicles = new List<string>()
						{
							"Millennium Falcon"
						},
						WikipediaPageViews = 2678760,
						ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/lando-main_a207290e.jpeg?region=147%2C0%2C951%2C536&width=768"
					},
					new Character()
					{
						Name = "Sebulba",
						Appearances = new List<string>()
						{
							"Star Wars: The Phantom Menace"
						},
						Affilations = new List<string>()
						{
							"Boonta Eve Classic Podracer Pilots"
						},
						Locations = new List<string>()
						{
							"Malastare",
							"Tatooine"
						},
						Height = 1.12f,
						Species = "Dug",
						CharacterType = CharacterType.None,
						Weapons = new List<string>(),
						Vehicles = new List<string>()
						{
							"Sebulba's Podracer"
						},
						WikipediaPageViews = 0,
						ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/sebulba_1f3fe180.jpeg?region=0%2C0%2C2453%2C1380&width=768"
					},
					new Character()
					{
						Name = "Darth Vader",
						Appearances = new List<string>()
						{
							"Star Wars: A New Hope",
							"Star Wars: The Empire Strikes Back",
							"Star Wars: Return of the Jedi",
							"Star Wars: Revenge of the Sith",
							"Rogue One: A Star Wars Story",
							"Star Wars Rebels"
						},
						Affilations = new List<string>()
						{
							"Galactic Empire",
							"Sith"
						},
						Locations = new List<string>()
						{
							"Death Star",
							"Death Star II"
						},
						Height = 2.03f,
						Species = "Human",
						CharacterType = CharacterType.Villain,
						Weapons = new List<string> ()
						{
							"Darth Vader's lightsaber"
						},
						Vehicles = new List<string>()
						{
							"Darth Vader's TIE Fighter"
						},
						WikipediaPageViews = 80756217,
						ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/Darth-Vader_6bda9114.jpeg?region=0%2C23%2C1400%2C785&width=768"
					},
					new Character()
					{
						Name = "Rey",
						Appearances = new List<string>()
						{
							"Star Wars: The Force Awakens",
							"Star Wars: The Last Jedi",
							"Star Wars: The Rise of Skywalker",
							"Star Wars: Forces of Destiny"
						},
						Affilations = new List<string>(),
						Locations = new List<string>()
						{
							"Jakku",
							"Goazon Badlands",
							"Rey's Home"
						},
						Height = 1.7f,
						Species = "Human",
						CharacterType = CharacterType.Hero,
						Weapons = new List<string>()
						{
							"Lightsaber",
							"Blaster Pistol",
							"Skywalker lightsaber",
							"Rey's Blaster",
							"Rey's Quarterstaff"
						},
						Vehicles = new List<string>()
						{
							"Millennium Falcon",
							"X-wing Starfighter",
							"Rey's Speeder"
						},
						WikipediaPageViews = 6190844,
						ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/rey-main_ca4bb0d7.jpeg?region=180%2C0%2C951%2C536&width=768"
					},
					new Character()
					{
						Name = "Emperor Palpatine / Darth Sidious",
						Appearances = new List<string>()
						{
							"Star Wars: The Empire Strikes Back",
							"Star Wars: Return of the Jedi",
							"Star Wars: The Phantom Menace",
							"Star Wars: Attack of the Clones",
							"Star Wars: Revenge of the Sith",
							"Star Wars: The Rise of Skywalker",
							"Star Wars Rebels",
							"Star Wars: The Clone Wars"
						},
						Affilations = new List<string>()
						{
							"Galactic Empire",
							"Galactic Republic",
							"Sith",
							"Galactic Senate"
						},
						Locations = new List<string>()
						{
							"Naboo",
							"Death Star II"
						},
						Height = 1.73f,
						Species = "Human",
						CharacterType = CharacterType.Villain,
						Weapons = new List<string>()
						{
							"Lightsaber",
							"Force Lightning",
							"Palpatine's lightsaber"
						},
						Vehicles = new List<string>(),
						WikipediaPageViews = 6663706,
						ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/emperor-palpatine-darth-sidious-main_3d82ddaa.jpeg?region=164%2C0%2C953%2C536&width=768"
					}
				};
			}

			return Characters;
		}
	}
}
