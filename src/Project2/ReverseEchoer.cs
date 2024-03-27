namespace Project2;

public class ReverseEchoer
{
    public string Echo(string message)
    {
        return message.Reverse().ToString() ?? string.Empty;
    }
}