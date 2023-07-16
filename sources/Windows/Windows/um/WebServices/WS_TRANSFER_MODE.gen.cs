// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='WS_TRANSFER_MODE.xml' path='doc/member[@name="WS_TRANSFER_MODE"]/*'/>
[Flags]
public enum WS_TRANSFER_MODE
{
    /// <include file='WS_TRANSFER_MODE.xml' path='doc/member[@name="WS_TRANSFER_MODE.WS_STREAMED_INPUT_TRANSFER_MODE"]/*'/>
    WS_STREAMED_INPUT_TRANSFER_MODE = 0x1,
    /// <include file='WS_TRANSFER_MODE.xml' path='doc/member[@name="WS_TRANSFER_MODE.WS_STREAMED_OUTPUT_TRANSFER_MODE"]/*'/>
    WS_STREAMED_OUTPUT_TRANSFER_MODE = 0x2,
    /// <include file='WS_TRANSFER_MODE.xml' path='doc/member[@name="WS_TRANSFER_MODE.WS_BUFFERED_TRANSFER_MODE"]/*'/>
    WS_BUFFERED_TRANSFER_MODE = 0x0,
    /// <include file='WS_TRANSFER_MODE.xml' path='doc/member[@name="WS_TRANSFER_MODE.WS_STREAMED_TRANSFER_MODE"]/*'/>
    WS_STREAMED_TRANSFER_MODE = (WS_STREAMED_INPUT_TRANSFER_MODE | WS_STREAMED_OUTPUT_TRANSFER_MODE),
}