// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum WebAccountProviderOperationKind
{
    WebAccountProviderOperationKind_RequestToken = 0,
    WebAccountProviderOperationKind_GetTokenSilently = 1,
    WebAccountProviderOperationKind_AddAccount = 2,
    WebAccountProviderOperationKind_ManageAccount = 3,
    WebAccountProviderOperationKind_DeleteAccount = 4,
    WebAccountProviderOperationKind_RetrieveCookies = 5,
    WebAccountProviderOperationKind_SignOutAccount = 6,
}
