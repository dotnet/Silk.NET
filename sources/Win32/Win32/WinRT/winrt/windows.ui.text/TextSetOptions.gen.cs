// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum TextSetOptions : uint
{
    TextSetOptions_None = 0,
    TextSetOptions_UnicodeBidi = 0x1,
    TextSetOptions_Unlink = 0x8,
    TextSetOptions_Unhide = 0x10,
    TextSetOptions_CheckTextLimit = 0x20,
    TextSetOptions_FormatRtf = 0x2000,
    TextSetOptions_ApplyRtfDocumentDefaults = 0x4000,
}
