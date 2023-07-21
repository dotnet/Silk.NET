// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPPHRASE.xml' path='doc/member[@name="SPPHRASE"]/*' />
[NativeTypeName("struct SPPHRASE : SPPHRASE_53")]
[NativeInheritance("SPPHRASE_53")]
public partial struct SPPHRASE
{
    public SPPHRASE_53 Base;

    /// <include file='SPPHRASE.xml' path='doc/member[@name="SPPHRASE.SemanticTagFormat"]/*' />
    public SPSEMANTICFORMAT SemanticTagFormat;
}
