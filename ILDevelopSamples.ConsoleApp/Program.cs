using System;

Console.WriteLine(IntHelper.Square(2));

Console.WriteLine(ObjectHelper.SizeOf<int>());

var a = 4;
Console.WriteLine(GenericHelper.AreSame(ref a, ref a));

Console.Read();