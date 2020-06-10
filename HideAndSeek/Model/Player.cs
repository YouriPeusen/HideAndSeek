using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeek.Model
{
	abstract public class Player
	{
		public int PlayerId { get; set; }
		public int Role { get; set; }
		public bool Winner { get; set; }

		public void ViewGameStats(int gameId)
		{

		}

		public void ViewGameHistorys()
		{

		}

		public void SelectRole()
		{

		}
	}
}
