// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IPersistPropertyBag2.xml' path='doc/member[@name="IPersistPropertyBag2"]/*'/>
[Guid("22F55881-280B-11D0-A8A9-00A0C90C2004")]
[NativeTypeName("struct IPersistPropertyBag2 : IPersist")]
[NativeInheritance("IPersist")]
public unsafe partial struct IPersistPropertyBag2 : IPersistPropertyBag2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistPropertyBag2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPersistPropertyBag2*, Guid*, void**, int> )(lpVtbl[0]))((IPersistPropertyBag2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPersistPropertyBag2*, uint> )(lpVtbl[1]))((IPersistPropertyBag2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistPropertyBag2*, uint> )(lpVtbl[2]))((IPersistPropertyBag2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IPersist.GetClassID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IPersistPropertyBag2*, Guid*, int> )(lpVtbl[3]))((IPersistPropertyBag2*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <include file='IPersistPropertyBag2.xml' path='doc/member[@name="IPersistPropertyBag2.InitNew"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InitNew()
    {
        return ((delegate* unmanaged<IPersistPropertyBag2*, int> )(lpVtbl[4]))((IPersistPropertyBag2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPersistPropertyBag2.xml' path='doc/member[@name="IPersistPropertyBag2.Load"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(IPropertyBag2* pPropBag, IErrorLog* pErrLog)
    {
        return ((delegate* unmanaged<IPersistPropertyBag2*, IPropertyBag2*, IErrorLog*, int> )(lpVtbl[5]))((IPersistPropertyBag2*)Unsafe.AsPointer(ref this), pPropBag, pErrLog);
    }

    /// <include file='IPersistPropertyBag2.xml' path='doc/member[@name="IPersistPropertyBag2.Save"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save(IPropertyBag2* pPropBag, BOOL fClearDirty, BOOL fSaveAllProperties)
    {
        return ((delegate* unmanaged<IPersistPropertyBag2*, IPropertyBag2*, BOOL, BOOL, int> )(lpVtbl[6]))((IPersistPropertyBag2*)Unsafe.AsPointer(ref this), pPropBag, fClearDirty, fSaveAllProperties);
    }

    /// <include file='IPersistPropertyBag2.xml' path='doc/member[@name="IPersistPropertyBag2.IsDirty"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<IPersistPropertyBag2*, int> )(lpVtbl[7]))((IPersistPropertyBag2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IPersist.Interface
    {
        [VtblIndex(4)]
        HRESULT InitNew();
        [VtblIndex(5)]
        HRESULT Load(IPropertyBag2* pPropBag, IErrorLog* pErrLog);
        [VtblIndex(6)]
        HRESULT Save(IPropertyBag2* pPropBag, BOOL fClearDirty, BOOL fSaveAllProperties);
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
        public delegate* unmanaged<TSelf*, IPropertyBag2*, IErrorLog*, int> Load;
        [NativeTypeName("HRESULT (IPropertyBag2 *, BOOL, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyBag2*, BOOL, BOOL, int> Save;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsDirty;
    }
}