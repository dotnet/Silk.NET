// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F185FE76-E64E-11D2-B76E-00C04FB6BD3D")]
[NativeTypeName("struct IAMPushSource : IAMLatency")]
[NativeInheritance("IAMLatency")]
public unsafe partial struct IAMPushSource : IAMPushSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMPushSource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMPushSource, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAMPushSource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMPushSource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetLatency([NativeTypeName("REFERENCE_TIME *")] long* prtLatency)
    {
        return ((delegate* unmanaged<IAMPushSource, long*, int>)((*lpVtbl)[3]))(this, prtLatency);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPushSourceFlags([NativeTypeName("ULONG *")] uint* pFlags)
    {
        return ((delegate* unmanaged<IAMPushSource, uint*, int>)((*lpVtbl)[4]))(this, pFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPushSourceFlags([NativeTypeName("ULONG")] uint Flags)
    {
        return ((delegate* unmanaged<IAMPushSource, uint, int>)((*lpVtbl)[5]))(this, Flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetStreamOffset([NativeTypeName("REFERENCE_TIME")] long rtOffset)
    {
        return ((delegate* unmanaged<IAMPushSource, long, int>)((*lpVtbl)[6]))(this, rtOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetStreamOffset([NativeTypeName("REFERENCE_TIME *")] long* prtOffset)
    {
        return ((delegate* unmanaged<IAMPushSource, long*, int>)((*lpVtbl)[7]))(this, prtOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMaxStreamOffset([NativeTypeName("REFERENCE_TIME *")] long* prtMaxOffset)
    {
        return ((delegate* unmanaged<IAMPushSource, long*, int>)((*lpVtbl)[8]))(this, prtMaxOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetMaxStreamOffset([NativeTypeName("REFERENCE_TIME")] long rtMaxOffset)
    {
        return ((delegate* unmanaged<IAMPushSource, long, int>)((*lpVtbl)[9]))(this, rtMaxOffset);
    }

    public interface Interface : IAMLatency.Interface
    {
        [VtblIndex(4)]
        HRESULT GetPushSourceFlags([NativeTypeName("ULONG *")] uint* pFlags);

        [VtblIndex(5)]
        HRESULT SetPushSourceFlags([NativeTypeName("ULONG")] uint Flags);

        [VtblIndex(6)]
        HRESULT SetStreamOffset([NativeTypeName("REFERENCE_TIME")] long rtOffset);

        [VtblIndex(7)]
        HRESULT GetStreamOffset([NativeTypeName("REFERENCE_TIME *")] long* prtOffset);

        [VtblIndex(8)]
        HRESULT GetMaxStreamOffset([NativeTypeName("REFERENCE_TIME *")] long* prtMaxOffset);

        [VtblIndex(9)]
        HRESULT SetMaxStreamOffset([NativeTypeName("REFERENCE_TIME")] long rtMaxOffset);
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

        [NativeTypeName("HRESULT (REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> GetLatency;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetPushSourceFlags;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetPushSourceFlags;

        [NativeTypeName("HRESULT (REFERENCE_TIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> SetStreamOffset;

        [NativeTypeName("HRESULT (REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> GetStreamOffset;

        [NativeTypeName("HRESULT (REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> GetMaxStreamOffset;

        [NativeTypeName("HRESULT (REFERENCE_TIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> SetMaxStreamOffset;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMPushSource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMPushSource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IAMLatency"/> to <see cref = "IAMPushSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IAMLatency"/> instance to be converted </param>
    public static explicit operator IAMPushSource(Silk.NET.Windows.IAMLatency value)
    {
        return new IAMPushSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMPushSource"/> to <see cref = "Silk.NET.Windows.IAMLatency"/>.</summary>
    /// <param name = "value">The <see cref = "IAMPushSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IAMLatency(IAMPushSource value)
    {
        return new Silk.NET.Windows.IAMLatency(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMPushSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMPushSource(Silk.NET.Windows.IUnknown value)
    {
        return new IAMPushSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMPushSource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMPushSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMPushSource value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
