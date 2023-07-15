// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='PROPERTYUI_NAME_FLAGS.xml' path='doc/member[@name="PROPERTYUI_NAME_FLAGS"]/*'/>
[Flags]
public enum PROPERTYUI_NAME_FLAGS
{
    /// <include file='PROPERTYUI_NAME_FLAGS.xml' path='doc/member[@name="PROPERTYUI_NAME_FLAGS.PUIFNF_DEFAULT"]/*'/>
    PUIFNF_DEFAULT = 0,
    /// <include file='PROPERTYUI_NAME_FLAGS.xml' path='doc/member[@name="PROPERTYUI_NAME_FLAGS.PUIFNF_MNEMONIC"]/*'/>
    PUIFNF_MNEMONIC = 0x1,
}