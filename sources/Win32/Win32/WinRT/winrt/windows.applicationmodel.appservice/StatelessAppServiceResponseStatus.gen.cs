// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.appservice.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum StatelessAppServiceResponseStatus
{
    StatelessAppServiceResponseStatus_Success = 0,
    StatelessAppServiceResponseStatus_AppNotInstalled = 1,
    StatelessAppServiceResponseStatus_AppUnavailable = 2,
    StatelessAppServiceResponseStatus_AppServiceUnavailable = 3,
    StatelessAppServiceResponseStatus_RemoteSystemUnavailable = 4,
    StatelessAppServiceResponseStatus_RemoteSystemNotSupportedByApp = 5,
    StatelessAppServiceResponseStatus_NotAuthorized = 6,
    StatelessAppServiceResponseStatus_ResourceLimitsExceeded = 7,
    StatelessAppServiceResponseStatus_MessageSizeTooLarge = 8,
    StatelessAppServiceResponseStatus_Failure = 9,
    StatelessAppServiceResponseStatus_Unknown = 10,
    StatelessAppServiceResponseStatus_AuthenticationError = 11,
    StatelessAppServiceResponseStatus_NetworkNotAvailable = 12,
    StatelessAppServiceResponseStatus_DisabledByPolicy = 13,
    StatelessAppServiceResponseStatus_WebServiceUnavailable = 14,
}
