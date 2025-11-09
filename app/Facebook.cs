public class Facebook : IChannel
{
    public void EnviarMensagem(string usuario, MessageBase message)
    {
        Console.WriteLine($"[Facebook] Enviando para @{usuario}: {message.Message}");
    }
}