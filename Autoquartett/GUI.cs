using System;

public class GUI
{
	public GUI()
	{
	}
	public const char borderCharacter = '*';
	private int lastWindowSizeX;
	private int lastWindowSizeY;

	public void WriteRectangle(int xVal, int yVal) 
    {
        int posX = Console.CursorLeft;
        int posY = Console.CursorTop;

        writeXAxis(xVal);

        Console.CursorLeft = posX;
        Console.CursorTop = posY + yVal - 1;

        writeXAxis(xVal);

        Console.CursorLeft = posX;
        Console.CursorTop = posY;

        writeYAxis(yVal);

        Console.CursorLeft = posX + xVal - 1;
        Console.CursorTop = posY;

        writeYAxis(yVal);
    }

    private void writeYAxis(int yVal)
    {
        for (int i = 0; i < yVal; i++)
        { 
            Console.Write(borderCharacter);
            Console.CursorTop = Console.CursorTop + 1;
            Console.CursorLeft = Console.CursorLeft - 1;
        }
    }

    private void writeXAxis(int xVal)
    {
        for (int i = 0; i < xVal; i++)
        {
            Console.Write(borderCharacter);
        }
    }

	public void ShowCard(object car)
    {

    }

	public Boolean ReloadWindow()
    {
		return true;
    }

	public void GetTitleScreen()
    {

    }

	public void GetEndScreen()
    {

    }

	public void WriteWindowBorder()
    {
        WriteRectangle(Console.WindowWidth, Console.WindowHeight);
    }
}
