using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeek.Model
{
	public class Game
	{
		public int GameId { get; set; }
		public TimeSpan TimeLimit { get; set; }
		public Player Hider { get; set; }
		public Player Seeker { get; set; }
	}
}
