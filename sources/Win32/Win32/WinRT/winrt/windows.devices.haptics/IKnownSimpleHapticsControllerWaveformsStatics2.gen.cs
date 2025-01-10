// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A7D24C27-B79D-510A-BF79-FF6D49173E1D")]
[NativeTypeName("struct IKnownSimpleHapticsControllerWaveformsStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKnownSimpleHapticsControllerWaveformsStatics2
    : IKnownSimpleHapticsControllerWaveformsStatics2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_IKnownSimpleHapticsControllerWaveformsStatics2)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                IKnownSimpleHapticsControllerWaveformsStatics2,
                Guid*,
                void**,
                int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2, uint>)(
                (*lpVtbl)[1]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2, uint>)(
                (*lpVtbl)[2]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<
                IKnownSimpleHapticsControllerWaveformsStatics2,
                uint*,
                Guid**,
                int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BrushContinuous([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2, ushort*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ChiselMarkerContinuous([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2, ushort*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_EraserContinuous([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2, ushort*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Error([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2, ushort*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_GalaxyPenContinuous([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2, ushort*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Hover([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2, ushort*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_InkContinuous([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2, ushort*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_MarkerContinuous([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2, ushort*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_PencilContinuous([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2, ushort*, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Success([NativeTypeName("UINT16 *")] ushort* value)
    {
        return (
            (delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2, ushort*, int>)(
                (*lpVtbl)[15]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BrushContinuous([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(7)]
        HRESULT get_ChiselMarkerContinuous([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(8)]
        HRESULT get_EraserContinuous([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(9)]
        HRESULT get_Error([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(10)]
        HRESULT get_GalaxyPenContinuous([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(11)]
        HRESULT get_Hover([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(12)]
        HRESULT get_InkContinuous([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(13)]
        HRESULT get_MarkerContinuous([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(14)]
        HRESULT get_PencilContinuous([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(15)]
        HRESULT get_Success([NativeTypeName("UINT16 *")] ushort* value);
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

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_BrushContinuous;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_ChiselMarkerContinuous;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_EraserContinuous;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Error;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_GalaxyPenContinuous;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Hover;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_InkContinuous;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_MarkerContinuous;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_PencilContinuous;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Success;
    }

    /// <summary>Initializes a new instance of the <see cref = "IKnownSimpleHapticsControllerWaveformsStatics2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IKnownSimpleHapticsControllerWaveformsStatics2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IKnownSimpleHapticsControllerWaveformsStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IKnownSimpleHapticsControllerWaveformsStatics2(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IKnownSimpleHapticsControllerWaveformsStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IKnownSimpleHapticsControllerWaveformsStatics2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IKnownSimpleHapticsControllerWaveformsStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IKnownSimpleHapticsControllerWaveformsStatics2 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IKnownSimpleHapticsControllerWaveformsStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IKnownSimpleHapticsControllerWaveformsStatics2(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IKnownSimpleHapticsControllerWaveformsStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IKnownSimpleHapticsControllerWaveformsStatics2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IKnownSimpleHapticsControllerWaveformsStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IKnownSimpleHapticsControllerWaveformsStatics2 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
