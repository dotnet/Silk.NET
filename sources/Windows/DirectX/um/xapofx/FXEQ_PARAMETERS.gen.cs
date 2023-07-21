// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='FXEQ_PARAMETERS.xml' path='doc/member[@name="FXEQ_PARAMETERS"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct FXEQ_PARAMETERS
{
    /// <include file='FXEQ_PARAMETERS.xml' path='doc/member[@name="FXEQ_PARAMETERS.FrequencyCenter0"]/*' />
    public float FrequencyCenter0;

    /// <include file='FXEQ_PARAMETERS.xml' path='doc/member[@name="FXEQ_PARAMETERS.Gain0"]/*' />
    public float Gain0;

    /// <include file='FXEQ_PARAMETERS.xml' path='doc/member[@name="FXEQ_PARAMETERS.Bandwidth0"]/*' />
    public float Bandwidth0;

    /// <include file='FXEQ_PARAMETERS.xml' path='doc/member[@name="FXEQ_PARAMETERS.FrequencyCenter1"]/*' />
    public float FrequencyCenter1;

    /// <include file='FXEQ_PARAMETERS.xml' path='doc/member[@name="FXEQ_PARAMETERS.Gain1"]/*' />
    public float Gain1;

    /// <include file='FXEQ_PARAMETERS.xml' path='doc/member[@name="FXEQ_PARAMETERS.Bandwidth1"]/*' />
    public float Bandwidth1;

    /// <include file='FXEQ_PARAMETERS.xml' path='doc/member[@name="FXEQ_PARAMETERS.FrequencyCenter2"]/*' />
    public float FrequencyCenter2;

    /// <include file='FXEQ_PARAMETERS.xml' path='doc/member[@name="FXEQ_PARAMETERS.Gain2"]/*' />
    public float Gain2;

    /// <include file='FXEQ_PARAMETERS.xml' path='doc/member[@name="FXEQ_PARAMETERS.Bandwidth2"]/*' />
    public float Bandwidth2;

    /// <include file='FXEQ_PARAMETERS.xml' path='doc/member[@name="FXEQ_PARAMETERS.FrequencyCenter3"]/*' />
    public float FrequencyCenter3;

    /// <include file='FXEQ_PARAMETERS.xml' path='doc/member[@name="FXEQ_PARAMETERS.Gain3"]/*' />
    public float Gain3;

    /// <include file='FXEQ_PARAMETERS.xml' path='doc/member[@name="FXEQ_PARAMETERS.Bandwidth3"]/*' />
    public float Bandwidth3;
}
