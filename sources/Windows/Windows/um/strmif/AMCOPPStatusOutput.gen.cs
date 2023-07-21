// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='AMCOPPStatusOutput.xml' path='doc/member[@name="AMCOPPStatusOutput"]/*' />
public unsafe partial struct AMCOPPStatusOutput
{
    /// <include file='AMCOPPStatusOutput.xml' path='doc/member[@name="AMCOPPStatusOutput.macKDI"]/*' />
    public Guid macKDI;

    /// <include file='AMCOPPStatusOutput.xml' path='doc/member[@name="AMCOPPStatusOutput.cbSizeData"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSizeData;

    /// <include file='AMCOPPStatusOutput.xml' path='doc/member[@name="AMCOPPStatusOutput.COPPStatus"]/*' />
    [NativeTypeName("BYTE[4076]")]
    public fixed byte COPPStatus[4076];
}
