// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPTEXT.xml' path='doc/member[@name="SPTEXT"]/*'/>
public enum SPTEXT
{
    /// <include file='SPTEXT.xml' path='doc/member[@name="SPTEXT.SPTEXT_ACTIONDESCRIPTION"]/*'/>
    SPTEXT_ACTIONDESCRIPTION = 1,
    /// <include file='SPTEXT.xml' path='doc/member[@name="SPTEXT.SPTEXT_ACTIONDETAIL"]/*'/>
    SPTEXT_ACTIONDETAIL = (SPTEXT_ACTIONDESCRIPTION + 1),
}