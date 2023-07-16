// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TCP_ESTATS_TYPE.xml' path='doc/member[@name="TCP_ESTATS_TYPE"]/*'/>
public enum TCP_ESTATS_TYPE
{
    /// <include file='TCP_ESTATS_TYPE.xml' path='doc/member[@name="TCP_ESTATS_TYPE.TcpConnectionEstatsSynOpts"]/*'/>
    TcpConnectionEstatsSynOpts,
    /// <include file='TCP_ESTATS_TYPE.xml' path='doc/member[@name="TCP_ESTATS_TYPE.TcpConnectionEstatsData"]/*'/>
    TcpConnectionEstatsData,
    /// <include file='TCP_ESTATS_TYPE.xml' path='doc/member[@name="TCP_ESTATS_TYPE.TcpConnectionEstatsSndCong"]/*'/>
    TcpConnectionEstatsSndCong,
    /// <include file='TCP_ESTATS_TYPE.xml' path='doc/member[@name="TCP_ESTATS_TYPE.TcpConnectionEstatsPath"]/*'/>
    TcpConnectionEstatsPath,
    /// <include file='TCP_ESTATS_TYPE.xml' path='doc/member[@name="TCP_ESTATS_TYPE.TcpConnectionEstatsSendBuff"]/*'/>
    TcpConnectionEstatsSendBuff,
    /// <include file='TCP_ESTATS_TYPE.xml' path='doc/member[@name="TCP_ESTATS_TYPE.TcpConnectionEstatsRec"]/*'/>
    TcpConnectionEstatsRec,
    /// <include file='TCP_ESTATS_TYPE.xml' path='doc/member[@name="TCP_ESTATS_TYPE.TcpConnectionEstatsObsRec"]/*'/>
    TcpConnectionEstatsObsRec,
    /// <include file='TCP_ESTATS_TYPE.xml' path='doc/member[@name="TCP_ESTATS_TYPE.TcpConnectionEstatsBandwidth"]/*'/>
    TcpConnectionEstatsBandwidth,
    /// <include file='TCP_ESTATS_TYPE.xml' path='doc/member[@name="TCP_ESTATS_TYPE.TcpConnectionEstatsFineRtt"]/*'/>
    TcpConnectionEstatsFineRtt,
    /// <include file='TCP_ESTATS_TYPE.xml' path='doc/member[@name="TCP_ESTATS_TYPE.TcpConnectionEstatsMaximum"]/*'/>
    TcpConnectionEstatsMaximum,
}