// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum GraphicsTrustStatus
{
    GraphicsTrustStatus_TrustNotRequired = 0,
    GraphicsTrustStatus_TrustEstablished = 1,
    GraphicsTrustStatus_EnvironmentNotSupported = 2,
    GraphicsTrustStatus_DriverNotSupported = 3,
    GraphicsTrustStatus_DriverSigningFailure = 4,
    GraphicsTrustStatus_UnknownFailure = 5,
}
