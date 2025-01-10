// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C3A9E92A-DA88-46B0-A110-6CF953026CB9")]
[NativeTypeName("struct IMFMediaKeySessionNotify2 : IMFMediaKeySessionNotify")]
[NativeInheritance("IMFMediaKeySessionNotify")]
public unsafe partial struct IMFMediaKeySessionNotify2
    : IMFMediaKeySessionNotify2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaKeySessionNotify2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaKeySessionNotify2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMediaKeySessionNotify2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaKeySessionNotify2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void KeyMessage(
        [NativeTypeName("BSTR")] ushort* destinationURL,
        [NativeTypeName("const BYTE *")] byte* message,
        [NativeTypeName("DWORD")] uint cb
    )
    {
        (
            (delegate* unmanaged<IMFMediaKeySessionNotify2, ushort*, byte*, uint, void>)(
                (*lpVtbl)[3]
            )
        )(this, destinationURL, message, cb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void KeyAdded()
    {
        ((delegate* unmanaged<IMFMediaKeySessionNotify2, void>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void KeyError(ushort code, [NativeTypeName("DWORD")] uint systemCode)
    {
        ((delegate* unmanaged<IMFMediaKeySessionNotify2, ushort, uint, void>)((*lpVtbl)[5]))(
            this,
            code,
            systemCode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void KeyMessage2(
        MF_MEDIAKEYSESSION_MESSAGETYPE eMessageType,
        [NativeTypeName("BSTR")] ushort* destinationURL,
        [NativeTypeName("const BYTE *")] byte* pbMessage,
        [NativeTypeName("DWORD")] uint cbMessage
    )
    {
        (
            (delegate* unmanaged<
                IMFMediaKeySessionNotify2,
                MF_MEDIAKEYSESSION_MESSAGETYPE,
                ushort*,
                byte*,
                uint,
                void>)((*lpVtbl)[6])
        )(this, eMessageType, destinationURL, pbMessage, cbMessage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void KeyStatusChange()
    {
        ((delegate* unmanaged<IMFMediaKeySessionNotify2, void>)((*lpVtbl)[7]))(this);
    }

    public interface Interface : IMFMediaKeySessionNotify.Interface
    {
        [VtblIndex(6)]
        void KeyMessage2(
            MF_MEDIAKEYSESSION_MESSAGETYPE eMessageType,
            [NativeTypeName("BSTR")] ushort* destinationURL,
            [NativeTypeName("const BYTE *")] byte* pbMessage,
            [NativeTypeName("DWORD")] uint cbMessage
        );

        [VtblIndex(7)]
        void KeyStatusChange();
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

        [NativeTypeName("void (BSTR, const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, byte*, uint, void> KeyMessage;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> KeyAdded;

        [NativeTypeName("void (USHORT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, uint, void> KeyError;

        [NativeTypeName(
            "void (MF_MEDIAKEYSESSION_MESSAGETYPE, BSTR, const BYTE *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MF_MEDIAKEYSESSION_MESSAGETYPE,
            ushort*,
            byte*,
            uint,
            void> KeyMessage2;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> KeyStatusChange;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaKeySessionNotify2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaKeySessionNotify2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFMediaKeySessionNotify"/> to <see cref = "IMFMediaKeySessionNotify2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFMediaKeySessionNotify"/> instance to be converted </param>
    public static explicit operator IMFMediaKeySessionNotify2(
        Silk.NET.Windows.IMFMediaKeySessionNotify value
    )
    {
        return new IMFMediaKeySessionNotify2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaKeySessionNotify2"/> to <see cref = "Silk.NET.Windows.IMFMediaKeySessionNotify"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaKeySessionNotify2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFMediaKeySessionNotify(
        IMFMediaKeySessionNotify2 value
    )
    {
        return new Silk.NET.Windows.IMFMediaKeySessionNotify(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaKeySessionNotify2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaKeySessionNotify2(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaKeySessionNotify2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaKeySessionNotify2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaKeySessionNotify2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaKeySessionNotify2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
