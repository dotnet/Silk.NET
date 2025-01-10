// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("22F55881-280B-11D0-A8A9-00A0C90C2004")]
[NativeTypeName("struct IPersistPropertyBag2 : IPersist")]
[NativeInheritance("IPersist")]
public unsafe partial struct IPersistPropertyBag2 : IPersistPropertyBag2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistPropertyBag2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPersistPropertyBag2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPersistPropertyBag2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistPropertyBag2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IPersistPropertyBag2, Guid*, int>)((*lpVtbl)[3]))(
            this,
            pClassID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InitNew()
    {
        return ((delegate* unmanaged<IPersistPropertyBag2, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(IPropertyBag2 pPropBag, IErrorLog pErrLog)
    {
        return (
            (delegate* unmanaged<IPersistPropertyBag2, IPropertyBag2, IErrorLog, int>)((*lpVtbl)[5])
        )(this, pPropBag, pErrLog);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save(IPropertyBag2 pPropBag, BOOL fClearDirty, BOOL fSaveAllProperties)
    {
        return (
            (delegate* unmanaged<IPersistPropertyBag2, IPropertyBag2, BOOL, BOOL, int>)(
                (*lpVtbl)[6]
            )
        )(this, pPropBag, fClearDirty, fSaveAllProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<IPersistPropertyBag2, int>)((*lpVtbl)[7]))(this);
    }

    public interface Interface : IPersist.Interface
    {
        [VtblIndex(4)]
        HRESULT InitNew();

        [VtblIndex(5)]
        HRESULT Load(IPropertyBag2 pPropBag, IErrorLog pErrLog);

        [VtblIndex(6)]
        HRESULT Save(IPropertyBag2 pPropBag, BOOL fClearDirty, BOOL fSaveAllProperties);

        [VtblIndex(7)]
        HRESULT IsDirty();
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
        public delegate* unmanaged<TSelf*, int> InitNew;

        [NativeTypeName("HRESULT (IPropertyBag2 *, IErrorLog *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyBag2, IErrorLog, int> Load;

        [NativeTypeName("HRESULT (IPropertyBag2 *, BOOL, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyBag2, BOOL, BOOL, int> Save;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsDirty;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPersistPropertyBag2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPersistPropertyBag2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPersist"/> to <see cref = "IPersistPropertyBag2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPersist"/> instance to be converted </param>
    public static explicit operator IPersistPropertyBag2(Silk.NET.Windows.IPersist value)
    {
        return new IPersistPropertyBag2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistPropertyBag2"/> to <see cref = "Silk.NET.Windows.IPersist"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistPropertyBag2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPersist(IPersistPropertyBag2 value)
    {
        return new Silk.NET.Windows.IPersist(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPersistPropertyBag2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPersistPropertyBag2(Silk.NET.Windows.IUnknown value)
    {
        return new IPersistPropertyBag2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistPropertyBag2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistPropertyBag2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPersistPropertyBag2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
