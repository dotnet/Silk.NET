// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMediaPropertyBag"/> struct.</summary>
public static unsafe partial class IMediaPropertyBagTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMediaPropertyBag"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMediaPropertyBag).GUID, Is.EqualTo(IID_IMediaPropertyBag));
    }

    /// <summary>Validates that the <see cref = "IMediaPropertyBag"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMediaPropertyBag>(), Is.EqualTo(sizeof(IMediaPropertyBag)));
    }

    /// <summary>Validates that the <see cref = "IMediaPropertyBag"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMediaPropertyBag).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMediaPropertyBag"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMediaPropertyBag), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMediaPropertyBag), Is.EqualTo(4));
        }
    }
}