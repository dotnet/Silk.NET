// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='PROPERTYUI_FORMAT_FLAGS.xml' path='doc/member[@name="PROPERTYUI_FORMAT_FLAGS"]/*'/>
[Flags]
public enum PROPERTYUI_FORMAT_FLAGS
{
    /// <include file='PROPERTYUI_FORMAT_FLAGS.xml' path='doc/member[@name="PROPERTYUI_FORMAT_FLAGS.PUIFFDF_DEFAULT"]/*'/>
    PUIFFDF_DEFAULT = 0,
    /// <include file='PROPERTYUI_FORMAT_FLAGS.xml' path='doc/member[@name="PROPERTYUI_FORMAT_FLAGS.PUIFFDF_RIGHTTOLEFT"]/*'/>
    PUIFFDF_RIGHTTOLEFT = 0x1,
    /// <include file='PROPERTYUI_FORMAT_FLAGS.xml' path='doc/member[@name="PROPERTYUI_FORMAT_FLAGS.PUIFFDF_SHORTFORMAT"]/*'/>
    PUIFFDF_SHORTFORMAT = 0x2,
    /// <include file='PROPERTYUI_FORMAT_FLAGS.xml' path='doc/member[@name="PROPERTYUI_FORMAT_FLAGS.PUIFFDF_NOTIME"]/*'/>
    PUIFFDF_NOTIME = 0x4,
    /// <include file='PROPERTYUI_FORMAT_FLAGS.xml' path='doc/member[@name="PROPERTYUI_FORMAT_FLAGS.PUIFFDF_FRIENDLYDATE"]/*'/>
    PUIFFDF_FRIENDLYDATE = 0x8,
}