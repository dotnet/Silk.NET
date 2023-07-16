// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITfLangBarItem.xml' path='doc/member[@name="ITfLangBarItem"]/*'/>
[Guid("73540D69-EDEB-4EE9-96C9-23AA30B25916")]
[NativeTypeName("struct ITfLangBarItem : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfLangBarItem : ITfLangBarItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfLangBarItem));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfLangBarItem*, Guid*, void**, int> )(lpVtbl[0]))((ITfLangBarItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfLangBarItem*, uint> )(lpVtbl[1]))((ITfLangBarItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfLangBarItem*, uint> )(lpVtbl[2]))((ITfLangBarItem*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfLangBarItem.xml' path='doc/member[@name="ITfLangBarItem.GetInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetInfo(TF_LANGBARITEMINFO* pInfo)
    {
        return ((delegate* unmanaged<ITfLangBarItem*, TF_LANGBARITEMINFO*, int> )(lpVtbl[3]))((ITfLangBarItem*)Unsafe.AsPointer(ref this), pInfo);
    }

    /// <include file='ITfLangBarItem.xml' path='doc/member[@name="ITfLangBarItem.GetStatus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
    {
        return ((delegate* unmanaged<ITfLangBarItem*, uint*, int> )(lpVtbl[4]))((ITfLangBarItem*)Unsafe.AsPointer(ref this), pdwStatus);
    }

    /// <include file='ITfLangBarItem.xml' path='doc/member[@name="ITfLangBarItem.Show"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Show(BOOL fShow)
    {
        return ((delegate* unmanaged<ITfLangBarItem*, BOOL, int> )(lpVtbl[5]))((ITfLangBarItem*)Unsafe.AsPointer(ref this), fShow);
    }

    /// <include file='ITfLangBarItem.xml' path='doc/member[@name="ITfLangBarItem.GetTooltipString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetTooltipString([NativeTypeName("BSTR *")] ushort** pbstrToolTip)
    {
        return ((delegate* unmanaged<ITfLangBarItem*, ushort**, int> )(lpVtbl[6]))((ITfLangBarItem*)Unsafe.AsPointer(ref this), pbstrToolTip);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetInfo(TF_LANGBARITEMINFO* pInfo);
        [VtblIndex(4)]
        HRESULT GetStatus([NativeTypeName("DWORD *")] uint* pdwStatus);
        [VtblIndex(5)]
        HRESULT Show(BOOL fShow);
        [VtblIndex(6)]
        HRESULT GetTooltipString([NativeTypeName("BSTR *")] ushort** pbstrToolTip);
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
        [NativeTypeName("HRESULT (TF_LANGBARITEMINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TF_LANGBARITEMINFO*, int> GetInfo;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetStatus;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Show;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetTooltipString;
    }
}