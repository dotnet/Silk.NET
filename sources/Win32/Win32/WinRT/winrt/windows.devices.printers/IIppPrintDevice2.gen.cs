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

[Guid("F7C844C9-9D21-5C63-AC20-3676915BE2D7")]
[NativeTypeName("struct IIppPrintDevice2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIppPrintDevice2 : IIppPrintDevice2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIppPrintDevice2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IIppPrintDevice2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IIppPrintDevice2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IIppPrintDevice2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IIppPrintDevice2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IIppPrintDevice2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IIppPrintDevice2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMaxSupportedPdfSize([NativeTypeName("UINT64 *")] ulong* result)
    {
        return ((delegate* unmanaged<IIppPrintDevice2, ulong*, int>)((*lpVtbl)[6]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMaxSupportedPdfVersion(HSTRING* result)
    {
        return ((delegate* unmanaged<IIppPrintDevice2, HSTRING*, int>)((*lpVtbl)[7]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsPdlPassthroughSupported(
        HSTRING pdlContentType,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return ((delegate* unmanaged<IIppPrintDevice2, HSTRING, byte*, int>)((*lpVtbl)[8]))(
            this,
            pdlContentType,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPdlPassthroughProvider(
        [NativeTypeName("ABI::Windows::Devices::Printers::IPdlPassthroughProvider **")]
            IPdlPassthroughProvider* result
    )
    {
        return (
            (delegate* unmanaged<IIppPrintDevice2, IPdlPassthroughProvider*, int>)((*lpVtbl)[9])
        )(this, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetMaxSupportedPdfSize([NativeTypeName("UINT64 *")] ulong* result);

        [VtblIndex(7)]
        HRESULT GetMaxSupportedPdfVersion(HSTRING* result);

        [VtblIndex(8)]
        HRESULT IsPdlPassthroughSupported(
            HSTRING pdlContentType,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(9)]
        HRESULT GetPdlPassthroughProvider(
            [NativeTypeName("ABI::Windows::Devices::Printers::IPdlPassthroughProvider **")]
                IPdlPassthroughProvider* result
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetMaxSupportedPdfSize;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetMaxSupportedPdfVersion;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, byte*, int> IsPdlPassthroughSupported;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Printers::IPdlPassthroughProvider **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPdlPassthroughProvider*, int> GetPdlPassthroughProvider;
    }

    /// <summary>Initializes a new instance of the <see cref = "IIppPrintDevice2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IIppPrintDevice2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IIppPrintDevice2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IIppPrintDevice2(Silk.NET.WinRT.IInspectable value)
    {
        return new IIppPrintDevice2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIppPrintDevice2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IIppPrintDevice2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IIppPrintDevice2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IIppPrintDevice2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IIppPrintDevice2(Silk.NET.Windows.IUnknown value)
    {
        return new IIppPrintDevice2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIppPrintDevice2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IIppPrintDevice2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IIppPrintDevice2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
