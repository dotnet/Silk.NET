// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPSEMANTICFORMAT.xml' path='doc/member[@name="SPSEMANTICFORMAT"]/*'/>
public enum SPSEMANTICFORMAT
{
    /// <include file='SPSEMANTICFORMAT.xml' path='doc/member[@name="SPSEMANTICFORMAT.SPSMF_SAPI_PROPERTIES"]/*'/>
    SPSMF_SAPI_PROPERTIES = 0,
    /// <include file='SPSEMANTICFORMAT.xml' path='doc/member[@name="SPSEMANTICFORMAT.SPSMF_SRGS_SEMANTICINTERPRETATION_MS"]/*'/>
    SPSMF_SRGS_SEMANTICINTERPRETATION_MS = 1,
    /// <include file='SPSEMANTICFORMAT.xml' path='doc/member[@name="SPSEMANTICFORMAT.SPSMF_SRGS_SAPIPROPERTIES"]/*'/>
    SPSMF_SRGS_SAPIPROPERTIES = 2,
    /// <include file='SPSEMANTICFORMAT.xml' path='doc/member[@name="SPSEMANTICFORMAT.SPSMF_UPS"]/*'/>
    SPSMF_UPS = 4,
    /// <include file='SPSEMANTICFORMAT.xml' path='doc/member[@name="SPSEMANTICFORMAT.SPSMF_SRGS_SEMANTICINTERPRETATION_W3C"]/*'/>
    SPSMF_SRGS_SEMANTICINTERPRETATION_W3C = 8,
}