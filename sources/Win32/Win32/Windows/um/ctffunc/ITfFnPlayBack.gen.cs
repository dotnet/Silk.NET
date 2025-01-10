// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A3A416A4-0F64-11D3-B5B7-00C04FC324A1")]
[NativeTypeName("struct ITfFnPlayBack : ITfFunction")]
[NativeInheritance("ITfFunction")]
public unsafe partial struct ITfFnPlayBack : ITfFnPlayBack.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnPlayBack));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfFnPlayBack, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfFnPlayBack, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnPlayBack, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnPlayBack, ushort**, int>)((*lpVtbl)[3]))(this, pbstrName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT QueryRange(ITfRange pRange, ITfRange* ppNewRange, BOOL* pfPlayable)
    {
        return (
            (delegate* unmanaged<ITfFnPlayBack, ITfRange, ITfRange*, BOOL*, int>)((*lpVtbl)[4])
        )(this, pRange, ppNewRange, pfPlayable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Play(ITfRange pRange)
    {
        return ((delegate* unmanaged<ITfFnPlayBack, ITfRange, int>)((*lpVtbl)[5]))(this, pRange);
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT QueryRange(ITfRange pRange, ITfRange* ppNewRange, BOOL* pfPlayable);

        [VtblIndex(5)]
        HRESULT Play(ITfRange pRange);
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
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayName;

        [NativeTypeName("HRESULT (ITfRange *, ITfRange **, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange, ITfRange*, BOOL*, int> QueryRange;

        [NativeTypeName("HRESULT (ITfRange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange, int> Play;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfFnPlayBack"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfFnPlayBack(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfFunction"/> to <see cref = "ITfFnPlayBack"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfFunction"/> instance to be converted </param>
    public static explicit operator ITfFnPlayBack(Silk.NET.Windows.ITfFunction value)
    {
        return new ITfFnPlayBack(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnPlayBack"/> to <see cref = "Silk.NET.Windows.ITfFunction"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnPlayBack"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfFunction(ITfFnPlayBack value)
    {
        return new Silk.NET.Windows.ITfFunction(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfFnPlayBack"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfFnPlayBack(Silk.NET.Windows.IUnknown value)
    {
        return new ITfFnPlayBack(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnPlayBack"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnPlayBack"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfFnPlayBack value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
