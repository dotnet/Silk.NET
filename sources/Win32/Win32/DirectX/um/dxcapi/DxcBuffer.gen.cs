// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DxcBuffer
{
    [NativeTypeName("LPCVOID")]
    public void* Ptr;

    [NativeTypeName("SIZE_T")]
    public nuint Size;
    public uint Encoding;
}
