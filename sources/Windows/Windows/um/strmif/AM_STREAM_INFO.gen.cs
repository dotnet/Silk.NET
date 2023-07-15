// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AM_STREAM_INFO.xml' path='doc/member[@name="AM_STREAM_INFO"]/*'/>
public partial struct AM_STREAM_INFO
{
    /// <include file='AM_STREAM_INFO.xml' path='doc/member[@name="AM_STREAM_INFO.tStart"]/*'/>
    [NativeTypeName("REFERENCE_TIME")]
    public long tStart;
    /// <include file='AM_STREAM_INFO.xml' path='doc/member[@name="AM_STREAM_INFO.tStop"]/*'/>
    [NativeTypeName("REFERENCE_TIME")]
    public long tStop;
    /// <include file='AM_STREAM_INFO.xml' path='doc/member[@name="AM_STREAM_INFO.dwStartCookie"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStartCookie;
    /// <include file='AM_STREAM_INFO.xml' path='doc/member[@name="AM_STREAM_INFO.dwStopCookie"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStopCookie;
    /// <include file='AM_STREAM_INFO.xml' path='doc/member[@name="AM_STREAM_INFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}