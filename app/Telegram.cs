public class Telegram
{
    public void EnviarMensagem(string contato, TextMessage message)
    {
        Console.WriteLine($"Enviando mensagem de texto para o número {numero}");
    }
    
    public void EnviarMensagem(string contato, FotoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de foto para o número {foto}");
    }

    public void EnviarMensagem(string contato, VideoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de video para o número {video}");
    }

    public void EnviarMensagem(string contato, FileMessage message)
    {
        Console.WriteLine($"Enviando mensagem de arquivo para o número {arquivo}");
    }
}