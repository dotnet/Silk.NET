// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Unknwnbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using Silk.NET.Core;

namespace Silk.NET.Core.UnitTests;

/// <summary>Provides validation of the <see cref = "AsyncIUnknown"/> struct.</summary>
public static unsafe partial class AsyncIUnknownTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "AsyncIUnknown"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(AsyncIUnknown).GUID, Is.EqualTo(IID.AsyncIUnknown));
    }

    /// <summary>Validates that the <see cref = "AsyncIUnknown"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AsyncIUnknown>(), Is.EqualTo(sizeof(AsyncIUnknown)));
    }

    /// <summary>Validates that the <see cref = "AsyncIUnknown"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AsyncIUnknown).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AsyncIUnknown"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(AsyncIUnknown), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(AsyncIUnknown), Is.EqualTo(4));
        }
    }
}
