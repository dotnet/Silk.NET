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

[Guid("EF77E0D9-D158-4B7A-863F-203342FBFD41")]
[NativeTypeName("struct IMediaStreamSourceFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaStreamSourceFactory
    : IMediaStreamSourceFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaStreamSourceFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaStreamSourceFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaStreamSourceFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaStreamSourceFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaStreamSourceFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaStreamSourceFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaStreamSourceFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromDescriptor(
        [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor *")]
            IMediaStreamDescriptor descriptor,
        [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")]
            IMediaStreamSource* result
    )
    {
        return (
            (delegate* unmanaged<
                IMediaStreamSourceFactory,
                IMediaStreamDescriptor,
                IMediaStreamSource*,
                int>)((*lpVtbl)[6])
        )(this, descriptor, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromDescriptors(
        [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor *")]
            IMediaStreamDescriptor descriptor,
        [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor *")]
            IMediaStreamDescriptor descriptor2,
        [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")]
            IMediaStreamSource* result
    )
    {
        return (
            (delegate* unmanaged<
                IMediaStreamSourceFactory,
                IMediaStreamDescriptor,
                IMediaStreamDescriptor,
                IMediaStreamSource*,
                int>)((*lpVtbl)[7])
        )(this, descriptor, descriptor2, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromDescriptor(
            [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor *")]
                IMediaStreamDescriptor descriptor,
            [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")]
                IMediaStreamSource* result
        );

        [VtblIndex(7)]
        HRESULT CreateFromDescriptors(
            [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor *")]
                IMediaStreamDescriptor descriptor,
            [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor *")]
                IMediaStreamDescriptor descriptor2,
            [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")]
                IMediaStreamSource* result
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
            "HRESULT (ABI::Windows::Media::Core::IMediaStreamDescriptor *, ABI::Windows::Media::Core::IMediaStreamSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaStreamDescriptor,
            IMediaStreamSource*,
            int> CreateFromDescriptor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::IMediaStreamDescriptor *, ABI::Windows::Media::Core::IMediaStreamDescriptor *, ABI::Windows::Media::Core::IMediaStreamSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaStreamDescriptor,
            IMediaStreamDescriptor,
            IMediaStreamSource*,
            int> CreateFromDescriptors;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaStreamSourceFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaStreamSourceFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaStreamSourceFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaStreamSourceFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaStreamSourceFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaStreamSourceFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaStreamSourceFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaStreamSourceFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaStreamSourceFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaStreamSourceFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaStreamSourceFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaStreamSourceFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaStreamSourceFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaStreamSourceFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
