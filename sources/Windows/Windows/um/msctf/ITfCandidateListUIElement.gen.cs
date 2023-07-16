// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITfCandidateListUIElement.xml' path='doc/member[@name="ITfCandidateListUIElement"]/*'/>
[Guid("EA1EA138-19DF-11D7-A6D2-00065B84435C")]
[NativeTypeName("struct ITfCandidateListUIElement : ITfUIElement")]
[NativeInheritance("ITfUIElement")]
public unsafe partial struct ITfCandidateListUIElement : ITfCandidateListUIElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfCandidateListUIElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement*, Guid*, void**, int> )(lpVtbl[0]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement*, uint> )(lpVtbl[1]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement*, uint> )(lpVtbl[2]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ITfUIElement.GetDescription"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDescription)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement*, ushort**, int> )(lpVtbl[3]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), pbstrDescription);
    }

    /// <inheritdoc cref = "ITfUIElement.GetGUID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGUID(Guid* pguid)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement*, Guid*, int> )(lpVtbl[4]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), pguid);
    }

    /// <inheritdoc cref = "ITfUIElement.Show"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Show(BOOL bShow)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement*, BOOL, int> )(lpVtbl[5]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), bShow);
    }

    /// <inheritdoc cref = "ITfUIElement.IsShown"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsShown(BOOL* pbShow)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement*, BOOL*, int> )(lpVtbl[6]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), pbShow);
    }

    /// <include file='ITfCandidateListUIElement.xml' path='doc/member[@name="ITfCandidateListUIElement.GetUpdatedFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetUpdatedFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement*, uint*, int> )(lpVtbl[7]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), pdwFlags);
    }

    /// <include file='ITfCandidateListUIElement.xml' path='doc/member[@name="ITfCandidateListUIElement.GetDocumentMgr"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDocumentMgr(ITfDocumentMgr** ppdim)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement*, ITfDocumentMgr**, int> )(lpVtbl[8]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), ppdim);
    }

    /// <include file='ITfCandidateListUIElement.xml' path='doc/member[@name="ITfCandidateListUIElement.GetCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCount(uint* puCount)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement*, uint*, int> )(lpVtbl[9]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), puCount);
    }

    /// <include file='ITfCandidateListUIElement.xml' path='doc/member[@name="ITfCandidateListUIElement.GetSelection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetSelection(uint* puIndex)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement*, uint*, int> )(lpVtbl[10]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), puIndex);
    }

    /// <include file='ITfCandidateListUIElement.xml' path='doc/member[@name="ITfCandidateListUIElement.GetString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetString(uint uIndex, [NativeTypeName("BSTR *")] ushort** pstr)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement*, uint, ushort**, int> )(lpVtbl[11]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), uIndex, pstr);
    }

    /// <include file='ITfCandidateListUIElement.xml' path='doc/member[@name="ITfCandidateListUIElement.GetPageIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetPageIndex(uint* pIndex, uint uSize, uint* puPageCnt)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement*, uint*, uint, uint*, int> )(lpVtbl[12]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), pIndex, uSize, puPageCnt);
    }

    /// <include file='ITfCandidateListUIElement.xml' path='doc/member[@name="ITfCandidateListUIElement.SetPageIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetPageIndex(uint* pIndex, uint uPageCnt)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement*, uint*, uint, int> )(lpVtbl[13]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), pIndex, uPageCnt);
    }

    /// <include file='ITfCandidateListUIElement.xml' path='doc/member[@name="ITfCandidateListUIElement.GetCurrentPage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetCurrentPage(uint* puPage)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement*, uint*, int> )(lpVtbl[14]))((ITfCandidateListUIElement*)Unsafe.AsPointer(ref this), puPage);
    }

    public interface Interface : ITfUIElement.Interface
    {
        [VtblIndex(7)]
        HRESULT GetUpdatedFlags([NativeTypeName("DWORD *")] uint* pdwFlags);
        [VtblIndex(8)]
        HRESULT GetDocumentMgr(ITfDocumentMgr** ppdim);
        [VtblIndex(9)]
        HRESULT GetCount(uint* puCount);
        [VtblIndex(10)]
        HRESULT GetSelection(uint* puIndex);
        [VtblIndex(11)]
        HRESULT GetString(uint uIndex, [NativeTypeName("BSTR *")] ushort** pstr);
        [VtblIndex(12)]
        HRESULT GetPageIndex(uint* pIndex, uint uSize, uint* puPageCnt);
        [VtblIndex(13)]
        HRESULT SetPageIndex(uint* pIndex, uint uPageCnt);
        [VtblIndex(14)]
        HRESULT GetCurrentPage(uint* puPage);
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
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDescription;
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetGUID;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Show;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsShown;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetUpdatedFlags;
        [NativeTypeName("HRESULT (ITfDocumentMgr **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfDocumentMgr**, int> GetDocumentMgr;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSelection;
        [NativeTypeName("HRESULT (UINT, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetString;
        [NativeTypeName("HRESULT (UINT *, UINT, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint, uint*, int> GetPageIndex;
        [NativeTypeName("HRESULT (UINT *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint, int> SetPageIndex;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCurrentPage;
    }
}