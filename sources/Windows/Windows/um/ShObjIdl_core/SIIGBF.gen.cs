// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SIIGBF.xml' path='doc/member[@name="SIIGBF"]/*'/>
public enum SIIGBF
{
    /// <include file='SIIGBF.xml' path='doc/member[@name="SIIGBF.SIIGBF_RESIZETOFIT"]/*'/>
    SIIGBF_RESIZETOFIT = 0,
    /// <include file='SIIGBF.xml' path='doc/member[@name="SIIGBF.SIIGBF_BIGGERSIZEOK"]/*'/>
    SIIGBF_BIGGERSIZEOK = 0x1,
    /// <include file='SIIGBF.xml' path='doc/member[@name="SIIGBF.SIIGBF_MEMORYONLY"]/*'/>
    SIIGBF_MEMORYONLY = 0x2,
    /// <include file='SIIGBF.xml' path='doc/member[@name="SIIGBF.SIIGBF_ICONONLY"]/*'/>
    SIIGBF_ICONONLY = 0x4,
    /// <include file='SIIGBF.xml' path='doc/member[@name="SIIGBF.SIIGBF_THUMBNAILONLY"]/*'/>
    SIIGBF_THUMBNAILONLY = 0x8,
    /// <include file='SIIGBF.xml' path='doc/member[@name="SIIGBF.SIIGBF_INCACHEONLY"]/*'/>
    SIIGBF_INCACHEONLY = 0x10,
    /// <include file='SIIGBF.xml' path='doc/member[@name="SIIGBF.SIIGBF_CROPTOSQUARE"]/*'/>
    SIIGBF_CROPTOSQUARE = 0x20,
    /// <include file='SIIGBF.xml' path='doc/member[@name="SIIGBF.SIIGBF_WIDETHUMBNAILS"]/*'/>
    SIIGBF_WIDETHUMBNAILS = 0x40,
    /// <include file='SIIGBF.xml' path='doc/member[@name="SIIGBF.SIIGBF_ICONBACKGROUND"]/*'/>
    SIIGBF_ICONBACKGROUND = 0x80,
    /// <include file='SIIGBF.xml' path='doc/member[@name="SIIGBF.SIIGBF_SCALEUP"]/*'/>
    SIIGBF_SCALEUP = 0x100,
}