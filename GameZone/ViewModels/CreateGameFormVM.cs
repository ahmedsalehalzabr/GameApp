﻿using GameZone.Attributes;
using GameZone.Settings;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace GameZone.ViewModels
{
    public class CreateGameFormVM : GameFormVM
    {
        [AllowedExtensions(FileSettings.AllowedExtensions),
            MaxFileSize(FileSettings.MaxeFileSizeInBytes)]
        public IFormFile Cover { get; set; } = default!;
    }
}
