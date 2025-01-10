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

[Guid("0BEDDA75-46E6-4B11-A088-5C68632899B5")]
[NativeTypeName("struct IVoiceCommandSet : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN."
)]
public unsafe partial struct IVoiceCommandSet : IVoiceCommandSet.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVoiceCommandSet));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVoiceCommandSet, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVoiceCommandSet, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVoiceCommandSet, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IVoiceCommandSet, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IVoiceCommandSet, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IVoiceCommandSet, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN."
    )]
    public HRESULT get_Language(HSTRING* value)
    {
        return ((delegate* unmanaged<IVoiceCommandSet, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN."
    )]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<IVoiceCommandSet, HSTRING*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN."
    )]
    public HRESULT SetPhraseListAsync(
        HSTRING phraseListName,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* phraseList,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* updateAction
    )
    {
        return (
            (delegate* unmanaged<
                IVoiceCommandSet,
                HSTRING,
                IIterable<HSTRING>*,
                IAsyncAction*,
                int>)((*lpVtbl)[8])
        )(this, phraseListName, phraseList, updateAction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN."
        )]
        HRESULT get_Language(HSTRING* value);

        [VtblIndex(7)]
        [Obsolete(
            "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN."
        )]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(8)]
        [Obsolete(
            "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN."
        )]
        HRESULT SetPhraseListAsync(
            HSTRING phraseListName,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* phraseList,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* updateAction
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Language;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IIterable<HSTRING>*,
            IAsyncAction*,
            int> SetPhraseListAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVoiceCommandSet"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVoiceCommandSet(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IVoiceCommandSet"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IVoiceCommandSet(Silk.NET.WinRT.IInspectable value)
    {
        return new IVoiceCommandSet(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVoiceCommandSet"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IVoiceCommandSet"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IVoiceCommandSet value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVoiceCommandSet"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVoiceCommandSet(Silk.NET.Windows.IUnknown value)
    {
        return new IVoiceCommandSet(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVoiceCommandSet"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVoiceCommandSet"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVoiceCommandSet value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
