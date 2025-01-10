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

[Guid("430ADEB8-6842-5E55-9BDE-04B4EF3A8A57")]
[NativeTypeName("struct ICameraOcclusionState : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICameraOcclusionState : ICameraOcclusionState.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICameraOcclusionState));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICameraOcclusionState, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICameraOcclusionState, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICameraOcclusionState, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICameraOcclusionState, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICameraOcclusionState, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICameraOcclusionState, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsOccluded([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICameraOcclusionState, byte*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsOcclusionKind(
        [NativeTypeName("ABI::Windows::Media::Devices::CameraOcclusionKind")]
            CameraOcclusionKind occlusionKind,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<ICameraOcclusionState, CameraOcclusionKind, byte*, int>)(
                (*lpVtbl)[7]
            )
        )(this, occlusionKind, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsOccluded([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT IsOcclusionKind(
            [NativeTypeName("ABI::Windows::Media::Devices::CameraOcclusionKind")]
                CameraOcclusionKind occlusionKind,
            [NativeTypeName("boolean *")] byte* result
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsOccluded;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::CameraOcclusionKind, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CameraOcclusionKind, byte*, int> IsOcclusionKind;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICameraOcclusionState"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICameraOcclusionState(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICameraOcclusionState"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICameraOcclusionState(Silk.NET.WinRT.IInspectable value)
    {
        return new ICameraOcclusionState(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICameraOcclusionState"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICameraOcclusionState"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICameraOcclusionState value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICameraOcclusionState"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICameraOcclusionState(Silk.NET.Windows.IUnknown value)
    {
        return new ICameraOcclusionState(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICameraOcclusionState"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICameraOcclusionState"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICameraOcclusionState value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
