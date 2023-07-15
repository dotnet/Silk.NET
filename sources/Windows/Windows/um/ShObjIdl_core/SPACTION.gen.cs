// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPACTION.xml' path='doc/member[@name="SPACTION"]/*'/>
public enum SPACTION
{
    /// <include file='SPACTION.xml' path='doc/member[@name="SPACTION.SPACTION_NONE"]/*'/>
    SPACTION_NONE = 0,
    /// <include file='SPACTION.xml' path='doc/member[@name="SPACTION.SPACTION_MOVING"]/*'/>
    SPACTION_MOVING = (SPACTION_NONE + 1),
    /// <include file='SPACTION.xml' path='doc/member[@name="SPACTION.SPACTION_COPYING"]/*'/>
    SPACTION_COPYING = (SPACTION_MOVING + 1),
    /// <include file='SPACTION.xml' path='doc/member[@name="SPACTION.SPACTION_RECYCLING"]/*'/>
    SPACTION_RECYCLING = (SPACTION_COPYING + 1),
    /// <include file='SPACTION.xml' path='doc/member[@name="SPACTION.SPACTION_APPLYINGATTRIBS"]/*'/>
    SPACTION_APPLYINGATTRIBS = (SPACTION_RECYCLING + 1),
    /// <include file='SPACTION.xml' path='doc/member[@name="SPACTION.SPACTION_DOWNLOADING"]/*'/>
    SPACTION_DOWNLOADING = (SPACTION_APPLYINGATTRIBS + 1),
    /// <include file='SPACTION.xml' path='doc/member[@name="SPACTION.SPACTION_SEARCHING_INTERNET"]/*'/>
    SPACTION_SEARCHING_INTERNET = (SPACTION_DOWNLOADING + 1),
    /// <include file='SPACTION.xml' path='doc/member[@name="SPACTION.SPACTION_CALCULATING"]/*'/>
    SPACTION_CALCULATING = (SPACTION_SEARCHING_INTERNET + 1),
    /// <include file='SPACTION.xml' path='doc/member[@name="SPACTION.SPACTION_UPLOADING"]/*'/>
    SPACTION_UPLOADING = (SPACTION_CALCULATING + 1),
    /// <include file='SPACTION.xml' path='doc/member[@name="SPACTION.SPACTION_SEARCHING_FILES"]/*'/>
    SPACTION_SEARCHING_FILES = (SPACTION_UPLOADING + 1),
    /// <include file='SPACTION.xml' path='doc/member[@name="SPACTION.SPACTION_DELETING"]/*'/>
    SPACTION_DELETING = (SPACTION_SEARCHING_FILES + 1),
    /// <include file='SPACTION.xml' path='doc/member[@name="SPACTION.SPACTION_RENAMING"]/*'/>
    SPACTION_RENAMING = (SPACTION_DELETING + 1),
    /// <include file='SPACTION.xml' path='doc/member[@name="SPACTION.SPACTION_FORMATTING"]/*'/>
    SPACTION_FORMATTING = (SPACTION_RENAMING + 1),
    /// <include file='SPACTION.xml' path='doc/member[@name="SPACTION.SPACTION_COPY_MOVING"]/*'/>
    SPACTION_COPY_MOVING = (SPACTION_FORMATTING + 1),
}