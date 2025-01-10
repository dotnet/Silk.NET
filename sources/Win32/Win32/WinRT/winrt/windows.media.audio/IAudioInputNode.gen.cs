// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D148005C-8428-4784-B7FD-A99D468C5D20")]
[NativeTypeName("struct IAudioInputNode : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioInputNode : IAudioInputNode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioInputNode));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioInputNode, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioInputNode, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioInputNode, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAudioInputNode, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAudioInputNode, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAudioInputNode, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OutgoingConnections(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CAudio__CAudioGraphConnection_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return ((delegate* unmanaged<IAudioInputNode, IVectorView<IntPtr>**, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddOutgoingConnection(
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioNode *")] IAudioNode destination
    )
    {
        return ((delegate* unmanaged<IAudioInputNode, IAudioNode, int>)((*lpVtbl)[7]))(
            this,
            destination
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddOutgoingConnectionWithGain(
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioNode *")] IAudioNode destination,
        double gain
    )
    {
        return ((delegate* unmanaged<IAudioInputNode, IAudioNode, double, int>)((*lpVtbl)[8]))(
            this,
            destination,
            gain
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveOutgoingConnection(
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioNode *")] IAudioNode destination
    )
    {
        return ((delegate* unmanaged<IAudioInputNode, IAudioNode, int>)((*lpVtbl)[9]))(
            this,
            destination
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OutgoingConnections(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CAudio__CAudioGraphConnection_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(7)]
        HRESULT AddOutgoingConnection(
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioNode *")] IAudioNode destination
        );

        [VtblIndex(8)]
        HRESULT AddOutgoingConnectionWithGain(
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioNode *")] IAudioNode destination,
            double gain
        );

        [VtblIndex(9)]
        HRESULT RemoveOutgoingConnection(
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioNode *")] IAudioNode destination
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CAudio__CAudioGraphConnection_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> get_OutgoingConnections;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Audio::IAudioNode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioNode, int> AddOutgoingConnection;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Audio::IAudioNode *, DOUBLE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioNode, double, int> AddOutgoingConnectionWithGain;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Audio::IAudioNode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioNode, int> RemoveOutgoingConnection;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioInputNode"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioInputNode(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioInputNode"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioInputNode(Silk.NET.WinRT.IInspectable value)
    {
        return new IAudioInputNode(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioInputNode"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioInputNode"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAudioInputNode value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioInputNode"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioInputNode(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioInputNode(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioInputNode"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioInputNode"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioInputNode value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
