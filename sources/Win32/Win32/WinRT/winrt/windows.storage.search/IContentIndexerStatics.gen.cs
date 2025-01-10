// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("8C488375-B37E-4C60-9BA8-B760FDA3E59D")]
[NativeTypeName("struct IContentIndexerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContentIndexerStatics : IContentIndexerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContentIndexerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContentIndexerStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContentIndexerStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContentIndexerStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IContentIndexerStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IContentIndexerStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IContentIndexerStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetIndexerWithName(
        HSTRING indexName,
        [NativeTypeName("ABI::Windows::Storage::Search::IContentIndexer **")] IContentIndexer* index
    )
    {
        return (
            (delegate* unmanaged<IContentIndexerStatics, HSTRING, IContentIndexer*, int>)(
                (*lpVtbl)[6]
            )
        )(this, indexName, index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetIndexer(
        [NativeTypeName("ABI::Windows::Storage::Search::IContentIndexer **")] IContentIndexer* index
    )
    {
        return ((delegate* unmanaged<IContentIndexerStatics, IContentIndexer*, int>)((*lpVtbl)[7]))(
            this,
            index
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetIndexerWithName(
            HSTRING indexName,
            [NativeTypeName("ABI::Windows::Storage::Search::IContentIndexer **")]
                IContentIndexer* index
        );

        [VtblIndex(7)]
        HRESULT GetIndexer(
            [NativeTypeName("ABI::Windows::Storage::Search::IContentIndexer **")]
                IContentIndexer* index
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
            "HRESULT (HSTRING, ABI::Windows::Storage::Search::IContentIndexer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IContentIndexer*, int> GetIndexerWithName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::IContentIndexer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContentIndexer*, int> GetIndexer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContentIndexerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContentIndexerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IContentIndexerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IContentIndexerStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IContentIndexerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContentIndexerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IContentIndexerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IContentIndexerStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContentIndexerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContentIndexerStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IContentIndexerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContentIndexerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContentIndexerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContentIndexerStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
