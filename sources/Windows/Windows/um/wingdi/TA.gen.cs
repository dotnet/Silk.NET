// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class TA
{
    [NativeTypeName("#define TA_NOUPDATECP 0")]
    public const int TA_NOUPDATECP = 0;
    [NativeTypeName("#define TA_UPDATECP 1")]
    public const int TA_UPDATECP = 1;
    [NativeTypeName("#define TA_LEFT 0")]
    public const int TA_LEFT = 0;
    [NativeTypeName("#define TA_RIGHT 2")]
    public const int TA_RIGHT = 2;
    [NativeTypeName("#define TA_CENTER 6")]
    public const int TA_CENTER = 6;
    [NativeTypeName("#define TA_TOP 0")]
    public const int TA_TOP = 0;
    [NativeTypeName("#define TA_BOTTOM 8")]
    public const int TA_BOTTOM = 8;
    [NativeTypeName("#define TA_BASELINE 24")]
    public const int TA_BASELINE = 24;
    [NativeTypeName("#define TA_RTLREADING 256")]
    public const int TA_RTLREADING = 256;
    [NativeTypeName("#define TA_MASK (TA_BASELINE+TA_CENTER+TA_UPDATECP+TA_RTLREADING)")]
    public const int TA_MASK = (24 + 6 + 1 + 256);
}