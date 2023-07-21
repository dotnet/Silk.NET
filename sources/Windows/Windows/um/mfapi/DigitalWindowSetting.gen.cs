// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DigitalWindowSetting.xml' path='doc/member[@name="DigitalWindowSetting"]/*' />
public partial struct DigitalWindowSetting
{
    /// <include file='DigitalWindowSetting.xml' path='doc/member[@name="DigitalWindowSetting.OriginX"]/*' />
    public double OriginX;

    /// <include file='DigitalWindowSetting.xml' path='doc/member[@name="DigitalWindowSetting.OriginY"]/*' />
    public double OriginY;

    /// <include file='DigitalWindowSetting.xml' path='doc/member[@name="DigitalWindowSetting.WindowSize"]/*' />
    public double WindowSize;
}
