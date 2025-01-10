// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SCRUB_DATA_INPUT
{
    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint MaximumIos;

    [NativeTypeName("DWORD[4]")]
    public _ObjectId_e__FixedBuffer ObjectId;

    [NativeTypeName("ULONGLONG")]
    public ulong StartingByteOffset;

    [NativeTypeName("ULONGLONG")]
    public ulong ByteCount;

    [NativeTypeName("DWORD[36]")]
    public _Reserved_e__FixedBuffer Reserved;

    [NativeTypeName("BYTE[1040]")]
    public _ResumeContext_e__FixedBuffer ResumeContext;

    [InlineArray(4)]
    public partial struct _ObjectId_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(36)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(1040)]
    public partial struct _ResumeContext_e__FixedBuffer
    {
        public byte e0;
    }
}
