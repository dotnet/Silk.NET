// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WBEM_SHUTDOWN_FLAGS.xml' path='doc/member[@name="WBEM_SHUTDOWN_FLAGS"]/*' />
public enum WBEM_SHUTDOWN_FLAGS
{
    /// <include file='WBEM_SHUTDOWN_FLAGS.xml' path='doc/member[@name="WBEM_SHUTDOWN_FLAGS.WBEM_SHUTDOWN_UNLOAD_COMPONENT"]/*' />
    WBEM_SHUTDOWN_UNLOAD_COMPONENT = 1,

    /// <include file='WBEM_SHUTDOWN_FLAGS.xml' path='doc/member[@name="WBEM_SHUTDOWN_FLAGS.WBEM_SHUTDOWN_WMI"]/*' />
    WBEM_SHUTDOWN_WMI = 2,

    /// <include file='WBEM_SHUTDOWN_FLAGS.xml' path='doc/member[@name="WBEM_SHUTDOWN_FLAGS.WBEM_SHUTDOWN_OS"]/*' />
    WBEM_SHUTDOWN_OS = 3,
}
