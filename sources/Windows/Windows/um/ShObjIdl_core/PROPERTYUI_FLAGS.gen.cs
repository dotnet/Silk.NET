// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='PROPERTYUI_FLAGS.xml' path='doc/member[@name="PROPERTYUI_FLAGS"]/*'/>
[Flags]
public enum PROPERTYUI_FLAGS
{
    /// <include file='PROPERTYUI_FLAGS.xml' path='doc/member[@name="PROPERTYUI_FLAGS.PUIF_DEFAULT"]/*'/>
    PUIF_DEFAULT = 0,
    /// <include file='PROPERTYUI_FLAGS.xml' path='doc/member[@name="PROPERTYUI_FLAGS.PUIF_RIGHTALIGN"]/*'/>
    PUIF_RIGHTALIGN = 0x1,
    /// <include file='PROPERTYUI_FLAGS.xml' path='doc/member[@name="PROPERTYUI_FLAGS.PUIF_NOLABELININFOTIP"]/*'/>
    PUIF_NOLABELININFOTIP = 0x2,
}