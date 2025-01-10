// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F928B7B8-2221-40C1-B72E-7E82F1974D1A")]
[NativeTypeName("struct IWICPlanarBitmapFrameEncode : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IWICPlanarBitmapFrameEncode
    : IWICPlanarBitmapFrameEncode.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPlanarBitmapFrameEncode));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IWICPlanarBitmapFrameEncode, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICPlanarBitmapFrameEncode, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICPlanarBitmapFrameEncode, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT WritePixels(uint lineCount, WICBitmapPlane* pPlanes, uint cPlanes)
    {
        return (
            (delegate* unmanaged<IWICPlanarBitmapFrameEncode, uint, WICBitmapPlane*, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, lineCount, pPlanes, cPlanes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT WriteSource(IWICBitmapSource* ppPlanes, uint cPlanes, WICRect* prcSource)
    {
        return (
            (delegate* unmanaged<
                IWICPlanarBitmapFrameEncode,
                IWICBitmapSource*,
                uint,
                WICRect*,
                int>)((*lpVtbl)[4])
        )(this, ppPlanes, cPlanes, prcSource);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT WritePixels(uint lineCount, WICBitmapPlane* pPlanes, uint cPlanes);

        [VtblIndex(4)]
        HRESULT WriteSource(IWICBitmapSource* ppPlanes, uint cPlanes, WICRect* prcSource);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (UINT, WICBitmapPlane *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, WICBitmapPlane*, uint, int> WritePixels;

        [NativeTypeName("HRESULT (IWICBitmapSource **, UINT, WICRect *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource*, uint, WICRect*, int> WriteSource;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICPlanarBitmapFrameEncode"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICPlanarBitmapFrameEncode(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICPlanarBitmapFrameEncode"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICPlanarBitmapFrameEncode(Silk.NET.Windows.IUnknown value)
    {
        return new IWICPlanarBitmapFrameEncode(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICPlanarBitmapFrameEncode"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICPlanarBitmapFrameEncode"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICPlanarBitmapFrameEncode value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
