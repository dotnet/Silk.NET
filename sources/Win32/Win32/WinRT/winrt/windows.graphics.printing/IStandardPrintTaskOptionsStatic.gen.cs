// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B4483D26-0DD0-4CD4-BAFF-930FC7D6A574")]
[NativeTypeName("struct IStandardPrintTaskOptionsStatic : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStandardPrintTaskOptionsStatic
    : IStandardPrintTaskOptionsStatic.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStandardPrintTaskOptionsStatic));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IStandardPrintTaskOptionsStatic, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IStandardPrintTaskOptionsStatic, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStandardPrintTaskOptionsStatic, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IStandardPrintTaskOptionsStatic, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IStandardPrintTaskOptionsStatic, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IStandardPrintTaskOptionsStatic, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MediaSize(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IStandardPrintTaskOptionsStatic, HSTRING*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MediaType(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IStandardPrintTaskOptionsStatic, HSTRING*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Orientation(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IStandardPrintTaskOptionsStatic, HSTRING*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PrintQuality(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IStandardPrintTaskOptionsStatic, HSTRING*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ColorMode(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IStandardPrintTaskOptionsStatic, HSTRING*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Duplex(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IStandardPrintTaskOptionsStatic, HSTRING*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Collation(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IStandardPrintTaskOptionsStatic, HSTRING*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Staple(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IStandardPrintTaskOptionsStatic, HSTRING*, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_HolePunch(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IStandardPrintTaskOptionsStatic, HSTRING*, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Binding(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IStandardPrintTaskOptionsStatic, HSTRING*, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Copies(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IStandardPrintTaskOptionsStatic, HSTRING*, int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_NUp(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IStandardPrintTaskOptionsStatic, HSTRING*, int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_InputBin(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IStandardPrintTaskOptionsStatic, HSTRING*, int>)((*lpVtbl)[18])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MediaSize(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_MediaType(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Orientation(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_PrintQuality(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_ColorMode(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Duplex(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Collation(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_Staple(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_HolePunch(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_Binding(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_Copies(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_NUp(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_InputBin(HSTRING* value);
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_MediaSize;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_MediaType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Orientation;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_PrintQuality;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ColorMode;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Duplex;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Collation;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Staple;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_HolePunch;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Binding;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Copies;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_NUp;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_InputBin;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStandardPrintTaskOptionsStatic"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStandardPrintTaskOptionsStatic(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStandardPrintTaskOptionsStatic"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStandardPrintTaskOptionsStatic(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IStandardPrintTaskOptionsStatic(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStandardPrintTaskOptionsStatic"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStandardPrintTaskOptionsStatic"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IStandardPrintTaskOptionsStatic value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStandardPrintTaskOptionsStatic"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStandardPrintTaskOptionsStatic(Silk.NET.Windows.IUnknown value)
    {
        return new IStandardPrintTaskOptionsStatic(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStandardPrintTaskOptionsStatic"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStandardPrintTaskOptionsStatic"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStandardPrintTaskOptionsStatic value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
