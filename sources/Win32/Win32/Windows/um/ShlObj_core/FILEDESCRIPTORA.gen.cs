// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct FILEDESCRIPTORA
{
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("CLSID")]
    public Guid clsid;

    [NativeTypeName("SIZEL")]
    public SIZE sizel;
    public POINTL pointl;

    [NativeTypeName("DWORD")]
    public uint dwFileAttributes;
    public FILETIME ftCreationTime;
    public FILETIME ftLastAccessTime;
    public FILETIME ftLastWriteTime;

    [NativeTypeName("DWORD")]
    public uint nFileSizeHigh;

    [NativeTypeName("DWORD")]
    public uint nFileSizeLow;

    [NativeTypeName("CHAR[260]")]
    public _cFileName_e__FixedBuffer cFileName;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(260)]
    public partial struct _cFileName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
