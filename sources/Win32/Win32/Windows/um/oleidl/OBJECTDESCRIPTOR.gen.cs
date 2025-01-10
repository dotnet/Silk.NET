// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct OBJECTDESCRIPTOR
{
    [NativeTypeName("ULONG")]
    public uint cbSize;

    [NativeTypeName("CLSID")]
    public Guid clsid;

    [NativeTypeName("DWORD")]
    public uint dwDrawAspect;

    [NativeTypeName("SIZEL")]
    public SIZE sizel;
    public POINTL pointl;

    [NativeTypeName("DWORD")]
    public uint dwStatus;

    [NativeTypeName("DWORD")]
    public uint dwFullUserTypeName;

    [NativeTypeName("DWORD")]
    public uint dwSrcOfCopy;
}
