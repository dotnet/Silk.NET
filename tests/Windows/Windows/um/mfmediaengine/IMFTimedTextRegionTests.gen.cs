// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFTimedTextRegion"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class IMFTimedTextRegionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFTimedTextRegion"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFTimedTextRegion).GUID, Is.EqualTo(IID_IMFTimedTextRegion));
    }

    /// <summary>Validates that the <see cref = "IMFTimedTextRegion"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFTimedTextRegion>(), Is.EqualTo(sizeof(IMFTimedTextRegion)));
    }

    /// <summary>Validates that the <see cref = "IMFTimedTextRegion"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFTimedTextRegion).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFTimedTextRegion"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFTimedTextRegion), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFTimedTextRegion), Is.EqualTo(4));
        }
    }
}