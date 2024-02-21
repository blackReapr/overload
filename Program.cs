#region Task 1

static int SumOfThreeNumbers(int a, int b, int c)
{
    int sum = 0;
    if (a > 10 && a < 100)
    {
        sum += a;
    }
    if (b > 10 && b < 100)
    {
        sum += b;
    }
    if (c > 10 && c < 100)
    {
        sum += c;
    }
    return sum
}

#endregion

#region Task 2

static string NumberToMonth(int a)
{
    string result = "";
    switch (a)
    {
        case 3:
        case 4:
        case 5:
            result = "yaz";
            break;
        case 6:
        case 7:
        case 8:
            result = "yay";
            break;
        case 9:
        case 10:
        case 11:
            result = "qis";
            break;

        case 12:
        case 2:
        case 1:
            result = "qis";
            break
    }
    return result;
}

#endregion

#region Task 3

static int Multi(int number)
{
    int multi = 1;
    multi *= number % 10;
    number /= 10;
    multi *= number % 10;
    number /= 10;
    multi *= number;
    return multi;
}

#endregion

#region Task 4

static int Discount(int a, int b, int c)
{
    int sum = a + b + c;
    if (a > b)
    {
        if (b < c)
        {
            sum -= b;
        }
        else
        {
            sum -= c;
        }
    }
    else
    {
        if (a < c)
        {
            sum -= a;
        }
        else
        {
            sum -= c;
        }
    }
    return sum;
}

#endregion