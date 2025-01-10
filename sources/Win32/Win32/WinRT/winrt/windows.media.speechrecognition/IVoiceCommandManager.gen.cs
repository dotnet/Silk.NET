// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("AA3A8DD5-B6E7-4EE2-BAA9-DD6BACED0A2B")]
[NativeTypeName("struct IVoiceCommandManager : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager instead of Windows.Media.SpeechRecognition.VoiceComandManager. For more info, see MSDN."
)]
public unsafe partial struct IVoiceCommandManager : IVoiceCommandManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVoiceCommandManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVoiceCommandManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVoiceCommandManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVoiceCommandManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IVoiceCommandManager, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IVoiceCommandManager, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IVoiceCommandManager, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager instead of Windows.Media.SpeechRecognition.VoiceComandManager. For more info, see MSDN."
    )]
    public HRESULT InstallCommandSetsFromStorageFileAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* installAction
    )
    {
        return (
            (delegate* unmanaged<IVoiceCommandManager, IStorageFile, IAsyncAction*, int>)(
                (*lpVtbl)[6]
            )
        )(this, file, installAction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager instead of Windows.Media.SpeechRecognition.VoiceComandManager. For more info, see MSDN."
    )]
    public HRESULT get_InstalledCommandSets(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CMedia__CSpeechRecognition__CVoiceCommandSet_t **"
        )]
            IMapView<HSTRING, IntPtr>** voiceCommandSets
    )
    {
        return (
            (delegate* unmanaged<IVoiceCommandManager, IMapView<HSTRING, IntPtr>**, int>)(
                (*lpVtbl)[7]
            )
        )(this, voiceCommandSets);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager instead of Windows.Media.SpeechRecognition.VoiceComandManager. For more info, see MSDN."
        )]
        HRESULT InstallCommandSetsFromStorageFileAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")]
                IAsyncAction* installAction
        );

        [VtblIndex(7)]
        [Obsolete(
            "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager instead of Windows.Media.SpeechRecognition.VoiceComandManager. For more info, see MSDN."
        )]
        HRESULT get_InstalledCommandSets(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CMedia__CSpeechRecognition__CVoiceCommandSet_t **"
            )]
                IMapView<HSTRING, IntPtr>** voiceCommandSets
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
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager instead of Windows.Media.SpeechRecognition.VoiceComandManager. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IAsyncAction*,
            int> InstallCommandSetsFromStorageFileAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CMedia__CSpeechRecognition__CVoiceCommandSet_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager instead of Windows.Media.SpeechRecognition.VoiceComandManager. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            IMapView<HSTRING, IntPtr>**,
            int> get_InstalledCommandSets;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVoiceCommandManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVoiceCommandManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IVoiceCommandManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IVoiceCommandManager(Silk.NET.WinRT.IInspectable value)
    {
        return new IVoiceCommandManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVoiceCommandManager"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IVoiceCommandManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IVoiceCommandManager value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVoiceCommandManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVoiceCommandManager(Silk.NET.Windows.IUnknown value)
    {
        return new IVoiceCommandManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVoiceCommandManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVoiceCommandManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVoiceCommandManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
