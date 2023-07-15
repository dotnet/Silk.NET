// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IQuickActivate.xml' path='doc/member[@name="IQuickActivate"]/*'/>
[Guid("CF51ED10-62FE-11CF-BF86-00A0C9034836")]
[NativeTypeName("struct IQuickActivate : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IQuickActivate : IQuickActivate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IQuickActivate));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IQuickActivate*, Guid*, void**, int> )(lpVtbl[0]))((IQuickActivate*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IQuickActivate*, uint> )(lpVtbl[1]))((IQuickActivate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IQuickActivate*, uint> )(lpVtbl[2]))((IQuickActivate*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IQuickActivate.xml' path='doc/member[@name="IQuickActivate.QuickActivate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QuickActivate(QACONTAINER* pQaContainer, QACONTROL* pQaControl)
    {
        return ((delegate* unmanaged<IQuickActivate*, QACONTAINER*, QACONTROL*, int> )(lpVtbl[3]))((IQuickActivate*)Unsafe.AsPointer(ref this), pQaContainer, pQaControl);
    }

    /// <include file='IQuickActivate.xml' path='doc/member[@name="IQuickActivate.SetContentExtent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetContentExtent([NativeTypeName("LPSIZEL")] SIZE* pSizel)
    {
        return ((delegate* unmanaged<IQuickActivate*, SIZE*, int> )(lpVtbl[4]))((IQuickActivate*)Unsafe.AsPointer(ref this), pSizel);
    }

    /// <include file='IQuickActivate.xml' path='doc/member[@name="IQuickActivate.GetContentExtent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetContentExtent([NativeTypeName("LPSIZEL")] SIZE* pSizel)
    {
        return ((delegate* unmanaged<IQuickActivate*, SIZE*, int> )(lpVtbl[5]))((IQuickActivate*)Unsafe.AsPointer(ref this), pSizel);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QuickActivate(QACONTAINER* pQaContainer, QACONTROL* pQaControl);
        [VtblIndex(4)]
        HRESULT SetContentExtent([NativeTypeName("LPSIZEL")] SIZE* pSizel);
        [VtblIndex(5)]
        HRESULT GetContentExtent([NativeTypeName("LPSIZEL")] SIZE* pSizel);
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
        [NativeTypeName("HRESULT (QACONTAINER *, QACONTROL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, QACONTAINER*, QACONTROL*, int> QuickActivate;
        [NativeTypeName("HRESULT (LPSIZEL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE*, int> SetContentExtent;
        [NativeTypeName("HRESULT (LPSIZEL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE*, int> GetContentExtent;
    }
}