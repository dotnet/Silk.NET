// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PI_FLAGS.xml' path='doc/member[@name="PI_FLAGS"]/*' />
public enum PI_FLAGS
{
    /// <include file='PI_FLAGS.xml' path='doc/member[@name="PI_FLAGS.PI_PARSE_URL"]/*' />
    PI_PARSE_URL = 0x1,

    /// <include file='PI_FLAGS.xml' path='doc/member[@name="PI_FLAGS.PI_FILTER_MODE"]/*' />
    PI_FILTER_MODE = 0x2,

    /// <include file='PI_FLAGS.xml' path='doc/member[@name="PI_FLAGS.PI_FORCE_ASYNC"]/*' />
    PI_FORCE_ASYNC = 0x4,

    /// <include file='PI_FLAGS.xml' path='doc/member[@name="PI_FLAGS.PI_USE_WORKERTHREAD"]/*' />
    PI_USE_WORKERTHREAD = 0x8,

    /// <include file='PI_FLAGS.xml' path='doc/member[@name="PI_FLAGS.PI_MIMEVERIFICATION"]/*' />
    PI_MIMEVERIFICATION = 0x10,

    /// <include file='PI_FLAGS.xml' path='doc/member[@name="PI_FLAGS.PI_CLSIDLOOKUP"]/*' />
    PI_CLSIDLOOKUP = 0x20,

    /// <include file='PI_FLAGS.xml' path='doc/member[@name="PI_FLAGS.PI_DATAPROGRESS"]/*' />
    PI_DATAPROGRESS = 0x40,

    /// <include file='PI_FLAGS.xml' path='doc/member[@name="PI_FLAGS.PI_SYNCHRONOUS"]/*' />
    PI_SYNCHRONOUS = 0x80,

    /// <include file='PI_FLAGS.xml' path='doc/member[@name="PI_FLAGS.PI_APARTMENTTHREADED"]/*' />
    PI_APARTMENTTHREADED = 0x100,

    /// <include file='PI_FLAGS.xml' path='doc/member[@name="PI_FLAGS.PI_CLASSINSTALL"]/*' />
    PI_CLASSINSTALL = 0x200,

    /// <include file='PI_FLAGS.xml' path='doc/member[@name="PI_FLAGS.PI_PASSONBINDCTX"]/*' />
    PI_PASSONBINDCTX = 0x2000,

    /// <include file='PI_FLAGS.xml' path='doc/member[@name="PI_FLAGS.PI_NOMIMEHANDLER"]/*' />
    PI_NOMIMEHANDLER = 0x8000,

    /// <include file='PI_FLAGS.xml' path='doc/member[@name="PI_FLAGS.PI_LOADAPPDIRECT"]/*' />
    PI_LOADAPPDIRECT = 0x4000,

    /// <include file='PI_FLAGS.xml' path='doc/member[@name="PI_FLAGS.PD_FORCE_SWITCH"]/*' />
    PD_FORCE_SWITCH = 0x10000,

    /// <include file='PI_FLAGS.xml' path='doc/member[@name="PI_FLAGS.PI_PREFERDEFAULTHANDLER"]/*' />
    PI_PREFERDEFAULTHANDLER = 0x20000,
}
