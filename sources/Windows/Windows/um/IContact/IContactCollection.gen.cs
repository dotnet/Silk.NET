// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IContact.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IContactCollection.xml' path='doc/member[@name="IContactCollection"]/*'/>
[Guid("B6AFA338-D779-11D9-8BDE-F66BAD1E3F3A")]
[NativeTypeName("struct IContactCollection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IContactCollection : IContactCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactCollection));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContactCollection*, Guid*, void**, int> )(lpVtbl[0]))((IContactCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IContactCollection*, uint> )(lpVtbl[1]))((IContactCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactCollection*, uint> )(lpVtbl[2]))((IContactCollection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IContactCollection.xml' path='doc/member[@name="IContactCollection.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IContactCollection*, int> )(lpVtbl[3]))((IContactCollection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IContactCollection.xml' path='doc/member[@name="IContactCollection.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Next()
    {
        return ((delegate* unmanaged<IContactCollection*, int> )(lpVtbl[4]))((IContactCollection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IContactCollection.xml' path='doc/member[@name="IContactCollection.GetCurrent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrent(IContact** ppContact)
    {
        return ((delegate* unmanaged<IContactCollection*, IContact**, int> )(lpVtbl[5]))((IContactCollection*)Unsafe.AsPointer(ref this), ppContact);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Reset();
        [VtblIndex(4)]
        HRESULT Next();
        [VtblIndex(5)]
        HRESULT GetCurrent(IContact** ppContact);
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Next;
        [NativeTypeName("HRESULT (IContact **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IContact**, int> GetCurrent;
    }
}