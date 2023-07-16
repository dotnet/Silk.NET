// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IThumbnailHandlerFactory"/> struct.</summary>
public static unsafe partial class IThumbnailHandlerFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IThumbnailHandlerFactory"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IThumbnailHandlerFactory).GUID, Is.EqualTo(IID_IThumbnailHandlerFactory));
    }

    /// <summary>Validates that the <see cref = "IThumbnailHandlerFactory"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IThumbnailHandlerFactory>(), Is.EqualTo(sizeof(IThumbnailHandlerFactory)));
    }

    /// <summary>Validates that the <see cref = "IThumbnailHandlerFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IThumbnailHandlerFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IThumbnailHandlerFactory"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IThumbnailHandlerFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IThumbnailHandlerFactory), Is.EqualTo(4));
        }
    }
}