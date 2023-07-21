// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='PACKAGE_EXECUTION_STATE.xml' path='doc/member[@name="PACKAGE_EXECUTION_STATE"]/*' />
[Flags]
public enum PACKAGE_EXECUTION_STATE
{
    /// <include file='PACKAGE_EXECUTION_STATE.xml' path='doc/member[@name="PACKAGE_EXECUTION_STATE.PES_UNKNOWN"]/*' />
    PES_UNKNOWN = 0,

    /// <include file='PACKAGE_EXECUTION_STATE.xml' path='doc/member[@name="PACKAGE_EXECUTION_STATE.PES_RUNNING"]/*' />
    PES_RUNNING = 1,

    /// <include file='PACKAGE_EXECUTION_STATE.xml' path='doc/member[@name="PACKAGE_EXECUTION_STATE.PES_SUSPENDING"]/*' />
    PES_SUSPENDING = 2,

    /// <include file='PACKAGE_EXECUTION_STATE.xml' path='doc/member[@name="PACKAGE_EXECUTION_STATE.PES_SUSPENDED"]/*' />
    PES_SUSPENDED = 3,

    /// <include file='PACKAGE_EXECUTION_STATE.xml' path='doc/member[@name="PACKAGE_EXECUTION_STATE.PES_TERMINATED"]/*' />
    PES_TERMINATED = 4,
}
