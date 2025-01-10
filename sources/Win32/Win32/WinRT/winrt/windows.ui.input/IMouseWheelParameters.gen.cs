// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("EAD0CA44-9DED-4037-8149-5E4CC2564468")]
[NativeTypeName("struct IMouseWheelParameters : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMouseWheelParameters : IMouseWheelParameters.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMouseWheelParameters));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMouseWheelParameters, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMouseWheelParameters, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMouseWheelParameters, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMouseWheelParameters, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMouseWheelParameters, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMouseWheelParameters, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CharTranslation(
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value
    )
    {
        return ((delegate* unmanaged<IMouseWheelParameters, Point*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CharTranslation(
        [NativeTypeName("ABI::Windows::Foundation::Point")] Point value
    )
    {
        return ((delegate* unmanaged<IMouseWheelParameters, Point, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DeltaScale(float* value)
    {
        return ((delegate* unmanaged<IMouseWheelParameters, float*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DeltaScale(float value)
    {
        return ((delegate* unmanaged<IMouseWheelParameters, float, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DeltaRotationAngle(float* value)
    {
        return ((delegate* unmanaged<IMouseWheelParameters, float*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_DeltaRotationAngle(float value)
    {
        return ((delegate* unmanaged<IMouseWheelParameters, float, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PageTranslation(
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value
    )
    {
        return ((delegate* unmanaged<IMouseWheelParameters, Point*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_PageTranslation(
        [NativeTypeName("ABI::Windows::Foundation::Point")] Point value
    )
    {
        return ((delegate* unmanaged<IMouseWheelParameters, Point, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CharTranslation(
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value
        );

        [VtblIndex(7)]
        HRESULT put_CharTranslation(
            [NativeTypeName("ABI::Windows::Foundation::Point")] Point value
        );

        [VtblIndex(8)]
        HRESULT get_DeltaScale(float* value);

        [VtblIndex(9)]
        HRESULT put_DeltaScale(float value);

        [VtblIndex(10)]
        HRESULT get_DeltaRotationAngle(float* value);

        [VtblIndex(11)]
        HRESULT put_DeltaRotationAngle(float value);

        [VtblIndex(12)]
        HRESULT get_PageTranslation(
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value
        );

        [VtblIndex(13)]
        HRESULT put_PageTranslation(
            [NativeTypeName("ABI::Windows::Foundation::Point")] Point value
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Point*, int> get_CharTranslation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Point, int> put_CharTranslation;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_DeltaScale;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_DeltaScale;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_DeltaRotationAngle;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_DeltaRotationAngle;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Point*, int> get_PageTranslation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Point, int> put_PageTranslation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMouseWheelParameters"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMouseWheelParameters(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMouseWheelParameters"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMouseWheelParameters(Silk.NET.WinRT.IInspectable value)
    {
        return new IMouseWheelParameters(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMouseWheelParameters"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMouseWheelParameters"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMouseWheelParameters value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMouseWheelParameters"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMouseWheelParameters(Silk.NET.Windows.IUnknown value)
    {
        return new IMouseWheelParameters(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMouseWheelParameters"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMouseWheelParameters"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMouseWheelParameters value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
