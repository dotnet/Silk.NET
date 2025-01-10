// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.pickers.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("DDA45A10-F9D4-40C4-8AF5-C5B6B5A61D1D")]
[NativeTypeName("struct IFileOpenPickerUI : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileOpenPickerUI : IFileOpenPickerUI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileOpenPickerUI));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileOpenPickerUI, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFileOpenPickerUI, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileOpenPickerUI, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IFileOpenPickerUI, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IFileOpenPickerUI, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IFileOpenPickerUI, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddFile(
        HSTRING id,
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Storage::Pickers::Provider::AddFileResult *")]
            AddFileResult* addResult
    )
    {
        return (
            (delegate* unmanaged<IFileOpenPickerUI, HSTRING, IStorageFile, AddFileResult*, int>)(
                (*lpVtbl)[6]
            )
        )(this, id, file, addResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveFile(HSTRING id)
    {
        return ((delegate* unmanaged<IFileOpenPickerUI, HSTRING, int>)((*lpVtbl)[7]))(this, id);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ContainsFile(HSTRING id, [NativeTypeName("boolean *")] byte* isContained)
    {
        return ((delegate* unmanaged<IFileOpenPickerUI, HSTRING, byte*, int>)((*lpVtbl)[8]))(
            this,
            id,
            isContained
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CanAddFile(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("boolean *")] byte* canAdd
    )
    {
        return ((delegate* unmanaged<IFileOpenPickerUI, IStorageFile, byte*, int>)((*lpVtbl)[9]))(
            this,
            file,
            canAdd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AllowedFileTypes(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")]
            IVectorView<HSTRING>** value
    )
    {
        return (
            (delegate* unmanaged<IFileOpenPickerUI, IVectorView<HSTRING>**, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SelectionMode(
        [NativeTypeName("ABI::Windows::Storage::Pickers::Provider::FileSelectionMode *")]
            FileSelectionMode* value
    )
    {
        return ((delegate* unmanaged<IFileOpenPickerUI, FileSelectionMode*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SettingsIdentifier(HSTRING* value)
    {
        return ((delegate* unmanaged<IFileOpenPickerUI, HSTRING*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged<IFileOpenPickerUI, HSTRING*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged<IFileOpenPickerUI, HSTRING, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete(
        "Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised."
    )]
    public HRESULT add_FileRemoved(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileOpenPickerUI_Windows__CStorage__CPickers__CProvider__CFileRemovedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IFileOpenPickerUI,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[15])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [Obsolete(
        "Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised."
    )]
    public HRESULT remove_FileRemoved(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IFileOpenPickerUI, EventRegistrationToken, int>)((*lpVtbl)[16])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_Closing(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileOpenPickerUI_Windows__CStorage__CPickers__CProvider__CPickerClosingEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IFileOpenPickerUI,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[17])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_Closing(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IFileOpenPickerUI, EventRegistrationToken, int>)((*lpVtbl)[18])
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AddFile(
            HSTRING id,
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Storage::Pickers::Provider::AddFileResult *")]
                AddFileResult* addResult
        );

        [VtblIndex(7)]
        HRESULT RemoveFile(HSTRING id);

        [VtblIndex(8)]
        HRESULT ContainsFile(HSTRING id, [NativeTypeName("boolean *")] byte* isContained);

        [VtblIndex(9)]
        HRESULT CanAddFile(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("boolean *")] byte* canAdd
        );

        [VtblIndex(10)]
        HRESULT get_AllowedFileTypes(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")]
                IVectorView<HSTRING>** value
        );

        [VtblIndex(11)]
        HRESULT get_SelectionMode(
            [NativeTypeName("ABI::Windows::Storage::Pickers::Provider::FileSelectionMode *")]
                FileSelectionMode* value
        );

        [VtblIndex(12)]
        HRESULT get_SettingsIdentifier(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(15)]
        [Obsolete(
            "Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised."
        )]
        HRESULT add_FileRemoved(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileOpenPickerUI_Windows__CStorage__CPickers__CProvider__CFileRemovedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(16)]
        [Obsolete(
            "Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised."
        )]
        HRESULT remove_FileRemoved(EventRegistrationToken token);

        [VtblIndex(17)]
        HRESULT add_Closing(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileOpenPickerUI_Windows__CStorage__CPickers__CProvider__CPickerClosingEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(18)]
        HRESULT remove_Closing(EventRegistrationToken token);
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
            "HRESULT (HSTRING, ABI::Windows::Storage::IStorageFile *, ABI::Windows::Storage::Pickers::Provider::AddFileResult *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IStorageFile, AddFileResult*, int> AddFile;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> RemoveFile;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, byte*, int> ContainsFile;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFile, byte*, int> CanAddFile;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<HSTRING>**, int> get_AllowedFileTypes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Pickers::Provider::FileSelectionMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FileSelectionMode*, int> get_SelectionMode;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SettingsIdentifier;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileOpenPickerUI_Windows__CStorage__CPickers__CProvider__CFileRemovedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised."
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_FileRemoved;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete(
            "Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised."
        )]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_FileRemoved;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileOpenPickerUI_Windows__CStorage__CPickers__CProvider__CPickerClosingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_Closing;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Closing;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileOpenPickerUI"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileOpenPickerUI(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFileOpenPickerUI"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFileOpenPickerUI(Silk.NET.WinRT.IInspectable value)
    {
        return new IFileOpenPickerUI(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileOpenPickerUI"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFileOpenPickerUI"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IFileOpenPickerUI value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileOpenPickerUI"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileOpenPickerUI(Silk.NET.Windows.IUnknown value)
    {
        return new IFileOpenPickerUI(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileOpenPickerUI"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileOpenPickerUI"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileOpenPickerUI value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
