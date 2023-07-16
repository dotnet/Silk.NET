// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LSA_FOREST_TRUST_RECORD_TYPE.xml' path='doc/member[@name="LSA_FOREST_TRUST_RECORD_TYPE"]/*'/>
public enum LSA_FOREST_TRUST_RECORD_TYPE
{
    /// <include file='LSA_FOREST_TRUST_RECORD_TYPE.xml' path='doc/member[@name="LSA_FOREST_TRUST_RECORD_TYPE.ForestTrustTopLevelName"]/*'/>
    ForestTrustTopLevelName,
    /// <include file='LSA_FOREST_TRUST_RECORD_TYPE.xml' path='doc/member[@name="LSA_FOREST_TRUST_RECORD_TYPE.ForestTrustTopLevelNameEx"]/*'/>
    ForestTrustTopLevelNameEx,
    /// <include file='LSA_FOREST_TRUST_RECORD_TYPE.xml' path='doc/member[@name="LSA_FOREST_TRUST_RECORD_TYPE.ForestTrustDomainInfo"]/*'/>
    ForestTrustDomainInfo,
    /// <include file='LSA_FOREST_TRUST_RECORD_TYPE.xml' path='doc/member[@name="LSA_FOREST_TRUST_RECORD_TYPE.ForestTrustBinaryInfo"]/*'/>
    ForestTrustBinaryInfo,
    /// <include file='LSA_FOREST_TRUST_RECORD_TYPE.xml' path='doc/member[@name="LSA_FOREST_TRUST_RECORD_TYPE.ForestTrustScannerInfo"]/*'/>
    ForestTrustScannerInfo,
    /// <include file='LSA_FOREST_TRUST_RECORD_TYPE.xml' path='doc/member[@name="LSA_FOREST_TRUST_RECORD_TYPE.ForestTrustRecordTypeLast"]/*'/>
    ForestTrustRecordTypeLast = ForestTrustScannerInfo,
}