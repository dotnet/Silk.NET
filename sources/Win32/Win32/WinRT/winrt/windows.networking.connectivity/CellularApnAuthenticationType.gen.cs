// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum CellularApnAuthenticationType
{
    CellularApnAuthenticationType_None = 0,
    CellularApnAuthenticationType_Pap = 1,
    CellularApnAuthenticationType_Chap = 2,
    CellularApnAuthenticationType_Mschapv2 = 3,
}
