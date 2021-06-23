namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video() { Title = "Title" };
            VideoEncoder videoEncoder = new VideoEncoder(); // publisher

            MailService mailService = new MailService(); // subscriber object
            TextMessageService textMessageService = new TextMessageService(); // subscriber object

            videoEncoder.VideoEncoded += mailService.OnVideoEncodedRunThis; // subscription
            videoEncoder.VideoEncoded += textMessageService.OnVideoEncodedRunThis; // subscription

            videoEncoder.Encode(video);

        }
    }
}
