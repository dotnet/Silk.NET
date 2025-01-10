// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.editing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IMediaComposition"/> struct.</summary>
public static unsafe partial class IMediaCompositionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMediaComposition"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMediaComposition).GUID, Is.EqualTo(IID_IMediaComposition));
    }

    /// <summary>Validates that the <see cref = "IMediaComposition"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMediaComposition>(), Is.EqualTo(sizeof(IMediaComposition)));
    }

    /// <summary>Validates that the <see cref = "IMediaComposition"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMediaComposition).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMediaComposition"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMediaComposition), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMediaComposition), Is.EqualTo(4));
        }
    }
}
