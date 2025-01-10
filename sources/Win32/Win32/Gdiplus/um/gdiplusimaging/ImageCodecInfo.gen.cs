// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public unsafe partial struct ImageCodecInfo
{
    [NativeTypeName("CLSID")]
    public Guid Clsid;
    public Guid FormatID;

    [NativeTypeName("const WCHAR *")]
    public ushort* CodecName;

    [NativeTypeName("const WCHAR *")]
    public ushort* DllName;

    [NativeTypeName("const WCHAR *")]
    public ushort* FormatDescription;

    [NativeTypeName("const WCHAR *")]
    public ushort* FilenameExtension;

    [NativeTypeName("const WCHAR *")]
    public ushort* MimeType;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint SigCount;

    [NativeTypeName("DWORD")]
    public uint SigSize;

    [NativeTypeName("const BYTE *")]
    public byte* SigPattern;

    [NativeTypeName("const BYTE *")]
    public byte* SigMask;
}
