// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F605-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISegmentList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISegmentList : ISegmentList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISegmentList));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISegmentList, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISegmentList, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISegmentList, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateIterator(ISegmentListIterator* ppIIter)
    {
        return ((delegate* unmanaged<ISegmentList, ISegmentListIterator*, int>)((*lpVtbl)[3]))(
            this,
            ppIIter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetType(SELECTION_TYPE* peType)
    {
        return ((delegate* unmanaged<ISegmentList, SELECTION_TYPE*, int>)((*lpVtbl)[4]))(
            this,
            peType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsEmpty(BOOL* pfEmpty)
    {
        return ((delegate* unmanaged<ISegmentList, BOOL*, int>)((*lpVtbl)[5]))(this, pfEmpty);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateIterator(ISegmentListIterator* ppIIter);

        [VtblIndex(4)]
        HRESULT GetType(SELECTION_TYPE* peType);

        [VtblIndex(5)]
        HRESULT IsEmpty(BOOL* pfEmpty);
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

        [NativeTypeName("HRESULT (ISegmentListIterator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISegmentListIterator*, int> CreateIterator;

        [NativeTypeName("HRESULT (SELECTION_TYPE *) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, SELECTION_TYPE*, int> GetType;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsEmpty;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISegmentList"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISegmentList(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISegmentList"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISegmentList(Silk.NET.Windows.IUnknown value)
    {
        return new ISegmentList(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISegmentList"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISegmentList"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISegmentList value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
