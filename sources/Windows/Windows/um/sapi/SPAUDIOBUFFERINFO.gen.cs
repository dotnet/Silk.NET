// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPAUDIOBUFFERINFO.xml' path='doc/member[@name="SPAUDIOBUFFERINFO"]/*'/>
public partial struct SPAUDIOBUFFERINFO
{
    /// <include file='SPAUDIOBUFFERINFO.xml' path='doc/member[@name="SPAUDIOBUFFERINFO.ulMsMinNotification"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulMsMinNotification;
    /// <include file='SPAUDIOBUFFERINFO.xml' path='doc/member[@name="SPAUDIOBUFFERINFO.ulMsBufferSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulMsBufferSize;
    /// <include file='SPAUDIOBUFFERINFO.xml' path='doc/member[@name="SPAUDIOBUFFERINFO.ulMsEventBias"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulMsEventBias;
}