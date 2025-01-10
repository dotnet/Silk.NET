// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum CompositionFrameInstanceKind
{
    CompositionFrameInstanceKind_ComposedOnScreen = 0,
    CompositionFrameInstanceKind_ScanoutOnScreen = 1,
    CompositionFrameInstanceKind_ComposedToIntermediate = 2,
}
