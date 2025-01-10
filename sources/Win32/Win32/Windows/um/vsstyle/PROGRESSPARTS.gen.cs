// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum PROGRESSPARTS
{
    PP_BAR = 1,
    PP_BARVERT = 2,
    PP_CHUNK = 3,
    PP_CHUNKVERT = 4,
    PP_FILL = 5,
    PP_FILLVERT = 6,
    PP_PULSEOVERLAY = 7,
    PP_MOVEOVERLAY = 8,
    PP_PULSEOVERLAYVERT = 9,
    PP_MOVEOVERLAYVERT = 10,
    PP_TRANSPARENTBAR = 11,
    PP_TRANSPARENTBARVERT = 12,
}
