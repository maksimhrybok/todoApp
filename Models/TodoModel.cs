using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todoApp.Models
{
    internal class TodoModel
    {
		private bool _isDone;
		private string _text;

        public DateTime CreationDate { get; set; } = DateTime.Now;


		public bool isDone
		{
			get { return _isDone; }
			set { _isDone = value; }
		}


		public string Text
		{
			get { return _text; }
			set { _text = value; }
		}


	}
}
