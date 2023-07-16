// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NSTCECLICKTYPE.xml' path='doc/member[@name="NSTCECLICKTYPE"]/*'/>
public enum NSTCECLICKTYPE
{
    /// <include file='NSTCECLICKTYPE.xml' path='doc/member[@name="NSTCECLICKTYPE.NSTCECT_LBUTTON"]/*'/>
    NSTCECT_LBUTTON = 0x1,
    /// <include file='NSTCECLICKTYPE.xml' path='doc/member[@name="NSTCECLICKTYPE.NSTCECT_MBUTTON"]/*'/>
    NSTCECT_MBUTTON = 0x2,
    /// <include file='NSTCECLICKTYPE.xml' path='doc/member[@name="NSTCECLICKTYPE.NSTCECT_RBUTTON"]/*'/>
    NSTCECT_RBUTTON = 0x3,
    /// <include file='NSTCECLICKTYPE.xml' path='doc/member[@name="NSTCECLICKTYPE.NSTCECT_BUTTON"]/*'/>
    NSTCECT_BUTTON = 0x3,
    /// <include file='NSTCECLICKTYPE.xml' path='doc/member[@name="NSTCECLICKTYPE.NSTCECT_DBLCLICK"]/*'/>
    NSTCECT_DBLCLICK = 0x4,
}