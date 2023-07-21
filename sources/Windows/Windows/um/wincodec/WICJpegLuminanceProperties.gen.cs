// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICJpegLuminanceProperties.xml' path='doc/member[@name="WICJpegLuminanceProperties"]/*' />
public enum WICJpegLuminanceProperties
{
    /// <include file='WICJpegLuminanceProperties.xml' path='doc/member[@name="WICJpegLuminanceProperties.WICJpegLuminanceTable"]/*' />
    WICJpegLuminanceTable = 0x1,

    /// <include file='WICJpegLuminanceProperties.xml' path='doc/member[@name="WICJpegLuminanceProperties.WICJpegLuminanceProperties_FORCE_DWORD"]/*' />
    WICJpegLuminanceProperties_FORCE_DWORD = 0x7fffffff,
}
