namespace Reserve.Models
{
    public class Feeding: IDetails
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public AnimalRef Animal { get; set; }
        public Food Food { get; set; }

        public string GetDetails()
        {
            return $"ID кормления: {Id}\r\n" +
                   $"Дата: {Date:yyyy-MM-dd}\r\n" +
                   $"Животное: {Animal.AnimalName}\r\n" +
                   $"Корм: {Food.Name}\r\n" +
                   $"Количество: {Food.Amount} {Food.Unit}";
        }
    }
}
