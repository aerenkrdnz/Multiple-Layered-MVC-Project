﻿using System.ComponentModel.DataAnnotations;

namespace MarketoExpress.WebUI.Areas.Admin.Models
{
	public class CategoryFormViewModel
	{
		public int Id { get; set; }

		[Display(Name = "Ad")]
		[Required(ErrorMessage = "Kategori adını girmek zorunludur.")]
		public string Name { get; set; }

		[Display(Name = "Açıklama")]
		public string? Description { get; set; }
	}
}
