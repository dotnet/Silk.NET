// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SecureLockIconConstants.xml' path='doc/member[@name="SecureLockIconConstants"]/*'/>
public enum SecureLockIconConstants
{
    /// <include file='SecureLockIconConstants.xml' path='doc/member[@name="SecureLockIconConstants.secureLockIconUnsecure"]/*'/>
    secureLockIconUnsecure = 0,
    /// <include file='SecureLockIconConstants.xml' path='doc/member[@name="SecureLockIconConstants.secureLockIconMixed"]/*'/>
    secureLockIconMixed = 0x1,
    /// <include file='SecureLockIconConstants.xml' path='doc/member[@name="SecureLockIconConstants.secureLockIconSecureUnknownBits"]/*'/>
    secureLockIconSecureUnknownBits = 0x2,
    /// <include file='SecureLockIconConstants.xml' path='doc/member[@name="SecureLockIconConstants.secureLockIconSecure40Bit"]/*'/>
    secureLockIconSecure40Bit = 0x3,
    /// <include file='SecureLockIconConstants.xml' path='doc/member[@name="SecureLockIconConstants.secureLockIconSecure56Bit"]/*'/>
    secureLockIconSecure56Bit = 0x4,
    /// <include file='SecureLockIconConstants.xml' path='doc/member[@name="SecureLockIconConstants.secureLockIconSecureFortezza"]/*'/>
    secureLockIconSecureFortezza = 0x5,
    /// <include file='SecureLockIconConstants.xml' path='doc/member[@name="SecureLockIconConstants.secureLockIconSecure128Bit"]/*'/>
    secureLockIconSecure128Bit = 0x6,
}