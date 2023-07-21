// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BP_BUFFERFORMAT.xml' path='doc/member[@name="BP_BUFFERFORMAT"]/*' />
public enum BP_BUFFERFORMAT
{
    /// <include file='BP_BUFFERFORMAT.xml' path='doc/member[@name="BP_BUFFERFORMAT.BPBF_COMPATIBLEBITMAP"]/*' />
    BPBF_COMPATIBLEBITMAP,

    /// <include file='BP_BUFFERFORMAT.xml' path='doc/member[@name="BP_BUFFERFORMAT.BPBF_DIB"]/*' />
    BPBF_DIB,

    /// <include file='BP_BUFFERFORMAT.xml' path='doc/member[@name="BP_BUFFERFORMAT.BPBF_TOPDOWNDIB"]/*' />
    BPBF_TOPDOWNDIB,

    /// <include file='BP_BUFFERFORMAT.xml' path='doc/member[@name="BP_BUFFERFORMAT.BPBF_TOPDOWNMONODIB"]/*' />
    BPBF_TOPDOWNMONODIB,
}
