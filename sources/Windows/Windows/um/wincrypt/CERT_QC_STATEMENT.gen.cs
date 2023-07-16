// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_QC_STATEMENT.xml' path='doc/member[@name="CERT_QC_STATEMENT"]/*'/>
public unsafe partial struct CERT_QC_STATEMENT
{
    /// <include file='CERT_QC_STATEMENT.xml' path='doc/member[@name="CERT_QC_STATEMENT.pszStatementId"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszStatementId;
    /// <include file='CERT_QC_STATEMENT.xml' path='doc/member[@name="CERT_QC_STATEMENT.StatementInfo"]/*'/>
    [NativeTypeName("CRYPT_OBJID_BLOB")]
    public CRYPT_DATA_BLOB StatementInfo;
}