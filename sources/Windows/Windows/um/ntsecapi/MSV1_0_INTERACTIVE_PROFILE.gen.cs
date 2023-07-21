// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MSV1_0_INTERACTIVE_PROFILE.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_PROFILE"]/*' />
public partial struct MSV1_0_INTERACTIVE_PROFILE
{
    /// <include file='MSV1_0_INTERACTIVE_PROFILE.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_PROFILE.MessageType"]/*' />
    public MSV1_0_PROFILE_BUFFER_TYPE MessageType;

    /// <include file='MSV1_0_INTERACTIVE_PROFILE.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_PROFILE.LogonCount"]/*' />
    public ushort LogonCount;

    /// <include file='MSV1_0_INTERACTIVE_PROFILE.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_PROFILE.BadPasswordCount"]/*' />
    public ushort BadPasswordCount;

    /// <include file='MSV1_0_INTERACTIVE_PROFILE.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_PROFILE.LogonTime"]/*' />
    public LARGE_INTEGER LogonTime;

    /// <include file='MSV1_0_INTERACTIVE_PROFILE.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_PROFILE.LogoffTime"]/*' />
    public LARGE_INTEGER LogoffTime;

    /// <include file='MSV1_0_INTERACTIVE_PROFILE.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_PROFILE.KickOffTime"]/*' />
    public LARGE_INTEGER KickOffTime;

    /// <include file='MSV1_0_INTERACTIVE_PROFILE.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_PROFILE.PasswordLastSet"]/*' />
    public LARGE_INTEGER PasswordLastSet;

    /// <include file='MSV1_0_INTERACTIVE_PROFILE.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_PROFILE.PasswordCanChange"]/*' />
    public LARGE_INTEGER PasswordCanChange;

    /// <include file='MSV1_0_INTERACTIVE_PROFILE.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_PROFILE.PasswordMustChange"]/*' />
    public LARGE_INTEGER PasswordMustChange;

    /// <include file='MSV1_0_INTERACTIVE_PROFILE.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_PROFILE.LogonScript"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING LogonScript;

    /// <include file='MSV1_0_INTERACTIVE_PROFILE.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_PROFILE.HomeDirectory"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING HomeDirectory;

    /// <include file='MSV1_0_INTERACTIVE_PROFILE.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_PROFILE.FullName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING FullName;

    /// <include file='MSV1_0_INTERACTIVE_PROFILE.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_PROFILE.ProfilePath"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ProfilePath;

    /// <include file='MSV1_0_INTERACTIVE_PROFILE.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_PROFILE.HomeDirectoryDrive"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING HomeDirectoryDrive;

    /// <include file='MSV1_0_INTERACTIVE_PROFILE.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_PROFILE.LogonServer"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING LogonServer;

    /// <include file='MSV1_0_INTERACTIVE_PROFILE.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_PROFILE.UserFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint UserFlags;
}
