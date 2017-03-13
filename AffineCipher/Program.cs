using System;

namespace AffineCipher
{
	class MainClass
	{
		public static void Encryption(int a, int a1, string text)
		{
			char[] array = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t',
				'u','v','w','x','y','z'};
			int i;
			char b;
			for (i = 0; i < text.Length; i++)
			{
				b = text[i];
				int d = ((b - 'a')*a + a1) % 26;
				Console.Write(array[d]);

			}
			Console.WriteLine();
		}
		public static void Decryption(int a,int a2, string text)
		{
			char[] array = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t',
				'u','v','w','x','y','z'};
			int i,j,a1=0;
			char b;
			for (j = 0; j < 26; j++) {
				if ((j * a) % 26 == 1) {
					a1 = j;
					Console.WriteLine("Inverse of a is: {0}", a1);
					break;
				}
			}
			for (i = 0; i < text.Length; i++)
			{
				b = text[i];
				int d = (b - 'a'-a2);
				if (d < 0) d = d + 26;
				Console.Write(array[(a1*d) % 26]);
			}
			Console.WriteLine();
		}
		public static void Inverse(int a) {
			int j, a1 = 0;
			for (j = 0; j < 26; j++)
			{
				if ((j * a) % 26 == 1)
				{
					a1 = j;
					Console.WriteLine("Inverse of a is: {0}", a1);
					break;
				}
			}
		
		}
		public static void Main(string[] args)
		{
			string y = "y";
			while (y == "y") { 
			Console.WriteLine("1-Encyption, 2-Decryption,3-Inverse");
				int choose = Int32.Parse(Console.ReadLine());
				switch (choose)
				{
					case 1:
						Console.WriteLine("Input string to encrypt as a affine cipher method");
						string arr = Console.ReadLine();
						Console.WriteLine("Input a value to encryption");
						int k1 = Int32.Parse(Console.ReadLine());
						Console.WriteLine("Input b value to encryption");
						int k2 = Int32.Parse(Console.ReadLine());
						Encryption(k1, k2, arr);
						break;
					case 2:
						Console.WriteLine("Input string to decrypt as a a affine cipher method");
						string arr1 = Console.ReadLine();
						Console.WriteLine("Input a value to decryption");
						int k3 = Int32.Parse(Console.ReadLine());
						Console.WriteLine("Input b value to decryption");
						int k4 = Int32.Parse(Console.ReadLine());
						Decryption(k3, k4, arr1);
						break;
					case 3:
						Console.WriteLine("Input number ");
						int num = Int32.Parse(Console.ReadLine());
						Inverse(num);
						break;


				}
				Console.WriteLine("Do you want to continue? y-yes, n-no");
				y = Console.ReadLine();

			}



		}
	

	
}




		
}
