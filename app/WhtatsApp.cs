public class WhatsApp
{
    public void EnviarMensagem(string numero, TextMessage message)
    {
        Console.WriteLine($"Enviando mensagem de texto para o número {numero}");
    }
    
    public void EnviarMensagem(string numero, FotoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de foto para o número {foto}");
    }

    public void EnviarMensagem(string numero, VideoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de video para o número {video}");
    }

    public void EnviarMensagem(string numero, FileMessage message)
    {
        Console.WriteLine($"Enviando mensagem de arquivo para o número {arquivo}");
    }
}



