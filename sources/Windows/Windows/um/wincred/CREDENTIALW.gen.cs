// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CREDENTIALW.xml' path='doc/member[@name="CREDENTIALW"]/*' />
public unsafe partial struct CREDENTIALW
{
    /// <include file='CREDENTIALW.xml' path='doc/member[@name="CREDENTIALW.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='CREDENTIALW.xml' path='doc/member[@name="CREDENTIALW.Type"]/*' />
    [NativeTypeName("DWORD")]
    public uint Type;

    /// <include file='CREDENTIALW.xml' path='doc/member[@name="CREDENTIALW.TargetName"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* TargetName;

    /// <include file='CREDENTIALW.xml' path='doc/member[@name="CREDENTIALW.Comment"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* Comment;

    /// <include file='CREDENTIALW.xml' path='doc/member[@name="CREDENTIALW.LastWritten"]/*' />
    public FILETIME LastWritten;

    /// <include file='CREDENTIALW.xml' path='doc/member[@name="CREDENTIALW.CredentialBlobSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint CredentialBlobSize;

    /// <include file='CREDENTIALW.xml' path='doc/member[@name="CREDENTIALW.CredentialBlob"]/*' />
    [NativeTypeName("LPBYTE")]
    public byte* CredentialBlob;

    /// <include file='CREDENTIALW.xml' path='doc/member[@name="CREDENTIALW.Persist"]/*' />
    [NativeTypeName("DWORD")]
    public uint Persist;

    /// <include file='CREDENTIALW.xml' path='doc/member[@name="CREDENTIALW.AttributeCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint AttributeCount;

    /// <include file='CREDENTIALW.xml' path='doc/member[@name="CREDENTIALW.Attributes"]/*' />
    [NativeTypeName("PCREDENTIAL_ATTRIBUTEW")]
    public CREDENTIAL_ATTRIBUTEW* Attributes;

    /// <include file='CREDENTIALW.xml' path='doc/member[@name="CREDENTIALW.TargetAlias"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* TargetAlias;

    /// <include file='CREDENTIALW.xml' path='doc/member[@name="CREDENTIALW.UserName"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* UserName;
}
