// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct ENCRYPTION_KEY_CTRL_INPUT
{
    [NativeTypeName("DWORD")]
    public uint HeaderSize;

    [NativeTypeName("DWORD")]
    public uint StructureSize;

    [NativeTypeName("WORD")]
    public ushort KeyOffset;

    [NativeTypeName("WORD")]
    public ushort KeySize;

    [NativeTypeName("DWORD")]
    public uint DplLock;

    [NativeTypeName("DWORDLONG")]
    public ulong DplUserId;

    [NativeTypeName("DWORDLONG")]
    public ulong DplCredentialId;
}
