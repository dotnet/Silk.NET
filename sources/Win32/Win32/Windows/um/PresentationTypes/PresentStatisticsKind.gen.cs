// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum PresentStatisticsKind
{
    PresentStatisticsKind_PresentStatus = 1,
    PresentStatisticsKind_CompositionFrame = 2,
    PresentStatisticsKind_IndependentFlipFrame = 3,
}
