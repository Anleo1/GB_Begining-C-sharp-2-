Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0){
    number /= -1;
}
string temp = Convert.ToString(number);
if (temp.Length < 3){
    Console.WriteLine("Третьей цифры нет");
}
else {
    Console.WriteLine($"Третья цифра числа = {temp[2]}");
}