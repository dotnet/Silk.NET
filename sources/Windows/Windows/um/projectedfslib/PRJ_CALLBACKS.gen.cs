// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='PRJ_CALLBACKS.xml' path='doc/member[@name="PRJ_CALLBACKS"]/*'/>
[SupportedOSPlatform("windows10.0.17763.0")]
public unsafe partial struct PRJ_CALLBACKS
{
    /// <include file='PRJ_CALLBACKS.xml' path='doc/member[@name="PRJ_CALLBACKS.StartDirectoryEnumerationCallback"]/*'/>
    [NativeTypeName("PRJ_START_DIRECTORY_ENUMERATION_CB *")]
    public delegate* unmanaged<PRJ_CALLBACK_DATA*, Guid*, HRESULT> StartDirectoryEnumerationCallback;
    /// <include file='PRJ_CALLBACKS.xml' path='doc/member[@name="PRJ_CALLBACKS.EndDirectoryEnumerationCallback"]/*'/>
    [NativeTypeName("PRJ_END_DIRECTORY_ENUMERATION_CB *")]
    public delegate* unmanaged<PRJ_CALLBACK_DATA*, Guid*, HRESULT> EndDirectoryEnumerationCallback;
    /// <include file='PRJ_CALLBACKS.xml' path='doc/member[@name="PRJ_CALLBACKS.GetDirectoryEnumerationCallback"]/*'/>
    [NativeTypeName("PRJ_GET_DIRECTORY_ENUMERATION_CB *")]
    public delegate* unmanaged<PRJ_CALLBACK_DATA*, Guid*, ushort*, PRJ_DIR_ENTRY_BUFFER_HANDLE, HRESULT> GetDirectoryEnumerationCallback;
    /// <include file='PRJ_CALLBACKS.xml' path='doc/member[@name="PRJ_CALLBACKS.GetPlaceholderInfoCallback"]/*'/>
    [NativeTypeName("PRJ_GET_PLACEHOLDER_INFO_CB *")]
    public delegate* unmanaged<PRJ_CALLBACK_DATA*, HRESULT> GetPlaceholderInfoCallback;
    /// <include file='PRJ_CALLBACKS.xml' path='doc/member[@name="PRJ_CALLBACKS.GetFileDataCallback"]/*'/>
    [NativeTypeName("PRJ_GET_FILE_DATA_CB *")]
    public delegate* unmanaged<PRJ_CALLBACK_DATA*, ulong, uint, HRESULT> GetFileDataCallback;
    /// <include file='PRJ_CALLBACKS.xml' path='doc/member[@name="PRJ_CALLBACKS.QueryFileNameCallback"]/*'/>
    [NativeTypeName("PRJ_QUERY_FILE_NAME_CB *")]
    public delegate* unmanaged<PRJ_CALLBACK_DATA*, HRESULT> QueryFileNameCallback;
    /// <include file='PRJ_CALLBACKS.xml' path='doc/member[@name="PRJ_CALLBACKS.NotificationCallback"]/*'/>
    [NativeTypeName("PRJ_NOTIFICATION_CB *")]
    public delegate* unmanaged<PRJ_CALLBACK_DATA*, byte, PRJ_NOTIFICATION, ushort*, PRJ_NOTIFICATION_PARAMETERS*, HRESULT> NotificationCallback;
    /// <include file='PRJ_CALLBACKS.xml' path='doc/member[@name="PRJ_CALLBACKS.CancelCommandCallback"]/*'/>
    [NativeTypeName("PRJ_CANCEL_COMMAND_CB *")]
    public delegate* unmanaged<PRJ_CALLBACK_DATA*, void> CancelCommandCallback;
}