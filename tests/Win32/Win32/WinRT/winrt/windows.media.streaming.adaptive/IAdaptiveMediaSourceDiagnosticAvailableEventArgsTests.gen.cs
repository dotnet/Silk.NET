// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IAdaptiveMediaSourceDiagnosticAvailableEventArgs"/> struct.</summary>
public static unsafe partial class IAdaptiveMediaSourceDiagnosticAvailableEventArgsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAdaptiveMediaSourceDiagnosticAvailableEventArgs"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IAdaptiveMediaSourceDiagnosticAvailableEventArgs).GUID,
            Is.EqualTo(IID_IAdaptiveMediaSourceDiagnosticAvailableEventArgs)
        );
    }

    /// <summary>Validates that the <see cref = "IAdaptiveMediaSourceDiagnosticAvailableEventArgs"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IAdaptiveMediaSourceDiagnosticAvailableEventArgs>(),
            Is.EqualTo(sizeof(IAdaptiveMediaSourceDiagnosticAvailableEventArgs))
        );
    }

    /// <summary>Validates that the <see cref = "IAdaptiveMediaSourceDiagnosticAvailableEventArgs"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(IAdaptiveMediaSourceDiagnosticAvailableEventArgs).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "IAdaptiveMediaSourceDiagnosticAvailableEventArgs"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAdaptiveMediaSourceDiagnosticAvailableEventArgs), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAdaptiveMediaSourceDiagnosticAvailableEventArgs), Is.EqualTo(4));
        }
    }
}
