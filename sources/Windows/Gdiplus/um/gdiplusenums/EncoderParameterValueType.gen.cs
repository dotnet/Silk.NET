// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Gdiplus;
/// <include file='EncoderParameterValueType.xml' path='doc/member[@name="EncoderParameterValueType"]/*'/>
public enum EncoderParameterValueType
{
    /// <include file='EncoderParameterValueType.xml' path='doc/member[@name="EncoderParameterValueType.EncoderParameterValueTypeByte"]/*'/>
    EncoderParameterValueTypeByte = 1,
    /// <include file='EncoderParameterValueType.xml' path='doc/member[@name="EncoderParameterValueType.EncoderParameterValueTypeASCII"]/*'/>
    EncoderParameterValueTypeASCII = 2,
    /// <include file='EncoderParameterValueType.xml' path='doc/member[@name="EncoderParameterValueType.EncoderParameterValueTypeShort"]/*'/>
    EncoderParameterValueTypeShort = 3,
    /// <include file='EncoderParameterValueType.xml' path='doc/member[@name="EncoderParameterValueType.EncoderParameterValueTypeLong"]/*'/>
    EncoderParameterValueTypeLong = 4,
    /// <include file='EncoderParameterValueType.xml' path='doc/member[@name="EncoderParameterValueType.EncoderParameterValueTypeRational"]/*'/>
    EncoderParameterValueTypeRational = 5,
    /// <include file='EncoderParameterValueType.xml' path='doc/member[@name="EncoderParameterValueType.EncoderParameterValueTypeLongRange"]/*'/>
    EncoderParameterValueTypeLongRange = 6,
    /// <include file='EncoderParameterValueType.xml' path='doc/member[@name="EncoderParameterValueType.EncoderParameterValueTypeUndefined"]/*'/>
    EncoderParameterValueTypeUndefined = 7,
    /// <include file='EncoderParameterValueType.xml' path='doc/member[@name="EncoderParameterValueType.EncoderParameterValueTypeRationalRange"]/*'/>
    EncoderParameterValueTypeRationalRange = 8,
    /// <include file='EncoderParameterValueType.xml' path='doc/member[@name="EncoderParameterValueType.EncoderParameterValueTypePointer"]/*'/>
    EncoderParameterValueTypePointer = 9,
}