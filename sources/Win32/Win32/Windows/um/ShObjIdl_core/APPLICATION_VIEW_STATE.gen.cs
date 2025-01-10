// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum APPLICATION_VIEW_STATE
{
    AVS_FULLSCREEN_LANDSCAPE = 0,
    AVS_FILLED = (AVS_FULLSCREEN_LANDSCAPE + 1),
    AVS_SNAPPED = (AVS_FILLED + 1),
    AVS_FULLSCREEN_PORTRAIT = (AVS_SNAPPED + 1),
}
