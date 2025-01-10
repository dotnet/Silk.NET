// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[35]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsAppMessage =
        "Windows.Devices.Sms.ISmsAppMessage";

    [NativeTypeName("const WCHAR[38]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsBinaryMessage =
        "Windows.Devices.Sms.ISmsBinaryMessage";

    [NativeTypeName("const WCHAR[41]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsBroadcastMessage =
        "Windows.Devices.Sms.ISmsBroadcastMessage";

    [NativeTypeName("const WCHAR[31]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsDevice =
        "Windows.Devices.Sms.ISmsDevice";

    [NativeTypeName("const WCHAR[32]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsDevice2 =
        "Windows.Devices.Sms.ISmsDevice2";

    [NativeTypeName("const WCHAR[39]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsDevice2Statics =
        "Windows.Devices.Sms.ISmsDevice2Statics";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsDeviceMessageStore =
        "Windows.Devices.Sms.ISmsDeviceMessageStore";

    [NativeTypeName("const WCHAR[38]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsDeviceStatics =
        "Windows.Devices.Sms.ISmsDeviceStatics";

    [NativeTypeName("const WCHAR[39]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsDeviceStatics2 =
        "Windows.Devices.Sms.ISmsDeviceStatics2";

    [NativeTypeName("const WCHAR[35]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsFilterRule =
        "Windows.Devices.Sms.ISmsFilterRule";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsFilterRuleFactory =
        "Windows.Devices.Sms.ISmsFilterRuleFactory";

    [NativeTypeName("const WCHAR[36]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsFilterRules =
        "Windows.Devices.Sms.ISmsFilterRules";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsFilterRulesFactory =
        "Windows.Devices.Sms.ISmsFilterRulesFactory";

    [NativeTypeName("const WCHAR[32]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsMessage =
        "Windows.Devices.Sms.ISmsMessage";

    [NativeTypeName("const WCHAR[36]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsMessageBase =
        "Windows.Devices.Sms.ISmsMessageBase";

    [NativeTypeName("const WCHAR[49]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsMessageReceivedEventArgs =
        "Windows.Devices.Sms.ISmsMessageReceivedEventArgs";

    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsMessageReceivedTriggerDetails =
        "Windows.Devices.Sms.ISmsMessageReceivedTriggerDetails";

    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsMessageRegistration =
        "Windows.Devices.Sms.ISmsMessageRegistration";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsMessageRegistrationStatics =
        "Windows.Devices.Sms.ISmsMessageRegistrationStatics";

    [NativeTypeName("const WCHAR[45]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsReceivedEventDetails =
        "Windows.Devices.Sms.ISmsReceivedEventDetails";

    [NativeTypeName("const WCHAR[46]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsReceivedEventDetails2 =
        "Windows.Devices.Sms.ISmsReceivedEventDetails2";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsSendMessageResult =
        "Windows.Devices.Sms.ISmsSendMessageResult";

    [NativeTypeName("const WCHAR[38]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsStatusMessage =
        "Windows.Devices.Sms.ISmsStatusMessage";

    [NativeTypeName("const WCHAR[36]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsTextMessage =
        "Windows.Devices.Sms.ISmsTextMessage";

    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsTextMessage2 =
        "Windows.Devices.Sms.ISmsTextMessage2";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsTextMessageStatics =
        "Windows.Devices.Sms.ISmsTextMessageStatics";

    [NativeTypeName("const WCHAR[41]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsVoicemailMessage =
        "Windows.Devices.Sms.ISmsVoicemailMessage";

    [NativeTypeName("const WCHAR[35]")]
    public const string InterfaceName_Windows_Devices_Sms_ISmsWapMessage =
        "Windows.Devices.Sms.ISmsWapMessage";

    [NativeTypeName("const WCHAR[46]")]
    [Obsolete(
        "DeleteSmsMessageOperation may be altered or unavailable for releases after Windows 10."
    )]
    public const string RuntimeClass_Windows_Devices_Sms_DeleteSmsMessageOperation =
        "Windows.Devices.Sms.DeleteSmsMessageOperation";

    [NativeTypeName("const WCHAR[47]")]
    [Obsolete(
        "DeleteSmsMessagesOperation may be altered or unavailable for releases after Windows 10."
    )]
    public const string RuntimeClass_Windows_Devices_Sms_DeleteSmsMessagesOperation =
        "Windows.Devices.Sms.DeleteSmsMessagesOperation";

    [NativeTypeName("const WCHAR[42]")]
    [Obsolete("GetSmsDeviceOperation may be altered or unavailable for releases after Windows 10.")]
    public const string RuntimeClass_Windows_Devices_Sms_GetSmsDeviceOperation =
        "Windows.Devices.Sms.GetSmsDeviceOperation";

    [NativeTypeName("const WCHAR[43]")]
    [Obsolete(
        "GetSmsMessageOperation may be altered or unavailable for releases after Windows 10."
    )]
    public const string RuntimeClass_Windows_Devices_Sms_GetSmsMessageOperation =
        "Windows.Devices.Sms.GetSmsMessageOperation";

    [NativeTypeName("const WCHAR[44]")]
    [Obsolete(
        "GetSmsMessagesOperation may be altered or unavailable for releases after Windows 10."
    )]
    public const string RuntimeClass_Windows_Devices_Sms_GetSmsMessagesOperation =
        "Windows.Devices.Sms.GetSmsMessagesOperation";

    [NativeTypeName("const WCHAR[44]")]
    [Obsolete(
        "SendSmsMessageOperation may be altered or unavailable for releases after Windows 10."
    )]
    public const string RuntimeClass_Windows_Devices_Sms_SendSmsMessageOperation =
        "Windows.Devices.Sms.SendSmsMessageOperation";

    [NativeTypeName("const WCHAR[34]")]
    public const string RuntimeClass_Windows_Devices_Sms_SmsAppMessage =
        "Windows.Devices.Sms.SmsAppMessage";

    [NativeTypeName("const WCHAR[37]")]
    [Obsolete(
        "SmsBinaryMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsAppMessage."
    )]
    public const string RuntimeClass_Windows_Devices_Sms_SmsBinaryMessage =
        "Windows.Devices.Sms.SmsBinaryMessage";

    [NativeTypeName("const WCHAR[40]")]
    public const string RuntimeClass_Windows_Devices_Sms_SmsBroadcastMessage =
        "Windows.Devices.Sms.SmsBroadcastMessage";

    [NativeTypeName("const WCHAR[30]")]
    [Obsolete(
        "SmsDevice may be altered or unavailable for releases after Windows 10. Instead, use SmsDevice2."
    )]
    public const string RuntimeClass_Windows_Devices_Sms_SmsDevice =
        "Windows.Devices.Sms.SmsDevice";

    [NativeTypeName("const WCHAR[31]")]
    public const string RuntimeClass_Windows_Devices_Sms_SmsDevice2 =
        "Windows.Devices.Sms.SmsDevice2";

    [NativeTypeName("const WCHAR[42]")]
    [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
    public const string RuntimeClass_Windows_Devices_Sms_SmsDeviceMessageStore =
        "Windows.Devices.Sms.SmsDeviceMessageStore";

    [NativeTypeName("const WCHAR[34]")]
    public const string RuntimeClass_Windows_Devices_Sms_SmsFilterRule =
        "Windows.Devices.Sms.SmsFilterRule";

    [NativeTypeName("const WCHAR[35]")]
    public const string RuntimeClass_Windows_Devices_Sms_SmsFilterRules =
        "Windows.Devices.Sms.SmsFilterRules";

    [NativeTypeName("const WCHAR[48]")]
    [Obsolete(
        "SmsMessageReceivedEventArgs may be altered or unavailable for releases after Windows 10."
    )]
    public const string RuntimeClass_Windows_Devices_Sms_SmsMessageReceivedEventArgs =
        "Windows.Devices.Sms.SmsMessageReceivedEventArgs";

    [NativeTypeName("const WCHAR[53]")]
    public const string RuntimeClass_Windows_Devices_Sms_SmsMessageReceivedTriggerDetails =
        "Windows.Devices.Sms.SmsMessageReceivedTriggerDetails";

    [NativeTypeName("const WCHAR[43]")]
    public const string RuntimeClass_Windows_Devices_Sms_SmsMessageRegistration =
        "Windows.Devices.Sms.SmsMessageRegistration";

    [NativeTypeName("const WCHAR[44]")]
    [Obsolete(
        "SmsReceivedEventDetails may be altered or unavailable for releases after Windows 10. Instead, use SmsMessageReceivedTriggerDetails."
    )]
    public const string RuntimeClass_Windows_Devices_Sms_SmsReceivedEventDetails =
        "Windows.Devices.Sms.SmsReceivedEventDetails";

    [NativeTypeName("const WCHAR[41]")]
    public const string RuntimeClass_Windows_Devices_Sms_SmsSendMessageResult =
        "Windows.Devices.Sms.SmsSendMessageResult";

    [NativeTypeName("const WCHAR[37]")]
    public const string RuntimeClass_Windows_Devices_Sms_SmsStatusMessage =
        "Windows.Devices.Sms.SmsStatusMessage";

    [NativeTypeName("const WCHAR[35]")]
    [Obsolete(
        "SmsTextMessage may be altered or unavailable for releases after Windows 10. Instead, use SmsTextMessage2."
    )]
    public const string RuntimeClass_Windows_Devices_Sms_SmsTextMessage =
        "Windows.Devices.Sms.SmsTextMessage";

    [NativeTypeName("const WCHAR[36]")]
    public const string RuntimeClass_Windows_Devices_Sms_SmsTextMessage2 =
        "Windows.Devices.Sms.SmsTextMessage2";

    [NativeTypeName("const WCHAR[40]")]
    public const string RuntimeClass_Windows_Devices_Sms_SmsVoicemailMessage =
        "Windows.Devices.Sms.SmsVoicemailMessage";

    [NativeTypeName("const WCHAR[34]")]
    public const string RuntimeClass_Windows_Devices_Sms_SmsWapMessage =
        "Windows.Devices.Sms.SmsWapMessage";

    [NativeTypeName("#define WINDOWS_DEVICES_SMS_LEGACYSMSAPICONTRACT_VERSION 0x10000")]
    public const int WINDOWS_DEVICES_SMS_LEGACYSMSAPICONTRACT_VERSION = 0x10000;
}
