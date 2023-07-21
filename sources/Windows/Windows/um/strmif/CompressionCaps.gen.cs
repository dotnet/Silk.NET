// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CompressionCaps.xml' path='doc/member[@name="CompressionCaps"]/*' />
public enum CompressionCaps
{
    /// <include file='CompressionCaps.xml' path='doc/member[@name="CompressionCaps.CompressionCaps_CanQuality"]/*' />
    CompressionCaps_CanQuality = 0x1,

    /// <include file='CompressionCaps.xml' path='doc/member[@name="CompressionCaps.CompressionCaps_CanCrunch"]/*' />
    CompressionCaps_CanCrunch = 0x2,

    /// <include file='CompressionCaps.xml' path='doc/member[@name="CompressionCaps.CompressionCaps_CanKeyFrame"]/*' />
    CompressionCaps_CanKeyFrame = 0x4,

    /// <include file='CompressionCaps.xml' path='doc/member[@name="CompressionCaps.CompressionCaps_CanBFrame"]/*' />
    CompressionCaps_CanBFrame = 0x8,

    /// <include file='CompressionCaps.xml' path='doc/member[@name="CompressionCaps.CompressionCaps_CanWindow"]/*' />
    CompressionCaps_CanWindow = 0x10,
}
