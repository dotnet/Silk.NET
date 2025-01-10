// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D748AC56-76F3-5DC6-AFD4-C2A8686B9359")]
[NativeTypeName("struct IIppPrintDevice : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIppPrintDevice : IIppPrintDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIppPrintDevice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IIppPrintDevice, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IIppPrintDevice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IIppPrintDevice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IIppPrintDevice, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IIppPrintDevice, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IIppPrintDevice, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PrinterName(HSTRING* value)
    {
        return ((delegate* unmanaged<IIppPrintDevice, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PrinterUri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* value
    )
    {
        return ((delegate* unmanaged<IIppPrintDevice, IUriRuntimeClass*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPrinterAttributesAsBuffer(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* attributeNames,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* result
    )
    {
        return (
            (delegate* unmanaged<IIppPrintDevice, IIterable<HSTRING>*, IBuffer*, int>)((*lpVtbl)[8])
        )(this, attributeNames, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPrinterAttributes(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* attributeNames,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **"
        )]
            IMap<HSTRING, IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IIppPrintDevice,
                IIterable<HSTRING>*,
                IMap<HSTRING, IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, attributeNames, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetPrinterAttributesFromBuffer(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")]
            IBuffer printerAttributesBuffer,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppSetAttributesResult **")]
            IIppSetAttributesResult* result
    )
    {
        return (
            (delegate* unmanaged<IIppPrintDevice, IBuffer, IIppSetAttributesResult*, int>)(
                (*lpVtbl)[10]
            )
        )(this, printerAttributesBuffer, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetPrinterAttributes(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *"
        )]
            IIterable<IntPtr>* printerAttributes,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppSetAttributesResult **")]
            IIppSetAttributesResult* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppPrintDevice,
                IIterable<IntPtr>*,
                IIppSetAttributesResult*,
                int>)((*lpVtbl)[11])
        )(this, printerAttributes, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PrinterName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_PrinterUri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* value
        );

        [VtblIndex(8)]
        HRESULT GetPrinterAttributesAsBuffer(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* attributeNames,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* result
        );

        [VtblIndex(9)]
        HRESULT GetPrinterAttributes(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* attributeNames,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **"
            )]
                IMap<HSTRING, IntPtr>** result
        );

        [VtblIndex(10)]
        HRESULT SetPrinterAttributesFromBuffer(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")]
                IBuffer printerAttributesBuffer,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppSetAttributesResult **")]
                IIppSetAttributesResult* result
        );

        [VtblIndex(11)]
        HRESULT SetPrinterAttributes(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *"
            )]
                IIterable<IntPtr>* printerAttributes,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppSetAttributesResult **")]
                IIppSetAttributesResult* result
        );
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_PrinterName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass*, int> get_PrinterUri;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<HSTRING>*,
            IBuffer*,
            int> GetPrinterAttributesAsBuffer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<HSTRING>*,
            IMap<HSTRING, IntPtr>**,
            int> GetPrinterAttributes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::Printers::IIppSetAttributesResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            IIppSetAttributesResult*,
            int> SetPrinterAttributesFromBuffer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *, ABI::Windows::Devices::Printers::IIppSetAttributesResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IIppSetAttributesResult*,
            int> SetPrinterAttributes;
    }

    /// <summary>Initializes a new instance of the <see cref = "IIppPrintDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IIppPrintDevice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IIppPrintDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IIppPrintDevice(Silk.NET.WinRT.IInspectable value)
    {
        return new IIppPrintDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIppPrintDevice"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IIppPrintDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IIppPrintDevice value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IIppPrintDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IIppPrintDevice(Silk.NET.Windows.IUnknown value)
    {
        return new IIppPrintDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIppPrintDevice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IIppPrintDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IIppPrintDevice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
