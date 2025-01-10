// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum msidbServiceControlEvent
{
    msidbServiceControlEventStart = 0x00000001,
    msidbServiceControlEventStop = 0x00000002,
    msidbServiceControlEventDelete = 0x00000008,
    msidbServiceControlEventUninstallStart = 0x00000010,
    msidbServiceControlEventUninstallStop = 0x00000020,
    msidbServiceControlEventUninstallDelete = 0x00000080,
}
