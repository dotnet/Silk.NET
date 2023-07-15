// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PSUACTION.xml' path='doc/member[@name="PSUACTION"]/*'/>
public enum PSUACTION
{
    /// <include file='PSUACTION.xml' path='doc/member[@name="PSUACTION.PSU_DEFAULT"]/*'/>
    PSU_DEFAULT = 1,
    /// <include file='PSUACTION.xml' path='doc/member[@name="PSUACTION.PSU_SECURITY_URL_ONLY"]/*'/>
    PSU_SECURITY_URL_ONLY = (PSU_DEFAULT + 1),
}