// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("47DD575D-AC05-4CDD-8049-9B02CD16F44C")]
[NativeTypeName("struct ID2D1Device : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1Device : ID2D1Device.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Device));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1Device, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1Device, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1Device, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1Device, ID2D1Factory*, void>)((*lpVtbl)[3]))(this, factory);
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
                ID2D1Device,
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
                ID2D1Device,
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
        ((delegate* unmanaged<ID2D1Device, ulong, void>)((*lpVtbl)[6]))(this, maximumInBytes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("UINT64")]
    public ulong GetMaximumTextureMemory()
    {
        return ((delegate* unmanaged<ID2D1Device, ulong>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void ClearResources([NativeTypeName("UINT32")] uint millisecondsSinceUse = 0)
    {
        ((delegate* unmanaged<ID2D1Device, uint, void>)((*lpVtbl)[8]))(this, millisecondsSinceUse);
    }

    public interface Interface : ID2D1Resource.Interface
    {
        [VtblIndex(4)]
        HRESULT CreateDeviceContext(
            D2D1_DEVICE_CONTEXT_OPTIONS options,
            ID2D1DeviceContext* deviceContext
        );

        [VtblIndex(5)]
        HRESULT CreatePrintControl(
            IWICImagingFactory wicFactory,
            IPrintDocumentPackageTarget documentTarget,
            [NativeTypeName("const D2D1_PRINT_CONTROL_PROPERTIES *")]
                D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties,
            ID2D1PrintControl* printControl
        );

        [VtblIndex(6)]
        void SetMaximumTextureMemory([NativeTypeName("UINT64")] ulong maximumInBytes);

        [VtblIndex(7)]
        [return: NativeTypeName("UINT64")]
        ulong GetMaximumTextureMemory();

        [VtblIndex(8)]
        void ClearResources([NativeTypeName("UINT32")] uint millisecondsSinceUse = 0);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1Device"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1Device(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1Device"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1Device(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1Device(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1Device"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1Device"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1Device value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1Device"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1Device(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1Device(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1Device"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1Device"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1Device value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
