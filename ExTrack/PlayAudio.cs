using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ExTrack
{
    class PlayAudio
    {
        //obsolet, da medien inkludiert werden
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand,
            StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        public PlayAudio(string fileName)
        {
            string FORMAT = "open \"" + fileName + "\" type MPEGVideo alias MediaFile";
            string command = String.Format(FORMAT, fileName);
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        public void Play()
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
    }
}
