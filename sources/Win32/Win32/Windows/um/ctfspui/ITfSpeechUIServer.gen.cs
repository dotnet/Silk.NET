// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfspui.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("90E9A944-9244-489F-A78F-DE67AFC013A7")]
[NativeTypeName("struct ITfSpeechUIServer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfSpeechUIServer : ITfSpeechUIServer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfSpeechUIServer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfSpeechUIServer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfSpeechUIServer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfSpeechUIServer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize()
    {
        return ((delegate* unmanaged<ITfSpeechUIServer, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ShowUI(BOOL fShow)
    {
        return ((delegate* unmanaged<ITfSpeechUIServer, BOOL, int>)((*lpVtbl)[4]))(this, fShow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT UpdateBalloon(
        TfLBBalloonStyle style,
        [NativeTypeName("const WCHAR *")] ushort* pch,
        [NativeTypeName("ULONG")] uint cch
    )
    {
        return (
            (delegate* unmanaged<ITfSpeechUIServer, TfLBBalloonStyle, ushort*, uint, int>)(
                (*lpVtbl)[5]
            )
        )(this, style, pch, cch);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize();

        [VtblIndex(4)]
        HRESULT ShowUI(BOOL fShow);

        [VtblIndex(5)]
        HRESULT UpdateBalloon(
            TfLBBalloonStyle style,
            [NativeTypeName("const WCHAR *")] ushort* pch,
            [NativeTypeName("ULONG")] uint cch
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Initialize;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> ShowUI;

        [NativeTypeName(
            "HRESULT (TfLBBalloonStyle, const WCHAR *, ULONG) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TfLBBalloonStyle, ushort*, uint, int> UpdateBalloon;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfSpeechUIServer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfSpeechUIServer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfSpeechUIServer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfSpeechUIServer(Silk.NET.Windows.IUnknown value)
    {
        return new ITfSpeechUIServer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfSpeechUIServer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfSpeechUIServer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfSpeechUIServer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
