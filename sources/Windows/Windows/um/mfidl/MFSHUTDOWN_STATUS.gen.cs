// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFSHUTDOWN_STATUS.xml' path='doc/member[@name="MFSHUTDOWN_STATUS"]/*'/>
public enum MFSHUTDOWN_STATUS
{
    /// <include file='MFSHUTDOWN_STATUS.xml' path='doc/member[@name="MFSHUTDOWN_STATUS.MFSHUTDOWN_INITIATED"]/*'/>
    MFSHUTDOWN_INITIATED = 0,
    /// <include file='MFSHUTDOWN_STATUS.xml' path='doc/member[@name="MFSHUTDOWN_STATUS.MFSHUTDOWN_COMPLETED"]/*'/>
    MFSHUTDOWN_COMPLETED = (MFSHUTDOWN_INITIATED + 1),
}