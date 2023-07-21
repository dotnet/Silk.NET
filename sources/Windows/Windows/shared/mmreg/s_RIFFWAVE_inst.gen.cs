// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='s_RIFFWAVE_inst.xml' path='doc/member[@name="s_RIFFWAVE_inst"]/*' />
public partial struct s_RIFFWAVE_inst
{
    /// <include file='s_RIFFWAVE_inst.xml' path='doc/member[@name="s_RIFFWAVE_inst.bUnshiftedNote"]/*' />
    public byte bUnshiftedNote;

    /// <include file='s_RIFFWAVE_inst.xml' path='doc/member[@name="s_RIFFWAVE_inst.chFineTune"]/*' />
    [NativeTypeName("char")]
    public sbyte chFineTune;

    /// <include file='s_RIFFWAVE_inst.xml' path='doc/member[@name="s_RIFFWAVE_inst.chGain"]/*' />
    [NativeTypeName("char")]
    public sbyte chGain;

    /// <include file='s_RIFFWAVE_inst.xml' path='doc/member[@name="s_RIFFWAVE_inst.bLowNote"]/*' />
    public byte bLowNote;

    /// <include file='s_RIFFWAVE_inst.xml' path='doc/member[@name="s_RIFFWAVE_inst.bHighNote"]/*' />
    public byte bHighNote;

    /// <include file='s_RIFFWAVE_inst.xml' path='doc/member[@name="s_RIFFWAVE_inst.bLowVelocity"]/*' />
    public byte bLowVelocity;

    /// <include file='s_RIFFWAVE_inst.xml' path='doc/member[@name="s_RIFFWAVE_inst.bHighVelocity"]/*' />
    public byte bHighVelocity;
}
