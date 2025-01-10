// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public enum EncoderParameterValueType
{
    EncoderParameterValueTypeByte = 1,
    EncoderParameterValueTypeASCII = 2,
    EncoderParameterValueTypeShort = 3,
    EncoderParameterValueTypeLong = 4,
    EncoderParameterValueTypeRational = 5,
    EncoderParameterValueTypeLongRange = 6,
    EncoderParameterValueTypeUndefined = 7,
    EncoderParameterValueTypeRationalRange = 8,
    EncoderParameterValueTypePointer = 9,
}
