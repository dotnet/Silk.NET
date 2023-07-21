// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='WS_FAULT.xml' path='doc/member[@name="WS_FAULT"]/*' />
public unsafe partial struct WS_FAULT
{
    /// <include file='WS_FAULT.xml' path='doc/member[@name="WS_FAULT.code"]/*' />
    public WS_FAULT_CODE* code;

    /// <include file='WS_FAULT.xml' path='doc/member[@name="WS_FAULT.reasons"]/*' />
    public WS_FAULT_REASON* reasons;

    /// <include file='WS_FAULT.xml' path='doc/member[@name="WS_FAULT.reasonCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint reasonCount;

    /// <include file='WS_FAULT.xml' path='doc/member[@name="WS_FAULT.actor"]/*' />
    public WS_STRING actor;

    /// <include file='WS_FAULT.xml' path='doc/member[@name="WS_FAULT.node"]/*' />
    public WS_STRING node;

    /// <include file='WS_FAULT.xml' path='doc/member[@name="WS_FAULT.detail"]/*' />
    [NativeTypeName("WS_XML_BUFFER*")]
    public IntPtr detail;
}
