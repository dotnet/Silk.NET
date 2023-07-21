// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SAFEARR_UNKNOWN.xml' path='doc/member[@name="SAFEARR_UNKNOWN"]/*' />
public unsafe partial struct SAFEARR_UNKNOWN
{
    /// <include file='SAFEARR_UNKNOWN.xml' path='doc/member[@name="SAFEARR_UNKNOWN.Size"]/*' />
    [NativeTypeName("ULONG")]
    public uint Size;

    /// <include file='SAFEARR_UNKNOWN.xml' path='doc/member[@name="SAFEARR_UNKNOWN.apUnknown"]/*' />
    public IUnknown** apUnknown;
}
