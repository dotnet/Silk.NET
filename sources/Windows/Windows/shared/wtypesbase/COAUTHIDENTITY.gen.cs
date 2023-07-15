// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='COAUTHIDENTITY.xml' path='doc/member[@name="COAUTHIDENTITY"]/*'/>
public unsafe partial struct COAUTHIDENTITY
{
    /// <include file='COAUTHIDENTITY.xml' path='doc/member[@name="COAUTHIDENTITY.User"]/*'/>
    public ushort* User;
    /// <include file='COAUTHIDENTITY.xml' path='doc/member[@name="COAUTHIDENTITY.UserLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint UserLength;
    /// <include file='COAUTHIDENTITY.xml' path='doc/member[@name="COAUTHIDENTITY.Domain"]/*'/>
    public ushort* Domain;
    /// <include file='COAUTHIDENTITY.xml' path='doc/member[@name="COAUTHIDENTITY.DomainLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint DomainLength;
    /// <include file='COAUTHIDENTITY.xml' path='doc/member[@name="COAUTHIDENTITY.Password"]/*'/>
    public ushort* Password;
    /// <include file='COAUTHIDENTITY.xml' path='doc/member[@name="COAUTHIDENTITY.PasswordLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint PasswordLength;
    /// <include file='COAUTHIDENTITY.xml' path='doc/member[@name="COAUTHIDENTITY.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
}