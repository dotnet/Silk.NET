// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPT_PROVIDER_FUNCTIONS.xml' path='doc/member[@name="CRYPT_PROVIDER_FUNCTIONS"]/*' />
public unsafe partial struct CRYPT_PROVIDER_FUNCTIONS
{
    /// <include file='CRYPT_PROVIDER_FUNCTIONS.xml' path='doc/member[@name="CRYPT_PROVIDER_FUNCTIONS.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='CRYPT_PROVIDER_FUNCTIONS.xml' path='doc/member[@name="CRYPT_PROVIDER_FUNCTIONS.pfnAlloc"]/*' />
    [NativeTypeName("PFN_CPD_MEM_ALLOC")]
    public delegate* unmanaged<uint, void*> pfnAlloc;

    /// <include file='CRYPT_PROVIDER_FUNCTIONS.xml' path='doc/member[@name="CRYPT_PROVIDER_FUNCTIONS.pfnFree"]/*' />
    [NativeTypeName("PFN_CPD_MEM_FREE")]
    public delegate* unmanaged<void*, void> pfnFree;

    /// <include file='CRYPT_PROVIDER_FUNCTIONS.xml' path='doc/member[@name="CRYPT_PROVIDER_FUNCTIONS.pfnAddStore2Chain"]/*' />
    [NativeTypeName("PFN_CPD_ADD_STORE")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, HCERTSTORE, BOOL> pfnAddStore2Chain;

    /// <include file='CRYPT_PROVIDER_FUNCTIONS.xml' path='doc/member[@name="CRYPT_PROVIDER_FUNCTIONS.pfnAddSgnr2Chain"]/*' />
    [NativeTypeName("PFN_CPD_ADD_SGNR")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, BOOL, uint, CRYPT_PROVIDER_SGNR*, BOOL> pfnAddSgnr2Chain;

    /// <include file='CRYPT_PROVIDER_FUNCTIONS.xml' path='doc/member[@name="CRYPT_PROVIDER_FUNCTIONS.pfnAddCert2Chain"]/*' />
    [NativeTypeName("PFN_CPD_ADD_CERT")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, uint, BOOL, uint, CERT_CONTEXT*, BOOL> pfnAddCert2Chain;

    /// <include file='CRYPT_PROVIDER_FUNCTIONS.xml' path='doc/member[@name="CRYPT_PROVIDER_FUNCTIONS.pfnAddPrivData2Chain"]/*' />
    [NativeTypeName("PFN_CPD_ADD_PRIVDATA")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, CRYPT_PROVIDER_PRIVDATA*, BOOL> pfnAddPrivData2Chain;

    /// <include file='CRYPT_PROVIDER_FUNCTIONS.xml' path='doc/member[@name="CRYPT_PROVIDER_FUNCTIONS.pfnInitialize"]/*' />
    [NativeTypeName("PFN_PROVIDER_INIT_CALL")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, HRESULT> pfnInitialize;

    /// <include file='CRYPT_PROVIDER_FUNCTIONS.xml' path='doc/member[@name="CRYPT_PROVIDER_FUNCTIONS.pfnObjectTrust"]/*' />
    [NativeTypeName("PFN_PROVIDER_OBJTRUST_CALL")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, HRESULT> pfnObjectTrust;

    /// <include file='CRYPT_PROVIDER_FUNCTIONS.xml' path='doc/member[@name="CRYPT_PROVIDER_FUNCTIONS.pfnSignatureTrust"]/*' />
    [NativeTypeName("PFN_PROVIDER_SIGTRUST_CALL")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, HRESULT> pfnSignatureTrust;

    /// <include file='CRYPT_PROVIDER_FUNCTIONS.xml' path='doc/member[@name="CRYPT_PROVIDER_FUNCTIONS.pfnCertificateTrust"]/*' />
    [NativeTypeName("PFN_PROVIDER_CERTTRUST_CALL")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, HRESULT> pfnCertificateTrust;

    /// <include file='CRYPT_PROVIDER_FUNCTIONS.xml' path='doc/member[@name="CRYPT_PROVIDER_FUNCTIONS.pfnFinalPolicy"]/*' />
    [NativeTypeName("PFN_PROVIDER_FINALPOLICY_CALL")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, HRESULT> pfnFinalPolicy;

    /// <include file='CRYPT_PROVIDER_FUNCTIONS.xml' path='doc/member[@name="CRYPT_PROVIDER_FUNCTIONS.pfnCertCheckPolicy"]/*' />
    [NativeTypeName("PFN_PROVIDER_CERTCHKPOLICY_CALL")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, uint, BOOL, uint, BOOL> pfnCertCheckPolicy;

    /// <include file='CRYPT_PROVIDER_FUNCTIONS.xml' path='doc/member[@name="CRYPT_PROVIDER_FUNCTIONS.pfnTestFinalPolicy"]/*' />
    [NativeTypeName("PFN_PROVIDER_TESTFINALPOLICY_CALL")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, HRESULT> pfnTestFinalPolicy;

    /// <include file='CRYPT_PROVIDER_FUNCTIONS.xml' path='doc/member[@name="CRYPT_PROVIDER_FUNCTIONS.psUIpfns"]/*' />
    [NativeTypeName("struct _CRYPT_PROVUI_FUNCS *")]
    public CRYPT_PROVUI_FUNCS* psUIpfns;

    /// <include file='CRYPT_PROVIDER_FUNCTIONS.xml' path='doc/member[@name="CRYPT_PROVIDER_FUNCTIONS.pfnCleanupPolicy"]/*' />
    [NativeTypeName("PFN_PROVIDER_CLEANUP_CALL")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, HRESULT> pfnCleanupPolicy;
}
