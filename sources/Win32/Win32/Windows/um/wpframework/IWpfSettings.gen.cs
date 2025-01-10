// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[NativeTypeName("struct IWpfSettings : IWpfReferencedObject")]
[NativeInheritance("IWpfReferencedObject")]
public unsafe partial struct IWpfSettings : IWpfSettings.Interface
{
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWpfSettings*, uint>)((*lpVtbl)[0]))(
            (IWpfSettings*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWpfSettings*, uint>)((*lpVtbl)[1]))(
            (IWpfSettings*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT GetDwordProperty(
        WPF_SETTINGS_DWORD_ENUM SettingId,
        [NativeTypeName("DWORD *")] uint* pdwSetting
    )
    {
        return (
            (delegate* unmanaged<IWpfSettings*, WPF_SETTINGS_DWORD_ENUM, uint*, int>)((*lpVtbl)[2])
        )((IWpfSettings*)Unsafe.AsPointer(ref this), SettingId, pdwSetting);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetUlonglongProperty(
        WPF_SETTINGS_ULONGLONG_ENUM SettingId,
        [NativeTypeName("ULONGLONG *")] ulong* pSetting
    )
    {
        return (
            (delegate* unmanaged<IWpfSettings*, WPF_SETTINGS_ULONGLONG_ENUM, ulong*, int>)(
                (*lpVtbl)[3]
            )
        )((IWpfSettings*)Unsafe.AsPointer(ref this), SettingId, pSetting);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStringProperty(
        WPF_SETTINGS_STRING_ENUM SettingId,
        [NativeTypeName("PWSTR")] ushort* pszSetting,
        [NativeTypeName("DWORD *")] uint* pcchSetting
    )
    {
        return (
            (delegate* unmanaged<IWpfSettings*, WPF_SETTINGS_STRING_ENUM, ushort*, uint*, int>)(
                (*lpVtbl)[4]
            )
        )((IWpfSettings*)Unsafe.AsPointer(ref this), SettingId, pszSetting, pcchSetting);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetBoolProperty(WPF_SETTINGS_BOOL_ENUM SettingId, BOOL* pfSetting)
    {
        return (
            (delegate* unmanaged<IWpfSettings*, WPF_SETTINGS_BOOL_ENUM, BOOL*, int>)((*lpVtbl)[5])
        )((IWpfSettings*)Unsafe.AsPointer(ref this), SettingId, pfSetting);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetHandleProperty(WPF_SETTINGS_HANDLE_ENUM SettingId, HANDLE* phSetting)
    {
        return (
            (delegate* unmanaged<IWpfSettings*, WPF_SETTINGS_HANDLE_ENUM, HANDLE*, int>)(
                (*lpVtbl)[6]
            )
        )((IWpfSettings*)Unsafe.AsPointer(ref this), SettingId, phSetting);
    }

    public interface Interface : IWpfReferencedObject.Interface
    {
        [VtblIndex(2)]
        HRESULT GetDwordProperty(
            WPF_SETTINGS_DWORD_ENUM SettingId,
            [NativeTypeName("DWORD *")] uint* pdwSetting
        );

        [VtblIndex(3)]
        HRESULT GetUlonglongProperty(
            WPF_SETTINGS_ULONGLONG_ENUM SettingId,
            [NativeTypeName("ULONGLONG *")] ulong* pSetting
        );

        [VtblIndex(4)]
        HRESULT GetStringProperty(
            WPF_SETTINGS_STRING_ENUM SettingId,
            [NativeTypeName("PWSTR")] ushort* pszSetting,
            [NativeTypeName("DWORD *")] uint* pcchSetting
        );

        [VtblIndex(5)]
        HRESULT GetBoolProperty(WPF_SETTINGS_BOOL_ENUM SettingId, BOOL* pfSetting);

        [VtblIndex(6)]
        HRESULT GetHandleProperty(WPF_SETTINGS_HANDLE_ENUM SettingId, HANDLE* phSetting);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (WPF_SETTINGS_DWORD_ENUM, DWORD *)")]
        public delegate* unmanaged<TSelf*, WPF_SETTINGS_DWORD_ENUM, uint*, int> GetDwordProperty;

        [NativeTypeName("HRESULT (WPF_SETTINGS_ULONGLONG_ENUM, ULONGLONG *)")]
        public delegate* unmanaged<
            TSelf*,
            WPF_SETTINGS_ULONGLONG_ENUM,
            ulong*,
            int> GetUlonglongProperty;

        [NativeTypeName("HRESULT (WPF_SETTINGS_STRING_ENUM, PWSTR, DWORD *)")]
        public delegate* unmanaged<
            TSelf*,
            WPF_SETTINGS_STRING_ENUM,
            ushort*,
            uint*,
            int> GetStringProperty;

        [NativeTypeName("HRESULT (WPF_SETTINGS_BOOL_ENUM, BOOL *)")]
        public delegate* unmanaged<TSelf*, WPF_SETTINGS_BOOL_ENUM, BOOL*, int> GetBoolProperty;

        [NativeTypeName("HRESULT (WPF_SETTINGS_HANDLE_ENUM, HANDLE *)")]
        public delegate* unmanaged<
            TSelf*,
            WPF_SETTINGS_HANDLE_ENUM,
            HANDLE*,
            int> GetHandleProperty;
    }
}
