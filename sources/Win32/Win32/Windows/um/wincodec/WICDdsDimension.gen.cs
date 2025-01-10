// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.3")]
public enum WICDdsDimension
{
    WICDdsTexture1D = 0,
    WICDdsTexture2D = 0x1,
    WICDdsTexture3D = 0x2,
    WICDdsTextureCube = 0x3,
    WICDDSTEXTURE_FORCE_DWORD = 0x7fffffff,
}
