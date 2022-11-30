Console.WriteLine("Введите день недели (от 1 до 7): ");
int day_of_week = Convert.ToInt32(Console.ReadLine());
if (day_of_week >0 && day_of_week < 6){
    Console.WriteLine("Рабочий день( ");
}
else if (day_of_week > 5 && day_of_week < 8){
    Console.WriteLine("Выходной!!!");
}
else {
    Console.WriteLine("Неверный день недели");
}