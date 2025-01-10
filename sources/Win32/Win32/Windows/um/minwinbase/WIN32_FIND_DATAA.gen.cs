// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct WIN32_FIND_DATAA
{
    [NativeTypeName("DWORD")]
    public uint dwFileAttributes;
    public FILETIME ftCreationTime;
    public FILETIME ftLastAccessTime;
    public FILETIME ftLastWriteTime;

    [NativeTypeName("DWORD")]
    public uint nFileSizeHigh;

    [NativeTypeName("DWORD")]
    public uint nFileSizeLow;

    [NativeTypeName("DWORD")]
    public uint dwReserved0;

    [NativeTypeName("DWORD")]
    public uint dwReserved1;

    [NativeTypeName("CHAR[260]")]
    public _cFileName_e__FixedBuffer cFileName;

    [NativeTypeName("CHAR[14]")]
    public _cAlternateFileName_e__FixedBuffer cAlternateFileName;

    [InlineArray(260)]
    public partial struct _cFileName_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(14)]
    public partial struct _cAlternateFileName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
