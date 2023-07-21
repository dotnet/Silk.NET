// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='COMPATIBILITY_CONTEXT_ELEMENT.xml' path='doc/member[@name="COMPATIBILITY_CONTEXT_ELEMENT"]/*' />
public partial struct COMPATIBILITY_CONTEXT_ELEMENT
{
    /// <include file='COMPATIBILITY_CONTEXT_ELEMENT.xml' path='doc/member[@name="COMPATIBILITY_CONTEXT_ELEMENT.Id"]/*' />
    public Guid Id;

    /// <include file='COMPATIBILITY_CONTEXT_ELEMENT.xml' path='doc/member[@name="COMPATIBILITY_CONTEXT_ELEMENT.Type"]/*' />
    public ACTCTX_COMPATIBILITY_ELEMENT_TYPE Type;

    /// <include file='COMPATIBILITY_CONTEXT_ELEMENT.xml' path='doc/member[@name="COMPATIBILITY_CONTEXT_ELEMENT.MaxVersionTested"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong MaxVersionTested;
}
