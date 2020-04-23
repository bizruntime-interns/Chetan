using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static void Main(string[] args)
        {
            Video video = new Video { Title = "Fifa" }; // creating a object for Video class to get Title of the video.

            VideoEncoder videoEncoder = new VideoEncoder(); // Publisher.... creating a object for VideoEncoder class to encode the video.

            MailService mailService = new MailService();    // Subscriber.... creating a object for MailService class to send a video through mail.

            MessageService messageService = new MessageService();   // Subscriber.... creating a object for MailService class to send a video through message.

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;    // Subscribing a mailService from Event VideoEncoder.

            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; // Subscribing a messageService from Event VideoEncoder.

            videoEncoder.Encode(video);

        }
    }
}
