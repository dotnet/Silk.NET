// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SPCFGRULEATTRIBUTES
{
    SPRAF_TopLevel = (1 << 0),
    SPRAF_Active = (1 << 1),
    SPRAF_Export = (1 << 2),
    SPRAF_Import = (1 << 3),
    SPRAF_Interpreter = (1 << 4),
    SPRAF_Dynamic = (1 << 5),
    SPRAF_Root = (1 << 6),
    SPRAF_AutoPause = (1 << 16),
    SPRAF_UserDelimited = (1 << 17),
}
