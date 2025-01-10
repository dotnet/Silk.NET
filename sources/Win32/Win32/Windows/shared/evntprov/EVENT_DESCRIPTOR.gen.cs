// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct EVENT_DESCRIPTOR
{
    public ushort Id;

    [NativeTypeName("UCHAR")]
    public byte Version;

    [NativeTypeName("UCHAR")]
    public byte Channel;

    [NativeTypeName("UCHAR")]
    public byte Level;

    [NativeTypeName("UCHAR")]
    public byte Opcode;
    public ushort Task;

    [NativeTypeName("ULONGLONG")]
    public ulong Keyword;
}
