// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='WS_SERVICE_PROPERTY_CLOSE_CALLBACK.xml' path='doc/member[@name="WS_SERVICE_PROPERTY_CLOSE_CALLBACK"]/*'/>
public unsafe partial struct WS_SERVICE_PROPERTY_CLOSE_CALLBACK
{
    /// <include file='WS_SERVICE_PROPERTY_CLOSE_CALLBACK.xml' path='doc/member[@name="WS_SERVICE_PROPERTY_CLOSE_CALLBACK.callback"]/*'/>
    [NativeTypeName("WS_SERVICE_CLOSE_CHANNEL_CALLBACK")]
    public delegate* unmanaged<IntPtr, WS_ASYNC_CONTEXT*, HRESULT> callback;
}