// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='JOBOBJECT_IO_ATTRIBUTION_CONTROL_FLAGS.xml' path='doc/member[@name="JOBOBJECT_IO_ATTRIBUTION_CONTROL_FLAGS"]/*'/>
[Flags]
public enum JOBOBJECT_IO_ATTRIBUTION_CONTROL_FLAGS
{
    /// <include file='JOBOBJECT_IO_ATTRIBUTION_CONTROL_FLAGS.xml' path='doc/member[@name="JOBOBJECT_IO_ATTRIBUTION_CONTROL_FLAGS.JOBOBJECT_IO_ATTRIBUTION_CONTROL_ENABLE"]/*'/>
    JOBOBJECT_IO_ATTRIBUTION_CONTROL_ENABLE = 0x1,
    /// <include file='JOBOBJECT_IO_ATTRIBUTION_CONTROL_FLAGS.xml' path='doc/member[@name="JOBOBJECT_IO_ATTRIBUTION_CONTROL_FLAGS.JOBOBJECT_IO_ATTRIBUTION_CONTROL_DISABLE"]/*'/>
    JOBOBJECT_IO_ATTRIBUTION_CONTROL_DISABLE = 0x2,
    /// <include file='JOBOBJECT_IO_ATTRIBUTION_CONTROL_FLAGS.xml' path='doc/member[@name="JOBOBJECT_IO_ATTRIBUTION_CONTROL_FLAGS.JOBOBJECT_IO_ATTRIBUTION_CONTROL_VALID_FLAGS"]/*'/>
    JOBOBJECT_IO_ATTRIBUTION_CONTROL_VALID_FLAGS = 0x3,
}