int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int first_nmb = 15;
int second_nmb = 21;
int third_nmb = 39;
int fourth_nmb = 12;
int fifth_nmb = 23;
int sixth_nmb = 33;
int seventh_nmb = 13;
int eighth_nmb = 23;
int ninth_nmb = 33;

//

int max1 = Max(first_nmb, second_nmb, third_nmb);
int max2 = Max(fourth_nmb, fifth_nmb, sixth_nmb);
int max3 = Max(seventh_nmb, eighth_nmb, ninth_nmb);

int max = Max(max1, max2, max3);

// OR

// int max = Max(Max(first_nmb, second_nmb, third_nmb),
//           Max(fourth_nmb, fifth_nmb, sixth_nmb),
//           Max(seventh_nmb, eighth_nmb, ninth_nmb));

// CHAOTIC APPROACH

// int max = first_nmb;
// if (second_nmb > max) max = second_nmb;
// if (third_nmb > max) max = third_nmb;
// if (fourth_nmb > max) max = fourth_nmb;
// if (fifth_nmb > max) max = fifth_nmb;
// if (sixth_nmb > max) max = sixth_nmb;
// if (seventh_nmb > max) max = seventh_nmb;
// if (eighth_nmb > max) max = eighth_nmb;
// if (ninth_nmb > max) max = ninth_nmb;

Console.WriteLine(max);