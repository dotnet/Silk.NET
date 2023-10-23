// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagDCOM_CALL_STATE")]
    public enum DCOMCallState : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "DCOM_NONE")]
        DcomNone = 0x0,
        [Obsolete("Deprecated in favour of \"CallComplete\"")]
        [NativeName("Name", "DCOM_CALL_COMPLETE")]
        DcomCallComplete = 0x1,
        [Obsolete("Deprecated in favour of \"CallCanceled\"")]
        [NativeName("Name", "DCOM_CALL_CANCELED")]
        DcomCallCanceled = 0x2,
        [NativeName("Name", "DCOM_NONE")]
        None = 0x0,
        [NativeName("Name", "DCOM_CALL_COMPLETE")]
        CallComplete = 0x1,
        [NativeName("Name", "DCOM_CALL_CANCELED")]
        CallCanceled = 0x2,
    }
}
