//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lazy.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bug
    {
        public int Id { get; set; }
        public string BugId { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string Notes { get; set; }
        public int StatusId { get; set; }
        public int WorkspaceId { get; set; }
    
        public virtual Status Status { get; set; }
        public virtual Workspace Workspace { get; set; }
    }
}