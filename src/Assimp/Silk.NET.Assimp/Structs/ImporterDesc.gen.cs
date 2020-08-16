// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiImporterDesc")]
    public unsafe partial struct ImporterDesc
    {
        public ImporterDesc
        (
            byte* mName = default,
            byte* mAuthor = default,
            byte* mMaintainer = default,
            byte* mComments = default,
            uint mFlags = default,
            uint mMinMajor = default,
            uint mMinMinor = default,
            uint mMaxMajor = default,
            uint mMaxMinor = default,
            byte* mFileExtensions = default
        )
        {
            MName = mName;
            MAuthor = mAuthor;
            MMaintainer = mMaintainer;
            MComments = mComments;
            MFlags = mFlags;
            MMinMajor = mMinMajor;
            MMinMinor = mMinMinor;
            MMaxMajor = mMaxMajor;
            MMaxMinor = mMaxMinor;
            MFileExtensions = mFileExtensions;
        }


        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "mName")]
        public byte* MName;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "mAuthor")]
        public byte* MAuthor;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "mMaintainer")]
        public byte* MMaintainer;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "mComments")]
        public byte* MComments;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mFlags")]
        public uint MFlags;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mMinMajor")]
        public uint MMinMajor;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mMinMinor")]
        public uint MMinMinor;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mMaxMajor")]
        public uint MMaxMajor;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mMaxMinor")]
        public uint MMaxMinor;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "mFileExtensions")]
        public byte* MFileExtensions;
    }
}
