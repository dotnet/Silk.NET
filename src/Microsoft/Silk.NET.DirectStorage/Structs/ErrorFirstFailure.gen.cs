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
    [NativeName("Name", "DSTORAGE_ERROR_FIRST_FAILURE")]
    public unsafe partial struct ErrorFirstFailure
    {
        public ErrorFirstFailure
        (
            int? hResult = null,
            CommandType? commandType = null,
            ErrorFirstFailureUnion? anonymous = null,
            ErrorParametersRequest? request = null,
            ErrorParametersStatus? status = null,
            ErrorParametersSignal? signal = null,
            ErrorParametersEvent? @event = null
        ) : this()
        {
            if (hResult is not null)
            {
                HResult = hResult.Value;
            }

            if (commandType is not null)
            {
                CommandType = commandType.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

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


        [NativeName("Type", "HRESULT")]
        [NativeName("Type.Name", "HRESULT")]
        [NativeName("Name", "HResult")]
        public int HResult;

        [NativeName("Type", "DSTORAGE_COMMAND_TYPE")]
        [NativeName("Type.Name", "DSTORAGE_COMMAND_TYPE")]
        [NativeName("Name", "CommandType")]
        public CommandType CommandType;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_dstorage_L556_C5")]
        [NativeName("Name", "anonymous1")]
        public ErrorFirstFailureUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ErrorParametersRequest Request
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Request;
        }
#else
        public ErrorParametersRequest Request
        {
            get => Anonymous.Request;
            set => Anonymous.Request = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ErrorParametersStatus Status
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Status;
        }
#else
        public ErrorParametersStatus Status
        {
            get => Anonymous.Status;
            set => Anonymous.Status = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ErrorParametersSignal Signal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Signal;
        }
#else
        public ErrorParametersSignal Signal
        {
            get => Anonymous.Signal;
            set => Anonymous.Signal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ErrorParametersEvent Event
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Event;
        }
#else
        public ErrorParametersEvent Event
        {
            get => Anonymous.Event;
            set => Anonymous.Event = value;
        }
#endif

    }
}
