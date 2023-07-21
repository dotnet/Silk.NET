// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IElementBehaviorSubmit.xml' path='doc/member[@name="IElementBehaviorSubmit"]/*' />
[Guid("3050F646-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementBehaviorSubmit : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IElementBehaviorSubmit : IElementBehaviorSubmit.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementBehaviorSubmit));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementBehaviorSubmit*, Guid*, void**, int>)(lpVtbl[0]))((IElementBehaviorSubmit*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IElementBehaviorSubmit*, uint>)(lpVtbl[1]))((IElementBehaviorSubmit*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementBehaviorSubmit*, uint>)(lpVtbl[2]))((IElementBehaviorSubmit*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IElementBehaviorSubmit.xml' path='doc/member[@name="IElementBehaviorSubmit.GetSubmitInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSubmitInfo(IHTMLSubmitData* pSubmitData)
    {
        return ((delegate* unmanaged<IElementBehaviorSubmit*, IHTMLSubmitData*, int>)(lpVtbl[3]))((IElementBehaviorSubmit*)Unsafe.AsPointer(ref this), pSubmitData);
    }

    /// <include file='IElementBehaviorSubmit.xml' path='doc/member[@name="IElementBehaviorSubmit.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IElementBehaviorSubmit*, int>)(lpVtbl[4]))((IElementBehaviorSubmit*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSubmitInfo(IHTMLSubmitData* pSubmitData);

        [VtblIndex(4)]
        HRESULT Reset();
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

        [NativeTypeName("HRESULT (IHTMLSubmitData *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLSubmitData*, int> GetSubmitInfo;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
    }
}
