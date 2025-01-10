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

[Guid("C8F3F363-FF5E-4582-A9A8-0550F85A4A76")]
[NativeTypeName("struct IPhotoConfirmationControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhotoConfirmationControl
    : IPhotoConfirmationControl.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhotoConfirmationControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPhotoConfirmationControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPhotoConfirmationControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPhotoConfirmationControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPhotoConfirmationControl, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPhotoConfirmationControl, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPhotoConfirmationControl, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Supported([NativeTypeName("boolean *")] byte* pbSupported)
    {
        return ((delegate* unmanaged<IPhotoConfirmationControl, byte*, int>)((*lpVtbl)[6]))(
            this,
            pbSupported
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Enabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPhotoConfirmationControl, byte*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Enabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IPhotoConfirmationControl, byte, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PixelFormat(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaPixelFormat *")]
            MediaPixelFormat* format
    )
    {
        return (
            (delegate* unmanaged<IPhotoConfirmationControl, MediaPixelFormat*, int>)((*lpVtbl)[9])
        )(this, format);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_PixelFormat(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaPixelFormat")]
            MediaPixelFormat format
    )
    {
        return (
            (delegate* unmanaged<IPhotoConfirmationControl, MediaPixelFormat, int>)((*lpVtbl)[10])
        )(this, format);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Supported([NativeTypeName("boolean *")] byte* pbSupported);

        [VtblIndex(7)]
        HRESULT get_Enabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT put_Enabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT get_PixelFormat(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaPixelFormat *")]
                MediaPixelFormat* format
        );

        [VtblIndex(10)]
        HRESULT put_PixelFormat(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaPixelFormat")]
                MediaPixelFormat format
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
        public delegate* unmanaged<TSelf*, byte*, int> get_Supported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Enabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_Enabled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::MediaPixelFormat *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaPixelFormat*, int> get_PixelFormat;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::MediaPixelFormat) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaPixelFormat, int> put_PixelFormat;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPhotoConfirmationControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPhotoConfirmationControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPhotoConfirmationControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPhotoConfirmationControl(Silk.NET.WinRT.IInspectable value)
    {
        return new IPhotoConfirmationControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhotoConfirmationControl"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPhotoConfirmationControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPhotoConfirmationControl value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPhotoConfirmationControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPhotoConfirmationControl(Silk.NET.Windows.IUnknown value)
    {
        return new IPhotoConfirmationControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhotoConfirmationControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPhotoConfirmationControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPhotoConfirmationControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
