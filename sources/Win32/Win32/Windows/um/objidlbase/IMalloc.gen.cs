// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000002-0000-0000-C000-000000000046")]
[NativeTypeName("struct IMalloc : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMalloc : IMalloc.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMalloc));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMalloc, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMalloc, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMalloc, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void* Alloc([NativeTypeName("SIZE_T")] nuint cb)
    {
        return ((delegate* unmanaged<IMalloc, nuint, void*>)((*lpVtbl)[3]))(this, cb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void* Realloc(void* pv, [NativeTypeName("SIZE_T")] nuint cb)
    {
        return ((delegate* unmanaged<IMalloc, void*, nuint, void*>)((*lpVtbl)[4]))(this, pv, cb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void Free(void* pv)
    {
        ((delegate* unmanaged<IMalloc, void*, void>)((*lpVtbl)[5]))(this, pv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetSize(void* pv)
    {
        return ((delegate* unmanaged<IMalloc, void*, nuint>)((*lpVtbl)[6]))(this, pv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public int DidAlloc(void* pv)
    {
        return ((delegate* unmanaged<IMalloc, void*, int>)((*lpVtbl)[7]))(this, pv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void HeapMinimize()
    {
        ((delegate* unmanaged<IMalloc, void>)((*lpVtbl)[8]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void* Alloc([NativeTypeName("SIZE_T")] nuint cb);

        [VtblIndex(4)]
        void* Realloc(void* pv, [NativeTypeName("SIZE_T")] nuint cb);

        [VtblIndex(5)]
        void Free(void* pv);

        [VtblIndex(6)]
        [return: NativeTypeName("SIZE_T")]
        nuint GetSize(void* pv);

        [VtblIndex(7)]
        int DidAlloc(void* pv);

        [VtblIndex(8)]
        void HeapMinimize();
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

        [NativeTypeName("void *(SIZE_T) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, void*> Alloc;

        [NativeTypeName("void *(void *, SIZE_T) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, nuint, void*> Realloc;

        [NativeTypeName("void (void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, void> Free;

        [NativeTypeName("SIZE_T (void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, nuint> GetSize;

        [NativeTypeName("int (void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, int> DidAlloc;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> HeapMinimize;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMalloc"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMalloc(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMalloc"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMalloc(Silk.NET.Windows.IUnknown value)
    {
        return new IMalloc(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMalloc"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMalloc"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMalloc value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
