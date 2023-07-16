// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFRATE_DIRECTION.xml' path='doc/member[@name="MFRATE_DIRECTION"]/*'/>
public enum MFRATE_DIRECTION
{
    /// <include file='MFRATE_DIRECTION.xml' path='doc/member[@name="MFRATE_DIRECTION.MFRATE_FORWARD"]/*'/>
    MFRATE_FORWARD = 0,
    /// <include file='MFRATE_DIRECTION.xml' path='doc/member[@name="MFRATE_DIRECTION.MFRATE_REVERSE"]/*'/>
    MFRATE_REVERSE = (MFRATE_FORWARD + 1),
}