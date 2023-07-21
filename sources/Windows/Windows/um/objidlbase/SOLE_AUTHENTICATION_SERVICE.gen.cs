// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SOLE_AUTHENTICATION_SERVICE.xml' path='doc/member[@name="SOLE_AUTHENTICATION_SERVICE"]/*' />
public unsafe partial struct SOLE_AUTHENTICATION_SERVICE
{
    /// <include file='SOLE_AUTHENTICATION_SERVICE.xml' path='doc/member[@name="SOLE_AUTHENTICATION_SERVICE.dwAuthnSvc"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAuthnSvc;

    /// <include file='SOLE_AUTHENTICATION_SERVICE.xml' path='doc/member[@name="SOLE_AUTHENTICATION_SERVICE.dwAuthzSvc"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAuthzSvc;

    /// <include file='SOLE_AUTHENTICATION_SERVICE.xml' path='doc/member[@name="SOLE_AUTHENTICATION_SERVICE.pPrincipalName"]/*' />
    [NativeTypeName("OLECHAR *")]
    public ushort* pPrincipalName;

    /// <include file='SOLE_AUTHENTICATION_SERVICE.xml' path='doc/member[@name="SOLE_AUTHENTICATION_SERVICE.hr"]/*' />
    public HRESULT hr;
}
