using TestApi.Model;

namespace TestApi.Dto
{
    public class CustomerDto
    {
        public CustomerDto()
        {

        }
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
    }
}
