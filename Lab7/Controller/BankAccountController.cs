using Lab7.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Controller
{
	public class BankAccountController
	{
		public BankAccountController(ref BankRuntimeDB db)
		{
			db = new BankRuntimeDB();
		}
	}
}
