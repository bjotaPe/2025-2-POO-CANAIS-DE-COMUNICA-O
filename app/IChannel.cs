public interface IChannel
{
    void EnviarMensagem(string destino, MessageBase message);
}