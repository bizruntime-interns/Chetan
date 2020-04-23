using System;

namespace EventsAndDelegates
{
    class MessageService
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void OnVideoEncoded(object source, VideoArgs args)
        {
            log.Info("Video has been sent through message..."+args.Video.Title);
        }
    }
}
