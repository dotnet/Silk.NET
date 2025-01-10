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

[Guid("9664BB6A-1EA6-4AA6-8074-ABE8851ECAE2")]
[NativeTypeName("struct IVideoTransformEffectDefinition : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoTransformEffectDefinition
    : IVideoTransformEffectDefinition.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoTransformEffectDefinition));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IVideoTransformEffectDefinition, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVideoTransformEffectDefinition, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVideoTransformEffectDefinition, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IVideoTransformEffectDefinition, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IVideoTransformEffectDefinition, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IVideoTransformEffectDefinition, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PaddingColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IVideoTransformEffectDefinition, Color*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_PaddingColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged<IVideoTransformEffectDefinition, Color, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OutputSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged<IVideoTransformEffectDefinition, Size*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_OutputSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size value)
    {
        return ((delegate* unmanaged<IVideoTransformEffectDefinition, Size, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CropRectangle(
        [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value
    )
    {
        return ((delegate* unmanaged<IVideoTransformEffectDefinition, Rect*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_CropRectangle([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value)
    {
        return ((delegate* unmanaged<IVideoTransformEffectDefinition, Rect, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Rotation(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaRotation *")]
            MediaRotation* value
    )
    {
        return (
            (delegate* unmanaged<IVideoTransformEffectDefinition, MediaRotation*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Rotation(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaRotation")] MediaRotation value
    )
    {
        return (
            (delegate* unmanaged<IVideoTransformEffectDefinition, MediaRotation, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Mirror(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaMirroringOptions *")]
            MediaMirroringOptions* value
    )
    {
        return (
            (delegate* unmanaged<IVideoTransformEffectDefinition, MediaMirroringOptions*, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Mirror(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaMirroringOptions")]
            MediaMirroringOptions value
    )
    {
        return (
            (delegate* unmanaged<IVideoTransformEffectDefinition, MediaMirroringOptions, int>)(
                (*lpVtbl)[15]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_ProcessingAlgorithm(
        [NativeTypeName("ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm")]
            MediaVideoProcessingAlgorithm value
    )
    {
        return (
            (delegate* unmanaged<
                IVideoTransformEffectDefinition,
                MediaVideoProcessingAlgorithm,
                int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ProcessingAlgorithm(
        [NativeTypeName("ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm *")]
            MediaVideoProcessingAlgorithm* value
    )
    {
        return (
            (delegate* unmanaged<
                IVideoTransformEffectDefinition,
                MediaVideoProcessingAlgorithm*,
                int>)((*lpVtbl)[17])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PaddingColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(7)]
        HRESULT put_PaddingColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(8)]
        HRESULT get_OutputSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(9)]
        HRESULT put_OutputSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size value);

        [VtblIndex(10)]
        HRESULT get_CropRectangle([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(11)]
        HRESULT put_CropRectangle([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value);

        [VtblIndex(12)]
        HRESULT get_Rotation(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaRotation *")]
                MediaRotation* value
        );

        [VtblIndex(13)]
        HRESULT put_Rotation(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaRotation")]
                MediaRotation value
        );

        [VtblIndex(14)]
        HRESULT get_Mirror(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaMirroringOptions *")]
                MediaMirroringOptions* value
        );

        [VtblIndex(15)]
        HRESULT put_Mirror(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaMirroringOptions")]
                MediaMirroringOptions value
        );

        [VtblIndex(16)]
        HRESULT put_ProcessingAlgorithm(
            [NativeTypeName("ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm")]
                MediaVideoProcessingAlgorithm value
        );

        [VtblIndex(17)]
        HRESULT get_ProcessingAlgorithm(
            [NativeTypeName("ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm *")]
                MediaVideoProcessingAlgorithm* value
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_PaddingColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color, int> put_PaddingColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Size*, int> get_OutputSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Size, int> put_OutputSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Rect*, int> get_CropRectangle;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Rect, int> put_CropRectangle;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::MediaRotation *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaRotation*, int> get_Rotation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::MediaRotation) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaRotation, int> put_Rotation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::MediaMirroringOptions *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaMirroringOptions*, int> get_Mirror;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::MediaMirroringOptions) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaMirroringOptions, int> put_Mirror;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaVideoProcessingAlgorithm,
            int> put_ProcessingAlgorithm;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaVideoProcessingAlgorithm*,
            int> get_ProcessingAlgorithm;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVideoTransformEffectDefinition"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVideoTransformEffectDefinition(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IVideoTransformEffectDefinition"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IVideoTransformEffectDefinition(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IVideoTransformEffectDefinition(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoTransformEffectDefinition"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoTransformEffectDefinition"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IVideoTransformEffectDefinition value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVideoTransformEffectDefinition"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVideoTransformEffectDefinition(Silk.NET.Windows.IUnknown value)
    {
        return new IVideoTransformEffectDefinition(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoTransformEffectDefinition"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoTransformEffectDefinition"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVideoTransformEffectDefinition value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
