// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum AddPackageDependencyOptions2
{
    AddPackageDependencyOptions2_None = 0,
    AddPackageDependencyOptions2_PrependIfRankCollision = 0x00000001,
    AddPackageDependencyOptions2_SpecifiedPackageFamilyOnly = 0x00000002,
}
