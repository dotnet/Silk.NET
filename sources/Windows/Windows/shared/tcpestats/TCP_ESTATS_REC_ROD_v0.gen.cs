// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TCP_ESTATS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_REC_ROD_v0"]/*' />
public partial struct TCP_ESTATS_REC_ROD_v0
{
    /// <include file='TCP_ESTATS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_REC_ROD_v0.CurRwinSent"]/*' />
    [NativeTypeName("ULONG")]
    public uint CurRwinSent;

    /// <include file='TCP_ESTATS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_REC_ROD_v0.MaxRwinSent"]/*' />
    [NativeTypeName("ULONG")]
    public uint MaxRwinSent;

    /// <include file='TCP_ESTATS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_REC_ROD_v0.MinRwinSent"]/*' />
    [NativeTypeName("ULONG")]
    public uint MinRwinSent;

    /// <include file='TCP_ESTATS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_REC_ROD_v0.LimRwin"]/*' />
    [NativeTypeName("ULONG")]
    public uint LimRwin;

    /// <include file='TCP_ESTATS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_REC_ROD_v0.DupAckEpisodes"]/*' />
    [NativeTypeName("ULONG")]
    public uint DupAckEpisodes;

    /// <include file='TCP_ESTATS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_REC_ROD_v0.DupAcksOut"]/*' />
    [NativeTypeName("ULONG")]
    public uint DupAcksOut;

    /// <include file='TCP_ESTATS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_REC_ROD_v0.CeRcvd"]/*' />
    [NativeTypeName("ULONG")]
    public uint CeRcvd;

    /// <include file='TCP_ESTATS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_REC_ROD_v0.EcnSent"]/*' />
    [NativeTypeName("ULONG")]
    public uint EcnSent;

    /// <include file='TCP_ESTATS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_REC_ROD_v0.EcnNoncesRcvd"]/*' />
    [NativeTypeName("ULONG")]
    public uint EcnNoncesRcvd;

    /// <include file='TCP_ESTATS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_REC_ROD_v0.CurReasmQueue"]/*' />
    [NativeTypeName("ULONG")]
    public uint CurReasmQueue;

    /// <include file='TCP_ESTATS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_REC_ROD_v0.MaxReasmQueue"]/*' />
    [NativeTypeName("ULONG")]
    public uint MaxReasmQueue;

    /// <include file='TCP_ESTATS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_REC_ROD_v0.CurAppRQueue"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint CurAppRQueue;

    /// <include file='TCP_ESTATS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_REC_ROD_v0.MaxAppRQueue"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint MaxAppRQueue;

    /// <include file='TCP_ESTATS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_REC_ROD_v0.WinScaleSent"]/*' />
    [NativeTypeName("UCHAR")]
    public byte WinScaleSent;
}
