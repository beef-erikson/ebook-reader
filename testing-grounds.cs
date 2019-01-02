using System;
using Gtk;
using Gdk;

public class Heyo
{
    // The tray Icon
    private static StatusIcon trayIcon;

    // The window
    private static Gtk.Window window;

    public static void Main()
    {
        // Initialize GTK#
        Application.Init();

        // Creates window
        window = new Gtk.Window("This is a window!");

        // Attach to the Delete Event when the window has been closed.
        window.DeleteEvent += delegate { Application.Quit(); };

        // Create the icon
        trayIcon = new StatusIcon(new Pixbuf("someIcon.png"));
        trayIcon.Visible = true;

        // Show/Hide the window when the TrayIcon has been clicked.
        trayIcon.Activate += delegate { window.Visible = !window.Visible; };
        // Show a pop up menu when the icon has been right clicked.
        trayIcon.PopupMenu += OnTrayIconPopup;

        // A Tooltip for the Icon
        trayIcon.Tooltip = "Yep. This is a tooltip.";

        // Show main window and start the app
        window.ShowAll();
        Application.Run();
    }

    // Create the popup menu, on right click
    static void OnTrayIconPopup(object o, EventArgs args)
    {
        Menu popupMenu = new Menu();
        ImageMenuItem menuItemQuit = new ImageMenuItem("Quit");
        Gtk.Image appimg = new Gtk.Image(Stock.Quit, IconSize.Menu);
        menuItemQuit.Image = appimg;
        popupMenu.Add(menuItemQuit);

        // Quit the application when quit has been clicked
        menuItemQuit.Activated += delegate { Application.Quit(); };
        popupMenu.ShowAll();
        popupMenu.Popup();
    }
}