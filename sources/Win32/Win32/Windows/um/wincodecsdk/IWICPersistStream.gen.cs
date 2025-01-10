// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00675040-6908-45F8-86A3-49C7DFD6D9AD")]
[NativeTypeName("struct IWICPersistStream : IPersistStream")]
[NativeInheritance("IPersistStream")]
public unsafe partial struct IWICPersistStream : IWICPersistStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPersistStream));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICPersistStream, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICPersistStream, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICPersistStream, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IWICPersistStream, Guid*, int>)((*lpVtbl)[3]))(this, pClassID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<IWICPersistStream, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(IStream pStm)
    {
        return ((delegate* unmanaged<IWICPersistStream, IStream, int>)((*lpVtbl)[5]))(this, pStm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save(IStream pStm, BOOL fClearDirty)
    {
        return ((delegate* unmanaged<IWICPersistStream, IStream, BOOL, int>)((*lpVtbl)[6]))(
            this,
            pStm,
            fClearDirty
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSizeMax(ULARGE_INTEGER* pcbSize)
    {
        return ((delegate* unmanaged<IWICPersistStream, ULARGE_INTEGER*, int>)((*lpVtbl)[7]))(
            this,
            pcbSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT LoadEx(
        IStream pIStream,
        [NativeTypeName("const GUID *")] Guid* pguidPreferredVendor,
        [NativeTypeName("DWORD")] uint dwPersistOptions
    )
    {
        return ((delegate* unmanaged<IWICPersistStream, IStream, Guid*, uint, int>)((*lpVtbl)[8]))(
            this,
            pIStream,
            pguidPreferredVendor,
            dwPersistOptions
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SaveEx(
        IStream pIStream,
        [NativeTypeName("DWORD")] uint dwPersistOptions,
        BOOL fClearDirty
    )
    {
        return ((delegate* unmanaged<IWICPersistStream, IStream, uint, BOOL, int>)((*lpVtbl)[9]))(
            this,
            pIStream,
            dwPersistOptions,
            fClearDirty
        );
    }

    public interface Interface : IPersistStream.Interface
    {
        [VtblIndex(8)]
        HRESULT LoadEx(
            IStream pIStream,
            [NativeTypeName("const GUID *")] Guid* pguidPreferredVendor,
            [NativeTypeName("DWORD")] uint dwPersistOptions
        );

        [VtblIndex(9)]
        HRESULT SaveEx(
            IStream pIStream,
            [NativeTypeName("DWORD")] uint dwPersistOptions,
            BOOL fClearDirty
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

        [NativeTypeName("HRESULT (IStream *, const GUID *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, Guid*, uint, int> LoadEx;

        [NativeTypeName("HRESULT (IStream *, DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, uint, BOOL, int> SaveEx;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICPersistStream"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICPersistStream(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPersistStream"/> to <see cref = "IWICPersistStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPersistStream"/> instance to be converted </param>
    public static explicit operator IWICPersistStream(Silk.NET.Windows.IPersistStream value)
    {
        return new IWICPersistStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICPersistStream"/> to <see cref = "Silk.NET.Windows.IPersistStream"/>.</summary>
    /// <param name = "value">The <see cref = "IWICPersistStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPersistStream(IWICPersistStream value)
    {
        return new Silk.NET.Windows.IPersistStream(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPersist"/> to <see cref = "IWICPersistStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPersist"/> instance to be converted </param>
    public static explicit operator IWICPersistStream(Silk.NET.Windows.IPersist value)
    {
        return new IWICPersistStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICPersistStream"/> to <see cref = "Silk.NET.Windows.IPersist"/>.</summary>
    /// <param name = "value">The <see cref = "IWICPersistStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPersist(IWICPersistStream value)
    {
        return new Silk.NET.Windows.IPersist(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICPersistStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICPersistStream(Silk.NET.Windows.IUnknown value)
    {
        return new IWICPersistStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICPersistStream"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICPersistStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICPersistStream value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
