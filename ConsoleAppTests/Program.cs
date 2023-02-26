
// See https://aka.ms/new-console-template for more information



using ConsoleAppTests;
using DesignPatterns.TemplateMethodAndStrategy.Strategy;
using DesignPatterns.TemplateMethodAndStrategy.Strategy.Sorter;


// * Start Strategy for Fto
//var ftoStrategy = new FtoStrategy();
//var applicationRunner = new ApplicationRunner(ftoStrategy);
//applicationRunner.Run();


//// * Start strategy for Bubble Sort
//var intSortHandler = new IntSortHandler();
//var bubbleSorter = new BubbleSorter(intSortHandler);
//var array = new int[] { 250, 333, 15, 5, 1055, 856 };
//bubbleSorter.Sort(array);
//foreach (var item in array)
//{
//    Console.WriteLine(item);
//}

//// * Start strategy for Quick Bubble Sort
//var intSortHandler2 = new IntSortHandler(); 
//var quikBubbleSorter = new QuikBubbleSorter(intSortHandler2); 
//var array2 = new int[] { 250, 333, 15, 5, 1055, 856 };
//quikBubbleSorter.Sort(array2);
//foreach (var item in array2)
//{
//    Console.WriteLine(item);
//}


//new RunFtoRaw();

new RunBubbleSorter().Execute();
