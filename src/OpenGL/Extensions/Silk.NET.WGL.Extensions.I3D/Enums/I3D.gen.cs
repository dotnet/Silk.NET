// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.I3D
{
    [NativeName("Name", "GLenum")]
    public enum I3D : int
    {
        [NativeName("Name", "WGL_DIGITAL_VIDEO_CURSOR_ALPHA_FRAMEBUFFER_I3D")]
        DigitalVideoCursorAlphaFramebufferI3D = 0x2050,
        [NativeName("Name", "WGL_DIGITAL_VIDEO_CURSOR_ALPHA_VALUE_I3D")]
        DigitalVideoCursorAlphaValueI3D = 0x2051,
        [NativeName("Name", "WGL_DIGITAL_VIDEO_CURSOR_INCLUDED_I3D")]
        DigitalVideoCursorIncludedI3D = 0x2052,
        [NativeName("Name", "WGL_DIGITAL_VIDEO_GAMMA_CORRECTED_I3D")]
        DigitalVideoGammaCorrectedI3D = 0x2053,
        [NativeName("Name", "WGL_GAMMA_TABLE_SIZE_I3D")]
        GammaTableSizeI3D = 0x204E,
        [NativeName("Name", "WGL_GAMMA_EXCLUDE_DESKTOP_I3D")]
        GammaExcludeDesktopI3D = 0x204F,
        [NativeName("Name", "WGL_GENLOCK_SOURCE_MULTIVIEW_I3D")]
        GenlockSourceMultiviewI3D = 0x2044,
        [NativeName("Name", "WGL_GENLOCK_SOURCE_EXTERNAL_SYNC_I3D")]
        GenlockSourceExternalSyncI3D = 0x2045,
        [NativeName("Name", "WGL_GENLOCK_SOURCE_EXTERNAL_FIELD_I3D")]
        GenlockSourceExternalFieldI3D = 0x2046,
        [NativeName("Name", "WGL_GENLOCK_SOURCE_EXTERNAL_TTL_I3D")]
        GenlockSourceExternalTtlI3D = 0x2047,
        [NativeName("Name", "WGL_GENLOCK_SOURCE_DIGITAL_SYNC_I3D")]
        GenlockSourceDigitalSyncI3D = 0x2048,
        [NativeName("Name", "WGL_GENLOCK_SOURCE_DIGITAL_FIELD_I3D")]
        GenlockSourceDigitalFieldI3D = 0x2049,
        [NativeName("Name", "WGL_GENLOCK_SOURCE_EDGE_FALLING_I3D")]
        GenlockSourceEdgeFallingI3D = 0x204A,
        [NativeName("Name", "WGL_GENLOCK_SOURCE_EDGE_RISING_I3D")]
        GenlockSourceEdgeRisingI3D = 0x204B,
        [NativeName("Name", "WGL_GENLOCK_SOURCE_EDGE_BOTH_I3D")]
        GenlockSourceEdgeBothI3D = 0x204C,
        [NativeName("Name", "WGL_IMAGE_BUFFER_MIN_ACCESS_I3D")]
        ImageBufferMinAccessI3D = 0x1,
        [NativeName("Name", "WGL_IMAGE_BUFFER_LOCK_I3D")]
        ImageBufferLockI3D = 0x2,
    }
}
