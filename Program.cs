using Design_Patterns.Structural.Composite;

namespace Design_Patterns;

internal class Program
{
    private static void Main(string[] args)
    {
        var package = new BoxItem();

        var box1 = new BoxItem();
        box1.Add(new KeyboardItem(100));

        var box2 = new BoxItem();

        var box3 = new BoxItem();
        box3.Add(new VgaItem(200));

        var box4 = new BoxItem();
        box4.Add(new CpuItem(300));

        box2.Add(box3);
        box2.Add(box4);

        package.Add(box1);
        package.Add(box2);

        Console.WriteLine(package.GetTotalPrince());

        MainComposite(args);

    }

    private static void MainComposite(string[] args)
    {
        var package = new BoxItem();

        var box1 = new BoxItem();
        box1.Add(new KeyboardItem(100));

        var box2 = new BoxItem();

        var box3 = new BoxItem();
        box3.Add(new VgaItem(200));

        var box4 = new BoxItem();
        box4.Add(new CpuItem(300));

        box2.Add(box3);
        box2.Add(box4);

        package.Add(box1);
        package.Add(box2);

        Console.WriteLine(package.GetTotalPrince());
    }
}