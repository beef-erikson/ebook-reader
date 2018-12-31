using System;
using Gtk;

public class Heyo
{
    public static void Main()
    {
        Application.Init();

        // Creates window
        Window myWin = new Window("This is a window!");
        myWin.Resize(600,600);

        // Creates a label and puts some text in it
        Label myLable = new Label();
        myLable.Text = "Hi. Hope you're day / evening is well, fellow devs o7\nHappy New Year!!\n\nMore interesting things to come here after sleep!";

        // Adds label to form
        myWin.Add(myLable);

        // Show everything
        myWin.ShowAll();

        Application.Run();
    }
}