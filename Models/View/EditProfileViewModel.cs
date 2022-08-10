using Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SD2.Models.View
{
    public class EditProfileViewModel
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public EditProfileViewModel(Client client)
        {
            Id = client.Id;
            FirstName = client.Name.Split(' ')[0];
            LastName = client.Name.Split(' ')[1];
        }

        public void Fill(Client client)
        {
            client.Name = this.FirstName + " " + this.LastName;
        }
    }
}
