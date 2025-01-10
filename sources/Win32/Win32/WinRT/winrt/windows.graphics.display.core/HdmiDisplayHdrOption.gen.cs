// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.display.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum HdmiDisplayHdrOption
{
    HdmiDisplayHdrOption_None = 0,
    HdmiDisplayHdrOption_EotfSdr = 1,
    HdmiDisplayHdrOption_Eotf2084 = 2,
    HdmiDisplayHdrOption_DolbyVisionLowLatency = 3,
}
