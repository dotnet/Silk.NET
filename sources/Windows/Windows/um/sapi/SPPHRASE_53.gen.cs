// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPPHRASE_53.xml' path='doc/member[@name="SPPHRASE_53"]/*' />
[NativeTypeName("struct SPPHRASE_53 : SPPHRASE_50")]
[NativeInheritance("SPPHRASE_50")]
public unsafe partial struct SPPHRASE_53
{
    public SPPHRASE_50 Base;

    /// <include file='SPPHRASE_53.xml' path='doc/member[@name="SPPHRASE_53.pSML"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pSML;

    /// <include file='SPPHRASE_53.xml' path='doc/member[@name="SPPHRASE_53.pSemanticErrorInfo"]/*' />
    public SPSEMANTICERRORINFO* pSemanticErrorInfo;
}
