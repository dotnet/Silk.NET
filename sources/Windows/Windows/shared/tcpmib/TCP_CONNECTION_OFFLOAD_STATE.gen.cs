// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TCP_CONNECTION_OFFLOAD_STATE.xml' path='doc/member[@name="TCP_CONNECTION_OFFLOAD_STATE"]/*'/>
public enum TCP_CONNECTION_OFFLOAD_STATE
{
    /// <include file='TCP_CONNECTION_OFFLOAD_STATE.xml' path='doc/member[@name="TCP_CONNECTION_OFFLOAD_STATE.TcpConnectionOffloadStateInHost"]/*'/>
    TcpConnectionOffloadStateInHost,
    /// <include file='TCP_CONNECTION_OFFLOAD_STATE.xml' path='doc/member[@name="TCP_CONNECTION_OFFLOAD_STATE.TcpConnectionOffloadStateOffloading"]/*'/>
    TcpConnectionOffloadStateOffloading,
    /// <include file='TCP_CONNECTION_OFFLOAD_STATE.xml' path='doc/member[@name="TCP_CONNECTION_OFFLOAD_STATE.TcpConnectionOffloadStateOffloaded"]/*'/>
    TcpConnectionOffloadStateOffloaded,
    /// <include file='TCP_CONNECTION_OFFLOAD_STATE.xml' path='doc/member[@name="TCP_CONNECTION_OFFLOAD_STATE.TcpConnectionOffloadStateUploading"]/*'/>
    TcpConnectionOffloadStateUploading,
    /// <include file='TCP_CONNECTION_OFFLOAD_STATE.xml' path='doc/member[@name="TCP_CONNECTION_OFFLOAD_STATE.TcpConnectionOffloadStateMax"]/*'/>
    TcpConnectionOffloadStateMax,
}