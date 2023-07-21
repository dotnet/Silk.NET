// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Gdiplus;

/// <include file='EmfToWmfBitsFlags.xml' path='doc/member[@name="EmfToWmfBitsFlags"]/*' />
[Flags]
public enum EmfToWmfBitsFlags
{
    /// <include file='EmfToWmfBitsFlags.xml' path='doc/member[@name="EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault"]/*' />
    EmfToWmfBitsFlagsDefault = 0x00000000,

    /// <include file='EmfToWmfBitsFlags.xml' path='doc/member[@name="EmfToWmfBitsFlags.EmfToWmfBitsFlagsEmbedEmf"]/*' />
    EmfToWmfBitsFlagsEmbedEmf = 0x00000001,

    /// <include file='EmfToWmfBitsFlags.xml' path='doc/member[@name="EmfToWmfBitsFlags.EmfToWmfBitsFlagsIncludePlaceable"]/*' />
    EmfToWmfBitsFlagsIncludePlaceable = 0x00000002,

    /// <include file='EmfToWmfBitsFlags.xml' path='doc/member[@name="EmfToWmfBitsFlags.EmfToWmfBitsFlagsNoXORClip"]/*' />
    EmfToWmfBitsFlagsNoXORClip = 0x00000004,
}
