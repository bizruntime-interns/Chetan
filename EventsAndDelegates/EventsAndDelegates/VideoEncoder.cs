using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{

    class VideoEncoder
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //public delegate void VideoEventHandler(object source, EventArgs args); // creating a delegate.

        //public event VideoEventHandler VideoEncoded; // Defining a Event based on delegate. 
        public event EventHandler<VideoArgs> VideoEncoded;

        public void Encode(Video video)
        {
            log.Info("Encoding video......");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        // Raising the Event for Subscriber class (MessageService and MailService).
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoArgs() { Video = video });
        }
    }
}
