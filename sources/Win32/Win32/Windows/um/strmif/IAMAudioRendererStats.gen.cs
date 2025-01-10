// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("22320CB2-D41A-11D2-BF7C-D7CB9DF0BF93")]
[NativeTypeName("struct IAMAudioRendererStats : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMAudioRendererStats : IAMAudioRendererStats.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMAudioRendererStats));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMAudioRendererStats, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAMAudioRendererStats, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMAudioRendererStats, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStatParam(
        [NativeTypeName("DWORD")] uint dwParam,
        [NativeTypeName("DWORD *")] uint* pdwParam1,
        [NativeTypeName("DWORD *")] uint* pdwParam2
    )
    {
        return (
            (delegate* unmanaged<IAMAudioRendererStats, uint, uint*, uint*, int>)((*lpVtbl)[3])
        )(this, dwParam, pdwParam1, pdwParam2);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStatParam(
            [NativeTypeName("DWORD")] uint dwParam,
            [NativeTypeName("DWORD *")] uint* pdwParam1,
            [NativeTypeName("DWORD *")] uint* pdwParam2
        );
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

        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, uint*, int> GetStatParam;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMAudioRendererStats"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMAudioRendererStats(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMAudioRendererStats"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMAudioRendererStats(Silk.NET.Windows.IUnknown value)
    {
        return new IAMAudioRendererStats(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMAudioRendererStats"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMAudioRendererStats"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMAudioRendererStats value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
