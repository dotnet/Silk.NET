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

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "ETW_OPEN_TRACE_OPTIONS")]
    public unsafe partial struct EtwOpenTraceOptions
    {
        public EtwOpenTraceOptions
        (
            EtwProcessTraceModes? processTraceModes = null,
            PfnPeventRecordCallback? eventCallback = null,
            void* eventCallbackContext = null,
            PfnPetwBufferCallback? bufferCallback = null,
            void* bufferCallbackContext = null
        ) : this()
        {
            if (processTraceModes is not null)
            {
                ProcessTraceModes = processTraceModes.Value;
            }

            if (eventCallback is not null)
            {
                EventCallback = eventCallback.Value;
            }

            if (eventCallbackContext is not null)
            {
                EventCallbackContext = eventCallbackContext;
            }

            if (bufferCallback is not null)
            {
                BufferCallback = bufferCallback.Value;
            }

            if (bufferCallbackContext is not null)
            {
                BufferCallbackContext = bufferCallbackContext;
            }
        }


        [NativeName("Type", "ETW_PROCESS_TRACE_MODES")]
        [NativeName("Type.Name", "ETW_PROCESS_TRACE_MODES")]
        [NativeName("Name", "ProcessTraceModes")]
        public EtwProcessTraceModes ProcessTraceModes;

        [NativeName("Type", "PEVENT_RECORD_CALLBACK")]
        [NativeName("Type.Name", "PEVENT_RECORD_CALLBACK")]
        [NativeName("Name", "EventCallback")]
        public PfnPeventRecordCallback EventCallback;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "EventCallbackContext")]
        public void* EventCallbackContext;

        [NativeName("Type", "PETW_BUFFER_CALLBACK")]
        [NativeName("Type.Name", "PETW_BUFFER_CALLBACK")]
        [NativeName("Name", "BufferCallback")]
        public PfnPetwBufferCallback BufferCallback;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "BufferCallbackContext")]
        public void* BufferCallbackContext;
    }
}
