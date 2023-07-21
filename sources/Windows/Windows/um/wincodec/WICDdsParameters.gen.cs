// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.DirectX;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WICDdsParameters.xml' path='doc/member[@name="WICDdsParameters"]/*' />
[SupportedOSPlatform("windows6.3")]
public partial struct WICDdsParameters
{
    /// <include file='WICDdsParameters.xml' path='doc/member[@name="WICDdsParameters.Width"]/*' />
    public uint Width;

    /// <include file='WICDdsParameters.xml' path='doc/member[@name="WICDdsParameters.Height"]/*' />
    public uint Height;

    /// <include file='WICDdsParameters.xml' path='doc/member[@name="WICDdsParameters.Depth"]/*' />
    public uint Depth;

    /// <include file='WICDdsParameters.xml' path='doc/member[@name="WICDdsParameters.MipLevels"]/*' />
    public uint MipLevels;

    /// <include file='WICDdsParameters.xml' path='doc/member[@name="WICDdsParameters.ArraySize"]/*' />
    public uint ArraySize;

    /// <include file='WICDdsParameters.xml' path='doc/member[@name="WICDdsParameters.DxgiFormat"]/*' />
    public DXGI_FORMAT DxgiFormat;

    /// <include file='WICDdsParameters.xml' path='doc/member[@name="WICDdsParameters.Dimension"]/*' />
    public WICDdsDimension Dimension;

    /// <include file='WICDdsParameters.xml' path='doc/member[@name="WICDdsParameters.AlphaMode"]/*' />
    public WICDdsAlphaMode AlphaMode;
}
