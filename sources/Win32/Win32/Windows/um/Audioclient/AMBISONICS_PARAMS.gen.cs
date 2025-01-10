// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct AMBISONICS_PARAMS
{
    [NativeTypeName("UINT32")]
    public uint u32Size;

    [NativeTypeName("UINT32")]
    public uint u32Version;
    public AMBISONICS_TYPE u32Type;
    public AMBISONICS_CHANNEL_ORDERING u32ChannelOrdering;
    public AMBISONICS_NORMALIZATION u32Normalization;

    [NativeTypeName("UINT32")]
    public uint u32Order;

    [NativeTypeName("UINT32")]
    public uint u32NumChannels;

    [NativeTypeName("UINT32 *")]
    public uint* pu32ChannelMap;
}
