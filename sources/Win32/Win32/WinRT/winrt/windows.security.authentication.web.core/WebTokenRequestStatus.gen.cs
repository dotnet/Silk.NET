// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum WebTokenRequestStatus
{
    WebTokenRequestStatus_Success = 0,
    WebTokenRequestStatus_UserCancel = 1,
    WebTokenRequestStatus_AccountSwitch = 2,
    WebTokenRequestStatus_UserInteractionRequired = 3,
    WebTokenRequestStatus_AccountProviderNotAvailable = 4,
    WebTokenRequestStatus_ProviderError = 5,
}
