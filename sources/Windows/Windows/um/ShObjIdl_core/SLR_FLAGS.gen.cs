// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='SLR_FLAGS.xml' path='doc/member[@name="SLR_FLAGS"]/*'/>
[Flags]
public enum SLR_FLAGS
{
    /// <include file='SLR_FLAGS.xml' path='doc/member[@name="SLR_FLAGS.SLR_NONE"]/*'/>
    SLR_NONE = 0,
    /// <include file='SLR_FLAGS.xml' path='doc/member[@name="SLR_FLAGS.SLR_NO_UI"]/*'/>
    SLR_NO_UI = 0x1,
    /// <include file='SLR_FLAGS.xml' path='doc/member[@name="SLR_FLAGS.SLR_ANY_MATCH"]/*'/>
    SLR_ANY_MATCH = 0x2,
    /// <include file='SLR_FLAGS.xml' path='doc/member[@name="SLR_FLAGS.SLR_UPDATE"]/*'/>
    SLR_UPDATE = 0x4,
    /// <include file='SLR_FLAGS.xml' path='doc/member[@name="SLR_FLAGS.SLR_NOUPDATE"]/*'/>
    SLR_NOUPDATE = 0x8,
    /// <include file='SLR_FLAGS.xml' path='doc/member[@name="SLR_FLAGS.SLR_NOSEARCH"]/*'/>
    SLR_NOSEARCH = 0x10,
    /// <include file='SLR_FLAGS.xml' path='doc/member[@name="SLR_FLAGS.SLR_NOTRACK"]/*'/>
    SLR_NOTRACK = 0x20,
    /// <include file='SLR_FLAGS.xml' path='doc/member[@name="SLR_FLAGS.SLR_NOLINKINFO"]/*'/>
    SLR_NOLINKINFO = 0x40,
    /// <include file='SLR_FLAGS.xml' path='doc/member[@name="SLR_FLAGS.SLR_INVOKE_MSI"]/*'/>
    SLR_INVOKE_MSI = 0x80,
    /// <include file='SLR_FLAGS.xml' path='doc/member[@name="SLR_FLAGS.SLR_NO_UI_WITH_MSG_PUMP"]/*'/>
    SLR_NO_UI_WITH_MSG_PUMP = 0x101,
    /// <include file='SLR_FLAGS.xml' path='doc/member[@name="SLR_FLAGS.SLR_OFFER_DELETE_WITHOUT_FILE"]/*'/>
    SLR_OFFER_DELETE_WITHOUT_FILE = 0x200,
    /// <include file='SLR_FLAGS.xml' path='doc/member[@name="SLR_FLAGS.SLR_KNOWNFOLDER"]/*'/>
    SLR_KNOWNFOLDER = 0x400,
    /// <include file='SLR_FLAGS.xml' path='doc/member[@name="SLR_FLAGS.SLR_MACHINE_IN_LOCAL_TARGET"]/*'/>
    SLR_MACHINE_IN_LOCAL_TARGET = 0x800,
    /// <include file='SLR_FLAGS.xml' path='doc/member[@name="SLR_FLAGS.SLR_UPDATE_MACHINE_AND_SID"]/*'/>
    SLR_UPDATE_MACHINE_AND_SID = 0x1000,
    /// <include file='SLR_FLAGS.xml' path='doc/member[@name="SLR_FLAGS.SLR_NO_OBJECT_ID"]/*'/>
    SLR_NO_OBJECT_ID = 0x2000,
}