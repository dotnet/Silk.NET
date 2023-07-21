// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CHANGER_ELEMENT.xml' path='doc/member[@name="CHANGER_ELEMENT"]/*' />
public partial struct CHANGER_ELEMENT
{
    /// <include file='CHANGER_ELEMENT.xml' path='doc/member[@name="CHANGER_ELEMENT.ElementType"]/*' />
    public ELEMENT_TYPE ElementType;

    /// <include file='CHANGER_ELEMENT.xml' path='doc/member[@name="CHANGER_ELEMENT.ElementAddress"]/*' />
    [NativeTypeName("DWORD")]
    public uint ElementAddress;
}
