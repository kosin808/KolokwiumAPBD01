namespace WebApplication1.DTOs;
using System.ComponentModel.DataAnnotations;

public class GetItemDto
{
		[Key]
        public string ItemName { get; set; }
        public int ItemWeight { get; set; }
        public int Amount { get; set; }
}