// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_PROPERTY_BINDING.xml' path='doc/member[@name="D2D1_PROPERTY_BINDING"]/*'/>
public unsafe partial struct D2D1_PROPERTY_BINDING
{
    /// <include file='D2D1_PROPERTY_BINDING.xml' path='doc/member[@name="D2D1_PROPERTY_BINDING.propertyName"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* propertyName;
    /// <include file='D2D1_PROPERTY_BINDING.xml' path='doc/member[@name="D2D1_PROPERTY_BINDING.setFunction"]/*'/>
    [NativeTypeName("PD2D1_PROPERTY_SET_FUNCTION")]
    public delegate* unmanaged<IUnknown*, byte*, uint, HRESULT> setFunction;
    /// <include file='D2D1_PROPERTY_BINDING.xml' path='doc/member[@name="D2D1_PROPERTY_BINDING.getFunction"]/*'/>
    [NativeTypeName("PD2D1_PROPERTY_GET_FUNCTION")]
    public delegate* unmanaged<IUnknown*, byte*, uint, uint*, HRESULT> getFunction;
}