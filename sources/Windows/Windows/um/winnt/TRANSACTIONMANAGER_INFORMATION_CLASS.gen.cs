// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TRANSACTIONMANAGER_INFORMATION_CLASS.xml' path='doc/member[@name="TRANSACTIONMANAGER_INFORMATION_CLASS"]/*'/>
public enum TRANSACTIONMANAGER_INFORMATION_CLASS
{
    /// <include file='TRANSACTIONMANAGER_INFORMATION_CLASS.xml' path='doc/member[@name="TRANSACTIONMANAGER_INFORMATION_CLASS.TransactionManagerBasicInformation"]/*'/>
    TransactionManagerBasicInformation,
    /// <include file='TRANSACTIONMANAGER_INFORMATION_CLASS.xml' path='doc/member[@name="TRANSACTIONMANAGER_INFORMATION_CLASS.TransactionManagerLogInformation"]/*'/>
    TransactionManagerLogInformation,
    /// <include file='TRANSACTIONMANAGER_INFORMATION_CLASS.xml' path='doc/member[@name="TRANSACTIONMANAGER_INFORMATION_CLASS.TransactionManagerLogPathInformation"]/*'/>
    TransactionManagerLogPathInformation,
    /// <include file='TRANSACTIONMANAGER_INFORMATION_CLASS.xml' path='doc/member[@name="TRANSACTIONMANAGER_INFORMATION_CLASS.TransactionManagerRecoveryInformation"]/*'/>
    TransactionManagerRecoveryInformation = 4,
    /// <include file='TRANSACTIONMANAGER_INFORMATION_CLASS.xml' path='doc/member[@name="TRANSACTIONMANAGER_INFORMATION_CLASS.TransactionManagerOnlineProbeInformation"]/*'/>
    TransactionManagerOnlineProbeInformation = 3,
    /// <include file='TRANSACTIONMANAGER_INFORMATION_CLASS.xml' path='doc/member[@name="TRANSACTIONMANAGER_INFORMATION_CLASS.TransactionManagerOldestTransactionInformation"]/*'/>
    TransactionManagerOldestTransactionInformation = 5,
}