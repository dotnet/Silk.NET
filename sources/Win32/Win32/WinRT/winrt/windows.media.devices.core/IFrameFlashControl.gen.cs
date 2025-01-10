// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("75D5F6C7-BD45-4FAB-9375-45AC04B332C2")]
[NativeTypeName("struct IFrameFlashControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFrameFlashControl : IFrameFlashControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFrameFlashControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFrameFlashControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFrameFlashControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFrameFlashControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IFrameFlashControl, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IFrameFlashControl, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IFrameFlashControl, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Mode(
        [NativeTypeName("ABI::Windows::Media::Devices::Core::FrameFlashMode *")]
            FrameFlashMode* value
    )
    {
        return ((delegate* unmanaged<IFrameFlashControl, FrameFlashMode*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Mode(
        [NativeTypeName("ABI::Windows::Media::Devices::Core::FrameFlashMode")] FrameFlashMode value
    )
    {
        return ((delegate* unmanaged<IFrameFlashControl, FrameFlashMode, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Auto([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IFrameFlashControl, byte*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Auto([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IFrameFlashControl, byte, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RedEyeReduction([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IFrameFlashControl, byte*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_RedEyeReduction([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IFrameFlashControl, byte, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PowerPercent(float* value)
    {
        return ((delegate* unmanaged<IFrameFlashControl, float*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_PowerPercent(float value)
    {
        return ((delegate* unmanaged<IFrameFlashControl, float, int>)((*lpVtbl)[13]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Mode(
            [NativeTypeName("ABI::Windows::Media::Devices::Core::FrameFlashMode *")]
                FrameFlashMode* value
        );

        [VtblIndex(7)]
        HRESULT put_Mode(
            [NativeTypeName("ABI::Windows::Media::Devices::Core::FrameFlashMode")]
                FrameFlashMode value
        );

        [VtblIndex(8)]
        HRESULT get_Auto([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_Auto([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_RedEyeReduction([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_RedEyeReduction([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_PowerPercent(float* value);

        [VtblIndex(13)]
        HRESULT put_PowerPercent(float value);
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
            "HRESULT (ABI::Windows::Media::Devices::Core::FrameFlashMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FrameFlashMode*, int> get_Mode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::Core::FrameFlashMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FrameFlashMode, int> put_Mode;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Auto;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_Auto;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_RedEyeReduction;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_RedEyeReduction;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_PowerPercent;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_PowerPercent;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFrameFlashControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFrameFlashControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFrameFlashControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFrameFlashControl(Silk.NET.WinRT.IInspectable value)
    {
        return new IFrameFlashControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFrameFlashControl"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFrameFlashControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IFrameFlashControl value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFrameFlashControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFrameFlashControl(Silk.NET.Windows.IUnknown value)
    {
        return new IFrameFlashControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFrameFlashControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFrameFlashControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFrameFlashControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
