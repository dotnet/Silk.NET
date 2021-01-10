// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.ANDROID
{
    [NativeName("Name", "GLenum")]
    public enum ANDROID : int
    {
        [NativeName("Name", "EGL_NATIVE_BUFFER_USAGE_ANDROID")]
        NativeBufferUsageAndroid = 0x3143,
        [NativeName("Name", "EGL_NATIVE_BUFFER_USAGE_PROTECTED_BIT_ANDROID")]
        NativeBufferUsageProtectedBitAndroid = 0x1,
        [NativeName("Name", "EGL_NATIVE_BUFFER_USAGE_RENDERBUFFER_BIT_ANDROID")]
        NativeBufferUsageRenderbufferBitAndroid = 0x2,
        [NativeName("Name", "EGL_NATIVE_BUFFER_USAGE_TEXTURE_BIT_ANDROID")]
        NativeBufferUsageTextureBitAndroid = 0x4,
        [NativeName("Name", "EGL_FRAMEBUFFER_TARGET_ANDROID")]
        FramebufferTargetAndroid = 0x3147,
        [NativeName("Name", "EGL_FRONT_BUFFER_AUTO_REFRESH_ANDROID")]
        FrontBufferAutoRefreshAndroid = 0x314C,
        [NativeName("Name", "EGL_TIMESTAMP_PENDING_ANDROID")]
        TimestampPendingAndroid = unchecked((int)0xFFFFFFFFFFFFFFFE),
        [NativeName("Name", "EGL_TIMESTAMP_INVALID_ANDROID")]
        TimestampInvalidAndroid = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "EGL_TIMESTAMPS_ANDROID")]
        TimestampsAndroid = 0x3430,
        [NativeName("Name", "EGL_COMPOSITE_DEADLINE_ANDROID")]
        CompositeDeadlineAndroid = 0x3431,
        [NativeName("Name", "EGL_COMPOSITE_INTERVAL_ANDROID")]
        CompositeIntervalAndroid = 0x3432,
        [NativeName("Name", "EGL_COMPOSITE_TO_PRESENT_LATENCY_ANDROID")]
        CompositeToPresentLatencyAndroid = 0x3433,
        [NativeName("Name", "EGL_REQUESTED_PRESENT_TIME_ANDROID")]
        RequestedPresentTimeAndroid = 0x3434,
        [NativeName("Name", "EGL_RENDERING_COMPLETE_TIME_ANDROID")]
        RenderingCompleteTimeAndroid = 0x3435,
        [NativeName("Name", "EGL_COMPOSITION_LATCH_TIME_ANDROID")]
        CompositionLatchTimeAndroid = 0x3436,
        [NativeName("Name", "EGL_FIRST_COMPOSITION_START_TIME_ANDROID")]
        FirstCompositionStartTimeAndroid = 0x3437,
        [NativeName("Name", "EGL_LAST_COMPOSITION_START_TIME_ANDROID")]
        LastCompositionStartTimeAndroid = 0x3438,
        [NativeName("Name", "EGL_FIRST_COMPOSITION_GPU_FINISHED_TIME_ANDROID")]
        FirstCompositionGpuFinishedTimeAndroid = 0x3439,
        [NativeName("Name", "EGL_DISPLAY_PRESENT_TIME_ANDROID")]
        DisplayPresentTimeAndroid = 0x343A,
        [NativeName("Name", "EGL_DEQUEUE_READY_TIME_ANDROID")]
        DequeueReadyTimeAndroid = 0x343B,
        [NativeName("Name", "EGL_READS_DONE_TIME_ANDROID")]
        ReadsDoneTimeAndroid = 0x343C,
        [NativeName("Name", "EGL_NATIVE_BUFFER_ANDROID")]
        NativeBufferAndroid = 0x3140,
        [NativeName("Name", "EGL_SYNC_NATIVE_FENCE_ANDROID")]
        SyncNativeFenceAndroid = 0x3144,
        [NativeName("Name", "EGL_SYNC_NATIVE_FENCE_FD_ANDROID")]
        SyncNativeFenceFDAndroid = 0x3145,
        [NativeName("Name", "EGL_SYNC_NATIVE_FENCE_SIGNALED_ANDROID")]
        SyncNativeFenceSignaledAndroid = 0x3146,
        [NativeName("Name", "EGL_NO_NATIVE_FENCE_FD_ANDROID")]
        NoNativeFenceFDAndroid = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "EGL_RECORDABLE_ANDROID")]
        RecordableAndroid = 0x3142,
    }
}
