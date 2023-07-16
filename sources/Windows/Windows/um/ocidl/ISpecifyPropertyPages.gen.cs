// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISpecifyPropertyPages.xml' path='doc/member[@name="ISpecifyPropertyPages"]/*'/>
[Guid("B196B28B-BAB4-101A-B69C-00AA00341D07")]
[NativeTypeName("struct ISpecifyPropertyPages : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpecifyPropertyPages : ISpecifyPropertyPages.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpecifyPropertyPages));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpecifyPropertyPages*, Guid*, void**, int> )(lpVtbl[0]))((ISpecifyPropertyPages*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpecifyPropertyPages*, uint> )(lpVtbl[1]))((ISpecifyPropertyPages*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpecifyPropertyPages*, uint> )(lpVtbl[2]))((ISpecifyPropertyPages*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpecifyPropertyPages.xml' path='doc/member[@name="ISpecifyPropertyPages.GetPages"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPages(CAUUID* pPages)
    {
        return ((delegate* unmanaged<ISpecifyPropertyPages*, CAUUID*, int> )(lpVtbl[3]))((ISpecifyPropertyPages*)Unsafe.AsPointer(ref this), pPages);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPages(CAUUID* pPages);
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
        [NativeTypeName("HRESULT (CAUUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CAUUID*, int> GetPages;
    }
}