// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IP_MASK_STRING.xml' path='doc/member[@name="IP_MASK_STRING"]/*' />
public unsafe partial struct IP_MASK_STRING
{
    /// <include file='IP_MASK_STRING.xml' path='doc/member[@name="IP_MASK_STRING.String"]/*' />
    [NativeTypeName("char[16]")]
    public fixed sbyte String[16];
}
