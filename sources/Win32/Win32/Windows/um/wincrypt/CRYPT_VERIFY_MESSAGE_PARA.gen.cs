// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CRYPT_VERIFY_MESSAGE_PARA
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint dwMsgAndCertEncodingType;
    public HCRYPTPROV_LEGACY hCryptProv;

    [NativeTypeName("PFN_CRYPT_GET_SIGNER_CERTIFICATE")]
    public delegate* unmanaged<
        void*,
        uint,
        CERT_INFO*,
        HCERTSTORE,
        CERT_CONTEXT*> pfnGetSignerCertificate;
    public void* pvGetArg;
}
