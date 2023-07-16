// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITfLanguageProfileNotifySink.xml' path='doc/member[@name="ITfLanguageProfileNotifySink"]/*'/>
[Guid("43C9FE15-F494-4C17-9DE2-B8A4AC350AA8")]
[NativeTypeName("struct ITfLanguageProfileNotifySink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfLanguageProfileNotifySink : ITfLanguageProfileNotifySink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfLanguageProfileNotifySink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfLanguageProfileNotifySink*, Guid*, void**, int> )(lpVtbl[0]))((ITfLanguageProfileNotifySink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfLanguageProfileNotifySink*, uint> )(lpVtbl[1]))((ITfLanguageProfileNotifySink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfLanguageProfileNotifySink*, uint> )(lpVtbl[2]))((ITfLanguageProfileNotifySink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfLanguageProfileNotifySink.xml' path='doc/member[@name="ITfLanguageProfileNotifySink.OnLanguageChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnLanguageChange([NativeTypeName("LANGID")] ushort langid, BOOL* pfAccept)
    {
        return ((delegate* unmanaged<ITfLanguageProfileNotifySink*, ushort, BOOL*, int> )(lpVtbl[3]))((ITfLanguageProfileNotifySink*)Unsafe.AsPointer(ref this), langid, pfAccept);
    }

    /// <include file='ITfLanguageProfileNotifySink.xml' path='doc/member[@name="ITfLanguageProfileNotifySink.OnLanguageChanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnLanguageChanged()
    {
        return ((delegate* unmanaged<ITfLanguageProfileNotifySink*, int> )(lpVtbl[4]))((ITfLanguageProfileNotifySink*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnLanguageChange([NativeTypeName("LANGID")] ushort langid, BOOL* pfAccept);
        [VtblIndex(4)]
        HRESULT OnLanguageChanged();
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
        [NativeTypeName("HRESULT (LANGID, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, BOOL*, int> OnLanguageChange;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnLanguageChanged;
    }
}