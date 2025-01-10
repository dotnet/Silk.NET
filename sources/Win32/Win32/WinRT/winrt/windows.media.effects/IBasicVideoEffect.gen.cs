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

[Guid("8262C7EF-B360-40BE-949B-2FF42FF35693")]
[NativeTypeName("struct IBasicVideoEffect : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBasicVideoEffect : IBasicVideoEffect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBasicVideoEffect));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBasicVideoEffect, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBasicVideoEffect, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBasicVideoEffect, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IBasicVideoEffect, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBasicVideoEffect, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBasicVideoEffect, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsReadOnly([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IBasicVideoEffect, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SupportedMemoryTypes(
        [NativeTypeName("ABI::Windows::Media::Effects::MediaMemoryTypes *")] MediaMemoryTypes* value
    )
    {
        return ((delegate* unmanaged<IBasicVideoEffect, MediaMemoryTypes*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_TimeIndependent([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IBasicVideoEffect, byte*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SupportedEncodingProperties(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaProperties__CVideoEncodingProperties_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return ((delegate* unmanaged<IBasicVideoEffect, IVectorView<IntPtr>**, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetEncodingProperties(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *")]
            IVideoEncodingProperties encodingProperties,
        [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DDevice *")]
            IDirect3DDevice device
    )
    {
        return (
            (delegate* unmanaged<
                IBasicVideoEffect,
                IVideoEncodingProperties,
                IDirect3DDevice,
                int>)((*lpVtbl)[10])
        )(this, encodingProperties, device);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ProcessFrame(
        [NativeTypeName("ABI::Windows::Media::Effects::IProcessVideoFrameContext *")]
            IProcessVideoFrameContext context
    )
    {
        return (
            (delegate* unmanaged<IBasicVideoEffect, IProcessVideoFrameContext, int>)((*lpVtbl)[11])
        )(this, context);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Close(
        [NativeTypeName("ABI::Windows::Media::Effects::MediaEffectClosedReason")]
            MediaEffectClosedReason reason
    )
    {
        return (
            (delegate* unmanaged<IBasicVideoEffect, MediaEffectClosedReason, int>)((*lpVtbl)[12])
        )(this, reason);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT DiscardQueuedFrames()
    {
        return ((delegate* unmanaged<IBasicVideoEffect, int>)((*lpVtbl)[13]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsReadOnly([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_SupportedMemoryTypes(
            [NativeTypeName("ABI::Windows::Media::Effects::MediaMemoryTypes *")]
                MediaMemoryTypes* value
        );

        [VtblIndex(8)]
        HRESULT get_TimeIndependent([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_SupportedEncodingProperties(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaProperties__CVideoEncodingProperties_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(10)]
        HRESULT SetEncodingProperties(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *")]
                IVideoEncodingProperties encodingProperties,
            [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DDevice *")]
                IDirect3DDevice device
        );

        [VtblIndex(11)]
        HRESULT ProcessFrame(
            [NativeTypeName("ABI::Windows::Media::Effects::IProcessVideoFrameContext *")]
                IProcessVideoFrameContext context
        );

        [VtblIndex(12)]
        HRESULT Close(
            [NativeTypeName("ABI::Windows::Media::Effects::MediaEffectClosedReason")]
                MediaEffectClosedReason reason
        );

        [VtblIndex(13)]
        HRESULT DiscardQueuedFrames();
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
        public delegate* unmanaged<TSelf*, byte*, int> get_IsReadOnly;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Effects::MediaMemoryTypes *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaMemoryTypes*, int> get_SupportedMemoryTypes;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_TimeIndependent;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaProperties__CVideoEncodingProperties_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<IntPtr>**,
            int> get_SupportedEncodingProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *, ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DDevice *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVideoEncodingProperties,
            IDirect3DDevice,
            int> SetEncodingProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Effects::IProcessVideoFrameContext *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IProcessVideoFrameContext, int> ProcessFrame;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Effects::MediaEffectClosedReason) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaEffectClosedReason, int> Close;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DiscardQueuedFrames;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBasicVideoEffect"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBasicVideoEffect(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBasicVideoEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBasicVideoEffect(Silk.NET.WinRT.IInspectable value)
    {
        return new IBasicVideoEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBasicVideoEffect"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBasicVideoEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBasicVideoEffect value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBasicVideoEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBasicVideoEffect(Silk.NET.Windows.IUnknown value)
    {
        return new IBasicVideoEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBasicVideoEffect"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBasicVideoEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBasicVideoEffect value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
