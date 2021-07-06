using System;
using System.IO;
using UnityEngine;
using YoutubePlayer;

namespace YoutubePlayer
{
    public class DownloadYoutubeVideo : MonoBehaviour
    {
        public YoutubePlayer youtubePlayer;
        public Environment.SpecialFolder destination;

        public async void Download()
        {
            Debug.Log("Downloading, please wait...");

            var videoDownloadTask = youtubePlayer.DownloadVideoAsync(Environment.GetFolderPath(destination));
            var filePath = await videoDownloadTask;

            Debug.Log($"Video saved to {Path.GetFullPath(filePath)}");
        }

        public async void DownloadAudio()
        {
            Debug.Log("Downloading, please wait...");

            var videoDownloadTask = youtubePlayer.DownloadAudioAsync(Environment.GetFolderPath(destination));
            var filePath = await videoDownloadTask;

            Debug.Log($"Video saved to {Path.GetFullPath(filePath)}");
        }
    }
}
