// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='tagSMINFOFLAGS.xml' path='doc/member[@name="tagSMINFOFLAGS"]/*'/>
[Flags]
public enum tagSMINFOFLAGS
{
    /// <include file='tagSMINFOFLAGS.xml' path='doc/member[@name="tagSMINFOFLAGS.SMIF_ICON"]/*'/>
    SMIF_ICON = 0x1,
    /// <include file='tagSMINFOFLAGS.xml' path='doc/member[@name="tagSMINFOFLAGS.SMIF_ACCELERATOR"]/*'/>
    SMIF_ACCELERATOR = 0x2,
    /// <include file='tagSMINFOFLAGS.xml' path='doc/member[@name="tagSMINFOFLAGS.SMIF_DROPTARGET"]/*'/>
    SMIF_DROPTARGET = 0x4,
    /// <include file='tagSMINFOFLAGS.xml' path='doc/member[@name="tagSMINFOFLAGS.SMIF_SUBMENU"]/*'/>
    SMIF_SUBMENU = 0x8,
    /// <include file='tagSMINFOFLAGS.xml' path='doc/member[@name="tagSMINFOFLAGS.SMIF_CHECKED"]/*'/>
    SMIF_CHECKED = 0x20,
    /// <include file='tagSMINFOFLAGS.xml' path='doc/member[@name="tagSMINFOFLAGS.SMIF_DROPCASCADE"]/*'/>
    SMIF_DROPCASCADE = 0x40,
    /// <include file='tagSMINFOFLAGS.xml' path='doc/member[@name="tagSMINFOFLAGS.SMIF_HIDDEN"]/*'/>
    SMIF_HIDDEN = 0x80,
    /// <include file='tagSMINFOFLAGS.xml' path='doc/member[@name="tagSMINFOFLAGS.SMIF_DISABLED"]/*'/>
    SMIF_DISABLED = 0x100,
    /// <include file='tagSMINFOFLAGS.xml' path='doc/member[@name="tagSMINFOFLAGS.SMIF_TRACKPOPUP"]/*'/>
    SMIF_TRACKPOPUP = 0x200,
    /// <include file='tagSMINFOFLAGS.xml' path='doc/member[@name="tagSMINFOFLAGS.SMIF_DEMOTED"]/*'/>
    SMIF_DEMOTED = 0x400,
    /// <include file='tagSMINFOFLAGS.xml' path='doc/member[@name="tagSMINFOFLAGS.SMIF_ALTSTATE"]/*'/>
    SMIF_ALTSTATE = 0x800,
    /// <include file='tagSMINFOFLAGS.xml' path='doc/member[@name="tagSMINFOFLAGS.SMIF_DRAGNDROP"]/*'/>
    SMIF_DRAGNDROP = 0x1000,
    /// <include file='tagSMINFOFLAGS.xml' path='doc/member[@name="tagSMINFOFLAGS.SMIF_NEW"]/*'/>
    SMIF_NEW = 0x2000,
}