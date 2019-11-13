// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    internal struct FuncPtrInternal
    {
        public static Dictionary<IntPtr, FuncPtrInternal> Storage { get; } = new Dictionary<IntPtr, FuncPtrInternal>();
        public Delegate Delegate { get; set; }
        public GCHandle Handle { get; set; }
    }
}
