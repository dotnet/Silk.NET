namespace Silk.NET.SDL;

public unsafe delegate void AudioPostmixCallbackDelegate(
    void* arg0,
    AudioSpec* arg1,
    float* arg2,
    int arg3
);
