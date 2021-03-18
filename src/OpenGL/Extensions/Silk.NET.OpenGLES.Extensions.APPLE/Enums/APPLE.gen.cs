// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.APPLE
{
    [NativeName("Name", "GLenum")]
    public enum APPLE : int
    {
        [NativeName("Name", "GL_MAX_CLIP_DISTANCES_APPLE")]
        MaxClipDistancesApple = 0xD32,
        [NativeName("Name", "GL_CLIP_DISTANCE0_APPLE")]
        ClipDistance0Apple = 0x3000,
        [NativeName("Name", "GL_CLIP_DISTANCE1_APPLE")]
        ClipDistance1Apple = 0x3001,
        [NativeName("Name", "GL_CLIP_DISTANCE2_APPLE")]
        ClipDistance2Apple = 0x3002,
        [NativeName("Name", "GL_CLIP_DISTANCE3_APPLE")]
        ClipDistance3Apple = 0x3003,
        [NativeName("Name", "GL_CLIP_DISTANCE4_APPLE")]
        ClipDistance4Apple = 0x3004,
        [NativeName("Name", "GL_CLIP_DISTANCE5_APPLE")]
        ClipDistance5Apple = 0x3005,
        [NativeName("Name", "GL_CLIP_DISTANCE6_APPLE")]
        ClipDistance6Apple = 0x3006,
        [NativeName("Name", "GL_CLIP_DISTANCE7_APPLE")]
        ClipDistance7Apple = 0x3007,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES_APPLE")]
        RenderbufferSamplesApple = 0x8CAB,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE")]
        FramebufferIncompleteMultisampleApple = 0x8D56,
        [NativeName("Name", "GL_MAX_SAMPLES_APPLE")]
        MaxSamplesApple = 0x8D57,
        [NativeName("Name", "GL_READ_FRAMEBUFFER_APPLE")]
        ReadFramebufferApple = 0x8CA8,
        [NativeName("Name", "GL_DRAW_FRAMEBUFFER_APPLE")]
        DrawFramebufferApple = 0x8CA9,
        [NativeName("Name", "GL_DRAW_FRAMEBUFFER_BINDING_APPLE")]
        DrawFramebufferBindingApple = 0x8CA6,
        [NativeName("Name", "GL_READ_FRAMEBUFFER_BINDING_APPLE")]
        ReadFramebufferBindingApple = 0x8CAA,
        [NativeName("Name", "GL_RGB_422_APPLE")]
        Rgb422Apple = 0x8A1F,
        [NativeName("Name", "GL_UNSIGNED_SHORT_8_8_APPLE")]
        UnsignedShort88Apple = 0x85BA,
        [NativeName("Name", "GL_UNSIGNED_SHORT_8_8_REV_APPLE")]
        UnsignedShort88RevApple = 0x85BB,
        [NativeName("Name", "GL_RGB_RAW_422_APPLE")]
        RgbRaw422Apple = 0x8A51,
        [NativeName("Name", "GL_SYNC_OBJECT_APPLE")]
        SyncObjectApple = 0x8A53,
        [NativeName("Name", "GL_MAX_SERVER_WAIT_TIMEOUT_APPLE")]
        MaxServerWaitTimeoutApple = 0x9111,
        [NativeName("Name", "GL_OBJECT_TYPE_APPLE")]
        ObjectTypeApple = 0x9112,
        [NativeName("Name", "GL_SYNC_CONDITION_APPLE")]
        SyncConditionApple = 0x9113,
        [NativeName("Name", "GL_SYNC_STATUS_APPLE")]
        SyncStatusApple = 0x9114,
        [NativeName("Name", "GL_SYNC_FLAGS_APPLE")]
        SyncFlagsApple = 0x9115,
        [NativeName("Name", "GL_SYNC_FENCE_APPLE")]
        SyncFenceApple = 0x9116,
        [NativeName("Name", "GL_SYNC_GPU_COMMANDS_COMPLETE_APPLE")]
        SyncGpuCommandsCompleteApple = 0x9117,
        [NativeName("Name", "GL_UNSIGNALED_APPLE")]
        UnsignaledApple = 0x9118,
        [NativeName("Name", "GL_SIGNALED_APPLE")]
        SignaledApple = 0x9119,
        [NativeName("Name", "GL_ALREADY_SIGNALED_APPLE")]
        AlreadySignaledApple = 0x911A,
        [NativeName("Name", "GL_TIMEOUT_EXPIRED_APPLE")]
        TimeoutExpiredApple = 0x911B,
        [NativeName("Name", "GL_CONDITION_SATISFIED_APPLE")]
        ConditionSatisfiedApple = 0x911C,
        [NativeName("Name", "GL_WAIT_FAILED_APPLE")]
        WaitFailedApple = 0x911D,
        [NativeName("Name", "GL_SYNC_FLUSH_COMMANDS_BIT_APPLE")]
        SyncFlushCommandsBitApple = 0x1,
        [NativeName("Name", "GL_TIMEOUT_IGNORED_APPLE")]
        TimeoutIgnoredApple = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "GL_BGRA_EXT")]
        BgraExt = 0x80E1,
        [NativeName("Name", "GL_BGRA8_EXT")]
        Bgra8Ext = 0x93A1,
        [NativeName("Name", "GL_TEXTURE_MAX_LEVEL_APPLE")]
        TextureMaxLevelApple = 0x813D,
        [NativeName("Name", "GL_UNSIGNED_INT_10F_11F_11F_REV_APPLE")]
        UnsignedInt10f11f11fRevApple = 0x8C3B,
        [NativeName("Name", "GL_UNSIGNED_INT_5_9_9_9_REV_APPLE")]
        UnsignedInt5999RevApple = 0x8C3E,
        [NativeName("Name", "GL_R11F_G11F_B10F_APPLE")]
        R11fG11fB10fApple = 0x8C3A,
        [NativeName("Name", "GL_RGB9_E5_APPLE")]
        Rgb9E5Apple = 0x8C3D,
    }
}
