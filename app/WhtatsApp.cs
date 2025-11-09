public class WhatsApp : IChannel
{
    public void EnviarMensagem(string numero, MessageBase message)
    {
        Console.WriteLine($"[WhatsApp] Enviando para {numero}: {message.Message}");
    }
}



