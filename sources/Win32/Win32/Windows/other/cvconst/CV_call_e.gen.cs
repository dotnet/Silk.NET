// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum CV_call_e
{
    CV_CALL_NEAR_C = 0x00,
    CV_CALL_FAR_C = 0x01,
    CV_CALL_NEAR_PASCAL = 0x02,
    CV_CALL_FAR_PASCAL = 0x03,
    CV_CALL_NEAR_FAST = 0x04,
    CV_CALL_FAR_FAST = 0x05,
    CV_CALL_SKIPPED = 0x06,
    CV_CALL_NEAR_STD = 0x07,
    CV_CALL_FAR_STD = 0x08,
    CV_CALL_NEAR_SYS = 0x09,
    CV_CALL_FAR_SYS = 0x0a,
    CV_CALL_THISCALL = 0x0b,
    CV_CALL_MIPSCALL = 0x0c,
    CV_CALL_GENERIC = 0x0d,
    CV_CALL_ALPHACALL = 0x0e,
    CV_CALL_PPCCALL = 0x0f,
    CV_CALL_SHCALL = 0x10,
    CV_CALL_ARMCALL = 0x11,
    CV_CALL_AM33CALL = 0x12,
    CV_CALL_TRICALL = 0x13,
    CV_CALL_SH5CALL = 0x14,
    CV_CALL_M32RCALL = 0x15,
    CV_CALL_CLRCALL = 0x16,
    CV_CALL_INLINE = 0x17,
    CV_CALL_NEAR_VECTOR = 0x18,
    CV_CALL_SWIFT = 0x19,
    CV_CALL_RESERVED = 0x20,
}
