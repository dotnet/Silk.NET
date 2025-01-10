// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGE_ROM_OPTIONAL_HEADER
{
    [NativeTypeName("WORD")]
    public ushort Magic;
    public byte MajorLinkerVersion;
    public byte MinorLinkerVersion;

    [NativeTypeName("DWORD")]
    public uint SizeOfCode;

    [NativeTypeName("DWORD")]
    public uint SizeOfInitializedData;

    [NativeTypeName("DWORD")]
    public uint SizeOfUninitializedData;

    [NativeTypeName("DWORD")]
    public uint AddressOfEntryPoint;

    [NativeTypeName("DWORD")]
    public uint BaseOfCode;

    [NativeTypeName("DWORD")]
    public uint BaseOfData;

    [NativeTypeName("DWORD")]
    public uint BaseOfBss;

    [NativeTypeName("DWORD")]
    public uint GprMask;

    [NativeTypeName("DWORD[4]")]
    public _CprMask_e__FixedBuffer CprMask;

    [NativeTypeName("DWORD")]
    public uint GpValue;

    [InlineArray(4)]
    public partial struct _CprMask_e__FixedBuffer
    {
        public uint e0;
    }
}
