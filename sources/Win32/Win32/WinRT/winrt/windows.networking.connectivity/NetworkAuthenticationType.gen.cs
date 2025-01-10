// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum NetworkAuthenticationType
{
    NetworkAuthenticationType_None = 0,
    NetworkAuthenticationType_Unknown = 1,
    NetworkAuthenticationType_Open80211 = 2,
    NetworkAuthenticationType_SharedKey80211 = 3,
    NetworkAuthenticationType_Wpa = 4,
    NetworkAuthenticationType_WpaPsk = 5,
    NetworkAuthenticationType_WpaNone = 6,
    NetworkAuthenticationType_Rsna = 7,
    NetworkAuthenticationType_RsnaPsk = 8,
    NetworkAuthenticationType_Ihv = 9,
    NetworkAuthenticationType_Wpa3 = 10,
    NetworkAuthenticationType_Wpa3Enterprise192Bits = 10,
    NetworkAuthenticationType_Wpa3Sae = 11,
    NetworkAuthenticationType_Owe = 12,
    NetworkAuthenticationType_Wpa3Enterprise = 13,
}
