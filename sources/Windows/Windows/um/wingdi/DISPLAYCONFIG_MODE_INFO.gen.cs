// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='DISPLAYCONFIG_MODE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_MODE_INFO"]/*' />
public partial struct DISPLAYCONFIG_MODE_INFO
{
    /// <include file='DISPLAYCONFIG_MODE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_MODE_INFO.infoType"]/*' />
    public DISPLAYCONFIG_MODE_INFO_TYPE infoType;

    /// <include file='DISPLAYCONFIG_MODE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_MODE_INFO.id"]/*' />
    [NativeTypeName("UINT32")]
    public uint id;

    /// <include file='DISPLAYCONFIG_MODE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_MODE_INFO.adapterId"]/*' />
    public LUID adapterId;

    /// <include file='DISPLAYCONFIG_MODE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_MODE_INFO.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_wingdi_L2936_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.targetMode"]/*' />
    [UnscopedRef]
    public ref DISPLAYCONFIG_TARGET_MODE targetMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.targetMode;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.sourceMode"]/*' />
    [UnscopedRef]
    public ref DISPLAYCONFIG_SOURCE_MODE sourceMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.sourceMode;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.desktopImageInfo"]/*' />
    [SupportedOSPlatform("windows10.0.17763.0")]
    [UnscopedRef]
    public ref DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.desktopImageInfo;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.targetMode"]/*' />
        [FieldOffset(0)]
        public DISPLAYCONFIG_TARGET_MODE targetMode;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.sourceMode"]/*' />
        [FieldOffset(0)]
        public DISPLAYCONFIG_SOURCE_MODE sourceMode;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.desktopImageInfo"]/*' />
        [FieldOffset(0)]
        [SupportedOSPlatform("windows10.0.17763.0")]
        public DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo;
    }
}
