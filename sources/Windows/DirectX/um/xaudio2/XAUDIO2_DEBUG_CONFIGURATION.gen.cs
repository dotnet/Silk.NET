// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='XAUDIO2_DEBUG_CONFIGURATION.xml' path='doc/member[@name="XAUDIO2_DEBUG_CONFIGURATION"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAUDIO2_DEBUG_CONFIGURATION
{
    /// <include file='XAUDIO2_DEBUG_CONFIGURATION.xml' path='doc/member[@name="XAUDIO2_DEBUG_CONFIGURATION.TraceMask"]/*'/>
    [NativeTypeName("UINT32")]
    public uint TraceMask;
    /// <include file='XAUDIO2_DEBUG_CONFIGURATION.xml' path='doc/member[@name="XAUDIO2_DEBUG_CONFIGURATION.BreakMask"]/*'/>
    [NativeTypeName("UINT32")]
    public uint BreakMask;
    /// <include file='XAUDIO2_DEBUG_CONFIGURATION.xml' path='doc/member[@name="XAUDIO2_DEBUG_CONFIGURATION.LogThreadID"]/*'/>
    public BOOL LogThreadID;
    /// <include file='XAUDIO2_DEBUG_CONFIGURATION.xml' path='doc/member[@name="XAUDIO2_DEBUG_CONFIGURATION.LogFileline"]/*'/>
    public BOOL LogFileline;
    /// <include file='XAUDIO2_DEBUG_CONFIGURATION.xml' path='doc/member[@name="XAUDIO2_DEBUG_CONFIGURATION.LogFunctionName"]/*'/>
    public BOOL LogFunctionName;
    /// <include file='XAUDIO2_DEBUG_CONFIGURATION.xml' path='doc/member[@name="XAUDIO2_DEBUG_CONFIGURATION.LogTiming"]/*'/>
    public BOOL LogTiming;
}