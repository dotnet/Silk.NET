// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='PSS_PROCESS_FLAGS.xml' path='doc/member[@name="PSS_PROCESS_FLAGS"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.3")]
public enum PSS_PROCESS_FLAGS
{
    /// <include file='PSS_PROCESS_FLAGS.xml' path='doc/member[@name="PSS_PROCESS_FLAGS.PSS_PROCESS_FLAGS_NONE"]/*'/>
    PSS_PROCESS_FLAGS_NONE = 0x00000000,
    /// <include file='PSS_PROCESS_FLAGS.xml' path='doc/member[@name="PSS_PROCESS_FLAGS.PSS_PROCESS_FLAGS_PROTECTED"]/*'/>
    PSS_PROCESS_FLAGS_PROTECTED = 0x00000001,
    /// <include file='PSS_PROCESS_FLAGS.xml' path='doc/member[@name="PSS_PROCESS_FLAGS.PSS_PROCESS_FLAGS_WOW64"]/*'/>
    PSS_PROCESS_FLAGS_WOW64 = 0x00000002,
    /// <include file='PSS_PROCESS_FLAGS.xml' path='doc/member[@name="PSS_PROCESS_FLAGS.PSS_PROCESS_FLAGS_RESERVED_03"]/*'/>
    PSS_PROCESS_FLAGS_RESERVED_03 = 0x00000004,
    /// <include file='PSS_PROCESS_FLAGS.xml' path='doc/member[@name="PSS_PROCESS_FLAGS.PSS_PROCESS_FLAGS_RESERVED_04"]/*'/>
    PSS_PROCESS_FLAGS_RESERVED_04 = 0x00000008,
    /// <include file='PSS_PROCESS_FLAGS.xml' path='doc/member[@name="PSS_PROCESS_FLAGS.PSS_PROCESS_FLAGS_FROZEN"]/*'/>
    PSS_PROCESS_FLAGS_FROZEN = 0x00000010,
}