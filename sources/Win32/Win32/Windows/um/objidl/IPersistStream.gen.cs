// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000109-0000-0000-C000-000000000046")]
[NativeTypeName("struct IPersistStream : IPersist")]
[NativeInheritance("IPersist")]
public unsafe partial struct IPersistStream : IPersistStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistStream));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPersistStream, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPersistStream, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistStream, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IPersistStream, Guid*, int>)((*lpVtbl)[3]))(this, pClassID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<IPersistStream, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(IStream pStm)
    {
        return ((delegate* unmanaged<IPersistStream, IStream, int>)((*lpVtbl)[5]))(this, pStm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save(IStream pStm, BOOL fClearDirty)
    {
        return ((delegate* unmanaged<IPersistStream, IStream, BOOL, int>)((*lpVtbl)[6]))(
            this,
            pStm,
            fClearDirty
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSizeMax(ULARGE_INTEGER* pcbSize)
    {
        return ((delegate* unmanaged<IPersistStream, ULARGE_INTEGER*, int>)((*lpVtbl)[7]))(
            this,
            pcbSize
        );
    }

    public interface Interface : IPersist.Interface
    {
        [VtblIndex(4)]
        HRESULT IsDirty();

        [VtblIndex(5)]
        HRESULT Load(IStream pStm);

        [VtblIndex(6)]
        HRESULT Save(IStream pStm, BOOL fClearDirty);

        [VtblIndex(7)]
        HRESULT GetSizeMax(ULARGE_INTEGER* pcbSize);
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

        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, int> Load;

        [NativeTypeName("HRESULT (IStream *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, BOOL, int> Save;

        [NativeTypeName("HRESULT (ULARGE_INTEGER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER*, int> GetSizeMax;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPersistStream"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPersistStream(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPersist"/> to <see cref = "IPersistStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPersist"/> instance to be converted </param>
    public static explicit operator IPersistStream(Silk.NET.Windows.IPersist value)
    {
        return new IPersistStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistStream"/> to <see cref = "Silk.NET.Windows.IPersist"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPersist(IPersistStream value)
    {
        return new Silk.NET.Windows.IPersist(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPersistStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPersistStream(Silk.NET.Windows.IUnknown value)
    {
        return new IPersistStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistStream"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPersistStream value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
