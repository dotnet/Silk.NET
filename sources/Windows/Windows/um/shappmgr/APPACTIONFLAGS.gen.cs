// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='APPACTIONFLAGS.xml' path='doc/member[@name="APPACTIONFLAGS"]/*'/>
public enum APPACTIONFLAGS
{
    /// <include file='APPACTIONFLAGS.xml' path='doc/member[@name="APPACTIONFLAGS.APPACTION_INSTALL"]/*'/>
    APPACTION_INSTALL = 0x1,
    /// <include file='APPACTIONFLAGS.xml' path='doc/member[@name="APPACTIONFLAGS.APPACTION_UNINSTALL"]/*'/>
    APPACTION_UNINSTALL = 0x2,
    /// <include file='APPACTIONFLAGS.xml' path='doc/member[@name="APPACTIONFLAGS.APPACTION_MODIFY"]/*'/>
    APPACTION_MODIFY = 0x4,
    /// <include file='APPACTIONFLAGS.xml' path='doc/member[@name="APPACTIONFLAGS.APPACTION_REPAIR"]/*'/>
    APPACTION_REPAIR = 0x8,
    /// <include file='APPACTIONFLAGS.xml' path='doc/member[@name="APPACTIONFLAGS.APPACTION_UPGRADE"]/*'/>
    APPACTION_UPGRADE = 0x10,
    /// <include file='APPACTIONFLAGS.xml' path='doc/member[@name="APPACTIONFLAGS.APPACTION_CANGETSIZE"]/*'/>
    APPACTION_CANGETSIZE = 0x20,
    /// <include file='APPACTIONFLAGS.xml' path='doc/member[@name="APPACTIONFLAGS.APPACTION_MODIFYREMOVE"]/*'/>
    APPACTION_MODIFYREMOVE = 0x80,
    /// <include file='APPACTIONFLAGS.xml' path='doc/member[@name="APPACTIONFLAGS.APPACTION_ADDLATER"]/*'/>
    APPACTION_ADDLATER = 0x100,
    /// <include file='APPACTIONFLAGS.xml' path='doc/member[@name="APPACTIONFLAGS.APPACTION_UNSCHEDULE"]/*'/>
    APPACTION_UNSCHEDULE = 0x200,
}