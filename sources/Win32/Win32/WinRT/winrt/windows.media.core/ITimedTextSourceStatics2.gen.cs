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

[Guid("B66B7602-923E-43FA-9633-587075812DB5")]
[NativeTypeName("struct ITimedTextSourceStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextSourceStatics2
    : ITimedTextSourceStatics2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedTextSourceStatics2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITimedTextSourceStatics2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITimedTextSourceStatics2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITimedTextSourceStatics2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ITimedTextSourceStatics2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ITimedTextSourceStatics2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ITimedTextSourceStatics2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromStreamWithIndex(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream stream,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream indexStream,
        [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource* result
    )
    {
        return (
            (delegate* unmanaged<
                ITimedTextSourceStatics2,
                IRandomAccessStream,
                IRandomAccessStream,
                ITimedTextSource*,
                int>)((*lpVtbl)[6])
        )(this, stream, indexStream, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromUriWithIndex(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass indexUri,
        [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource* result
    )
    {
        return (
            (delegate* unmanaged<
                ITimedTextSourceStatics2,
                IUriRuntimeClass,
                IUriRuntimeClass,
                ITimedTextSource*,
                int>)((*lpVtbl)[7])
        )(this, uri, indexUri, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFromStreamWithIndexAndLanguage(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream stream,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream indexStream,
        HSTRING defaultLanguage,
        [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource* result
    )
    {
        return (
            (delegate* unmanaged<
                ITimedTextSourceStatics2,
                IRandomAccessStream,
                IRandomAccessStream,
                HSTRING,
                ITimedTextSource*,
                int>)((*lpVtbl)[8])
        )(this, stream, indexStream, defaultLanguage, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFromUriWithIndexAndLanguage(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass indexUri,
        HSTRING defaultLanguage,
        [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")] ITimedTextSource* result
    )
    {
        return (
            (delegate* unmanaged<
                ITimedTextSourceStatics2,
                IUriRuntimeClass,
                IUriRuntimeClass,
                HSTRING,
                ITimedTextSource*,
                int>)((*lpVtbl)[9])
        )(this, uri, indexUri, defaultLanguage, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromStreamWithIndex(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream stream,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream indexStream,
            [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")]
                ITimedTextSource* result
        );

        [VtblIndex(7)]
        HRESULT CreateFromUriWithIndex(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass indexUri,
            [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")]
                ITimedTextSource* result
        );

        [VtblIndex(8)]
        HRESULT CreateFromStreamWithIndexAndLanguage(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream stream,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream indexStream,
            HSTRING defaultLanguage,
            [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")]
                ITimedTextSource* result
        );

        [VtblIndex(9)]
        HRESULT CreateFromUriWithIndexAndLanguage(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass indexUri,
            HSTRING defaultLanguage,
            [NativeTypeName("ABI::Windows::Media::Core::ITimedTextSource **")]
                ITimedTextSource* result
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
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Media::Core::ITimedTextSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStream,
            IRandomAccessStream,
            ITimedTextSource*,
            int> CreateFromStreamWithIndex;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Media::Core::ITimedTextSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            IUriRuntimeClass,
            ITimedTextSource*,
            int> CreateFromUriWithIndex;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Storage::Streams::IRandomAccessStream *, HSTRING, ABI::Windows::Media::Core::ITimedTextSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStream,
            IRandomAccessStream,
            HSTRING,
            ITimedTextSource*,
            int> CreateFromStreamWithIndexAndLanguage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Media::Core::ITimedTextSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            IUriRuntimeClass,
            HSTRING,
            ITimedTextSource*,
            int> CreateFromUriWithIndexAndLanguage;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITimedTextSourceStatics2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITimedTextSourceStatics2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITimedTextSourceStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITimedTextSourceStatics2(Silk.NET.WinRT.IInspectable value)
    {
        return new ITimedTextSourceStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedTextSourceStatics2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedTextSourceStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ITimedTextSourceStatics2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITimedTextSourceStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITimedTextSourceStatics2(Silk.NET.Windows.IUnknown value)
    {
        return new ITimedTextSourceStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedTextSourceStatics2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedTextSourceStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITimedTextSourceStatics2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
