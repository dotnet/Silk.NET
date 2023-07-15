// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SOLE_AUTHENTICATION_INFO.xml' path='doc/member[@name="SOLE_AUTHENTICATION_INFO"]/*'/>
public unsafe partial struct SOLE_AUTHENTICATION_INFO
{
    /// <include file='SOLE_AUTHENTICATION_INFO.xml' path='doc/member[@name="SOLE_AUTHENTICATION_INFO.dwAuthnSvc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAuthnSvc;
    /// <include file='SOLE_AUTHENTICATION_INFO.xml' path='doc/member[@name="SOLE_AUTHENTICATION_INFO.dwAuthzSvc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAuthzSvc;
    /// <include file='SOLE_AUTHENTICATION_INFO.xml' path='doc/member[@name="SOLE_AUTHENTICATION_INFO.pAuthInfo"]/*'/>
    public void* pAuthInfo;
}