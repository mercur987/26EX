using System;

public class Test
{
    public static void Main()
    {
        Box box = new Box();
        Console.WriteLine("体積:" + box.GetVolume());
        Console.WriteLine("表面積:" + box.GetSurface());
        Console.WriteLine("縦横奥行の値を入力してください");
        try
        {
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            float depth = float.Parse(Console.ReadLine());
            Box box1 = new Box(width, height, depth);
            Console.WriteLine("体積:" + box1.GetVolume());
            Console.WriteLine("表面積:" + box1.GetSurface());
        }
        catch (Exception)
        {
            Console.WriteLine("入力エラー");
        }
    }
    class Box
    {
        private float width;
        private float height;
        private float depth;
        public Box(float w, float h, float d)
        {
            this.width = w;
            this.height = h;
            this.depth = d;
        }
        public Box(float w = 1)
        {
            this.width = w;
            this.height = w;
            this.depth = w;
        }
        public float GetVolume()
        {
            return width * height * depth;
        }
        public float GetSurface()
        {
            return (width * height + height * depth + depth * width) * 2;
        }
    }
}