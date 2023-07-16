// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPENDSRSTREAMFLAGS.xml' path='doc/member[@name="SPENDSRSTREAMFLAGS"]/*'/>
public enum SPENDSRSTREAMFLAGS
{
    /// <include file='SPENDSRSTREAMFLAGS.xml' path='doc/member[@name="SPENDSRSTREAMFLAGS.SPESF_NONE"]/*'/>
    SPESF_NONE = 0,
    /// <include file='SPENDSRSTREAMFLAGS.xml' path='doc/member[@name="SPENDSRSTREAMFLAGS.SPESF_STREAM_RELEASED"]/*'/>
    SPESF_STREAM_RELEASED = (1 << 0),
    /// <include file='SPENDSRSTREAMFLAGS.xml' path='doc/member[@name="SPENDSRSTREAMFLAGS.SPESF_EMULATED"]/*'/>
    SPESF_EMULATED = (1 << 1),
}