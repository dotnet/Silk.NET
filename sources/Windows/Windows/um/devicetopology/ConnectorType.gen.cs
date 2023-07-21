// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ConnectorType.xml' path='doc/member[@name="ConnectorType"]/*' />
public enum ConnectorType
{
    /// <include file='ConnectorType.xml' path='doc/member[@name="ConnectorType.Unknown_Connector"]/*' />
    Unknown_Connector = 0,

    /// <include file='ConnectorType.xml' path='doc/member[@name="ConnectorType.Physical_Internal"]/*' />
    Physical_Internal = (Unknown_Connector + 1),

    /// <include file='ConnectorType.xml' path='doc/member[@name="ConnectorType.Physical_External"]/*' />
    Physical_External = (Physical_Internal + 1),

    /// <include file='ConnectorType.xml' path='doc/member[@name="ConnectorType.Software_IO"]/*' />
    Software_IO = (Physical_External + 1),

    /// <include file='ConnectorType.xml' path='doc/member[@name="ConnectorType.Software_Fixed"]/*' />
    Software_Fixed = (Software_IO + 1),

    /// <include file='ConnectorType.xml' path='doc/member[@name="ConnectorType.Network"]/*' />
    Network = (Software_Fixed + 1),
}
