// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='EXPCMDSTATE.xml' path='doc/member[@name="EXPCMDSTATE"]/*'/>
[Flags]
public enum EXPCMDSTATE
{
    /// <include file='EXPCMDSTATE.xml' path='doc/member[@name="EXPCMDSTATE.ECS_ENABLED"]/*'/>
    ECS_ENABLED = 0,
    /// <include file='EXPCMDSTATE.xml' path='doc/member[@name="EXPCMDSTATE.ECS_DISABLED"]/*'/>
    ECS_DISABLED = 0x1,
    /// <include file='EXPCMDSTATE.xml' path='doc/member[@name="EXPCMDSTATE.ECS_HIDDEN"]/*'/>
    ECS_HIDDEN = 0x2,
    /// <include file='EXPCMDSTATE.xml' path='doc/member[@name="EXPCMDSTATE.ECS_CHECKBOX"]/*'/>
    ECS_CHECKBOX = 0x4,
    /// <include file='EXPCMDSTATE.xml' path='doc/member[@name="EXPCMDSTATE.ECS_CHECKED"]/*'/>
    ECS_CHECKED = 0x8,
    /// <include file='EXPCMDSTATE.xml' path='doc/member[@name="EXPCMDSTATE.ECS_RADIOCHECK"]/*'/>
    ECS_RADIOCHECK = 0x10,
}