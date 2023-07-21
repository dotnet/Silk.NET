// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0"]/*' />
public partial struct TCP_ESTATS_SND_CONG_ROD_v0
{
    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.SndLimTransRwin"]/*' />
    [NativeTypeName("ULONG")]
    public uint SndLimTransRwin;

    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.SndLimTimeRwin"]/*' />
    [NativeTypeName("ULONG")]
    public uint SndLimTimeRwin;

    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.SndLimBytesRwin"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint SndLimBytesRwin;

    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.SndLimTransCwnd"]/*' />
    [NativeTypeName("ULONG")]
    public uint SndLimTransCwnd;

    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.SndLimTimeCwnd"]/*' />
    [NativeTypeName("ULONG")]
    public uint SndLimTimeCwnd;

    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.SndLimBytesCwnd"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint SndLimBytesCwnd;

    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.SndLimTransSnd"]/*' />
    [NativeTypeName("ULONG")]
    public uint SndLimTransSnd;

    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.SndLimTimeSnd"]/*' />
    [NativeTypeName("ULONG")]
    public uint SndLimTimeSnd;

    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.SndLimBytesSnd"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint SndLimBytesSnd;

    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.SlowStart"]/*' />
    [NativeTypeName("ULONG")]
    public uint SlowStart;

    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.CongAvoid"]/*' />
    [NativeTypeName("ULONG")]
    public uint CongAvoid;

    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.OtherReductions"]/*' />
    [NativeTypeName("ULONG")]
    public uint OtherReductions;

    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.CurCwnd"]/*' />
    [NativeTypeName("ULONG")]
    public uint CurCwnd;

    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.MaxSsCwnd"]/*' />
    [NativeTypeName("ULONG")]
    public uint MaxSsCwnd;

    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.MaxCaCwnd"]/*' />
    [NativeTypeName("ULONG")]
    public uint MaxCaCwnd;

    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.CurSsthresh"]/*' />
    [NativeTypeName("ULONG")]
    public uint CurSsthresh;

    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.MaxSsthresh"]/*' />
    [NativeTypeName("ULONG")]
    public uint MaxSsthresh;

    /// <include file='TCP_ESTATS_SND_CONG_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SND_CONG_ROD_v0.MinSsthresh"]/*' />
    [NativeTypeName("ULONG")]
    public uint MinSsthresh;
}
