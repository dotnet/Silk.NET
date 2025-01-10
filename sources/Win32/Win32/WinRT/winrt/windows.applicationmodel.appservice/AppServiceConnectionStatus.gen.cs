// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.appservice.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AppServiceConnectionStatus
{
    AppServiceConnectionStatus_Success = 0,
    AppServiceConnectionStatus_AppNotInstalled = 1,
    AppServiceConnectionStatus_AppUnavailable = 2,
    AppServiceConnectionStatus_AppServiceUnavailable = 3,
    AppServiceConnectionStatus_Unknown = 4,
    AppServiceConnectionStatus_RemoteSystemUnavailable = 5,
    AppServiceConnectionStatus_RemoteSystemNotSupportedByApp = 6,
    AppServiceConnectionStatus_NotAuthorized = 7,
    AppServiceConnectionStatus_AuthenticationError = 8,
    AppServiceConnectionStatus_NetworkNotAvailable = 9,
    AppServiceConnectionStatus_DisabledByPolicy = 10,
    AppServiceConnectionStatus_WebServiceUnavailable = 11,
}
