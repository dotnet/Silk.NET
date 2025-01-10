// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MFRR_COMPONENT_HASH_INFO
{
    [NativeTypeName("DWORD")]
    public uint ulReason;

    [NativeTypeName("WCHAR[43]")]
    public _rgHeaderHash_e__FixedBuffer rgHeaderHash;

    [NativeTypeName("WCHAR[43]")]
    public _rgPublicKeyHash_e__FixedBuffer rgPublicKeyHash;

    [NativeTypeName("WCHAR[260]")]
    public _wszName_e__FixedBuffer wszName;

    [InlineArray(43)]
    public partial struct _rgHeaderHash_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(43)]
    public partial struct _rgPublicKeyHash_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(260)]
    public partial struct _wszName_e__FixedBuffer
    {
        public ushort e0;
    }
}
