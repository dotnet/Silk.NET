// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MACROBLOCK_DATA.xml' path='doc/member[@name="MACROBLOCK_DATA"]/*' />
public partial struct MACROBLOCK_DATA
{
    /// <include file='MACROBLOCK_DATA.xml' path='doc/member[@name="MACROBLOCK_DATA.flags"]/*' />
    [NativeTypeName("UINT32")]
    public uint flags;

    /// <include file='MACROBLOCK_DATA.xml' path='doc/member[@name="MACROBLOCK_DATA.motionVectorX"]/*' />
    [NativeTypeName("INT16")]
    public short motionVectorX;

    /// <include file='MACROBLOCK_DATA.xml' path='doc/member[@name="MACROBLOCK_DATA.motionVectorY"]/*' />
    [NativeTypeName("INT16")]
    public short motionVectorY;

    /// <include file='MACROBLOCK_DATA.xml' path='doc/member[@name="MACROBLOCK_DATA.QPDelta"]/*' />
    [NativeTypeName("INT32")]
    public int QPDelta;
}
