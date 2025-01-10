// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("917A71C1-85F3-4DD1-B001-A50BFD21C8D2")]
[NativeTypeName("struct ISystemProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemProperties : ISystemProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISystemProperties));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISystemProperties, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISystemProperties, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISystemProperties, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISystemProperties, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISystemProperties, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISystemProperties, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Author(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemProperties, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Comment(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemProperties, HSTRING*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ItemNameDisplay(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemProperties, HSTRING*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Keywords(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemProperties, HSTRING*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Rating(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemProperties, HSTRING*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemProperties, HSTRING*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Audio(
        [NativeTypeName("ABI::Windows::Storage::ISystemAudioProperties **")]
            ISystemAudioProperties* value
    )
    {
        return (
            (delegate* unmanaged<ISystemProperties, ISystemAudioProperties*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_GPS(
        [NativeTypeName("ABI::Windows::Storage::ISystemGPSProperties **")]
            ISystemGPSProperties* value
    )
    {
        return (
            (delegate* unmanaged<ISystemProperties, ISystemGPSProperties*, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Media(
        [NativeTypeName("ABI::Windows::Storage::ISystemMediaProperties **")]
            ISystemMediaProperties* value
    )
    {
        return (
            (delegate* unmanaged<ISystemProperties, ISystemMediaProperties*, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Music(
        [NativeTypeName("ABI::Windows::Storage::ISystemMusicProperties **")]
            ISystemMusicProperties* value
    )
    {
        return (
            (delegate* unmanaged<ISystemProperties, ISystemMusicProperties*, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Photo(
        [NativeTypeName("ABI::Windows::Storage::ISystemPhotoProperties **")]
            ISystemPhotoProperties* value
    )
    {
        return (
            (delegate* unmanaged<ISystemProperties, ISystemPhotoProperties*, int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Video(
        [NativeTypeName("ABI::Windows::Storage::ISystemVideoProperties **")]
            ISystemVideoProperties* value
    )
    {
        return (
            (delegate* unmanaged<ISystemProperties, ISystemVideoProperties*, int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Image(
        [NativeTypeName("ABI::Windows::Storage::ISystemImageProperties **")]
            ISystemImageProperties* value
    )
    {
        return (
            (delegate* unmanaged<ISystemProperties, ISystemImageProperties*, int>)((*lpVtbl)[18])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Author(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Comment(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_ItemNameDisplay(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Keywords(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Rating(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Audio(
            [NativeTypeName("ABI::Windows::Storage::ISystemAudioProperties **")]
                ISystemAudioProperties* value
        );

        [VtblIndex(13)]
        HRESULT get_GPS(
            [NativeTypeName("ABI::Windows::Storage::ISystemGPSProperties **")]
                ISystemGPSProperties* value
        );

        [VtblIndex(14)]
        HRESULT get_Media(
            [NativeTypeName("ABI::Windows::Storage::ISystemMediaProperties **")]
                ISystemMediaProperties* value
        );

        [VtblIndex(15)]
        HRESULT get_Music(
            [NativeTypeName("ABI::Windows::Storage::ISystemMusicProperties **")]
                ISystemMusicProperties* value
        );

        [VtblIndex(16)]
        HRESULT get_Photo(
            [NativeTypeName("ABI::Windows::Storage::ISystemPhotoProperties **")]
                ISystemPhotoProperties* value
        );

        [VtblIndex(17)]
        HRESULT get_Video(
            [NativeTypeName("ABI::Windows::Storage::ISystemVideoProperties **")]
                ISystemVideoProperties* value
        );

        [VtblIndex(18)]
        HRESULT get_Image(
            [NativeTypeName("ABI::Windows::Storage::ISystemImageProperties **")]
                ISystemImageProperties* value
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Author;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Comment;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ItemNameDisplay;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Keywords;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Rating;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::ISystemAudioProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISystemAudioProperties*, int> get_Audio;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::ISystemGPSProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISystemGPSProperties*, int> get_GPS;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::ISystemMediaProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISystemMediaProperties*, int> get_Media;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::ISystemMusicProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISystemMusicProperties*, int> get_Music;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::ISystemPhotoProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISystemPhotoProperties*, int> get_Photo;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::ISystemVideoProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISystemVideoProperties*, int> get_Video;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::ISystemImageProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISystemImageProperties*, int> get_Image;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISystemProperties"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISystemProperties(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISystemProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISystemProperties(Silk.NET.WinRT.IInspectable value)
    {
        return new ISystemProperties(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISystemProperties"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISystemProperties"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISystemProperties value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISystemProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISystemProperties(Silk.NET.Windows.IUnknown value)
    {
        return new ISystemProperties(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISystemProperties"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISystemProperties"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISystemProperties value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
