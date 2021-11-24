int[] array = {1, 4, 66, 44, 55, 4, 5};
int n = array.Length; //array.Length знает сколько элементов в массиве
int find = 4; // пользователь вводит число, например 4
int index = 0;
while (index < n) // пока индекс меньше n
{
    if (array[index] == find)
    {
    Console.WriteLine(index);
    break; // прерывает цикл, что бы не искать все элемены из массива с одинакомым значением
    }
    index++;

}