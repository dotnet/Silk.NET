// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='NSTCITEMSTATE.xml' path='doc/member[@name="NSTCITEMSTATE"]/*'/>
[Flags]
public enum NSTCITEMSTATE
{
    /// <include file='NSTCITEMSTATE.xml' path='doc/member[@name="NSTCITEMSTATE.NSTCIS_NONE"]/*'/>
    NSTCIS_NONE = 0,
    /// <include file='NSTCITEMSTATE.xml' path='doc/member[@name="NSTCITEMSTATE.NSTCIS_SELECTED"]/*'/>
    NSTCIS_SELECTED = 0x1,
    /// <include file='NSTCITEMSTATE.xml' path='doc/member[@name="NSTCITEMSTATE.NSTCIS_EXPANDED"]/*'/>
    NSTCIS_EXPANDED = 0x2,
    /// <include file='NSTCITEMSTATE.xml' path='doc/member[@name="NSTCITEMSTATE.NSTCIS_BOLD"]/*'/>
    NSTCIS_BOLD = 0x4,
    /// <include file='NSTCITEMSTATE.xml' path='doc/member[@name="NSTCITEMSTATE.NSTCIS_DISABLED"]/*'/>
    NSTCIS_DISABLED = 0x8,
    /// <include file='NSTCITEMSTATE.xml' path='doc/member[@name="NSTCITEMSTATE.NSTCIS_SELECTEDNOEXPAND"]/*'/>
    NSTCIS_SELECTEDNOEXPAND = 0x10,
}