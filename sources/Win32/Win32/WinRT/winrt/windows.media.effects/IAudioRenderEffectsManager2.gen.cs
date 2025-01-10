// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A844CD09-5ECC-44B3-BB4E-1DB07287139C")]
[NativeTypeName("struct IAudioRenderEffectsManager2 : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("Not supported starting in windows 10")]
public unsafe partial struct IAudioRenderEffectsManager2
    : IAudioRenderEffectsManager2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioRenderEffectsManager2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAudioRenderEffectsManager2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioRenderEffectsManager2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioRenderEffectsManager2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAudioRenderEffectsManager2, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAudioRenderEffectsManager2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAudioRenderEffectsManager2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Not supported starting in windows 10")]
    public HRESULT get_EffectsProviderThumbnail(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamWithContentType **")]
            IRandomAccessStreamWithContentType* value
    )
    {
        return (
            (delegate* unmanaged<
                IAudioRenderEffectsManager2,
                IRandomAccessStreamWithContentType*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("Not supported starting in windows 10")]
    public HRESULT get_EffectsProviderSettingsLabel(HSTRING* value)
    {
        return ((delegate* unmanaged<IAudioRenderEffectsManager2, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Not supported starting in windows 10")]
    public HRESULT ShowSettingsUI()
    {
        return ((delegate* unmanaged<IAudioRenderEffectsManager2, int>)((*lpVtbl)[8]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Not supported starting in windows 10")]
        HRESULT get_EffectsProviderThumbnail(
            [NativeTypeName(
                "ABI::Windows::Storage::Streams::IRandomAccessStreamWithContentType **"
            )]
                IRandomAccessStreamWithContentType* value
        );

        [VtblIndex(7)]
        [Obsolete("Not supported starting in windows 10")]
        HRESULT get_EffectsProviderSettingsLabel(HSTRING* value);

        [VtblIndex(8)]
        [Obsolete("Not supported starting in windows 10")]
        HRESULT ShowSettingsUI();
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
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamWithContentType **) __attribute__((stdcall))"
        )]
        [Obsolete("Not supported starting in windows 10")]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStreamWithContentType*,
            int> get_EffectsProviderThumbnail;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("Not supported starting in windows 10")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_EffectsProviderSettingsLabel;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        [Obsolete("Not supported starting in windows 10")]
        public delegate* unmanaged<TSelf*, int> ShowSettingsUI;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioRenderEffectsManager2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioRenderEffectsManager2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioRenderEffectsManager2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioRenderEffectsManager2(Silk.NET.WinRT.IInspectable value)
    {
        return new IAudioRenderEffectsManager2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioRenderEffectsManager2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioRenderEffectsManager2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAudioRenderEffectsManager2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioRenderEffectsManager2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioRenderEffectsManager2(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioRenderEffectsManager2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioRenderEffectsManager2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioRenderEffectsManager2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioRenderEffectsManager2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
