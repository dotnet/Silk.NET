// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct ACTRL_ACCESS_ENTRYW
{
    public TRUSTEE_W Trustee;

    [NativeTypeName("ULONG")]
    public uint fAccessFlags;

    [NativeTypeName("ACCESS_RIGHTS")]
    public uint Access;

    [NativeTypeName("ACCESS_RIGHTS")]
    public uint ProvSpecificAccess;

    [NativeTypeName("INHERIT_FLAGS")]
    public uint Inheritance;

    [NativeTypeName("LPWSTR")]
    public ushort* lpInheritProperty;
}
