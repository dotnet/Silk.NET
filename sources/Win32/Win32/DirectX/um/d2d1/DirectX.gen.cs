// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [DllImport("d2d1", ExactSpelling = true)]
    public static extern HRESULT D2D1CreateFactory(
        D2D1_FACTORY_TYPE factoryType,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("const D2D1_FACTORY_OPTIONS *")] D2D1_FACTORY_OPTIONS* pFactoryOptions,
        void** ppIFactory
    );

    [DllImport("d2d1", ExactSpelling = true)]
    public static extern void D2D1MakeRotateMatrix(
        float angle,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center,
        [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix
    );

    [DllImport("d2d1", ExactSpelling = true)]
    public static extern void D2D1MakeSkewMatrix(
        float angleX,
        float angleY,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center,
        [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix
    );

    [DllImport("d2d1", ExactSpelling = true)]
    public static extern BOOL D2D1IsMatrixInvertible(
        [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix
    );

    [DllImport("d2d1", ExactSpelling = true)]
    public static extern BOOL D2D1InvertMatrix(
        [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix
    );

    public static HRESULT D2D1CreateFactory(
        D2D1_FACTORY_TYPE factoryType,
        [NativeTypeName("const IID &")] Guid* riid,
        void** factory
    )
    {
        return D2D1CreateFactory(factoryType, riid, null, factory);
    }
}
