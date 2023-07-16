// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IQueryCodePage.xml' path='doc/member[@name="IQueryCodePage"]/*'/>
[Guid("C7B236CE-EE80-11D0-985F-006008059382")]
[NativeTypeName("struct IQueryCodePage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IQueryCodePage : IQueryCodePage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IQueryCodePage));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IQueryCodePage*, Guid*, void**, int> )(lpVtbl[0]))((IQueryCodePage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IQueryCodePage*, uint> )(lpVtbl[1]))((IQueryCodePage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IQueryCodePage*, uint> )(lpVtbl[2]))((IQueryCodePage*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IQueryCodePage.xml' path='doc/member[@name="IQueryCodePage.GetCodePage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCodePage(uint* puiCodePage)
    {
        return ((delegate* unmanaged<IQueryCodePage*, uint*, int> )(lpVtbl[3]))((IQueryCodePage*)Unsafe.AsPointer(ref this), puiCodePage);
    }

    /// <include file='IQueryCodePage.xml' path='doc/member[@name="IQueryCodePage.SetCodePage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetCodePage(uint uiCodePage)
    {
        return ((delegate* unmanaged<IQueryCodePage*, uint, int> )(lpVtbl[4]))((IQueryCodePage*)Unsafe.AsPointer(ref this), uiCodePage);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCodePage(uint* puiCodePage);
        [VtblIndex(4)]
        HRESULT SetCodePage(uint uiCodePage);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCodePage;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetCodePage;
    }
}