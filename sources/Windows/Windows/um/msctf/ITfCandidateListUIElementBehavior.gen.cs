// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfCandidateListUIElementBehavior.xml' path='doc/member[@name="ITfCandidateListUIElementBehavior"]/*'/>
[Guid("85FAD185-58CE-497A-9460-355366B64B9A")]
[NativeTypeName("struct ITfCandidateListUIElementBehavior : ITfCandidateListUIElement")]
[NativeInheritance("ITfCandidateListUIElement")]
public unsafe partial struct ITfCandidateListUIElementBehavior : ITfCandidateListUIElementBehavior.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfCandidateListUIElementBehavior));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, Guid*, void**, int> )(lpVtbl[0]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint> )(lpVtbl[1]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint> )(lpVtbl[2]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ITfUIElement.GetDescription"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDescription)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, ushort**, int> )(lpVtbl[3]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), pbstrDescription);
    }

    /// <inheritdoc cref = "ITfUIElement.GetGUID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGUID(Guid* pguid)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, Guid*, int> )(lpVtbl[4]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), pguid);
    }

    /// <inheritdoc cref = "ITfUIElement.Show"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Show(BOOL bShow)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, BOOL, int> )(lpVtbl[5]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), bShow);
    }

    /// <inheritdoc cref = "ITfUIElement.IsShown"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsShown(BOOL* pbShow)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, BOOL*, int> )(lpVtbl[6]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), pbShow);
    }

    /// <inheritdoc cref = "ITfCandidateListUIElement.GetUpdatedFlags"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetUpdatedFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint*, int> )(lpVtbl[7]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), pdwFlags);
    }

    /// <inheritdoc cref = "ITfCandidateListUIElement.GetDocumentMgr"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDocumentMgr(ITfDocumentMgr** ppdim)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, ITfDocumentMgr**, int> )(lpVtbl[8]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), ppdim);
    }

    /// <inheritdoc cref = "ITfCandidateListUIElement.GetCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCount(uint* puCount)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint*, int> )(lpVtbl[9]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), puCount);
    }

    /// <inheritdoc cref = "ITfCandidateListUIElement.GetSelection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetSelection(uint* puIndex)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint*, int> )(lpVtbl[10]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), puIndex);
    }

    /// <inheritdoc cref = "ITfCandidateListUIElement.GetString"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetString(uint uIndex, [NativeTypeName("BSTR *")] ushort** pstr)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint, ushort**, int> )(lpVtbl[11]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), uIndex, pstr);
    }

    /// <inheritdoc cref = "ITfCandidateListUIElement.GetPageIndex"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetPageIndex(uint* pIndex, uint uSize, uint* puPageCnt)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint*, uint, uint*, int> )(lpVtbl[12]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), pIndex, uSize, puPageCnt);
    }

    /// <inheritdoc cref = "ITfCandidateListUIElement.SetPageIndex"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetPageIndex(uint* pIndex, uint uPageCnt)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint*, uint, int> )(lpVtbl[13]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), pIndex, uPageCnt);
    }

    /// <inheritdoc cref = "ITfCandidateListUIElement.GetCurrentPage"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetCurrentPage(uint* puPage)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint*, int> )(lpVtbl[14]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), puPage);
    }

    /// <include file='ITfCandidateListUIElementBehavior.xml' path='doc/member[@name="ITfCandidateListUIElementBehavior.SetSelection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetSelection(uint nIndex)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint, int> )(lpVtbl[15]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), nIndex);
    }

    /// <include file='ITfCandidateListUIElementBehavior.xml' path='doc/member[@name="ITfCandidateListUIElementBehavior.Finalize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Finalize()
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, int> )(lpVtbl[16]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfCandidateListUIElementBehavior.xml' path='doc/member[@name="ITfCandidateListUIElementBehavior.Abort"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Abort()
    {
        return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, int> )(lpVtbl[17]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : ITfCandidateListUIElement.Interface
    {
        [VtblIndex(15)]
        HRESULT SetSelection(uint nIndex);
        [VtblIndex(16)]
        HRESULT Finalize();
        [VtblIndex(17)]
        HRESULT Abort();
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
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetSelection;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Finalize;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Abort;
    }
}