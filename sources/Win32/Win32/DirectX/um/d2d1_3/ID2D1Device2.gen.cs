// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("A44472E1-8DFB-4E60-8492-6E2861C9CA8B")]
[NativeTypeName("struct ID2D1Device2 : ID2D1Device1")]
[NativeInheritance("ID2D1Device1")]
public unsafe partial struct ID2D1Device2 : ID2D1Device2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Device2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1Device2, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1Device2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1Device2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1Device2, ID2D1Factory*, void>)((*lpVtbl)[3]))(this, factory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateDeviceContext(
        D2D1_DEVICE_CONTEXT_OPTIONS options,
        ID2D1DeviceContext* deviceContext
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1Device2,
                D2D1_DEVICE_CONTEXT_OPTIONS,
                ID2D1DeviceContext*,
                int>)((*lpVtbl)[4])
        )(this, options, deviceContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreatePrintControl(
        IWICImagingFactory wicFactory,
        IPrintDocumentPackageTarget documentTarget,
        [NativeTypeName("const D2D1_PRINT_CONTROL_PROPERTIES *")]
            D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties,
        ID2D1PrintControl* printControl
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1Device2,
                IWICImagingFactory,
                IPrintDocumentPackageTarget,
                D2D1_PRINT_CONTROL_PROPERTIES*,
                ID2D1PrintControl*,
                int>)((*lpVtbl)[5])
        )(this, wicFactory, documentTarget, printControlProperties, printControl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetMaximumTextureMemory([NativeTypeName("UINT64")] ulong maximumInBytes)
    {
        ((delegate* unmanaged<ID2D1Device2, ulong, void>)((*lpVtbl)[6]))(this, maximumInBytes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("UINT64")]
    public ulong GetMaximumTextureMemory()
    {
        return ((delegate* unmanaged<ID2D1Device2, ulong>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void ClearResources([NativeTypeName("UINT32")] uint millisecondsSinceUse = 0)
    {
        ((delegate* unmanaged<ID2D1Device2, uint, void>)((*lpVtbl)[8]))(this, millisecondsSinceUse);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public D2D1_RENDERING_PRIORITY GetRenderingPriority()
    {
        return ((delegate* unmanaged<ID2D1Device2, D2D1_RENDERING_PRIORITY>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void SetRenderingPriority(D2D1_RENDERING_PRIORITY renderingPriority)
    {
        ((delegate* unmanaged<ID2D1Device2, D2D1_RENDERING_PRIORITY, void>)((*lpVtbl)[10]))(
            this,
            renderingPriority
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateDeviceContext(
        D2D1_DEVICE_CONTEXT_OPTIONS options,
        ID2D1DeviceContext1* deviceContext1
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1Device2,
                D2D1_DEVICE_CONTEXT_OPTIONS,
                ID2D1DeviceContext1*,
                int>)((*lpVtbl)[11])
        )(this, options, deviceContext1);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateDeviceContext(
        D2D1_DEVICE_CONTEXT_OPTIONS options,
        ID2D1DeviceContext2* deviceContext2
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1Device2,
                D2D1_DEVICE_CONTEXT_OPTIONS,
                ID2D1DeviceContext2*,
                int>)((*lpVtbl)[12])
        )(this, options, deviceContext2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void FlushDeviceContexts(ID2D1Bitmap bitmap)
    {
        ((delegate* unmanaged<ID2D1Device2, ID2D1Bitmap, void>)((*lpVtbl)[13]))(this, bitmap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDxgiDevice(IDXGIDevice* dxgiDevice)
    {
        return ((delegate* unmanaged<ID2D1Device2, IDXGIDevice*, int>)((*lpVtbl)[14]))(
            this,
            dxgiDevice
        );
    }

    public interface Interface : ID2D1Device1.Interface
    {
        [VtblIndex(12)]
        HRESULT CreateDeviceContext(
            D2D1_DEVICE_CONTEXT_OPTIONS options,
            ID2D1DeviceContext2* deviceContext2
        );

        [VtblIndex(13)]
        void FlushDeviceContexts(ID2D1Bitmap bitmap);

        [VtblIndex(14)]
        HRESULT GetDxgiDevice(IDXGIDevice* dxgiDevice);
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

        [NativeTypeName(
            "void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Factory*, void> GetFactory;

        [NativeTypeName(
            "HRESULT (D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_DEVICE_CONTEXT_OPTIONS,
            ID2D1DeviceContext*,
            int> CreateDeviceContext;

        [NativeTypeName(
            "HRESULT (IWICImagingFactory *, IPrintDocumentPackageTarget *, const D2D1_PRINT_CONTROL_PROPERTIES *, ID2D1PrintControl **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWICImagingFactory,
            IPrintDocumentPackageTarget,
            D2D1_PRINT_CONTROL_PROPERTIES*,
            ID2D1PrintControl*,
            int> CreatePrintControl;

        [NativeTypeName("void (UINT64) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, void> SetMaximumTextureMemory;

        [NativeTypeName("UINT64 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetMaximumTextureMemory;

        [NativeTypeName("void (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> ClearResources;

        [NativeTypeName(
            "D2D1_RENDERING_PRIORITY () __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_RENDERING_PRIORITY> GetRenderingPriority;

        [NativeTypeName(
            "void (D2D1_RENDERING_PRIORITY) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_RENDERING_PRIORITY, void> SetRenderingPriority;

        [NativeTypeName(
            "HRESULT (D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_DEVICE_CONTEXT_OPTIONS,
            ID2D1DeviceContext1*,
            int> CreateDeviceContext1;

        [NativeTypeName(
            "HRESULT (D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext2 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_DEVICE_CONTEXT_OPTIONS,
            ID2D1DeviceContext2*,
            int> CreateDeviceContext2;

        [NativeTypeName("void (ID2D1Bitmap *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Bitmap, void> FlushDeviceContexts;

        [NativeTypeName(
            "HRESULT (IDXGIDevice **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDXGIDevice*, int> GetDxgiDevice;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1Device2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1Device2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Device1"/> to <see cref = "ID2D1Device2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Device1"/> instance to be converted </param>
    public static explicit operator ID2D1Device2(Silk.NET.DirectX.ID2D1Device1 value)
    {
        return new ID2D1Device2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1Device2"/> to <see cref = "Silk.NET.DirectX.ID2D1Device1"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1Device2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Device1(ID2D1Device2 value)
    {
        return new Silk.NET.DirectX.ID2D1Device1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Device"/> to <see cref = "ID2D1Device2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Device"/> instance to be converted </param>
    public static explicit operator ID2D1Device2(Silk.NET.DirectX.ID2D1Device value)
    {
        return new ID2D1Device2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1Device2"/> to <see cref = "Silk.NET.DirectX.ID2D1Device"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1Device2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Device(ID2D1Device2 value)
    {
        return new Silk.NET.DirectX.ID2D1Device(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1Device2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1Device2(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1Device2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1Device2"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1Device2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1Device2 value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1Device2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1Device2(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1Device2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1Device2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1Device2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1Device2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
