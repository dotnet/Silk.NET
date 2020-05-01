// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.ANDROID
{
    public enum ANDROID
    {
        NativeBufferUsageAndroid = 0x3143,
        NativeBufferUsageProtectedBitAndroid = 0x1,
        NativeBufferUsageRenderbufferBitAndroid = 0x2,
        NativeBufferUsageTextureBitAndroid = 0x4,
        FramebufferTargetAndroid = 0x3147,
        FrontBufferAutoRefreshAndroid = 0x314C,
        TimestampPendingAndroid = unchecked((int)0xFFFFFFFFFFFFFFFE),
        TimestampInvalidAndroid = unchecked((int)0xFFFFFFFFFFFFFFFF),
        TimestampsAndroid = 0x3430,
        CompositeDeadlineAndroid = 0x3431,
        CompositeIntervalAndroid = 0x3432,
        CompositeToPresentLatencyAndroid = 0x3433,
        RequestedPresentTimeAndroid = 0x3434,
        RenderingCompleteTimeAndroid = 0x3435,
        CompositionLatchTimeAndroid = 0x3436,
        FirstCompositionStartTimeAndroid = 0x3437,
        LastCompositionStartTimeAndroid = 0x3438,
        FirstCompositionGpuFinishedTimeAndroid = 0x3439,
        DisplayPresentTimeAndroid = 0x343A,
        DequeueReadyTimeAndroid = 0x343B,
        ReadsDoneTimeAndroid = 0x343C,
        NativeBufferAndroid = 0x3140,
        SyncNativeFenceAndroid = 0x3144,
        SyncNativeFenceFDAndroid = 0x3145,
        SyncNativeFenceSignaledAndroid = 0x3146,
        NoNativeFenceFDAndroid = unchecked((int)0xFFFFFFFFFFFFFFFF),
        RecordableAndroid = 0x3142,
    }
}
