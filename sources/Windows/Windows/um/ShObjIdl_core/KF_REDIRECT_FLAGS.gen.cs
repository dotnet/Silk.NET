// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='KF_REDIRECT_FLAGS.xml' path='doc/member[@name="KF_REDIRECT_FLAGS"]/*'/>
[Flags]
public enum KF_REDIRECT_FLAGS
{
    /// <include file='KF_REDIRECT_FLAGS.xml' path='doc/member[@name="KF_REDIRECT_FLAGS.KF_REDIRECT_USER_EXCLUSIVE"]/*'/>
    KF_REDIRECT_USER_EXCLUSIVE = 0x1,
    /// <include file='KF_REDIRECT_FLAGS.xml' path='doc/member[@name="KF_REDIRECT_FLAGS.KF_REDIRECT_COPY_SOURCE_DACL"]/*'/>
    KF_REDIRECT_COPY_SOURCE_DACL = 0x2,
    /// <include file='KF_REDIRECT_FLAGS.xml' path='doc/member[@name="KF_REDIRECT_FLAGS.KF_REDIRECT_OWNER_USER"]/*'/>
    KF_REDIRECT_OWNER_USER = 0x4,
    /// <include file='KF_REDIRECT_FLAGS.xml' path='doc/member[@name="KF_REDIRECT_FLAGS.KF_REDIRECT_SET_OWNER_EXPLICIT"]/*'/>
    KF_REDIRECT_SET_OWNER_EXPLICIT = 0x8,
    /// <include file='KF_REDIRECT_FLAGS.xml' path='doc/member[@name="KF_REDIRECT_FLAGS.KF_REDIRECT_CHECK_ONLY"]/*'/>
    KF_REDIRECT_CHECK_ONLY = 0x10,
    /// <include file='KF_REDIRECT_FLAGS.xml' path='doc/member[@name="KF_REDIRECT_FLAGS.KF_REDIRECT_WITH_UI"]/*'/>
    KF_REDIRECT_WITH_UI = 0x20,
    /// <include file='KF_REDIRECT_FLAGS.xml' path='doc/member[@name="KF_REDIRECT_FLAGS.KF_REDIRECT_UNPIN"]/*'/>
    KF_REDIRECT_UNPIN = 0x40,
    /// <include file='KF_REDIRECT_FLAGS.xml' path='doc/member[@name="KF_REDIRECT_FLAGS.KF_REDIRECT_PIN"]/*'/>
    KF_REDIRECT_PIN = 0x80,
    /// <include file='KF_REDIRECT_FLAGS.xml' path='doc/member[@name="KF_REDIRECT_FLAGS.KF_REDIRECT_COPY_CONTENTS"]/*'/>
    KF_REDIRECT_COPY_CONTENTS = 0x200,
    /// <include file='KF_REDIRECT_FLAGS.xml' path='doc/member[@name="KF_REDIRECT_FLAGS.KF_REDIRECT_DEL_SOURCE_CONTENTS"]/*'/>
    KF_REDIRECT_DEL_SOURCE_CONTENTS = 0x400,
    /// <include file='KF_REDIRECT_FLAGS.xml' path='doc/member[@name="KF_REDIRECT_FLAGS.KF_REDIRECT_EXCLUDE_ALL_KNOWN_SUBFOLDERS"]/*'/>
    KF_REDIRECT_EXCLUDE_ALL_KNOWN_SUBFOLDERS = 0x800,
}