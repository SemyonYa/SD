using Core.Models;

namespace SD2.Models.View
{
    public class RegisterViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Client Create()
        {
            Client client = new Client();
            client.Name = this.FirstName + " " + this.LastName;
            client.Age = this.Age;
            client.IsActive = false;

            return client;
        }
    }
}
