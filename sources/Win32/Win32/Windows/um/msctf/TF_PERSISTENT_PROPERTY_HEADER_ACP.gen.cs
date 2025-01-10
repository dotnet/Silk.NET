// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TF_PERSISTENT_PROPERTY_HEADER_ACP
{
    public Guid guidType;

    [NativeTypeName("LONG")]
    public int ichStart;

    [NativeTypeName("LONG")]
    public int cch;

    [NativeTypeName("ULONG")]
    public uint cb;

    [NativeTypeName("DWORD")]
    public uint dwPrivate;

    [NativeTypeName("CLSID")]
    public Guid clsidTIP;
}
