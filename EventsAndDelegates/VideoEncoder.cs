using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        /*
        1- define a delegate 
        2- define an event based on that delegate 
        3- raise the event          
         */
        
        // 5 min to brainstorm - how i can print the Video object 

        public delegate void VideoEncoderHandler(object source, VideoEventArgs args); // step 1

        public event VideoEncoderHandler VideoEncoded; // step 2
        public void Encode(Video video)
        {
            // ... Encoding
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);


            OnVideoEncoded(video);

        }

        protected virtual void OnVideoEncoded(Video video) // step 3
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs(){ Video = video});
            }
        }
         
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
