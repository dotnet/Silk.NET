// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DROPIMAGETYPE.xml' path='doc/member[@name="DROPIMAGETYPE"]/*'/>
public enum DROPIMAGETYPE
{
    /// <include file='DROPIMAGETYPE.xml' path='doc/member[@name="DROPIMAGETYPE.DROPIMAGE_INVALID"]/*'/>
    DROPIMAGE_INVALID = -1,
    /// <include file='DROPIMAGETYPE.xml' path='doc/member[@name="DROPIMAGETYPE.DROPIMAGE_NONE"]/*'/>
    DROPIMAGE_NONE = 0,
    /// <include file='DROPIMAGETYPE.xml' path='doc/member[@name="DROPIMAGETYPE.DROPIMAGE_COPY"]/*'/>
    DROPIMAGE_COPY = (1),
    /// <include file='DROPIMAGETYPE.xml' path='doc/member[@name="DROPIMAGETYPE.DROPIMAGE_MOVE"]/*'/>
    DROPIMAGE_MOVE = (2),
    /// <include file='DROPIMAGETYPE.xml' path='doc/member[@name="DROPIMAGETYPE.DROPIMAGE_LINK"]/*'/>
    DROPIMAGE_LINK = (4),
    /// <include file='DROPIMAGETYPE.xml' path='doc/member[@name="DROPIMAGETYPE.DROPIMAGE_LABEL"]/*'/>
    DROPIMAGE_LABEL = 6,
    /// <include file='DROPIMAGETYPE.xml' path='doc/member[@name="DROPIMAGETYPE.DROPIMAGE_WARNING"]/*'/>
    DROPIMAGE_WARNING = 7,
    /// <include file='DROPIMAGETYPE.xml' path='doc/member[@name="DROPIMAGETYPE.DROPIMAGE_NOIMAGE"]/*'/>
    DROPIMAGE_NOIMAGE = 8,
}