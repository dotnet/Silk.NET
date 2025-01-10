// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SmsModemErrorCode
{
    SmsModemErrorCode_Other = 0,
    SmsModemErrorCode_MessagingNetworkError = 1,
    SmsModemErrorCode_SmsOperationNotSupportedByDevice = 2,
    SmsModemErrorCode_SmsServiceNotSupportedByNetwork = 3,
    SmsModemErrorCode_DeviceFailure = 4,
    SmsModemErrorCode_MessageNotEncodedProperly = 5,
    SmsModemErrorCode_MessageTooLarge = 6,
    SmsModemErrorCode_DeviceNotReady = 7,
    SmsModemErrorCode_NetworkNotReady = 8,
    SmsModemErrorCode_InvalidSmscAddress = 9,
    SmsModemErrorCode_NetworkFailure = 10,
    SmsModemErrorCode_FixedDialingNumberRestricted = 11,
}
