﻿using SparseVector;

//int[] ints = new int[] { 1, 0, 0, 0, 0, 0, 0, 3, 0, 0, 5, 0, 0, 4, 0 };
//int[] _ints = new int[] { 0, 0, 0, 0, 1, 0, 0, 6, 0, 0, 4, 0, 0, 5, 0 };
//var vector = new SparceVector(ints);
//var _vector = new SparceVector(_ints);
//vector.PrintVector();
//_vector.PrintVector();
//Console.WriteLine("--------------");

//var sum = SparceVector.Addition(vector, _vector);
//sum.PrintVector();
//var minus = SparceVector.Subtraction(vector, _vector);
//Console.WriteLine("--------------");
//minus.PrintVector();
//var scalarProduct = SparceVector.ScalarProduct(vector, _vector);
//Console.WriteLine(scalarProduct);

int[] arrayOfInts = new int[] { 0, 0, 1, 0, 0, 5, 0, 0 };
var vector = new SparceVector(arrayOfInts);
vector[1] = 2;
vector[2] = 0;
vector[3] = 6;
vector[5] = 0;
vector[6] = 5;
int[] changedArray = new int[] { 0, 2, 0, 6, 0, 0, 5, 0 };
vector.PrintVector();