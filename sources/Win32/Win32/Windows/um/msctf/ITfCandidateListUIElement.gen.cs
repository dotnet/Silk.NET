// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EA1EA138-19DF-11D7-A6D2-00065B84435C")]
[NativeTypeName("struct ITfCandidateListUIElement : ITfUIElement")]
[NativeInheritance("ITfUIElement")]
public unsafe partial struct ITfCandidateListUIElement
    : ITfCandidateListUIElement.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfCandidateListUIElement));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDescription)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrDescription
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGUID(Guid* pguid)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement, Guid*, int>)((*lpVtbl)[4]))(
            this,
            pguid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Show(BOOL bShow)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement, BOOL, int>)((*lpVtbl)[5]))(
            this,
            bShow
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsShown(BOOL* pbShow)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement, BOOL*, int>)((*lpVtbl)[6]))(
            this,
            pbShow
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetUpdatedFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement, uint*, int>)((*lpVtbl)[7]))(
            this,
            pdwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDocumentMgr(ITfDocumentMgr* ppdim)
    {
        return (
            (delegate* unmanaged<ITfCandidateListUIElement, ITfDocumentMgr*, int>)((*lpVtbl)[8])
        )(this, ppdim);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCount(uint* puCount)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement, uint*, int>)((*lpVtbl)[9]))(
            this,
            puCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetSelection(uint* puIndex)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement, uint*, int>)((*lpVtbl)[10]))(
            this,
            puIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetString(uint uIndex, [NativeTypeName("BSTR *")] ushort** pstr)
    {
        return (
            (delegate* unmanaged<ITfCandidateListUIElement, uint, ushort**, int>)((*lpVtbl)[11])
        )(this, uIndex, pstr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetPageIndex(uint* pIndex, uint uSize, uint* puPageCnt)
    {
        return (
            (delegate* unmanaged<ITfCandidateListUIElement, uint*, uint, uint*, int>)((*lpVtbl)[12])
        )(this, pIndex, uSize, puPageCnt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetPageIndex(uint* pIndex, uint uPageCnt)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement, uint*, uint, int>)((*lpVtbl)[13]))(
            this,
            pIndex,
            uPageCnt
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetCurrentPage(uint* puPage)
    {
        return ((delegate* unmanaged<ITfCandidateListUIElement, uint*, int>)((*lpVtbl)[14]))(
            this,
            puPage
        );
    }

    public interface Interface : ITfUIElement.Interface
    {
        [VtblIndex(7)]
        HRESULT GetUpdatedFlags([NativeTypeName("DWORD *")] uint* pdwFlags);

        [VtblIndex(8)]
        HRESULT GetDocumentMgr(ITfDocumentMgr* ppdim);

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
        public delegate* unmanaged<TSelf*, ITfDocumentMgr*, int> GetDocumentMgr;

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

    /// <summary>Initializes a new instance of the <see cref = "ITfCandidateListUIElement"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfCandidateListUIElement(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfUIElement"/> to <see cref = "ITfCandidateListUIElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfUIElement"/> instance to be converted </param>
    public static explicit operator ITfCandidateListUIElement(Silk.NET.Windows.ITfUIElement value)
    {
        return new ITfCandidateListUIElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfCandidateListUIElement"/> to <see cref = "Silk.NET.Windows.ITfUIElement"/>.</summary>
    /// <param name = "value">The <see cref = "ITfCandidateListUIElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfUIElement(ITfCandidateListUIElement value)
    {
        return new Silk.NET.Windows.ITfUIElement(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfCandidateListUIElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfCandidateListUIElement(Silk.NET.Windows.IUnknown value)
    {
        return new ITfCandidateListUIElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfCandidateListUIElement"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfCandidateListUIElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfCandidateListUIElement value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
