// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='KF_DEFINITION_FLAGS.xml' path='doc/member[@name="KF_DEFINITION_FLAGS"]/*'/>
[Flags]
public enum KF_DEFINITION_FLAGS
{
    /// <include file='KF_DEFINITION_FLAGS.xml' path='doc/member[@name="KF_DEFINITION_FLAGS.KFDF_LOCAL_REDIRECT_ONLY"]/*'/>
    KFDF_LOCAL_REDIRECT_ONLY = 0x2,
    /// <include file='KF_DEFINITION_FLAGS.xml' path='doc/member[@name="KF_DEFINITION_FLAGS.KFDF_ROAMABLE"]/*'/>
    KFDF_ROAMABLE = 0x4,
    /// <include file='KF_DEFINITION_FLAGS.xml' path='doc/member[@name="KF_DEFINITION_FLAGS.KFDF_PRECREATE"]/*'/>
    KFDF_PRECREATE = 0x8,
    /// <include file='KF_DEFINITION_FLAGS.xml' path='doc/member[@name="KF_DEFINITION_FLAGS.KFDF_STREAM"]/*'/>
    KFDF_STREAM = 0x10,
    /// <include file='KF_DEFINITION_FLAGS.xml' path='doc/member[@name="KF_DEFINITION_FLAGS.KFDF_PUBLISHEXPANDEDPATH"]/*'/>
    KFDF_PUBLISHEXPANDEDPATH = 0x20,
    /// <include file='KF_DEFINITION_FLAGS.xml' path='doc/member[@name="KF_DEFINITION_FLAGS.KFDF_NO_REDIRECT_UI"]/*'/>
    KFDF_NO_REDIRECT_UI = 0x40,
}