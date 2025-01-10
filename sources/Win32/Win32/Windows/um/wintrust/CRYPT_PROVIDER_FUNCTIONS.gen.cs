// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CRYPT_PROVIDER_FUNCTIONS
{
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    [NativeTypeName("PFN_CPD_MEM_ALLOC")]
    public delegate* unmanaged<uint, void*> pfnAlloc;

    [NativeTypeName("PFN_CPD_MEM_FREE")]
    public delegate* unmanaged<void*, void> pfnFree;

    [NativeTypeName("PFN_CPD_ADD_STORE")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, HCERTSTORE, BOOL> pfnAddStore2Chain;

    [NativeTypeName("PFN_CPD_ADD_SGNR")]
    public delegate* unmanaged<
        CRYPT_PROVIDER_DATA*,
        BOOL,
        uint,
        CRYPT_PROVIDER_SGNR*,
        BOOL> pfnAddSgnr2Chain;

    [NativeTypeName("PFN_CPD_ADD_CERT")]
    public delegate* unmanaged<
        CRYPT_PROVIDER_DATA*,
        uint,
        BOOL,
        uint,
        CERT_CONTEXT*,
        BOOL> pfnAddCert2Chain;

    [NativeTypeName("PFN_CPD_ADD_PRIVDATA")]
    public delegate* unmanaged<
        CRYPT_PROVIDER_DATA*,
        CRYPT_PROVIDER_PRIVDATA*,
        BOOL> pfnAddPrivData2Chain;

    [NativeTypeName("PFN_PROVIDER_INIT_CALL")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, HRESULT> pfnInitialize;

    [NativeTypeName("PFN_PROVIDER_OBJTRUST_CALL")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, HRESULT> pfnObjectTrust;

    [NativeTypeName("PFN_PROVIDER_SIGTRUST_CALL")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, HRESULT> pfnSignatureTrust;

    [NativeTypeName("PFN_PROVIDER_CERTTRUST_CALL")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, HRESULT> pfnCertificateTrust;

    [NativeTypeName("PFN_PROVIDER_FINALPOLICY_CALL")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, HRESULT> pfnFinalPolicy;

    [NativeTypeName("PFN_PROVIDER_CERTCHKPOLICY_CALL")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, uint, BOOL, uint, BOOL> pfnCertCheckPolicy;

    [NativeTypeName("PFN_PROVIDER_TESTFINALPOLICY_CALL")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, HRESULT> pfnTestFinalPolicy;

    [NativeTypeName("struct _CRYPT_PROVUI_FUNCS *")]
    public CRYPT_PROVUI_FUNCS* psUIpfns;

    [NativeTypeName("PFN_PROVIDER_CLEANUP_CALL")]
    public delegate* unmanaged<CRYPT_PROVIDER_DATA*, HRESULT> pfnCleanupPolicy;
}
