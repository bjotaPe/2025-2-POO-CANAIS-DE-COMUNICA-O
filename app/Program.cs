// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Selecione o canal:");
        Console.WriteLine("1. WhatsApp");
        Console.WriteLine("2. Telegram");
        Console.WriteLine("3. Instagram");
        Console.WriteLine("4. Facebook");

        if (!int.TryParse(Console.ReadLine(), out int canal))
        {
            Console.WriteLine("Opção inválida!");
            return;
        }

        Console.WriteLine("Informe o destino (número ou usuário):");
        string destino = Console.ReadLine();


        Console.WriteLine("Tipo de mensagem:");
        Console.WriteLine("1. Texto");
        Console.WriteLine("2. Foto");
        Console.WriteLine("3. Vídeo");
        Console.WriteLine("4. Arquivo");

        if (!int.TryParse(Console.ReadLine(), out int tipoMensagem))
        {
            Console.WriteLine("Tipo inválido!");
            return;
        }

        MessageBase mensagem = tipoMensagem switch
        {
            1 => new TextMessage("Olá! Esta é uma mensagem de texto."),
            2 => new PhotoMessage("Envio de foto", "imagem.png", "png"),
            3 => new VideoMessage("Envio de vídeo", "video.mp4", "mp4", 40),
            4 => new FileMessage("Envio de arquivo", "documento.pdf", "pdf"),
            _ => null
        };

        if (mensagem == null)
        {
            Console.WriteLine("Erro ao criar mensagem.");
            return;
        }

        IChannel channel = canal switch
        {
            1 => new WhatsApp(),
            2 => new Telegram(),
            3 => new Instagram(),
            4 => new Facebook(),
            _ => null
        };

        if (channel == null)
        {
            Console.WriteLine("Canal inválido!");
            return;
        }

        channel.EnviarMensagem(destino, mensagem);
    }
}