// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WICBitmapPlane.xml' path='doc/member[@name="WICBitmapPlane"]/*' />
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct WICBitmapPlane
{
    /// <include file='WICBitmapPlane.xml' path='doc/member[@name="WICBitmapPlane.Format"]/*' />
    [NativeTypeName("WICPixelFormatGUID")]
    public Guid Format;

    /// <include file='WICBitmapPlane.xml' path='doc/member[@name="WICBitmapPlane.pbBuffer"]/*' />
    public byte* pbBuffer;

    /// <include file='WICBitmapPlane.xml' path='doc/member[@name="WICBitmapPlane.cbStride"]/*' />
    public uint cbStride;

    /// <include file='WICBitmapPlane.xml' path='doc/member[@name="WICBitmapPlane.cbBufferSize"]/*' />
    public uint cbBufferSize;
}
