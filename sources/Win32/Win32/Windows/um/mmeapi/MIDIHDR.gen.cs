// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIDIHDR
{
    [NativeTypeName("LPSTR")]
    public sbyte* lpData;

    [NativeTypeName("DWORD")]
    public uint dwBufferLength;

    [NativeTypeName("DWORD")]
    public uint dwBytesRecorded;

    [NativeTypeName("DWORD_PTR")]
    public nuint dwUser;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("struct midihdr_tag *")]
    public MIDIHDR* lpNext;

    [NativeTypeName("DWORD_PTR")]
    public nuint reserved;

    [NativeTypeName("DWORD")]
    public uint dwOffset;

    [NativeTypeName("DWORD_PTR[8]")]
    public _dwReserved_e__FixedBuffer dwReserved;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(8)]
    public partial struct _dwReserved_e__FixedBuffer
    {
        public nuint e0;
    }
}
