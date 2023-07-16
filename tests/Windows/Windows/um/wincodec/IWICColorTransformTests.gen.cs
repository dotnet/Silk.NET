// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IWICColorTransform"/> struct.</summary>
public static unsafe partial class IWICColorTransformTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IWICColorTransform"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IWICColorTransform).GUID, Is.EqualTo(IID_IWICColorTransform));
    }

    /// <summary>Validates that the <see cref = "IWICColorTransform"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IWICColorTransform>(), Is.EqualTo(sizeof(IWICColorTransform)));
    }

    /// <summary>Validates that the <see cref = "IWICColorTransform"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IWICColorTransform).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IWICColorTransform"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWICColorTransform), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWICColorTransform), Is.EqualTo(4));
        }
    }
}