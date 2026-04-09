namespace Reserve.Models
{
    public class Employee: IDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public Phone Phone { get; set; }
        public Address Address { get; set; }

        public string GetDetails()
        {
            return $"ID: {Id}\r\n" +
                   $"Имя: {Name}\r\n" +
                   $"Должность: {Position}\r\n" +
                   $"Мобильный: {Phone.Mobile}\r\n" +
                   $"Адрес: {Address.City}, ул. {Address.Street}, д. {Address.House}";
        }
    }
}
