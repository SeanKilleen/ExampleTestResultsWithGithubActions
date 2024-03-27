namespace Project2;

public class ReverseEchoer
{
    public string Echo(string message)
    {
        var charArray = message.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}