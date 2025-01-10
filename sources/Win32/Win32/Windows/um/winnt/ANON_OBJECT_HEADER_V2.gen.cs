// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct ANON_OBJECT_HEADER_V2
{
    [NativeTypeName("WORD")]
    public ushort Sig1;

    [NativeTypeName("WORD")]
    public ushort Sig2;

    [NativeTypeName("WORD")]
    public ushort Version;

    [NativeTypeName("WORD")]
    public ushort Machine;

    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    [NativeTypeName("CLSID")]
    public Guid ClassID;

    [NativeTypeName("DWORD")]
    public uint SizeOfData;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint MetaDataSize;

    [NativeTypeName("DWORD")]
    public uint MetaDataOffset;
}
