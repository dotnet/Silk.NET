// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("FAF1BA0A-30BA-409C-BEF7-CFFB6D03B8FB")]
[NativeTypeName("struct IGattPresentationFormatTypesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattPresentationFormatTypesStatics
    : IGattPresentationFormatTypesStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattPresentationFormatTypesStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGattPresentationFormatTypesStatics, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGattPresentationFormatTypesStatics, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Boolean(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Bit2(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Nibble(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_UInt8(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_UInt12(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_UInt16(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_UInt24(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_UInt32(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_UInt48(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_UInt64(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_UInt128(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SInt8(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_SInt12(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[18])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_SInt16(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[19])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_SInt24(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[20])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_SInt32(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[21])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_SInt48(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[22])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_SInt64(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[23])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_SInt128(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[24])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_Float32(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[25])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_Float64(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[26])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_SFloat(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[27])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_Float(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[28])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_DUInt16(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[29])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_Utf8(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[30])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_Utf16(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[31])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_Struct(byte* value)
    {
        return (
            (delegate* unmanaged<IGattPresentationFormatTypesStatics, byte*, int>)((*lpVtbl)[32])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Boolean(byte* value);

        [VtblIndex(7)]
        HRESULT get_Bit2(byte* value);

        [VtblIndex(8)]
        HRESULT get_Nibble(byte* value);

        [VtblIndex(9)]
        HRESULT get_UInt8(byte* value);

        [VtblIndex(10)]
        HRESULT get_UInt12(byte* value);

        [VtblIndex(11)]
        HRESULT get_UInt16(byte* value);

        [VtblIndex(12)]
        HRESULT get_UInt24(byte* value);

        [VtblIndex(13)]
        HRESULT get_UInt32(byte* value);

        [VtblIndex(14)]
        HRESULT get_UInt48(byte* value);

        [VtblIndex(15)]
        HRESULT get_UInt64(byte* value);

        [VtblIndex(16)]
        HRESULT get_UInt128(byte* value);

        [VtblIndex(17)]
        HRESULT get_SInt8(byte* value);

        [VtblIndex(18)]
        HRESULT get_SInt12(byte* value);

        [VtblIndex(19)]
        HRESULT get_SInt16(byte* value);

        [VtblIndex(20)]
        HRESULT get_SInt24(byte* value);

        [VtblIndex(21)]
        HRESULT get_SInt32(byte* value);

        [VtblIndex(22)]
        HRESULT get_SInt48(byte* value);

        [VtblIndex(23)]
        HRESULT get_SInt64(byte* value);

        [VtblIndex(24)]
        HRESULT get_SInt128(byte* value);

        [VtblIndex(25)]
        HRESULT get_Float32(byte* value);

        [VtblIndex(26)]
        HRESULT get_Float64(byte* value);

        [VtblIndex(27)]
        HRESULT get_SFloat(byte* value);

        [VtblIndex(28)]
        HRESULT get_Float(byte* value);

        [VtblIndex(29)]
        HRESULT get_DUInt16(byte* value);

        [VtblIndex(30)]
        HRESULT get_Utf8(byte* value);

        [VtblIndex(31)]
        HRESULT get_Utf16(byte* value);

        [VtblIndex(32)]
        HRESULT get_Struct(byte* value);
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

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Boolean;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Bit2;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Nibble;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_UInt8;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_UInt12;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_UInt16;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_UInt24;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_UInt32;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_UInt48;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_UInt64;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_UInt128;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_SInt8;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_SInt12;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_SInt16;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_SInt24;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_SInt32;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_SInt48;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_SInt64;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_SInt128;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Float32;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Float64;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_SFloat;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Float;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_DUInt16;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Utf8;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Utf16;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Struct;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGattPresentationFormatTypesStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGattPresentationFormatTypesStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGattPresentationFormatTypesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGattPresentationFormatTypesStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IGattPresentationFormatTypesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattPresentationFormatTypesStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGattPresentationFormatTypesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IGattPresentationFormatTypesStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGattPresentationFormatTypesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGattPresentationFormatTypesStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IGattPresentationFormatTypesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattPresentationFormatTypesStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGattPresentationFormatTypesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IGattPresentationFormatTypesStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
