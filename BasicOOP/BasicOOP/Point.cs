﻿using System;

namespace BasicOOP
{
	public class Point
	{
		public int x;
		public int y;
		public char sym;

		public void Draw()
		{
			Console.SetCursorPosition(x, y);
			Console.WriteLine(sym);
		}
	}
}