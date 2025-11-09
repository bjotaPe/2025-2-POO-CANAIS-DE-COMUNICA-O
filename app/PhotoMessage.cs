public abstract class MediaMessage : MessageBase
{
        protected MediaMessage(string message, string file, string format)
        : base(message)
    {
        File = file;
        Format = format;
    }

    public string File { get; }
    public string Format { get; }
}

public class PhotoMessage : MediaMessage
{
    public PhotoMessage(string message, string file, string format)
    : base(message, file, format) { }
}

public class FileMessage : MediaMessage
{
    public FileMessage(string message, string file, string format)
    : base(message, file, format) { }
}

public class VideoMessage : MediaMessage
{
    public int Duration { get; }

    public VideoMessage(string message, string file, string format, int duration)
    : base(message, file, format)
    {
        Duration = duration;
    }
}

