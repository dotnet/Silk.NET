// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DWM_PRESENT_PARAMETERS.xml' path='doc/member[@name="DWM_PRESENT_PARAMETERS"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DWM_PRESENT_PARAMETERS
{
    /// <include file='DWM_PRESENT_PARAMETERS.xml' path='doc/member[@name="DWM_PRESENT_PARAMETERS.cbSize"]/*'/>
    [NativeTypeName("UINT32")]
    public uint cbSize;
    /// <include file='DWM_PRESENT_PARAMETERS.xml' path='doc/member[@name="DWM_PRESENT_PARAMETERS.fQueue"]/*'/>
    public BOOL fQueue;
    /// <include file='DWM_PRESENT_PARAMETERS.xml' path='doc/member[@name="DWM_PRESENT_PARAMETERS.cRefreshStart"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshStart;
    /// <include file='DWM_PRESENT_PARAMETERS.xml' path='doc/member[@name="DWM_PRESENT_PARAMETERS.cBuffer"]/*'/>
    public uint cBuffer;
    /// <include file='DWM_PRESENT_PARAMETERS.xml' path='doc/member[@name="DWM_PRESENT_PARAMETERS.fUseSourceRate"]/*'/>
    public BOOL fUseSourceRate;
    /// <include file='DWM_PRESENT_PARAMETERS.xml' path='doc/member[@name="DWM_PRESENT_PARAMETERS.rateSource"]/*'/>
    public UNSIGNED_RATIO rateSource;
    /// <include file='DWM_PRESENT_PARAMETERS.xml' path='doc/member[@name="DWM_PRESENT_PARAMETERS.cRefreshesPerFrame"]/*'/>
    public uint cRefreshesPerFrame;
    /// <include file='DWM_PRESENT_PARAMETERS.xml' path='doc/member[@name="DWM_PRESENT_PARAMETERS.eSampling"]/*'/>
    public DWM_SOURCE_FRAME_SAMPLING eSampling;
}