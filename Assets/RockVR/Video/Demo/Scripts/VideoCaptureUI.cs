using UnityEngine;
using System.Diagnostics;

namespace RockVR.Video.Demo
{
    public class VideoCaptureUI : MonoBehaviour
    {
        private bool isPlayVideo = false;
        private void Awake()
        {
            Application.runInBackground = true;
            isPlayVideo = false;
        }

        private void OnGUI()
        {
            if (VideoCaptureCtrl.instance.status == VideoCaptureCtrl.StatusType.NOT_START)
            {
                if (GUI.Button(new Rect(10, Screen.height - 60, 150, 50), "Iniciar grabación"))
                {
                    VideoCaptureCtrl.instance.StartCapture();
                }
            }
            else if (VideoCaptureCtrl.instance.status == VideoCaptureCtrl.StatusType.STARTED)
            {
                if (GUI.Button(new Rect(10, Screen.height - 60, 150, 50), "Parar grabación"))
                {
                    VideoCaptureCtrl.instance.StopCapture();
                }
                if (GUI.Button(new Rect(180, Screen.height - 60, 150, 50), "Pausar grabación"))
                {
                    VideoCaptureCtrl.instance.ToggleCapture();
                }
            }
            else if (VideoCaptureCtrl.instance.status == VideoCaptureCtrl.StatusType.PAUSED)
            {
                if (GUI.Button(new Rect(10, Screen.height - 60, 150, 50), "Parar grabación"))
                {
                    VideoCaptureCtrl.instance.StopCapture();
                }
                if (GUI.Button(new Rect(180, Screen.height - 60, 150, 50), "Continuar grabación"))
                {
                    VideoCaptureCtrl.instance.ToggleCapture();
                }
            }
            else if (VideoCaptureCtrl.instance.status == VideoCaptureCtrl.StatusType.STOPPED)
            {
                if (GUI.Button(new Rect(10, Screen.height - 60, 150, 50), "Procesando"))
                {
                    // Waiting processing end.
                }
            }
            else if (VideoCaptureCtrl.instance.status == VideoCaptureCtrl.StatusType.FINISH)
            {
                if (!isPlayVideo)
                {
                    if (GUI.Button(new Rect(10, Screen.height - 60, 150, 50), "Ver video"))
                    {
#if UNITY_5_6_OR_NEWER
                        // Set root folder.
                        isPlayVideo = true;
                        VideoPlayer.instance.SetRootFolder();
                        // Play capture video.
                        VideoPlayer.instance.PlayVideo();
                    }
                }
                else
                {
                    if (GUI.Button(new Rect(10, Screen.height - 60, 150, 50), "Siguiente video"))
                    {
                        // Turn to next video.
                        VideoPlayer.instance.NextVideo();
                        // Play capture video.
                        VideoPlayer.instance.PlayVideo();
#else
                        // Open video save directory.
                        Process.Start(PathConfig.saveFolder);
#endif
                    }
                }
            }
        }
    }
}