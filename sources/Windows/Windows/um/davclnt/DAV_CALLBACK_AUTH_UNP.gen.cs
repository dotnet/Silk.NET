// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/davclnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DAV_CALLBACK_AUTH_UNP.xml' path='doc/member[@name="DAV_CALLBACK_AUTH_UNP"]/*' />
public unsafe partial struct DAV_CALLBACK_AUTH_UNP
{
    /// <include file='DAV_CALLBACK_AUTH_UNP.xml' path='doc/member[@name="DAV_CALLBACK_AUTH_UNP.pszUserName"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszUserName;

    /// <include file='DAV_CALLBACK_AUTH_UNP.xml' path='doc/member[@name="DAV_CALLBACK_AUTH_UNP.ulUserNameLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulUserNameLength;

    /// <include file='DAV_CALLBACK_AUTH_UNP.xml' path='doc/member[@name="DAV_CALLBACK_AUTH_UNP.pszPassword"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszPassword;

    /// <include file='DAV_CALLBACK_AUTH_UNP.xml' path='doc/member[@name="DAV_CALLBACK_AUTH_UNP.ulPasswordLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulPasswordLength;
}
