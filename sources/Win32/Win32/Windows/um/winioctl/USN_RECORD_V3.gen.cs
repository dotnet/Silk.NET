// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public partial struct USN_RECORD_V3
{
    [NativeTypeName("DWORD")]
    public uint RecordLength;

    [NativeTypeName("WORD")]
    public ushort MajorVersion;

    [NativeTypeName("WORD")]
    public ushort MinorVersion;
    public FILE_ID_128 FileReferenceNumber;
    public FILE_ID_128 ParentFileReferenceNumber;

    [NativeTypeName("USN")]
    public long Usn;
    public LARGE_INTEGER TimeStamp;

    [NativeTypeName("DWORD")]
    public uint Reason;

    [NativeTypeName("DWORD")]
    public uint SourceInfo;

    [NativeTypeName("DWORD")]
    public uint SecurityId;

    [NativeTypeName("DWORD")]
    public uint FileAttributes;

    [NativeTypeName("WORD")]
    public ushort FileNameLength;

    [NativeTypeName("WORD")]
    public ushort FileNameOffset;

    [NativeTypeName("WCHAR[1]")]
    public _FileName_e__FixedBuffer FileName;

    public partial struct _FileName_e__FixedBuffer
    {
        public ushort e0;

        [UnscopedRef]
        public ref ushort this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<ushort> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
