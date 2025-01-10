// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BD1AE5E0-A6AE-11CE-BD37-504200C10000")]
[NativeTypeName("struct IPersistMemory : IPersist")]
[NativeInheritance("IPersist")]
public unsafe partial struct IPersistMemory : IPersistMemory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistMemory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPersistMemory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPersistMemory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistMemory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IPersistMemory, Guid*, int>)((*lpVtbl)[3]))(this, pClassID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<IPersistMemory, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(
        [NativeTypeName("LPVOID")] void* pMem,
        [NativeTypeName("ULONG")] uint cbSize
    )
    {
        return ((delegate* unmanaged<IPersistMemory, void*, uint, int>)((*lpVtbl)[5]))(
            this,
            pMem,
            cbSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save(
        [NativeTypeName("LPVOID")] void* pMem,
        BOOL fClearDirty,
        [NativeTypeName("ULONG")] uint cbSize
    )
    {
        return ((delegate* unmanaged<IPersistMemory, void*, BOOL, uint, int>)((*lpVtbl)[6]))(
            this,
            pMem,
            fClearDirty,
            cbSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSizeMax([NativeTypeName("ULONG *")] uint* pCbSize)
    {
        return ((delegate* unmanaged<IPersistMemory, uint*, int>)((*lpVtbl)[7]))(this, pCbSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InitNew()
    {
        return ((delegate* unmanaged<IPersistMemory, int>)((*lpVtbl)[8]))(this);
    }

    public interface Interface : IPersist.Interface
    {
        [VtblIndex(4)]
        HRESULT IsDirty();

        [VtblIndex(5)]
        HRESULT Load([NativeTypeName("LPVOID")] void* pMem, [NativeTypeName("ULONG")] uint cbSize);

        [VtblIndex(6)]
        HRESULT Save(
            [NativeTypeName("LPVOID")] void* pMem,
            BOOL fClearDirty,
            [NativeTypeName("ULONG")] uint cbSize
        );

        [VtblIndex(7)]
        HRESULT GetSizeMax([NativeTypeName("ULONG *")] uint* pCbSize);

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

        [NativeTypeName("HRESULT (LPVOID, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, int> Load;

        [NativeTypeName("HRESULT (LPVOID, BOOL, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, BOOL, uint, int> Save;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSizeMax;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> InitNew;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPersistMemory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPersistMemory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPersist"/> to <see cref = "IPersistMemory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPersist"/> instance to be converted </param>
    public static explicit operator IPersistMemory(Silk.NET.Windows.IPersist value)
    {
        return new IPersistMemory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistMemory"/> to <see cref = "Silk.NET.Windows.IPersist"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistMemory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPersist(IPersistMemory value)
    {
        return new Silk.NET.Windows.IPersist(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPersistMemory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPersistMemory(Silk.NET.Windows.IUnknown value)
    {
        return new IPersistMemory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistMemory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistMemory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPersistMemory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
