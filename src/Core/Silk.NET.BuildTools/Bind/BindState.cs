// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Concurrent;
using System.Collections.Generic;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Bind
{
    public class BindState
    {
        public BindState(BindTask task) => Task = task;
        public BindTask Task;
        public ConcurrentDictionary<string, Type> WrappedFunctionPointers = new();
    }
}
