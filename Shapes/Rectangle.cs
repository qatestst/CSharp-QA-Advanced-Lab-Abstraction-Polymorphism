﻿using Shapes;
using System;

public class Rectangle : IDrawable
{
    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public int width { get; set; }
    public int height { get; set; }

    public void Draw()
    {
        DrawLine(this.width, '*', '*');
        for (int i =1; i < this.height -1; ++i) 
        {
            DrawLine(this.width, '*', ' ');
        }
        DrawLine(this.width, '*', '*');
    }

    private void DrawLine(int width, char end, char mid)
    {
        Console.Write(end);
        for ( int i = 1; i< width -1;++i ) 
        {
            Console.Write(mid);
        }
        Console.WriteLine(end);
    }
}