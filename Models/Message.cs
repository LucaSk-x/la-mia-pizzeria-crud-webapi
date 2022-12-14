using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_crud_webapi.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }

        [StringLength(500, ErrorMessage = "Il testo può essere massimo 500 caratteri")]
        public string Text { get; set; }

    }
}
