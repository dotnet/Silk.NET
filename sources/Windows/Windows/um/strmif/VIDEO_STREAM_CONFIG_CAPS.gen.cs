// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS"]/*'/>
public partial struct VIDEO_STREAM_CONFIG_CAPS
{
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.guid"]/*'/>
    public Guid guid;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.VideoStandard"]/*'/>
    [NativeTypeName("ULONG")]
    public uint VideoStandard;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.InputSize"]/*'/>
    public SIZE InputSize;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.MinCroppingSize"]/*'/>
    public SIZE MinCroppingSize;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.MaxCroppingSize"]/*'/>
    public SIZE MaxCroppingSize;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.CropGranularityX"]/*'/>
    public int CropGranularityX;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.CropGranularityY"]/*'/>
    public int CropGranularityY;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.CropAlignX"]/*'/>
    public int CropAlignX;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.CropAlignY"]/*'/>
    public int CropAlignY;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.MinOutputSize"]/*'/>
    public SIZE MinOutputSize;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.MaxOutputSize"]/*'/>
    public SIZE MaxOutputSize;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.OutputGranularityX"]/*'/>
    public int OutputGranularityX;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.OutputGranularityY"]/*'/>
    public int OutputGranularityY;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.StretchTapsX"]/*'/>
    public int StretchTapsX;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.StretchTapsY"]/*'/>
    public int StretchTapsY;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.ShrinkTapsX"]/*'/>
    public int ShrinkTapsX;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.ShrinkTapsY"]/*'/>
    public int ShrinkTapsY;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.MinFrameInterval"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long MinFrameInterval;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.MaxFrameInterval"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long MaxFrameInterval;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.MinBitsPerSecond"]/*'/>
    [NativeTypeName("LONG")]
    public int MinBitsPerSecond;
    /// <include file='VIDEO_STREAM_CONFIG_CAPS.xml' path='doc/member[@name="VIDEO_STREAM_CONFIG_CAPS.MaxBitsPerSecond"]/*'/>
    [NativeTypeName("LONG")]
    public int MaxBitsPerSecond;
}