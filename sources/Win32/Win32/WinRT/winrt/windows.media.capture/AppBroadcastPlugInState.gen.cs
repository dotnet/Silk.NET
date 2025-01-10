// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AppBroadcastPlugInState
{
    AppBroadcastPlugInState_Unknown = 0,
    AppBroadcastPlugInState_Initialized = 1,
    AppBroadcastPlugInState_MicrosoftSignInRequired = 2,
    AppBroadcastPlugInState_OAuthSignInRequired = 3,
    AppBroadcastPlugInState_ProviderSignInRequired = 4,
    AppBroadcastPlugInState_InBandwidthTest = 5,
    AppBroadcastPlugInState_ReadyToBroadcast = 6,
}
