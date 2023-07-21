// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.DirectX;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WICDdsFormatInfo.xml' path='doc/member[@name="WICDdsFormatInfo"]/*' />
[SupportedOSPlatform("windows6.3")]
public partial struct WICDdsFormatInfo
{
    /// <include file='WICDdsFormatInfo.xml' path='doc/member[@name="WICDdsFormatInfo.DxgiFormat"]/*' />
    public DXGI_FORMAT DxgiFormat;

    /// <include file='WICDdsFormatInfo.xml' path='doc/member[@name="WICDdsFormatInfo.BytesPerBlock"]/*' />
    public uint BytesPerBlock;

    /// <include file='WICDdsFormatInfo.xml' path='doc/member[@name="WICDdsFormatInfo.BlockWidth"]/*' />
    public uint BlockWidth;

    /// <include file='WICDdsFormatInfo.xml' path='doc/member[@name="WICDdsFormatInfo.BlockHeight"]/*' />
    public uint BlockHeight;
}
