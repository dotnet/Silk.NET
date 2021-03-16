// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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
