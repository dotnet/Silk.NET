// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DDOPTSURFACEDESC
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;
    public DDSCAPS2 ddSCaps;
    public DDOSCAPS ddOSCaps;
    public Guid guid;

    [NativeTypeName("DWORD")]
    public uint dwCompressionRatio;
}
