// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFVideoDRMFlags.xml' path='doc/member[@name="MFVideoDRMFlags"]/*'/>
public enum MFVideoDRMFlags
{
    /// <include file='MFVideoDRMFlags.xml' path='doc/member[@name="MFVideoDRMFlags.MFVideoDRMFlag_None"]/*'/>
    MFVideoDRMFlag_None = 0,
    /// <include file='MFVideoDRMFlags.xml' path='doc/member[@name="MFVideoDRMFlags.MFVideoDRMFlag_AnalogProtected"]/*'/>
    MFVideoDRMFlag_AnalogProtected = 1,
    /// <include file='MFVideoDRMFlags.xml' path='doc/member[@name="MFVideoDRMFlags.MFVideoDRMFlag_DigitallyProtected"]/*'/>
    MFVideoDRMFlag_DigitallyProtected = 2,
}