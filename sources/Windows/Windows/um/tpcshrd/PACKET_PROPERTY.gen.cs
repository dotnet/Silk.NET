// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='PACKET_PROPERTY.xml' path='doc/member[@name="PACKET_PROPERTY"]/*' />
public partial struct PACKET_PROPERTY
{
    /// <include file='PACKET_PROPERTY.xml' path='doc/member[@name="PACKET_PROPERTY.guid"]/*' />
    public Guid guid;

    /// <include file='PACKET_PROPERTY.xml' path='doc/member[@name="PACKET_PROPERTY.PropertyMetrics"]/*' />
    public PROPERTY_METRICS PropertyMetrics;
}
