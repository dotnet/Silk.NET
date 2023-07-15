// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='EXPLORER_BROWSER_FILL_FLAGS.xml' path='doc/member[@name="EXPLORER_BROWSER_FILL_FLAGS"]/*'/>
[Flags]
public enum EXPLORER_BROWSER_FILL_FLAGS
{
    /// <include file='EXPLORER_BROWSER_FILL_FLAGS.xml' path='doc/member[@name="EXPLORER_BROWSER_FILL_FLAGS.EBF_NONE"]/*'/>
    EBF_NONE = 0,
    /// <include file='EXPLORER_BROWSER_FILL_FLAGS.xml' path='doc/member[@name="EXPLORER_BROWSER_FILL_FLAGS.EBF_SELECTFROMDATAOBJECT"]/*'/>
    EBF_SELECTFROMDATAOBJECT = 0x100,
    /// <include file='EXPLORER_BROWSER_FILL_FLAGS.xml' path='doc/member[@name="EXPLORER_BROWSER_FILL_FLAGS.EBF_NODROPTARGET"]/*'/>
    EBF_NODROPTARGET = 0x200,
}