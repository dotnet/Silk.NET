// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SECURITY_DESCRIPTOR_RELATIVE
{
    public byte Revision;
    public byte Sbz1;

    [NativeTypeName("SECURITY_DESCRIPTOR_CONTROL")]
    public ushort Control;

    [NativeTypeName("DWORD")]
    public uint Owner;

    [NativeTypeName("DWORD")]
    public uint Group;

    [NativeTypeName("DWORD")]
    public uint Sacl;

    [NativeTypeName("DWORD")]
    public uint Dacl;
}
