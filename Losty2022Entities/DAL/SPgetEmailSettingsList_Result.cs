//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    
    public partial class SPgetEmailSettingsList_Result
    {
        public int emailSettingsId { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<bool> emailAboutNewRequest { get; set; }
        public Nullable<bool> emailFromAnotherUser { get; set; }
        public Nullable<bool> systemEmailAboutExistsRequest { get; set; }
    }
}