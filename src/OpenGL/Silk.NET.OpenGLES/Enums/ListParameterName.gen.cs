// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ListParameterName")]
    public enum ListParameterName : int
    {
        [NativeName("Name", "GL_LIST_PRIORITY_SGIX")]
        ListPrioritySgix = 0x8182,
    }
}
