namespace Silk.NET.SDL;

public unsafe delegate void AudioStreamCallbackDelegate(
    void* arg0,
    AudioStreamHandle arg1,
    int arg2,
    int arg3
);
