// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='WS_OPERATION_DESCRIPTION.xml' path='doc/member[@name="WS_OPERATION_DESCRIPTION"]/*'/>
public unsafe partial struct WS_OPERATION_DESCRIPTION
{
    /// <include file='WS_OPERATION_DESCRIPTION.xml' path='doc/member[@name="WS_OPERATION_DESCRIPTION.versionInfo"]/*'/>
    [NativeTypeName("ULONG")]
    public uint versionInfo;
    /// <include file='WS_OPERATION_DESCRIPTION.xml' path='doc/member[@name="WS_OPERATION_DESCRIPTION.inputMessageDescription"]/*'/>
    public WS_MESSAGE_DESCRIPTION* inputMessageDescription;
    /// <include file='WS_OPERATION_DESCRIPTION.xml' path='doc/member[@name="WS_OPERATION_DESCRIPTION.outputMessageDescription"]/*'/>
    public WS_MESSAGE_DESCRIPTION* outputMessageDescription;
    /// <include file='WS_OPERATION_DESCRIPTION.xml' path='doc/member[@name="WS_OPERATION_DESCRIPTION.inputMessageOptions"]/*'/>
    [NativeTypeName("ULONG")]
    public uint inputMessageOptions;
    /// <include file='WS_OPERATION_DESCRIPTION.xml' path='doc/member[@name="WS_OPERATION_DESCRIPTION.outputMessageOptions"]/*'/>
    [NativeTypeName("ULONG")]
    public uint outputMessageOptions;
    /// <include file='WS_OPERATION_DESCRIPTION.xml' path='doc/member[@name="WS_OPERATION_DESCRIPTION.parameterCount"]/*'/>
    public ushort parameterCount;
    /// <include file='WS_OPERATION_DESCRIPTION.xml' path='doc/member[@name="WS_OPERATION_DESCRIPTION.parameterDescription"]/*'/>
    public WS_PARAMETER_DESCRIPTION* parameterDescription;
    /// <include file='WS_OPERATION_DESCRIPTION.xml' path='doc/member[@name="WS_OPERATION_DESCRIPTION.stubCallback"]/*'/>
    [NativeTypeName("WS_SERVICE_STUB_CALLBACK")]
    public delegate* unmanaged<IntPtr, void*, void*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> stubCallback;
    /// <include file='WS_OPERATION_DESCRIPTION.xml' path='doc/member[@name="WS_OPERATION_DESCRIPTION.style"]/*'/>
    public WS_OPERATION_STYLE style;
}