// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DirectStorage
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_dstorage_L556_C5")]
    public unsafe partial struct ErrorFirstFailureUnion
    {
        public ErrorFirstFailureUnion
        (
            ErrorParametersRequest? request = null,
            ErrorParametersStatus? status = null,
            ErrorParametersSignal? signal = null,
            ErrorParametersEvent? @event = null
        ) : this()
        {
            if (request is not null)
            {
                Request = request.Value;
            }

            if (status is not null)
            {
                Status = status.Value;
            }

            if (signal is not null)
            {
                Signal = signal.Value;
            }

            if (@event is not null)
            {
                Event = @event.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "DSTORAGE_ERROR_PARAMETERS_REQUEST")]
        [NativeName("Type.Name", "DSTORAGE_ERROR_PARAMETERS_REQUEST")]
        [NativeName("Name", "Request")]
        public ErrorParametersRequest Request;

        [FieldOffset(0)]
        [NativeName("Type", "DSTORAGE_ERROR_PARAMETERS_STATUS")]
        [NativeName("Type.Name", "DSTORAGE_ERROR_PARAMETERS_STATUS")]
        [NativeName("Name", "Status")]
        public ErrorParametersStatus Status;

        [FieldOffset(0)]
        [NativeName("Type", "DSTORAGE_ERROR_PARAMETERS_SIGNAL")]
        [NativeName("Type.Name", "DSTORAGE_ERROR_PARAMETERS_SIGNAL")]
        [NativeName("Name", "Signal")]
        public ErrorParametersSignal Signal;

        [FieldOffset(0)]
        [NativeName("Type", "DSTORAGE_ERROR_PARAMETERS_EVENT")]
        [NativeName("Type.Name", "DSTORAGE_ERROR_PARAMETERS_EVENT")]
        [NativeName("Name", "Event")]
        public ErrorParametersEvent Event;
    }
}
