// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiImporterDesc")]
    public unsafe partial struct ImporterDesc
    {
        public ImporterDesc
        (
            byte* mName = null,
            byte* mAuthor = null,
            byte* mMaintainer = null,
            byte* mComments = null,
            uint? mFlags = null,
            uint? mMinMajor = null,
            uint? mMinMinor = null,
            uint? mMaxMajor = null,
            uint? mMaxMinor = null,
            byte* mFileExtensions = null
        ) : this()
        {
            if (mName is not null)
            {
                MName = mName;
            }

            if (mAuthor is not null)
            {
                MAuthor = mAuthor;
            }

            if (mMaintainer is not null)
            {
                MMaintainer = mMaintainer;
            }

            if (mComments is not null)
            {
                MComments = mComments;
            }

            if (mFlags is not null)
            {
                MFlags = mFlags.Value;
            }

            if (mMinMajor is not null)
            {
                MMinMajor = mMinMajor.Value;
            }

            if (mMinMinor is not null)
            {
                MMinMinor = mMinMinor.Value;
            }

            if (mMaxMajor is not null)
            {
                MMaxMajor = mMaxMajor.Value;
            }

            if (mMaxMinor is not null)
            {
                MMaxMinor = mMaxMinor.Value;
            }

            if (mFileExtensions is not null)
            {
                MFileExtensions = mFileExtensions;
            }
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
