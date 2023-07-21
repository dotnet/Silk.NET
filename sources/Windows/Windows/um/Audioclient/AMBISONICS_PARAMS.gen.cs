// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AMBISONICS_PARAMS.xml' path='doc/member[@name="AMBISONICS_PARAMS"]/*' />
public unsafe partial struct AMBISONICS_PARAMS
{
    /// <include file='AMBISONICS_PARAMS.xml' path='doc/member[@name="AMBISONICS_PARAMS.u32Size"]/*' />
    [NativeTypeName("UINT32")]
    public uint u32Size;

    /// <include file='AMBISONICS_PARAMS.xml' path='doc/member[@name="AMBISONICS_PARAMS.u32Version"]/*' />
    [NativeTypeName("UINT32")]
    public uint u32Version;

    /// <include file='AMBISONICS_PARAMS.xml' path='doc/member[@name="AMBISONICS_PARAMS.u32Type"]/*' />
    public AMBISONICS_TYPE u32Type;

    /// <include file='AMBISONICS_PARAMS.xml' path='doc/member[@name="AMBISONICS_PARAMS.u32ChannelOrdering"]/*' />
    public AMBISONICS_CHANNEL_ORDERING u32ChannelOrdering;

    /// <include file='AMBISONICS_PARAMS.xml' path='doc/member[@name="AMBISONICS_PARAMS.u32Normalization"]/*' />
    public AMBISONICS_NORMALIZATION u32Normalization;

    /// <include file='AMBISONICS_PARAMS.xml' path='doc/member[@name="AMBISONICS_PARAMS.u32Order"]/*' />
    [NativeTypeName("UINT32")]
    public uint u32Order;

    /// <include file='AMBISONICS_PARAMS.xml' path='doc/member[@name="AMBISONICS_PARAMS.u32NumChannels"]/*' />
    [NativeTypeName("UINT32")]
    public uint u32NumChannels;

    /// <include file='AMBISONICS_PARAMS.xml' path='doc/member[@name="AMBISONICS_PARAMS.pu32ChannelMap"]/*' />
    [NativeTypeName("UINT32 *")]
    public uint* pu32ChannelMap;
}
