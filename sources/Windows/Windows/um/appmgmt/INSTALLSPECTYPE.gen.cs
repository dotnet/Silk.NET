// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmgmt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='INSTALLSPECTYPE.xml' path='doc/member[@name="INSTALLSPECTYPE"]/*'/>
public enum INSTALLSPECTYPE
{
    /// <include file='INSTALLSPECTYPE.xml' path='doc/member[@name="INSTALLSPECTYPE.APPNAME"]/*'/>
    APPNAME = 1,
    /// <include file='INSTALLSPECTYPE.xml' path='doc/member[@name="INSTALLSPECTYPE.FILEEXT"]/*'/>
    FILEEXT,
    /// <include file='INSTALLSPECTYPE.xml' path='doc/member[@name="INSTALLSPECTYPE.PROGID"]/*'/>
    PROGID,
    /// <include file='INSTALLSPECTYPE.xml' path='doc/member[@name="INSTALLSPECTYPE.COMCLASS"]/*'/>
    COMCLASS,
}