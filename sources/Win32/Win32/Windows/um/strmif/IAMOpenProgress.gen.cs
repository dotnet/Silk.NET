// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8E1C39A1-DE53-11CF-AA63-0080C744528D")]
[NativeTypeName("struct IAMOpenProgress : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMOpenProgress : IAMOpenProgress.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMOpenProgress));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMOpenProgress, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAMOpenProgress, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMOpenProgress, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryProgress(
        [NativeTypeName("LONGLONG *")] long* pllTotal,
        [NativeTypeName("LONGLONG *")] long* pllCurrent
    )
    {
        return ((delegate* unmanaged<IAMOpenProgress, long*, long*, int>)((*lpVtbl)[3]))(
            this,
            pllTotal,
            pllCurrent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AbortOperation()
    {
        return ((delegate* unmanaged<IAMOpenProgress, int>)((*lpVtbl)[4]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryProgress(
            [NativeTypeName("LONGLONG *")] long* pllTotal,
            [NativeTypeName("LONGLONG *")] long* pllCurrent
        );

        [VtblIndex(4)]
        HRESULT AbortOperation();
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

        [NativeTypeName("HRESULT (LONGLONG *, LONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, long*, int> QueryProgress;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> AbortOperation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMOpenProgress"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMOpenProgress(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMOpenProgress"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMOpenProgress(Silk.NET.Windows.IUnknown value)
    {
        return new IAMOpenProgress(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMOpenProgress"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMOpenProgress"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMOpenProgress value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
