// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.editing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A902AE5D-7869-4830-8AB1-94DC01C05FA4")]
[NativeTypeName("struct IMediaOverlay : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaOverlay : IMediaOverlay.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaOverlay));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaOverlay, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaOverlay, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaOverlay, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaOverlay, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaOverlay, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaOverlay, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged<IMediaOverlay, Rect*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Position([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value)
    {
        return ((delegate* unmanaged<IMediaOverlay, Rect, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Delay([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged<IMediaOverlay, TimeSpan, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Delay(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IMediaOverlay, TimeSpan*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Opacity(double* value)
    {
        return ((delegate* unmanaged<IMediaOverlay, double*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Opacity(double value)
    {
        return ((delegate* unmanaged<IMediaOverlay, double, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Clone(
        [NativeTypeName("ABI::Windows::Media::Editing::IMediaOverlay **")] IMediaOverlay* result
    )
    {
        return ((delegate* unmanaged<IMediaOverlay, IMediaOverlay*, int>)((*lpVtbl)[12]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Clip(
        [NativeTypeName("ABI::Windows::Media::Editing::IMediaClip **")] IMediaClip* value
    )
    {
        return ((delegate* unmanaged<IMediaOverlay, IMediaClip*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_AudioEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaOverlay, byte*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_AudioEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IMediaOverlay, byte, int>)((*lpVtbl)[15]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(7)]
        HRESULT put_Position([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value);

        [VtblIndex(8)]
        HRESULT put_Delay([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(9)]
        HRESULT get_Delay([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(10)]
        HRESULT get_Opacity(double* value);

        [VtblIndex(11)]
        HRESULT put_Opacity(double value);

        [VtblIndex(12)]
        HRESULT Clone(
            [NativeTypeName("ABI::Windows::Media::Editing::IMediaOverlay **")] IMediaOverlay* result
        );

        [VtblIndex(13)]
        HRESULT get_Clip(
            [NativeTypeName("ABI::Windows::Media::Editing::IMediaClip **")] IMediaClip* value
        );

        [VtblIndex(14)]
        HRESULT get_AudioEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_AudioEnabled([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Rect*, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Rect, int> put_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan, int> put_Delay;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_Delay;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_Opacity;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_Opacity;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Editing::IMediaOverlay **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaOverlay*, int> Clone;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Editing::IMediaClip **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaClip*, int> get_Clip;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_AudioEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_AudioEnabled;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaOverlay"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaOverlay(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaOverlay"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaOverlay(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaOverlay(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaOverlay"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaOverlay"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaOverlay value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaOverlay"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaOverlay(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaOverlay(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaOverlay"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaOverlay"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaOverlay value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
