// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.WinRT;

/// <include file='MLOperatorSetId.xml' path='doc/member[@name="MLOperatorSetId"]/*' />
public unsafe partial struct MLOperatorSetId
{
    /// <include file='MLOperatorSetId.xml' path='doc/member[@name="MLOperatorSetId.domain"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* domain;

    /// <include file='MLOperatorSetId.xml' path='doc/member[@name="MLOperatorSetId.version"]/*' />
    [NativeTypeName("int32_t")]
    public int version;
}
