// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum HTMLDlgFlag
{
    HTMLDlgFlagNo = 0,
    HTMLDlgFlagOff = 0,
    HTMLDlgFlag0 = 0,
    HTMLDlgFlagYes = 1,
    HTMLDlgFlagOn = 1,
    HTMLDlgFlag1 = 1,
    HTMLDlgFlagNotSet = -1,
    HTMLDlgFlag_Max = 2147483647,
}
