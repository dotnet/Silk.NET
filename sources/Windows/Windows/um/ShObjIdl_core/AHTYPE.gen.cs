// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AHTYPE.xml' path='doc/member[@name="AHTYPE"]/*'/>
public enum AHTYPE
{
    /// <include file='AHTYPE.xml' path='doc/member[@name="AHTYPE.AHTYPE_UNDEFINED"]/*'/>
    AHTYPE_UNDEFINED = 0,
    /// <include file='AHTYPE.xml' path='doc/member[@name="AHTYPE.AHTYPE_USER_APPLICATION"]/*'/>
    AHTYPE_USER_APPLICATION = 0x8,
    /// <include file='AHTYPE.xml' path='doc/member[@name="AHTYPE.AHTYPE_ANY_APPLICATION"]/*'/>
    AHTYPE_ANY_APPLICATION = 0x10,
    /// <include file='AHTYPE.xml' path='doc/member[@name="AHTYPE.AHTYPE_MACHINEDEFAULT"]/*'/>
    AHTYPE_MACHINEDEFAULT = 0x20,
    /// <include file='AHTYPE.xml' path='doc/member[@name="AHTYPE.AHTYPE_PROGID"]/*'/>
    AHTYPE_PROGID = 0x40,
    /// <include file='AHTYPE.xml' path='doc/member[@name="AHTYPE.AHTYPE_APPLICATION"]/*'/>
    AHTYPE_APPLICATION = 0x80,
    /// <include file='AHTYPE.xml' path='doc/member[@name="AHTYPE.AHTYPE_CLASS_APPLICATION"]/*'/>
    AHTYPE_CLASS_APPLICATION = 0x100,
    /// <include file='AHTYPE.xml' path='doc/member[@name="AHTYPE.AHTYPE_ANY_PROGID"]/*'/>
    AHTYPE_ANY_PROGID = 0x200,
}