// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLEditHost2.xml' path='doc/member[@name="IHTMLEditHost2"]/*'/>
[Guid("3050F848-98B5-11CF-BB82-00AA00BDCE0D")]
[NativeTypeName("struct IHTMLEditHost2 : IHTMLEditHost")]
[NativeInheritance("IHTMLEditHost")]
public unsafe partial struct IHTMLEditHost2 : IHTMLEditHost2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLEditHost2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLEditHost2*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLEditHost2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLEditHost2*, uint> )(lpVtbl[1]))((IHTMLEditHost2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLEditHost2*, uint> )(lpVtbl[2]))((IHTMLEditHost2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IHTMLEditHost.SnapRect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SnapRect(IHTMLElement* pIElement, RECT* prcNew, ELEMENT_CORNER eHandle)
    {
        return ((delegate* unmanaged<IHTMLEditHost2*, IHTMLElement*, RECT*, ELEMENT_CORNER, int> )(lpVtbl[3]))((IHTMLEditHost2*)Unsafe.AsPointer(ref this), pIElement, prcNew, eHandle);
    }

    /// <include file='IHTMLEditHost2.xml' path='doc/member[@name="IHTMLEditHost2.PreDrag"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT PreDrag()
    {
        return ((delegate* unmanaged<IHTMLEditHost2*, int> )(lpVtbl[4]))((IHTMLEditHost2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IHTMLEditHost.Interface
    {
        [VtblIndex(4)]
        HRESULT PreDrag();
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
        [NativeTypeName("HRESULT (IHTMLElement *, RECT *, ELEMENT_CORNER) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, RECT*, ELEMENT_CORNER, int> SnapRect;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PreDrag;
    }
}