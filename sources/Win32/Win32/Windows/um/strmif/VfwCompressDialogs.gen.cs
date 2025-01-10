// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum VfwCompressDialogs
{
    VfwCompressDialog_Config = 0x1,
    VfwCompressDialog_About = 0x2,
    VfwCompressDialog_QueryConfig = 0x4,
    VfwCompressDialog_QueryAbout = 0x8,
}
