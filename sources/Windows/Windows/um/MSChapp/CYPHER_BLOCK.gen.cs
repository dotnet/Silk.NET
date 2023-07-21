// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSChapp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CYPHER_BLOCK.xml' path='doc/member[@name="CYPHER_BLOCK"]/*' />
public unsafe partial struct CYPHER_BLOCK
{
    /// <include file='CYPHER_BLOCK.xml' path='doc/member[@name="CYPHER_BLOCK.data"]/*' />
    [NativeTypeName("CHAR[8]")]
    public fixed sbyte data[8];
}
