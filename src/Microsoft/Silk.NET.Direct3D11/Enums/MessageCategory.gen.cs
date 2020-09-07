// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_MESSAGE_CATEGORY")]
    public enum MessageCategory
    {
        [NativeName("Name", "D3D11_MESSAGE_CATEGORY_APPLICATION_DEFINED")]
        MessageCategoryApplicationDefined = 0x0,
        [NativeName("Name", "D3D11_MESSAGE_CATEGORY_MISCELLANEOUS")]
        MessageCategoryMiscellaneous = 0x1,
        [NativeName("Name", "D3D11_MESSAGE_CATEGORY_INITIALIZATION")]
        MessageCategoryInitialization = 0x2,
        [NativeName("Name", "D3D11_MESSAGE_CATEGORY_CLEANUP")]
        MessageCategoryCleanup = 0x3,
        [NativeName("Name", "D3D11_MESSAGE_CATEGORY_COMPILATION")]
        MessageCategoryCompilation = 0x4,
        [NativeName("Name", "D3D11_MESSAGE_CATEGORY_STATE_CREATION")]
        MessageCategoryStateCreation = 0x5,
        [NativeName("Name", "D3D11_MESSAGE_CATEGORY_STATE_SETTING")]
        MessageCategoryStateSetting = 0x6,
        [NativeName("Name", "D3D11_MESSAGE_CATEGORY_STATE_GETTING")]
        MessageCategoryStateGetting = 0x7,
        [NativeName("Name", "D3D11_MESSAGE_CATEGORY_RESOURCE_MANIPULATION")]
        MessageCategoryResourceManipulation = 0x8,
        [NativeName("Name", "D3D11_MESSAGE_CATEGORY_EXECUTION")]
        MessageCategoryExecution = 0x9,
        [NativeName("Name", "D3D11_MESSAGE_CATEGORY_SHADER")]
        MessageCategoryShader = 0xA,
    }
}
