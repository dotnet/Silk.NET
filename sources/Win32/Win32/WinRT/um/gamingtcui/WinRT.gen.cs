// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gamingtcui.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static unsafe partial class WinRT
{
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowGameInviteUI(
        HSTRING serviceConfigurationId,
        HSTRING sessionTemplateName,
        HSTRING sessionId,
        HSTRING invitationDisplayText,
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowPlayerPickerUI(
        HSTRING promptDisplayText,
        [NativeTypeName("const HSTRING *")] HSTRING* xuids,
        [NativeTypeName("size_t")] nuint xuidsCount,
        [NativeTypeName("const HSTRING *")] HSTRING* preSelectedXuids,
        [NativeTypeName("size_t")] nuint preSelectedXuidsCount,
        [NativeTypeName("size_t")] nuint minSelectionCount,
        [NativeTypeName("size_t")] nuint maxSelectionCount,
        [NativeTypeName("PlayerPickerUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, HSTRING*, nuint, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowProfileCardUI(
        HSTRING targetUserXuid,
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowChangeFriendRelationshipUI(
        HSTRING targetUserXuid,
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowTitleAchievementsUI(
        [NativeTypeName("UINT32")] uint titleId,
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ProcessPendingGameUI(BOOL waitForCompletion);

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern BOOL TryCancelPendingGameUI();

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT CheckGamingPrivilegeWithUI(
        [NativeTypeName("UINT32")] uint privilegeId,
        HSTRING scope,
        HSTRING policy,
        HSTRING friendlyMessage,
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT CheckGamingPrivilegeSilently(
        [NativeTypeName("UINT32")] uint privilegeId,
        HSTRING scope,
        HSTRING policy,
        BOOL* hasPrivilege
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowGameInviteUIForUser(
        IInspectable user,
        HSTRING serviceConfigurationId,
        HSTRING sessionTemplateName,
        HSTRING sessionId,
        HSTRING invitationDisplayText,
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowPlayerPickerUIForUser(
        IInspectable user,
        HSTRING promptDisplayText,
        [NativeTypeName("const HSTRING *")] HSTRING* xuids,
        [NativeTypeName("size_t")] nuint xuidsCount,
        [NativeTypeName("const HSTRING *")] HSTRING* preSelectedXuids,
        [NativeTypeName("size_t")] nuint preSelectedXuidsCount,
        [NativeTypeName("size_t")] nuint minSelectionCount,
        [NativeTypeName("size_t")] nuint maxSelectionCount,
        [NativeTypeName("PlayerPickerUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, HSTRING*, nuint, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowProfileCardUIForUser(
        IInspectable user,
        HSTRING targetUserXuid,
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowChangeFriendRelationshipUIForUser(
        IInspectable user,
        HSTRING targetUserXuid,
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowTitleAchievementsUIForUser(
        IInspectable user,
        [NativeTypeName("UINT32")] uint titleId,
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT CheckGamingPrivilegeWithUIForUser(
        IInspectable user,
        [NativeTypeName("UINT32")] uint privilegeId,
        HSTRING scope,
        HSTRING policy,
        HSTRING friendlyMessage,
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT CheckGamingPrivilegeSilentlyForUser(
        IInspectable user,
        [NativeTypeName("UINT32")] uint privilegeId,
        HSTRING scope,
        HSTRING policy,
        BOOL* hasPrivilege
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowGameInviteUIWithContext(
        HSTRING serviceConfigurationId,
        HSTRING sessionTemplateName,
        HSTRING sessionId,
        HSTRING invitationDisplayText,
        HSTRING customActivationContext,
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowGameInviteUIWithContextForUser(
        IInspectable user,
        HSTRING serviceConfigurationId,
        HSTRING sessionTemplateName,
        HSTRING sessionId,
        HSTRING invitationDisplayText,
        HSTRING customActivationContext,
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowGameInfoUI(
        [NativeTypeName("UINT32")] uint titleId,
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowGameInfoUIForUser(
        IInspectable user,
        [NativeTypeName("UINT32")] uint titleId,
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowFindFriendsUI(
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowFindFriendsUIForUser(
        IInspectable user,
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowCustomizeUserProfileUI(
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowCustomizeUserProfileUIForUser(
        IInspectable user,
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowUserSettingsUI(
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );

    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowUserSettingsUIForUser(
        IInspectable user,
        [NativeTypeName("GameUICompletionRoutine")]
            delegate* unmanaged<HRESULT, void*, void> completionRoutine,
        void* context
    );
}
