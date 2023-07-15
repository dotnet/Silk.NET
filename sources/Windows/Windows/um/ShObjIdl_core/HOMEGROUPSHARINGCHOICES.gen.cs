// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HOMEGROUPSHARINGCHOICES.xml' path='doc/member[@name="HOMEGROUPSHARINGCHOICES"]/*'/>
public enum HOMEGROUPSHARINGCHOICES
{
    /// <include file='HOMEGROUPSHARINGCHOICES.xml' path='doc/member[@name="HOMEGROUPSHARINGCHOICES.HGSC_NONE"]/*'/>
    HGSC_NONE = 0,
    /// <include file='HOMEGROUPSHARINGCHOICES.xml' path='doc/member[@name="HOMEGROUPSHARINGCHOICES.HGSC_MUSICLIBRARY"]/*'/>
    HGSC_MUSICLIBRARY = 0x1,
    /// <include file='HOMEGROUPSHARINGCHOICES.xml' path='doc/member[@name="HOMEGROUPSHARINGCHOICES.HGSC_PICTURESLIBRARY"]/*'/>
    HGSC_PICTURESLIBRARY = 0x2,
    /// <include file='HOMEGROUPSHARINGCHOICES.xml' path='doc/member[@name="HOMEGROUPSHARINGCHOICES.HGSC_VIDEOSLIBRARY"]/*'/>
    HGSC_VIDEOSLIBRARY = 0x4,
    /// <include file='HOMEGROUPSHARINGCHOICES.xml' path='doc/member[@name="HOMEGROUPSHARINGCHOICES.HGSC_DOCUMENTSLIBRARY"]/*'/>
    HGSC_DOCUMENTSLIBRARY = 0x8,
    /// <include file='HOMEGROUPSHARINGCHOICES.xml' path='doc/member[@name="HOMEGROUPSHARINGCHOICES.HGSC_PRINTERS"]/*'/>
    HGSC_PRINTERS = 0x10,
}