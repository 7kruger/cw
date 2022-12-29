﻿using System;

namespace CourseWork.Domain.Entities
{
	public class Item
	{
		public string Id { get; set; }
		public string CollectionId { get; set; }
		public string Name { get; set; }
		public string Author { get; set; }
		public string Content { get; set; }
		public DateTime Date { get; set; }
		public string ImgRef { get; set; }
	}
}
