// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAccServerDocMgr.xml' path='doc/member[@name="IAccServerDocMgr"]/*'/>
[Guid("AD7C73CF-6DD5-4855-ABC2-B04BAD5B9153")]
[NativeTypeName("struct IAccServerDocMgr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAccServerDocMgr : IAccServerDocMgr.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAccServerDocMgr));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAccServerDocMgr*, Guid*, void**, int> )(lpVtbl[0]))((IAccServerDocMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAccServerDocMgr*, uint> )(lpVtbl[1]))((IAccServerDocMgr*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAccServerDocMgr*, uint> )(lpVtbl[2]))((IAccServerDocMgr*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAccServerDocMgr.xml' path='doc/member[@name="IAccServerDocMgr.NewDocument"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT NewDocument([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk)
    {
        return ((delegate* unmanaged<IAccServerDocMgr*, Guid*, IUnknown*, int> )(lpVtbl[3]))((IAccServerDocMgr*)Unsafe.AsPointer(ref this), riid, punk);
    }

    /// <include file='IAccServerDocMgr.xml' path='doc/member[@name="IAccServerDocMgr.RevokeDocument"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RevokeDocument(IUnknown* punk)
    {
        return ((delegate* unmanaged<IAccServerDocMgr*, IUnknown*, int> )(lpVtbl[4]))((IAccServerDocMgr*)Unsafe.AsPointer(ref this), punk);
    }

    /// <include file='IAccServerDocMgr.xml' path='doc/member[@name="IAccServerDocMgr.OnDocumentFocus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnDocumentFocus(IUnknown* punk)
    {
        return ((delegate* unmanaged<IAccServerDocMgr*, IUnknown*, int> )(lpVtbl[5]))((IAccServerDocMgr*)Unsafe.AsPointer(ref this), punk);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT NewDocument([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk);
        [VtblIndex(4)]
        HRESULT RevokeDocument(IUnknown* punk);
        [VtblIndex(5)]
        HRESULT OnDocumentFocus(IUnknown* punk);
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
        [NativeTypeName("HRESULT (const IID &, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> NewDocument;
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> RevokeDocument;
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> OnDocumentFocus;
    }
}