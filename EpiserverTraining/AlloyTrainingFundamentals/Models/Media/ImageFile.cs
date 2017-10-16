using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace AlloyTrainingFundamentals.Models.Media
{
    [ContentType(DisplayName = "Image File", GUID = "172b0eac-062d-4b11-a3af-a97cdabd29a5", Description = "Use this to upload image files.")]
    [MediaDescriptor(ExtensionString = "png, jpg, jpeg, gif")]
    public class ImageFile : ImageData
    {
        
                [CultureSpecific]
                [Editable(true)]
                [Display(
                    Name = "Description",
                    Description = "Description field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 50)]
                public virtual string Description { get; set; }
         
    }
}