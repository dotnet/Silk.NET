// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE"]/*'/>
public enum D2D1_PROPERTY_TYPE
{
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN"]/*'/>
    D2D1_PROPERTY_TYPE_UNKNOWN = 0,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_STRING"]/*'/>
    D2D1_PROPERTY_TYPE_STRING = 1,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_BOOL"]/*'/>
    D2D1_PROPERTY_TYPE_BOOL = 2,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UINT32"]/*'/>
    D2D1_PROPERTY_TYPE_UINT32 = 3,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_INT32"]/*'/>
    D2D1_PROPERTY_TYPE_INT32 = 4,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_FLOAT"]/*'/>
    D2D1_PROPERTY_TYPE_FLOAT = 5,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR2"]/*'/>
    D2D1_PROPERTY_TYPE_VECTOR2 = 6,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR3"]/*'/>
    D2D1_PROPERTY_TYPE_VECTOR3 = 7,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR4"]/*'/>
    D2D1_PROPERTY_TYPE_VECTOR4 = 8,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_BLOB"]/*'/>
    D2D1_PROPERTY_TYPE_BLOB = 9,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_IUNKNOWN"]/*'/>
    D2D1_PROPERTY_TYPE_IUNKNOWN = 10,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_ENUM"]/*'/>
    D2D1_PROPERTY_TYPE_ENUM = 11,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_ARRAY"]/*'/>
    D2D1_PROPERTY_TYPE_ARRAY = 12,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_CLSID"]/*'/>
    D2D1_PROPERTY_TYPE_CLSID = 13,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_3X2"]/*'/>
    D2D1_PROPERTY_TYPE_MATRIX_3X2 = 14,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_4X3"]/*'/>
    D2D1_PROPERTY_TYPE_MATRIX_4X3 = 15,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_4X4"]/*'/>
    D2D1_PROPERTY_TYPE_MATRIX_4X4 = 16,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_5X4"]/*'/>
    D2D1_PROPERTY_TYPE_MATRIX_5X4 = 17,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_COLOR_CONTEXT"]/*'/>
    D2D1_PROPERTY_TYPE_COLOR_CONTEXT = 18,
    /// <include file='D2D1_PROPERTY_TYPE.xml' path='doc/member[@name="D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_FORCE_DWORD"]/*'/>
    D2D1_PROPERTY_TYPE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}