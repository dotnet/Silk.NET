// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MSV1_0_INTERACTIVE_PROFILE
{
    public MSV1_0_PROFILE_BUFFER_TYPE MessageType;
    public ushort LogonCount;
    public ushort BadPasswordCount;
    public LARGE_INTEGER LogonTime;
    public LARGE_INTEGER LogoffTime;
    public LARGE_INTEGER KickOffTime;
    public LARGE_INTEGER PasswordLastSet;
    public LARGE_INTEGER PasswordCanChange;
    public LARGE_INTEGER PasswordMustChange;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING LogonScript;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING HomeDirectory;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING FullName;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ProfilePath;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING HomeDirectoryDrive;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING LogonServer;

    [NativeTypeName("ULONG")]
    public uint UserFlags;
}
