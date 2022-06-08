using System;
using System.ComponentModel.DataAnnotations;

namespace PustokProject.Models
{
	public class Slider
	{
		public int Id { get; set; }
		[MaxLength(50)]
		public string Title { get; set; }
		[MaxLength(50)]
		public string SubTitle { get; set; }
		[MaxLength(250)]
		public string Desc { get; set; }
		[MaxLength(250)]
		public string BtnUrl { get; set; }
		[MaxLength(250)]
		public string Image { get; set; }
		public int Order { get; set; }
	}
}

