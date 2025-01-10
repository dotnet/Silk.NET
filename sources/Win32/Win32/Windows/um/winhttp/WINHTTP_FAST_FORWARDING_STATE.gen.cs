// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WINHTTP_FAST_FORWARDING_STATE
{
    WinHttpFastForwardingStateInProgress = 0,
    WinHttpFastForwardingStateSucceeded = 1,
    WinHttpFastForwardingStateClientSideFailed = 2,
    WinHttpFastForwardingStateServerSideFailed = 3,
}
