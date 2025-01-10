// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("215913CC-57EB-4FAB-AB5A-E5FA7BEA2A6C")]
[NativeTypeName("struct IUserNotification2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUserNotification2 : IUserNotification2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserNotification2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUserNotification2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUserNotification2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUserNotification2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetBalloonInfo(
        [NativeTypeName("LPCWSTR")] ushort* pszTitle,
        [NativeTypeName("LPCWSTR")] ushort* pszText,
        [NativeTypeName("DWORD")] uint dwInfoFlags
    )
    {
        return (
            (delegate* unmanaged<IUserNotification2, ushort*, ushort*, uint, int>)((*lpVtbl)[3])
        )(this, pszTitle, pszText, dwInfoFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetBalloonRetry(
        [NativeTypeName("DWORD")] uint dwShowTime,
        [NativeTypeName("DWORD")] uint dwInterval,
        uint cRetryCount
    )
    {
        return ((delegate* unmanaged<IUserNotification2, uint, uint, uint, int>)((*lpVtbl)[4]))(
            this,
            dwShowTime,
            dwInterval,
            cRetryCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetIconInfo(HICON hIcon, [NativeTypeName("LPCWSTR")] ushort* pszToolTip)
    {
        return ((delegate* unmanaged<IUserNotification2, HICON, ushort*, int>)((*lpVtbl)[5]))(
            this,
            hIcon,
            pszToolTip
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Show(
        IQueryContinue pqc,
        [NativeTypeName("DWORD")] uint dwContinuePollInterval,
        IUserNotificationCallback pSink
    )
    {
        return (
            (delegate* unmanaged<
                IUserNotification2,
                IQueryContinue,
                uint,
                IUserNotificationCallback,
                int>)((*lpVtbl)[6])
        )(this, pqc, dwContinuePollInterval, pSink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT PlaySoundW([NativeTypeName("LPCWSTR")] ushort* pszSoundName)
    {
        return ((delegate* unmanaged<IUserNotification2, ushort*, int>)((*lpVtbl)[7]))(
            this,
            pszSoundName
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetBalloonInfo(
            [NativeTypeName("LPCWSTR")] ushort* pszTitle,
            [NativeTypeName("LPCWSTR")] ushort* pszText,
            [NativeTypeName("DWORD")] uint dwInfoFlags
        );

        [VtblIndex(4)]
        HRESULT SetBalloonRetry(
            [NativeTypeName("DWORD")] uint dwShowTime,
            [NativeTypeName("DWORD")] uint dwInterval,
            uint cRetryCount
        );

        [VtblIndex(5)]
        HRESULT SetIconInfo(HICON hIcon, [NativeTypeName("LPCWSTR")] ushort* pszToolTip);

        [VtblIndex(6)]
        HRESULT Show(
            IQueryContinue pqc,
            [NativeTypeName("DWORD")] uint dwContinuePollInterval,
            IUserNotificationCallback pSink
        );

        [VtblIndex(7)]
        HRESULT PlaySoundW([NativeTypeName("LPCWSTR")] ushort* pszSoundName);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, uint, int> SetBalloonInfo;

        [NativeTypeName("HRESULT (DWORD, DWORD, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> SetBalloonRetry;

        [NativeTypeName("HRESULT (HICON, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HICON, ushort*, int> SetIconInfo;

        [NativeTypeName(
            "HRESULT (IQueryContinue *, DWORD, IUserNotificationCallback *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IQueryContinue,
            uint,
            IUserNotificationCallback,
            int> Show;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> PlaySoundW;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUserNotification2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUserNotification2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUserNotification2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUserNotification2(Silk.NET.Windows.IUnknown value)
    {
        return new IUserNotification2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserNotification2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUserNotification2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUserNotification2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
