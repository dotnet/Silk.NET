// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MULTIPLE_TRUSTEE_OPERATION.xml' path='doc/member[@name="MULTIPLE_TRUSTEE_OPERATION"]/*'/>
public enum MULTIPLE_TRUSTEE_OPERATION
{
    /// <include file='MULTIPLE_TRUSTEE_OPERATION.xml' path='doc/member[@name="MULTIPLE_TRUSTEE_OPERATION.NO_MULTIPLE_TRUSTEE"]/*'/>
    NO_MULTIPLE_TRUSTEE,
    /// <include file='MULTIPLE_TRUSTEE_OPERATION.xml' path='doc/member[@name="MULTIPLE_TRUSTEE_OPERATION.TRUSTEE_IS_IMPERSONATE"]/*'/>
    TRUSTEE_IS_IMPERSONATE,
}