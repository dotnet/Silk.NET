// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='VIEWSTATUS.xml' path='doc/member[@name="VIEWSTATUS"]/*'/>
public enum VIEWSTATUS
{
    /// <include file='VIEWSTATUS.xml' path='doc/member[@name="VIEWSTATUS.VIEWSTATUS_OPAQUE"]/*'/>
    VIEWSTATUS_OPAQUE = 1,
    /// <include file='VIEWSTATUS.xml' path='doc/member[@name="VIEWSTATUS.VIEWSTATUS_SOLIDBKGND"]/*'/>
    VIEWSTATUS_SOLIDBKGND = 2,
    /// <include file='VIEWSTATUS.xml' path='doc/member[@name="VIEWSTATUS.VIEWSTATUS_DVASPECTOPAQUE"]/*'/>
    VIEWSTATUS_DVASPECTOPAQUE = 4,
    /// <include file='VIEWSTATUS.xml' path='doc/member[@name="VIEWSTATUS.VIEWSTATUS_DVASPECTTRANSPARENT"]/*'/>
    VIEWSTATUS_DVASPECTTRANSPARENT = 8,
    /// <include file='VIEWSTATUS.xml' path='doc/member[@name="VIEWSTATUS.VIEWSTATUS_SURFACE"]/*'/>
    VIEWSTATUS_SURFACE = 16,
    /// <include file='VIEWSTATUS.xml' path='doc/member[@name="VIEWSTATUS.VIEWSTATUS_3DSURFACE"]/*'/>
    VIEWSTATUS_3DSURFACE = 32,
}