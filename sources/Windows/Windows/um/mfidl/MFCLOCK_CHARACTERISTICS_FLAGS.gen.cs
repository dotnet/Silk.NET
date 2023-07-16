// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFCLOCK_CHARACTERISTICS_FLAGS.xml' path='doc/member[@name="MFCLOCK_CHARACTERISTICS_FLAGS"]/*'/>
public enum MFCLOCK_CHARACTERISTICS_FLAGS
{
    /// <include file='MFCLOCK_CHARACTERISTICS_FLAGS.xml' path='doc/member[@name="MFCLOCK_CHARACTERISTICS_FLAGS.MFCLOCK_CHARACTERISTICS_FLAG_FREQUENCY_10MHZ"]/*'/>
    MFCLOCK_CHARACTERISTICS_FLAG_FREQUENCY_10MHZ = 0x2,
    /// <include file='MFCLOCK_CHARACTERISTICS_FLAGS.xml' path='doc/member[@name="MFCLOCK_CHARACTERISTICS_FLAGS.MFCLOCK_CHARACTERISTICS_FLAG_ALWAYS_RUNNING"]/*'/>
    MFCLOCK_CHARACTERISTICS_FLAG_ALWAYS_RUNNING = 0x4,
    /// <include file='MFCLOCK_CHARACTERISTICS_FLAGS.xml' path='doc/member[@name="MFCLOCK_CHARACTERISTICS_FLAGS.MFCLOCK_CHARACTERISTICS_FLAG_IS_SYSTEM_CLOCK"]/*'/>
    MFCLOCK_CHARACTERISTICS_FLAG_IS_SYSTEM_CLOCK = 0x8,
}