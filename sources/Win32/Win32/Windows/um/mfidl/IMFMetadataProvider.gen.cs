// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56181D2D-E221-4ADB-B1C8-3CEE6A53F76F")]
[NativeTypeName("struct IMFMetadataProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMetadataProvider : IMFMetadataProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMetadataProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMetadataProvider, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMetadataProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMetadataProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetMFMetadata(
        IMFPresentationDescriptor pPresentationDescriptor,
        [NativeTypeName("DWORD")] uint dwStreamIdentifier,
        [NativeTypeName("DWORD")] uint dwFlags,
        IMFMetadata* ppMFMetadata
    )
    {
        return (
            (delegate* unmanaged<
                IMFMetadataProvider,
                IMFPresentationDescriptor,
                uint,
                uint,
                IMFMetadata*,
                int>)((*lpVtbl)[3])
        )(this, pPresentationDescriptor, dwStreamIdentifier, dwFlags, ppMFMetadata);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetMFMetadata(
            IMFPresentationDescriptor pPresentationDescriptor,
            [NativeTypeName("DWORD")] uint dwStreamIdentifier,
            [NativeTypeName("DWORD")] uint dwFlags,
            IMFMetadata* ppMFMetadata
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

        [NativeTypeName(
            "HRESULT (IMFPresentationDescriptor *, DWORD, DWORD, IMFMetadata **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMFPresentationDescriptor,
            uint,
            uint,
            IMFMetadata*,
            int> GetMFMetadata;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMetadataProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMetadataProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMetadataProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMetadataProvider(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMetadataProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMetadataProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMetadataProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMetadataProvider value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
