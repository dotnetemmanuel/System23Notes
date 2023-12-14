using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqWarsConsoleStart.Models
{
	public class Character
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<string> Appearances { get; set; }
		public List<string> Affilations { get; set; }
		public List<string> Locations { get; set; }
		public float Height { get; set; }
		public string Species { get; set; }
		public CharacterType CharacterType { get; set; }
		public List<string> Weapons { get; set; }
		public List<string> Vehicles { get; set; }
		public int WikipediaPageViews { get; set; }
		public string ImageUrl { get; set; }
	}
}
