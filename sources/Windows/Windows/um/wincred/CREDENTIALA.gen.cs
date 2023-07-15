// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CREDENTIALA.xml' path='doc/member[@name="CREDENTIALA"]/*'/>
public unsafe partial struct CREDENTIALA
{
    /// <include file='CREDENTIALA.xml' path='doc/member[@name="CREDENTIALA.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='CREDENTIALA.xml' path='doc/member[@name="CREDENTIALA.Type"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Type;
    /// <include file='CREDENTIALA.xml' path='doc/member[@name="CREDENTIALA.TargetName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* TargetName;
    /// <include file='CREDENTIALA.xml' path='doc/member[@name="CREDENTIALA.Comment"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* Comment;
    /// <include file='CREDENTIALA.xml' path='doc/member[@name="CREDENTIALA.LastWritten"]/*'/>
    public FILETIME LastWritten;
    /// <include file='CREDENTIALA.xml' path='doc/member[@name="CREDENTIALA.CredentialBlobSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CredentialBlobSize;
    /// <include file='CREDENTIALA.xml' path='doc/member[@name="CREDENTIALA.CredentialBlob"]/*'/>
    [NativeTypeName("LPBYTE")]
    public byte* CredentialBlob;
    /// <include file='CREDENTIALA.xml' path='doc/member[@name="CREDENTIALA.Persist"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Persist;
    /// <include file='CREDENTIALA.xml' path='doc/member[@name="CREDENTIALA.AttributeCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AttributeCount;
    /// <include file='CREDENTIALA.xml' path='doc/member[@name="CREDENTIALA.Attributes"]/*'/>
    [NativeTypeName("PCREDENTIAL_ATTRIBUTEA")]
    public CREDENTIAL_ATTRIBUTEA* Attributes;
    /// <include file='CREDENTIALA.xml' path='doc/member[@name="CREDENTIALA.TargetAlias"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* TargetAlias;
    /// <include file='CREDENTIALA.xml' path='doc/member[@name="CREDENTIALA.UserName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* UserName;
}