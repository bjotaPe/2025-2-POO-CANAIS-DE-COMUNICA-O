public class Instagram : IChannel
{
    public void EnviarMensagem(string usuario, MessageBase message)
    {
        Console.WriteLine($"[Instagram] Enviando para @{usuario}: {message.Message}");
    }
}