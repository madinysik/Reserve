namespace Reserve.Models
{
    public class Animal: IDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Weight Weight { get; set; }
        public AnimalType Type { get; set; }

        public string GetDetails()
        {
            return $"ID: {Id}\r\n" +
                   $"Имя: {Name}\r\n" +
                   $"Возраст: {Age} лет\r\n" +
                   $"Вес: {Weight.Value} {Weight.Unit}\r\n" +
                   $"Категория: {Type.Category}\r\n" +
                   $"Питание: {Type.Diet}";
        }
    }
}