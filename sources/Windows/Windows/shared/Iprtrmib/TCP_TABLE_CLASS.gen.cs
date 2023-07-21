// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TCP_TABLE_CLASS.xml' path='doc/member[@name="TCP_TABLE_CLASS"]/*' />
public enum TCP_TABLE_CLASS
{
    /// <include file='TCP_TABLE_CLASS.xml' path='doc/member[@name="TCP_TABLE_CLASS.TCP_TABLE_BASIC_LISTENER"]/*' />
    TCP_TABLE_BASIC_LISTENER,

    /// <include file='TCP_TABLE_CLASS.xml' path='doc/member[@name="TCP_TABLE_CLASS.TCP_TABLE_BASIC_CONNECTIONS"]/*' />
    TCP_TABLE_BASIC_CONNECTIONS,

    /// <include file='TCP_TABLE_CLASS.xml' path='doc/member[@name="TCP_TABLE_CLASS.TCP_TABLE_BASIC_ALL"]/*' />
    TCP_TABLE_BASIC_ALL,

    /// <include file='TCP_TABLE_CLASS.xml' path='doc/member[@name="TCP_TABLE_CLASS.TCP_TABLE_OWNER_PID_LISTENER"]/*' />
    TCP_TABLE_OWNER_PID_LISTENER,

    /// <include file='TCP_TABLE_CLASS.xml' path='doc/member[@name="TCP_TABLE_CLASS.TCP_TABLE_OWNER_PID_CONNECTIONS"]/*' />
    TCP_TABLE_OWNER_PID_CONNECTIONS,

    /// <include file='TCP_TABLE_CLASS.xml' path='doc/member[@name="TCP_TABLE_CLASS.TCP_TABLE_OWNER_PID_ALL"]/*' />
    TCP_TABLE_OWNER_PID_ALL,

    /// <include file='TCP_TABLE_CLASS.xml' path='doc/member[@name="TCP_TABLE_CLASS.TCP_TABLE_OWNER_MODULE_LISTENER"]/*' />
    TCP_TABLE_OWNER_MODULE_LISTENER,

    /// <include file='TCP_TABLE_CLASS.xml' path='doc/member[@name="TCP_TABLE_CLASS.TCP_TABLE_OWNER_MODULE_CONNECTIONS"]/*' />
    TCP_TABLE_OWNER_MODULE_CONNECTIONS,

    /// <include file='TCP_TABLE_CLASS.xml' path='doc/member[@name="TCP_TABLE_CLASS.TCP_TABLE_OWNER_MODULE_ALL"]/*' />
    TCP_TABLE_OWNER_MODULE_ALL,
}
