// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.appservice.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AppServiceResponseStatus
{
    AppServiceResponseStatus_Success = 0,
    AppServiceResponseStatus_Failure = 1,
    AppServiceResponseStatus_ResourceLimitsExceeded = 2,
    AppServiceResponseStatus_Unknown = 3,
    AppServiceResponseStatus_RemoteSystemUnavailable = 4,
    AppServiceResponseStatus_MessageSizeTooLarge = 5,
    AppServiceResponseStatus_AppUnavailable = 6,
    AppServiceResponseStatus_AuthenticationError = 7,
    AppServiceResponseStatus_NetworkNotAvailable = 8,
    AppServiceResponseStatus_DisabledByPolicy = 9,
    AppServiceResponseStatus_WebServiceUnavailable = 10,
}
