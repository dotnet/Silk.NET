// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("4A25EAF5-242D-4DFB-97F4-69B7C42576FF")]
[NativeTypeName("struct IMediaExtensionManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaExtensionManager : IMediaExtensionManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaExtensionManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaExtensionManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaExtensionManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaExtensionManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaExtensionManager, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaExtensionManager, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaExtensionManager, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RegisterSchemeHandler(HSTRING activatableClassId, HSTRING scheme)
    {
        return ((delegate* unmanaged<IMediaExtensionManager, HSTRING, HSTRING, int>)((*lpVtbl)[6]))(
            this,
            activatableClassId,
            scheme
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RegisterSchemeHandlerWithSettings(
        HSTRING activatableClassId,
        HSTRING scheme,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet configuration
    )
    {
        return (
            (delegate* unmanaged<IMediaExtensionManager, HSTRING, HSTRING, IPropertySet, int>)(
                (*lpVtbl)[7]
            )
        )(this, activatableClassId, scheme, configuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RegisterByteStreamHandler(
        HSTRING activatableClassId,
        HSTRING fileExtension,
        HSTRING mimeType
    )
    {
        return (
            (delegate* unmanaged<IMediaExtensionManager, HSTRING, HSTRING, HSTRING, int>)(
                (*lpVtbl)[8]
            )
        )(this, activatableClassId, fileExtension, mimeType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RegisterByteStreamHandlerWithSettings(
        HSTRING activatableClassId,
        HSTRING fileExtension,
        HSTRING mimeType,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet configuration
    )
    {
        return (
            (delegate* unmanaged<
                IMediaExtensionManager,
                HSTRING,
                HSTRING,
                HSTRING,
                IPropertySet,
                int>)((*lpVtbl)[9])
        )(this, activatableClassId, fileExtension, mimeType, configuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RegisterAudioDecoder(
        HSTRING activatableClassId,
        Guid inputSubtype,
        Guid outputSubtype
    )
    {
        return (
            (delegate* unmanaged<IMediaExtensionManager, HSTRING, Guid, Guid, int>)((*lpVtbl)[10])
        )(this, activatableClassId, inputSubtype, outputSubtype);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RegisterAudioDecoderWithSettings(
        HSTRING activatableClassId,
        Guid inputSubtype,
        Guid outputSubtype,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet configuration
    )
    {
        return (
            (delegate* unmanaged<IMediaExtensionManager, HSTRING, Guid, Guid, IPropertySet, int>)(
                (*lpVtbl)[11]
            )
        )(this, activatableClassId, inputSubtype, outputSubtype, configuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RegisterAudioEncoder(
        HSTRING activatableClassId,
        Guid inputSubtype,
        Guid outputSubtype
    )
    {
        return (
            (delegate* unmanaged<IMediaExtensionManager, HSTRING, Guid, Guid, int>)((*lpVtbl)[12])
        )(this, activatableClassId, inputSubtype, outputSubtype);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RegisterAudioEncoderWithSettings(
        HSTRING activatableClassId,
        Guid inputSubtype,
        Guid outputSubtype,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet configuration
    )
    {
        return (
            (delegate* unmanaged<IMediaExtensionManager, HSTRING, Guid, Guid, IPropertySet, int>)(
                (*lpVtbl)[13]
            )
        )(this, activatableClassId, inputSubtype, outputSubtype, configuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT RegisterVideoDecoder(
        HSTRING activatableClassId,
        Guid inputSubtype,
        Guid outputSubtype
    )
    {
        return (
            (delegate* unmanaged<IMediaExtensionManager, HSTRING, Guid, Guid, int>)((*lpVtbl)[14])
        )(this, activatableClassId, inputSubtype, outputSubtype);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT RegisterVideoDecoderWithSettings(
        HSTRING activatableClassId,
        Guid inputSubtype,
        Guid outputSubtype,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet configuration
    )
    {
        return (
            (delegate* unmanaged<IMediaExtensionManager, HSTRING, Guid, Guid, IPropertySet, int>)(
                (*lpVtbl)[15]
            )
        )(this, activatableClassId, inputSubtype, outputSubtype, configuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RegisterVideoEncoder(
        HSTRING activatableClassId,
        Guid inputSubtype,
        Guid outputSubtype
    )
    {
        return (
            (delegate* unmanaged<IMediaExtensionManager, HSTRING, Guid, Guid, int>)((*lpVtbl)[16])
        )(this, activatableClassId, inputSubtype, outputSubtype);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT RegisterVideoEncoderWithSettings(
        HSTRING activatableClassId,
        Guid inputSubtype,
        Guid outputSubtype,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet configuration
    )
    {
        return (
            (delegate* unmanaged<IMediaExtensionManager, HSTRING, Guid, Guid, IPropertySet, int>)(
                (*lpVtbl)[17]
            )
        )(this, activatableClassId, inputSubtype, outputSubtype, configuration);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RegisterSchemeHandler(HSTRING activatableClassId, HSTRING scheme);

        [VtblIndex(7)]
        HRESULT RegisterSchemeHandlerWithSettings(
            HSTRING activatableClassId,
            HSTRING scheme,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet configuration
        );

        [VtblIndex(8)]
        HRESULT RegisterByteStreamHandler(
            HSTRING activatableClassId,
            HSTRING fileExtension,
            HSTRING mimeType
        );

        [VtblIndex(9)]
        HRESULT RegisterByteStreamHandlerWithSettings(
            HSTRING activatableClassId,
            HSTRING fileExtension,
            HSTRING mimeType,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet configuration
        );

        [VtblIndex(10)]
        HRESULT RegisterAudioDecoder(
            HSTRING activatableClassId,
            Guid inputSubtype,
            Guid outputSubtype
        );

        [VtblIndex(11)]
        HRESULT RegisterAudioDecoderWithSettings(
            HSTRING activatableClassId,
            Guid inputSubtype,
            Guid outputSubtype,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet configuration
        );

        [VtblIndex(12)]
        HRESULT RegisterAudioEncoder(
            HSTRING activatableClassId,
            Guid inputSubtype,
            Guid outputSubtype
        );

        [VtblIndex(13)]
        HRESULT RegisterAudioEncoderWithSettings(
            HSTRING activatableClassId,
            Guid inputSubtype,
            Guid outputSubtype,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet configuration
        );

        [VtblIndex(14)]
        HRESULT RegisterVideoDecoder(
            HSTRING activatableClassId,
            Guid inputSubtype,
            Guid outputSubtype
        );

        [VtblIndex(15)]
        HRESULT RegisterVideoDecoderWithSettings(
            HSTRING activatableClassId,
            Guid inputSubtype,
            Guid outputSubtype,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet configuration
        );

        [VtblIndex(16)]
        HRESULT RegisterVideoEncoder(
            HSTRING activatableClassId,
            Guid inputSubtype,
            Guid outputSubtype
        );

        [VtblIndex(17)]
        HRESULT RegisterVideoEncoderWithSettings(
            HSTRING activatableClassId,
            Guid inputSubtype,
            Guid outputSubtype,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet configuration
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, int> RegisterSchemeHandler;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IPropertySet,
            int> RegisterSchemeHandlerWithSettings;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            HSTRING,
            int> RegisterByteStreamHandler;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            HSTRING,
            IPropertySet,
            int> RegisterByteStreamHandlerWithSettings;

        [NativeTypeName("HRESULT (HSTRING, GUID, GUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, Guid, Guid, int> RegisterAudioDecoder;

        [NativeTypeName(
            "HRESULT (HSTRING, GUID, GUID, ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            Guid,
            Guid,
            IPropertySet,
            int> RegisterAudioDecoderWithSettings;

        [NativeTypeName("HRESULT (HSTRING, GUID, GUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, Guid, Guid, int> RegisterAudioEncoder;

        [NativeTypeName(
            "HRESULT (HSTRING, GUID, GUID, ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            Guid,
            Guid,
            IPropertySet,
            int> RegisterAudioEncoderWithSettings;

        [NativeTypeName("HRESULT (HSTRING, GUID, GUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, Guid, Guid, int> RegisterVideoDecoder;

        [NativeTypeName(
            "HRESULT (HSTRING, GUID, GUID, ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            Guid,
            Guid,
            IPropertySet,
            int> RegisterVideoDecoderWithSettings;

        [NativeTypeName("HRESULT (HSTRING, GUID, GUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, Guid, Guid, int> RegisterVideoEncoder;

        [NativeTypeName(
            "HRESULT (HSTRING, GUID, GUID, ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            Guid,
            Guid,
            IPropertySet,
            int> RegisterVideoEncoderWithSettings;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaExtensionManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaExtensionManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaExtensionManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaExtensionManager(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaExtensionManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaExtensionManager"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaExtensionManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaExtensionManager value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaExtensionManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaExtensionManager(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaExtensionManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaExtensionManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaExtensionManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaExtensionManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
