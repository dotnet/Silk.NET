// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("F92C1B68-6320-5577-879E-9942621C3DD9")]
[NativeTypeName("struct IAccelerometerDataThreshold : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAccelerometerDataThreshold
    : IAccelerometerDataThreshold.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAccelerometerDataThreshold));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAccelerometerDataThreshold, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAccelerometerDataThreshold, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAccelerometerDataThreshold, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAccelerometerDataThreshold, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAccelerometerDataThreshold, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAccelerometerDataThreshold, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_XAxisInGForce(double* value)
    {
        return ((delegate* unmanaged<IAccelerometerDataThreshold, double*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_XAxisInGForce(double value)
    {
        return ((delegate* unmanaged<IAccelerometerDataThreshold, double, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_YAxisInGForce(double* value)
    {
        return ((delegate* unmanaged<IAccelerometerDataThreshold, double*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_YAxisInGForce(double value)
    {
        return ((delegate* unmanaged<IAccelerometerDataThreshold, double, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ZAxisInGForce(double* value)
    {
        return ((delegate* unmanaged<IAccelerometerDataThreshold, double*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ZAxisInGForce(double value)
    {
        return ((delegate* unmanaged<IAccelerometerDataThreshold, double, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_XAxisInGForce(double* value);

        [VtblIndex(7)]
        HRESULT put_XAxisInGForce(double value);

        [VtblIndex(8)]
        HRESULT get_YAxisInGForce(double* value);

        [VtblIndex(9)]
        HRESULT put_YAxisInGForce(double value);

        [VtblIndex(10)]
        HRESULT get_ZAxisInGForce(double* value);

        [VtblIndex(11)]
        HRESULT put_ZAxisInGForce(double value);
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

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_XAxisInGForce;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_XAxisInGForce;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_YAxisInGForce;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_YAxisInGForce;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_ZAxisInGForce;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_ZAxisInGForce;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAccelerometerDataThreshold"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAccelerometerDataThreshold(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAccelerometerDataThreshold"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAccelerometerDataThreshold(Silk.NET.WinRT.IInspectable value)
    {
        return new IAccelerometerDataThreshold(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAccelerometerDataThreshold"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAccelerometerDataThreshold"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAccelerometerDataThreshold value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAccelerometerDataThreshold"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAccelerometerDataThreshold(Silk.NET.Windows.IUnknown value)
    {
        return new IAccelerometerDataThreshold(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAccelerometerDataThreshold"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAccelerometerDataThreshold"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAccelerometerDataThreshold value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
