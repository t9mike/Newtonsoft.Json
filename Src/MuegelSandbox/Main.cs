using System;
using Newtonsoft.Json;

namespace MuegelSandbox
{
	public enum TestEnum
	{
		Value1,
		Value2
	}

	public class TestClass
	{
		public TestEnum Enum = TestEnum.Value1;
		public DateTime Date = DateTime.Now;
		public Version Version = new Version(1, 2, 3);
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			var obj = new TestClass();
			Console.WriteLine(JsonConvert.SerializeObject(obj));
		}
	}
}
