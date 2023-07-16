// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MEDIA_TYPES.xml' path='doc/member[@name="MEDIA_TYPES"]/*'/>
public enum MEDIA_TYPES
{
    /// <include file='MEDIA_TYPES.xml' path='doc/member[@name="MEDIA_TYPES.MEDIA_CDDA_CDROM"]/*'/>
    MEDIA_CDDA_CDROM = 1,
    /// <include file='MEDIA_TYPES.xml' path='doc/member[@name="MEDIA_TYPES.MEDIA_CD_ROM_XA"]/*'/>
    MEDIA_CD_ROM_XA = (MEDIA_CDDA_CDROM + 1),
    /// <include file='MEDIA_TYPES.xml' path='doc/member[@name="MEDIA_TYPES.MEDIA_CD_I"]/*'/>
    MEDIA_CD_I = (MEDIA_CD_ROM_XA + 1),
    /// <include file='MEDIA_TYPES.xml' path='doc/member[@name="MEDIA_TYPES.MEDIA_CD_EXTRA"]/*'/>
    MEDIA_CD_EXTRA = (MEDIA_CD_I + 1),
    /// <include file='MEDIA_TYPES.xml' path='doc/member[@name="MEDIA_TYPES.MEDIA_CD_OTHER"]/*'/>
    MEDIA_CD_OTHER = (MEDIA_CD_EXTRA + 1),
    /// <include file='MEDIA_TYPES.xml' path='doc/member[@name="MEDIA_TYPES.MEDIA_SPECIAL"]/*'/>
    MEDIA_SPECIAL = (MEDIA_CD_OTHER + 1),
}