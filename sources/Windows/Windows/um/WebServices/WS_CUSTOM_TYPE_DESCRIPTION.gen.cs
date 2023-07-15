// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='WS_CUSTOM_TYPE_DESCRIPTION.xml' path='doc/member[@name="WS_CUSTOM_TYPE_DESCRIPTION"]/*'/>
public unsafe partial struct WS_CUSTOM_TYPE_DESCRIPTION
{
    /// <include file='WS_CUSTOM_TYPE_DESCRIPTION.xml' path='doc/member[@name="WS_CUSTOM_TYPE_DESCRIPTION.size"]/*'/>
    [NativeTypeName("ULONG")]
    public uint size;
    /// <include file='WS_CUSTOM_TYPE_DESCRIPTION.xml' path='doc/member[@name="WS_CUSTOM_TYPE_DESCRIPTION.alignment"]/*'/>
    [NativeTypeName("ULONG")]
    public uint alignment;
    /// <include file='WS_CUSTOM_TYPE_DESCRIPTION.xml' path='doc/member[@name="WS_CUSTOM_TYPE_DESCRIPTION.readCallback"]/*'/>
    [NativeTypeName("WS_READ_TYPE_CALLBACK")]
    public delegate* unmanaged<IntPtr, WS_TYPE_MAPPING, void*, IntPtr, void*, uint, IntPtr, HRESULT> readCallback;
    /// <include file='WS_CUSTOM_TYPE_DESCRIPTION.xml' path='doc/member[@name="WS_CUSTOM_TYPE_DESCRIPTION.writeCallback"]/*'/>
    [NativeTypeName("WS_WRITE_TYPE_CALLBACK")]
    public delegate* unmanaged<IntPtr, WS_TYPE_MAPPING, void*, void*, uint, IntPtr, HRESULT> writeCallback;
    /// <include file='WS_CUSTOM_TYPE_DESCRIPTION.xml' path='doc/member[@name="WS_CUSTOM_TYPE_DESCRIPTION.descriptionData"]/*'/>
    public void* descriptionData;
    /// <include file='WS_CUSTOM_TYPE_DESCRIPTION.xml' path='doc/member[@name="WS_CUSTOM_TYPE_DESCRIPTION.isDefaultValueCallback"]/*'/>
    [NativeTypeName("WS_IS_DEFAULT_VALUE_CALLBACK")]
    public delegate* unmanaged<void*, void*, void*, uint, BOOL*, IntPtr, HRESULT> isDefaultValueCallback;
}