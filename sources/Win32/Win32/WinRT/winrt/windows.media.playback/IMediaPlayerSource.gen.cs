// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("BD4F8897-1423-4C3E-82C5-0FB1AF94F715")]
[NativeTypeName("struct IMediaPlayerSource : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlayerSource : IMediaPlayerSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlayerSource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaPlayerSource, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaPlayerSource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaPlayerSource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaPlayerSource, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaPlayerSource, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaPlayerSource, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ProtectionManager(
        [NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionManager **")]
            IMediaProtectionManager* value
    )
    {
        return (
            (delegate* unmanaged<IMediaPlayerSource, IMediaProtectionManager*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ProtectionManager(
        [NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionManager *")]
            IMediaProtectionManager value
    )
    {
        return (
            (delegate* unmanaged<IMediaPlayerSource, IMediaProtectionManager, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Use Source instead of SetFileSource.  For more info, see MSDN.")]
    public HRESULT SetFileSource(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file
    )
    {
        return ((delegate* unmanaged<IMediaPlayerSource, IStorageFile, int>)((*lpVtbl)[8]))(
            this,
            file
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("Use Source instead of SetStreamSource.  For more info, see MSDN.")]
    public HRESULT SetStreamSource(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream stream
    )
    {
        return ((delegate* unmanaged<IMediaPlayerSource, IRandomAccessStream, int>)((*lpVtbl)[9]))(
            this,
            stream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("Use Source instead of SetMediaSource.  For more info, see MSDN.")]
    public HRESULT SetMediaSource(
        [NativeTypeName("ABI::Windows::Media::Core::IMediaSource *")] IMediaSource source
    )
    {
        return ((delegate* unmanaged<IMediaPlayerSource, IMediaSource, int>)((*lpVtbl)[10]))(
            this,
            source
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ProtectionManager(
            [NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionManager **")]
                IMediaProtectionManager* value
        );

        [VtblIndex(7)]
        HRESULT put_ProtectionManager(
            [NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionManager *")]
                IMediaProtectionManager value
        );

        [VtblIndex(8)]
        [Obsolete("Use Source instead of SetFileSource.  For more info, see MSDN.")]
        HRESULT SetFileSource(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file
        );

        [VtblIndex(9)]
        [Obsolete("Use Source instead of SetStreamSource.  For more info, see MSDN.")]
        HRESULT SetStreamSource(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream stream
        );

        [VtblIndex(10)]
        [Obsolete("Use Source instead of SetMediaSource.  For more info, see MSDN.")]
        HRESULT SetMediaSource(
            [NativeTypeName("ABI::Windows::Media::Core::IMediaSource *")] IMediaSource source
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
            "HRESULT (ABI::Windows::Media::Protection::IMediaProtectionManager **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaProtectionManager*, int> get_ProtectionManager;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Protection::IMediaProtectionManager *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaProtectionManager, int> put_ProtectionManager;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *) __attribute__((stdcall))")]
        [Obsolete("Use Source instead of SetFileSource.  For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, IStorageFile, int> SetFileSource;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *) __attribute__((stdcall))"
        )]
        [Obsolete("Use Source instead of SetStreamSource.  For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, IRandomAccessStream, int> SetStreamSource;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::IMediaSource *) __attribute__((stdcall))"
        )]
        [Obsolete("Use Source instead of SetMediaSource.  For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, IMediaSource, int> SetMediaSource;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaPlayerSource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaPlayerSource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaPlayerSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaPlayerSource(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaPlayerSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlayerSource"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlayerSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaPlayerSource value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaPlayerSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaPlayerSource(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaPlayerSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlayerSource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlayerSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaPlayerSource value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
