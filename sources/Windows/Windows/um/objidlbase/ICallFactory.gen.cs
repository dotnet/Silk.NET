// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ICallFactory.xml' path='doc/member[@name="ICallFactory"]/*'/>
[Guid("1C733A30-2A1C-11CE-ADE5-00AA0044773D")]
[NativeTypeName("struct ICallFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICallFactory : ICallFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICallFactory));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICallFactory*, Guid*, void**, int> )(lpVtbl[0]))((ICallFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICallFactory*, uint> )(lpVtbl[1]))((ICallFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICallFactory*, uint> )(lpVtbl[2]))((ICallFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICallFactory.xml' path='doc/member[@name="ICallFactory.CreateCall"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateCall([NativeTypeName("const IID &")] Guid* riid, IUnknown* pCtrlUnk, [NativeTypeName("const IID &")] Guid* riid2, IUnknown** ppv)
    {
        return ((delegate* unmanaged<ICallFactory*, Guid*, IUnknown*, Guid*, IUnknown**, int> )(lpVtbl[3]))((ICallFactory*)Unsafe.AsPointer(ref this), riid, pCtrlUnk, riid2, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateCall([NativeTypeName("const IID &")] Guid* riid, IUnknown* pCtrlUnk, [NativeTypeName("const IID &")] Guid* riid2, IUnknown** ppv);
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
        [NativeTypeName("HRESULT (const IID &, IUnknown *, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, Guid*, IUnknown**, int> CreateCall;
    }
}