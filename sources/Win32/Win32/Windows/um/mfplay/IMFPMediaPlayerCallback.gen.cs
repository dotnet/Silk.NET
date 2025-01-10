// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("766C8FFB-5FDB-4FEA-A28D-B912996F51BD")]
[NativeTypeName("struct IMFPMediaPlayerCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFPMediaPlayerCallback
    : IMFPMediaPlayerCallback.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFPMediaPlayerCallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFPMediaPlayerCallback, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFPMediaPlayerCallback, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFPMediaPlayerCallback, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void OnMediaPlayerEvent(MFP_EVENT_HEADER* pEventHeader)
    {
        ((delegate* unmanaged<IMFPMediaPlayerCallback, MFP_EVENT_HEADER*, void>)((*lpVtbl)[3]))(
            this,
            pEventHeader
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void OnMediaPlayerEvent(MFP_EVENT_HEADER* pEventHeader);
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

        [NativeTypeName("void (MFP_EVENT_HEADER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFP_EVENT_HEADER*, void> OnMediaPlayerEvent;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFPMediaPlayerCallback"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFPMediaPlayerCallback(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFPMediaPlayerCallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFPMediaPlayerCallback(Silk.NET.Windows.IUnknown value)
    {
        return new IMFPMediaPlayerCallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFPMediaPlayerCallback"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFPMediaPlayerCallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFPMediaPlayerCallback value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
