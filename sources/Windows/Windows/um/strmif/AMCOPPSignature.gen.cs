// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AMCOPPSignature.xml' path='doc/member[@name="AMCOPPSignature"]/*' />
public unsafe partial struct AMCOPPSignature
{
    /// <include file='AMCOPPSignature.xml' path='doc/member[@name="AMCOPPSignature.Signature"]/*' />
    [NativeTypeName("BYTE[256]")]
    public fixed byte Signature[256];
}
