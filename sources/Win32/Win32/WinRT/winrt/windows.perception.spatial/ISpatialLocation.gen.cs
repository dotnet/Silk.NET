// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("1D81D29D-24A1-37D5-8FA1-39B4F9AD67E2")]
[NativeTypeName("struct ISpatialLocation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialLocation : ISpatialLocation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialLocation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialLocation, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpatialLocation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialLocation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISpatialLocation, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISpatialLocation, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISpatialLocation, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Position(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
    )
    {
        return ((delegate* unmanaged<ISpatialLocation, Vector3*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Orientation(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value
    )
    {
        return ((delegate* unmanaged<ISpatialLocation, Quaternion*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AbsoluteLinearVelocity(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
    )
    {
        return ((delegate* unmanaged<ISpatialLocation, Vector3*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AbsoluteLinearAcceleration(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
    )
    {
        return ((delegate* unmanaged<ISpatialLocation, Vector3*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete(
        "Use AbsoluteAngularVelocityAxisAngle instead of AbsoluteAngularVelocity. For more info, see MSDN."
    )]
    public HRESULT get_AbsoluteAngularVelocity(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value
    )
    {
        return ((delegate* unmanaged<ISpatialLocation, Quaternion*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete(
        "Use AbsoluteAngularAccelerationAxisAngle instead of AbsoluteAngularAcceleration. For more info, see MSDN."
    )]
    public HRESULT get_AbsoluteAngularAcceleration(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value
    )
    {
        return ((delegate* unmanaged<ISpatialLocation, Quaternion*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Position(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
        );

        [VtblIndex(7)]
        HRESULT get_Orientation(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value
        );

        [VtblIndex(8)]
        HRESULT get_AbsoluteLinearVelocity(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
        );

        [VtblIndex(9)]
        HRESULT get_AbsoluteLinearAcceleration(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
        );

        [VtblIndex(10)]
        [Obsolete(
            "Use AbsoluteAngularVelocityAxisAngle instead of AbsoluteAngularVelocity. For more info, see MSDN."
        )]
        HRESULT get_AbsoluteAngularVelocity(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value
        );

        [VtblIndex(11)]
        [Obsolete(
            "Use AbsoluteAngularAccelerationAxisAngle instead of AbsoluteAngularAcceleration. For more info, see MSDN."
        )]
        HRESULT get_AbsoluteAngularAcceleration(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3*, int> get_Position;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Quaternion *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Quaternion*, int> get_Orientation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3*, int> get_AbsoluteLinearVelocity;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3*, int> get_AbsoluteLinearAcceleration;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Quaternion *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use AbsoluteAngularVelocityAxisAngle instead of AbsoluteAngularVelocity. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, Quaternion*, int> get_AbsoluteAngularVelocity;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Quaternion *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use AbsoluteAngularAccelerationAxisAngle instead of AbsoluteAngularAcceleration. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, Quaternion*, int> get_AbsoluteAngularAcceleration;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialLocation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialLocation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpatialLocation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpatialLocation(Silk.NET.WinRT.IInspectable value)
    {
        return new ISpatialLocation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialLocation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialLocation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISpatialLocation value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialLocation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialLocation(Silk.NET.Windows.IUnknown value)
    {
        return new ISpatialLocation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialLocation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialLocation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpatialLocation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
