// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPEVENTSOURCEINFO.xml' path='doc/member[@name="SPEVENTSOURCEINFO"]/*'/>
public partial struct SPEVENTSOURCEINFO
{
    /// <include file='SPEVENTSOURCEINFO.xml' path='doc/member[@name="SPEVENTSOURCEINFO.ullEventInterest"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ullEventInterest;
    /// <include file='SPEVENTSOURCEINFO.xml' path='doc/member[@name="SPEVENTSOURCEINFO.ullQueuedInterest"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ullQueuedInterest;
    /// <include file='SPEVENTSOURCEINFO.xml' path='doc/member[@name="SPEVENTSOURCEINFO.ulCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulCount;
}