// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPC_PE_IMAGE_DATA.xml' path='doc/member[@name="SPC_PE_IMAGE_DATA"]/*' />
public unsafe partial struct SPC_PE_IMAGE_DATA
{
    /// <include file='SPC_PE_IMAGE_DATA.xml' path='doc/member[@name="SPC_PE_IMAGE_DATA.Flags"]/*' />
    public CRYPT_BIT_BLOB Flags;

    /// <include file='SPC_PE_IMAGE_DATA.xml' path='doc/member[@name="SPC_PE_IMAGE_DATA.pFile"]/*' />
    [NativeTypeName("PSPC_LINK")]
    public SPC_LINK* pFile;
}
