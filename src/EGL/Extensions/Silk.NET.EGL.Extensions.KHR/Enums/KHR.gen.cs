// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.KHR
{
    [NativeName("Name", "GLenum")]
    public enum KHR : int
    {
        [NativeName("Name", "EGL_CL_EVENT_HANDLE_KHR")]
        CLEventHandleKhr = 0x309C,
        [NativeName("Name", "EGL_SYNC_CL_EVENT_KHR")]
        SyncCLEventKhr = 0x30FE,
        [NativeName("Name", "EGL_SYNC_CL_EVENT_COMPLETE_KHR")]
        SyncCLEventCompleteKhr = 0x30FF,
        [NativeName("Name", "EGL_CONFORMANT_KHR")]
        ConformantKhr = 0x3042,
        [NativeName("Name", "EGL_VG_COLORSPACE_LINEAR_BIT_KHR")]
        VGColorspaceLinearBitKhr = 0x20,
        [NativeName("Name", "EGL_VG_ALPHA_FORMAT_PRE_BIT_KHR")]
        VGAlphaFormatPreBitKhr = 0x40,
        [NativeName("Name", "EGL_CONTEXT_RELEASE_BEHAVIOR_NONE_KHR")]
        ContextReleaseBehaviorNoneKhr = 0x0,
        [NativeName("Name", "EGL_CONTEXT_RELEASE_BEHAVIOR_KHR")]
        ContextReleaseBehaviorKhr = 0x2097,
        [NativeName("Name", "EGL_CONTEXT_RELEASE_BEHAVIOR_FLUSH_KHR")]
        ContextReleaseBehaviorFlushKhr = 0x2098,
        [NativeName("Name", "EGL_CONTEXT_MAJOR_VERSION_KHR")]
        ContextMajorVersionKhr = 0x3098,
        [NativeName("Name", "EGL_CONTEXT_MINOR_VERSION_KHR")]
        ContextMinorVersionKhr = 0x30FB,
        [NativeName("Name", "EGL_CONTEXT_FLAGS_KHR")]
        ContextFlagsKhr = 0x30FC,
        [NativeName("Name", "EGL_CONTEXT_OPENGL_PROFILE_MASK_KHR")]
        ContextOpenglProfileMaskKhr = 0x30FD,
        [NativeName("Name", "EGL_CONTEXT_OPENGL_RESET_NOTIFICATION_STRATEGY_KHR")]
        ContextOpenglResetNotificationStrategyKhr = 0x31BD,
        [NativeName("Name", "EGL_NO_RESET_NOTIFICATION_KHR")]
        NoResetNotificationKhr = 0x31BE,
        [NativeName("Name", "EGL_LOSE_CONTEXT_ON_RESET_KHR")]
        LoseContextOnResetKhr = 0x31BF,
        [NativeName("Name", "EGL_CONTEXT_OPENGL_DEBUG_BIT_KHR")]
        ContextOpenglDebugBitKhr = 0x1,
        [NativeName("Name", "EGL_CONTEXT_OPENGL_FORWARD_COMPATIBLE_BIT_KHR")]
        ContextOpenglForwardCompatibleBitKhr = 0x2,
        [NativeName("Name", "EGL_CONTEXT_OPENGL_ROBUST_ACCESS_BIT_KHR")]
        ContextOpenglRobustAccessBitKhr = 0x4,
        [NativeName("Name", "EGL_CONTEXT_OPENGL_CORE_PROFILE_BIT_KHR")]
        ContextOpenglCoreProfileBitKhr = 0x1,
        [NativeName("Name", "EGL_CONTEXT_OPENGL_COMPATIBILITY_PROFILE_BIT_KHR")]
        ContextOpenglCompatibilityProfileBitKhr = 0x2,
        [NativeName("Name", "EGL_OPENGL_ES3_BIT")]
        OpenglES3Bit = 0x40,
        [NativeName("Name", "EGL_OPENGL_ES3_BIT_KHR")]
        OpenglES3BitKhr = 0x40,
        [NativeName("Name", "EGL_CONTEXT_OPENGL_NO_ERROR_KHR")]
        ContextOpenglNoErrorKhr = 0x31B3,
        [NativeName("Name", "EGL_OBJECT_THREAD_KHR")]
        ObjectThreadKhr = 0x33B0,
        [NativeName("Name", "EGL_OBJECT_DISPLAY_KHR")]
        ObjectDisplayKhr = 0x33B1,
        [NativeName("Name", "EGL_OBJECT_CONTEXT_KHR")]
        ObjectContextKhr = 0x33B2,
        [NativeName("Name", "EGL_OBJECT_SURFACE_KHR")]
        ObjectSurfaceKhr = 0x33B3,
        [NativeName("Name", "EGL_OBJECT_IMAGE_KHR")]
        ObjectImageKhr = 0x33B4,
        [NativeName("Name", "EGL_OBJECT_SYNC_KHR")]
        ObjectSyncKhr = 0x33B5,
        [NativeName("Name", "EGL_OBJECT_STREAM_KHR")]
        ObjectStreamKhr = 0x33B6,
        [NativeName("Name", "EGL_DEBUG_MSG_CRITICAL_KHR")]
        DebugMsgCriticalKhr = 0x33B9,
        [NativeName("Name", "EGL_DEBUG_MSG_ERROR_KHR")]
        DebugMsgErrorKhr = 0x33BA,
        [NativeName("Name", "EGL_DEBUG_MSG_WARN_KHR")]
        DebugMsgWarnKhr = 0x33BB,
        [NativeName("Name", "EGL_DEBUG_MSG_INFO_KHR")]
        DebugMsgInfoKhr = 0x33BC,
        [NativeName("Name", "EGL_DEBUG_CALLBACK_KHR")]
        DebugCallbackKhr = 0x33B8,
        [NativeName("Name", "EGL_TRACK_REFERENCES_KHR")]
        TrackReferencesKhr = 0x3352,
        [NativeName("Name", "EGL_SYNC_PRIOR_COMMANDS_COMPLETE_KHR")]
        SyncPriorCommandsCompleteKhr = 0x30F0,
        [NativeName("Name", "EGL_SYNC_CONDITION_KHR")]
        SyncConditionKhr = 0x30F8,
        [NativeName("Name", "EGL_SYNC_FENCE_KHR")]
        SyncFenceKhr = 0x30F9,
        [NativeName("Name", "EGL_GL_COLORSPACE_KHR")]
        GLColorspaceKhr = 0x309D,
        [NativeName("Name", "EGL_GL_COLORSPACE_SRGB_KHR")]
        GLColorspaceSrgbKhr = 0x3089,
        [NativeName("Name", "EGL_GL_COLORSPACE_LINEAR_KHR")]
        GLColorspaceLinearKhr = 0x308A,
        [NativeName("Name", "EGL_GL_RENDERBUFFER_KHR")]
        GLRenderbufferKhr = 0x30B9,
        [NativeName("Name", "EGL_GL_TEXTURE_2D_KHR")]
        GLTexture2DKhr = 0x30B1,
        [NativeName("Name", "EGL_GL_TEXTURE_LEVEL_KHR")]
        GLTextureLevelKhr = 0x30BC,
        [NativeName("Name", "EGL_GL_TEXTURE_3D_KHR")]
        GLTexture3DKhr = 0x30B2,
        [NativeName("Name", "EGL_GL_TEXTURE_ZOFFSET_KHR")]
        GLTextureZoffsetKhr = 0x30BD,
        [NativeName("Name", "EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_X_KHR")]
        GLTextureCubeMapPositiveXKhr = 0x30B3,
        [NativeName("Name", "EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_X_KHR")]
        GLTextureCubeMapNegativeXKhr = 0x30B4,
        [NativeName("Name", "EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_Y_KHR")]
        GLTextureCubeMapPositiveYKhr = 0x30B5,
        [NativeName("Name", "EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_KHR")]
        GLTextureCubeMapNegativeYKhr = 0x30B6,
        [NativeName("Name", "EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_Z_KHR")]
        GLTextureCubeMapPositiveZKhr = 0x30B7,
        [NativeName("Name", "EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_KHR")]
        GLTextureCubeMapNegativeZKhr = 0x30B8,
        [NativeName("Name", "EGL_NATIVE_PIXMAP_KHR")]
        NativePixmapKhr = 0x30B0,
        [NativeName("Name", "EGL_NO_IMAGE_KHR")]
        NoImageKhr = 0x0,
        [NativeName("Name", "EGL_IMAGE_PRESERVED_KHR")]
        ImagePreservedKhr = 0x30D2,
        [NativeName("Name", "EGL_READ_SURFACE_BIT_KHR")]
        ReadSurfaceBitKhr = 0x1,
        [NativeName("Name", "EGL_WRITE_SURFACE_BIT_KHR")]
        WriteSurfaceBitKhr = 0x2,
        [NativeName("Name", "EGL_LOCK_SURFACE_BIT_KHR")]
        LockSurfaceBitKhr = 0x80,
        [NativeName("Name", "EGL_OPTIMAL_FORMAT_BIT_KHR")]
        OptimalFormatBitKhr = 0x100,
        [NativeName("Name", "EGL_MATCH_FORMAT_KHR")]
        MatchFormatKhr = 0x3043,
        [NativeName("Name", "EGL_FORMAT_RGB_565_EXACT_KHR")]
        FormatRgb565ExactKhr = 0x30C0,
        [NativeName("Name", "EGL_FORMAT_RGB_565_KHR")]
        FormatRgb565Khr = 0x30C1,
        [NativeName("Name", "EGL_FORMAT_RGBA_8888_EXACT_KHR")]
        FormatRgba8888ExactKhr = 0x30C2,
        [NativeName("Name", "EGL_FORMAT_RGBA_8888_KHR")]
        FormatRgba8888Khr = 0x30C3,
        [NativeName("Name", "EGL_MAP_PRESERVE_PIXELS_KHR")]
        MapPreservePixelsKhr = 0x30C4,
        [NativeName("Name", "EGL_LOCK_USAGE_HINT_KHR")]
        LockUsageHintKhr = 0x30C5,
        [NativeName("Name", "EGL_BITMAP_POINTER_KHR")]
        BitmapPointerKhr = 0x30C6,
        [NativeName("Name", "EGL_BITMAP_PITCH_KHR")]
        BitmapPitchKhr = 0x30C7,
        [NativeName("Name", "EGL_BITMAP_ORIGIN_KHR")]
        BitmapOriginKhr = 0x30C8,
        [NativeName("Name", "EGL_BITMAP_PIXEL_RED_OFFSET_KHR")]
        BitmapPixelRedOffsetKhr = 0x30C9,
        [NativeName("Name", "EGL_BITMAP_PIXEL_GREEN_OFFSET_KHR")]
        BitmapPixelGreenOffsetKhr = 0x30CA,
        [NativeName("Name", "EGL_BITMAP_PIXEL_BLUE_OFFSET_KHR")]
        BitmapPixelBlueOffsetKhr = 0x30CB,
        [NativeName("Name", "EGL_BITMAP_PIXEL_ALPHA_OFFSET_KHR")]
        BitmapPixelAlphaOffsetKhr = 0x30CC,
        [NativeName("Name", "EGL_BITMAP_PIXEL_LUMINANCE_OFFSET_KHR")]
        BitmapPixelLuminanceOffsetKhr = 0x30CD,
        [NativeName("Name", "EGL_LOWER_LEFT_KHR")]
        LowerLeftKhr = 0x30CE,
        [NativeName("Name", "EGL_UPPER_LEFT_KHR")]
        UpperLeftKhr = 0x30CF,
        [NativeName("Name", "EGL_BITMAP_PIXEL_SIZE_KHR")]
        BitmapPixelSizeKhr = 0x3110,
        [NativeName("Name", "EGL_MUTABLE_RENDER_BUFFER_BIT_KHR")]
        MutableRenderBufferBitKhr = 0x1000,
        [NativeName("Name", "EGL_NO_CONFIG_KHR")]
        NoConfigKhr = 0x0,
        [NativeName("Name", "EGL_BUFFER_AGE_KHR")]
        BufferAgeKhr = 0x313D,
        [NativeName("Name", "EGL_PLATFORM_ANDROID_KHR")]
        PlatformAndroidKhr = 0x3141,
        [NativeName("Name", "EGL_PLATFORM_GBM_KHR")]
        PlatformGbmKhr = 0x31D7,
        [NativeName("Name", "EGL_PLATFORM_WAYLAND_KHR")]
        PlatformWaylandKhr = 0x31D8,
        [NativeName("Name", "EGL_PLATFORM_X11_KHR")]
        PlatformX11Khr = 0x31D5,
        [NativeName("Name", "EGL_PLATFORM_X11_SCREEN_KHR")]
        PlatformX11ScreenKhr = 0x31D6,
        [NativeName("Name", "EGL_SYNC_STATUS_KHR")]
        SyncStatusKhr = 0x30F1,
        [NativeName("Name", "EGL_SIGNALED_KHR")]
        SignaledKhr = 0x30F2,
        [NativeName("Name", "EGL_UNSIGNALED_KHR")]
        UnsignaledKhr = 0x30F3,
        [NativeName("Name", "EGL_TIMEOUT_EXPIRED_KHR")]
        TimeoutExpiredKhr = 0x30F5,
        [NativeName("Name", "EGL_CONDITION_SATISFIED_KHR")]
        ConditionSatisfiedKhr = 0x30F6,
        [NativeName("Name", "EGL_SYNC_TYPE_KHR")]
        SyncTypeKhr = 0x30F7,
        [NativeName("Name", "EGL_SYNC_REUSABLE_KHR")]
        SyncReusableKhr = 0x30FA,
        [NativeName("Name", "EGL_SYNC_FLUSH_COMMANDS_BIT_KHR")]
        SyncFlushCommandsBitKhr = 0x1,
        [NativeName("Name", "EGL_FOREVER_KHR")]
        ForeverKhr = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "EGL_NO_SYNC_KHR")]
        NoSyncKhr = 0x0,
        [NativeName("Name", "EGL_NO_STREAM_KHR")]
        NoStreamKhr = 0x0,
        [NativeName("Name", "EGL_CONSUMER_LATENCY_USEC_KHR")]
        ConsumerLatencyUsecKhr = 0x3210,
        [NativeName("Name", "EGL_PRODUCER_FRAME_KHR")]
        ProducerFrameKhr = 0x3212,
        [NativeName("Name", "EGL_CONSUMER_FRAME_KHR")]
        ConsumerFrameKhr = 0x3213,
        [NativeName("Name", "EGL_STREAM_STATE_KHR")]
        StreamStateKhr = 0x3214,
        [NativeName("Name", "EGL_STREAM_STATE_CREATED_KHR")]
        StreamStateCreatedKhr = 0x3215,
        [NativeName("Name", "EGL_STREAM_STATE_CONNECTING_KHR")]
        StreamStateConnectingKhr = 0x3216,
        [NativeName("Name", "EGL_STREAM_STATE_EMPTY_KHR")]
        StreamStateEmptyKhr = 0x3217,
        [NativeName("Name", "EGL_STREAM_STATE_NEW_FRAME_AVAILABLE_KHR")]
        StreamStateNewFrameAvailableKhr = 0x3218,
        [NativeName("Name", "EGL_STREAM_STATE_OLD_FRAME_AVAILABLE_KHR")]
        StreamStateOldFrameAvailableKhr = 0x3219,
        [NativeName("Name", "EGL_STREAM_STATE_DISCONNECTED_KHR")]
        StreamStateDisconnectedKhr = 0x321A,
        [NativeName("Name", "EGL_BAD_STREAM_KHR")]
        BadStreamKhr = 0x321B,
        [NativeName("Name", "EGL_BAD_STATE_KHR")]
        BadStateKhr = 0x321C,
        [NativeName("Name", "EGL_CONSUMER_ACQUIRE_TIMEOUT_USEC_KHR")]
        ConsumerAcquireTimeoutUsecKhr = 0x321E,
        [NativeName("Name", "EGL_NO_FILE_DESCRIPTOR_KHR")]
        NoFileDescriptorKhr = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "EGL_STREAM_FIFO_LENGTH_KHR")]
        StreamFifoLengthKhr = 0x31FC,
        [NativeName("Name", "EGL_STREAM_TIME_NOW_KHR")]
        StreamTimeNowKhr = 0x31FD,
        [NativeName("Name", "EGL_STREAM_TIME_CONSUMER_KHR")]
        StreamTimeConsumerKhr = 0x31FE,
        [NativeName("Name", "EGL_STREAM_TIME_PRODUCER_KHR")]
        StreamTimeProducerKhr = 0x31FF,
        [NativeName("Name", "EGL_STREAM_BIT_KHR")]
        StreamBitKhr = 0x800,
        [NativeName("Name", "EGL_VG_PARENT_IMAGE_KHR")]
        VGParentImageKhr = 0x30BA,
    }
}
