// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.DirectX;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WICImageParameters.xml' path='doc/member[@name="WICImageParameters"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct WICImageParameters
{
    /// <include file='WICImageParameters.xml' path='doc/member[@name="WICImageParameters.PixelFormat"]/*' />
    public D2D1_PIXEL_FORMAT PixelFormat;

    /// <include file='WICImageParameters.xml' path='doc/member[@name="WICImageParameters.DpiX"]/*' />
    public float DpiX;

    /// <include file='WICImageParameters.xml' path='doc/member[@name="WICImageParameters.DpiY"]/*' />
    public float DpiY;

    /// <include file='WICImageParameters.xml' path='doc/member[@name="WICImageParameters.Top"]/*' />
    public float Top;

    /// <include file='WICImageParameters.xml' path='doc/member[@name="WICImageParameters.Left"]/*' />
    public float Left;

    /// <include file='WICImageParameters.xml' path='doc/member[@name="WICImageParameters.PixelWidth"]/*' />
    [NativeTypeName("UINT32")]
    public uint PixelWidth;

    /// <include file='WICImageParameters.xml' path='doc/member[@name="WICImageParameters.PixelHeight"]/*' />
    [NativeTypeName("UINT32")]
    public uint PixelHeight;
}
