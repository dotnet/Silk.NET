// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluspixelformats.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public enum DitherType
{
    DitherTypeNone = 0,
    DitherTypeSolid = 1,
    DitherTypeOrdered4x4 = 2,
    DitherTypeOrdered8x8 = 3,
    DitherTypeOrdered16x16 = 4,
    DitherTypeSpiral4x4 = 5,
    DitherTypeSpiral8x8 = 6,
    DitherTypeDualSpiral4x4 = 7,
    DitherTypeDualSpiral8x8 = 8,
    DitherTypeErrorDiffusion = 9,
    DitherTypeMax = 10,
}
