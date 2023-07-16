// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='WICDdsDimension.xml' path='doc/member[@name="WICDdsDimension"]/*'/>
[SupportedOSPlatform("windows6.3")]
public enum WICDdsDimension
{
    /// <include file='WICDdsDimension.xml' path='doc/member[@name="WICDdsDimension.WICDdsTexture1D"]/*'/>
    WICDdsTexture1D = 0,
    /// <include file='WICDdsDimension.xml' path='doc/member[@name="WICDdsDimension.WICDdsTexture2D"]/*'/>
    WICDdsTexture2D = 0x1,
    /// <include file='WICDdsDimension.xml' path='doc/member[@name="WICDdsDimension.WICDdsTexture3D"]/*'/>
    WICDdsTexture3D = 0x2,
    /// <include file='WICDdsDimension.xml' path='doc/member[@name="WICDdsDimension.WICDdsTextureCube"]/*'/>
    WICDdsTextureCube = 0x3,
    /// <include file='WICDdsDimension.xml' path='doc/member[@name="WICDdsDimension.WICDDSTEXTURE_FORCE_DWORD"]/*'/>
    WICDDSTEXTURE_FORCE_DWORD = 0x7fffffff,
}