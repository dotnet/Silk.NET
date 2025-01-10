// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TLIBATTR
{
    public Guid guid;

    [NativeTypeName("LCID")]
    public uint lcid;
    public SYSKIND syskind;

    [NativeTypeName("WORD")]
    public ushort wMajorVerNum;

    [NativeTypeName("WORD")]
    public ushort wMinorVerNum;

    [NativeTypeName("WORD")]
    public ushort wLibFlags;
}
