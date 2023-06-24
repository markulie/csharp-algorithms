namespace InvokeDelegate;

internal static class Program
{
    private delegate void MyDelegate(string text);

    private static void Main()
    {
        MyDelegate myDelegate = Sing;
        myDelegate += Dance;

        myDelegate.Invoke("I am ");
        myDelegate.Invoke("He is ");
        myDelegate.Invoke("She is ");
        myDelegate.Invoke("We are ");
        myDelegate.Invoke("They are ");
    }

    #region Methods

    private static void Sing(string text)
    {
        Console.WriteLine(text + "singing");
    }

    private static void Dance(string text)
    {
        Console.WriteLine(text + "dancing");
    }

    #endregion Methods
}