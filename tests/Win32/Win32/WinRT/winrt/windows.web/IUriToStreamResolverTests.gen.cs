// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IUriToStreamResolver"/> struct.</summary>
public static unsafe partial class IUriToStreamResolverTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IUriToStreamResolver"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IUriToStreamResolver).GUID, Is.EqualTo(IID_IUriToStreamResolver));
    }

    /// <summary>Validates that the <see cref = "IUriToStreamResolver"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IUriToStreamResolver>(),
            Is.EqualTo(sizeof(IUriToStreamResolver))
        );
    }

    /// <summary>Validates that the <see cref = "IUriToStreamResolver"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IUriToStreamResolver).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IUriToStreamResolver"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IUriToStreamResolver), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IUriToStreamResolver), Is.EqualTo(4));
        }
    }
}
