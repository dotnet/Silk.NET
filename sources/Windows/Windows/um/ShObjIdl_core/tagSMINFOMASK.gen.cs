// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='tagSMINFOMASK.xml' path='doc/member[@name="tagSMINFOMASK"]/*'/>
[Flags]
public enum tagSMINFOMASK
{
    /// <include file='tagSMINFOMASK.xml' path='doc/member[@name="tagSMINFOMASK.SMIM_TYPE"]/*'/>
    SMIM_TYPE = 0x1,
    /// <include file='tagSMINFOMASK.xml' path='doc/member[@name="tagSMINFOMASK.SMIM_FLAGS"]/*'/>
    SMIM_FLAGS = 0x2,
    /// <include file='tagSMINFOMASK.xml' path='doc/member[@name="tagSMINFOMASK.SMIM_ICON"]/*'/>
    SMIM_ICON = 0x4,
}