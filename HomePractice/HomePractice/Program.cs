using System;

namespace HomePractice
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

//			FindSumOfDivisibles fd = new FindSumOfDivisibles ();
//			int sum = fd.FindSum (1000);
//			Console.WriteLine ("sum is-: {0}", sum);

//			Factors fact = new Factors ();
//			System.Collections.ArrayList li = fact.FindFactors (48);
//			Console.WriteLine ("values are -: {0}", li);

//			FindPrimeNumber f = new FindPrimeNumber ();
//			bool b = f.IsPrime (-2);
//			Console.WriteLine (" number is prime , and it is a -: {0}", b + " statement");

//			PrimeFactors pf = new PrimeFactors ();
//			System.Collections.ArrayList ll  = pf.FindPrimeFactors (18);
//			Console.WriteLine ("prime factors count is-: {0}", ll.Count);

//			factorial f = new factorial ();

            //fibonacci f = new fibonacci ();
            //int n = f.CalculateFibonacci (8);

//            Combination combs = new Combination("wxyz");
//            combs.Combine();

			string s = "Awdes''  S' h 'ar ma";
			FindQuotesInString f = new FindQuotesInString (s);

//			StringDups dups = new StringDups ();
//			dups.StringDuplicates ("geeksforgeeks");

//			SortStrings sort = new SortStrings ();
//			string[] arr = {"car", "arc", "name"};
//			sort.SortCollectionOfStrings(arr);

//			int[] arr = { 1, 2, 3, 3, 4 };
//			dups.removeDuplicates (arr);

//			FunnyString fs = new FunnyString ();
//
//			fs.ParseString (Console.ReadLine());

//			int[] A = new int[]{2,4,6};
//			int[] B = new int[]{5,7,7,8,8,10,11, 12, 13, 14, 15, 16, 16, 16, 16, 17, 18};
//
//			FindRange fr = new FindRange ();
//			int[] newArr = fr.Find (B, 16);

//			MergeTwoSorted m = new MergeTwoSorted ();
//			m.merge(A,B,3);

			//xome x = new xome ();
			//string s1 = x.Simplify ("dir1/dir2/../dir3/./dir4");
			//string s = x.Simplify ("a/b/../c/./d/.././e");
			//string s2 = x.Simplify ("../abc/./def/ab/../bc/");

//			TopCodeTemplate template = new TopCodeTemplate ();
//			int n = template.two (3);
//			int n1 =  template.last_bit(3);
//			int n2 = template.ones(3);
//			template.setBit (3);
//			int n3 = template.test (2, 3);
//			template.unsetBit (3);

//			string s = "This! is@ aw@#$esome";
//			ReverseWords rw = new ReverseWords ();
//			string ch = rw.ReverseWords1(s);

//			AllAnagramsInFile ana = new AllAnagramsInFile ();
//			string[] words = new string[] {"car","arc","and","dna","val","ram","mar","data" };
//			ana.FindAllAnagrams(words);

			//string s = " ";
			//string[] sArr = s.Split (' ');

			//ReverseWords rw = new ReverseWords ();
			//string ch = rw.Reverse1(s);

			//ReverseWordsInStrings rw = new ReverseWordsInStrings ();
			//string op = rw.ReverseSentence ("string item.");
		}

	}
}
