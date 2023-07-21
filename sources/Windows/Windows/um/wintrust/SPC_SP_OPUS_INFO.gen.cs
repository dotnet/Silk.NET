// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPC_SP_OPUS_INFO.xml' path='doc/member[@name="SPC_SP_OPUS_INFO"]/*' />
public unsafe partial struct SPC_SP_OPUS_INFO
{
    /// <include file='SPC_SP_OPUS_INFO.xml' path='doc/member[@name="SPC_SP_OPUS_INFO.pwszProgramName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pwszProgramName;

    /// <include file='SPC_SP_OPUS_INFO.xml' path='doc/member[@name="SPC_SP_OPUS_INFO.pMoreInfo"]/*' />
    [NativeTypeName("struct SPC_LINK_ *")]
    public SPC_LINK* pMoreInfo;

    /// <include file='SPC_SP_OPUS_INFO.xml' path='doc/member[@name="SPC_SP_OPUS_INFO.pPublisherInfo"]/*' />
    [NativeTypeName("struct SPC_LINK_ *")]
    public SPC_LINK* pPublisherInfo;
}
