Console.WriteLine("Введите трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100 != 0 && number > -1000 && number < 1000) {
    if (number < 0){
        number /= -1;
    }
    number /=10;
    number %=10;
    Console.WriteLine($"Вторая цифра числа = {number}");
}
else {
    Console.WriteLine("Введено неверное число");
}