// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SocketErrorStatus
{
    SocketErrorStatus_Unknown = 0,
    SocketErrorStatus_OperationAborted = 1,
    SocketErrorStatus_HttpInvalidServerResponse = 2,
    SocketErrorStatus_ConnectionTimedOut = 3,
    SocketErrorStatus_AddressFamilyNotSupported = 4,
    SocketErrorStatus_SocketTypeNotSupported = 5,
    SocketErrorStatus_HostNotFound = 6,
    SocketErrorStatus_NoDataRecordOfRequestedType = 7,
    SocketErrorStatus_NonAuthoritativeHostNotFound = 8,
    SocketErrorStatus_ClassTypeNotFound = 9,
    SocketErrorStatus_AddressAlreadyInUse = 10,
    SocketErrorStatus_CannotAssignRequestedAddress = 11,
    SocketErrorStatus_ConnectionRefused = 12,
    SocketErrorStatus_NetworkIsUnreachable = 13,
    SocketErrorStatus_UnreachableHost = 14,
    SocketErrorStatus_NetworkIsDown = 15,
    SocketErrorStatus_NetworkDroppedConnectionOnReset = 16,
    SocketErrorStatus_SoftwareCausedConnectionAbort = 17,
    SocketErrorStatus_ConnectionResetByPeer = 18,
    SocketErrorStatus_HostIsDown = 19,
    SocketErrorStatus_NoAddressesFound = 20,
    SocketErrorStatus_TooManyOpenFiles = 21,
    SocketErrorStatus_MessageTooLong = 22,
    SocketErrorStatus_CertificateExpired = 23,
    SocketErrorStatus_CertificateUntrustedRoot = 24,
    SocketErrorStatus_CertificateCommonNameIsIncorrect = 25,
    SocketErrorStatus_CertificateWrongUsage = 26,
    SocketErrorStatus_CertificateRevoked = 27,
    SocketErrorStatus_CertificateNoRevocationCheck = 28,
    SocketErrorStatus_CertificateRevocationServerOffline = 29,
    SocketErrorStatus_CertificateIsInvalid = 30,
}
