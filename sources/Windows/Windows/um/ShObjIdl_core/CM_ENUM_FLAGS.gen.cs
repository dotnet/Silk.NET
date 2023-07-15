// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='CM_ENUM_FLAGS.xml' path='doc/member[@name="CM_ENUM_FLAGS"]/*'/>
[Flags]
public enum CM_ENUM_FLAGS
{
    /// <include file='CM_ENUM_FLAGS.xml' path='doc/member[@name="CM_ENUM_FLAGS.CM_ENUM_ALL"]/*'/>
    CM_ENUM_ALL = 0x1,
    /// <include file='CM_ENUM_FLAGS.xml' path='doc/member[@name="CM_ENUM_FLAGS.CM_ENUM_VISIBLE"]/*'/>
    CM_ENUM_VISIBLE = 0x2,
}