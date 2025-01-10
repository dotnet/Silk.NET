// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7FD52380-4E07-101B-AE2D-08002B2EC713")]
[NativeTypeName("struct IPersistStreamInit : IPersist")]
[NativeInheritance("IPersist")]
public unsafe partial struct IPersistStreamInit : IPersistStreamInit.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistStreamInit));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPersistStreamInit, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPersistStreamInit, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistStreamInit, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IPersistStreamInit, Guid*, int>)((*lpVtbl)[3]))(
            this,
            pClassID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<IPersistStreamInit, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load([NativeTypeName("LPSTREAM")] IStream pStm)
    {
        return ((delegate* unmanaged<IPersistStreamInit, IStream, int>)((*lpVtbl)[5]))(this, pStm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save([NativeTypeName("LPSTREAM")] IStream pStm, BOOL fClearDirty)
    {
        return ((delegate* unmanaged<IPersistStreamInit, IStream, BOOL, int>)((*lpVtbl)[6]))(
            this,
            pStm,
            fClearDirty
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSizeMax(ULARGE_INTEGER* pCbSize)
    {
        return ((delegate* unmanaged<IPersistStreamInit, ULARGE_INTEGER*, int>)((*lpVtbl)[7]))(
            this,
            pCbSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InitNew()
    {
        return ((delegate* unmanaged<IPersistStreamInit, int>)((*lpVtbl)[8]))(this);
    }

    public interface Interface : IPersist.Interface
    {
        [VtblIndex(4)]
        HRESULT IsDirty();

        [VtblIndex(5)]
        HRESULT Load([NativeTypeName("LPSTREAM")] IStream pStm);

        [VtblIndex(6)]
        HRESULT Save([NativeTypeName("LPSTREAM")] IStream pStm, BOOL fClearDirty);

        [VtblIndex(7)]
        HRESULT GetSizeMax(ULARGE_INTEGER* pCbSize);

        [VtblIndex(8)]
        HRESULT InitNew();
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

        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetClassID;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsDirty;

        [NativeTypeName("HRESULT (LPSTREAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, int> Load;

        [NativeTypeName("HRESULT (LPSTREAM, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, BOOL, int> Save;

        [NativeTypeName("HRESULT (ULARGE_INTEGER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER*, int> GetSizeMax;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> InitNew;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPersistStreamInit"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPersistStreamInit(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPersist"/> to <see cref = "IPersistStreamInit"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPersist"/> instance to be converted </param>
    public static explicit operator IPersistStreamInit(Silk.NET.Windows.IPersist value)
    {
        return new IPersistStreamInit(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistStreamInit"/> to <see cref = "Silk.NET.Windows.IPersist"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistStreamInit"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPersist(IPersistStreamInit value)
    {
        return new Silk.NET.Windows.IPersist(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPersistStreamInit"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPersistStreamInit(Silk.NET.Windows.IUnknown value)
    {
        return new IPersistStreamInit(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistStreamInit"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistStreamInit"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPersistStreamInit value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
