using System;
using System.Collections.Generic;
using System.Text;

using Silk.NET.Vulkan;

namespace VMASharp
{
    public class VulkanResultException : ApplicationException
    {
        public readonly Result? Result;

        public VulkanResultException(string message) : base(message)
        {
        }

        public VulkanResultException(string message, Exception? innerException) : base(message, innerException)
        {
        }

        public VulkanResultException(Result res) : base("Vulkan returned an API error code")
        {
            Result = res;
        }

        public VulkanResultException(string message, Result res) : base(message)
        {
            Result = res;
        }
    }

    public class AllocationException : VulkanResultException
    {
        public AllocationException(string message) : base (message)
        {
        }

        public AllocationException(string message, Exception? innerException) : base (message, innerException)
        {
        }

        public AllocationException(Result res) : base(res)
        {
        }

        public AllocationException(string message, Result res) : base (message, res)
        {
        }
    }

    public class DefragmentationException : VulkanResultException
    {
        public DefragmentationException(string message) : base(message)
        {
        }

        public DefragmentationException(Result res) : base(res)
        {
        }

        public DefragmentationException(string message, Result res) : base(message, res)
        {
        }
    }

    public class MapMemoryException : VulkanResultException
    {
        public MapMemoryException(string message) : base(message)
        {
        }

        public MapMemoryException(Result res) : base("Mapping a Device Memory block encountered an issue", res)
        {
        }

        public MapMemoryException(string message, Result res) : base(message, res)
        {
        }
    }

    public class ValidationFailedException : ApplicationException
    {
        public ValidationFailedException() : base("Validation of Allocator structures found a bug!")
        {
        }
    }
}
