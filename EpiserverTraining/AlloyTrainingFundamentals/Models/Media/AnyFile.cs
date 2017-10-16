using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTrainingFundamentals.Models.Media
{
    [ContentType(DisplayName = "Any File", GUID = "972ebfc9-c4ef-47b8-a360-f8e63bdfa06a", Description = "Use this to upload any type of file.")]
    public class AnyFile : MediaData
    {
    }
}