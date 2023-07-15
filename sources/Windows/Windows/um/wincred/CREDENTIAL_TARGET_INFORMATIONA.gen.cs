// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CREDENTIAL_TARGET_INFORMATIONA.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONA"]/*'/>
public unsafe partial struct CREDENTIAL_TARGET_INFORMATIONA
{
    /// <include file='CREDENTIAL_TARGET_INFORMATIONA.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONA.TargetName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* TargetName;
    /// <include file='CREDENTIAL_TARGET_INFORMATIONA.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONA.NetbiosServerName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* NetbiosServerName;
    /// <include file='CREDENTIAL_TARGET_INFORMATIONA.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONA.DnsServerName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* DnsServerName;
    /// <include file='CREDENTIAL_TARGET_INFORMATIONA.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONA.NetbiosDomainName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* NetbiosDomainName;
    /// <include file='CREDENTIAL_TARGET_INFORMATIONA.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONA.DnsDomainName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* DnsDomainName;
    /// <include file='CREDENTIAL_TARGET_INFORMATIONA.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONA.DnsTreeName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* DnsTreeName;
    /// <include file='CREDENTIAL_TARGET_INFORMATIONA.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONA.PackageName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* PackageName;
    /// <include file='CREDENTIAL_TARGET_INFORMATIONA.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONA.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='CREDENTIAL_TARGET_INFORMATIONA.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONA.CredTypeCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CredTypeCount;
    /// <include file='CREDENTIAL_TARGET_INFORMATIONA.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONA.CredTypes"]/*'/>
    [NativeTypeName("LPDWORD")]
    public uint* CredTypes;
}