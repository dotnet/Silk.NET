// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gamingtcui.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System.Runtime.InteropServices;

namespace Silk.NET.WinRT;
public static unsafe partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowGameInviteUI"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowGameInviteUI(HSTRING serviceConfigurationId, HSTRING sessionTemplateName, HSTRING sessionId, HSTRING invitationDisplayText, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowPlayerPickerUI"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowPlayerPickerUI(HSTRING promptDisplayText, [NativeTypeName("const HSTRING *")] HSTRING* xuids, [NativeTypeName("size_t")] nuint xuidsCount, [NativeTypeName("const HSTRING *")] HSTRING* preSelectedXuids, [NativeTypeName("size_t")] nuint preSelectedXuidsCount, [NativeTypeName("size_t")] nuint minSelectionCount, [NativeTypeName("size_t")] nuint maxSelectionCount, [NativeTypeName("PlayerPickerUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, HSTRING*, nuint, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowProfileCardUI"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowProfileCardUI(HSTRING targetUserXuid, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowChangeFriendRelationshipUI"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowChangeFriendRelationshipUI(HSTRING targetUserXuid, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowTitleAchievementsUI"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowTitleAchievementsUI([NativeTypeName("UINT32")] uint titleId, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ProcessPendingGameUI"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ProcessPendingGameUI(BOOL waitForCompletion);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.TryCancelPendingGameUI"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern BOOL TryCancelPendingGameUI();
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.CheckGamingPrivilegeWithUI"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT CheckGamingPrivilegeWithUI([NativeTypeName("UINT32")] uint privilegeId, HSTRING scope, HSTRING policy, HSTRING friendlyMessage, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.CheckGamingPrivilegeSilently"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT CheckGamingPrivilegeSilently([NativeTypeName("UINT32")] uint privilegeId, HSTRING scope, HSTRING policy, BOOL* hasPrivilege);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowGameInviteUIForUser"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowGameInviteUIForUser(IInspectable* user, HSTRING serviceConfigurationId, HSTRING sessionTemplateName, HSTRING sessionId, HSTRING invitationDisplayText, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowPlayerPickerUIForUser"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowPlayerPickerUIForUser(IInspectable* user, HSTRING promptDisplayText, [NativeTypeName("const HSTRING *")] HSTRING* xuids, [NativeTypeName("size_t")] nuint xuidsCount, [NativeTypeName("const HSTRING *")] HSTRING* preSelectedXuids, [NativeTypeName("size_t")] nuint preSelectedXuidsCount, [NativeTypeName("size_t")] nuint minSelectionCount, [NativeTypeName("size_t")] nuint maxSelectionCount, [NativeTypeName("PlayerPickerUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, HSTRING*, nuint, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowProfileCardUIForUser"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowProfileCardUIForUser(IInspectable* user, HSTRING targetUserXuid, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowChangeFriendRelationshipUIForUser"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowChangeFriendRelationshipUIForUser(IInspectable* user, HSTRING targetUserXuid, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowTitleAchievementsUIForUser"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowTitleAchievementsUIForUser(IInspectable* user, [NativeTypeName("UINT32")] uint titleId, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.CheckGamingPrivilegeWithUIForUser"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT CheckGamingPrivilegeWithUIForUser(IInspectable* user, [NativeTypeName("UINT32")] uint privilegeId, HSTRING scope, HSTRING policy, HSTRING friendlyMessage, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.CheckGamingPrivilegeSilentlyForUser"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT CheckGamingPrivilegeSilentlyForUser(IInspectable* user, [NativeTypeName("UINT32")] uint privilegeId, HSTRING scope, HSTRING policy, BOOL* hasPrivilege);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowGameInviteUIWithContext"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowGameInviteUIWithContext(HSTRING serviceConfigurationId, HSTRING sessionTemplateName, HSTRING sessionId, HSTRING invitationDisplayText, HSTRING customActivationContext, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowGameInviteUIWithContextForUser"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowGameInviteUIWithContextForUser(IInspectable* user, HSTRING serviceConfigurationId, HSTRING sessionTemplateName, HSTRING sessionId, HSTRING invitationDisplayText, HSTRING customActivationContext, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowGameInfoUI"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowGameInfoUI([NativeTypeName("UINT32")] uint titleId, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowGameInfoUIForUser"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowGameInfoUIForUser(IInspectable* user, [NativeTypeName("UINT32")] uint titleId, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowFindFriendsUI"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowFindFriendsUI([NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowFindFriendsUIForUser"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowFindFriendsUIForUser(IInspectable* user, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowCustomizeUserProfileUI"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowCustomizeUserProfileUI([NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowCustomizeUserProfileUIForUser"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowCustomizeUserProfileUIForUser(IInspectable* user, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowUserSettingsUI"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowUserSettingsUI([NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.ShowUserSettingsUIForUser"]/*'/>
    [DllImport("gamingtcui", ExactSpelling = true)]
    public static extern HRESULT ShowUserSettingsUIForUser(IInspectable* user, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
}