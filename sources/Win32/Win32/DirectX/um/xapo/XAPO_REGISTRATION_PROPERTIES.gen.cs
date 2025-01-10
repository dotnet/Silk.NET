// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xapo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAPO_REGISTRATION_PROPERTIES
{
    [NativeTypeName("CLSID")]
    public Guid clsid;

    [NativeTypeName("WCHAR[256]")]
    public _FriendlyName_e__FixedBuffer FriendlyName;

    [NativeTypeName("WCHAR[256]")]
    public _CopyrightInfo_e__FixedBuffer CopyrightInfo;

    [NativeTypeName("UINT32")]
    public uint MajorVersion;

    [NativeTypeName("UINT32")]
    public uint MinorVersion;

    [NativeTypeName("UINT32")]
    public uint Flags;

    [NativeTypeName("UINT32")]
    public uint MinInputBufferCount;

    [NativeTypeName("UINT32")]
    public uint MaxInputBufferCount;

    [NativeTypeName("UINT32")]
    public uint MinOutputBufferCount;

    [NativeTypeName("UINT32")]
    public uint MaxOutputBufferCount;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(256)]
    public partial struct _FriendlyName_e__FixedBuffer
    {
        public ushort e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(256)]
    public partial struct _CopyrightInfo_e__FixedBuffer
    {
        public ushort e0;
    }
}
