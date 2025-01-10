// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct MFP_ACQUIRE_USER_CREDENTIAL_EVENT
{
    public MFP_EVENT_HEADER header;

    [NativeTypeName("DWORD_PTR")]
    public nuint dwUserData;
    public BOOL fProceedWithAuthentication;
    public HRESULT hrAuthenticationStatus;

    [NativeTypeName("LPCWSTR")]
    public ushort* pwszURL;

    [NativeTypeName("LPCWSTR")]
    public ushort* pwszSite;

    [NativeTypeName("LPCWSTR")]
    public ushort* pwszRealm;

    [NativeTypeName("LPCWSTR")]
    public ushort* pwszPackage;

    [NativeTypeName("LONG")]
    public int nRetries;

    [NativeTypeName("MFP_CREDENTIAL_FLAGS")]
    public uint flags;
    public IMFNetCredential pCredential;
}
