// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.17763.0")]
public unsafe partial struct PRJ_CALLBACKS
{
    [NativeTypeName("PRJ_START_DIRECTORY_ENUMERATION_CB *")]
    public delegate* unmanaged<
        PRJ_CALLBACK_DATA*,
        Guid*,
        HRESULT> StartDirectoryEnumerationCallback;

    [NativeTypeName("PRJ_END_DIRECTORY_ENUMERATION_CB *")]
    public delegate* unmanaged<PRJ_CALLBACK_DATA*, Guid*, HRESULT> EndDirectoryEnumerationCallback;

    [NativeTypeName("PRJ_GET_DIRECTORY_ENUMERATION_CB *")]
    public delegate* unmanaged<
        PRJ_CALLBACK_DATA*,
        Guid*,
        ushort*,
        PRJ_DIR_ENTRY_BUFFER_HANDLE,
        HRESULT> GetDirectoryEnumerationCallback;

    [NativeTypeName("PRJ_GET_PLACEHOLDER_INFO_CB *")]
    public delegate* unmanaged<PRJ_CALLBACK_DATA*, HRESULT> GetPlaceholderInfoCallback;

    [NativeTypeName("PRJ_GET_FILE_DATA_CB *")]
    public delegate* unmanaged<PRJ_CALLBACK_DATA*, ulong, uint, HRESULT> GetFileDataCallback;

    [NativeTypeName("PRJ_QUERY_FILE_NAME_CB *")]
    public delegate* unmanaged<PRJ_CALLBACK_DATA*, HRESULT> QueryFileNameCallback;

    [NativeTypeName("PRJ_NOTIFICATION_CB *")]
    public delegate* unmanaged<
        PRJ_CALLBACK_DATA*,
        byte,
        PRJ_NOTIFICATION,
        ushort*,
        PRJ_NOTIFICATION_PARAMETERS*,
        HRESULT> NotificationCallback;

    [NativeTypeName("PRJ_CANCEL_COMMAND_CB *")]
    public delegate* unmanaged<PRJ_CALLBACK_DATA*, void> CancelCommandCallback;
}
