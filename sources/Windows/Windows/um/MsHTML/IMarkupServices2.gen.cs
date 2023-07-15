// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMarkupServices2.xml' path='doc/member[@name="IMarkupServices2"]/*'/>
[Guid("3050F682-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IMarkupServices2 : IMarkupServices")]
[NativeInheritance("IMarkupServices")]
public unsafe partial struct IMarkupServices2 : IMarkupServices2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMarkupServices2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMarkupServices2*, Guid*, void**, int> )(lpVtbl[0]))((IMarkupServices2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMarkupServices2*, uint> )(lpVtbl[1]))((IMarkupServices2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMarkupServices2*, uint> )(lpVtbl[2]))((IMarkupServices2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMarkupServices.CreateMarkupPointer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateMarkupPointer(IMarkupPointer** ppPointer)
    {
        return ((delegate* unmanaged<IMarkupServices2*, IMarkupPointer**, int> )(lpVtbl[3]))((IMarkupServices2*)Unsafe.AsPointer(ref this), ppPointer);
    }

    /// <inheritdoc cref = "IMarkupServices.CreateMarkupContainer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateMarkupContainer(IMarkupContainer** ppMarkupContainer)
    {
        return ((delegate* unmanaged<IMarkupServices2*, IMarkupContainer**, int> )(lpVtbl[4]))((IMarkupServices2*)Unsafe.AsPointer(ref this), ppMarkupContainer);
    }

    /// <inheritdoc cref = "IMarkupServices.CreateElement"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateElement(ELEMENT_TAG_ID tagID, [NativeTypeName("OLECHAR *")] ushort* pchAttributes, IHTMLElement** ppElement)
    {
        return ((delegate* unmanaged<IMarkupServices2*, ELEMENT_TAG_ID, ushort*, IHTMLElement**, int> )(lpVtbl[5]))((IMarkupServices2*)Unsafe.AsPointer(ref this), tagID, pchAttributes, ppElement);
    }

    /// <inheritdoc cref = "IMarkupServices.CloneElement"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CloneElement(IHTMLElement* pElemCloneThis, IHTMLElement** ppElementTheClone)
    {
        return ((delegate* unmanaged<IMarkupServices2*, IHTMLElement*, IHTMLElement**, int> )(lpVtbl[6]))((IMarkupServices2*)Unsafe.AsPointer(ref this), pElemCloneThis, ppElementTheClone);
    }

    /// <inheritdoc cref = "IMarkupServices.InsertElement"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InsertElement(IHTMLElement* pElementInsert, IMarkupPointer* pPointerStart, IMarkupPointer* pPointerFinish)
    {
        return ((delegate* unmanaged<IMarkupServices2*, IHTMLElement*, IMarkupPointer*, IMarkupPointer*, int> )(lpVtbl[7]))((IMarkupServices2*)Unsafe.AsPointer(ref this), pElementInsert, pPointerStart, pPointerFinish);
    }

    /// <inheritdoc cref = "IMarkupServices.RemoveElement"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveElement(IHTMLElement* pElementRemove)
    {
        return ((delegate* unmanaged<IMarkupServices2*, IHTMLElement*, int> )(lpVtbl[8]))((IMarkupServices2*)Unsafe.AsPointer(ref this), pElementRemove);
    }

    /// <inheritdoc cref = "IMarkupServices.Remove"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Remove(IMarkupPointer* pPointerStart, IMarkupPointer* pPointerFinish)
    {
        return ((delegate* unmanaged<IMarkupServices2*, IMarkupPointer*, IMarkupPointer*, int> )(lpVtbl[9]))((IMarkupServices2*)Unsafe.AsPointer(ref this), pPointerStart, pPointerFinish);
    }

    /// <inheritdoc cref = "IMarkupServices.Copy"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Copy(IMarkupPointer* pPointerSourceStart, IMarkupPointer* pPointerSourceFinish, IMarkupPointer* pPointerTarget)
    {
        return ((delegate* unmanaged<IMarkupServices2*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, int> )(lpVtbl[10]))((IMarkupServices2*)Unsafe.AsPointer(ref this), pPointerSourceStart, pPointerSourceFinish, pPointerTarget);
    }

    /// <inheritdoc cref = "IMarkupServices.Move"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Move(IMarkupPointer* pPointerSourceStart, IMarkupPointer* pPointerSourceFinish, IMarkupPointer* pPointerTarget)
    {
        return ((delegate* unmanaged<IMarkupServices2*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, int> )(lpVtbl[11]))((IMarkupServices2*)Unsafe.AsPointer(ref this), pPointerSourceStart, pPointerSourceFinish, pPointerTarget);
    }

    /// <inheritdoc cref = "IMarkupServices.InsertText"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT InsertText([NativeTypeName("OLECHAR *")] ushort* pchText, [NativeTypeName("long")] int cch, IMarkupPointer* pPointerTarget)
    {
        return ((delegate* unmanaged<IMarkupServices2*, ushort*, int, IMarkupPointer*, int> )(lpVtbl[12]))((IMarkupServices2*)Unsafe.AsPointer(ref this), pchText, cch, pPointerTarget);
    }

    /// <inheritdoc cref = "IMarkupServices.ParseString"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ParseString([NativeTypeName("OLECHAR *")] ushort* pchHTML, [NativeTypeName("DWORD")] uint dwFlags, IMarkupContainer** ppContainerResult, IMarkupPointer* ppPointerStart, IMarkupPointer* ppPointerFinish)
    {
        return ((delegate* unmanaged<IMarkupServices2*, ushort*, uint, IMarkupContainer**, IMarkupPointer*, IMarkupPointer*, int> )(lpVtbl[13]))((IMarkupServices2*)Unsafe.AsPointer(ref this), pchHTML, dwFlags, ppContainerResult, ppPointerStart, ppPointerFinish);
    }

    /// <inheritdoc cref = "IMarkupServices.ParseGlobal"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ParseGlobal(HGLOBAL hglobalHTML, [NativeTypeName("DWORD")] uint dwFlags, IMarkupContainer** ppContainerResult, IMarkupPointer* pPointerStart, IMarkupPointer* pPointerFinish)
    {
        return ((delegate* unmanaged<IMarkupServices2*, HGLOBAL, uint, IMarkupContainer**, IMarkupPointer*, IMarkupPointer*, int> )(lpVtbl[14]))((IMarkupServices2*)Unsafe.AsPointer(ref this), hglobalHTML, dwFlags, ppContainerResult, pPointerStart, pPointerFinish);
    }

    /// <inheritdoc cref = "IMarkupServices.IsScopedElement"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsScopedElement(IHTMLElement* pElement, BOOL* pfScoped)
    {
        return ((delegate* unmanaged<IMarkupServices2*, IHTMLElement*, BOOL*, int> )(lpVtbl[15]))((IMarkupServices2*)Unsafe.AsPointer(ref this), pElement, pfScoped);
    }

    /// <inheritdoc cref = "IMarkupServices.GetElementTagId"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetElementTagId(IHTMLElement* pElement, ELEMENT_TAG_ID* ptagId)
    {
        return ((delegate* unmanaged<IMarkupServices2*, IHTMLElement*, ELEMENT_TAG_ID*, int> )(lpVtbl[16]))((IMarkupServices2*)Unsafe.AsPointer(ref this), pElement, ptagId);
    }

    /// <inheritdoc cref = "IMarkupServices.GetTagIDForName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetTagIDForName([NativeTypeName("BSTR")] ushort* bstrName, ELEMENT_TAG_ID* ptagId)
    {
        return ((delegate* unmanaged<IMarkupServices2*, ushort*, ELEMENT_TAG_ID*, int> )(lpVtbl[17]))((IMarkupServices2*)Unsafe.AsPointer(ref this), bstrName, ptagId);
    }

    /// <inheritdoc cref = "IMarkupServices.GetNameForTagID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetNameForTagID(ELEMENT_TAG_ID tagId, [NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<IMarkupServices2*, ELEMENT_TAG_ID, ushort**, int> )(lpVtbl[18]))((IMarkupServices2*)Unsafe.AsPointer(ref this), tagId, pbstrName);
    }

    /// <inheritdoc cref = "IMarkupServices.MovePointersToRange"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT MovePointersToRange(IHTMLTxtRange* pIRange, IMarkupPointer* pPointerStart, IMarkupPointer* pPointerFinish)
    {
        return ((delegate* unmanaged<IMarkupServices2*, IHTMLTxtRange*, IMarkupPointer*, IMarkupPointer*, int> )(lpVtbl[19]))((IMarkupServices2*)Unsafe.AsPointer(ref this), pIRange, pPointerStart, pPointerFinish);
    }

    /// <inheritdoc cref = "IMarkupServices.MoveRangeToPointers"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT MoveRangeToPointers(IMarkupPointer* pPointerStart, IMarkupPointer* pPointerFinish, IHTMLTxtRange* pIRange)
    {
        return ((delegate* unmanaged<IMarkupServices2*, IMarkupPointer*, IMarkupPointer*, IHTMLTxtRange*, int> )(lpVtbl[20]))((IMarkupServices2*)Unsafe.AsPointer(ref this), pPointerStart, pPointerFinish, pIRange);
    }

    /// <inheritdoc cref = "IMarkupServices.BeginUndoUnit"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT BeginUndoUnit([NativeTypeName("OLECHAR *")] ushort* pchTitle)
    {
        return ((delegate* unmanaged<IMarkupServices2*, ushort*, int> )(lpVtbl[21]))((IMarkupServices2*)Unsafe.AsPointer(ref this), pchTitle);
    }

    /// <inheritdoc cref = "IMarkupServices.EndUndoUnit"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT EndUndoUnit()
    {
        return ((delegate* unmanaged<IMarkupServices2*, int> )(lpVtbl[22]))((IMarkupServices2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMarkupServices2.xml' path='doc/member[@name="IMarkupServices2.ParseGlobalEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT ParseGlobalEx(HGLOBAL hglobalHTML, [NativeTypeName("DWORD")] uint dwFlags, IMarkupContainer* pContext, IMarkupContainer** ppContainerResult, IMarkupPointer* pPointerStart, IMarkupPointer* pPointerFinish)
    {
        return ((delegate* unmanaged<IMarkupServices2*, HGLOBAL, uint, IMarkupContainer*, IMarkupContainer**, IMarkupPointer*, IMarkupPointer*, int> )(lpVtbl[23]))((IMarkupServices2*)Unsafe.AsPointer(ref this), hglobalHTML, dwFlags, pContext, ppContainerResult, pPointerStart, pPointerFinish);
    }

    /// <include file='IMarkupServices2.xml' path='doc/member[@name="IMarkupServices2.ValidateElements"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT ValidateElements(IMarkupPointer* pPointerStart, IMarkupPointer* pPointerFinish, IMarkupPointer* pPointerTarget, IMarkupPointer* pPointerStatus, IHTMLElement** ppElemFailBottom, IHTMLElement** ppElemFailTop)
    {
        return ((delegate* unmanaged<IMarkupServices2*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, IHTMLElement**, IHTMLElement**, int> )(lpVtbl[24]))((IMarkupServices2*)Unsafe.AsPointer(ref this), pPointerStart, pPointerFinish, pPointerTarget, pPointerStatus, ppElemFailBottom, ppElemFailTop);
    }

    /// <include file='IMarkupServices2.xml' path='doc/member[@name="IMarkupServices2.SaveSegmentsToClipboard"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SaveSegmentsToClipboard(ISegmentList* pSegmentList, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IMarkupServices2*, ISegmentList*, uint, int> )(lpVtbl[25]))((IMarkupServices2*)Unsafe.AsPointer(ref this), pSegmentList, dwFlags);
    }

    public interface Interface : IMarkupServices.Interface
    {
        [VtblIndex(23)]
        HRESULT ParseGlobalEx(HGLOBAL hglobalHTML, [NativeTypeName("DWORD")] uint dwFlags, IMarkupContainer* pContext, IMarkupContainer** ppContainerResult, IMarkupPointer* pPointerStart, IMarkupPointer* pPointerFinish);
        [VtblIndex(24)]
        HRESULT ValidateElements(IMarkupPointer* pPointerStart, IMarkupPointer* pPointerFinish, IMarkupPointer* pPointerTarget, IMarkupPointer* pPointerStatus, IHTMLElement** ppElemFailBottom, IHTMLElement** ppElemFailTop);
        [VtblIndex(25)]
        HRESULT SaveSegmentsToClipboard(ISegmentList* pSegmentList, [NativeTypeName("DWORD")] uint dwFlags);
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
        [NativeTypeName("HRESULT (IMarkupPointer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer**, int> CreateMarkupPointer;
        [NativeTypeName("HRESULT (IMarkupContainer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupContainer**, int> CreateMarkupContainer;
        [NativeTypeName("HRESULT (ELEMENT_TAG_ID, OLECHAR *, IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ELEMENT_TAG_ID, ushort*, IHTMLElement**, int> CreateElement;
        [NativeTypeName("HRESULT (IHTMLElement *, IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, IHTMLElement**, int> CloneElement;
        [NativeTypeName("HRESULT (IHTMLElement *, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, IMarkupPointer*, IMarkupPointer*, int> InsertElement;
        [NativeTypeName("HRESULT (IHTMLElement *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, int> RemoveElement;
        [NativeTypeName("HRESULT (IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer*, IMarkupPointer*, int> Remove;
        [NativeTypeName("HRESULT (IMarkupPointer *, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, int> Copy;
        [NativeTypeName("HRESULT (IMarkupPointer *, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, int> Move;
        [NativeTypeName("HRESULT (OLECHAR *, long, IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, IMarkupPointer*, int> InsertText;
        [NativeTypeName("HRESULT (OLECHAR *, DWORD, IMarkupContainer **, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, IMarkupContainer**, IMarkupPointer*, IMarkupPointer*, int> ParseString;
        [NativeTypeName("HRESULT (HGLOBAL, DWORD, IMarkupContainer **, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HGLOBAL, uint, IMarkupContainer**, IMarkupPointer*, IMarkupPointer*, int> ParseGlobal;
        [NativeTypeName("HRESULT (IHTMLElement *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, BOOL*, int> IsScopedElement;
        [NativeTypeName("HRESULT (IHTMLElement *, ELEMENT_TAG_ID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, ELEMENT_TAG_ID*, int> GetElementTagId;
        [NativeTypeName("HRESULT (BSTR, ELEMENT_TAG_ID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ELEMENT_TAG_ID*, int> GetTagIDForName;
        [NativeTypeName("HRESULT (ELEMENT_TAG_ID, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ELEMENT_TAG_ID, ushort**, int> GetNameForTagID;
        [NativeTypeName("HRESULT (IHTMLTxtRange *, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTxtRange*, IMarkupPointer*, IMarkupPointer*, int> MovePointersToRange;
        [NativeTypeName("HRESULT (IMarkupPointer *, IMarkupPointer *, IHTMLTxtRange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer*, IMarkupPointer*, IHTMLTxtRange*, int> MoveRangeToPointers;
        [NativeTypeName("HRESULT (OLECHAR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> BeginUndoUnit;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndUndoUnit;
        [NativeTypeName("HRESULT (HGLOBAL, DWORD, IMarkupContainer *, IMarkupContainer **, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HGLOBAL, uint, IMarkupContainer*, IMarkupContainer**, IMarkupPointer*, IMarkupPointer*, int> ParseGlobalEx;
        [NativeTypeName("HRESULT (IMarkupPointer *, IMarkupPointer *, IMarkupPointer *, IMarkupPointer *, IHTMLElement **, IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, IHTMLElement**, IHTMLElement**, int> ValidateElements;
        [NativeTypeName("HRESULT (ISegmentList *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISegmentList*, uint, int> SaveSegmentsToClipboard;
    }
}