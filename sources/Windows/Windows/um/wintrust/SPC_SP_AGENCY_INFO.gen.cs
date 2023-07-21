// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPC_SP_AGENCY_INFO.xml' path='doc/member[@name="SPC_SP_AGENCY_INFO"]/*' />
public unsafe partial struct SPC_SP_AGENCY_INFO
{
    /// <include file='SPC_SP_AGENCY_INFO.xml' path='doc/member[@name="SPC_SP_AGENCY_INFO.pPolicyInformation"]/*' />
    [NativeTypeName("struct SPC_LINK_ *")]
    public SPC_LINK* pPolicyInformation;

    /// <include file='SPC_SP_AGENCY_INFO.xml' path='doc/member[@name="SPC_SP_AGENCY_INFO.pwszPolicyDisplayText"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pwszPolicyDisplayText;

    /// <include file='SPC_SP_AGENCY_INFO.xml' path='doc/member[@name="SPC_SP_AGENCY_INFO.pLogoImage"]/*' />
    [NativeTypeName("PSPC_IMAGE")]
    public SPC_IMAGE* pLogoImage;

    /// <include file='SPC_SP_AGENCY_INFO.xml' path='doc/member[@name="SPC_SP_AGENCY_INFO.pLogoLink"]/*' />
    [NativeTypeName("struct SPC_LINK_ *")]
    public SPC_LINK* pLogoLink;
}
