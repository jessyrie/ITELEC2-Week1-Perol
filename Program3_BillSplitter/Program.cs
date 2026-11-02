int totalBill = 250;
int friends = 4;

int wholeShare = totalBill / friends;
int leftover = totalBill % friends;
double exactShare = (double)totalBill / friends;

Console.WriteLine($"Total Bill: PHP {totalBill}");
Console.WriteLine($"Number of Friends: {friends}");
Console.WriteLine($"Each pays (whole): PHP {wholeShare}");
Console.WriteLine($"Leftover: PHP {leftover}");
Console.WriteLine($"Each pays (exact): PHP {exactShare:F2}");