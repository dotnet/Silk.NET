// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='WS_XML_WRITER_STREAM_OUTPUT.xml' path='doc/member[@name="WS_XML_WRITER_STREAM_OUTPUT"]/*'/>
public unsafe partial struct WS_XML_WRITER_STREAM_OUTPUT
{
    /// <include file='WS_XML_WRITER_STREAM_OUTPUT.xml' path='doc/member[@name="WS_XML_WRITER_STREAM_OUTPUT.output"]/*'/>
    public WS_XML_WRITER_OUTPUT output;
    /// <include file='WS_XML_WRITER_STREAM_OUTPUT.xml' path='doc/member[@name="WS_XML_WRITER_STREAM_OUTPUT.writeCallback"]/*'/>
    [NativeTypeName("WS_WRITE_CALLBACK")]
    public delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> writeCallback;
    /// <include file='WS_XML_WRITER_STREAM_OUTPUT.xml' path='doc/member[@name="WS_XML_WRITER_STREAM_OUTPUT.writeCallbackState"]/*'/>
    public void* writeCallbackState;
}