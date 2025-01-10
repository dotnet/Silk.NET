// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
public enum D3D10_RESOURCE_MISC_FLAG
{
    D3D10_RESOURCE_MISC_GENERATE_MIPS = 0x1,
    D3D10_RESOURCE_MISC_SHARED = 0x2,
    D3D10_RESOURCE_MISC_TEXTURECUBE = 0x4,
    D3D10_RESOURCE_MISC_SHARED_KEYEDMUTEX = 0x10,
    D3D10_RESOURCE_MISC_GDI_COMPATIBLE = 0x20,
}
