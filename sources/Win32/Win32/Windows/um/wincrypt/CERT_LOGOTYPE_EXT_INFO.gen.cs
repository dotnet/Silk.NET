// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CERT_LOGOTYPE_EXT_INFO
{
    [NativeTypeName("DWORD")]
    public uint cCommunityLogo;

    [NativeTypeName("PCERT_LOGOTYPE_INFO")]
    public CERT_LOGOTYPE_INFO* rgCommunityLogo;

    [NativeTypeName("PCERT_LOGOTYPE_INFO")]
    public CERT_LOGOTYPE_INFO* pIssuerLogo;

    [NativeTypeName("PCERT_LOGOTYPE_INFO")]
    public CERT_LOGOTYPE_INFO* pSubjectLogo;

    [NativeTypeName("DWORD")]
    public uint cOtherLogo;

    [NativeTypeName("PCERT_OTHER_LOGOTYPE_INFO")]
    public CERT_OTHER_LOGOTYPE_INFO* rgOtherLogo;
}
