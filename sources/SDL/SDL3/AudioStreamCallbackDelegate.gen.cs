// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.SDL;

public unsafe delegate void AudioStreamCallbackDelegate(
    void* arg0,
    AudioStreamHandle arg1,
    int arg2,
    int arg3
);
