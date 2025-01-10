// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B3E7549E-00B4-5B53-8BE8-353F6C433101")]
[NativeTypeName("struct IRectangleClip : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRectangleClip : IRectangleClip.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRectangleClip));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRectangleClip, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRectangleClip, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRectangleClip, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IRectangleClip, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IRectangleClip, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IRectangleClip, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Bottom(float* value)
    {
        return ((delegate* unmanaged<IRectangleClip, float*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Bottom(float value)
    {
        return ((delegate* unmanaged<IRectangleClip, float, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BottomLeftRadius(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
    )
    {
        return ((delegate* unmanaged<IRectangleClip, Vector2*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BottomLeftRadius(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
    )
    {
        return ((delegate* unmanaged<IRectangleClip, Vector2, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BottomRightRadius(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
    )
    {
        return ((delegate* unmanaged<IRectangleClip, Vector2*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_BottomRightRadius(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
    )
    {
        return ((delegate* unmanaged<IRectangleClip, Vector2, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Left(float* value)
    {
        return ((delegate* unmanaged<IRectangleClip, float*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Left(float value)
    {
        return ((delegate* unmanaged<IRectangleClip, float, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Right(float* value)
    {
        return ((delegate* unmanaged<IRectangleClip, float*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Right(float value)
    {
        return ((delegate* unmanaged<IRectangleClip, float, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Top(float* value)
    {
        return ((delegate* unmanaged<IRectangleClip, float*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_Top(float value)
    {
        return ((delegate* unmanaged<IRectangleClip, float, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_TopLeftRadius(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
    )
    {
        return ((delegate* unmanaged<IRectangleClip, Vector2*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_TopLeftRadius(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
    )
    {
        return ((delegate* unmanaged<IRectangleClip, Vector2, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_TopRightRadius(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
    )
    {
        return ((delegate* unmanaged<IRectangleClip, Vector2*, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_TopRightRadius(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
    )
    {
        return ((delegate* unmanaged<IRectangleClip, Vector2, int>)((*lpVtbl)[21]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Bottom(float* value);

        [VtblIndex(7)]
        HRESULT put_Bottom(float value);

        [VtblIndex(8)]
        HRESULT get_BottomLeftRadius(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
        );

        [VtblIndex(9)]
        HRESULT put_BottomLeftRadius(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
        );

        [VtblIndex(10)]
        HRESULT get_BottomRightRadius(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
        );

        [VtblIndex(11)]
        HRESULT put_BottomRightRadius(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
        );

        [VtblIndex(12)]
        HRESULT get_Left(float* value);

        [VtblIndex(13)]
        HRESULT put_Left(float value);

        [VtblIndex(14)]
        HRESULT get_Right(float* value);

        [VtblIndex(15)]
        HRESULT put_Right(float value);

        [VtblIndex(16)]
        HRESULT get_Top(float* value);

        [VtblIndex(17)]
        HRESULT put_Top(float value);

        [VtblIndex(18)]
        HRESULT get_TopLeftRadius(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
        );

        [VtblIndex(19)]
        HRESULT put_TopLeftRadius(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
        );

        [VtblIndex(20)]
        HRESULT get_TopRightRadius(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
        );

        [VtblIndex(21)]
        HRESULT put_TopRightRadius(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
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

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_Bottom;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_Bottom;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2*, int> get_BottomLeftRadius;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2, int> put_BottomLeftRadius;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2*, int> get_BottomRightRadius;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2, int> put_BottomRightRadius;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_Left;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_Left;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_Right;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_Right;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_Top;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_Top;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2*, int> get_TopLeftRadius;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2, int> put_TopLeftRadius;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2*, int> get_TopRightRadius;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2, int> put_TopRightRadius;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRectangleClip"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRectangleClip(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRectangleClip"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRectangleClip(Silk.NET.WinRT.IInspectable value)
    {
        return new IRectangleClip(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRectangleClip"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRectangleClip"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IRectangleClip value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRectangleClip"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRectangleClip(Silk.NET.Windows.IUnknown value)
    {
        return new IRectangleClip(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRectangleClip"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRectangleClip"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRectangleClip value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
