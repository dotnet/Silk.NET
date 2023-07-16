// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITfRangeACP.xml' path='doc/member[@name="ITfRangeACP"]/*'/>
[Guid("057A6296-029B-4154-B79A-0D461D4EA94C")]
[NativeTypeName("struct ITfRangeACP : ITfRange")]
[NativeInheritance("ITfRange")]
public unsafe partial struct ITfRangeACP : ITfRangeACP.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfRangeACP));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfRangeACP*, Guid*, void**, int> )(lpVtbl[0]))((ITfRangeACP*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint> )(lpVtbl[1]))((ITfRangeACP*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint> )(lpVtbl[2]))((ITfRangeACP*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ITfRange.GetText"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetText([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("WCHAR *")] ushort* pchText, [NativeTypeName("ULONG")] uint cchMax, [NativeTypeName("ULONG *")] uint* pcch)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, uint, ushort*, uint, uint*, int> )(lpVtbl[3]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, dwFlags, pchText, cchMax, pcch);
    }

    /// <inheritdoc cref = "ITfRange.SetText"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetText([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("LONG")] int cch)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, uint, ushort*, int, int> )(lpVtbl[4]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, dwFlags, pchText, cch);
    }

    /// <inheritdoc cref = "ITfRange.GetFormattedText"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFormattedText([NativeTypeName("TfEditCookie")] uint ec, IDataObject** ppDataObject)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, IDataObject**, int> )(lpVtbl[5]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, ppDataObject);
    }

    /// <inheritdoc cref = "ITfRange.GetEmbedded"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetEmbedded([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, Guid*, Guid*, IUnknown**, int> )(lpVtbl[6]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, rguidService, riid, ppunk);
    }

    /// <inheritdoc cref = "ITfRange.InsertEmbedded"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InsertEmbedded([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, IDataObject* pDataObject)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, uint, IDataObject*, int> )(lpVtbl[7]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, dwFlags, pDataObject);
    }

    /// <inheritdoc cref = "ITfRange.ShiftStart"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ShiftStart([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("LONG")] int cchReq, [NativeTypeName("LONG *")] int* pcch, [NativeTypeName("const TF_HALTCOND *")] TF_HALTCOND* pHalt)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, int, int*, TF_HALTCOND*, int> )(lpVtbl[8]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, cchReq, pcch, pHalt);
    }

    /// <inheritdoc cref = "ITfRange.ShiftEnd"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ShiftEnd([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("LONG")] int cchReq, [NativeTypeName("LONG *")] int* pcch, [NativeTypeName("const TF_HALTCOND *")] TF_HALTCOND* pHalt)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, int, int*, TF_HALTCOND*, int> )(lpVtbl[9]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, cchReq, pcch, pHalt);
    }

    /// <inheritdoc cref = "ITfRange.ShiftStartToRange"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ShiftStartToRange([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, TfAnchor aPos)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, ITfRange*, TfAnchor, int> )(lpVtbl[10]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, pRange, aPos);
    }

    /// <inheritdoc cref = "ITfRange.ShiftEndToRange"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ShiftEndToRange([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, TfAnchor aPos)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, ITfRange*, TfAnchor, int> )(lpVtbl[11]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, pRange, aPos);
    }

    /// <inheritdoc cref = "ITfRange.ShiftStartRegion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ShiftStartRegion([NativeTypeName("TfEditCookie")] uint ec, TfShiftDir dir, BOOL* pfNoRegion)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, TfShiftDir, BOOL*, int> )(lpVtbl[12]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, dir, pfNoRegion);
    }

    /// <inheritdoc cref = "ITfRange.ShiftEndRegion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ShiftEndRegion([NativeTypeName("TfEditCookie")] uint ec, TfShiftDir dir, BOOL* pfNoRegion)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, TfShiftDir, BOOL*, int> )(lpVtbl[13]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, dir, pfNoRegion);
    }

    /// <inheritdoc cref = "ITfRange.IsEmpty"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT IsEmpty([NativeTypeName("TfEditCookie")] uint ec, BOOL* pfEmpty)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, BOOL*, int> )(lpVtbl[14]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, pfEmpty);
    }

    /// <inheritdoc cref = "ITfRange.Collapse"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Collapse([NativeTypeName("TfEditCookie")] uint ec, TfAnchor aPos)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, TfAnchor, int> )(lpVtbl[15]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, aPos);
    }

    /// <inheritdoc cref = "ITfRange.IsEqualStart"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT IsEqualStart([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, BOOL* pfEqual)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, ITfRange*, TfAnchor, BOOL*, int> )(lpVtbl[16]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, pWith, aPos, pfEqual);
    }

    /// <inheritdoc cref = "ITfRange.IsEqualEnd"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT IsEqualEnd([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, BOOL* pfEqual)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, ITfRange*, TfAnchor, BOOL*, int> )(lpVtbl[17]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, pWith, aPos, pfEqual);
    }

    /// <inheritdoc cref = "ITfRange.CompareStart"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CompareStart([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, [NativeTypeName("LONG *")] int* plResult)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, ITfRange*, TfAnchor, int*, int> )(lpVtbl[18]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, pWith, aPos, plResult);
    }

    /// <inheritdoc cref = "ITfRange.CompareEnd"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CompareEnd([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pWith, TfAnchor aPos, [NativeTypeName("LONG *")] int* plResult)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, ITfRange*, TfAnchor, int*, int> )(lpVtbl[19]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, pWith, aPos, plResult);
    }

    /// <inheritdoc cref = "ITfRange.AdjustForInsert"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT AdjustForInsert([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("ULONG")] uint cchInsert, BOOL* pfInsertOk)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, uint, BOOL*, int> )(lpVtbl[20]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, cchInsert, pfInsertOk);
    }

    /// <inheritdoc cref = "ITfRange.GetGravity"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetGravity(TfGravity* pgStart, TfGravity* pgEnd)
    {
        return ((delegate* unmanaged<ITfRangeACP*, TfGravity*, TfGravity*, int> )(lpVtbl[21]))((ITfRangeACP*)Unsafe.AsPointer(ref this), pgStart, pgEnd);
    }

    /// <inheritdoc cref = "ITfRange.SetGravity"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetGravity([NativeTypeName("TfEditCookie")] uint ec, TfGravity gStart, TfGravity gEnd)
    {
        return ((delegate* unmanaged<ITfRangeACP*, uint, TfGravity, TfGravity, int> )(lpVtbl[22]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ec, gStart, gEnd);
    }

    /// <inheritdoc cref = "ITfRange.Clone"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT Clone(ITfRange** ppClone)
    {
        return ((delegate* unmanaged<ITfRangeACP*, ITfRange**, int> )(lpVtbl[23]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ppClone);
    }

    /// <inheritdoc cref = "ITfRange.GetContext"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetContext(ITfContext** ppContext)
    {
        return ((delegate* unmanaged<ITfRangeACP*, ITfContext**, int> )(lpVtbl[24]))((ITfRangeACP*)Unsafe.AsPointer(ref this), ppContext);
    }

    /// <include file='ITfRangeACP.xml' path='doc/member[@name="ITfRangeACP.GetExtent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetExtent([NativeTypeName("LONG *")] int* pacpAnchor, [NativeTypeName("LONG *")] int* pcch)
    {
        return ((delegate* unmanaged<ITfRangeACP*, int*, int*, int> )(lpVtbl[25]))((ITfRangeACP*)Unsafe.AsPointer(ref this), pacpAnchor, pcch);
    }

    /// <include file='ITfRangeACP.xml' path='doc/member[@name="ITfRangeACP.SetExtent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetExtent([NativeTypeName("LONG")] int acpAnchor, [NativeTypeName("LONG")] int cch)
    {
        return ((delegate* unmanaged<ITfRangeACP*, int, int, int> )(lpVtbl[26]))((ITfRangeACP*)Unsafe.AsPointer(ref this), acpAnchor, cch);
    }

    public interface Interface : ITfRange.Interface
    {
        [VtblIndex(25)]
        HRESULT GetExtent([NativeTypeName("LONG *")] int* pacpAnchor, [NativeTypeName("LONG *")] int* pcch);
        [VtblIndex(26)]
        HRESULT SetExtent([NativeTypeName("LONG")] int acpAnchor, [NativeTypeName("LONG")] int cch);
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
        [NativeTypeName("HRESULT (LONG *, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> GetExtent;
        [NativeTypeName("HRESULT (LONG, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> SetExtent;
    }
}