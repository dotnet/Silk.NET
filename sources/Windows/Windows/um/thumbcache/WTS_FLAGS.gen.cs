// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS"]/*'/>
public enum WTS_FLAGS
{
    /// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS.WTS_NONE"]/*'/>
    WTS_NONE = 0,
    /// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS.WTS_EXTRACT"]/*'/>
    WTS_EXTRACT = 0,
    /// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS.WTS_INCACHEONLY"]/*'/>
    WTS_INCACHEONLY = 0x1,
    /// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS.WTS_FASTEXTRACT"]/*'/>
    WTS_FASTEXTRACT = 0x2,
    /// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS.WTS_FORCEEXTRACTION"]/*'/>
    WTS_FORCEEXTRACTION = 0x4,
    /// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS.WTS_SLOWRECLAIM"]/*'/>
    WTS_SLOWRECLAIM = 0x8,
    /// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS.WTS_EXTRACTDONOTCACHE"]/*'/>
    WTS_EXTRACTDONOTCACHE = 0x20,
    /// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS.WTS_SCALETOREQUESTEDSIZE"]/*'/>
    WTS_SCALETOREQUESTEDSIZE = 0x40,
    /// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS.WTS_SKIPFASTEXTRACT"]/*'/>
    WTS_SKIPFASTEXTRACT = 0x80,
    /// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS.WTS_EXTRACTINPROC"]/*'/>
    WTS_EXTRACTINPROC = 0x100,
    /// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS.WTS_CROPTOSQUARE"]/*'/>
    WTS_CROPTOSQUARE = 0x200,
    /// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS.WTS_INSTANCESURROGATE"]/*'/>
    WTS_INSTANCESURROGATE = 0x400,
    /// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS.WTS_REQUIRESURROGATE"]/*'/>
    WTS_REQUIRESURROGATE = 0x800,
    /// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS.WTS_APPSTYLE"]/*'/>
    WTS_APPSTYLE = 0x2000,
    /// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS.WTS_WIDETHUMBNAILS"]/*'/>
    WTS_WIDETHUMBNAILS = 0x4000,
    /// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS.WTS_IDEALCACHESIZEONLY"]/*'/>
    WTS_IDEALCACHESIZEONLY = 0x8000,
    /// <include file='WTS_FLAGS.xml' path='doc/member[@name="WTS_FLAGS.WTS_SCALEUP"]/*'/>
    WTS_SCALEUP = 0x10000,
}