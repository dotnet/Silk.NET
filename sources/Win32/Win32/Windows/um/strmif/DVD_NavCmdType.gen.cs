// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DVD_NavCmdType
{
    DVD_NavCmdType_Pre = 1,
    DVD_NavCmdType_Post = 2,
    DVD_NavCmdType_Cell = 3,
    DVD_NavCmdType_Button = 4,
}
