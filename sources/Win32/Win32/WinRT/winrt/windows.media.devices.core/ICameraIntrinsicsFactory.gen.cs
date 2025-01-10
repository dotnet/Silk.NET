// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("C0DDC486-2132-4A34-A659-9BFE2A055712")]
[NativeTypeName("struct ICameraIntrinsicsFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICameraIntrinsicsFactory
    : ICameraIntrinsicsFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICameraIntrinsicsFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICameraIntrinsicsFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICameraIntrinsicsFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICameraIntrinsicsFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICameraIntrinsicsFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICameraIntrinsicsFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICameraIntrinsicsFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 focalLength,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 principalPoint,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 radialDistortion,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")]
            Vector2 tangentialDistortion,
        [NativeTypeName("UINT32")] uint imageWidth,
        [NativeTypeName("UINT32")] uint imageHeight,
        [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics **")]
            ICameraIntrinsics* result
    )
    {
        return (
            (delegate* unmanaged<
                ICameraIntrinsicsFactory,
                Vector2,
                Vector2,
                Vector3,
                Vector2,
                uint,
                uint,
                ICameraIntrinsics*,
                int>)((*lpVtbl)[6])
        )(
            this,
            focalLength,
            principalPoint,
            radialDistortion,
            tangentialDistortion,
            imageWidth,
            imageHeight,
            result
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 focalLength,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 principalPoint,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")]
                Vector3 radialDistortion,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")]
                Vector2 tangentialDistortion,
            [NativeTypeName("UINT32")] uint imageWidth,
            [NativeTypeName("UINT32")] uint imageHeight,
            [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics **")]
                ICameraIntrinsics* result
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
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2, ABI::Windows::Foundation::Numerics::Vector2, ABI::Windows::Foundation::Numerics::Vector3, ABI::Windows::Foundation::Numerics::Vector2, UINT32, UINT32, ABI::Windows::Media::Devices::Core::ICameraIntrinsics **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Vector2,
            Vector2,
            Vector3,
            Vector2,
            uint,
            uint,
            ICameraIntrinsics*,
            int> Create;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICameraIntrinsicsFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICameraIntrinsicsFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICameraIntrinsicsFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICameraIntrinsicsFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new ICameraIntrinsicsFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICameraIntrinsicsFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICameraIntrinsicsFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICameraIntrinsicsFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICameraIntrinsicsFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICameraIntrinsicsFactory(Silk.NET.Windows.IUnknown value)
    {
        return new ICameraIntrinsicsFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICameraIntrinsicsFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICameraIntrinsicsFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICameraIntrinsicsFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
