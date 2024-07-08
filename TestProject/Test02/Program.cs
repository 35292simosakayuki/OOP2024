using System.Collections.Generic;
using System;


        //問題１　合計値を表示

//　　　　出力結果【618】

        private static void Exercise01(List<int> numbers) {

    var sum = numbers.Sum();

    Console.WriteLine(sum);


}

//問題２　偶数の最大値を表示

//　　　　出力結果【94】

private static void Exercise02(List<int> numbers) {

    var max = numbers.Where(n => n % 2 == 0)

                     .Max();

    Console.WriteLine(max);

}

//問題３　奇数のみを降順に並べて表示（遅延実行とする）

//　　　　出力結果【91 87 53 35 31 17】

private static void Exercise03(List<int> numbers) {

    var selected = numbers.Where(n => n % 2 == 1).OrderBy(n => n.ToString());

    foreach (int n in selected)

        Console.WriteLine(n);

}


//問題４　10以上50以下の数字のみを表示（即時実行でも可とする）

//　　　　出力結果【12 14 20 40 35 31 17 48】

private static void Exercise04(List<int> numbers) {

    var result = numbers.Where(x => x >= 10 && x <= 50);

    foreach (var x in result) {

        Console.Write(x);

        Console.Write(" ");
    }

}

//問題５　平均年齢を表示

//　　　　出力結果【30.2才】

private static void Exercise05(List<Person> persons) {

    var average = persons.Average(x => x.Age);

    Console.WriteLine(average + "才");

}

//問題６　身長170cm以上の体重平均を表示

//　　　　出力結果【72.25kg】

private static void Exercise06(List<Person> persons) {

    var average = persons.Where(x => x.Height >= 170).Average(x => x.Weight);

    Console.WriteLine(average + "kg");


}

//問題７　体重70Kg以下の人を全て表示（名前と体重）

//　　　　出力結果【山田隆司 68kg

//　　　　　　　　　沖田宏一 59kg

//　　　　　　　　　片山伸介 65kg】

private static void Exercise07(List<Person> persons) {

    var result = persons.Where(x => x.Weight <= 70);

    foreach (var item in result) {

        Console.WriteLine("{0} {1}kg", item.Name, item.Weight);

    }


}

//問題８　名前に「山」の漢字が含まれている人全て表示

//　　　　出力結果【山田隆司

//　　　　　　　　　片山伸介】

private static void Exercise08(List<Person> persons) {

    var result = persons.Where(x => x.Name.Contains("山"));

    foreach (var item in result) {

        Console.WriteLine(item.Name);

    }


}

    }

}

 