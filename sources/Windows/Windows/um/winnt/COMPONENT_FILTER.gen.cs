// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='COMPONENT_FILTER.xml' path='doc/member[@name="COMPONENT_FILTER"]/*' />
public partial struct COMPONENT_FILTER
{
    /// <include file='COMPONENT_FILTER.xml' path='doc/member[@name="COMPONENT_FILTER.ComponentFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint ComponentFlags;
}
