// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D78BAD2C-F721-5244-A196-B56CCBEC606C")]
[NativeTypeName("struct IDigitalWindowCapability : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDigitalWindowCapability
    : IDigitalWindowCapability.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDigitalWindowCapability));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDigitalWindowCapability, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDigitalWindowCapability, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDigitalWindowCapability, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDigitalWindowCapability, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDigitalWindowCapability, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDigitalWindowCapability, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Width([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IDigitalWindowCapability, int*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Height([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IDigitalWindowCapability, int*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MinScaleValue(double* value)
    {
        return ((delegate* unmanaged<IDigitalWindowCapability, double*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MaxScaleValue(double* value)
    {
        return ((delegate* unmanaged<IDigitalWindowCapability, double*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MinScaleValueWithoutUpsampling(double* value)
    {
        return ((delegate* unmanaged<IDigitalWindowCapability, double*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_NormalizedFieldOfViewLimit(
        [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value
    )
    {
        return ((delegate* unmanaged<IDigitalWindowCapability, Rect*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Width([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_Height([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_MinScaleValue(double* value);

        [VtblIndex(9)]
        HRESULT get_MaxScaleValue(double* value);

        [VtblIndex(10)]
        HRESULT get_MinScaleValueWithoutUpsampling(double* value);

        [VtblIndex(11)]
        HRESULT get_NormalizedFieldOfViewLimit(
            [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Width;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Height;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_MinScaleValue;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_MaxScaleValue;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_MinScaleValueWithoutUpsampling;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Rect*, int> get_NormalizedFieldOfViewLimit;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDigitalWindowCapability"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDigitalWindowCapability(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDigitalWindowCapability"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDigitalWindowCapability(Silk.NET.WinRT.IInspectable value)
    {
        return new IDigitalWindowCapability(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDigitalWindowCapability"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDigitalWindowCapability"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDigitalWindowCapability value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDigitalWindowCapability"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDigitalWindowCapability(Silk.NET.Windows.IUnknown value)
    {
        return new IDigitalWindowCapability(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDigitalWindowCapability"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDigitalWindowCapability"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDigitalWindowCapability value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
