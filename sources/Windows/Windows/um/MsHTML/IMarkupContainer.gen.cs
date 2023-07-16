// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMarkupContainer.xml' path='doc/member[@name="IMarkupContainer"]/*'/>
[Guid("3050F5F9-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IMarkupContainer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMarkupContainer : IMarkupContainer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMarkupContainer));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMarkupContainer*, Guid*, void**, int> )(lpVtbl[0]))((IMarkupContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMarkupContainer*, uint> )(lpVtbl[1]))((IMarkupContainer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMarkupContainer*, uint> )(lpVtbl[2]))((IMarkupContainer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMarkupContainer.xml' path='doc/member[@name="IMarkupContainer.OwningDoc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OwningDoc(IHTMLDocument2** ppDoc)
    {
        return ((delegate* unmanaged<IMarkupContainer*, IHTMLDocument2**, int> )(lpVtbl[3]))((IMarkupContainer*)Unsafe.AsPointer(ref this), ppDoc);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OwningDoc(IHTMLDocument2** ppDoc);
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
        [NativeTypeName("HRESULT (IHTMLDocument2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDocument2**, int> OwningDoc;
    }
}