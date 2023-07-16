// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D2D1CreateDevice"]/*'/>
    [DllImport("d2d1", ExactSpelling = true)]
    public static extern HRESULT D2D1CreateDevice(IDXGIDevice* dxgiDevice, [NativeTypeName("const D2D1_CREATION_PROPERTIES *")] D2D1_CREATION_PROPERTIES* creationProperties, ID2D1Device** d2dDevice);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D2D1CreateDeviceContext"]/*'/>
    [DllImport("d2d1", ExactSpelling = true)]
    public static extern HRESULT D2D1CreateDeviceContext(IDXGISurface* dxgiSurface, [NativeTypeName("const D2D1_CREATION_PROPERTIES *")] D2D1_CREATION_PROPERTIES* creationProperties, ID2D1DeviceContext** d2dDeviceContext);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D2D1ConvertColorSpace"]/*'/>
    [DllImport("d2d1", ExactSpelling = true)]
    [return: NativeTypeName("D2D1_COLOR_F")]
    public static extern DXGI_RGBA D2D1ConvertColorSpace(D2D1_COLOR_SPACE sourceColorSpace, D2D1_COLOR_SPACE destinationColorSpace, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D2D1SinCos"]/*'/>
    [DllImport("d2d1", ExactSpelling = true)]
    public static extern void D2D1SinCos(float angle, float* s, float* c);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D2D1Tan"]/*'/>
    [DllImport("d2d1", ExactSpelling = true)]
    public static extern float D2D1Tan(float angle);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D2D1Vec3Length"]/*'/>
    [DllImport("d2d1", ExactSpelling = true)]
    public static extern float D2D1Vec3Length(float x, float y, float z);
}