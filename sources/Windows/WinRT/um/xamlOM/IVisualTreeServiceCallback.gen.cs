// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='IVisualTreeServiceCallback.xml' path='doc/member[@name="IVisualTreeServiceCallback"]/*'/>
[Guid("AA7A8931-80E4-4FEC-8F3B-553F87B4966E")]
[NativeTypeName("struct IVisualTreeServiceCallback : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IVisualTreeServiceCallback : IVisualTreeServiceCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVisualTreeServiceCallback));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVisualTreeServiceCallback*, Guid*, void**, int> )(lpVtbl[0]))((IVisualTreeServiceCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVisualTreeServiceCallback*, uint> )(lpVtbl[1]))((IVisualTreeServiceCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVisualTreeServiceCallback*, uint> )(lpVtbl[2]))((IVisualTreeServiceCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVisualTreeServiceCallback.xml' path='doc/member[@name="IVisualTreeServiceCallback.OnVisualTreeChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnVisualTreeChange(ParentChildRelation relation, VisualElement element, VisualMutationType mutationType)
    {
        return ((delegate* unmanaged<IVisualTreeServiceCallback*, ParentChildRelation, VisualElement, VisualMutationType, int> )(lpVtbl[3]))((IVisualTreeServiceCallback*)Unsafe.AsPointer(ref this), relation, element, mutationType);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnVisualTreeChange(ParentChildRelation relation, VisualElement element, VisualMutationType mutationType);
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
        [NativeTypeName("HRESULT (ParentChildRelation, VisualElement, VisualMutationType) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ParentChildRelation, VisualElement, VisualMutationType, int> OnVisualTreeChange;
    }
}