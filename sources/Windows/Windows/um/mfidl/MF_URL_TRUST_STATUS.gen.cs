// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MF_URL_TRUST_STATUS.xml' path='doc/member[@name="MF_URL_TRUST_STATUS"]/*'/>
public enum MF_URL_TRUST_STATUS
{
    /// <include file='MF_URL_TRUST_STATUS.xml' path='doc/member[@name="MF_URL_TRUST_STATUS.MF_LICENSE_URL_UNTRUSTED"]/*'/>
    MF_LICENSE_URL_UNTRUSTED = 0,
    /// <include file='MF_URL_TRUST_STATUS.xml' path='doc/member[@name="MF_URL_TRUST_STATUS.MF_LICENSE_URL_TRUSTED"]/*'/>
    MF_LICENSE_URL_TRUSTED = (MF_LICENSE_URL_UNTRUSTED + 1),
    /// <include file='MF_URL_TRUST_STATUS.xml' path='doc/member[@name="MF_URL_TRUST_STATUS.MF_LICENSE_URL_TAMPERED"]/*'/>
    MF_LICENSE_URL_TAMPERED = (MF_LICENSE_URL_TRUSTED + 1),
}