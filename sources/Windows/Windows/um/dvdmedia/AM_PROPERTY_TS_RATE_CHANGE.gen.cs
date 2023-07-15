// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AM_PROPERTY_TS_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_TS_RATE_CHANGE"]/*'/>
public enum AM_PROPERTY_TS_RATE_CHANGE
{
    /// <include file='AM_PROPERTY_TS_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_TS_RATE_CHANGE.AM_RATE_SimpleRateChange"]/*'/>
    AM_RATE_SimpleRateChange = 1,
    /// <include file='AM_PROPERTY_TS_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_TS_RATE_CHANGE.AM_RATE_ExactRateChange"]/*'/>
    AM_RATE_ExactRateChange = 2,
    /// <include file='AM_PROPERTY_TS_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_TS_RATE_CHANGE.AM_RATE_MaxFullDataRate"]/*'/>
    AM_RATE_MaxFullDataRate = 3,
    /// <include file='AM_PROPERTY_TS_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_TS_RATE_CHANGE.AM_RATE_Step"]/*'/>
    AM_RATE_Step = 4,
    /// <include file='AM_PROPERTY_TS_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_TS_RATE_CHANGE.AM_RATE_UseRateVersion"]/*'/>
    AM_RATE_UseRateVersion = 5,
    /// <include file='AM_PROPERTY_TS_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_TS_RATE_CHANGE.AM_RATE_QueryFullFrameRate"]/*'/>
    AM_RATE_QueryFullFrameRate = 6,
    /// <include file='AM_PROPERTY_TS_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_TS_RATE_CHANGE.AM_RATE_QueryLastRateSegPTS"]/*'/>
    AM_RATE_QueryLastRateSegPTS = 7,
    /// <include file='AM_PROPERTY_TS_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_TS_RATE_CHANGE.AM_RATE_CorrectTS"]/*'/>
    AM_RATE_CorrectTS = 8,
    /// <include file='AM_PROPERTY_TS_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_TS_RATE_CHANGE.AM_RATE_ReverseMaxFullDataRate"]/*'/>
    AM_RATE_ReverseMaxFullDataRate = 9,
    /// <include file='AM_PROPERTY_TS_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_TS_RATE_CHANGE.AM_RATE_ResetOnTimeDisc"]/*'/>
    AM_RATE_ResetOnTimeDisc = 10,
    /// <include file='AM_PROPERTY_TS_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_TS_RATE_CHANGE.AM_RATE_QueryMapping"]/*'/>
    AM_RATE_QueryMapping = 11,
}