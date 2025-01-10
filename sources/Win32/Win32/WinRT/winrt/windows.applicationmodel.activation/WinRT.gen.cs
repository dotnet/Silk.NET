// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[56]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IActivatedEventArgs";

    [NativeTypeName("const WCHAR[64]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IActivatedEventArgsWithUser =
        "Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser";

    [NativeTypeName("const WCHAR[71]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IApplicationViewActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs";

    [NativeTypeName("const WCHAR[76]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IAppointmentsProviderActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IAppointmentsProviderActivatedEventArgs";

    [NativeTypeName("const WCHAR[90]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IAppointmentsProviderAddAppointmentActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IAppointmentsProviderAddAppointmentActivatedEventArgs";

    [NativeTypeName("const WCHAR[93]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IAppointmentsProviderRemoveAppointmentActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IAppointmentsProviderRemoveAppointmentActivatedEventArgs";

    [NativeTypeName("const WCHAR[94]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IAppointmentsProviderReplaceAppointmentActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IAppointmentsProviderReplaceAppointmentActivatedEventArgs";

    [NativeTypeName("const WCHAR[98]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs";

    [NativeTypeName("const WCHAR[89]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IAppointmentsProviderShowTimeFrameActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IAppointmentsProviderShowTimeFrameActivatedEventArgs";

    [NativeTypeName("const WCHAR[66]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IBackgroundActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IBackgroundActivatedEventArgs";

    [NativeTypeName("const WCHAR[77]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IBarcodeScannerPreviewActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IBarcodeScannerPreviewActivatedEventArgs";

    [NativeTypeName("const WCHAR[73]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_ICachedFileUpdaterActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ICachedFileUpdaterActivatedEventArgs";

    [NativeTypeName("const WCHAR[70]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_ICameraSettingsActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ICameraSettingsActivatedEventArgs";

    [NativeTypeName("const WCHAR[67]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_ICommandLineActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ICommandLineActivatedEventArgs";

    [NativeTypeName("const WCHAR[68]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_ICommandLineActivationOperation =
        "Windows.ApplicationModel.Activation.ICommandLineActivationOperation";

    [NativeTypeName("const WCHAR[63]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IContactActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IContactActivatedEventArgs";

    [NativeTypeName("const WCHAR[67]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IContactCallActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IContactCallActivatedEventArgs";

    [NativeTypeName("const WCHAR[66]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IContactMapActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IContactMapActivatedEventArgs";

    [NativeTypeName("const WCHAR[70]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IContactMessageActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IContactMessageActivatedEventArgs";

    [NativeTypeName("const WCHAR[68]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IContactPanelActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IContactPanelActivatedEventArgs";

    [NativeTypeName("const WCHAR[69]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IContactPickerActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IContactPickerActivatedEventArgs";

    [NativeTypeName("const WCHAR[67]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IContactPostActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IContactPostActivatedEventArgs";

    [NativeTypeName("const WCHAR[72]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IContactVideoCallActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IContactVideoCallActivatedEventArgs";

    [NativeTypeName("const WCHAR[72]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IContactsProviderActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IContactsProviderActivatedEventArgs";

    [NativeTypeName("const WCHAR[68]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IContinuationActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IContinuationActivatedEventArgs";

    [NativeTypeName("const WCHAR[62]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IDeviceActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IDeviceActivatedEventArgs";

    [NativeTypeName("const WCHAR[69]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IDevicePairingActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IDevicePairingActivatedEventArgs";

    [NativeTypeName("const WCHAR[68]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IDialReceiverActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IDialReceiverActivatedEventArgs";

    [NativeTypeName("const WCHAR[60]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IFileActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IFileActivatedEventArgs";

    [NativeTypeName("const WCHAR[87]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IFileActivatedEventArgsWithCallerPackageFamilyName =
        "Windows.ApplicationModel.Activation.IFileActivatedEventArgsWithCallerPackageFamilyName";

    [NativeTypeName("const WCHAR[80]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IFileActivatedEventArgsWithNeighboringFiles =
        "Windows.ApplicationModel.Activation.IFileActivatedEventArgsWithNeighboringFiles";

    [NativeTypeName("const WCHAR[70]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IFileOpenPickerActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IFileOpenPickerActivatedEventArgs";

    [NativeTypeName("const WCHAR[71]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IFileOpenPickerActivatedEventArgs2 =
        "Windows.ApplicationModel.Activation.IFileOpenPickerActivatedEventArgs2";

    [NativeTypeName("const WCHAR[73]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IFileOpenPickerContinuationEventArgs =
        "Windows.ApplicationModel.Activation.IFileOpenPickerContinuationEventArgs";

    [NativeTypeName("const WCHAR[70]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IFileSavePickerActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IFileSavePickerActivatedEventArgs";

    [NativeTypeName("const WCHAR[71]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IFileSavePickerActivatedEventArgs2 =
        "Windows.ApplicationModel.Activation.IFileSavePickerActivatedEventArgs2";

    [NativeTypeName("const WCHAR[73]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IFileSavePickerContinuationEventArgs =
        "Windows.ApplicationModel.Activation.IFileSavePickerContinuationEventArgs";

    [NativeTypeName("const WCHAR[71]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IFolderPickerContinuationEventArgs =
        "Windows.ApplicationModel.Activation.IFolderPickerContinuationEventArgs";

    [NativeTypeName("const WCHAR[62]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_ILaunchActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ILaunchActivatedEventArgs";

    [NativeTypeName("const WCHAR[63]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_ILaunchActivatedEventArgs2 =
        "Windows.ApplicationModel.Activation.ILaunchActivatedEventArgs2";

    [NativeTypeName("const WCHAR[66]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_ILockScreenActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ILockScreenActivatedEventArgs";

    [NativeTypeName("const WCHAR[70]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_ILockScreenCallActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ILockScreenCallActivatedEventArgs";

    [NativeTypeName("const WCHAR[65]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IPhoneCallActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IPhoneCallActivatedEventArgs";

    [NativeTypeName("const WCHAR[70]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IPickerReturnedActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IPickerReturnedActivatedEventArgs";

    [NativeTypeName("const WCHAR[65]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IPrelaunchActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IPrelaunchActivatedEventArgs";

    [NativeTypeName("const WCHAR[71]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IPrint3DWorkflowActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IPrint3DWorkflowActivatedEventArgs";

    [NativeTypeName("const WCHAR[73]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IPrintTaskSettingsActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IPrintTaskSettingsActivatedEventArgs";

    [NativeTypeName("const WCHAR[64]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IProtocolActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IProtocolActivatedEventArgs";

    [NativeTypeName("const WCHAR[98]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IProtocolActivatedEventArgsWithCallerPackageFamilyNameAndData =
        "Windows.ApplicationModel.Activation.IProtocolActivatedEventArgsWithCallerPackageFamilyNameAndData";

    [NativeTypeName("const WCHAR[74]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IProtocolForResultsActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IProtocolForResultsActivatedEventArgs";

    [NativeTypeName("const WCHAR[72]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IRestrictedLaunchActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IRestrictedLaunchActivatedEventArgs";

    [NativeTypeName("const WCHAR[62]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_ISearchActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ISearchActivatedEventArgs";

    [NativeTypeName("const WCHAR[83]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_ISearchActivatedEventArgsWithLinguisticDetails =
        "Windows.ApplicationModel.Activation.ISearchActivatedEventArgsWithLinguisticDetails";

    [NativeTypeName("const WCHAR[67]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IShareTargetActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IShareTargetActivatedEventArgs";

    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_ISplashScreen =
        "Windows.ApplicationModel.Activation.ISplashScreen";

    [NativeTypeName("const WCHAR[67]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IStartupTaskActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IStartupTaskActivatedEventArgs";

    [NativeTypeName("const WCHAR[55]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_ITileActivatedInfo =
        "Windows.ApplicationModel.Activation.ITileActivatedInfo";

    [NativeTypeName("const WCHAR[73]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IToastNotificationActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IToastNotificationActivatedEventArgs";

    [NativeTypeName("const WCHAR[79]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IUserDataAccountProviderActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IUserDataAccountProviderActivatedEventArgs";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IViewSwitcherProvider =
        "Windows.ApplicationModel.Activation.IViewSwitcherProvider";

    [NativeTypeName("const WCHAR[68]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IVoiceCommandActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IVoiceCommandActivatedEventArgs";

    [NativeTypeName("const WCHAR[68]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IWalletActionActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IWalletActionActivatedEventArgs";

    [NativeTypeName("const WCHAR[74]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IWebAccountProviderActivatedEventArgs =
        "Windows.ApplicationModel.Activation.IWebAccountProviderActivatedEventArgs";

    [NativeTypeName("const WCHAR[82]")]
    public const string InterfaceName_Windows_ApplicationModel_Activation_IWebAuthenticationBrokerContinuationEventArgs =
        "Windows.ApplicationModel.Activation.IWebAuthenticationBrokerContinuationEventArgs";

    [NativeTypeName("const WCHAR[89]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_AppointmentsProviderAddAppointmentActivatedEventArgs =
        "Windows.ApplicationModel.Activation.AppointmentsProviderAddAppointmentActivatedEventArgs";

    [NativeTypeName("const WCHAR[92]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_AppointmentsProviderRemoveAppointmentActivatedEventArgs =
        "Windows.ApplicationModel.Activation.AppointmentsProviderRemoveAppointmentActivatedEventArgs";

    [NativeTypeName("const WCHAR[93]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_AppointmentsProviderReplaceAppointmentActivatedEventArgs =
        "Windows.ApplicationModel.Activation.AppointmentsProviderReplaceAppointmentActivatedEventArgs";

    [NativeTypeName("const WCHAR[97]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_AppointmentsProviderShowAppointmentDetailsActivatedEventArgs =
        "Windows.ApplicationModel.Activation.AppointmentsProviderShowAppointmentDetailsActivatedEventArgs";

    [NativeTypeName("const WCHAR[88]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_AppointmentsProviderShowTimeFrameActivatedEventArgs =
        "Windows.ApplicationModel.Activation.AppointmentsProviderShowTimeFrameActivatedEventArgs";

    [NativeTypeName("const WCHAR[65]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_BackgroundActivatedEventArgs =
        "Windows.ApplicationModel.Activation.BackgroundActivatedEventArgs";

    [NativeTypeName("const WCHAR[76]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_BarcodeScannerPreviewActivatedEventArgs =
        "Windows.ApplicationModel.Activation.BarcodeScannerPreviewActivatedEventArgs";

    [NativeTypeName("const WCHAR[72]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_CachedFileUpdaterActivatedEventArgs =
        "Windows.ApplicationModel.Activation.CachedFileUpdaterActivatedEventArgs";

    [NativeTypeName("const WCHAR[69]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_CameraSettingsActivatedEventArgs =
        "Windows.ApplicationModel.Activation.CameraSettingsActivatedEventArgs";

    [NativeTypeName("const WCHAR[66]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_CommandLineActivatedEventArgs =
        "Windows.ApplicationModel.Activation.CommandLineActivatedEventArgs";

    [NativeTypeName("const WCHAR[67]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_CommandLineActivationOperation =
        "Windows.ApplicationModel.Activation.CommandLineActivationOperation";

    [NativeTypeName("const WCHAR[66]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_ContactCallActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ContactCallActivatedEventArgs";

    [NativeTypeName("const WCHAR[65]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_ContactMapActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ContactMapActivatedEventArgs";

    [NativeTypeName("const WCHAR[69]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_ContactMessageActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ContactMessageActivatedEventArgs";

    [NativeTypeName("const WCHAR[67]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_ContactPanelActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ContactPanelActivatedEventArgs";

    [NativeTypeName("const WCHAR[68]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_ContactPickerActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ContactPickerActivatedEventArgs";

    [NativeTypeName("const WCHAR[66]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_ContactPostActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ContactPostActivatedEventArgs";

    [NativeTypeName("const WCHAR[71]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_ContactVideoCallActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ContactVideoCallActivatedEventArgs";

    [NativeTypeName("const WCHAR[61]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_DeviceActivatedEventArgs =
        "Windows.ApplicationModel.Activation.DeviceActivatedEventArgs";

    [NativeTypeName("const WCHAR[68]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_DevicePairingActivatedEventArgs =
        "Windows.ApplicationModel.Activation.DevicePairingActivatedEventArgs";

    [NativeTypeName("const WCHAR[67]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_DialReceiverActivatedEventArgs =
        "Windows.ApplicationModel.Activation.DialReceiverActivatedEventArgs";

    [NativeTypeName("const WCHAR[59]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_FileActivatedEventArgs =
        "Windows.ApplicationModel.Activation.FileActivatedEventArgs";

    [NativeTypeName("const WCHAR[69]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_FileOpenPickerActivatedEventArgs =
        "Windows.ApplicationModel.Activation.FileOpenPickerActivatedEventArgs";

    [NativeTypeName("const WCHAR[72]")]
    [Obsolete(
        "FileOpenPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_FileOpenPickerContinuationEventArgs =
        "Windows.ApplicationModel.Activation.FileOpenPickerContinuationEventArgs";

    [NativeTypeName("const WCHAR[69]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_FileSavePickerActivatedEventArgs =
        "Windows.ApplicationModel.Activation.FileSavePickerActivatedEventArgs";

    [NativeTypeName("const WCHAR[72]")]
    [Obsolete(
        "FileSavePickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_FileSavePickerContinuationEventArgs =
        "Windows.ApplicationModel.Activation.FileSavePickerContinuationEventArgs";

    [NativeTypeName("const WCHAR[70]")]
    [Obsolete(
        "FolderPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_FolderPickerContinuationEventArgs =
        "Windows.ApplicationModel.Activation.FolderPickerContinuationEventArgs";

    [NativeTypeName("const WCHAR[61]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_LaunchActivatedEventArgs =
        "Windows.ApplicationModel.Activation.LaunchActivatedEventArgs";

    [NativeTypeName("const WCHAR[65]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_LockScreenActivatedEventArgs =
        "Windows.ApplicationModel.Activation.LockScreenActivatedEventArgs";

    [NativeTypeName("const WCHAR[69]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_LockScreenCallActivatedEventArgs =
        "Windows.ApplicationModel.Activation.LockScreenCallActivatedEventArgs";

    [NativeTypeName("const WCHAR[74]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_LockScreenComponentActivatedEventArgs =
        "Windows.ApplicationModel.Activation.LockScreenComponentActivatedEventArgs";

    [NativeTypeName("const WCHAR[64]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_PhoneCallActivatedEventArgs =
        "Windows.ApplicationModel.Activation.PhoneCallActivatedEventArgs";

    [NativeTypeName("const WCHAR[69]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_PickerReturnedActivatedEventArgs =
        "Windows.ApplicationModel.Activation.PickerReturnedActivatedEventArgs";

    [NativeTypeName("const WCHAR[70]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_Print3DWorkflowActivatedEventArgs =
        "Windows.ApplicationModel.Activation.Print3DWorkflowActivatedEventArgs";

    [NativeTypeName("const WCHAR[72]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_PrintTaskSettingsActivatedEventArgs =
        "Windows.ApplicationModel.Activation.PrintTaskSettingsActivatedEventArgs";

    [NativeTypeName("const WCHAR[63]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_ProtocolActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ProtocolActivatedEventArgs";

    [NativeTypeName("const WCHAR[73]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_ProtocolForResultsActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ProtocolForResultsActivatedEventArgs";

    [NativeTypeName("const WCHAR[71]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_RestrictedLaunchActivatedEventArgs =
        "Windows.ApplicationModel.Activation.RestrictedLaunchActivatedEventArgs";

    [NativeTypeName("const WCHAR[61]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_SearchActivatedEventArgs =
        "Windows.ApplicationModel.Activation.SearchActivatedEventArgs";

    [NativeTypeName("const WCHAR[66]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_ShareTargetActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ShareTargetActivatedEventArgs";

    [NativeTypeName("const WCHAR[49]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_SplashScreen =
        "Windows.ApplicationModel.Activation.SplashScreen";

    [NativeTypeName("const WCHAR[66]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_StartupTaskActivatedEventArgs =
        "Windows.ApplicationModel.Activation.StartupTaskActivatedEventArgs";

    [NativeTypeName("const WCHAR[54]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_TileActivatedInfo =
        "Windows.ApplicationModel.Activation.TileActivatedInfo";

    [NativeTypeName("const WCHAR[72]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_ToastNotificationActivatedEventArgs =
        "Windows.ApplicationModel.Activation.ToastNotificationActivatedEventArgs";

    [NativeTypeName("const WCHAR[78]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_UserDataAccountProviderActivatedEventArgs =
        "Windows.ApplicationModel.Activation.UserDataAccountProviderActivatedEventArgs";

    [NativeTypeName("const WCHAR[67]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_VoiceCommandActivatedEventArgs =
        "Windows.ApplicationModel.Activation.VoiceCommandActivatedEventArgs";

    [NativeTypeName("const WCHAR[67]")]
    [Obsolete(
        "WalletActionActivatedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_WalletActionActivatedEventArgs =
        "Windows.ApplicationModel.Activation.WalletActionActivatedEventArgs";

    [NativeTypeName("const WCHAR[73]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_WebAccountProviderActivatedEventArgs =
        "Windows.ApplicationModel.Activation.WebAccountProviderActivatedEventArgs";

    [NativeTypeName("const WCHAR[81]")]
    public const string RuntimeClass_Windows_ApplicationModel_Activation_WebAuthenticationBrokerContinuationEventArgs =
        "Windows.ApplicationModel.Activation.WebAuthenticationBrokerContinuationEventArgs";

    [NativeTypeName(
        "#define WINDOWS_APPLICATIONMODEL_ACTIVATION_ACTIVATEDEVENTSCONTRACT_VERSION 0x10000"
    )]
    public const int WINDOWS_APPLICATIONMODEL_ACTIVATION_ACTIVATEDEVENTSCONTRACT_VERSION = 0x10000;

    [NativeTypeName(
        "#define WINDOWS_APPLICATIONMODEL_ACTIVATION_ACTIVATIONCAMERASETTINGSCONTRACT_VERSION 0x10000"
    )]
    public const int WINDOWS_APPLICATIONMODEL_ACTIVATION_ACTIVATIONCAMERASETTINGSCONTRACT_VERSION =
        0x10000;

    [NativeTypeName(
        "#define WINDOWS_APPLICATIONMODEL_ACTIVATION_CONTACTACTIVATEDEVENTSCONTRACT_VERSION 0x10000"
    )]
    public const int WINDOWS_APPLICATIONMODEL_ACTIVATION_CONTACTACTIVATEDEVENTSCONTRACT_VERSION =
        0x10000;

    [NativeTypeName(
        "#define WINDOWS_APPLICATIONMODEL_ACTIVATION_WEBUISEARCHACTIVATEDEVENTSCONTRACT_VERSION 0x10000"
    )]
    public const int WINDOWS_APPLICATIONMODEL_ACTIVATION_WEBUISEARCHACTIVATEDEVENTSCONTRACT_VERSION =
        0x10000;
}
