﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreCMS.Modules.Cms.Models.ViewModels
{
    class NccModuleViewModel
    {
        public string ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleTitle { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
