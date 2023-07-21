// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CHANGER_ELEMENT_LIST.xml' path='doc/member[@name="CHANGER_ELEMENT_LIST"]/*' />
public partial struct CHANGER_ELEMENT_LIST
{
    /// <include file='CHANGER_ELEMENT_LIST.xml' path='doc/member[@name="CHANGER_ELEMENT_LIST.Element"]/*' />
    public CHANGER_ELEMENT Element;

    /// <include file='CHANGER_ELEMENT_LIST.xml' path='doc/member[@name="CHANGER_ELEMENT_LIST.NumberOfElements"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfElements;
}
