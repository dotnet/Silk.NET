// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("26AFEA53-D9ED-42B5-AB80-E64F9EE34779")]
[NativeTypeName("struct IMFSeekInfo : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFSeekInfo : IMFSeekInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSeekInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSeekInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFSeekInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSeekInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetNearestKeyFrames(
        [NativeTypeName("const GUID *")] Guid* pguidTimeFormat,
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition,
        PROPVARIANT* pvarPreviousKeyFrame,
        PROPVARIANT* pvarNextKeyFrame
    )
    {
        return (
            (delegate* unmanaged<
                IMFSeekInfo,
                Guid*,
                PROPVARIANT*,
                PROPVARIANT*,
                PROPVARIANT*,
                int>)((*lpVtbl)[3])
        )(this, pguidTimeFormat, pvarStartPosition, pvarPreviousKeyFrame, pvarNextKeyFrame);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetNearestKeyFrames(
            [NativeTypeName("const GUID *")] Guid* pguidTimeFormat,
            [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition,
            PROPVARIANT* pvarPreviousKeyFrame,
            PROPVARIANT* pvarNextKeyFrame
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

        [NativeTypeName(
            "HRESULT (const GUID *, const PROPVARIANT *, PROPVARIANT *, PROPVARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            PROPVARIANT*,
            PROPVARIANT*,
            PROPVARIANT*,
            int> GetNearestKeyFrames;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSeekInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSeekInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSeekInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSeekInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSeekInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSeekInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSeekInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSeekInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
