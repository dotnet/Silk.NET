using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.XAudio
{
    public partial class XAudioFX
    {
        public static XAudioFX GetApi()
        {
             return new XAudioFX(CreateDefaultContext("Windows.Media.Audio"));
        }

        public override bool IsExtensionPresent(string extension) => false;
    }
}

