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

[Guid("7133FCE1-1769-4FF9-A7C1-38D2C4D42360")]
[NativeTypeName("struct IMediaPlaybackItemFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackItemFactory
    : IMediaPlaybackItemFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlaybackItemFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaPlaybackItemFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaPlaybackItemFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaPlaybackItemFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaPlaybackItemFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaPlaybackItemFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaPlaybackItemFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 *")] IMediaSource2 source,
        [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")]
            IMediaPlaybackItem* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackItemFactory,
                IMediaSource2,
                IMediaPlaybackItem*,
                int>)((*lpVtbl)[6])
        )(this, source, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 *")] IMediaSource2 source,
            [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")]
                IMediaPlaybackItem* value
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
            "HRESULT (ABI::Windows::Media::Core::IMediaSource2 *, ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaSource2, IMediaPlaybackItem*, int> Create;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaPlaybackItemFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaPlaybackItemFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaPlaybackItemFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaPlaybackItemFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaPlaybackItemFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlaybackItemFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlaybackItemFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaPlaybackItemFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaPlaybackItemFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaPlaybackItemFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaPlaybackItemFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlaybackItemFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlaybackItemFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaPlaybackItemFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
