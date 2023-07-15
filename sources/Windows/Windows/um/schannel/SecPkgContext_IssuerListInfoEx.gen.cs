// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SecPkgContext_IssuerListInfoEx.xml' path='doc/member[@name="SecPkgContext_IssuerListInfoEx"]/*'/>
public unsafe partial struct SecPkgContext_IssuerListInfoEx
{
    /// <include file='SecPkgContext_IssuerListInfoEx.xml' path='doc/member[@name="SecPkgContext_IssuerListInfoEx.aIssuers"]/*'/>
    [NativeTypeName("PCERT_NAME_BLOB")]
    public CRYPT_DATA_BLOB* aIssuers;
    /// <include file='SecPkgContext_IssuerListInfoEx.xml' path='doc/member[@name="SecPkgContext_IssuerListInfoEx.cIssuers"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cIssuers;
}