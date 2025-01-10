// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("449494BC-B468-4927-96D7-BA90D31AB505")]
[NativeTypeName("struct IWICStreamProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICStreamProvider : IWICStreamProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICStreamProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICStreamProvider, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICStreamProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICStreamProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStream(IStream* ppIStream)
    {
        return ((delegate* unmanaged<IWICStreamProvider, IStream*, int>)((*lpVtbl)[3]))(
            this,
            ppIStream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPersistOptions([NativeTypeName("DWORD *")] uint* pdwPersistOptions)
    {
        return ((delegate* unmanaged<IWICStreamProvider, uint*, int>)((*lpVtbl)[4]))(
            this,
            pdwPersistOptions
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPreferredVendorGUID(Guid* pguidPreferredVendor)
    {
        return ((delegate* unmanaged<IWICStreamProvider, Guid*, int>)((*lpVtbl)[5]))(
            this,
            pguidPreferredVendor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RefreshStream()
    {
        return ((delegate* unmanaged<IWICStreamProvider, int>)((*lpVtbl)[6]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStream(IStream* ppIStream);

        [VtblIndex(4)]
        HRESULT GetPersistOptions([NativeTypeName("DWORD *")] uint* pdwPersistOptions);

        [VtblIndex(5)]
        HRESULT GetPreferredVendorGUID(Guid* pguidPreferredVendor);

        [VtblIndex(6)]
        HRESULT RefreshStream();
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

        [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, int> GetStream;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetPersistOptions;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetPreferredVendorGUID;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RefreshStream;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICStreamProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICStreamProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICStreamProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICStreamProvider(Silk.NET.Windows.IUnknown value)
    {
        return new IWICStreamProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICStreamProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICStreamProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICStreamProvider value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
