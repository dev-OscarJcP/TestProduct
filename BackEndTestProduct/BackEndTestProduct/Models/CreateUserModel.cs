namespace BackEndTestProduct.Models
{
    public class CreateUserModel
    {
        
        public int Nif { get; set; }
        public int Password { get; set; }
        public int IsAdmin { get; set; }
        public Boolean IsActive { get; set; }
    }
}
