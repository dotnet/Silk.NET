// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("7E311853-9ABA-4AC4-BB98-2FB176C3BFDD")]
[NativeTypeName("struct ITimedTextSourceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextSourceStatics
    : ITimedTextSourceStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedTextSourceStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITimedTextSourceStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITimedTextSourceStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITimedTextSourceStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ITimedTextSourceStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ITimedTextSourceStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ITimedTextSourceStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromStream(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream stream,
        [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource* value
    )
    {
        return (
            (delegate* unmanaged<
                ITimedTextSourceStatics,
                IRandomAccessStream,
                ITimedTextSource*,
                int>)((*lpVtbl)[6])
        )(this, stream, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromUri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource* value
    )
    {
        return (
            (delegate* unmanaged<
                ITimedTextSourceStatics,
                IUriRuntimeClass,
                ITimedTextSource*,
                int>)((*lpVtbl)[7])
        )(this, uri, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFromStreamWithLanguage(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream stream,
        HSTRING defaultLanguage,
        [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource* value
    )
    {
        return (
            (delegate* unmanaged<
                ITimedTextSourceStatics,
                IRandomAccessStream,
                HSTRING,
                ITimedTextSource*,
                int>)((*lpVtbl)[8])
        )(this, stream, defaultLanguage, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFromUriWithLanguage(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        HSTRING defaultLanguage,
        [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource* value
    )
    {
        return (
            (delegate* unmanaged<
                ITimedTextSourceStatics,
                IUriRuntimeClass,
                HSTRING,
                ITimedTextSource*,
                int>)((*lpVtbl)[9])
        )(this, uri, defaultLanguage, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromStream(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream stream,
            [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")]
                ITimedTextSource* value
        );

        [VtblIndex(7)]
        HRESULT CreateFromUri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")]
                ITimedTextSource* value
        );

        [VtblIndex(8)]
        HRESULT CreateFromStreamWithLanguage(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream stream,
            HSTRING defaultLanguage,
            [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")]
                ITimedTextSource* value
        );

        [VtblIndex(9)]
        HRESULT CreateFromUriWithLanguage(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            HSTRING defaultLanguage,
            [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")]
                ITimedTextSource* value
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
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Media::Core::ITimedTextSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStream,
            ITimedTextSource*,
            int> CreateFromStream;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Media::Core::ITimedTextSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass, ITimedTextSource*, int> CreateFromUri;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, HSTRING, ABI::Windows::Media::Core::ITimedTextSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStream,
            HSTRING,
            ITimedTextSource*,
            int> CreateFromStreamWithLanguage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Media::Core::ITimedTextSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            HSTRING,
            ITimedTextSource*,
            int> CreateFromUriWithLanguage;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITimedTextSourceStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITimedTextSourceStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITimedTextSourceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITimedTextSourceStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new ITimedTextSourceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedTextSourceStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedTextSourceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ITimedTextSourceStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITimedTextSourceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITimedTextSourceStatics(Silk.NET.Windows.IUnknown value)
    {
        return new ITimedTextSourceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedTextSourceStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedTextSourceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITimedTextSourceStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
