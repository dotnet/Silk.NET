// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SECUREURLHOSTVALIDATE_FLAGS.xml' path='doc/member[@name="SECUREURLHOSTVALIDATE_FLAGS"]/*'/>
public enum SECUREURLHOSTVALIDATE_FLAGS
{
    /// <include file='SECUREURLHOSTVALIDATE_FLAGS.xml' path='doc/member[@name="SECUREURLHOSTVALIDATE_FLAGS.SUHV_PROMPTBEFORENO"]/*'/>
    SUHV_PROMPTBEFORENO = 0x1,
    /// <include file='SECUREURLHOSTVALIDATE_FLAGS.xml' path='doc/member[@name="SECUREURLHOSTVALIDATE_FLAGS.SUHV_SILENTYES"]/*'/>
    SUHV_SILENTYES = 0x2,
    /// <include file='SECUREURLHOSTVALIDATE_FLAGS.xml' path='doc/member[@name="SECUREURLHOSTVALIDATE_FLAGS.SUHV_UNSECURESOURCE"]/*'/>
    SUHV_UNSECURESOURCE = 0x4,
    /// <include file='SECUREURLHOSTVALIDATE_FLAGS.xml' path='doc/member[@name="SECUREURLHOSTVALIDATE_FLAGS.SECUREURLHOSTVALIDATE_FLAGS_Max"]/*'/>
    SECUREURLHOSTVALIDATE_FLAGS_Max = 2147483647,
}