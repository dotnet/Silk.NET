// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct MFNetCredentialManagerGetParam
{
    public HRESULT hrOp;
    public BOOL fAllowLoggedOnUser;
    public BOOL fClearTextPackage;

    [NativeTypeName("LPCWSTR")]
    public ushort* pszUrl;

    [NativeTypeName("LPCWSTR")]
    public ushort* pszSite;

    [NativeTypeName("LPCWSTR")]
    public ushort* pszRealm;

    [NativeTypeName("LPCWSTR")]
    public ushort* pszPackage;

    [NativeTypeName("LONG")]
    public int nRetries;
}
