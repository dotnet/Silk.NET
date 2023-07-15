// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='WS_ASYNC_OPERATION.xml' path='doc/member[@name="WS_ASYNC_OPERATION"]/*'/>
public unsafe partial struct WS_ASYNC_OPERATION
{
    /// <include file='WS_ASYNC_OPERATION.xml' path='doc/member[@name="WS_ASYNC_OPERATION.function"]/*'/>
    [NativeTypeName("WS_ASYNC_FUNCTION")]
    public delegate* unmanaged<HRESULT, WS_CALLBACK_MODEL, void*, WS_ASYNC_OPERATION*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> function;
}