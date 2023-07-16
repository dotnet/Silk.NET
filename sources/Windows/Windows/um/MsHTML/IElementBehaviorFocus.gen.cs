// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IElementBehaviorFocus.xml' path='doc/member[@name="IElementBehaviorFocus"]/*'/>
[Guid("3050F6B6-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementBehaviorFocus : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IElementBehaviorFocus : IElementBehaviorFocus.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementBehaviorFocus));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementBehaviorFocus*, Guid*, void**, int> )(lpVtbl[0]))((IElementBehaviorFocus*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IElementBehaviorFocus*, uint> )(lpVtbl[1]))((IElementBehaviorFocus*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementBehaviorFocus*, uint> )(lpVtbl[2]))((IElementBehaviorFocus*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IElementBehaviorFocus.xml' path='doc/member[@name="IElementBehaviorFocus.GetFocusRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFocusRect(RECT* pRect)
    {
        return ((delegate* unmanaged<IElementBehaviorFocus*, RECT*, int> )(lpVtbl[3]))((IElementBehaviorFocus*)Unsafe.AsPointer(ref this), pRect);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFocusRect(RECT* pRect);
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
        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> GetFocusRect;
    }
}