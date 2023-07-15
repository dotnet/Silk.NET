// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TRANSACTION_SUPERIOR_ENLISTMENT_INFORMATION.xml' path='doc/member[@name="TRANSACTION_SUPERIOR_ENLISTMENT_INFORMATION"]/*'/>
public partial struct TRANSACTION_SUPERIOR_ENLISTMENT_INFORMATION
{
    /// <include file='TRANSACTION_SUPERIOR_ENLISTMENT_INFORMATION.xml' path='doc/member[@name="TRANSACTION_SUPERIOR_ENLISTMENT_INFORMATION.SuperiorEnlistmentPair"]/*'/>
    public TRANSACTION_ENLISTMENT_PAIR SuperiorEnlistmentPair;
}