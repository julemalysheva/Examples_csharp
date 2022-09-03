/*Задача со звездочкой: Пользователь вводит скобочные последовательности. 
В последовательности могут встретиться скобки вида: {}, (), [].
Правильная скобочная последовательность - символьная последовательность, составленная в алфавите,
 состоящем из символов, сгруппированных в упорядоченные пары.
Пример правильной скобочной последовательности: (), ()[]{}
Пример неправильной: (], ({)}
Написать программу, которая определяет правильная ли скобочная последовательность была введена*/

//Функция возвращает значение true, если закрытая скобка из строки 
//находит пару с ранее помещенной в стек открытой скобкой

bool FindPair(char charBracket1, char charBracket2)
{
    if (charBracket1 == '(' && charBracket2 == ')')
        return true;
    else if (charBracket1 == '{' && charBracket2 == '}')
        return true;
    else if (charBracket1 == '[' && charBracket2 == ']')
        return true;
    else
        return false;
}

bool BracketSequenceCorrect(string charBracket)
{
    Stack<char> checkStr = new Stack<char>();
    for (int i = 0; i < charBracket.Length; i++)
    {
        if (charBracket[i] == '{' || charBracket[i] == '('
                || charBracket[i] == '[')
            checkStr.Push(charBracket[i]);
        //если хотим исключить ввод вложенных пар скобок типа ([])
        //используем очистку стека,если там уже есть откр.скобка
        //если это условие не применять, будет работать вложенная проверка
        if (checkStr.Count > 1)
        {
            checkStr.Clear();
            return false;
        } //удалить для вложенной проверки пар скобок

        if (charBracket[i] == '}' || charBracket[i] == ')'
            || charBracket[i] == ']')
        {   //если закрыв.скобка, а в стеке еще нет откр.,он пуст - то false         
            if (checkStr.Count == 0)
            {
                return false;
            }
            //иначе изымаем верхний эл.стека и см.соответствие,т.е. ищем ранее добавл.откр.скобку
            //если не соотв. - то false
            else if (!FindPair(checkStr.Pop(), charBracket[i]))
            {
                return false;
            }
        }
    }
    //если после обхода строки в стеке что-то есть, значит не нашлась пара откр.скобке
    //данная проверка уместна, если по условию мы допускаем вложенность скобок или нет проверки на четность
    //в текущем варианте стек итак всегда будет пустой, можно обойтись return true;
    if (checkStr.Count == 0) return true;
    else return false;
}

bool CheckStringStandardBracket(string charBracket)
{
    string standardBracket = "(){}[]";
    foreach (char item in charBracket)
    {
        if (!standardBracket.Contains(item))
            return false;
    }
    return true;
}

Console.Write("Введите скобочные последовательности: ");
string sBrackets = Console.ReadLine();

if (CheckStringStandardBracket(sBrackets))
{
    //если длина строки - чётное число
    if (sBrackets.Length % 2 == 0) //тогда запускать проверку функцией
    {
        if (BracketSequenceCorrect(sBrackets))
            Console.WriteLine("Да");
        else
            Console.WriteLine("Нет");
    }
    else //если нечетное, то сразу понятно, что Нет
        Console.WriteLine("Нет");
}
else 
Console.WriteLine("Некорректные данные");