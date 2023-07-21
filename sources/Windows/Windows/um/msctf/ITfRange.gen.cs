// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfRange.xml' path='doc/member[@name="ITfRange"]/*' />
[Guid("AA80E7FF-2021-11D2-93E0-0060B067B86E")]
[NativeTypeName("struct ITfRange : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfRange : ITfRange.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfRange));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfRange*, Guid*, void**, int>)(lpVtbl[0]))((ITfRange*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfRange*, uint>)(lpVtbl[1]))((ITfRange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfRange*, uint>)(lpVtbl[2]))((ITfRange*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.GetText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetText([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cchMax, [NativeTypeName("ULONG *")] uint* pcch)
    {
        return ((delegate* unmanaged<ITfRange*, uint, uint, ushort*, uint, uint*, int>)(lpVtbl[3]))((ITfRange*)Unsafe.AsPointer(ref this), ec, dwFlags, pchText, cchMax, pcch);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.SetText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetText([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("LONG")] int cch)
    {
        return ((delegate* unmanaged<ITfRange*, uint, uint, ushort*, int, int>)(lpVtbl[4]))((ITfRange*)Unsafe.AsPointer(ref this), ec, dwFlags, pchText, cch);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.GetFormattedText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFormattedText([NativeTypeName("TfEditCookie")] uint ec, IDataObject** ppDataObject)
    {
        return ((delegate* unmanaged<ITfRange*, uint, IDataObject**, int>)(lpVtbl[5]))((ITfRange*)Unsafe.AsPointer(ref this), ec, ppDataObject);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.GetEmbedded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetEmbedded([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
    {
        return ((delegate* unmanaged<ITfRange*, uint, Guid*, Guid*, IUnknown**, int>)(lpVtbl[6]))((ITfRange*)Unsafe.AsPointer(ref this), ec, rguidService, riid, ppunk);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.InsertEmbedded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InsertEmbedded([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, IDataObject* pDataObject)
    {
        return ((delegate* unmanaged<ITfRange*, uint, uint, IDataObject*, int>)(lpVtbl[7]))((ITfRange*)Unsafe.AsPointer(ref this), ec, dwFlags, pDataObject);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.ShiftStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ShiftStart([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("LONG")] int cchReq, [NativeTypeName("LONG *")] int* pcch, [NativeTypeName("const TF_HALTCOND *")] TF_HALTCOND* pHalt)
    {
        return ((delegate* unmanaged<ITfRange*, uint, int, int*, TF_HALTCOND*, int>)(lpVtbl[8]))((ITfRange*)Unsafe.AsPointer(ref this), ec, cchReq, pcch, pHalt);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.ShiftEnd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ShiftEnd([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("LONG")] int cchReq, [NativeTypeName("LONG *")] int* pcch, [NativeTypeName("const TF_HALTCOND *")] TF_HALTCOND* pHalt)
    {
        return ((delegate* unmanaged<ITfRange*, uint, int, int*, TF_HALTCOND*, int>)(lpVtbl[9]))((ITfRange*)Unsafe.AsPointer(ref this), ec, cchReq, pcch, pHalt);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.ShiftStartToRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ShiftStartToRange([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, TfAnchor aPos)
    {
        return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, int>)(lpVtbl[10]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pRange, aPos);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.ShiftEndToRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ShiftEndToRange([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, TfAnchor aPos)
    {
        return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, int>)(lpVtbl[11]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pRange, aPos);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.ShiftStartRegion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ShiftStartRegion([NativeTypeName("TfEditCookie")] uint ec, TfShiftDir dir, BOOL* pfNoRegion)
    {
        return ((delegate* unmanaged<ITfRange*, uint, TfShiftDir, BOOL*, int>)(lpVtbl[12]))((ITfRange*)Unsafe.AsPointer(ref this), ec, dir, pfNoRegion);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.ShiftEndRegion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ShiftEndRegion([NativeTypeName("TfEditCookie")] uint ec, TfShiftDir dir, BOOL* pfNoRegion)
    {
        return ((delegate* unmanaged<ITfRange*, uint, TfShiftDir, BOOL*, int>)(lpVtbl[13]))((ITfRange*)Unsafe.AsPointer(ref this), ec, dir, pfNoRegion);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.IsEmpty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT IsEmpty([NativeTypeName("TfEditCookie")] uint ec, BOOL* pfEmpty)
    {
        return ((delegate* unmanaged<ITfRange*, uint, BOOL*, int>)(lpVtbl[14]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pfEmpty);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.Collapse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Collapse([NativeTypeName("TfEditCookie")] uint ec, TfAnchor aPos)
    {
        return ((delegate* unmanaged<ITfRange*, uint, TfAnchor, int>)(lpVtbl[15]))((ITfRange*)Unsafe.AsPointer(ref this), ec, aPos);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.IsEqualStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT IsEqualStart([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, BOOL* pfEqual)
    {
        return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, BOOL*, int>)(lpVtbl[16]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pWith, aPos, pfEqual);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.IsEqualEnd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT IsEqualEnd([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, BOOL* pfEqual)
    {
        return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, BOOL*, int>)(lpVtbl[17]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pWith, aPos, pfEqual);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.CompareStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CompareStart([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, [NativeTypeName("LONG *")] int* plResult)
    {
        return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, int*, int>)(lpVtbl[18]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pWith, aPos, plResult);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.CompareEnd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CompareEnd([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, [NativeTypeName("LONG *")] int* plResult)
    {
        return ((delegate* unmanaged<ITfRange*, uint, ITfRange*, TfAnchor, int*, int>)(lpVtbl[19]))((ITfRange*)Unsafe.AsPointer(ref this), ec, pWith, aPos, plResult);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.AdjustForInsert"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT AdjustForInsert([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("ULONG")] uint cchInsert, BOOL* pfInsertOk)
    {
        return ((delegate* unmanaged<ITfRange*, uint, uint, BOOL*, int>)(lpVtbl[20]))((ITfRange*)Unsafe.AsPointer(ref this), ec, cchInsert, pfInsertOk);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.GetGravity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetGravity(TfGravity* pgStart, TfGravity* pgEnd)
    {
        return ((delegate* unmanaged<ITfRange*, TfGravity*, TfGravity*, int>)(lpVtbl[21]))((ITfRange*)Unsafe.AsPointer(ref this), pgStart, pgEnd);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.SetGravity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetGravity([NativeTypeName("TfEditCookie")] uint ec, TfGravity gStart, TfGravity gEnd)
    {
        return ((delegate* unmanaged<ITfRange*, uint, TfGravity, TfGravity, int>)(lpVtbl[22]))((ITfRange*)Unsafe.AsPointer(ref this), ec, gStart, gEnd);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT Clone(ITfRange** ppClone)
    {
        return ((delegate* unmanaged<ITfRange*, ITfRange**, int>)(lpVtbl[23]))((ITfRange*)Unsafe.AsPointer(ref this), ppClone);
    }

    /// <include file='ITfRange.xml' path='doc/member[@name="ITfRange.GetContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetContext(ITfContext** ppContext)
    {
        return ((delegate* unmanaged<ITfRange*, ITfContext**, int>)(lpVtbl[24]))((ITfRange*)Unsafe.AsPointer(ref this), ppContext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetText([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cchMax, [NativeTypeName("ULONG *")] uint* pcch);

        [VtblIndex(4)]
        HRESULT SetText([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("LONG")] int cch);

        [VtblIndex(5)]
        HRESULT GetFormattedText([NativeTypeName("TfEditCookie")] uint ec, IDataObject** ppDataObject);

        [VtblIndex(6)]
        HRESULT GetEmbedded([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk);

        [VtblIndex(7)]
        HRESULT InsertEmbedded([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, IDataObject* pDataObject);

        [VtblIndex(8)]
        HRESULT ShiftStart([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("LONG")] int cchReq, [NativeTypeName("LONG *")] int* pcch, [NativeTypeName("const TF_HALTCOND *")] TF_HALTCOND* pHalt);

        [VtblIndex(9)]
        HRESULT ShiftEnd([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("LONG")] int cchReq, [NativeTypeName("LONG *")] int* pcch, [NativeTypeName("const TF_HALTCOND *")] TF_HALTCOND* pHalt);

        [VtblIndex(10)]
        HRESULT ShiftStartToRange([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, TfAnchor aPos);

        [VtblIndex(11)]
        HRESULT ShiftEndToRange([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, TfAnchor aPos);

        [VtblIndex(12)]
        HRESULT ShiftStartRegion([NativeTypeName("TfEditCookie")] uint ec, TfShiftDir dir, BOOL* pfNoRegion);

        [VtblIndex(13)]
        HRESULT ShiftEndRegion([NativeTypeName("TfEditCookie")] uint ec, TfShiftDir dir, BOOL* pfNoRegion);

        [VtblIndex(14)]
        HRESULT IsEmpty([NativeTypeName("TfEditCookie")] uint ec, BOOL* pfEmpty);

        [VtblIndex(15)]
        HRESULT Collapse([NativeTypeName("TfEditCookie")] uint ec, TfAnchor aPos);

        [VtblIndex(16)]
        HRESULT IsEqualStart([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, BOOL* pfEqual);

        [VtblIndex(17)]
        HRESULT IsEqualEnd([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, BOOL* pfEqual);

        [VtblIndex(18)]
        HRESULT CompareStart([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, [NativeTypeName("LONG *")] int* plResult);

        [VtblIndex(19)]
        HRESULT CompareEnd([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, [NativeTypeName("LONG *")] int* plResult);

        [VtblIndex(20)]
        HRESULT AdjustForInsert([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("ULONG")] uint cchInsert, BOOL* pfInsertOk);

        [VtblIndex(21)]
        HRESULT GetGravity(TfGravity* pgStart, TfGravity* pgEnd);

        [VtblIndex(22)]
        HRESULT SetGravity([NativeTypeName("TfEditCookie")] uint ec, TfGravity gStart, TfGravity gEnd);

        [VtblIndex(23)]
        HRESULT Clone(ITfRange** ppClone);

        [VtblIndex(24)]
        HRESULT GetContext(ITfContext** ppContext);
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

        [NativeTypeName("HRESULT (TfEditCookie, DWORD, WCHAR *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ushort*, uint, uint*, int> GetText;

        [NativeTypeName("HRESULT (TfEditCookie, DWORD, const WCHAR *, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ushort*, int, int> SetText;

        [NativeTypeName("HRESULT (TfEditCookie, IDataObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDataObject**, int> GetFormattedText;

        [NativeTypeName("HRESULT (TfEditCookie, const GUID &, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, Guid*, IUnknown**, int> GetEmbedded;

        [NativeTypeName("HRESULT (TfEditCookie, DWORD, IDataObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IDataObject*, int> InsertEmbedded;

        [NativeTypeName("HRESULT (TfEditCookie, LONG, LONG *, const TF_HALTCOND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int, int*, TF_HALTCOND*, int> ShiftStart;

        [NativeTypeName("HRESULT (TfEditCookie, LONG, LONG *, const TF_HALTCOND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int, int*, TF_HALTCOND*, int> ShiftEnd;

        [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, TfAnchor) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange*, TfAnchor, int> ShiftStartToRange;

        [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, TfAnchor) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange*, TfAnchor, int> ShiftEndToRange;

        [NativeTypeName("HRESULT (TfEditCookie, TfShiftDir, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, TfShiftDir, BOOL*, int> ShiftStartRegion;

        [NativeTypeName("HRESULT (TfEditCookie, TfShiftDir, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, TfShiftDir, BOOL*, int> ShiftEndRegion;

        [NativeTypeName("HRESULT (TfEditCookie, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, int> IsEmpty;

        [NativeTypeName("HRESULT (TfEditCookie, TfAnchor) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, TfAnchor, int> Collapse;

        [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, TfAnchor, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange*, TfAnchor, BOOL*, int> IsEqualStart;

        [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, TfAnchor, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange*, TfAnchor, BOOL*, int> IsEqualEnd;

        [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, TfAnchor, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange*, TfAnchor, int*, int> CompareStart;

        [NativeTypeName("HRESULT (TfEditCookie, ITfRange *, TfAnchor, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange*, TfAnchor, int*, int> CompareEnd;

        [NativeTypeName("HRESULT (TfEditCookie, ULONG, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, BOOL*, int> AdjustForInsert;

        [NativeTypeName("HRESULT (TfGravity *, TfGravity *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TfGravity*, TfGravity*, int> GetGravity;

        [NativeTypeName("HRESULT (TfEditCookie, TfGravity, TfGravity) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, TfGravity, TfGravity, int> SetGravity;

        [NativeTypeName("HRESULT (ITfRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange**, int> Clone;

        [NativeTypeName("HRESULT (ITfContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext**, int> GetContext;
    }
}
