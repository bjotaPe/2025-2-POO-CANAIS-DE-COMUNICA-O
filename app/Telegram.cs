public class Telegram : IChannel
{
    public void EnviarMensagem(string contato, MessageBase message)
    {
        Console.WriteLine($"[Telegram] Enviando para {contato}: {message.Message}");
    }
}