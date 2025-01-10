// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[NativeTypeName("struct IWpfListenerChannelCallback : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IWpfListenerChannelCallback : IWpfListenerChannelCallback.Interface
{
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWpfListenerChannelCallback*, uint>)((*lpVtbl)[0]))(
            (IWpfListenerChannelCallback*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWpfListenerChannelCallback*, uint>)((*lpVtbl)[1]))(
            (IWpfListenerChannelCallback*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT ReportStarted()
    {
        return ((delegate* unmanaged<IWpfListenerChannelCallback*, int>)((*lpVtbl)[2]))(
            (IWpfListenerChannelCallback*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReportStopped(HRESULT hr)
    {
        return ((delegate* unmanaged<IWpfListenerChannelCallback*, HRESULT, int>)((*lpVtbl)[3]))(
            (IWpfListenerChannelCallback*)Unsafe.AsPointer(ref this),
            hr
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReportMessageReceived()
    {
        return ((delegate* unmanaged<IWpfListenerChannelCallback*, int>)((*lpVtbl)[4]))(
            (IWpfListenerChannelCallback*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetId([NativeTypeName("DWORD *")] uint* pdwListenerChannelId)
    {
        return ((delegate* unmanaged<IWpfListenerChannelCallback*, uint*, int>)((*lpVtbl)[5]))(
            (IWpfListenerChannelCallback*)Unsafe.AsPointer(ref this),
            pdwListenerChannelId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetBlob(
        [NativeTypeName("PBYTE")] byte* pBlob,
        [NativeTypeName("DWORD *")] uint* pcbBlob
    )
    {
        return (
            (delegate* unmanaged<IWpfListenerChannelCallback*, byte*, uint*, int>)((*lpVtbl)[6])
        )((IWpfListenerChannelCallback*)Unsafe.AsPointer(ref this), pBlob, pcbBlob);
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT ReportStarted();

        [VtblIndex(3)]
        HRESULT ReportStopped(HRESULT hr);

        [VtblIndex(4)]
        HRESULT ReportMessageReceived();

        [VtblIndex(5)]
        HRESULT GetId([NativeTypeName("DWORD *")] uint* pdwListenerChannelId);

        [VtblIndex(6)]
        HRESULT GetBlob(
            [NativeTypeName("PBYTE")] byte* pBlob,
            [NativeTypeName("DWORD *")] uint* pcbBlob
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT ()")]
        public delegate* unmanaged<TSelf*, int> ReportStarted;

        [NativeTypeName("HRESULT (HRESULT)")]
        public delegate* unmanaged<TSelf*, HRESULT, int> ReportStopped;

        [NativeTypeName("HRESULT ()")]
        public delegate* unmanaged<TSelf*, int> ReportMessageReceived;

        [NativeTypeName("HRESULT (DWORD *)")]
        public delegate* unmanaged<TSelf*, uint*, int> GetId;

        [NativeTypeName("HRESULT (PBYTE, DWORD *)")]
        public delegate* unmanaged<TSelf*, byte*, uint*, int> GetBlob;
    }
}
