using Core.Models;

namespace SD2.Models.View
{
    public class EditClientViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }

        public EditClientViewModel(Client client)
        {
            Id = client.Id;
            FirstName = client.Name.Split(' ')[0];
            LastName = client.Name.Split(' ')[1];
            Age = client.Age;
            IsActive = client.IsActive;
        }

        public void Fill(Client client)
        {
            client.Name = this.FirstName + " " + this.LastName;
            client.Age = this.Age;
            client.IsActive = this.IsActive;
        }
    }
}
