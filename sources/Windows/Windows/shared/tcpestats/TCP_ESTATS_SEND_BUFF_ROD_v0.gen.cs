// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TCP_ESTATS_SEND_BUFF_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SEND_BUFF_ROD_v0"]/*'/>
public partial struct TCP_ESTATS_SEND_BUFF_ROD_v0
{
    /// <include file='TCP_ESTATS_SEND_BUFF_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SEND_BUFF_ROD_v0.CurRetxQueue"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint CurRetxQueue;
    /// <include file='TCP_ESTATS_SEND_BUFF_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SEND_BUFF_ROD_v0.MaxRetxQueue"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint MaxRetxQueue;
    /// <include file='TCP_ESTATS_SEND_BUFF_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SEND_BUFF_ROD_v0.CurAppWQueue"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint CurAppWQueue;
    /// <include file='TCP_ESTATS_SEND_BUFF_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_SEND_BUFF_ROD_v0.MaxAppWQueue"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint MaxAppWQueue;
}