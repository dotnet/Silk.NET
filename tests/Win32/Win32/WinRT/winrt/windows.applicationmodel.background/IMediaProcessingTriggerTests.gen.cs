// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IMediaProcessingTrigger"/> struct.</summary>
public static unsafe partial class IMediaProcessingTriggerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMediaProcessingTrigger"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMediaProcessingTrigger).GUID, Is.EqualTo(IID_IMediaProcessingTrigger));
    }

    /// <summary>Validates that the <see cref = "IMediaProcessingTrigger"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IMediaProcessingTrigger>(),
            Is.EqualTo(sizeof(IMediaProcessingTrigger))
        );
    }

    /// <summary>Validates that the <see cref = "IMediaProcessingTrigger"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMediaProcessingTrigger).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMediaProcessingTrigger"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMediaProcessingTrigger), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMediaProcessingTrigger), Is.EqualTo(4));
        }
    }
}
