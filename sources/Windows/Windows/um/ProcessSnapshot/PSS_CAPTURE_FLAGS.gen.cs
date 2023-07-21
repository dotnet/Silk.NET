// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS"]/*' />
[Flags]
[SupportedOSPlatform("windows6.3")]
public enum PSS_CAPTURE_FLAGS
{
    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CAPTURE_NONE"]/*' />
    PSS_CAPTURE_NONE = 0x00000000,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CAPTURE_VA_CLONE"]/*' />
    PSS_CAPTURE_VA_CLONE = 0x00000001,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CAPTURE_RESERVED_00000002"]/*' />
    PSS_CAPTURE_RESERVED_00000002 = 0x00000002,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CAPTURE_HANDLES"]/*' />
    PSS_CAPTURE_HANDLES = 0x00000004,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CAPTURE_HANDLE_NAME_INFORMATION"]/*' />
    PSS_CAPTURE_HANDLE_NAME_INFORMATION = 0x00000008,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CAPTURE_HANDLE_BASIC_INFORMATION"]/*' />
    PSS_CAPTURE_HANDLE_BASIC_INFORMATION = 0x00000010,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CAPTURE_HANDLE_TYPE_SPECIFIC_INFORMATION"]/*' />
    PSS_CAPTURE_HANDLE_TYPE_SPECIFIC_INFORMATION = 0x00000020,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CAPTURE_HANDLE_TRACE"]/*' />
    PSS_CAPTURE_HANDLE_TRACE = 0x00000040,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CAPTURE_THREADS"]/*' />
    PSS_CAPTURE_THREADS = 0x00000080,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CAPTURE_THREAD_CONTEXT"]/*' />
    PSS_CAPTURE_THREAD_CONTEXT = 0x00000100,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CAPTURE_THREAD_CONTEXT_EXTENDED"]/*' />
    PSS_CAPTURE_THREAD_CONTEXT_EXTENDED = 0x00000200,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CAPTURE_RESERVED_00000400"]/*' />
    PSS_CAPTURE_RESERVED_00000400 = 0x00000400,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CAPTURE_VA_SPACE"]/*' />
    PSS_CAPTURE_VA_SPACE = 0x00000800,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CAPTURE_VA_SPACE_SECTION_INFORMATION"]/*' />
    PSS_CAPTURE_VA_SPACE_SECTION_INFORMATION = 0x00001000,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CAPTURE_IPT_TRACE"]/*' />
    PSS_CAPTURE_IPT_TRACE = 0x00002000,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CAPTURE_RESERVED_00004000"]/*' />
    PSS_CAPTURE_RESERVED_00004000 = 0x00004000,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CREATE_BREAKAWAY_OPTIONAL"]/*' />
    PSS_CREATE_BREAKAWAY_OPTIONAL = 0x04000000,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CREATE_BREAKAWAY"]/*' />
    PSS_CREATE_BREAKAWAY = 0x08000000,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CREATE_FORCE_BREAKAWAY"]/*' />
    PSS_CREATE_FORCE_BREAKAWAY = 0x10000000,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CREATE_USE_VM_ALLOCATIONS"]/*' />
    PSS_CREATE_USE_VM_ALLOCATIONS = 0x20000000,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CREATE_MEASURE_PERFORMANCE"]/*' />
    PSS_CREATE_MEASURE_PERFORMANCE = 0x40000000,

    /// <include file='PSS_CAPTURE_FLAGS.xml' path='doc/member[@name="PSS_CAPTURE_FLAGS.PSS_CREATE_RELEASE_SECTION"]/*' />
    PSS_CREATE_RELEASE_SECTION = unchecked((int)(0x80000000)),
}
