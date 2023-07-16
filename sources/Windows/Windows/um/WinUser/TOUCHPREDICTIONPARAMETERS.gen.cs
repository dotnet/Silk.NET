// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TOUCHPREDICTIONPARAMETERS.xml' path='doc/member[@name="TOUCHPREDICTIONPARAMETERS"]/*'/>
public partial struct TOUCHPREDICTIONPARAMETERS
{
    /// <include file='TOUCHPREDICTIONPARAMETERS.xml' path='doc/member[@name="TOUCHPREDICTIONPARAMETERS.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='TOUCHPREDICTIONPARAMETERS.xml' path='doc/member[@name="TOUCHPREDICTIONPARAMETERS.dwLatency"]/*'/>
    public uint dwLatency;
    /// <include file='TOUCHPREDICTIONPARAMETERS.xml' path='doc/member[@name="TOUCHPREDICTIONPARAMETERS.dwSampleTime"]/*'/>
    public uint dwSampleTime;
    /// <include file='TOUCHPREDICTIONPARAMETERS.xml' path='doc/member[@name="TOUCHPREDICTIONPARAMETERS.bUseHWTimeStamp"]/*'/>
    public uint bUseHWTimeStamp;
}