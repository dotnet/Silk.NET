// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPC_FINANCIAL_CRITERIA.xml' path='doc/member[@name="SPC_FINANCIAL_CRITERIA"]/*'/>
public partial struct SPC_FINANCIAL_CRITERIA
{
    /// <include file='SPC_FINANCIAL_CRITERIA.xml' path='doc/member[@name="SPC_FINANCIAL_CRITERIA.fFinancialInfoAvailable"]/*'/>
    public BOOL fFinancialInfoAvailable;
    /// <include file='SPC_FINANCIAL_CRITERIA.xml' path='doc/member[@name="SPC_FINANCIAL_CRITERIA.fMeetsCriteria"]/*'/>
    public BOOL fMeetsCriteria;
}