//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TypingGame
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypingGameScore
    {
        public int ScoreId { get; set; }
        public int Correct { get; set; }
        public int InCorrect { get; set; }
        public int TotalScore { get; set; }
        public System.DateTime ResultDateTime { get; set; }
        public string ApplicationUser_Id { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
