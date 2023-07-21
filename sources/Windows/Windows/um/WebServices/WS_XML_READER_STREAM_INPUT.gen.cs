// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='WS_XML_READER_STREAM_INPUT.xml' path='doc/member[@name="WS_XML_READER_STREAM_INPUT"]/*' />
public unsafe partial struct WS_XML_READER_STREAM_INPUT
{
    /// <include file='WS_XML_READER_STREAM_INPUT.xml' path='doc/member[@name="WS_XML_READER_STREAM_INPUT.input"]/*' />
    public WS_XML_READER_INPUT input;

    /// <include file='WS_XML_READER_STREAM_INPUT.xml' path='doc/member[@name="WS_XML_READER_STREAM_INPUT.readCallback"]/*' />
    [NativeTypeName("WS_READ_CALLBACK")]
    public delegate* unmanaged<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> readCallback;

    /// <include file='WS_XML_READER_STREAM_INPUT.xml' path='doc/member[@name="WS_XML_READER_STREAM_INPUT.readCallbackState"]/*' />
    public void* readCallbackState;
}
