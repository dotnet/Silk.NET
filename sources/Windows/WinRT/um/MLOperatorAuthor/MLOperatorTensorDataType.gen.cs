// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.WinRT;
/// <include file='MLOperatorTensorDataType.xml' path='doc/member[@name="MLOperatorTensorDataType"]/*'/>
[NativeTypeName("uint32_t")]
public enum MLOperatorTensorDataType : uint
{
    /// <include file='MLOperatorTensorDataType.xml' path='doc/member[@name="MLOperatorTensorDataType.Undefined"]/*'/>
    Undefined = 0,
    /// <include file='MLOperatorTensorDataType.xml' path='doc/member[@name="MLOperatorTensorDataType.Float"]/*'/>
    Float = 1,
    /// <include file='MLOperatorTensorDataType.xml' path='doc/member[@name="MLOperatorTensorDataType.UInt8"]/*'/>
    UInt8 = 2,
    /// <include file='MLOperatorTensorDataType.xml' path='doc/member[@name="MLOperatorTensorDataType.Int8"]/*'/>
    Int8 = 3,
    /// <include file='MLOperatorTensorDataType.xml' path='doc/member[@name="MLOperatorTensorDataType.UInt16"]/*'/>
    UInt16 = 4,
    /// <include file='MLOperatorTensorDataType.xml' path='doc/member[@name="MLOperatorTensorDataType.Int16"]/*'/>
    Int16 = 5,
    /// <include file='MLOperatorTensorDataType.xml' path='doc/member[@name="MLOperatorTensorDataType.Int32"]/*'/>
    Int32 = 6,
    /// <include file='MLOperatorTensorDataType.xml' path='doc/member[@name="MLOperatorTensorDataType.Int64"]/*'/>
    Int64 = 7,
    /// <include file='MLOperatorTensorDataType.xml' path='doc/member[@name="MLOperatorTensorDataType.String"]/*'/>
    String = 8,
    /// <include file='MLOperatorTensorDataType.xml' path='doc/member[@name="MLOperatorTensorDataType.Bool"]/*'/>
    Bool = 9,
    /// <include file='MLOperatorTensorDataType.xml' path='doc/member[@name="MLOperatorTensorDataType.Float16"]/*'/>
    Float16 = 10,
    /// <include file='MLOperatorTensorDataType.xml' path='doc/member[@name="MLOperatorTensorDataType.Double"]/*'/>
    Double = 11,
    /// <include file='MLOperatorTensorDataType.xml' path='doc/member[@name="MLOperatorTensorDataType.UInt32"]/*'/>
    UInt32 = 12,
    /// <include file='MLOperatorTensorDataType.xml' path='doc/member[@name="MLOperatorTensorDataType.UInt64"]/*'/>
    UInt64 = 13,
    /// <include file='MLOperatorTensorDataType.xml' path='doc/member[@name="MLOperatorTensorDataType.Complex64"]/*'/>
    Complex64 = 14,
    /// <include file='MLOperatorTensorDataType.xml' path='doc/member[@name="MLOperatorTensorDataType.Complex128"]/*'/>
    Complex128 = 15,
}