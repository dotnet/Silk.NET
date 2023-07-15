// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D2D1CreateFactory"]/*'/>
    [DllImport("d2d1", ExactSpelling = true)]
    public static extern HRESULT D2D1CreateFactory(D2D1_FACTORY_TYPE factoryType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("const D2D1_FACTORY_OPTIONS *")] D2D1_FACTORY_OPTIONS* pFactoryOptions, void** ppIFactory);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D2D1MakeRotateMatrix"]/*'/>
    [DllImport("d2d1", ExactSpelling = true)]
    public static extern void D2D1MakeRotateMatrix(float angle, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D2D1MakeSkewMatrix"]/*'/>
    [DllImport("d2d1", ExactSpelling = true)]
    public static extern void D2D1MakeSkewMatrix(float angleX, float angleY, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D2D1IsMatrixInvertible"]/*'/>
    [DllImport("d2d1", ExactSpelling = true)]
    public static extern BOOL D2D1IsMatrixInvertible([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D2D1InvertMatrix"]/*'/>
    [DllImport("d2d1", ExactSpelling = true)]
    public static extern BOOL D2D1InvertMatrix([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D2D1CreateFactory"]/*'/>
    public static HRESULT D2D1CreateFactory(D2D1_FACTORY_TYPE factoryType, [NativeTypeName("const IID &")] Guid* riid, void** factory)
    {
        return D2D1CreateFactory(factoryType, riid, null, factory);
    }
}