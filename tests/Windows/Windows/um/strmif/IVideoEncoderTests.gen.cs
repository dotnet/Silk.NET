// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IVideoEncoder"/> struct.</summary>
public static unsafe partial class IVideoEncoderTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IVideoEncoder"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IVideoEncoder).GUID, Is.EqualTo(IID_IVideoEncoder));
    }

    /// <summary>Validates that the <see cref = "IVideoEncoder"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IVideoEncoder>(), Is.EqualTo(sizeof(IVideoEncoder)));
    }

    /// <summary>Validates that the <see cref = "IVideoEncoder"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IVideoEncoder).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IVideoEncoder"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IVideoEncoder), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IVideoEncoder), Is.EqualTo(4));
        }
    }
}