// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum TimedMetadataKind
{
    TimedMetadataKind_Caption = 0,
    TimedMetadataKind_Chapter = 1,
    TimedMetadataKind_Custom = 2,
    TimedMetadataKind_Data = 3,
    TimedMetadataKind_Description = 4,
    TimedMetadataKind_Subtitle = 5,
    TimedMetadataKind_ImageSubtitle = 6,
    TimedMetadataKind_Speech = 7,
}
