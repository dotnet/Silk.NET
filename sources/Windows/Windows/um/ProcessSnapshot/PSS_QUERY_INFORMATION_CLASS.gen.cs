// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PSS_QUERY_INFORMATION_CLASS.xml' path='doc/member[@name="PSS_QUERY_INFORMATION_CLASS"]/*' />
[SupportedOSPlatform("windows6.3")]
public enum PSS_QUERY_INFORMATION_CLASS
{
    /// <include file='PSS_QUERY_INFORMATION_CLASS.xml' path='doc/member[@name="PSS_QUERY_INFORMATION_CLASS.PSS_QUERY_PROCESS_INFORMATION"]/*' />
    PSS_QUERY_PROCESS_INFORMATION = 0,

    /// <include file='PSS_QUERY_INFORMATION_CLASS.xml' path='doc/member[@name="PSS_QUERY_INFORMATION_CLASS.PSS_QUERY_VA_CLONE_INFORMATION"]/*' />
    PSS_QUERY_VA_CLONE_INFORMATION = 1,

    /// <include file='PSS_QUERY_INFORMATION_CLASS.xml' path='doc/member[@name="PSS_QUERY_INFORMATION_CLASS.PSS_QUERY_AUXILIARY_PAGES_INFORMATION"]/*' />
    PSS_QUERY_AUXILIARY_PAGES_INFORMATION = 2,

    /// <include file='PSS_QUERY_INFORMATION_CLASS.xml' path='doc/member[@name="PSS_QUERY_INFORMATION_CLASS.PSS_QUERY_VA_SPACE_INFORMATION"]/*' />
    PSS_QUERY_VA_SPACE_INFORMATION = 3,

    /// <include file='PSS_QUERY_INFORMATION_CLASS.xml' path='doc/member[@name="PSS_QUERY_INFORMATION_CLASS.PSS_QUERY_HANDLE_INFORMATION"]/*' />
    PSS_QUERY_HANDLE_INFORMATION = 4,

    /// <include file='PSS_QUERY_INFORMATION_CLASS.xml' path='doc/member[@name="PSS_QUERY_INFORMATION_CLASS.PSS_QUERY_THREAD_INFORMATION"]/*' />
    PSS_QUERY_THREAD_INFORMATION = 5,

    /// <include file='PSS_QUERY_INFORMATION_CLASS.xml' path='doc/member[@name="PSS_QUERY_INFORMATION_CLASS.PSS_QUERY_HANDLE_TRACE_INFORMATION"]/*' />
    PSS_QUERY_HANDLE_TRACE_INFORMATION = 6,

    /// <include file='PSS_QUERY_INFORMATION_CLASS.xml' path='doc/member[@name="PSS_QUERY_INFORMATION_CLASS.PSS_QUERY_PERFORMANCE_COUNTERS"]/*' />
    PSS_QUERY_PERFORMANCE_COUNTERS = 7,
}
