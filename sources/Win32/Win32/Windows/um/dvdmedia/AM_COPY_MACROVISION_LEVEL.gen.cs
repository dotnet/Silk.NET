// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum AM_COPY_MACROVISION_LEVEL
{
    AM_MACROVISION_DISABLED = 0,
    AM_MACROVISION_LEVEL1 = 1,
    AM_MACROVISION_LEVEL2 = 2,
    AM_MACROVISION_LEVEL3 = 3,
}
