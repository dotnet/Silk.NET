// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DxcShaderHash
{
    [NativeTypeName("UINT32")]
    public uint Flags;

    [NativeTypeName("BYTE[16]")]
    public _HashDigest_e__FixedBuffer HashDigest;

    [InlineArray(16)]
    public partial struct _HashDigest_e__FixedBuffer
    {
        public byte e0;
    }
}
