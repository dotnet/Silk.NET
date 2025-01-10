// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E3BC42CE-4E5C-11D3-9144-00104BA11C5E")]
[NativeTypeName("struct IJolietDiscMaster : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IJolietDiscMaster : IJolietDiscMaster.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IJolietDiscMaster));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IJolietDiscMaster, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IJolietDiscMaster, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IJolietDiscMaster, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTotalDataBlocks([NativeTypeName("long *")] int* pnBlocks)
    {
        return ((delegate* unmanaged<IJolietDiscMaster, int*, int>)((*lpVtbl)[3]))(this, pnBlocks);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetUsedDataBlocks([NativeTypeName("long *")] int* pnBlocks)
    {
        return ((delegate* unmanaged<IJolietDiscMaster, int*, int>)((*lpVtbl)[4]))(this, pnBlocks);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDataBlockSize([NativeTypeName("long *")] int* pnBlockBytes)
    {
        return ((delegate* unmanaged<IJolietDiscMaster, int*, int>)((*lpVtbl)[5]))(
            this,
            pnBlockBytes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddData(IStorage pStorage, [NativeTypeName("long")] int lFileOverwrite)
    {
        return ((delegate* unmanaged<IJolietDiscMaster, IStorage, int, int>)((*lpVtbl)[6]))(
            this,
            pStorage,
            lFileOverwrite
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetJolietProperties(IPropertyStorage* ppPropStg)
    {
        return ((delegate* unmanaged<IJolietDiscMaster, IPropertyStorage*, int>)((*lpVtbl)[7]))(
            this,
            ppPropStg
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetJolietProperties(IPropertyStorage pPropStg)
    {
        return ((delegate* unmanaged<IJolietDiscMaster, IPropertyStorage, int>)((*lpVtbl)[8]))(
            this,
            pPropStg
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetTotalDataBlocks([NativeTypeName("long *")] int* pnBlocks);

        [VtblIndex(4)]
        HRESULT GetUsedDataBlocks([NativeTypeName("long *")] int* pnBlocks);

        [VtblIndex(5)]
        HRESULT GetDataBlockSize([NativeTypeName("long *")] int* pnBlockBytes);

        [VtblIndex(6)]
        HRESULT AddData(IStorage pStorage, [NativeTypeName("long")] int lFileOverwrite);

        [VtblIndex(7)]
        HRESULT GetJolietProperties(IPropertyStorage* ppPropStg);

        [VtblIndex(8)]
        HRESULT SetJolietProperties(IPropertyStorage pPropStg);
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

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetTotalDataBlocks;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetUsedDataBlocks;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetDataBlockSize;

        [NativeTypeName("HRESULT (IStorage *, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStorage, int, int> AddData;

        [NativeTypeName("HRESULT (IPropertyStorage **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyStorage*, int> GetJolietProperties;

        [NativeTypeName("HRESULT (IPropertyStorage *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyStorage, int> SetJolietProperties;
    }

    /// <summary>Initializes a new instance of the <see cref = "IJolietDiscMaster"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IJolietDiscMaster(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IJolietDiscMaster"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IJolietDiscMaster(Silk.NET.Windows.IUnknown value)
    {
        return new IJolietDiscMaster(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IJolietDiscMaster"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IJolietDiscMaster"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IJolietDiscMaster value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
