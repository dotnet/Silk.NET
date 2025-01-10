// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2456BD58-C067-4513-84FE-8D0C88FFDC61")]
[NativeTypeName("struct IMFSinkWriterCallback2 : IMFSinkWriterCallback")]
[NativeInheritance("IMFSinkWriterCallback")]
public unsafe partial struct IMFSinkWriterCallback2 : IMFSinkWriterCallback2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSinkWriterCallback2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFSinkWriterCallback2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnFinalize(HRESULT hrStatus)
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback2, HRESULT, int>)((*lpVtbl)[3]))(
            this,
            hrStatus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnMarker(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        [NativeTypeName("LPVOID")] void* pvContext
    )
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback2, uint, void*, int>)((*lpVtbl)[4]))(
            this,
            dwStreamIndex,
            pvContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnTransformChange()
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback2, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnStreamError([NativeTypeName("DWORD")] uint dwStreamIndex, HRESULT hrStatus)
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback2, uint, HRESULT, int>)((*lpVtbl)[6]))(
            this,
            dwStreamIndex,
            hrStatus
        );
    }

    public interface Interface : IMFSinkWriterCallback.Interface
    {
        [VtblIndex(5)]
        HRESULT OnTransformChange();

        [VtblIndex(6)]
        HRESULT OnStreamError([NativeTypeName("DWORD")] uint dwStreamIndex, HRESULT hrStatus);
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

        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, int> OnFinalize;

        [NativeTypeName("HRESULT (DWORD, LPVOID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, int> OnMarker;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnTransformChange;

        [NativeTypeName("HRESULT (DWORD, HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HRESULT, int> OnStreamError;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSinkWriterCallback2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSinkWriterCallback2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFSinkWriterCallback"/> to <see cref = "IMFSinkWriterCallback2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFSinkWriterCallback"/> instance to be converted </param>
    public static explicit operator IMFSinkWriterCallback2(
        Silk.NET.Windows.IMFSinkWriterCallback value
    )
    {
        return new IMFSinkWriterCallback2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSinkWriterCallback2"/> to <see cref = "Silk.NET.Windows.IMFSinkWriterCallback"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSinkWriterCallback2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFSinkWriterCallback(
        IMFSinkWriterCallback2 value
    )
    {
        return new Silk.NET.Windows.IMFSinkWriterCallback(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSinkWriterCallback2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSinkWriterCallback2(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSinkWriterCallback2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSinkWriterCallback2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSinkWriterCallback2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSinkWriterCallback2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
