// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TCP_ESTATS_DATA_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_DATA_ROD_v0"]/*' />
public partial struct TCP_ESTATS_DATA_ROD_v0
{
    /// <include file='TCP_ESTATS_DATA_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_DATA_ROD_v0.DataBytesOut"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong DataBytesOut;

    /// <include file='TCP_ESTATS_DATA_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_DATA_ROD_v0.DataSegsOut"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong DataSegsOut;

    /// <include file='TCP_ESTATS_DATA_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_DATA_ROD_v0.DataBytesIn"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong DataBytesIn;

    /// <include file='TCP_ESTATS_DATA_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_DATA_ROD_v0.DataSegsIn"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong DataSegsIn;

    /// <include file='TCP_ESTATS_DATA_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_DATA_ROD_v0.SegsOut"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong SegsOut;

    /// <include file='TCP_ESTATS_DATA_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_DATA_ROD_v0.SegsIn"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong SegsIn;

    /// <include file='TCP_ESTATS_DATA_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_DATA_ROD_v0.SoftErrors"]/*' />
    [NativeTypeName("ULONG")]
    public uint SoftErrors;

    /// <include file='TCP_ESTATS_DATA_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_DATA_ROD_v0.SoftErrorReason"]/*' />
    [NativeTypeName("ULONG")]
    public uint SoftErrorReason;

    /// <include file='TCP_ESTATS_DATA_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_DATA_ROD_v0.SndUna"]/*' />
    [NativeTypeName("ULONG")]
    public uint SndUna;

    /// <include file='TCP_ESTATS_DATA_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_DATA_ROD_v0.SndNxt"]/*' />
    [NativeTypeName("ULONG")]
    public uint SndNxt;

    /// <include file='TCP_ESTATS_DATA_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_DATA_ROD_v0.SndMax"]/*' />
    [NativeTypeName("ULONG")]
    public uint SndMax;

    /// <include file='TCP_ESTATS_DATA_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_DATA_ROD_v0.ThruBytesAcked"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong ThruBytesAcked;

    /// <include file='TCP_ESTATS_DATA_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_DATA_ROD_v0.RcvNxt"]/*' />
    [NativeTypeName("ULONG")]
    public uint RcvNxt;

    /// <include file='TCP_ESTATS_DATA_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_DATA_ROD_v0.ThruBytesReceived"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong ThruBytesReceived;
}
