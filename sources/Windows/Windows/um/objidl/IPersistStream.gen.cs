// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IPersistStream.xml' path='doc/member[@name="IPersistStream"]/*'/>
[Guid("00000109-0000-0000-C000-000000000046")]
[NativeTypeName("struct IPersistStream : IPersist")]
[NativeInheritance("IPersist")]
public unsafe partial struct IPersistStream : IPersistStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistStream));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPersistStream*, Guid*, void**, int> )(lpVtbl[0]))((IPersistStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPersistStream*, uint> )(lpVtbl[1]))((IPersistStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistStream*, uint> )(lpVtbl[2]))((IPersistStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IPersist.GetClassID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IPersistStream*, Guid*, int> )(lpVtbl[3]))((IPersistStream*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <include file='IPersistStream.xml' path='doc/member[@name="IPersistStream.IsDirty"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<IPersistStream*, int> )(lpVtbl[4]))((IPersistStream*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPersistStream.xml' path='doc/member[@name="IPersistStream.Load"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(IStream* pStm)
    {
        return ((delegate* unmanaged<IPersistStream*, IStream*, int> )(lpVtbl[5]))((IPersistStream*)Unsafe.AsPointer(ref this), pStm);
    }

    /// <include file='IPersistStream.xml' path='doc/member[@name="IPersistStream.Save"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save(IStream* pStm, BOOL fClearDirty)
    {
        return ((delegate* unmanaged<IPersistStream*, IStream*, BOOL, int> )(lpVtbl[6]))((IPersistStream*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
    }

    /// <include file='IPersistStream.xml' path='doc/member[@name="IPersistStream.GetSizeMax"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSizeMax(ULARGE_INTEGER* pcbSize)
    {
        return ((delegate* unmanaged<IPersistStream*, ULARGE_INTEGER*, int> )(lpVtbl[7]))((IPersistStream*)Unsafe.AsPointer(ref this), pcbSize);
    }

    public interface Interface : IPersist.Interface
    {
        [VtblIndex(4)]
        HRESULT IsDirty();
        [VtblIndex(5)]
        HRESULT Load(IStream* pStm);
        [VtblIndex(6)]
        HRESULT Save(IStream* pStm, BOOL fClearDirty);
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
        public delegate* unmanaged<TSelf*, IStream*, int> Load;
        [NativeTypeName("HRESULT (IStream *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, BOOL, int> Save;
        [NativeTypeName("HRESULT (ULARGE_INTEGER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER*, int> GetSizeMax;
    }
}