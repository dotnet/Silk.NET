// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='AUDIO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="AUDIO_STREAM_CONFIG_CAPS"]/*'/>
public partial struct AUDIO_STREAM_CONFIG_CAPS
{
    /// <include file='AUDIO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="AUDIO_STREAM_CONFIG_CAPS.guid"]/*'/>
    public Guid guid;
    /// <include file='AUDIO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="AUDIO_STREAM_CONFIG_CAPS.MinimumChannels"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MinimumChannels;
    /// <include file='AUDIO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="AUDIO_STREAM_CONFIG_CAPS.MaximumChannels"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MaximumChannels;
    /// <include file='AUDIO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="AUDIO_STREAM_CONFIG_CAPS.ChannelsGranularity"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ChannelsGranularity;
    /// <include file='AUDIO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="AUDIO_STREAM_CONFIG_CAPS.MinimumBitsPerSample"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MinimumBitsPerSample;
    /// <include file='AUDIO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="AUDIO_STREAM_CONFIG_CAPS.MaximumBitsPerSample"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MaximumBitsPerSample;
    /// <include file='AUDIO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="AUDIO_STREAM_CONFIG_CAPS.BitsPerSampleGranularity"]/*'/>
    [NativeTypeName("ULONG")]
    public uint BitsPerSampleGranularity;
    /// <include file='AUDIO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="AUDIO_STREAM_CONFIG_CAPS.MinimumSampleFrequency"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MinimumSampleFrequency;
    /// <include file='AUDIO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="AUDIO_STREAM_CONFIG_CAPS.MaximumSampleFrequency"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MaximumSampleFrequency;
    /// <include file='AUDIO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="AUDIO_STREAM_CONFIG_CAPS.SampleFrequencyGranularity"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SampleFrequencyGranularity;
}