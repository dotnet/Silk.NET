// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='WS_CHANNEL_ENCODER.xml' path='doc/member[@name="WS_CHANNEL_ENCODER"]/*'/>
public unsafe partial struct WS_CHANNEL_ENCODER
{
    /// <include file='WS_CHANNEL_ENCODER.xml' path='doc/member[@name="WS_CHANNEL_ENCODER.createContext"]/*'/>
    public void* createContext;
    /// <include file='WS_CHANNEL_ENCODER.xml' path='doc/member[@name="WS_CHANNEL_ENCODER.createEncoderCallback"]/*'/>
    [NativeTypeName("WS_CREATE_ENCODER_CALLBACK")]
    public delegate* unmanaged<void*, delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> , void*, void**, IntPtr, HRESULT> createEncoderCallback;
    /// <include file='WS_CHANNEL_ENCODER.xml' path='doc/member[@name="WS_CHANNEL_ENCODER.encoderGetContentTypeCallback"]/*'/>
    [NativeTypeName("WS_ENCODER_GET_CONTENT_TYPE_CALLBACK")]
    public delegate* unmanaged<void*, WS_STRING*, WS_STRING*, WS_STRING*, IntPtr, HRESULT> encoderGetContentTypeCallback;
    /// <include file='WS_CHANNEL_ENCODER.xml' path='doc/member[@name="WS_CHANNEL_ENCODER.encoderStartCallback"]/*'/>
    [NativeTypeName("WS_ENCODER_START_CALLBACK")]
    public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> encoderStartCallback;
    /// <include file='WS_CHANNEL_ENCODER.xml' path='doc/member[@name="WS_CHANNEL_ENCODER.encoderEncodeCallback"]/*'/>
    [NativeTypeName("WS_ENCODER_ENCODE_CALLBACK")]
    public delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> encoderEncodeCallback;
    /// <include file='WS_CHANNEL_ENCODER.xml' path='doc/member[@name="WS_CHANNEL_ENCODER.encoderEndCallback"]/*'/>
    [NativeTypeName("WS_ENCODER_END_CALLBACK")]
    public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> encoderEndCallback;
    /// <include file='WS_CHANNEL_ENCODER.xml' path='doc/member[@name="WS_CHANNEL_ENCODER.freeEncoderCallback"]/*'/>
    [NativeTypeName("WS_FREE_ENCODER_CALLBACK")]
    public delegate* unmanaged<void*, void> freeEncoderCallback;
}