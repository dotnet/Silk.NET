// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SERVICE_ERROR_TYPE.xml' path='doc/member[@name="SERVICE_ERROR_TYPE"]/*'/>
public enum SERVICE_ERROR_TYPE
{
    /// <include file='SERVICE_ERROR_TYPE.xml' path='doc/member[@name="SERVICE_ERROR_TYPE.IgnoreError"]/*'/>
    IgnoreError = 0x00000000,
    /// <include file='SERVICE_ERROR_TYPE.xml' path='doc/member[@name="SERVICE_ERROR_TYPE.NormalError"]/*'/>
    NormalError = 0x00000001,
    /// <include file='SERVICE_ERROR_TYPE.xml' path='doc/member[@name="SERVICE_ERROR_TYPE.SevereError"]/*'/>
    SevereError = 0x00000002,
    /// <include file='SERVICE_ERROR_TYPE.xml' path='doc/member[@name="SERVICE_ERROR_TYPE.CriticalError"]/*'/>
    CriticalError = 0x00000003,
}