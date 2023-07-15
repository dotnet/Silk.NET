// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ARM64_FNPDATA_CR.xml' path='doc/member[@name="ARM64_FNPDATA_CR"]/*'/>
public enum ARM64_FNPDATA_CR
{
    /// <include file='ARM64_FNPDATA_CR.xml' path='doc/member[@name="ARM64_FNPDATA_CR.PdataCrUnchained"]/*'/>
    PdataCrUnchained = 0,
    /// <include file='ARM64_FNPDATA_CR.xml' path='doc/member[@name="ARM64_FNPDATA_CR.PdataCrUnchainedSavedLr"]/*'/>
    PdataCrUnchainedSavedLr = 1,
    /// <include file='ARM64_FNPDATA_CR.xml' path='doc/member[@name="ARM64_FNPDATA_CR.PdataCrChainedWithPac"]/*'/>
    PdataCrChainedWithPac = 2,
    /// <include file='ARM64_FNPDATA_CR.xml' path='doc/member[@name="ARM64_FNPDATA_CR.PdataCrChained"]/*'/>
    PdataCrChained = 3,
}