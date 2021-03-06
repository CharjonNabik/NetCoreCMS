﻿using NetCoreCMS.Framework.Core.Mvc.Models;
using System.Collections.Generic;

namespace NetCoreCMS.Framework.Core.Models
{
    public class NccModule : BaseModel, IBaseModel<long>
    { 
        public NccModule()
        {
            Dependencies = new List<NccModuleDependency>();
        }

        public string ModuleId { get; set; }
        public string ModuleTitle { get; set; }
        public string Description { get; set; }
        public string Category { get; set; } 
        public string Author { get; set; }
        public string WebSite { get; set; }
        
        public bool AntiForgery { get; set; }
        public string Version { get; set; }
        public string MinNccVersion { get; set; }
        public string MaxNccVersion { get; set; }        
        public string Path { get; set; }
        public string Folder { get; set; }

        public NccModuleStatus ModuleStatus { get; set; }
        public List<NccModuleDependency> Dependencies { get; set; }

        public enum NccModuleStatus
        {        
            New,
            Installed,
            UnInstalled,
            Active,
            Inactive,
            Duplicate,
            Deleted,
            InCompatible
        }
    }     
}
