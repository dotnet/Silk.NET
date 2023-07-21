// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ELEMENT_TYPE.xml' path='doc/member[@name="ELEMENT_TYPE"]/*' />
public enum ELEMENT_TYPE
{
    /// <include file='ELEMENT_TYPE.xml' path='doc/member[@name="ELEMENT_TYPE.AllElements"]/*' />
    AllElements,

    /// <include file='ELEMENT_TYPE.xml' path='doc/member[@name="ELEMENT_TYPE.ChangerTransport"]/*' />
    ChangerTransport,

    /// <include file='ELEMENT_TYPE.xml' path='doc/member[@name="ELEMENT_TYPE.ChangerSlot"]/*' />
    ChangerSlot,

    /// <include file='ELEMENT_TYPE.xml' path='doc/member[@name="ELEMENT_TYPE.ChangerIEPort"]/*' />
    ChangerIEPort,

    /// <include file='ELEMENT_TYPE.xml' path='doc/member[@name="ELEMENT_TYPE.ChangerDrive"]/*' />
    ChangerDrive,

    /// <include file='ELEMENT_TYPE.xml' path='doc/member[@name="ELEMENT_TYPE.ChangerDoor"]/*' />
    ChangerDoor,

    /// <include file='ELEMENT_TYPE.xml' path='doc/member[@name="ELEMENT_TYPE.ChangerKeypad"]/*' />
    ChangerKeypad,

    /// <include file='ELEMENT_TYPE.xml' path='doc/member[@name="ELEMENT_TYPE.ChangerMaxElement"]/*' />
    ChangerMaxElement,
}
