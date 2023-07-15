// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_PROPERTY.xml' path='doc/member[@name="D2D1_PROPERTY"]/*'/>
public enum D2D1_PROPERTY
{
    /// <include file='D2D1_PROPERTY.xml' path='doc/member[@name="D2D1_PROPERTY.D2D1_PROPERTY_CLSID"]/*'/>
    D2D1_PROPERTY_CLSID = unchecked((int)(0x80000000)),
    /// <include file='D2D1_PROPERTY.xml' path='doc/member[@name="D2D1_PROPERTY.D2D1_PROPERTY_DISPLAYNAME"]/*'/>
    D2D1_PROPERTY_DISPLAYNAME = unchecked((int)(0x80000001)),
    /// <include file='D2D1_PROPERTY.xml' path='doc/member[@name="D2D1_PROPERTY.D2D1_PROPERTY_AUTHOR"]/*'/>
    D2D1_PROPERTY_AUTHOR = unchecked((int)(0x80000002)),
    /// <include file='D2D1_PROPERTY.xml' path='doc/member[@name="D2D1_PROPERTY.D2D1_PROPERTY_CATEGORY"]/*'/>
    D2D1_PROPERTY_CATEGORY = unchecked((int)(0x80000003)),
    /// <include file='D2D1_PROPERTY.xml' path='doc/member[@name="D2D1_PROPERTY.D2D1_PROPERTY_DESCRIPTION"]/*'/>
    D2D1_PROPERTY_DESCRIPTION = unchecked((int)(0x80000004)),
    /// <include file='D2D1_PROPERTY.xml' path='doc/member[@name="D2D1_PROPERTY.D2D1_PROPERTY_INPUTS"]/*'/>
    D2D1_PROPERTY_INPUTS = unchecked((int)(0x80000005)),
    /// <include file='D2D1_PROPERTY.xml' path='doc/member[@name="D2D1_PROPERTY.D2D1_PROPERTY_CACHED"]/*'/>
    D2D1_PROPERTY_CACHED = unchecked((int)(0x80000006)),
    /// <include file='D2D1_PROPERTY.xml' path='doc/member[@name="D2D1_PROPERTY.D2D1_PROPERTY_PRECISION"]/*'/>
    D2D1_PROPERTY_PRECISION = unchecked((int)(0x80000007)),
    /// <include file='D2D1_PROPERTY.xml' path='doc/member[@name="D2D1_PROPERTY.D2D1_PROPERTY_MIN_INPUTS"]/*'/>
    D2D1_PROPERTY_MIN_INPUTS = unchecked((int)(0x80000008)),
    /// <include file='D2D1_PROPERTY.xml' path='doc/member[@name="D2D1_PROPERTY.D2D1_PROPERTY_MAX_INPUTS"]/*'/>
    D2D1_PROPERTY_MAX_INPUTS = unchecked((int)(0x80000009)),
    /// <include file='D2D1_PROPERTY.xml' path='doc/member[@name="D2D1_PROPERTY.D2D1_PROPERTY_FORCE_DWORD"]/*'/>
    D2D1_PROPERTY_FORCE_DWORD = unchecked((int)(0xffffffff)),
}