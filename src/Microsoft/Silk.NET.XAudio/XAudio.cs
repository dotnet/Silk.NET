using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.XAudio
{
    public partial class XAudio
    {
        public static XAudio GetApi()
        {
             return new(CreateDefaultContext("XAudio2_9"));
        }

        public override bool IsExtensionPresent(string extension) => false;
    }
}

